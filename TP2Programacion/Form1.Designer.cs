namespace TP2Programacion
{
    partial class Form1
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
            dtgvLista = new DataGridView();
            Codigo = new DataGridViewTextBoxColumn();
            Nombre = new DataGridViewTextBoxColumn();
            Precio = new DataGridViewTextBoxColumn();
            labelCodigo = new Label();
            labelNombre = new Label();
            labelPrecio = new Label();
            txtCodigo = new TextBox();
            txtNombre = new TextBox();
            txtPrecio = new TextBox();
            labelInformacion = new Label();
            btnAdicionar = new Button();
            btnBorrar = new Button();
            ((System.ComponentModel.ISupportInitialize)dtgvLista).BeginInit();
            SuspendLayout();
            // 
            // dtgvLista
            // 
            dtgvLista.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgvLista.Columns.AddRange(new DataGridViewColumn[] { Codigo, Nombre, Precio });
            dtgvLista.Location = new Point(98, 245);
            dtgvLista.Name = "dtgvLista";
            dtgvLista.RowTemplate.Height = 25;
            dtgvLista.Size = new Size(498, 193);
            dtgvLista.TabIndex = 0;
            dtgvLista.CellClick += dtgvLista_CellClick;
            dtgvLista.CellContentClick += dataGridView1_CellContentClick;
            // 
            // Codigo
            // 
            Codigo.HeaderText = "Codigo Auto";
            Codigo.Name = "Codigo";
            // 
            // Nombre
            // 
            Nombre.HeaderText = "Nombre Auto";
            Nombre.Name = "Nombre";
            // 
            // Precio
            // 
            Precio.HeaderText = "Precio Auto";
            Precio.Name = "Precio";
            // 
            // labelCodigo
            // 
            labelCodigo.AutoSize = true;
            labelCodigo.Location = new Point(103, 31);
            labelCodigo.Name = "labelCodigo";
            labelCodigo.Size = new Size(46, 15);
            labelCodigo.TabIndex = 1;
            labelCodigo.Text = "Codigo";
            // 
            // labelNombre
            // 
            labelNombre.AutoSize = true;
            labelNombre.Location = new Point(98, 78);
            labelNombre.Name = "labelNombre";
            labelNombre.Size = new Size(51, 15);
            labelNombre.TabIndex = 2;
            labelNombre.Text = "Nombre";
            // 
            // labelPrecio
            // 
            labelPrecio.AutoSize = true;
            labelPrecio.Location = new Point(103, 128);
            labelPrecio.Name = "labelPrecio";
            labelPrecio.Size = new Size(40, 15);
            labelPrecio.TabIndex = 3;
            labelPrecio.Text = "Precio";
            labelPrecio.Click += label2_Click;
            // 
            // txtCodigo
            // 
            txtCodigo.Location = new Point(206, 31);
            txtCodigo.Name = "txtCodigo";
            txtCodigo.Size = new Size(100, 23);
            txtCodigo.TabIndex = 4;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(206, 78);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(100, 23);
            txtNombre.TabIndex = 5;
            // 
            // txtPrecio
            // 
            txtPrecio.Location = new Point(206, 128);
            txtPrecio.Name = "txtPrecio";
            txtPrecio.Size = new Size(100, 23);
            txtPrecio.TabIndex = 6;
            // 
            // labelInformacion
            // 
            labelInformacion.AutoSize = true;
            labelInformacion.Location = new Point(105, 184);
            labelInformacion.Name = "labelInformacion";
            labelInformacion.Size = new Size(0, 15);
            labelInformacion.TabIndex = 7;
            // 
            // btnAdicionar
            // 
            btnAdicionar.Location = new Point(357, 31);
            btnAdicionar.Name = "btnAdicionar";
            btnAdicionar.Size = new Size(75, 23);
            btnAdicionar.TabIndex = 8;
            btnAdicionar.Text = "Adicionar";
            btnAdicionar.UseVisualStyleBackColor = true;
            btnAdicionar.Click += btnAdicionar_Click;
            // 
            // btnBorrar
            // 
            btnBorrar.Location = new Point(357, 78);
            btnBorrar.Name = "btnBorrar";
            btnBorrar.Size = new Size(75, 23);
            btnBorrar.TabIndex = 9;
            btnBorrar.Text = "Borrar";
            btnBorrar.UseVisualStyleBackColor = true;
            btnBorrar.Click += btnBorrar_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(607, 420);
            Controls.Add(btnBorrar);
            Controls.Add(btnAdicionar);
            Controls.Add(labelInformacion);
            Controls.Add(txtPrecio);
            Controls.Add(txtNombre);
            Controls.Add(txtCodigo);
            Controls.Add(labelPrecio);
            Controls.Add(labelNombre);
            Controls.Add(labelCodigo);
            Controls.Add(dtgvLista);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dtgvLista).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dtgvLista;
        private Label labelCodigo;
        private Label labelNombre;
        private Label labelPrecio;
        private TextBox txtCodigo;
        private TextBox txtNombre;
        private TextBox txtPrecio;
        private Label labelInformacion;
        private Button btnAdicionar;
        private Button btnBorrar;
        private DataGridViewTextBoxColumn Codigo;
        private DataGridViewTextBoxColumn Nombre;
        private DataGridViewTextBoxColumn Precio;
    }
}