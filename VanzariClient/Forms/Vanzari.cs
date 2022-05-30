using Model;
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
    public partial class Vanzari : Form
    {
        private AngajatController Controller;
        private BindingList<Produs> produse;
        private List<ComandaItem> comenzi;
        public Vanzari(AngajatController Controller)
        {
            this.Controller = Controller;
            comenzi = new List<ComandaItem>();
            InitializeComponent();
            Controller.userEvent += userEvent_handler;
        }

        private void userEvent_handler(object sender, VanzariEvent e)
        {
            if (e.UserEventType == EventType.RELOADPRODUSE)
            {
                comenziDataGridView.BeginInvoke(new Action(() => {
                    try
                    {
                        produse = new BindingList<Produs>((IList<Produs>)Controller.FindAllProduse());
                        produseDataGridView.DataSource = produse;
                    }
                    catch (Exception er)
                    {
                        MessageBox.Show(er.Message);
                    }
                }));
            }
        }

        private void Vanzari_Load(object sender, EventArgs e)
        {
            try
            {
                produse = new BindingList<Produs>((IList<Produs>)Controller.FindAllProduse());
                produseDataGridView.DataSource = produse;
            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message);
            }
        }

        private void produseDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            descriereTextBox.Tag= (produseDataGridView.Rows[e.RowIndex].DataBoundItem as Produs).Id;
            descriereTextBox.Text = (produseDataGridView.Rows[e.RowIndex].DataBoundItem as Produs).Descriere;
            denumireTextBox.Text = (produseDataGridView.Rows[e.RowIndex].DataBoundItem as Produs).Denumire;
            produseDataGridView.Rows[e.RowIndex].Selected = true;
        }

        private void clearBtn_Click(object sender, EventArgs e)
        {
            comenziDataGridView.DataSource = null;
            comenzi.Clear();
        }

        private void trimiteComandaBtn_Click(object sender, EventArgs e)
        {
            if (!descComadanTextBox.Text.Equals("")) {
                Comanda comanda = new Comanda();
                comanda.Descriere = descComadanTextBox.Text;
                comanda.Status = Status.pending;
                Controller.SendOrder(comanda, comenzi);
                comenziDataGridView.DataSource = null;
                comenzi.Clear();
                denumireTextBox.Text = "";
                descComadanTextBox.Text = "";
                cantitateTextBox.Text = "";
                descriereTextBox.Text = "";
                MessageBox.Show("Comanda trimisa cu succes!");
            }
            else MessageBox.Show("Introduceti descrire valida!");
        }

        private void viewComenziBtn_Click(object sender, EventArgs e)
        {
            Comenzi comenziForm = new Comenzi(Controller);
            comenziForm.Show();
        }

        private void adaugaCosBtn_Click(object sender, EventArgs e)
        {
            try
            {
                ComandaItem comandaItem = new ComandaItem(int.Parse(descriereTextBox.Tag.ToString()), int.Parse(cantitateTextBox.Text));
                comenzi.Add(comandaItem);
                comenziDataGridView.DataSource = null;
                comenziDataGridView.DataSource = comenzi;

            }
            catch (Exception)
            {
                MessageBox.Show("Cantitate invalida!");
            }
        }
    }
}
