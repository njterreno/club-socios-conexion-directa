namespace Interfaz
{
    partial class frmBuscarSocios
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
            this.dgvSocios = new System.Windows.Forms.DataGridView();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnCargarBD = new System.Windows.Forms.Button();
            this.cmbSeleccionFiltro = new System.Windows.Forms.ComboBox();
            this.txtFiltro = new System.Windows.Forms.TextBox();
            this.cbxActivo = new System.Windows.Forms.ComboBox();
            this.lblDNI = new System.Windows.Forms.Label();
            this.lblDireccion = new System.Windows.Forms.Label();
            this.Activo = new System.Windows.Forms.Label();
            this.lblTelContacto = new System.Windows.Forms.Label();
            this.lblCorreoElectronico = new System.Windows.Forms.Label();
            this.lblFechaNac = new System.Windows.Forms.Label();
            this.lblFechaAlta = new System.Windows.Forms.Label();
            this.txtDNI = new System.Windows.Forms.TextBox();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.txtTelContacto = new System.Windows.Forms.TextBox();
            this.txtCorreoElectronico = new System.Windows.Forms.TextBox();
            this.lblTelefono = new System.Windows.Forms.Label();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.lblApellido = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.txtLimpiarCampos = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtIDSocio = new System.Windows.Forms.TextBox();
            this.txtFechaNac = new System.Windows.Forms.MaskedTextBox();
            this.txtFechaAlta = new System.Windows.Forms.MaskedTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSocios)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvSocios
            // 
            this.dgvSocios.AllowUserToAddRows = false;
            this.dgvSocios.AllowUserToDeleteRows = false;
            this.dgvSocios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSocios.Location = new System.Drawing.Point(12, 72);
            this.dgvSocios.Name = "dgvSocios";
            this.dgvSocios.ReadOnly = true;
            this.dgvSocios.Size = new System.Drawing.Size(732, 351);
            this.dgvSocios.TabIndex = 0;
            this.dgvSocios.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSocios_CellContentDoubleClick);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(305, 15);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(85, 34);
            this.btnBuscar.TabIndex = 3;
            this.btnBuscar.Tag = "2";
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // btnCargarBD
            // 
            this.btnCargarBD.Location = new System.Drawing.Point(595, 10);
            this.btnCargarBD.Name = "btnCargarBD";
            this.btnCargarBD.Size = new System.Drawing.Size(107, 45);
            this.btnCargarBD.TabIndex = 15;
            this.btnCargarBD.Text = "Cargar Base de Datos";
            this.btnCargarBD.UseVisualStyleBackColor = true;
            this.btnCargarBD.Click += new System.EventHandler(this.btnCargarBD_Click);
            // 
            // cmbSeleccionFiltro
            // 
            this.cmbSeleccionFiltro.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSeleccionFiltro.FormattingEnabled = true;
            this.cmbSeleccionFiltro.Items.AddRange(new object[] {
            "DNI",
            "Nombre",
            "Apellido"});
            this.cmbSeleccionFiltro.Location = new System.Drawing.Point(15, 23);
            this.cmbSeleccionFiltro.Name = "cmbSeleccionFiltro";
            this.cmbSeleccionFiltro.Size = new System.Drawing.Size(121, 21);
            this.cmbSeleccionFiltro.TabIndex = 0;
            // 
            // txtFiltro
            // 
            this.txtFiltro.Location = new System.Drawing.Point(157, 23);
            this.txtFiltro.Name = "txtFiltro";
            this.txtFiltro.Size = new System.Drawing.Size(128, 20);
            this.txtFiltro.TabIndex = 1;
            // 
            // cbxActivo
            // 
            this.cbxActivo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxActivo.FormattingEnabled = true;
            this.cbxActivo.Items.AddRange(new object[] {
            "SI",
            "NO"});
            this.cbxActivo.Location = new System.Drawing.Point(906, 320);
            this.cbxActivo.Name = "cbxActivo";
            this.cbxActivo.Size = new System.Drawing.Size(135, 21);
            this.cbxActivo.TabIndex = 11;
            // 
            // lblDNI
            // 
            this.lblDNI.AutoSize = true;
            this.lblDNI.Location = new System.Drawing.Point(792, 111);
            this.lblDNI.Name = "lblDNI";
            this.lblDNI.Size = new System.Drawing.Size(26, 13);
            this.lblDNI.TabIndex = 40;
            this.lblDNI.Text = "DNI";
            // 
            // lblDireccion
            // 
            this.lblDireccion.AutoSize = true;
            this.lblDireccion.Location = new System.Drawing.Point(792, 359);
            this.lblDireccion.Name = "lblDireccion";
            this.lblDireccion.Size = new System.Drawing.Size(52, 13);
            this.lblDireccion.TabIndex = 39;
            this.lblDireccion.Text = "Direccion";
            // 
            // Activo
            // 
            this.Activo.AutoSize = true;
            this.Activo.Location = new System.Drawing.Point(792, 323);
            this.Activo.Name = "Activo";
            this.Activo.Size = new System.Drawing.Size(37, 13);
            this.Activo.TabIndex = 38;
            this.Activo.Text = "Activo";
            // 
            // lblTelContacto
            // 
            this.lblTelContacto.AutoSize = true;
            this.lblTelContacto.Location = new System.Drawing.Point(792, 288);
            this.lblTelContacto.Name = "lblTelContacto";
            this.lblTelContacto.Size = new System.Drawing.Size(110, 13);
            this.lblTelContacto.TabIndex = 37;
            this.lblTelContacto.Text = "Telefono de Contacto";
            // 
            // lblCorreoElectronico
            // 
            this.lblCorreoElectronico.AutoSize = true;
            this.lblCorreoElectronico.Location = new System.Drawing.Point(792, 253);
            this.lblCorreoElectronico.Name = "lblCorreoElectronico";
            this.lblCorreoElectronico.Size = new System.Drawing.Size(94, 13);
            this.lblCorreoElectronico.TabIndex = 36;
            this.lblCorreoElectronico.Text = "Correo Electronico";
            // 
            // lblFechaNac
            // 
            this.lblFechaNac.AutoSize = true;
            this.lblFechaNac.Location = new System.Drawing.Point(792, 181);
            this.lblFechaNac.Name = "lblFechaNac";
            this.lblFechaNac.Size = new System.Drawing.Size(60, 13);
            this.lblFechaNac.TabIndex = 35;
            this.lblFechaNac.Text = "Fecha Nac";
            // 
            // lblFechaAlta
            // 
            this.lblFechaAlta.AutoSize = true;
            this.lblFechaAlta.Location = new System.Drawing.Point(792, 146);
            this.lblFechaAlta.Name = "lblFechaAlta";
            this.lblFechaAlta.Size = new System.Drawing.Size(58, 13);
            this.lblFechaAlta.TabIndex = 34;
            this.lblFechaAlta.Text = "Fecha Alta";
            // 
            // txtDNI
            // 
            this.txtDNI.Location = new System.Drawing.Point(906, 108);
            this.txtDNI.MaxLength = 10;
            this.txtDNI.Name = "txtDNI";
            this.txtDNI.Size = new System.Drawing.Size(133, 20);
            this.txtDNI.TabIndex = 5;
            this.txtDNI.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDNI_KeyPress);
            // 
            // txtDireccion
            // 
            this.txtDireccion.Location = new System.Drawing.Point(906, 356);
            this.txtDireccion.MaxLength = 60;
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(137, 20);
            this.txtDireccion.TabIndex = 12;
            // 
            // txtTelContacto
            // 
            this.txtTelContacto.Location = new System.Drawing.Point(906, 285);
            this.txtTelContacto.MaxLength = 15;
            this.txtTelContacto.Name = "txtTelContacto";
            this.txtTelContacto.Size = new System.Drawing.Size(135, 20);
            this.txtTelContacto.TabIndex = 10;
            this.txtTelContacto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTelContacto_KeyPress);
            // 
            // txtCorreoElectronico
            // 
            this.txtCorreoElectronico.Location = new System.Drawing.Point(906, 250);
            this.txtCorreoElectronico.Name = "txtCorreoElectronico";
            this.txtCorreoElectronico.Size = new System.Drawing.Size(135, 20);
            this.txtCorreoElectronico.TabIndex = 9;
            // 
            // lblTelefono
            // 
            this.lblTelefono.AutoSize = true;
            this.lblTelefono.Location = new System.Drawing.Point(792, 217);
            this.lblTelefono.Name = "lblTelefono";
            this.lblTelefono.Size = new System.Drawing.Size(49, 13);
            this.lblTelefono.TabIndex = 27;
            this.lblTelefono.Text = "Telefono";
            // 
            // txtTelefono
            // 
            this.txtTelefono.Location = new System.Drawing.Point(906, 214);
            this.txtTelefono.MaxLength = 15;
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(135, 20);
            this.txtTelefono.TabIndex = 8;
            this.txtTelefono.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTelefono_KeyPress);
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.Location = new System.Drawing.Point(792, 74);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(44, 13);
            this.lblApellido.TabIndex = 25;
            this.lblApellido.Text = "Apellido";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(792, 38);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(44, 13);
            this.lblNombre.TabIndex = 24;
            this.lblNombre.Text = "Nombre";
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(906, 71);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(133, 20);
            this.txtApellido.TabIndex = 4;
            this.txtApellido.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtApellido_KeyPress);
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(906, 35);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(133, 20);
            this.txtNombre.TabIndex = 3;
            this.txtNombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNombre_KeyPress);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(941, 424);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(102, 35);
            this.btnGuardar.TabIndex = 13;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // txtLimpiarCampos
            // 
            this.txtLimpiarCampos.Location = new System.Drawing.Point(793, 424);
            this.txtLimpiarCampos.Name = "txtLimpiarCampos";
            this.txtLimpiarCampos.Size = new System.Drawing.Size(75, 35);
            this.txtLimpiarCampos.TabIndex = 14;
            this.txtLimpiarCampos.Text = "Limpiar Campos";
            this.txtLimpiarCampos.UseVisualStyleBackColor = true;
            this.txtLimpiarCampos.Click += new System.EventHandler(this.txtLimpiarCampos_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(792, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 13);
            this.label1.TabIndex = 44;
            this.label1.Text = "ID";
            // 
            // txtIDSocio
            // 
            this.txtIDSocio.Location = new System.Drawing.Point(906, 3);
            this.txtIDSocio.Name = "txtIDSocio";
            this.txtIDSocio.ReadOnly = true;
            this.txtIDSocio.Size = new System.Drawing.Size(133, 20);
            this.txtIDSocio.TabIndex = 45;
            // 
            // txtFechaNac
            // 
            this.txtFechaNac.Location = new System.Drawing.Point(906, 178);
            this.txtFechaNac.Mask = "00/00/0000";
            this.txtFechaNac.Name = "txtFechaNac";
            this.txtFechaNac.Size = new System.Drawing.Size(133, 20);
            this.txtFechaNac.TabIndex = 48;
            this.txtFechaNac.ValidatingType = typeof(System.DateTime);
            // 
            // txtFechaAlta
            // 
            this.txtFechaAlta.Location = new System.Drawing.Point(906, 143);
            this.txtFechaAlta.Mask = "00/00/0000";
            this.txtFechaAlta.Name = "txtFechaAlta";
            this.txtFechaAlta.Size = new System.Drawing.Size(133, 20);
            this.txtFechaAlta.TabIndex = 49;
            this.txtFechaAlta.ValidatingType = typeof(System.DateTime);
            // 
            // frmBuscarSocios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1080, 471);
            this.Controls.Add(this.txtFechaAlta);
            this.Controls.Add(this.txtFechaNac);
            this.Controls.Add(this.txtIDSocio);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtLimpiarCampos);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.cbxActivo);
            this.Controls.Add(this.lblDNI);
            this.Controls.Add(this.lblDireccion);
            this.Controls.Add(this.Activo);
            this.Controls.Add(this.lblTelContacto);
            this.Controls.Add(this.lblCorreoElectronico);
            this.Controls.Add(this.lblFechaNac);
            this.Controls.Add(this.lblFechaAlta);
            this.Controls.Add(this.txtDNI);
            this.Controls.Add(this.txtDireccion);
            this.Controls.Add(this.txtTelContacto);
            this.Controls.Add(this.txtCorreoElectronico);
            this.Controls.Add(this.lblTelefono);
            this.Controls.Add(this.txtTelefono);
            this.Controls.Add(this.lblApellido);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.txtApellido);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.txtFiltro);
            this.Controls.Add(this.cmbSeleccionFiltro);
            this.Controls.Add(this.btnCargarBD);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.dgvSocios);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmBuscarSocios";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BuscarSocios";
            ((System.ComponentModel.ISupportInitialize)(this.dgvSocios)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvSocios;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnCargarBD;
        private System.Windows.Forms.TextBox txtFiltro;
        public System.Windows.Forms.ComboBox cmbSeleccionFiltro;
        private System.Windows.Forms.ComboBox cbxActivo;
        private System.Windows.Forms.Label lblDNI;
        private System.Windows.Forms.Label lblDireccion;
        private System.Windows.Forms.Label Activo;
        private System.Windows.Forms.Label lblTelContacto;
        private System.Windows.Forms.Label lblCorreoElectronico;
        private System.Windows.Forms.Label lblFechaNac;
        private System.Windows.Forms.Label lblFechaAlta;
        private System.Windows.Forms.TextBox txtDNI;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.TextBox txtTelContacto;
        private System.Windows.Forms.TextBox txtCorreoElectronico;
        private System.Windows.Forms.Label lblTelefono;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button txtLimpiarCampos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtIDSocio;
        private System.Windows.Forms.MaskedTextBox txtFechaNac;
        private System.Windows.Forms.MaskedTextBox txtFechaAlta;
    }
}