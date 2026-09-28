namespace pryAmatoGimnasio
{
    partial class frmInscripcion
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
            lblTitulo = new Label();
            lblSubtitulo = new Label();
            gpbDatosPersonales = new GroupBox();
            lblAños = new Label();
            txtEdad = new TextBox();
            lblEdad = new Label();
            txtNombre = new TextBox();
            lblNombre = new Label();
            chkEstudiante = new CheckBox();
            gpbPlanTurno = new GroupBox();
            cboTurno = new ComboBox();
            cboPlan = new ComboBox();
            lblTurno = new Label();
            lblPlan = new Label();
            gpbAdicionales = new GroupBox();
            chkAdicional = new CheckBox();
            gpbMesesInscripcion = new GroupBox();
            lblCantidadMeses = new Label();
            txtMeses = new TextBox();
            lblMeses = new Label();
            gpbFormaPago = new GroupBox();
            cboCuotas = new ComboBox();
            lblCantidadCuotas = new Label();
            rbtTarjeta = new RadioButton();
            rbtEfectivo = new RadioButton();
            btnCalcular = new Button();
            btnLimpiar = new Button();
            gpbDescuentosEdad = new GroupBox();
            lblEnOtroCaso = new Label();
            lblEstudiante = new Label();
            lblMayor = new Label();
            lblMenor = new Label();
            lblDescEdad = new Label();
            pictureBox1 = new PictureBox();
            gpbDatosPersonales.SuspendLayout();
            gpbPlanTurno.SuspendLayout();
            gpbAdicionales.SuspendLayout();
            gpbMesesInscripcion.SuspendLayout();
            gpbFormaPago.SuspendLayout();
            gpbDescuentosEdad.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Arial Narrow", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTitulo.Location = new Point(152, 21);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(197, 31);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "GIMNASIO SIGLO";
            // 
            // lblSubtitulo
            // 
            lblSubtitulo.AutoSize = true;
            lblSubtitulo.Font = new Font("Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblSubtitulo.Location = new Point(171, 52);
            lblSubtitulo.Name = "lblSubtitulo";
            lblSubtitulo.Size = new Size(139, 20);
            lblSubtitulo.TabIndex = 1;
            lblSubtitulo.Text = "Inscripción de Socios";
            // 
            // gpbDatosPersonales
            // 
            gpbDatosPersonales.Controls.Add(lblAños);
            gpbDatosPersonales.Controls.Add(txtEdad);
            gpbDatosPersonales.Controls.Add(lblEdad);
            gpbDatosPersonales.Controls.Add(txtNombre);
            gpbDatosPersonales.Controls.Add(lblNombre);
            gpbDatosPersonales.Location = new Point(35, 90);
            gpbDatosPersonales.Name = "gpbDatosPersonales";
            gpbDatosPersonales.Size = new Size(308, 106);
            gpbDatosPersonales.TabIndex = 2;
            gpbDatosPersonales.TabStop = false;
            gpbDatosPersonales.Text = "Datos Personales";
            // 
            // lblAños
            // 
            lblAños.AutoSize = true;
            lblAños.Location = new Point(148, 74);
            lblAños.Name = "lblAños";
            lblAños.Size = new Size(32, 15);
            lblAños.TabIndex = 4;
            lblAños.Text = "años";
            // 
            // txtEdad
            // 
            txtEdad.Location = new Point(94, 66);
            txtEdad.Name = "txtEdad";
            txtEdad.Size = new Size(48, 23);
            txtEdad.TabIndex = 3;
            // 
            // lblEdad
            // 
            lblEdad.AutoSize = true;
            lblEdad.Location = new Point(26, 74);
            lblEdad.Name = "lblEdad";
            lblEdad.Size = new Size(33, 15);
            lblEdad.TabIndex = 2;
            lblEdad.Text = "Edad";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(94, 29);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(197, 23);
            txtNombre.TabIndex = 1;
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(26, 37);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(51, 15);
            lblNombre.TabIndex = 0;
            lblNombre.Text = "Nombre";
            // 
            // chkEstudiante
            // 
            chkEstudiante.AutoSize = true;
            chkEstudiante.Location = new Point(26, 23);
            chkEstudiante.Name = "chkEstudiante";
            chkEstudiante.Size = new Size(114, 19);
            chkEstudiante.TabIndex = 5;
            chkEstudiante.Text = "Estudiante (15%)";
            chkEstudiante.UseVisualStyleBackColor = true;
            // 
            // gpbPlanTurno
            // 
            gpbPlanTurno.Controls.Add(cboTurno);
            gpbPlanTurno.Controls.Add(cboPlan);
            gpbPlanTurno.Controls.Add(lblTurno);
            gpbPlanTurno.Controls.Add(lblPlan);
            gpbPlanTurno.Location = new Point(369, 90);
            gpbPlanTurno.Name = "gpbPlanTurno";
            gpbPlanTurno.Size = new Size(308, 106);
            gpbPlanTurno.TabIndex = 3;
            gpbPlanTurno.TabStop = false;
            gpbPlanTurno.Text = "Plan y Turno";
            // 
            // cboTurno
            // 
            cboTurno.DropDownStyle = ComboBoxStyle.DropDownList;
            cboTurno.FormattingEnabled = true;
            cboTurno.Items.AddRange(new object[] { "Mañana", "Tarde", "Noche" });
            cboTurno.Location = new Point(98, 74);
            cboTurno.Name = "cboTurno";
            cboTurno.Size = new Size(121, 23);
            cboTurno.TabIndex = 3;
            // 
            // cboPlan
            // 
            cboPlan.DropDownStyle = ComboBoxStyle.DropDownList;
            cboPlan.FormattingEnabled = true;
            cboPlan.Items.AddRange(new object[] { "Musculación", "Funcional", "Natación" });
            cboPlan.Location = new Point(98, 34);
            cboPlan.Name = "cboPlan";
            cboPlan.Size = new Size(121, 23);
            cboPlan.TabIndex = 2;
            // 
            // lblTurno
            // 
            lblTurno.AutoSize = true;
            lblTurno.Location = new Point(29, 82);
            lblTurno.Name = "lblTurno";
            lblTurno.Size = new Size(39, 15);
            lblTurno.TabIndex = 1;
            lblTurno.Text = "Turno";
            // 
            // lblPlan
            // 
            lblPlan.AutoSize = true;
            lblPlan.Location = new Point(29, 42);
            lblPlan.Name = "lblPlan";
            lblPlan.Size = new Size(30, 15);
            lblPlan.TabIndex = 0;
            lblPlan.Text = "Plan";
            // 
            // gpbAdicionales
            // 
            gpbAdicionales.Controls.Add(chkAdicional);
            gpbAdicionales.Location = new Point(371, 219);
            gpbAdicionales.Name = "gpbAdicionales";
            gpbAdicionales.Size = new Size(308, 57);
            gpbAdicionales.TabIndex = 4;
            gpbAdicionales.TabStop = false;
            gpbAdicionales.Text = "Adicionales";
            // 
            // chkAdicional
            // 
            chkAdicional.AutoSize = true;
            chkAdicional.Location = new Point(27, 27);
            chkAdicional.Name = "chkAdicional";
            chkAdicional.Size = new Size(142, 19);
            chkAdicional.TabIndex = 0;
            chkAdicional.Text = "Casillero ($3.000/mes)";
            chkAdicional.UseVisualStyleBackColor = true;
            // 
            // gpbMesesInscripcion
            // 
            gpbMesesInscripcion.Controls.Add(lblCantidadMeses);
            gpbMesesInscripcion.Controls.Add(txtMeses);
            gpbMesesInscripcion.Controls.Add(lblMeses);
            gpbMesesInscripcion.Location = new Point(35, 219);
            gpbMesesInscripcion.Name = "gpbMesesInscripcion";
            gpbMesesInscripcion.Size = new Size(305, 57);
            gpbMesesInscripcion.TabIndex = 5;
            gpbMesesInscripcion.TabStop = false;
            gpbMesesInscripcion.Text = "Meses de Inscripción";
            // 
            // lblCantidadMeses
            // 
            lblCantidadMeses.AutoSize = true;
            lblCantidadMeses.Location = new Point(194, 28);
            lblCantidadMeses.Name = "lblCantidadMeses";
            lblCantidadMeses.Size = new Size(75, 15);
            lblCantidadMeses.TabIndex = 2;
            lblCantidadMeses.Text = "(entre 1 y 12)";
            // 
            // txtMeses
            // 
            txtMeses.Location = new Point(136, 20);
            txtMeses.Name = "txtMeses";
            txtMeses.Size = new Size(52, 23);
            txtMeses.TabIndex = 1;
            // 
            // lblMeses
            // 
            lblMeses.AutoSize = true;
            lblMeses.Location = new Point(23, 26);
            lblMeses.Name = "lblMeses";
            lblMeses.Size = new Size(107, 15);
            lblMeses.TabIndex = 0;
            lblMeses.Text = "Cantidad de Meses";
            // 
            // gpbFormaPago
            // 
            gpbFormaPago.Controls.Add(cboCuotas);
            gpbFormaPago.Controls.Add(lblCantidadCuotas);
            gpbFormaPago.Controls.Add(rbtTarjeta);
            gpbFormaPago.Controls.Add(rbtEfectivo);
            gpbFormaPago.Location = new Point(371, 295);
            gpbFormaPago.Name = "gpbFormaPago";
            gpbFormaPago.Size = new Size(308, 133);
            gpbFormaPago.TabIndex = 6;
            gpbFormaPago.TabStop = false;
            gpbFormaPago.Text = "Forma de Pago";
            // 
            // cboCuotas
            // 
            cboCuotas.DropDownStyle = ComboBoxStyle.DropDownList;
            cboCuotas.FormattingEnabled = true;
            cboCuotas.Items.AddRange(new object[] { "1 cuota 0% recargo", "3 cuotas 10% de recargo", "6 cuotas 20% recargo" });
            cboCuotas.Location = new Point(155, 71);
            cboCuotas.Name = "cboCuotas";
            cboCuotas.Size = new Size(107, 23);
            cboCuotas.TabIndex = 3;
            // 
            // lblCantidadCuotas
            // 
            lblCantidadCuotas.AutoSize = true;
            lblCantidadCuotas.Location = new Point(38, 74);
            lblCantidadCuotas.Name = "lblCantidadCuotas";
            lblCantidadCuotas.Size = new Size(111, 15);
            lblCantidadCuotas.TabIndex = 2;
            lblCantidadCuotas.Text = "Cantidad de Cuotas";
            // 
            // rbtTarjeta
            // 
            rbtTarjeta.AutoSize = true;
            rbtTarjeta.Location = new Point(27, 47);
            rbtTarjeta.Name = "rbtTarjeta";
            rbtTarjeta.Size = new Size(60, 19);
            rbtTarjeta.TabIndex = 1;
            rbtTarjeta.TabStop = true;
            rbtTarjeta.Text = "Tarjeta";
            rbtTarjeta.UseVisualStyleBackColor = true;
            // 
            // rbtEfectivo
            // 
            rbtEfectivo.AutoSize = true;
            rbtEfectivo.Location = new Point(27, 22);
            rbtEfectivo.Name = "rbtEfectivo";
            rbtEfectivo.Size = new Size(174, 19);
            rbtEfectivo.TabIndex = 0;
            rbtEfectivo.TabStop = true;
            rbtEfectivo.Text = "Efectivo (10% de descuento)";
            rbtEfectivo.UseVisualStyleBackColor = true;
            // 
            // btnCalcular
            // 
            btnCalcular.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCalcular.Location = new Point(485, 434);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(87, 23);
            btnCalcular.TabIndex = 7;
            btnCalcular.Text = "Calcular";
            btnCalcular.UseVisualStyleBackColor = true;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnLimpiar.Location = new Point(578, 434);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(75, 23);
            btnLimpiar.TabIndex = 8;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = true;
            // 
            // gpbDescuentosEdad
            // 
            gpbDescuentosEdad.Controls.Add(lblEnOtroCaso);
            gpbDescuentosEdad.Controls.Add(lblEstudiante);
            gpbDescuentosEdad.Controls.Add(lblMayor);
            gpbDescuentosEdad.Controls.Add(lblMenor);
            gpbDescuentosEdad.Controls.Add(lblDescEdad);
            gpbDescuentosEdad.Controls.Add(chkEstudiante);
            gpbDescuentosEdad.Location = new Point(35, 295);
            gpbDescuentosEdad.Name = "gpbDescuentosEdad";
            gpbDescuentosEdad.Size = new Size(308, 133);
            gpbDescuentosEdad.TabIndex = 9;
            gpbDescuentosEdad.TabStop = false;
            gpbDescuentosEdad.Text = "Descuentos por edad / estudiante";
            // 
            // lblEnOtroCaso
            // 
            lblEnOtroCaso.AutoSize = true;
            lblEnOtroCaso.Location = new Point(23, 104);
            lblEnOtroCaso.Name = "lblEnOtroCaso";
            lblEnOtroCaso.Size = new Size(159, 15);
            lblEnOtroCaso.TabIndex = 10;
            lblEnOtroCaso.Text = "- En otro caso: sin descuento";
            // 
            // lblEstudiante
            // 
            lblEstudiante.AutoSize = true;
            lblEstudiante.Location = new Point(23, 89);
            lblEstudiante.Name = "lblEstudiante";
            lblEstudiante.Size = new Size(98, 15);
            lblEstudiante.TabIndex = 9;
            lblEstudiante.Text = "- Estudiante: 15%";
            // 
            // lblMayor
            // 
            lblMayor.AutoSize = true;
            lblMayor.Location = new Point(23, 74);
            lblMayor.Name = "lblMayor";
            lblMayor.Size = new Size(118, 15);
            lblMayor.TabIndex = 8;
            lblMayor.Text = "- 65 años o mas: 30%";
            // 
            // lblMenor
            // 
            lblMenor.AutoSize = true;
            lblMenor.Location = new Point(23, 60);
            lblMenor.Name = "lblMenor";
            lblMenor.Size = new Size(137, 15);
            lblMenor.TabIndex = 7;
            lblMenor.Text = "- Menor de 18 años: 25%";
            // 
            // lblDescEdad
            // 
            lblDescEdad.AutoSize = true;
            lblDescEdad.Location = new Point(23, 45);
            lblDescEdad.Name = "lblDescEdad";
            lblDescEdad.Size = new Size(211, 15);
            lblDescEdad.TabIndex = 6;
            lblDescEdad.Text = "El descuento se aplicara según la edad:";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Imagen_de_ChatGPT_28_sept_2026__11_25_55;
            pictureBox1.Location = new Point(35, 21);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(111, 63);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 10;
            pictureBox1.TabStop = false;
            // 
            // frmInscripcion
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(692, 470);
            Controls.Add(pictureBox1);
            Controls.Add(gpbDescuentosEdad);
            Controls.Add(btnLimpiar);
            Controls.Add(btnCalcular);
            Controls.Add(gpbFormaPago);
            Controls.Add(gpbMesesInscripcion);
            Controls.Add(gpbAdicionales);
            Controls.Add(gpbPlanTurno);
            Controls.Add(gpbDatosPersonales);
            Controls.Add(lblSubtitulo);
            Controls.Add(lblTitulo);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "frmInscripcion";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Gimnasio Siglo — Inscripción";
            gpbDatosPersonales.ResumeLayout(false);
            gpbDatosPersonales.PerformLayout();
            gpbPlanTurno.ResumeLayout(false);
            gpbPlanTurno.PerformLayout();
            gpbAdicionales.ResumeLayout(false);
            gpbAdicionales.PerformLayout();
            gpbMesesInscripcion.ResumeLayout(false);
            gpbMesesInscripcion.PerformLayout();
            gpbFormaPago.ResumeLayout(false);
            gpbFormaPago.PerformLayout();
            gpbDescuentosEdad.ResumeLayout(false);
            gpbDescuentosEdad.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitulo;
        private Label lblSubtitulo;
        private GroupBox gpbDatosPersonales;
        private Label lblAños;
        private TextBox txtEdad;
        private Label lblEdad;
        private TextBox txtNombre;
        private Label lblNombre;
        private CheckBox chkEstudiante;
        private GroupBox gpbPlanTurno;
        private ComboBox cboTurno;
        private ComboBox cboPlan;
        private Label lblTurno;
        private Label lblPlan;
        private GroupBox gpbAdicionales;
        private CheckBox chkAdicional;
        private GroupBox gpbMesesInscripcion;
        private Label lblCantidadMeses;
        private TextBox txtMeses;
        private Label lblMeses;
        private GroupBox gpbFormaPago;
        private RadioButton rbtTarjeta;
        private RadioButton rbtEfectivo;
        private ComboBox cboCuotas;
        private Label lblCantidadCuotas;
        private Button btnCalcular;
        private Button btnLimpiar;
        private GroupBox gpbDescuentosEdad;
        private Label lblEnOtroCaso;
        private Label lblEstudiante;
        private Label lblMayor;
        private Label lblMenor;
        private Label lblDescEdad;
        private PictureBox pictureBox1;
    }
}