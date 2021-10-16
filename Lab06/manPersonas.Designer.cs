
namespace Lab06
{
    partial class manPersonas
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.pTipoBusqueda = new System.Windows.Forms.Panel();
            this.lblTipoBusqueda = new System.Windows.Forms.Label();
            this.rbtnCodigo = new System.Windows.Forms.RadioButton();
            this.rbtnApellido = new System.Windows.Forms.RadioButton();
            this.rbtnNombre = new System.Windows.Forms.RadioButton();
            this.dgvListado = new System.Windows.Forms.DataGridView();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnInsertar = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnListar = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtEnrollmentDate = new System.Windows.Forms.DateTimePicker();
            this.lblInscripcion = new System.Windows.Forms.Label();
            this.txtHireDate = new System.Windows.Forms.DateTimePicker();
            this.lblContrato = new System.Windows.Forms.Label();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.lblApellido = new System.Windows.Forms.Label();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.lblNombres = new System.Windows.Forms.Label();
            this.txtPersonID = new System.Windows.Forms.TextBox();
            this.lblPersonID = new System.Windows.Forms.Label();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnOrdenarPorApelido = new System.Windows.Forms.Button();
            this.rbtnContrato = new System.Windows.Forms.RadioButton();
            this.rbtnInscripcion = new System.Windows.Forms.RadioButton();
            this.pTipoBusqueda.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListado)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pTipoBusqueda
            // 
            this.pTipoBusqueda.Controls.Add(this.rbtnInscripcion);
            this.pTipoBusqueda.Controls.Add(this.rbtnContrato);
            this.pTipoBusqueda.Controls.Add(this.lblTipoBusqueda);
            this.pTipoBusqueda.Controls.Add(this.rbtnCodigo);
            this.pTipoBusqueda.Controls.Add(this.rbtnApellido);
            this.pTipoBusqueda.Controls.Add(this.rbtnNombre);
            this.pTipoBusqueda.Location = new System.Drawing.Point(12, 269);
            this.pTipoBusqueda.Name = "pTipoBusqueda";
            this.pTipoBusqueda.Size = new System.Drawing.Size(473, 98);
            this.pTipoBusqueda.TabIndex = 19;
            // 
            // lblTipoBusqueda
            // 
            this.lblTipoBusqueda.AutoSize = true;
            this.lblTipoBusqueda.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipoBusqueda.Location = new System.Drawing.Point(8, 18);
            this.lblTipoBusqueda.Name = "lblTipoBusqueda";
            this.lblTipoBusqueda.Size = new System.Drawing.Size(168, 20);
            this.lblTipoBusqueda.TabIndex = 10;
            this.lblTipoBusqueda.Text = "Elegir tipo de búsqueda";
            // 
            // rbtnCodigo
            // 
            this.rbtnCodigo.AutoSize = true;
            this.rbtnCodigo.Checked = true;
            this.rbtnCodigo.Location = new System.Drawing.Point(12, 54);
            this.rbtnCodigo.Name = "rbtnCodigo";
            this.rbtnCodigo.Size = new System.Drawing.Size(73, 21);
            this.rbtnCodigo.TabIndex = 7;
            this.rbtnCodigo.TabStop = true;
            this.rbtnCodigo.Text = "Código";
            this.rbtnCodigo.UseVisualStyleBackColor = true;
            // 
            // rbtnApellido
            // 
            this.rbtnApellido.AutoSize = true;
            this.rbtnApellido.Location = new System.Drawing.Point(176, 54);
            this.rbtnApellido.Name = "rbtnApellido";
            this.rbtnApellido.Size = new System.Drawing.Size(79, 21);
            this.rbtnApellido.TabIndex = 9;
            this.rbtnApellido.TabStop = true;
            this.rbtnApellido.Text = "Apellido";
            this.rbtnApellido.UseVisualStyleBackColor = true;
            // 
            // rbtnNombre
            // 
            this.rbtnNombre.AutoSize = true;
            this.rbtnNombre.Location = new System.Drawing.Point(91, 54);
            this.rbtnNombre.Name = "rbtnNombre";
            this.rbtnNombre.Size = new System.Drawing.Size(79, 21);
            this.rbtnNombre.TabIndex = 8;
            this.rbtnNombre.TabStop = true;
            this.rbtnNombre.Text = "Nombre";
            this.rbtnNombre.UseVisualStyleBackColor = true;
            // 
            // dgvListado
            // 
            this.dgvListado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListado.Location = new System.Drawing.Point(12, 373);
            this.dgvListado.Name = "dgvListado";
            this.dgvListado.ReadOnly = true;
            this.dgvListado.RowHeadersVisible = false;
            this.dgvListado.RowHeadersWidth = 51;
            this.dgvListado.RowTemplate.Height = 24;
            this.dgvListado.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvListado.Size = new System.Drawing.Size(720, 311);
            this.dgvListado.TabIndex = 18;
            this.dgvListado.SelectionChanged += new System.EventHandler(this.dgvListado_SelectionChanged);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(601, 207);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(131, 33);
            this.btnEliminar.TabIndex = 17;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(601, 157);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(131, 33);
            this.btnModificar.TabIndex = 16;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnInsertar
            // 
            this.btnInsertar.Location = new System.Drawing.Point(601, 106);
            this.btnInsertar.Name = "btnInsertar";
            this.btnInsertar.Size = new System.Drawing.Size(131, 33);
            this.btnInsertar.TabIndex = 15;
            this.btnInsertar.Text = "Insertar";
            this.btnInsertar.UseVisualStyleBackColor = true;
            this.btnInsertar.Click += new System.EventHandler(this.btnInsertar_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(601, 58);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(131, 33);
            this.btnBuscar.TabIndex = 14;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // btnListar
            // 
            this.btnListar.Location = new System.Drawing.Point(601, 10);
            this.btnListar.Name = "btnListar";
            this.btnListar.Size = new System.Drawing.Size(131, 33);
            this.btnListar.TabIndex = 13;
            this.btnListar.Text = "Listar";
            this.btnListar.UseVisualStyleBackColor = true;
            this.btnListar.Click += new System.EventHandler(this.btnListar_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtEnrollmentDate);
            this.panel1.Controls.Add(this.lblInscripcion);
            this.panel1.Controls.Add(this.txtHireDate);
            this.panel1.Controls.Add(this.lblContrato);
            this.panel1.Controls.Add(this.txtFirstName);
            this.panel1.Controls.Add(this.lblApellido);
            this.panel1.Controls.Add(this.txtLastName);
            this.panel1.Controls.Add(this.lblNombres);
            this.panel1.Controls.Add(this.txtPersonID);
            this.panel1.Controls.Add(this.lblPersonID);
            this.panel1.Location = new System.Drawing.Point(12, 10);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(508, 253);
            this.panel1.TabIndex = 12;
            // 
            // txtEnrollmentDate
            // 
            this.txtEnrollmentDate.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEnrollmentDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txtEnrollmentDate.Location = new System.Drawing.Point(215, 179);
            this.txtEnrollmentDate.Name = "txtEnrollmentDate";
            this.txtEnrollmentDate.ShowCheckBox = true;
            this.txtEnrollmentDate.Size = new System.Drawing.Size(191, 27);
            this.txtEnrollmentDate.TabIndex = 9;
            // 
            // lblInscripcion
            // 
            this.lblInscripcion.AutoSize = true;
            this.lblInscripcion.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInscripcion.Location = new System.Drawing.Point(212, 158);
            this.lblInscripcion.Name = "lblInscripcion";
            this.lblInscripcion.Size = new System.Drawing.Size(80, 20);
            this.lblInscripcion.TabIndex = 8;
            this.lblInscripcion.Text = "Inscripción";
            // 
            // txtHireDate
            // 
            this.txtHireDate.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHireDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txtHireDate.Location = new System.Drawing.Point(6, 179);
            this.txtHireDate.Name = "txtHireDate";
            this.txtHireDate.ShowCheckBox = true;
            this.txtHireDate.Size = new System.Drawing.Size(147, 27);
            this.txtHireDate.TabIndex = 7;
            // 
            // lblContrato
            // 
            this.lblContrato.AutoSize = true;
            this.lblContrato.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContrato.Location = new System.Drawing.Point(3, 158);
            this.lblContrato.Name = "lblContrato";
            this.lblContrato.Size = new System.Drawing.Size(67, 20);
            this.lblContrato.TabIndex = 6;
            this.lblContrato.Text = "Contrato";
            // 
            // txtFirstName
            // 
            this.txtFirstName.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFirstName.Location = new System.Drawing.Point(215, 112);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(191, 27);
            this.txtFirstName.TabIndex = 5;
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApellido.Location = new System.Drawing.Point(212, 91);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(70, 20);
            this.lblApellido.TabIndex = 4;
            this.lblApellido.Text = "Nombres";
            // 
            // txtLastName
            // 
            this.txtLastName.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLastName.Location = new System.Drawing.Point(6, 112);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(147, 27);
            this.txtLastName.TabIndex = 3;
            // 
            // lblNombres
            // 
            this.lblNombres.AutoSize = true;
            this.lblNombres.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombres.Location = new System.Drawing.Point(3, 91);
            this.lblNombres.Name = "lblNombres";
            this.lblNombres.Size = new System.Drawing.Size(72, 20);
            this.lblNombres.TabIndex = 2;
            this.lblNombres.Text = "Apellidos";
            // 
            // txtPersonID
            // 
            this.txtPersonID.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPersonID.Location = new System.Drawing.Point(6, 48);
            this.txtPersonID.Name = "txtPersonID";
            this.txtPersonID.Size = new System.Drawing.Size(147, 27);
            this.txtPersonID.TabIndex = 1;
            // 
            // lblPersonID
            // 
            this.lblPersonID.AutoSize = true;
            this.lblPersonID.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPersonID.Location = new System.Drawing.Point(3, 27);
            this.lblPersonID.Name = "lblPersonID";
            this.lblPersonID.Size = new System.Drawing.Size(58, 20);
            this.lblPersonID.TabIndex = 0;
            this.lblPersonID.Text = "Código";
            // 
            // btnNuevo
            // 
            this.btnNuevo.BackColor = System.Drawing.Color.SpringGreen;
            this.btnNuevo.Location = new System.Drawing.Point(601, 258);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(131, 33);
            this.btnNuevo.TabIndex = 20;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.UseVisualStyleBackColor = false;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(491, 324);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 20);
            this.label1.TabIndex = 10;
            this.label1.Text = "Ordenar por:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnOrdenarPorApelido
            // 
            this.btnOrdenarPorApelido.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnOrdenarPorApelido.Location = new System.Drawing.Point(601, 317);
            this.btnOrdenarPorApelido.Name = "btnOrdenarPorApelido";
            this.btnOrdenarPorApelido.Size = new System.Drawing.Size(131, 33);
            this.btnOrdenarPorApelido.TabIndex = 21;
            this.btnOrdenarPorApelido.Text = "Apellido";
            this.btnOrdenarPorApelido.UseVisualStyleBackColor = false;
            this.btnOrdenarPorApelido.Click += new System.EventHandler(this.btnOrdenarPorApelido_Click);
            // 
            // rbtnContrato
            // 
            this.rbtnContrato.AutoSize = true;
            this.rbtnContrato.Location = new System.Drawing.Point(261, 54);
            this.rbtnContrato.Name = "rbtnContrato";
            this.rbtnContrato.Size = new System.Drawing.Size(83, 21);
            this.rbtnContrato.TabIndex = 11;
            this.rbtnContrato.TabStop = true;
            this.rbtnContrato.Text = "Contrato";
            this.rbtnContrato.UseVisualStyleBackColor = true;
            // 
            // rbtnInscripcion
            // 
            this.rbtnInscripcion.AutoSize = true;
            this.rbtnInscripcion.Location = new System.Drawing.Point(346, 54);
            this.rbtnInscripcion.Name = "rbtnInscripcion";
            this.rbtnInscripcion.Size = new System.Drawing.Size(96, 21);
            this.rbtnInscripcion.TabIndex = 12;
            this.rbtnInscripcion.TabStop = true;
            this.rbtnInscripcion.Text = "Inscripción";
            this.rbtnInscripcion.UseVisualStyleBackColor = true;
            // 
            // manPersonas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(744, 692);
            this.Controls.Add(this.btnOrdenarPorApelido);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.pTipoBusqueda);
            this.Controls.Add(this.dgvListado);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnInsertar);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.btnListar);
            this.Controls.Add(this.panel1);
            this.Name = "manPersonas";
            this.Text = "Mantenimiento de Personas";
            this.Load += new System.EventHandler(this.manPersonas_Load);
            this.pTipoBusqueda.ResumeLayout(false);
            this.pTipoBusqueda.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListado)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pTipoBusqueda;
        private System.Windows.Forms.Label lblTipoBusqueda;
        private System.Windows.Forms.RadioButton rbtnCodigo;
        private System.Windows.Forms.RadioButton rbtnApellido;
        private System.Windows.Forms.RadioButton rbtnNombre;
        private System.Windows.Forms.DataGridView dgvListado;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnInsertar;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnListar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DateTimePicker txtEnrollmentDate;
        private System.Windows.Forms.Label lblInscripcion;
        private System.Windows.Forms.DateTimePicker txtHireDate;
        private System.Windows.Forms.Label lblContrato;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.Label lblNombres;
        private System.Windows.Forms.TextBox txtPersonID;
        private System.Windows.Forms.Label lblPersonID;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnOrdenarPorApelido;
        private System.Windows.Forms.RadioButton rbtnInscripcion;
        private System.Windows.Forms.RadioButton rbtnContrato;
    }
}

