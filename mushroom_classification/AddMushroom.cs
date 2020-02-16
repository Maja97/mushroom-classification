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
    public partial class AddMushroom : MetroForm
    {
        public static Main.Mushroom mushroom = new Main.Mushroom();
        public static bool mushroom_added = false;
        public AddMushroom()
        {
            InitializeComponent();
        }
        
        private void btn_next1_Click(object sender, EventArgs e)
        {
            if (radioButton_hasBruises.Checked)
                mushroom.bruises = "t";
            else mushroom.bruises = "f";
            panelGillSpacing.Visible = true;
        }

        private void btn_next2_Click(object sender, EventArgs e)
        {
            if (radioButton_close.Checked)
                mushroom.gill_spacing = "c";
            else mushroom.gill_spacing = "w";
            panelGillSize.Visible = true;
        }

        private void btn_next3_Click(object sender, EventArgs e)
        {
            if (radioButton_broad.Checked)
                mushroom.gill_size = "b";
            else mushroom.gill_size = "n";
            panelStalkAboveRing.Visible = true;
        }

        private void btn_next4_Click(object sender, EventArgs e)
        {
            if (radioButtonSmooth.Checked)
                mushroom.stalk_surface_above_ring = "s";
            else if (radioButtonSilky.Checked)
                mushroom.stalk_surface_above_ring = "k";
            else if (radioButtonScaly.Checked)
                mushroom.stalk_surface_above_ring = "y";
            else mushroom.stalk_surface_above_ring = "f";
            panelStalkBelowRing.Visible = true;
        }

        private void btn_next5_Click(object sender, EventArgs e)
        {
            if (radioButtonSmooth1.Checked)
                mushroom.stalk_surface_below_ring = "s";
            else if (radioButtonSilky1.Checked)
                mushroom.stalk_surface_below_ring = "k";
            else if (radioButtonScaly1.Checked)
                mushroom.stalk_surface_below_ring = "y";
            else mushroom.stalk_surface_below_ring = "f";
            panelRingType.Visible = true;
        }

        private void btn_next6_Click(object sender, EventArgs e)
        {
            if (radioButtonPendant.Checked)
                mushroom.ring_type = "p";
            else if (radioButtonEvanescent.Checked)
                mushroom.ring_type = "e";
            else if (radioButtonFlaring.Checked)
                mushroom.ring_type = "f";
            else if (radioButtonLarge.Checked)
                mushroom.ring_type = "l";
            else mushroom.ring_type = "n";
            panelPopulation.Visible = true;
        }

        private void btn_next7_Click(object sender, EventArgs e)
        {
            if (radioButtonSolitary.Checked)
                mushroom.population = "y";
            else if (radioButtonSeveral.Checked)
                mushroom.population = "v";
            else if (radioButtonScattered.Checked)
                mushroom.population = "s";
            else if (radioButtonNumerous.Checked)
                mushroom.population = "n";
            else if (radioButtonAbundant.Checked)
                mushroom.population = "a";
            else mushroom.population = "c";
            panelHabitat.Visible = true;
        }

        private void btn_done_Click(object sender, EventArgs e)
        {
            if (radioButtonWoods.Checked)
                mushroom.habitat = "d";
            else if (radioButtonGrasses.Checked)
                mushroom.habitat = "g";
            else if (radioButtonPaths.Checked)
                mushroom.habitat = "p";
            else if (radioButtonLeaves.Checked)
                mushroom.habitat = "l";
            else if (radioButtonUrban.Checked)
                mushroom.habitat = "u";
            else if (radioButtonMeadows.Checked)
                mushroom.habitat = "m";
            else mushroom.habitat = "w";
            mushroom_added = true;
            this.Hide();
            Main mainForm = new Main();
            mainForm.ShowDialog();
            this.Close();
        }
    }
}
