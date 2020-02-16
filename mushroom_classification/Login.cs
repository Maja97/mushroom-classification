using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mushroom_classification
{
    public partial class Login : MetroForm
    {
        UsersEntities context;
        public static int userId;
        public Login()
        {
            InitializeComponent();
            context = new UsersEntities();
        }
        

        private void btn_login_Click(object sender, EventArgs e)
        {
            try
            {
                var username = textBoxUsernameLogin.Text;
                var password = textBoxPasswordLogin.Text;

                var user = context.User1.FirstOrDefault(y => y.Username == username && y.Password == password);
                userId = user.Id;

                MessageBox.Show("Login successful!");

                this.Hide();
                Main mainForm = new Main();
                mainForm.ShowDialog();

                this.Show();

            }

            catch
            {
                MessageBox.Show("Login failed. Try again.");
            }
        }

        private void label_register_Click(object sender, EventArgs e)
        {
            this.Hide();
            Register registerForm = new Register();
            registerForm.ShowDialog();
        }
    }
}
