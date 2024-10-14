namespace insertarClienteDapper
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
            this.dgvProveedor = new System.Windows.Forms.DataGridView();
            this.btnObtenerTodo = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tbxCompanyName = new System.Windows.Forms.TextBox();
            this.tbxContactName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbxContactTitle = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbxAddress = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbxCity = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.btnObtenerPorId = new System.Windows.Forms.Button();
            this.tbxObtenerPorId = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProveedor)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvProveedor
            // 
            this.dgvProveedor.AllowUserToAddRows = false;
            this.dgvProveedor.AllowUserToDeleteRows = false;
            this.dgvProveedor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProveedor.Location = new System.Drawing.Point(27, 31);
            this.dgvProveedor.Name = "dgvProveedor";
            this.dgvProveedor.ReadOnly = true;
            this.dgvProveedor.RowHeadersWidth = 51;
            this.dgvProveedor.RowTemplate.Height = 24;
            this.dgvProveedor.Size = new System.Drawing.Size(1004, 337);
            this.dgvProveedor.TabIndex = 0;
            // 
            // btnObtenerTodo
            // 
            this.btnObtenerTodo.Location = new System.Drawing.Point(27, 395);
            this.btnObtenerTodo.Name = "btnObtenerTodo";
            this.btnObtenerTodo.Size = new System.Drawing.Size(139, 48);
            this.btnObtenerTodo.TabIndex = 1;
            this.btnObtenerTodo.Text = "Obtener Todo";
            this.btnObtenerTodo.UseVisualStyleBackColor = true;
            this.btnObtenerTodo.Click += new System.EventHandler(this.btnObtenerTodo_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(569, 423);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 18);
            this.label1.TabIndex = 2;
            this.label1.Text = "Company Name";
            // 
            // tbxCompanyName
            // 
            this.tbxCompanyName.Location = new System.Drawing.Point(715, 419);
            this.tbxCompanyName.Name = "tbxCompanyName";
            this.tbxCompanyName.Size = new System.Drawing.Size(157, 22);
            this.tbxCompanyName.TabIndex = 3;
            // 
            // tbxContactName
            // 
            this.tbxContactName.Location = new System.Drawing.Point(715, 456);
            this.tbxContactName.Name = "tbxContactName";
            this.tbxContactName.Size = new System.Drawing.Size(157, 22);
            this.tbxContactName.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(581, 460);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 18);
            this.label2.TabIndex = 4;
            this.label2.Text = "Contact Name";
            // 
            // tbxContactTitle
            // 
            this.tbxContactTitle.Location = new System.Drawing.Point(715, 494);
            this.tbxContactTitle.Name = "tbxContactTitle";
            this.tbxContactTitle.Size = new System.Drawing.Size(157, 22);
            this.tbxContactTitle.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(593, 498);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 18);
            this.label3.TabIndex = 6;
            this.label3.Text = "Contact Title";
            // 
            // tbxAddress
            // 
            this.tbxAddress.Location = new System.Drawing.Point(715, 531);
            this.tbxAddress.Name = "tbxAddress";
            this.tbxAddress.Size = new System.Drawing.Size(157, 22);
            this.tbxAddress.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(628, 535);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 18);
            this.label4.TabIndex = 8;
            this.label4.Text = "Address";
            // 
            // tbxCity
            // 
            this.tbxCity.Location = new System.Drawing.Point(715, 568);
            this.tbxCity.Name = "tbxCity";
            this.tbxCity.Size = new System.Drawing.Size(157, 22);
            this.tbxCity.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(660, 572);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 18);
            this.label5.TabIndex = 10;
            this.label5.Text = "City";
            // 
            // btnActualizar
            // 
            this.btnActualizar.Location = new System.Drawing.Point(906, 485);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(125, 41);
            this.btnActualizar.TabIndex = 12;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.UseVisualStyleBackColor = true;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // btnObtenerPorId
            // 
            this.btnObtenerPorId.Location = new System.Drawing.Point(375, 505);
            this.btnObtenerPorId.Name = "btnObtenerPorId";
            this.btnObtenerPorId.Size = new System.Drawing.Size(139, 48);
            this.btnObtenerPorId.TabIndex = 13;
            this.btnObtenerPorId.Text = "Obtener id";
            this.btnObtenerPorId.UseVisualStyleBackColor = true;
            this.btnObtenerPorId.Click += new System.EventHandler(this.btnObtenerPorId_Click);
            // 
            // tbxObtenerPorId
            // 
            this.tbxObtenerPorId.Location = new System.Drawing.Point(188, 518);
            this.tbxObtenerPorId.Name = "tbxObtenerPorId";
            this.tbxObtenerPorId.Size = new System.Drawing.Size(157, 22);
            this.tbxObtenerPorId.TabIndex = 15;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(42, 522);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(116, 18);
            this.label6.TabIndex = 14;
            this.label6.Text = "Obtener por Id";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1062, 673);
            this.Controls.Add(this.tbxObtenerPorId);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnObtenerPorId);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.tbxCity);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tbxAddress);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbxContactTitle);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbxContactName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbxCompanyName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnObtenerTodo);
            this.Controls.Add(this.dgvProveedor);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dgvProveedor)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvProveedor;
        private System.Windows.Forms.Button btnObtenerTodo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbxCompanyName;
        private System.Windows.Forms.TextBox tbxContactName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbxContactTitle;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbxAddress;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbxCity;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Button btnObtenerPorId;
        private System.Windows.Forms.TextBox tbxObtenerPorId;
        private System.Windows.Forms.Label label6;
    }
}

