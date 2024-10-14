using AccesoDatos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace insertarClienteDapper
{
    public partial class Form1 : Form
    {

        SuppliersRepository suppliersR = new SuppliersRepository();

        public Form1()
        {
            InitializeComponent();
        }

        private void btnObtenerTodo_Click(object sender, EventArgs e)
        {
            var proveedor = suppliersR.ObtenerTodos();
            dgvProveedor.DataSource = proveedor;
        }

        private void btnObtenerPorId_Click(object sender, EventArgs e)
        {
            int idProveedor;
            if (!int.TryParse(tbxObtenerPorId.Text, out idProveedor))
            {

                MessageBox.Show("Por favor, ingrese un número entero válido.", "Error de formato", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; 
            }
            var proveedor = suppliersR.obtenerPorId(tbxObtenerPorId.Text);
            dgvProveedor.DataSource = new List<Suppliers> { proveedor };

            if (proveedor != null)
            {
                rellenarForm(proveedor);
            }
        }

        private void rellenarForm(Suppliers suppliers)
        {
            tbxCompanyName.Text = suppliers.CompanyName;
            tbxContactName.Text = suppliers.ContactName;
            tbxContactTitle.Text = suppliers.ContactTitle;
            tbxAddress.Text = suppliers.Address;
            tbxCity.Text = suppliers.City;
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            var proveedorActualizado = crearProveedor();
            var actualizada = suppliersR.actualizarProveedor(proveedorActualizado);
            var proveedor = suppliersR.obtenerPorId(proveedorActualizado.SupplierID);
            dgvProveedor.DataSource = new List<Suppliers > { proveedor }; 

            MessageBox.Show($"Filas actualizadas {actualizada}, {proveedorActualizado.SupplierID} ");
        }

        private Suppliers crearProveedor()
        {
            var nuevo = new Suppliers
            {   
                SupplierID = tbxObtenerPorId.Text,
                CompanyName = tbxCompanyName.Text,
                ContactName = tbxContactName.Text,
                ContactTitle = tbxContactTitle.Text,
                Address = tbxAddress.Text,
                City = tbxCity.Text,
            };

            return nuevo;
        }
    }
}
