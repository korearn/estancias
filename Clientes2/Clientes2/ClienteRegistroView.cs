using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Clientes2
{
    public partial class ClienteRegistroView : Form
    {
        private int id_cliente;
        private Cliente clienteEditar;
         
        public ClienteRegistroView()
        {
            InitializeComponent(); 
        }

        public ClienteRegistroView(int ID_Cliente) : this()
        {
            id_cliente = ID_Cliente;

            clienteEditar = ClienteController.ObtenerClientesPorID(id_cliente);
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Cliente nuevoCliente = new Cliente(); 
            nuevoCliente.RFC = txtRFC.Text.Trim();
            nuevoCliente.Nombre = txtNombre.Text.Trim();
            nuevoCliente.Paterno = txtPaterno.Text.Trim();
            nuevoCliente.Materno = txtMaterno.Text.Trim();
            if (chkActivo.Checked)
            {
                nuevoCliente.Activo = 1;
            } 
            if (clienteEditar != null)
            {
                nuevoCliente.ID_Cliente = clienteEditar.ID_Cliente;
                ClienteController.ActualizarCliente(nuevoCliente);
                MessageBox.Show("Se actualizo el cliente");
                
            }
            else
            {
                ClienteController.GuardarCliente(nuevoCliente);
                MessageBox.Show("Se guardo el cliente");
            }      
            LimpiarRegistros();

            this.Close();                     
        }

        private void LimpiarRegistros ()
        {
            txtRFC.Text = "";
            txtNombre.Text = "";
            txtPaterno.Text = "";
            txtMaterno.Text = "";
        }

        private void ClienteRegistroView_Load(object sender, EventArgs e)
        {

            if (clienteEditar != null)
            {
                txtRFC.Text = clienteEditar.RFC;
                txtNombre.Text = clienteEditar.Nombre;
                txtPaterno.Text = clienteEditar.Paterno;
                txtMaterno.Text = clienteEditar.Materno;
                chkActivo.Checked = clienteEditar.Activo > 0 ;
            }
        }



        private void txtRFC_TextChanged(object sender, EventArgs e)
        {
            errorProvider1.SetError(txtRFC, "Ingresa RFC");
        }

        /*
        private void txtRFC_Validating(object sender, CancelEventArgs e)
        {
            ValidarRFC();
        }
        
        
        private bool ValidarRFC()
        {
            bool estado = true;
            if(txtRFC.Text == "")
            {
                errorProvider1.SetError(txtRFC,"Ingresa RFC");
                estado = false;
            }
            else
            {
                errorProvider1.SetError(txtRFC,"");
                return estado;
            }
        }
        */
    }
}
