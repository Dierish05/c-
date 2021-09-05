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
            Producto product = new Producto()
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
            productoModel.GetProductosAsJson(product);
            string JsonProduct = JsonConvert.SerializeObject(product);
            PrintInformacionMessage(JsonProduct);
        }

        private void PrintInformacionMessage(string message)
        {
            MessageBox.Show(message, "Mensaje de Información", MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }

    }
}
