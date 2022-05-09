using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace VanzariClient
{
    public partial class LogIn : Form
    {
        private Controller controller;
        public LogIn(Controller controller)
        {
            this.controller = controller;
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void LogIn_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (userNameTextBox.Text != "" && passwordTextBox.Text != "")
                {
                    controller.LogIn(new Model.Angajat("", userNameTextBox.Text, passwordTextBox.Text, 0));
                    this.Hide();
                }
                else
                    MessageBox.Show("Invalid credentials");
            }
            catch(Exception er)
            {
                MessageBox.Show(er.Message);
            }
            

        }

        
    }
}

