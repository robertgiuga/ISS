using Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace VanzariClient
{
    public partial class Manage : Form
    {
        private Controller controller;
        private BindingList<Produs> produse;
        public Manage(Controller controller)
        {
            InitializeComponent();
            this.controller = controller;
            this.controller.userEvent += userEvent_handler;
            
        }

        private void userEvent_handler(object sender, VanzariEvent e)
        {
            switch (e.UserEventType)
            {
                case EventType.ADDPRODUS:
                    produseDataGridView.BeginInvoke(new ModifyProduseCallBack((list, item) =>
                    {
                        list.Add(item);
                    }), new Object[] { produse, (Produs)e.Data });
                    break;
                case EventType.DELETEPRODUS:
                    produseDataGridView.BeginInvoke(new ModifyProduseCallBack((list, item) =>
                    {
                        list.Remove(item);
                    }), new Object[] { produse, (Produs)e.Data });
                    break;
                case EventType.MODPRODUS:
                    produseDataGridView.BeginInvoke(new ModifyProduseCallBack((list, item) =>
                    {
                        int poz = list.IndexOf(item);
                        var listItem = list[poz];
                        listItem.Cantitate = item.Cantitate;
                        listItem.Denumire = item.Denumire;
                        listItem.Descriere = item.Descriere;
                        list.ResetItem(poz);
                    }), new Object[] { produse, (Produs)e.Data });
                    break;

            }
            
        }

        private delegate void ModifyProduseCallBack(BindingList<Produs> dataSource, Produs updatedProdus);

        private void Manage_Load(object sender, EventArgs e)
        {
            try
            {
                produse = new BindingList<Produs>((IList<Produs>) controller.findAllProduse()) ;
                produseDataGridView.DataSource = produse;
            }
            catch(Exception er)
            {
                MessageBox.Show(er.Message);
            }
        }

        private void adaugaButton_Click(object sender, EventArgs e)
        {
            if (produseDataGridView.SelectedRows.Count == 0)
            {
                try
                {
                    Produs produs = new Produs(0, descriereTextBox.Text, int.Parse(cantitateTextBox.Text), denumireTextBox.Text);
                    controller.AddProdus(produs);
                }
                catch (Exception er)
                {
                    MessageBox.Show(er.Message);
                }
            }
            else MessageBox.Show("Nu se poate adauga un produs selectat!");
        }

        private void modificaButton_Click(object sender, EventArgs e)
        {
            try
            {
                Produs produsSelected = produseDataGridView.SelectedRows[0].DataBoundItem as Produs;
                Produs produs = new Produs(produsSelected.Id, descriereTextBox.Text, int.Parse(cantitateTextBox.Text), denumireTextBox.Text);
                controller.UpdateProdus(produs);
            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message);
            }
        }

        private void strgeButton_Click(object sender, EventArgs e)
        {
            try
            {
                Produs produsSelected = produseDataGridView.SelectedRows[0].DataBoundItem as Produs;
                controller.DeleteProdus(produsSelected);
            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message);
            }
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            denumireTextBox.Text = "";
            descriereTextBox.Text = "";
            cantitateTextBox.Text = "";
            produseDataGridView.ClearSelection();
        }

        private void produseDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            descriereTextBox.Text = (produseDataGridView.Rows[e.RowIndex].DataBoundItem as Produs).Descriere;
            denumireTextBox.Text = (produseDataGridView.Rows[e.RowIndex].DataBoundItem as Produs).Denumire;
            cantitateTextBox.Text = (produseDataGridView.Rows[e.RowIndex].DataBoundItem as Produs).Cantitate.ToString();
            produseDataGridView.Rows[e.RowIndex].Selected = true;
        }

        private void Manage_FormClosing(object sender, FormClosingEventArgs e)
        {
            controller.LogOut();
            Application.Exit();
        }
    }
}
