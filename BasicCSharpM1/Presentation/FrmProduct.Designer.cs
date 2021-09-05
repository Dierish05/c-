namespace Presentation
{
    partial class FrmProduct
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnAgregarP = new System.Windows.Forms.Button();
            this.lblid = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblDescription = new System.Windows.Forms.Label();
            this.lblQuantity = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.lblCaducityDate = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblyyyy = new System.Windows.Forms.Label();
            this.lbldd = new System.Windows.Forms.Label();
            this.lblMM = new System.Windows.Forms.Label();
            this.txtYyyy = new System.Windows.Forms.TextBox();
            this.txtDd = new System.Windows.Forms.TextBox();
            this.cmbUnidadMedida = new System.Windows.Forms.ComboBox();
            this.lblUnidadMedida = new System.Windows.Forms.Label();
            this.txtMM = new System.Windows.Forms.TextBox();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.txtQuantity = new System.Windows.Forms.TextBox();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtId = new System.Windows.Forms.TextBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAgregarP
            // 
            this.btnAgregarP.Location = new System.Drawing.Point(16, 320);
            this.btnAgregarP.Margin = new System.Windows.Forms.Padding(4);
            this.btnAgregarP.Name = "btnAgregarP";
            this.btnAgregarP.Size = new System.Drawing.Size(100, 28);
            this.btnAgregarP.TabIndex = 0;
            this.btnAgregarP.Text = "Agregar";
            this.btnAgregarP.UseVisualStyleBackColor = true;
            this.btnAgregarP.Click += new System.EventHandler(this.BtnAgregarP_Click);
            // 
            // lblid
            // 
            this.lblid.AutoSize = true;
            this.lblid.Location = new System.Drawing.Point(8, 41);
            this.lblid.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblid.Name = "lblid";
            this.lblid.Size = new System.Drawing.Size(106, 17);
            this.lblid.TabIndex = 1;
            this.lblid.Text = "Id del producto:";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(8, 82);
            this.lblName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(145, 17);
            this.lblName.TabIndex = 2;
            this.lblName.Text = "Nombre del producto:";
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Location = new System.Drawing.Point(8, 116);
            this.lblDescription.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(169, 17);
            this.lblDescription.TabIndex = 3;
            this.lblDescription.Text = "Descripcion del producto:";
            // 
            // lblQuantity
            // 
            this.lblQuantity.AutoSize = true;
            this.lblQuantity.Location = new System.Drawing.Point(8, 151);
            this.lblQuantity.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(151, 17);
            this.lblQuantity.TabIndex = 4;
            this.lblQuantity.Text = "Cantidad del producto:";
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Location = new System.Drawing.Point(8, 185);
            this.lblPrice.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(135, 17);
            this.lblPrice.TabIndex = 5;
            this.lblPrice.Text = "Precio del producto:";
            // 
            // lblCaducityDate
            // 
            this.lblCaducityDate.AutoSize = true;
            this.lblCaducityDate.Location = new System.Drawing.Point(8, 219);
            this.lblCaducityDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCaducityDate.Name = "lblCaducityDate";
            this.lblCaducityDate.Size = new System.Drawing.Size(136, 17);
            this.lblCaducityDate.TabIndex = 6;
            this.lblCaducityDate.Text = "fecha de caducidad:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblyyyy);
            this.groupBox1.Controls.Add(this.lbldd);
            this.groupBox1.Controls.Add(this.lblMM);
            this.groupBox1.Controls.Add(this.txtYyyy);
            this.groupBox1.Controls.Add(this.txtDd);
            this.groupBox1.Controls.Add(this.cmbUnidadMedida);
            this.groupBox1.Controls.Add(this.lblUnidadMedida);
            this.groupBox1.Controls.Add(this.txtMM);
            this.groupBox1.Controls.Add(this.txtPrice);
            this.groupBox1.Controls.Add(this.txtQuantity);
            this.groupBox1.Controls.Add(this.txtDescription);
            this.groupBox1.Controls.Add(this.txtName);
            this.groupBox1.Controls.Add(this.txtId);
            this.groupBox1.Controls.Add(this.lblid);
            this.groupBox1.Controls.Add(this.lblCaducityDate);
            this.groupBox1.Controls.Add(this.lblName);
            this.groupBox1.Controls.Add(this.lblPrice);
            this.groupBox1.Controls.Add(this.lblDescription);
            this.groupBox1.Controls.Add(this.lblQuantity);
            this.groupBox1.Location = new System.Drawing.Point(16, 28);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(501, 284);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos del producto.";
            // 
            // lblyyyy
            // 
            this.lblyyyy.AutoSize = true;
            this.lblyyyy.Location = new System.Drawing.Point(334, 219);
            this.lblyyyy.Name = "lblyyyy";
            this.lblyyyy.Size = new System.Drawing.Size(36, 17);
            this.lblyyyy.TabIndex = 19;
            this.lblyyyy.Text = "yyyy";
            // 
            // lbldd
            // 
            this.lbldd.AutoSize = true;
            this.lbldd.Location = new System.Drawing.Point(257, 219);
            this.lbldd.Name = "lbldd";
            this.lbldd.Size = new System.Drawing.Size(24, 17);
            this.lbldd.TabIndex = 18;
            this.lbldd.Text = "dd";
            // 
            // lblMM
            // 
            this.lblMM.AutoSize = true;
            this.lblMM.Location = new System.Drawing.Point(184, 219);
            this.lblMM.Name = "lblMM";
            this.lblMM.Size = new System.Drawing.Size(30, 17);
            this.lblMM.TabIndex = 17;
            this.lblMM.Text = "MM";
            // 
            // txtYyyy
            // 
            this.txtYyyy.Location = new System.Drawing.Point(376, 214);
            this.txtYyyy.Name = "txtYyyy";
            this.txtYyyy.Size = new System.Drawing.Size(69, 22);
            this.txtYyyy.TabIndex = 16;
            // 
            // txtDd
            // 
            this.txtDd.Location = new System.Drawing.Point(287, 214);
            this.txtDd.Name = "txtDd";
            this.txtDd.Size = new System.Drawing.Size(41, 22);
            this.txtDd.TabIndex = 15;
            // 
            // cmbUnidadMedida
            // 
            this.cmbUnidadMedida.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbUnidadMedida.FormattingEnabled = true;
            this.cmbUnidadMedida.Items.AddRange(new object[] {
            "litros",
            "milimetros",
            "libras",
            "gramos",
            "kilogramos"});
            this.cmbUnidadMedida.Location = new System.Drawing.Point(187, 247);
            this.cmbUnidadMedida.Margin = new System.Windows.Forms.Padding(4);
            this.cmbUnidadMedida.Name = "cmbUnidadMedida";
            this.cmbUnidadMedida.Size = new System.Drawing.Size(258, 24);
            this.cmbUnidadMedida.TabIndex = 14;
            // 
            // lblUnidadMedida
            // 
            this.lblUnidadMedida.AutoSize = true;
            this.lblUnidadMedida.Location = new System.Drawing.Point(8, 254);
            this.lblUnidadMedida.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUnidadMedida.Name = "lblUnidadMedida";
            this.lblUnidadMedida.Size = new System.Drawing.Size(127, 17);
            this.lblUnidadMedida.TabIndex = 13;
            this.lblUnidadMedida.Text = "Unidad de medida:";
            // 
            // txtMM
            // 
            this.txtMM.Location = new System.Drawing.Point(221, 214);
            this.txtMM.Margin = new System.Windows.Forms.Padding(4);
            this.txtMM.Name = "txtMM";
            this.txtMM.Size = new System.Drawing.Size(29, 22);
            this.txtMM.TabIndex = 12;
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(187, 176);
            this.txtPrice.Margin = new System.Windows.Forms.Padding(4);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(258, 22);
            this.txtPrice.TabIndex = 11;
            // 
            // txtQuantity
            // 
            this.txtQuantity.Location = new System.Drawing.Point(187, 143);
            this.txtQuantity.Margin = new System.Windows.Forms.Padding(4);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(258, 22);
            this.txtQuantity.TabIndex = 10;
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(187, 107);
            this.txtDescription.Margin = new System.Windows.Forms.Padding(4);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(258, 22);
            this.txtDescription.TabIndex = 9;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(187, 74);
            this.txtName.Margin = new System.Windows.Forms.Padding(4);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(258, 22);
            this.txtName.TabIndex = 8;
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(187, 32);
            this.txtId.Margin = new System.Windows.Forms.Padding(4);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(258, 22);
            this.txtId.TabIndex = 7;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(539, 31);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(285, 281);
            this.richTextBox1.TabIndex = 8;
            this.richTextBox1.Text = "";
            // 
            // FrmProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(861, 491);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnAgregarP);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmProduct";
            this.Text = "Producto";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAgregarP;
        private System.Windows.Forms.Label lblid;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.Label lblQuantity;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label lblCaducityDate;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtMM;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.TextBox txtQuantity;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.ComboBox cmbUnidadMedida;
        private System.Windows.Forms.Label lblUnidadMedida;
        private System.Windows.Forms.Label lblyyyy;
        private System.Windows.Forms.Label lbldd;
        private System.Windows.Forms.Label lblMM;
        private System.Windows.Forms.TextBox txtYyyy;
        private System.Windows.Forms.TextBox txtDd;
        private System.Windows.Forms.RichTextBox richTextBox1;
    }
}