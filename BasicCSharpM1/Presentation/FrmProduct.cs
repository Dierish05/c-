using Domainzzz;
using Domainzzz.enums;
using Infraestructura;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentation
{
    public partial class FrmProduct : Form
    {
        public ProductoModel productoModel;
        public FrmProduct()
        {
            productoModel = new ProductoModel();
            InitializeComponent();
            this.CenterToScreen();
        }

        private void BtnAgregarP_Click(object sender, EventArgs e)
        {
            int id;
            string name, description;
            decimal quantity, price;
            DateTime caducityDate;
            int mm, dd, yyyy;

            int.TryParse(txtId.Text, out id);
            name = txtName.Text;
            description = txtDescription.Text;
            decimal.TryParse(txtQuantity.Text, out quantity);
            decimal.TryParse(txtPrice.Text, out price);
            int.TryParse(txtMM.Text, out mm);
            int.TryParse(txtDd.Text, out dd);
            int.TryParse(txtYyyy.Text, out yyyy); 
            caducityDate = new DateTime(yyyy, mm, dd);

            Producto product = new Producto()//--------------------------
            {
                Id = id,
                Name = name,
                Description = description,
                Quantity = quantity,
                Price = price,
                CaducityDate = caducityDate,
                unidadMedida = (UnidadMedida)Enum.GetValues(typeof(UnidadMedida)).GetValue(cmbUnidadMedida.SelectedIndex)
            };
            productoModel.AddProduct(product);
            //richTextBox1.Text = product.ToString;
            //productoModel.GetProductosAsJson(product);
            //string JsonProduct = JsonConvert.SerializeObject(product);
            //PrintInformacionMessage(JsonProduct);

            MessageBox.Show($@"
                                Id: {product.unidadMedida}
                                Nombre: {product.unidadMedida}
                                Descripcion:{product.Description}
                                Cantidad: {product.Quantity}
                                Precio: {product.Price}
                                Fecha de caducidad: {product.CaducityDate}
                                Unidad de medida: {product.unidadMedida}");

            ClearTextboxes();
        }

        private void PrintInformacionMessage(string message)
        {
            MessageBox.Show(message, "Mensaje de Información", MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }

        private void ClearTextboxes()
        {
            txtId.Text = string.Empty;
            txtName.Text = string.Empty;
            txtDescription.Text = string.Empty;
            txtQuantity.Text = string.Empty;
            txtPrice.Text = string.Empty;
            txtMM.Text = string.Empty;
            txtDd.Text = string.Empty;
            txtYyyy.Text = string.Empty;
            txtId.Focus();
        }

        private void btnJson_Click(object sender, EventArgs e)
        {
            string[] jsonArr = productoModel.GetProductosAsJson();
            string aux = string.Empty;

            for (int i = 0; i < jsonArr.Length; i++)
            {
                aux = $@"{aux}
                         {jsonArr[i]}";
            }

            richTextBox1.Text = aux;
        }

        private void btnOrdenar_Click(object sender, EventArgs e)
        {
            Producto[] ordenar = productoModel.OrdenarByPrecio();
            string aux_ord = string.Empty;

            for (int i = 0; i < ordenar.Length; i++)
            {
                aux_ord = $@"{aux_ord}
                                    {i + 1}. {ordenar[i].Name}
                                    {i + 1}. {ordenar[i].Price}";
            }

            PrintInformacionMessage(aux_ord);
        }

        private void btnRango_Click(object sender, EventArgs e)
        {
            decimal mayor, menor;

            decimal.TryParse(txtMayor.Text, out mayor);
            decimal.TryParse(txtMenor.Text, out menor);
            
            Producto[] rango = productoModel.GetProductosByRangoPrecio(menor, mayor);
            string aux_arr = string.Empty;

            for (int i = 0; i < rango.Length; i++)
            {
                aux_arr = $@"{aux_arr}
                                    {i + 1}. {rango[i].Name}
                                    {i + 1}. {rango[i].Price}";
            }

            PrintInformacionMessage(aux_arr);
        }

        private void btnCaducityDate_Click(object sender, EventArgs e)
        {
            int mmB, ddB, yyyyB;
            DateTime caducityDateB;

            int.TryParse(txtMMB.Text, out mmB);
            int.TryParse(txtddB.Text, out ddB);
            int.TryParse(txtyyyyB.Text, out yyyyB);
            caducityDateB = new DateTime(yyyyB, mmB, ddB);

            Producto[] porCaducidad = productoModel.GetProductosByCaducity(caducityDateB);
            string aux_cad = string.Empty;

            for (int i = 0; i < porCaducidad.Length; i++)
            {
                aux_cad = $@"{aux_cad}
                                    {i + 1}. {porCaducidad[i].Id}
                                    {i + 1}. {porCaducidad[i].Name}
                                    {i + 1}. {porCaducidad[i].Quantity}";
            }
            PrintInformacionMessage(aux_cad);
        }

        private void btnUnidadmedidaB_Click(object sender, EventArgs e)
        {
            Producto[] medida = productoModel.GetProductosByMedida(cmbunidadMedidaB.SelectedIndex);
            string aux_med = string.Empty;

            for (int i = 0; i < medida.Length; i++)
            {
                aux_med = $@"{aux_med}
                                    {i + 1}. {medida[i].Name}
                                    {i + 1}. {medida[i].unidadMedida}";
            }

            PrintInformacionMessage(aux_med);
        }
    }
}
