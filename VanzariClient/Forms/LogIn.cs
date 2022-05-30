using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using VanzariClient.Controllers;

namespace VanzariClient
{
    public partial class LogIn : Form
    {
        private LogInController controller;
        public LogIn(LogInController controller)
        {
            this.controller = controller;
            InitializeComponent();
        }

        private void LogIn_Click(object sender, EventArgs e)
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
            catch (Exception er)
            {
                MessageBox.Show(er.Message);
            }
        }
    }
}

