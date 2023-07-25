namespace Registro
{
    partial class Form1
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.TB_Telefono = new System.Windows.Forms.TextBox();
            this.TB_Nombre = new System.Windows.Forms.TextBox();
            this.TB_Edad = new System.Windows.Forms.TextBox();
            this.TB_Codigo = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.BuscarNombre_TB = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.DGV_Lista = new System.Windows.Forms.DataGridView();
            this.BT_Nuevo = new System.Windows.Forms.Button();
            this.BT_Eliminar = new System.Windows.Forms.Button();
            this.BT_Registrar = new System.Windows.Forms.Button();
            this.BT_Modificar = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Lista)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.TB_Telefono);
            this.groupBox1.Controls.Add(this.TB_Nombre);
            this.groupBox1.Controls.Add(this.TB_Edad);
            this.groupBox1.Controls.Add(this.TB_Codigo);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(424, 122);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // TB_Telefono
            // 
            this.TB_Telefono.Location = new System.Drawing.Point(266, 76);
            this.TB_Telefono.Name = "TB_Telefono";
            this.TB_Telefono.Size = new System.Drawing.Size(100, 22);
            this.TB_Telefono.TabIndex = 7;
            this.TB_Telefono.TextChanged += new System.EventHandler(this.TB_Telefono_TextChanged);
            // 
            // TB_Nombre
            // 
            this.TB_Nombre.Location = new System.Drawing.Point(259, 29);
            this.TB_Nombre.Name = "TB_Nombre";
            this.TB_Nombre.Size = new System.Drawing.Size(100, 22);
            this.TB_Nombre.TabIndex = 6;
            // 
            // TB_Edad
            // 
            this.TB_Edad.Location = new System.Drawing.Point(56, 76);
            this.TB_Edad.Name = "TB_Edad";
            this.TB_Edad.Size = new System.Drawing.Size(100, 22);
            this.TB_Edad.TabIndex = 5;
            // 
            // TB_Codigo
            // 
            this.TB_Codigo.Enabled = false;
            this.TB_Codigo.Location = new System.Drawing.Point(69, 29);
            this.TB_Codigo.Name = "TB_Codigo";
            this.TB_Codigo.Size = new System.Drawing.Size(100, 22);
            this.TB_Codigo.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(191, 79);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Telefono";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(191, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nombre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Edad";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Codigo";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.BuscarNombre_TB);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(12, 140);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(424, 71);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Buscar";
            // 
            // BuscarNombre_TB
            // 
            this.BuscarNombre_TB.Location = new System.Drawing.Point(74, 30);
            this.BuscarNombre_TB.Name = "BuscarNombre_TB";
            this.BuscarNombre_TB.Size = new System.Drawing.Size(344, 22);
            this.BuscarNombre_TB.TabIndex = 6;
            this.BuscarNombre_TB.TextChanged += new System.EventHandler(this.BuscarNombre_TB_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 33);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 16);
            this.label5.TabIndex = 0;
            this.label5.Text = "Nombre";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.DGV_Lista);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(12, 217);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(424, 221);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Lista";
            // 
            // DGV_Lista
            // 
            this.DGV_Lista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_Lista.Location = new System.Drawing.Point(6, 21);
            this.DGV_Lista.Name = "DGV_Lista";
            this.DGV_Lista.Size = new System.Drawing.Size(412, 194);
            this.DGV_Lista.TabIndex = 0;
            this.DGV_Lista.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGV_Lista_CellContentClick);
            // 
            // BT_Nuevo
            // 
            this.BT_Nuevo.Location = new System.Drawing.Point(18, 444);
            this.BT_Nuevo.Name = "BT_Nuevo";
            this.BT_Nuevo.Size = new System.Drawing.Size(75, 23);
            this.BT_Nuevo.TabIndex = 3;
            this.BT_Nuevo.Text = "Nuevo";
            this.BT_Nuevo.UseVisualStyleBackColor = true;
            this.BT_Nuevo.Click += new System.EventHandler(this.BT_Nuevo_Click);
            // 
            // BT_Eliminar
            // 
            this.BT_Eliminar.Location = new System.Drawing.Point(355, 444);
            this.BT_Eliminar.Name = "BT_Eliminar";
            this.BT_Eliminar.Size = new System.Drawing.Size(75, 23);
            this.BT_Eliminar.TabIndex = 4;
            this.BT_Eliminar.Text = "Eliminar";
            this.BT_Eliminar.UseVisualStyleBackColor = true;
            this.BT_Eliminar.Click += new System.EventHandler(this.BT_Eliminar_Click);
            // 
            // BT_Registrar
            // 
            this.BT_Registrar.Location = new System.Drawing.Point(119, 444);
            this.BT_Registrar.Name = "BT_Registrar";
            this.BT_Registrar.Size = new System.Drawing.Size(75, 23);
            this.BT_Registrar.TabIndex = 5;
            this.BT_Registrar.Text = "Registrar";
            this.BT_Registrar.UseVisualStyleBackColor = true;
            this.BT_Registrar.Click += new System.EventHandler(this.BT_Registrar_Click);
            // 
            // BT_Modificar
            // 
            this.BT_Modificar.Location = new System.Drawing.Point(243, 444);
            this.BT_Modificar.Name = "BT_Modificar";
            this.BT_Modificar.Size = new System.Drawing.Size(75, 23);
            this.BT_Modificar.TabIndex = 6;
            this.BT_Modificar.Text = "Modificar";
            this.BT_Modificar.UseVisualStyleBackColor = true;
            this.BT_Modificar.Click += new System.EventHandler(this.BT_Modificar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(448, 483);
            this.Controls.Add(this.BT_Modificar);
            this.Controls.Add(this.BT_Registrar);
            this.Controls.Add(this.BT_Eliminar);
            this.Controls.Add(this.BT_Nuevo);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Lista)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox TB_Telefono;
        private System.Windows.Forms.TextBox TB_Nombre;
        private System.Windows.Forms.TextBox TB_Edad;
        private System.Windows.Forms.TextBox TB_Codigo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox BuscarNombre_TB;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView DGV_Lista;
        private System.Windows.Forms.Button BT_Nuevo;
        private System.Windows.Forms.Button BT_Eliminar;
        private System.Windows.Forms.Button BT_Registrar;
        private System.Windows.Forms.Button BT_Modificar;
    }
}

