using MetroFramework.Forms;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Formatting;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mushroom_classification
{
    public partial class Main : MetroForm
    {
        UsersEntities context;
        public static string label = "", probability = "";
        int userID = Login.userId;
        public Main()
        {
            InitializeComponent();
            context = new UsersEntities();
            this.ControlBox = false;
            this.FormBorderStyle = FormBorderStyle.None;
        }
        
        public class StringTable
        {
            public string[] ColumnNames { get; set; }
            public string[,] Values { get; set; }
        }

        public class Mushroom
        {
            public Nullable<int> UserID { get; set; }
            public string edible { get; set; }
            public string bruises { get; set; }
            public string gill_spacing { get; set; }
            public string gill_size { get; set; }
            public string stalk_surface_above_ring { get; set; }
            public string stalk_surface_below_ring { get; set; }
            public string ring_type { get; set; }
            public string population { get; set; }
            public string habitat { get; set; }

            public string[,] GetValues()
            {
                return new string[,] { { "e", bruises, gill_spacing, gill_size, stalk_surface_above_ring, stalk_surface_below_ring , ring_type, population, habitat } };
            }
           
        }

        static async Task InvokeRequestResponseService(Mushroom mushroom)
        {
            using (var client = new HttpClient())
            {
                var scoreRequest = new
                {

                    Inputs = new Dictionary<string, StringTable>() {
                        {
                            "input1",
                            new StringTable()
                            {
                                ColumnNames = new string[] {"edible", "bruises", "gill-spacing", "gill-size", "stalk-surface-above-ring", "stalk-surface-below-ring", "ring-type", "population", "habitat"},
                                Values = mushroom.GetValues()
                            }
                        },
                    },
                    GlobalParameters = new Dictionary<string, string>()
                    {
                    }
                };
                const string apiKey = "lBLjaVg7cFDcy/VhPgQn5QTKOq+8dvn4BEYXAVJl36IV3hYHaQrqrnw0XT1MI5OEqVc6PAyy5OZoVFbveByoQA=="; // Replace this with the API key for the web service
                client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", apiKey);

                client.BaseAddress = new Uri("https://ussouthcentral.services.azureml.net/workspaces/858867282d184328afdff5d108d15379/services/8c08ec06b4994437b285bb56363a282c/execute?api-version=2.0&details=true");
                
                HttpResponseMessage response = await client.PostAsJsonAsync("", scoreRequest).ConfigureAwait(false);
                
                if (response.IsSuccessStatusCode)
                {
                    var result = await response.Content.ReadAsStringAsync();
                    Console.WriteLine("Result: {0}", result);
                    JObject jObject = JObject.Parse(result);
                    label = jObject.SelectToken("$.Results.output1.value.Values[0][0]").ToString();
                    probability = jObject.SelectToken("$.Results.output1.value.Values[0][1]").ToString();
                    
                }
                else
                {
                    Console.WriteLine(string.Format("The request failed with status code: {0}", response.StatusCode));

                    Console.WriteLine(response.Headers.ToString());

                    string responseContent = await response.Content.ReadAsStringAsync();
                    Console.WriteLine(responseContent);
                    MessageBox.Show(responseContent);
                }
            }
        }
        
        private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        
        private void btn_stats_Click(object sender, EventArgs e)
        {
            updateStats();
            metroPanel2.Visible = true;
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            metroPanel2.Visible = false;
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            if (AddMushroom.mushroom_added == true)
            {
                Mushroom newMushroom = getResults();
                mushroom_classification.Mushroom mushroom = new mushroom_classification.Mushroom(newMushroom, label);
                context.Mushrooms.Add(mushroom);
                context.SaveChanges();
                changeLabels();
            }
        }

        private Mushroom getResults()
        {
            Mushroom newMushroom = AddMushroom.mushroom;
            newMushroom.UserID = userID;
            InvokeRequestResponseService(newMushroom).Wait();
            return newMushroom;
        }

        private void Main_Load(object sender, EventArgs e)
        {
                changeLabels();
                updateStats();
        }
        
        private void btn_results_Click(object sender, EventArgs e)
        {
            getResults();
           
            MessageBox.Show("Last added mushroom\nPredicted label: " + label + "\nProbability: " + probability);
        }
        
        private void btn_edit_Click(object sender, EventArgs e)
        {
            this.Hide();
            AddMushroom addMushroomForm = new AddMushroom();
            addMushroomForm.ShowDialog();
            this.Close();
        }

        private void updateStats()
        {

            chart1.Series["s1"].Points.Clear();
            chart1.Series["s1"].Points.AddXY("Edible", getEdible());
            chart1.Series["s1"].Points.AddXY("Poisonous", getPoisonous());

            mushroomGrid.Rows.Clear();
            foreach (mushroom_classification.Mushroom m in context.Mushrooms.Where(y => y.UserID == userID))
            {
                mushroomGrid.Rows.Add(m.edible, m.bruises, m.gill_spacing, m.gill_size, m.stalk_surface_above_ring, m.stalk_surface_below_ring, m.ring_type, m.population, m.habitat);
            }
        }
        
        private void changeLabels()
        {

            int number = context.Mushrooms.Where(y => y.UserID == userID).Count();
            labelMushroomNumber.Text = number.ToString();
            int edible = getEdible();
            labelEdibleNumber.Text = edible.ToString();
            int poisonous = getPoisonous();
            labelPoisonousNumber.Text = poisonous.ToString();

        }

        private int getPoisonous()
        {
            return context.Mushrooms.Where(y => y.UserID == userID && y.edible == "p").Count();
        }

        private int getEdible()
        {
            return context.Mushrooms.Where(y => y.UserID == Login.userId && y.edible == "e").Count();
        }
    }
}
