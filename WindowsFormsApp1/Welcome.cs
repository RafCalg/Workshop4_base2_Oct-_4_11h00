using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Welcome : Form
    {
        private string username;
        private string password;

        public Welcome()
        {
            InitializeComponent();
        }

        /* only for test*/
        //private void loginButton_Click(object sender, EventArgs e)
        //{
        //    MainForm mf = new MainForm();

        //    mf.Show();
        //}


        private void loginButton_Click(object sender, EventArgs e)
        {
            if (isValid(usernameTextBox.Text.Trim(), passwordTextBox.Text.Trim()))
            {
                username = usernameTextBox.Text.Trim();
                password = passwordTextBox.Text.Trim();

                using (TravelExpertsLINQDataContext dbContext = new TravelExpertsLINQDataContext())
                {
                    var login = dbContext.Agents.Where(agent => agent.Username == username
                                                       && agent.Password == password).FirstOrDefault();

                    if (login != null)
                    {
                        MainForm mf = new MainForm();
                        mf.Show();
                    }
                    else
                    {
                        MessageBox.Show("Username or Password is not correct");
                        return;
                    }
                }
            }
            else
            {
                MessageBox.Show("Please enter valid username and password");
            }
        }


        private bool isValid (string username, string password)
        {
            return (!string.IsNullOrEmpty(username) && !string.IsNullOrEmpty(password)) ? true : false;
        }

        
    }
}
