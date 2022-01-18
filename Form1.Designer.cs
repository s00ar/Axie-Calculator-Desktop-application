
namespace AxieCalculator
{
    partial class FormularioControl
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormularioControl));
            this.botonLimpiar = new System.Windows.Forms.Button();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Procesar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtCuenta = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.botonSalir = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cbPorcentaje = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.tbSlpMinimoDiario = new System.Windows.Forms.TextBox();
            this.tbIngresoLogrado = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lblSItuacion = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.lblSlpDiferencia = new System.Windows.Forms.Label();
            this.lblSlpBecario = new System.Windows.Forms.Label();
            this.lblPromedio = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.lblDias = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.lblDateTime1 = new System.Windows.Forms.Label();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.lblStatus = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // botonLimpiar
            // 
            this.botonLimpiar.Location = new System.Drawing.Point(668, 191);
            this.botonLimpiar.Name = "botonLimpiar";
            this.botonLimpiar.Size = new System.Drawing.Size(105, 29);
            this.botonLimpiar.TabIndex = 11;
            this.botonLimpiar.Text = "&Limpiar";
            this.botonLimpiar.UseVisualStyleBackColor = true;
            this.botonLimpiar.Click += new System.EventHandler(this.botonLimpiar_Click);
            // 
            // txtUsuario
            // 
            this.txtUsuario.Location = new System.Drawing.Point(6, 50);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(231, 23);
            this.txtUsuario.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "Cuenta";
            // 
            // Procesar
            // 
            this.Procesar.Location = new System.Drawing.Point(560, 145);
            this.Procesar.Name = "Procesar";
            this.Procesar.Size = new System.Drawing.Size(213, 40);
            this.Procesar.TabIndex = 8;
            this.Procesar.Text = "&Calcular";
            this.Procesar.UseVisualStyleBackColor = true;
            this.Procesar.Click += new System.EventHandler(this.Procesar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.groupBox1.Controls.Add(this.dateTimePicker2);
            this.groupBox1.Controls.Add(this.dateTimePicker1);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtUsuario);
            this.groupBox1.Controls.Add(this.txtCuenta);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Location = new System.Drawing.Point(16, 145);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(243, 260);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Control Pago Semanal";
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(6, 218);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(231, 23);
            this.dateTimePicker2.TabIndex = 4;
            this.dateTimePicker2.ValueChanged += new System.EventHandler(this.dateTimePicker2_ValueChanged);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(6, 157);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(231, 23);
            this.dateTimePicker1.TabIndex = 3;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 200);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 15);
            this.label6.TabIndex = 8;
            this.label6.Text = "Fecha hasta";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 139);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 15);
            this.label4.TabIndex = 7;
            this.label4.Text = "Fecha desde";
            // 
            // txtCuenta
            // 
            this.txtCuenta.Location = new System.Drawing.Point(6, 106);
            this.txtCuenta.Name = "txtCuenta";
            this.txtCuenta.Size = new System.Drawing.Size(231, 23);
            this.txtCuenta.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 32);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(112, 15);
            this.label5.TabIndex = 3;
            this.label5.Text = "&Nombre del Becario";
            // 
            // botonSalir
            // 
            this.botonSalir.Location = new System.Drawing.Point(560, 226);
            this.botonSalir.Name = "botonSalir";
            this.botonSalir.Size = new System.Drawing.Size(213, 35);
            this.botonSalir.TabIndex = 12;
            this.botonSalir.Text = "&Salir";
            this.botonSalir.UseVisualStyleBackColor = true;
            this.botonSalir.Click += new System.EventHandler(this.botonSalir_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(560, 191);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(105, 29);
            this.btnSalvar.TabIndex = 10;
            this.btnSalvar.Text = "&Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.groupBox2.Controls.Add(this.cbPorcentaje);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.tbSlpMinimoDiario);
            this.groupBox2.Controls.Add(this.tbIngresoLogrado);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Location = new System.Drawing.Point(511, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(282, 127);
            this.groupBox2.TabIndex = 15;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Smooth Love Potion";
            // 
            // cbPorcentaje
            // 
            this.cbPorcentaje.Cursor = System.Windows.Forms.Cursors.Default;
            this.cbPorcentaje.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbPorcentaje.FormattingEnabled = true;
            this.cbPorcentaje.Items.AddRange(new object[] {
            "Seleccione",
            "%10",
            "%20",
            "%30",
            "%40",
            "%50",
            "%60",
            "%70",
            "%80",
            "%90"});
            this.cbPorcentaje.Location = new System.Drawing.Point(175, 98);
            this.cbPorcentaje.Name = "cbPorcentaje";
            this.cbPorcentaje.Size = new System.Drawing.Size(100, 23);
            this.cbPorcentaje.TabIndex = 7;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(6, 101);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(163, 15);
            this.label11.TabIndex = 12;
            this.label11.Text = "Porcentaje a favor del Becario";
            // 
            // tbSlpMinimoDiario
            // 
            this.tbSlpMinimoDiario.Location = new System.Drawing.Point(175, 18);
            this.tbSlpMinimoDiario.Name = "tbSlpMinimoDiario";
            this.tbSlpMinimoDiario.ShortcutsEnabled = false;
            this.tbSlpMinimoDiario.Size = new System.Drawing.Size(100, 23);
            this.tbSlpMinimoDiario.TabIndex = 5;
            this.tbSlpMinimoDiario.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtb_Only_Num1);
            // 
            // tbIngresoLogrado
            // 
            this.tbIngresoLogrado.Location = new System.Drawing.Point(175, 58);
            this.tbIngresoLogrado.Name = "tbIngresoLogrado";
            this.tbIngresoLogrado.ShortcutsEnabled = false;
            this.tbIngresoLogrado.Size = new System.Drawing.Size(100, 23);
            this.tbIngresoLogrado.TabIndex = 6;
            this.tbIngresoLogrado.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtb_Only_Num2);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(7, 66);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(93, 15);
            this.label13.TabIndex = 4;
            this.label13.Text = "Ingreso Logrado";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(7, 26);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(158, 15);
            this.label14.TabIndex = 3;
            this.label14.Text = "Ingreso mínimo diario de slp";
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.groupBox3.Controls.Add(this.lblSItuacion);
            this.groupBox3.Controls.Add(this.label22);
            this.groupBox3.Controls.Add(this.lblSlpDiferencia);
            this.groupBox3.Controls.Add(this.lblSlpBecario);
            this.groupBox3.Controls.Add(this.lblPromedio);
            this.groupBox3.Controls.Add(this.label17);
            this.groupBox3.Controls.Add(this.lblDias);
            this.groupBox3.Controls.Add(this.label19);
            this.groupBox3.Controls.Add(this.label20);
            this.groupBox3.Controls.Add(this.label21);
            this.groupBox3.Location = new System.Drawing.Point(542, 265);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(251, 158);
            this.groupBox3.TabIndex = 16;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Resultados";
            // 
            // lblSItuacion
            // 
            this.lblSItuacion.AutoSize = true;
            this.lblSItuacion.Location = new System.Drawing.Point(133, 137);
            this.lblSItuacion.Name = "lblSItuacion";
            this.lblSItuacion.Size = new System.Drawing.Size(116, 15);
            this.lblSItuacion.TabIndex = 21;
            this.lblSItuacion.Text = "MINIMO CUMPLIDO";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(6, 108);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(206, 15);
            this.label22.TabIndex = 20;
            this.label22.Text = "Diferencia entre slp logrado y mínimo";
            // 
            // lblSlpDiferencia
            // 
            this.lblSlpDiferencia.AutoSize = true;
            this.lblSlpDiferencia.Location = new System.Drawing.Point(218, 108);
            this.lblSlpDiferencia.Name = "lblSlpDiferencia";
            this.lblSlpDiferencia.Size = new System.Drawing.Size(13, 15);
            this.lblSlpDiferencia.TabIndex = 19;
            this.lblSlpDiferencia.Text = "0";
            // 
            // lblSlpBecario
            // 
            this.lblSlpBecario.AutoSize = true;
            this.lblSlpBecario.Location = new System.Drawing.Point(187, 80);
            this.lblSlpBecario.Name = "lblSlpBecario";
            this.lblSlpBecario.Size = new System.Drawing.Size(13, 15);
            this.lblSlpBecario.TabIndex = 18;
            this.lblSlpBecario.Text = "0";
            // 
            // lblPromedio
            // 
            this.lblPromedio.AutoSize = true;
            this.lblPromedio.Location = new System.Drawing.Point(187, 48);
            this.lblPromedio.Name = "lblPromedio";
            this.lblPromedio.Size = new System.Drawing.Size(13, 15);
            this.lblPromedio.TabIndex = 17;
            this.lblPromedio.Text = "0";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(5, 137);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(117, 15);
            this.label17.TabIndex = 15;
            this.label17.Text = "Situación del becario";
            // 
            // lblDias
            // 
            this.lblDias.AutoSize = true;
            this.lblDias.Location = new System.Drawing.Point(68, 19);
            this.lblDias.Name = "lblDias";
            this.lblDias.Size = new System.Drawing.Size(13, 15);
            this.lblDias.TabIndex = 14;
            this.lblDias.Text = "0";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(6, 80);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(166, 15);
            this.label19.TabIndex = 12;
            this.label19.Text = "Slp correspondiente al becario";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(6, 48);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(167, 15);
            this.label20.TabIndex = 11;
            this.label20.Text = "Slp promedio logrados por día";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(6, 19);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(56, 15);
            this.label21.TabIndex = 10;
            this.label21.Text = "Total días";
            // 
            // lblDateTime1
            // 
            this.lblDateTime1.AutoSize = true;
            this.lblDateTime1.BackColor = System.Drawing.Color.Transparent;
            this.lblDateTime1.Font = new System.Drawing.Font("Ink Free", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblDateTime1.ForeColor = System.Drawing.Color.SteelBlue;
            this.lblDateTime1.Location = new System.Drawing.Point(345, 403);
            this.lblDateTime1.Name = "lblDateTime1";
            this.lblDateTime1.Size = new System.Drawing.Size(58, 23);
            this.lblDateTime1.TabIndex = 17;
            this.lblDateTime1.Text = "Fecha";
            this.lblDateTime1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.BackColor = System.Drawing.Color.Transparent;
            this.lblStatus.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblStatus.Location = new System.Drawing.Point(16, 418);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(58, 15);
            this.lblStatus.TabIndex = 21;
            this.lblStatus.Text = "Status OK";
            // 
            // FormularioControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(802, 442);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.lblDateTime1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.Procesar);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.botonSalir);
            this.Controls.Add(this.botonLimpiar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormularioControl";
            this.Text = "Control Cuentas Play 2 Earn";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button botonLimpiar;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button Procesar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtCuenta;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button botonSalir;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox cbPorcentaje;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox tbSlpMinimoDiario;
        private System.Windows.Forms.TextBox tbIngresoLogrado;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label lblSItuacion;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label lblSlpDiferencia;
        private System.Windows.Forms.Label lblSlpBecario;
        private System.Windows.Forms.Label lblPromedio;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label lblDias;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label lblDateTime1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.Label lblStatus;
    }
}

