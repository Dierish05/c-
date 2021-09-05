namespace Presentation
{
    partial class Form1
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
            this.buttonAceptar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtDni = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNombres = new System.Windows.Forms.TextBox();
            this.txtApellidos = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtSalario = new System.Windows.Forms.TextBox();
            this.groupBoxDatos = new System.Windows.Forms.GroupBox();
            this.buttonSalario = new System.Windows.Forms.Button();
            this.buttonSalarioMin = new System.Windows.Forms.Button();
            this.buttonSP = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.buttonMay = new System.Windows.Forms.Button();
            this.buttonMen = new System.Windows.Forms.Button();
            this.cmbGenero = new System.Windows.Forms.ComboBox();
            this.cmbNivelAcademico = new System.Windows.Forms.ComboBox();
            this.lblNivelAcademico = new System.Windows.Forms.Label();
            this.LblGenero = new System.Windows.Forms.Label();
            this.btnVentanaProductos = new System.Windows.Forms.Button();
            this.groupBoxDatos.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonAceptar
            // 
            this.buttonAceptar.Location = new System.Drawing.Point(4, 4);
            this.buttonAceptar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonAceptar.Name = "buttonAceptar";
            this.buttonAceptar.Size = new System.Drawing.Size(113, 31);
            this.buttonAceptar.TabIndex = 0;
            this.buttonAceptar.Text = "Aceptar";
            this.buttonAceptar.UseVisualStyleBackColor = true;
            this.buttonAceptar.Click += new System.EventHandler(this.Button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 39);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "DNI:";
            // 
            // txtDni
            // 
            this.txtDni.Location = new System.Drawing.Point(153, 31);
            this.txtDni.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtDni.Name = "txtDni";
            this.txtDni.Size = new System.Drawing.Size(289, 22);
            this.txtDni.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(41, 101);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Nombres:";
            // 
            // txtNombres
            // 
            this.txtNombres.Location = new System.Drawing.Point(153, 92);
            this.txtNombres.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtNombres.Name = "txtNombres";
            this.txtNombres.Size = new System.Drawing.Size(289, 22);
            this.txtNombres.TabIndex = 4;
            // 
            // txtApellidos
            // 
            this.txtApellidos.Location = new System.Drawing.Point(153, 151);
            this.txtApellidos.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtApellidos.Name = "txtApellidos";
            this.txtApellidos.Size = new System.Drawing.Size(289, 22);
            this.txtApellidos.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(41, 155);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Apellidos:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(41, 217);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "Salario:";
            // 
            // txtSalario
            // 
            this.txtSalario.Location = new System.Drawing.Point(153, 208);
            this.txtSalario.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtSalario.Name = "txtSalario";
            this.txtSalario.Size = new System.Drawing.Size(289, 22);
            this.txtSalario.TabIndex = 8;
            // 
            // groupBoxDatos
            // 
            this.groupBoxDatos.Controls.Add(this.txtDni);
            this.groupBoxDatos.Controls.Add(this.label4);
            this.groupBoxDatos.Controls.Add(this.txtSalario);
            this.groupBoxDatos.Controls.Add(this.label3);
            this.groupBoxDatos.Controls.Add(this.txtNombres);
            this.groupBoxDatos.Controls.Add(this.label2);
            this.groupBoxDatos.Controls.Add(this.txtApellidos);
            this.groupBoxDatos.Controls.Add(this.label1);
            this.groupBoxDatos.Location = new System.Drawing.Point(16, 4);
            this.groupBoxDatos.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBoxDatos.Name = "groupBoxDatos";
            this.groupBoxDatos.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBoxDatos.Size = new System.Drawing.Size(485, 263);
            this.groupBoxDatos.TabIndex = 9;
            this.groupBoxDatos.TabStop = false;
            this.groupBoxDatos.Text = "Datos de Empleados";
            this.groupBoxDatos.Enter += new System.EventHandler(this.GroupBoxDatos_Enter);
            // 
            // buttonSalario
            // 
            this.buttonSalario.Location = new System.Drawing.Point(126, 4);
            this.buttonSalario.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonSalario.Name = "buttonSalario";
            this.buttonSalario.Size = new System.Drawing.Size(137, 31);
            this.buttonSalario.TabIndex = 1;
            this.buttonSalario.Text = "Salario Máximo";
            this.buttonSalario.UseVisualStyleBackColor = true;
            this.buttonSalario.Click += new System.EventHandler(this.ButtonSalario_Click);
            // 
            // buttonSalarioMin
            // 
            this.buttonSalarioMin.Location = new System.Drawing.Point(4, 43);
            this.buttonSalarioMin.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonSalarioMin.Name = "buttonSalarioMin";
            this.buttonSalarioMin.Size = new System.Drawing.Size(113, 28);
            this.buttonSalarioMin.TabIndex = 2;
            this.buttonSalarioMin.Text = "Salario Mínimo";
            this.buttonSalarioMin.UseVisualStyleBackColor = true;
            this.buttonSalarioMin.Click += new System.EventHandler(this.ButtonSalarioMin_Click);
            // 
            // buttonSP
            // 
            this.buttonSP.Location = new System.Drawing.Point(126, 43);
            this.buttonSP.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonSP.Name = "buttonSP";
            this.buttonSP.Size = new System.Drawing.Size(137, 28);
            this.buttonSP.TabIndex = 3;
            this.buttonSP.Text = "Salario Promedio";
            this.buttonSP.UseVisualStyleBackColor = true;
            this.buttonSP.Click += new System.EventHandler(this.ButtonSP_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoSize = true;
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 43.57798F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 56.42202F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 205F));
            this.tableLayoutPanel1.Controls.Add(this.buttonSP, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.buttonSalarioMin, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.buttonSalario, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.buttonAceptar, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.buttonMay, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.buttonMen, 2, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(16, 378);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(485, 78);
            this.tableLayoutPanel1.TabIndex = 12;
            // 
            // buttonMay
            // 
            this.buttonMay.Location = new System.Drawing.Point(283, 4);
            this.buttonMay.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonMay.Name = "buttonMay";
            this.buttonMay.Size = new System.Drawing.Size(175, 28);
            this.buttonMay.TabIndex = 4;
            this.buttonMay.Text = "Salarios May. al Prom.";
            this.buttonMay.UseVisualStyleBackColor = true;
            this.buttonMay.Click += new System.EventHandler(this.ButtonMay_Click);
            // 
            // buttonMen
            // 
            this.buttonMen.Location = new System.Drawing.Point(283, 43);
            this.buttonMen.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonMen.Name = "buttonMen";
            this.buttonMen.Size = new System.Drawing.Size(175, 28);
            this.buttonMen.TabIndex = 5;
            this.buttonMen.Text = "Salarios Men. al Prom.";
            this.buttonMen.UseVisualStyleBackColor = true;
            // 
            // cmbGenero
            // 
            this.cmbGenero.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbGenero.FormattingEnabled = true;
            this.cmbGenero.Items.AddRange(new object[] {
            "Femenino",
            "Masculino",
            "helicoptero Apache Volador"});
            this.cmbGenero.Location = new System.Drawing.Point(169, 316);
            this.cmbGenero.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbGenero.Name = "cmbGenero";
            this.cmbGenero.Size = new System.Drawing.Size(160, 24);
            this.cmbGenero.TabIndex = 13;
            // 
            // cmbNivelAcademico
            // 
            this.cmbNivelAcademico.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbNivelAcademico.FormattingEnabled = true;
            this.cmbNivelAcademico.Items.AddRange(new object[] {
            "Primaria",
            "Secundaria",
            "Universidad",
            "Post grado",
            "Maestria",
            "Doctorado",
            "Post Doctorado"});
            this.cmbNivelAcademico.Location = new System.Drawing.Point(169, 274);
            this.cmbNivelAcademico.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbNivelAcademico.Name = "cmbNivelAcademico";
            this.cmbNivelAcademico.Size = new System.Drawing.Size(160, 24);
            this.cmbNivelAcademico.TabIndex = 14;
            // 
            // lblNivelAcademico
            // 
            this.lblNivelAcademico.AutoSize = true;
            this.lblNivelAcademico.Location = new System.Drawing.Point(28, 274);
            this.lblNivelAcademico.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNivelAcademico.Name = "lblNivelAcademico";
            this.lblNivelAcademico.Size = new System.Drawing.Size(116, 17);
            this.lblNivelAcademico.TabIndex = 15;
            this.lblNivelAcademico.Text = "Nivel Academico:";
            // 
            // LblGenero
            // 
            this.LblGenero.AutoSize = true;
            this.LblGenero.Location = new System.Drawing.Point(28, 316);
            this.LblGenero.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblGenero.Name = "LblGenero";
            this.LblGenero.Size = new System.Drawing.Size(60, 17);
            this.LblGenero.TabIndex = 16;
            this.LblGenero.Text = "Genero:";
            // 
            // btnVentanaProductos
            // 
            this.btnVentanaProductos.Location = new System.Drawing.Point(16, 478);
            this.btnVentanaProductos.Name = "btnVentanaProductos";
            this.btnVentanaProductos.Size = new System.Drawing.Size(144, 23);
            this.btnVentanaProductos.TabIndex = 17;
            this.btnVentanaProductos.Text = "Ventana productos";
            this.btnVentanaProductos.UseVisualStyleBackColor = true;
            this.btnVentanaProductos.Click += new System.EventHandler(this.btnVentanaProductos_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(508, 564);
            this.Controls.Add(this.btnVentanaProductos);
            this.Controls.Add(this.LblGenero);
            this.Controls.Add(this.lblNivelAcademico);
            this.Controls.Add(this.cmbNivelAcademico);
            this.Controls.Add(this.cmbGenero);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.groupBoxDatos);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Empleado";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBoxDatos.ResumeLayout(false);
            this.groupBoxDatos.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonAceptar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDni;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNombres;
        private System.Windows.Forms.TextBox txtApellidos;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtSalario;
        private System.Windows.Forms.GroupBox groupBoxDatos;
        private System.Windows.Forms.Button buttonSalario;
        private System.Windows.Forms.Button buttonSalarioMin;
        private System.Windows.Forms.Button buttonSP;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button buttonMay;
        private System.Windows.Forms.Button buttonMen;
        private System.Windows.Forms.ComboBox cmbGenero;
        private System.Windows.Forms.ComboBox cmbNivelAcademico;
        private System.Windows.Forms.Label lblNivelAcademico;
        private System.Windows.Forms.Label LblGenero;
        private System.Windows.Forms.Button btnVentanaProductos;
    }
}

