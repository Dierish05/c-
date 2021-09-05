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
            this.btnJson = new System.Windows.Forms.Button();
            this.btnOrdenar = new System.Windows.Forms.Button();
            this.txtMayor = new System.Windows.Forms.TextBox();
            this.txtMenor = new System.Windows.Forms.TextBox();
            this.btnRango = new System.Windows.Forms.Button();
            this.lblRangoPrecio = new System.Windows.Forms.Label();
            this.lblmenor = new System.Windows.Forms.Label();
            this.lblMayor = new System.Windows.Forms.Label();
            this.btnCaducityDate = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtMMB = new System.Windows.Forms.TextBox();
            this.txtddB = new System.Windows.Forms.TextBox();
            this.txtyyyyB = new System.Windows.Forms.TextBox();
            this.cmbunidadMedidaB = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnUnidadmedidaB = new System.Windows.Forms.Button();
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
            this.lblyyyy.Size = new System.Drawing.Size(40, 17);
            this.lblyyyy.TabIndex = 19;
            this.lblyyyy.Text = "yyyy:";
            // 
            // lbldd
            // 
            this.lbldd.AutoSize = true;
            this.lbldd.Location = new System.Drawing.Point(257, 219);
            this.lbldd.Name = "lbldd";
            this.lbldd.Size = new System.Drawing.Size(28, 17);
            this.lbldd.TabIndex = 18;
            this.lbldd.Text = "dd:";
            // 
            // lblMM
            // 
            this.lblMM.AutoSize = true;
            this.lblMM.Location = new System.Drawing.Point(184, 219);
            this.lblMM.Name = "lblMM";
            this.lblMM.Size = new System.Drawing.Size(34, 17);
            this.lblMM.TabIndex = 17;
            this.lblMM.Text = "MM:";
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
            this.richTextBox1.Size = new System.Drawing.Size(307, 281);
            this.richTextBox1.TabIndex = 8;
            this.richTextBox1.Text = "";
            // 
            // btnJson
            // 
            this.btnJson.Location = new System.Drawing.Point(539, 325);
            this.btnJson.Name = "btnJson";
            this.btnJson.Size = new System.Drawing.Size(133, 23);
            this.btnJson.TabIndex = 9;
            this.btnJson.Text = "convertir a Json";
            this.btnJson.UseVisualStyleBackColor = true;
            this.btnJson.Click += new System.EventHandler(this.btnJson_Click);
            // 
            // btnOrdenar
            // 
            this.btnOrdenar.Location = new System.Drawing.Point(16, 355);
            this.btnOrdenar.Name = "btnOrdenar";
            this.btnOrdenar.Size = new System.Drawing.Size(100, 23);
            this.btnOrdenar.TabIndex = 10;
            this.btnOrdenar.Text = "Ordenar por precio";
            this.btnOrdenar.UseVisualStyleBackColor = true;
            this.btnOrdenar.Click += new System.EventHandler(this.btnOrdenar_Click);
            // 
            // txtMayor
            // 
            this.txtMayor.Location = new System.Drawing.Point(75, 490);
            this.txtMayor.Name = "txtMayor";
            this.txtMayor.Size = new System.Drawing.Size(100, 22);
            this.txtMayor.TabIndex = 11;
            // 
            // txtMenor
            // 
            this.txtMenor.Location = new System.Drawing.Point(75, 456);
            this.txtMenor.Name = "txtMenor";
            this.txtMenor.Size = new System.Drawing.Size(100, 22);
            this.txtMenor.TabIndex = 12;
            // 
            // btnRango
            // 
            this.btnRango.Location = new System.Drawing.Point(19, 535);
            this.btnRango.Name = "btnRango";
            this.btnRango.Size = new System.Drawing.Size(75, 23);
            this.btnRango.TabIndex = 13;
            this.btnRango.Text = "Buscar";
            this.btnRango.UseVisualStyleBackColor = true;
            this.btnRango.Click += new System.EventHandler(this.btnRango_Click);
            // 
            // lblRangoPrecio
            // 
            this.lblRangoPrecio.AutoSize = true;
            this.lblRangoPrecio.Location = new System.Drawing.Point(16, 427);
            this.lblRangoPrecio.Name = "lblRangoPrecio";
            this.lblRangoPrecio.Size = new System.Drawing.Size(120, 17);
            this.lblRangoPrecio.TabIndex = 14;
            this.lblRangoPrecio.Text = "Rango de precios";
            // 
            // lblmenor
            // 
            this.lblmenor.AutoSize = true;
            this.lblmenor.Location = new System.Drawing.Point(16, 461);
            this.lblmenor.Name = "lblmenor";
            this.lblmenor.Size = new System.Drawing.Size(48, 17);
            this.lblmenor.TabIndex = 15;
            this.lblmenor.Text = "menor";
            // 
            // lblMayor
            // 
            this.lblMayor.AutoSize = true;
            this.lblMayor.Location = new System.Drawing.Point(16, 495);
            this.lblMayor.Name = "lblMayor";
            this.lblMayor.Size = new System.Drawing.Size(47, 17);
            this.lblMayor.TabIndex = 16;
            this.lblMayor.Text = "mayor";
            // 
            // btnCaducityDate
            // 
            this.btnCaducityDate.Location = new System.Drawing.Point(270, 535);
            this.btnCaducityDate.Name = "btnCaducityDate";
            this.btnCaducityDate.Size = new System.Drawing.Size(185, 23);
            this.btnCaducityDate.TabIndex = 17;
            this.btnCaducityDate.Text = "Obtener por  caducityDate";
            this.btnCaducityDate.UseVisualStyleBackColor = true;
            this.btnCaducityDate.Click += new System.EventHandler(this.btnCaducityDate_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(267, 456);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 17);
            this.label1.TabIndex = 18;
            this.label1.Text = "MM:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(267, 477);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 17);
            this.label2.TabIndex = 19;
            this.label2.Text = "dd:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(267, 495);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 17);
            this.label3.TabIndex = 20;
            this.label3.Text = "yyyy:";
            // 
            // txtMMB
            // 
            this.txtMMB.Location = new System.Drawing.Point(320, 453);
            this.txtMMB.Name = "txtMMB";
            this.txtMMB.Size = new System.Drawing.Size(100, 22);
            this.txtMMB.TabIndex = 21;
            // 
            // txtddB
            // 
            this.txtddB.Location = new System.Drawing.Point(320, 474);
            this.txtddB.Name = "txtddB";
            this.txtddB.Size = new System.Drawing.Size(100, 22);
            this.txtddB.TabIndex = 22;
            // 
            // txtyyyyB
            // 
            this.txtyyyyB.Location = new System.Drawing.Point(320, 492);
            this.txtyyyyB.Name = "txtyyyyB";
            this.txtyyyyB.Size = new System.Drawing.Size(100, 22);
            this.txtyyyyB.TabIndex = 23;
            // 
            // cmbunidadMedidaB
            // 
            this.cmbunidadMedidaB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbunidadMedidaB.FormattingEnabled = true;
            this.cmbunidadMedidaB.Items.AddRange(new object[] {
            "litros",
            "milimetros",
            "libras",
            "gramos",
            "kilogramos"});
            this.cmbunidadMedidaB.Location = new System.Drawing.Point(486, 535);
            this.cmbunidadMedidaB.Name = "cmbunidadMedidaB";
            this.cmbunidadMedidaB.Size = new System.Drawing.Size(201, 24);
            this.cmbunidadMedidaB.TabIndex = 24;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(483, 497);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(204, 17);
            this.label4.TabIndex = 25;
            this.label4.Text = "Obtener por Unidad de medida";
            // 
            // btnUnidadmedidaB
            // 
            this.btnUnidadmedidaB.Location = new System.Drawing.Point(710, 535);
            this.btnUnidadmedidaB.Name = "btnUnidadmedidaB";
            this.btnUnidadmedidaB.Size = new System.Drawing.Size(75, 23);
            this.btnUnidadmedidaB.TabIndex = 26;
            this.btnUnidadmedidaB.Text = "buscar";
            this.btnUnidadmedidaB.UseVisualStyleBackColor = true;
            this.btnUnidadmedidaB.Click += new System.EventHandler(this.btnUnidadmedidaB_Click);
            // 
            // FrmProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(858, 588);
            this.Controls.Add(this.btnUnidadmedidaB);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cmbunidadMedidaB);
            this.Controls.Add(this.txtyyyyB);
            this.Controls.Add(this.txtddB);
            this.Controls.Add(this.txtMMB);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCaducityDate);
            this.Controls.Add(this.lblMayor);
            this.Controls.Add(this.lblmenor);
            this.Controls.Add(this.lblRangoPrecio);
            this.Controls.Add(this.btnRango);
            this.Controls.Add(this.txtMenor);
            this.Controls.Add(this.txtMayor);
            this.Controls.Add(this.btnOrdenar);
            this.Controls.Add(this.btnJson);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnAgregarP);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmProduct";
            this.Text = "Producto";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

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
        private System.Windows.Forms.Button btnJson;
        private System.Windows.Forms.Button btnOrdenar;
        private System.Windows.Forms.TextBox txtMayor;
        private System.Windows.Forms.TextBox txtMenor;
        private System.Windows.Forms.Button btnRango;
        private System.Windows.Forms.Label lblRangoPrecio;
        private System.Windows.Forms.Label lblmenor;
        private System.Windows.Forms.Label lblMayor;
        private System.Windows.Forms.Button btnCaducityDate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtMMB;
        private System.Windows.Forms.TextBox txtddB;
        private System.Windows.Forms.TextBox txtyyyyB;
        private System.Windows.Forms.ComboBox cmbunidadMedidaB;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnUnidadmedidaB;
    }
}