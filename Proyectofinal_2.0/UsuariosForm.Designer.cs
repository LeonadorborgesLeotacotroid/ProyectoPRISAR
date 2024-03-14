namespace Proyectofinal_2._0
{
    partial class UsuariosForm
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
            this.components = new System.ComponentModel.Container();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.close = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idusuario1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usuarios1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contrasena1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.roles1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estado1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtId = new System.Windows.Forms.TextBox();
            this.button4 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.adminAddUsers_addBtn = new System.Windows.Forms.Button();
            this.CBEstado = new System.Windows.Forms.ComboBox();
            this.CBrol = new System.Windows.Forms.ComboBox();
            this.txtContrasena = new System.Windows.Forms.TextBox();
            this.txtUser = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ctrlProductoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnEliminar = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ctrlProductoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.txtId);
            this.panel2.Controls.Add(this.txtBuscar);
            this.panel2.Controls.Add(this.btnBuscar);
            this.panel2.Controls.Add(this.close);
            this.panel2.Controls.Add(this.dataGridView1);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(381, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1119, 780);
            this.panel2.TabIndex = 5;
            // 
            // txtBuscar
            // 
            this.txtBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuscar.Location = new System.Drawing.Point(512, 33);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(133, 34);
            this.txtBuscar.TabIndex = 20;
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(99)))), ((int)(((byte)(102)))));
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscar.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.ForeColor = System.Drawing.Color.White;
            this.btnBuscar.Location = new System.Drawing.Point(355, 22);
            this.btnBuscar.Margin = new System.Windows.Forms.Padding(4);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(140, 45);
            this.btnBuscar.TabIndex = 19;
            this.btnBuscar.Text = "BUSCAR";
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // close
            // 
            this.close.AutoSize = true;
            this.close.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.close.Location = new System.Drawing.Point(1064, 22);
            this.close.Name = "close";
            this.close.Size = new System.Drawing.Size(22, 23);
            this.close.TabIndex = 19;
            this.close.Text = "X";
            this.close.Click += new System.EventHandler(this.close_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idusuario1DataGridViewTextBoxColumn,
            this.usuarios1DataGridViewTextBoxColumn,
            this.contrasena1DataGridViewTextBoxColumn,
            this.roles1DataGridViewTextBoxColumn,
            this.estado1DataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.usersBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(50, 95);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1057, 542);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // idusuario1DataGridViewTextBoxColumn
            // 
            this.idusuario1DataGridViewTextBoxColumn.DataPropertyName = "Id_usuario1";
            this.idusuario1DataGridViewTextBoxColumn.HeaderText = "Id_usuario1";
            this.idusuario1DataGridViewTextBoxColumn.Name = "idusuario1DataGridViewTextBoxColumn";
            // 
            // usuarios1DataGridViewTextBoxColumn
            // 
            this.usuarios1DataGridViewTextBoxColumn.DataPropertyName = "Usuarios1";
            this.usuarios1DataGridViewTextBoxColumn.HeaderText = "Usuarios1";
            this.usuarios1DataGridViewTextBoxColumn.Name = "usuarios1DataGridViewTextBoxColumn";
            // 
            // contrasena1DataGridViewTextBoxColumn
            // 
            this.contrasena1DataGridViewTextBoxColumn.DataPropertyName = "Contrasena1";
            this.contrasena1DataGridViewTextBoxColumn.HeaderText = "Contrasena1";
            this.contrasena1DataGridViewTextBoxColumn.Name = "contrasena1DataGridViewTextBoxColumn";
            // 
            // roles1DataGridViewTextBoxColumn
            // 
            this.roles1DataGridViewTextBoxColumn.DataPropertyName = "Roles1";
            this.roles1DataGridViewTextBoxColumn.HeaderText = "Roles1";
            this.roles1DataGridViewTextBoxColumn.Name = "roles1DataGridViewTextBoxColumn";
            // 
            // estado1DataGridViewTextBoxColumn
            // 
            this.estado1DataGridViewTextBoxColumn.DataPropertyName = "Estado1";
            this.estado1DataGridViewTextBoxColumn.HeaderText = "Estado1";
            this.estado1DataGridViewTextBoxColumn.Name = "estado1DataGridViewTextBoxColumn";
            // 
            // usersBindingSource
            // 
            this.usersBindingSource.DataSource = typeof(Proyectofinal_2._0.Users);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(24, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(296, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "Informacion de Usuarios";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.btnEliminar);
            this.panel1.Controls.Add(this.button4);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.btnLimpiar);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.adminAddUsers_addBtn);
            this.panel1.Controls.Add(this.CBEstado);
            this.panel1.Controls.Add(this.CBrol);
            this.panel1.Controls.Add(this.txtContrasena);
            this.panel1.Controls.Add(this.txtUser);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(381, 780);
            this.panel1.TabIndex = 4;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // txtId
            // 
            this.txtId.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtId.Location = new System.Drawing.Point(100, 664);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(133, 34);
            this.txtId.TabIndex = 21;
            this.txtId.Visible = false;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(99)))), ((int)(((byte)(102)))));
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.Color.White;
            this.button4.Location = new System.Drawing.Point(119, 219);
            this.button4.Margin = new System.Windows.Forms.Padding(4);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(141, 44);
            this.button4.TabIndex = 18;
            this.button4.Text = "Importar";
            this.button4.UseVisualStyleBackColor = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Silver;
            this.pictureBox1.Location = new System.Drawing.Point(119, 71);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(141, 128);
            this.pictureBox1.TabIndex = 17;
            this.pictureBox1.TabStop = false;
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(99)))), ((int)(((byte)(102)))));
            this.btnLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpiar.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiar.ForeColor = System.Drawing.Color.White;
            this.btnLimpiar.Location = new System.Drawing.Point(29, 661);
            this.btnLimpiar.Margin = new System.Windows.Forms.Padding(4);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(151, 45);
            this.btnLimpiar.TabIndex = 16;
            this.btnLimpiar.Text = "LIMPIAR";
            this.btnLimpiar.UseVisualStyleBackColor = false;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(99)))), ((int)(((byte)(102)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(191, 592);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(167, 45);
            this.button1.TabIndex = 14;
            this.button1.Text = "SELECCIONAR";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // adminAddUsers_addBtn
            // 
            this.adminAddUsers_addBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(99)))), ((int)(((byte)(102)))));
            this.adminAddUsers_addBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.adminAddUsers_addBtn.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adminAddUsers_addBtn.ForeColor = System.Drawing.Color.White;
            this.adminAddUsers_addBtn.Location = new System.Drawing.Point(29, 592);
            this.adminAddUsers_addBtn.Margin = new System.Windows.Forms.Padding(4);
            this.adminAddUsers_addBtn.Name = "adminAddUsers_addBtn";
            this.adminAddUsers_addBtn.Size = new System.Drawing.Size(140, 45);
            this.adminAddUsers_addBtn.TabIndex = 13;
            this.adminAddUsers_addBtn.Text = "GUARDAR";
            this.adminAddUsers_addBtn.UseVisualStyleBackColor = false;
            this.adminAddUsers_addBtn.Click += new System.EventHandler(this.adminAddUsers_addBtn_Click);
            // 
            // CBEstado
            // 
            this.CBEstado.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.CBEstado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CBEstado.FormattingEnabled = true;
            this.CBEstado.Items.AddRange(new object[] {
            "Activo",
            "Inactivo"});
            this.CBEstado.Location = new System.Drawing.Point(185, 501);
            this.CBEstado.Name = "CBEstado";
            this.CBEstado.Size = new System.Drawing.Size(173, 33);
            this.CBEstado.TabIndex = 9;
            // 
            // CBrol
            // 
            this.CBrol.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.CBrol.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CBrol.FormattingEnabled = true;
            this.CBrol.Items.AddRange(new object[] {
            "Administrador",
            "Empleado"});
            this.CBrol.Location = new System.Drawing.Point(185, 437);
            this.CBrol.Name = "CBrol";
            this.CBrol.Size = new System.Drawing.Size(173, 33);
            this.CBrol.TabIndex = 8;
            // 
            // txtContrasena
            // 
            this.txtContrasena.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txtContrasena.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtContrasena.Location = new System.Drawing.Point(185, 373);
            this.txtContrasena.Name = "txtContrasena";
            this.txtContrasena.Size = new System.Drawing.Size(173, 30);
            this.txtContrasena.TabIndex = 7;
            // 
            // txtUser
            // 
            this.txtUser.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txtUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUser.Location = new System.Drawing.Point(185, 308);
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(173, 30);
            this.txtUser.TabIndex = 6;
            this.txtUser.TextChanged += new System.EventHandler(this.txtUser_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(39, 511);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(84, 23);
            this.label6.TabIndex = 5;
            this.label6.Text = "Estado:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(39, 447);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 23);
            this.label5.TabIndex = 4;
            this.label5.Text = "Rol:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(39, 377);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(130, 23);
            this.label4.TabIndex = 3;
            this.label4.Text = "Contraseña:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(39, 315);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 23);
            this.label3.TabIndex = 2;
            this.label3.Text = "Usuario: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(51, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(296, 28);
            this.label2.TabIndex = 1;
            this.label2.Text = "Informacion de Usuarios";
            // 
            // ctrlProductoBindingSource
            // 
            this.ctrlProductoBindingSource.DataSource = typeof(Proyectofinal_2._0.Ctrl_Producto);
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(99)))), ((int)(((byte)(102)))));
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminar.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.ForeColor = System.Drawing.Color.White;
            this.btnEliminar.Location = new System.Drawing.Point(196, 664);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(4);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(151, 45);
            this.btnEliminar.TabIndex = 19;
            this.btnEliminar.Text = "ELIMINAR";
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // UsuariosForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1500, 780);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "UsuariosForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UsuariosForm";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ctrlProductoBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label close;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button adminAddUsers_addBtn;
        private System.Windows.Forms.ComboBox CBEstado;
        private System.Windows.Forms.ComboBox CBrol;
        private System.Windows.Forms.TextBox txtContrasena;
        private System.Windows.Forms.TextBox txtUser;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.BindingSource usersBindingSource;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.BindingSource ctrlProductoBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn idusuario1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn usuarios1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn contrasena1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn roles1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn estado1DataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btnEliminar;
    }
}