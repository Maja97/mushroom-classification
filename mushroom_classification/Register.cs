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
    public partial class Register : MetroForm
    {
        UsersEntities context;
    
        public Register()
        {
            InitializeComponent();
            context = new UsersEntities();
        }
        
        
        private void btn_register_Click(object sender, EventArgs e)
        {
            if (textBoxUsernameRegister.Text != "" && textBoxPassword1Register.Text != "" 
                && textBoxPassword2Register.Text != "" && textBoxPassword1Register.Text == textBoxPassword2Register.Text)
            {
                var username = textBoxUsernameRegister.Text;
                var password = textBoxPassword1Register.Text;

                if (context.User1.Where(y => y.Username == username).Count() == 0)
                {
                    User1 user = new User1
                    {
                        Username = username,
                        Password = password
                    };
                    context.User1.Add(user);
                    context.SaveChanges();

                    MessageBox.Show("Registration successful!");

                    this.Hide();
                    Login loginForm = new Login();
                    loginForm.ShowDialog();
                    this.Close();
                }
                else MessageBox.Show("Username already exists!");
            }
            else
            {
                if (textBoxUsernameRegister.Text == "")
                    MessageBox.Show("Enter a valid username");
                else if (textBoxPassword1Register.Text != textBoxPassword2Register.Text)
                    MessageBox.Show("Passwords must match!");
                else if (textBoxPassword1Register.Text == "" || textBoxPassword2Register.Text == "")
                    MessageBox.Show("Password can't be an empty field");
            }

        }

        private void label_backToLogin_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login loginForm = new Login();
            loginForm.ShowDialog();
            this.Close();
        }
    }
}
