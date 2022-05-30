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
    public partial class Comenzi : Form
    {
        private AngajatController Controller;
        private BindingList<Comanda> comenzi;
        bool selectedCom = false;
        Comanda SelectedCom = null;
        public Comenzi(AngajatController controller)
        {
            InitializeComponent();
            this.Controller = controller;
            statusComboBox.DataSource =new List<Status>() {Status.delivered, Status.finish, Status.pending};
            Controller.userEvent += userEvent_handler;
        }

        private void userEvent_handler(object sender, VanzariEvent e)
        {
            if (e.UserEventType == EventType.UPDATECOMANDA)
            {
                comenziDataGridView.BeginInvoke(new ModifyComenziCallBack((lista, comanda) =>
                {
                    int poz = lista.IndexOf(comanda);
                    var listItem = lista[poz];
                    listItem.Status = (Status)comanda.Status;
                    lista.ResetItem(poz);

                }), new Object[] { comenzi, e.Data });
            }
        }
        private delegate void ModifyComenziCallBack(BindingList<Comanda> lista, Comanda comanda);

        private void Comenzi_Load(object sender, EventArgs e)
        {
            comenzi= new BindingList<Comanda>((IList<Comanda>)Controller.FindAllComenzi());
            comenziDataGridView.DataSource = comenzi;
        }

        private void comenziDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (selectedCom)
                {
                    Comanda comanda = SelectedCom;
                    comanda.Status = (Status)statusComboBox.SelectedItem;
                    Controller.UpdateComanda(comanda);
                }
                else MessageBox.Show("Selectati o comanda");
            }catch(Exception er)
            {
                MessageBox.Show(er.Message);
            }
        }

        private void comenziDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            idTextBox.Text = (comenziDataGridView.Rows[e.RowIndex].DataBoundItem as Comanda).Id.ToString();
            descriereTextBox.Text = (comenziDataGridView.Rows[e.RowIndex].DataBoundItem as Comanda).Descriere;
            statusComboBox.SelectedItem = (comenziDataGridView.Rows[e.RowIndex].DataBoundItem as Comanda).Status;
            selectedCom = true;
            SelectedCom = (comenziDataGridView.Rows[e.RowIndex].DataBoundItem as Comanda);
        }
    }
}
