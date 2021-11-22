using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Clientes2
{
    public partial class PrincipalView : Form
    {
        private BindingSource binding;

        public PrincipalView()
        {
            InitializeComponent();            
        }

        private void PrincipalView_Load(object sender, EventArgs e)
        {
            binding = new BindingSource();
            grdClientes.DataSource = binding;
            CargarDatos();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            ClienteRegistroView form = new ClienteRegistroView();
            form.ShowDialog(this);

            CargarDatos();
        }

        public void CargarDatos()
        {
            binding.DataSource = ClienteController.ObtenerClientes();
        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            DataGridViewSelectedRowCollection rows =  grdClientes.SelectedRows;
            if (rows.Count> 0)
            {
                int ID_Cliente = int.Parse(rows[0].Cells["colID_Cliente"].Value.ToString());

                ClienteRegistroView form = new ClienteRegistroView(ID_Cliente);
                form.ShowDialog(this);
                CargarDatos();
            }       
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            DataGridViewSelectedRowCollection rows = grdClientes.SelectedRows;
            if (rows.Count > 0)
            {
                int ID_Cliente = int.Parse(rows[0].Cells["colID_Cliente"].Value.ToString());

                ClienteController.EliminarCliente(ID_Cliente);

                CargarDatos();
            }
        }        
    }
}
