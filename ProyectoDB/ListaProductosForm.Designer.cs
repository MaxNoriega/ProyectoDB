namespace ProyectoDB
{
    partial class ListaProductosForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.BackBtn = new System.Windows.Forms.Button();
            this.AgregarBtn = new System.Windows.Forms.Button();
            this.ListaProductos = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.txtBuscarProdVenta = new System.Windows.Forms.TextBox();
            this.Eliminarbtn = new System.Windows.Forms.Button();
            this.IdProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre_Producto_Venta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Precio_Venta_Producto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Stock_Venta_Producto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descrip_Venta_Producto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.ListaProductos)).BeginInit();
            this.SuspendLayout();
            // 
            // BackBtn
            // 
            this.BackBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.BackBtn.Location = new System.Drawing.Point(37, 19);
            this.BackBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BackBtn.Name = "BackBtn";
            this.BackBtn.Size = new System.Drawing.Size(134, 47);
            this.BackBtn.TabIndex = 32;
            this.BackBtn.Text = "Volver";
            this.BackBtn.UseVisualStyleBackColor = true;
            this.BackBtn.Click += new System.EventHandler(this.BackBtn_Click);
            // 
            // AgregarBtn
            // 
            this.AgregarBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.AgregarBtn.Location = new System.Drawing.Point(580, 616);
            this.AgregarBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.AgregarBtn.Name = "AgregarBtn";
            this.AgregarBtn.Size = new System.Drawing.Size(223, 60);
            this.AgregarBtn.TabIndex = 31;
            this.AgregarBtn.Text = "Agregar";
            this.AgregarBtn.UseVisualStyleBackColor = true;
            this.AgregarBtn.Click += new System.EventHandler(this.AgregarBtn_Click);
            // 
            // ListaProductos
            // 
            this.ListaProductos.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ListaProductos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.ListaProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ListaProductos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdProducto,
            this.Nombre_Producto_Venta,
            this.Precio_Venta_Producto,
            this.Stock_Venta_Producto,
            this.Descrip_Venta_Producto});
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.ListaProductos.DefaultCellStyle = dataGridViewCellStyle5;
            this.ListaProductos.Location = new System.Drawing.Point(108, 99);
            this.ListaProductos.MultiSelect = false;
            this.ListaProductos.Name = "ListaProductos";
            this.ListaProductos.ReadOnly = true;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ListaProductos.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.ListaProductos.RowHeadersVisible = false;
            this.ListaProductos.RowHeadersWidth = 62;
            this.ListaProductos.RowTemplate.Height = 40;
            this.ListaProductos.RowTemplate.ReadOnly = true;
            this.ListaProductos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ListaProductos.Size = new System.Drawing.Size(1141, 439);
            this.ListaProductos.TabIndex = 30;
            this.ListaProductos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ListaProductos_CellClick);
            this.ListaProductos.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ListaProductos_CellDoubleClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS Gothic", 24.75F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(691, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(303, 33);
            this.label1.TabIndex = 23;
            this.label1.Text = "Buscar Producto:";
            // 
            // txtBuscarProdVenta
            // 
            this.txtBuscarProdVenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.txtBuscarProdVenta.Location = new System.Drawing.Point(999, 46);
            this.txtBuscarProdVenta.Name = "txtBuscarProdVenta";
            this.txtBuscarProdVenta.Size = new System.Drawing.Size(232, 38);
            this.txtBuscarProdVenta.TabIndex = 22;
            // 
            // Eliminarbtn
            // 
            this.Eliminarbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.Eliminarbtn.Location = new System.Drawing.Point(37, 616);
            this.Eliminarbtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Eliminarbtn.Name = "Eliminarbtn";
            this.Eliminarbtn.Size = new System.Drawing.Size(223, 60);
            this.Eliminarbtn.TabIndex = 34;
            this.Eliminarbtn.Text = "Eliminar";
            this.Eliminarbtn.UseVisualStyleBackColor = true;
            this.Eliminarbtn.Click += new System.EventHandler(this.Eliminarbtn_Click);
            // 
            // IdProducto
            // 
            this.IdProducto.FillWeight = 253.8071F;
            this.IdProducto.HeaderText = "ID Producto";
            this.IdProducto.MinimumWidth = 8;
            this.IdProducto.Name = "IdProducto";
            this.IdProducto.ReadOnly = true;
            this.IdProducto.Width = 150;
            // 
            // Nombre_Producto_Venta
            // 
            this.Nombre_Producto_Venta.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Nombre_Producto_Venta.FillWeight = 61.54822F;
            this.Nombre_Producto_Venta.HeaderText = "Nombre";
            this.Nombre_Producto_Venta.MinimumWidth = 8;
            this.Nombre_Producto_Venta.Name = "Nombre_Producto_Venta";
            this.Nombre_Producto_Venta.ReadOnly = true;
            // 
            // Precio_Venta_Producto
            // 
            this.Precio_Venta_Producto.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Precio_Venta_Producto.FillWeight = 61.54822F;
            this.Precio_Venta_Producto.HeaderText = "Precio";
            this.Precio_Venta_Producto.MinimumWidth = 8;
            this.Precio_Venta_Producto.Name = "Precio_Venta_Producto";
            this.Precio_Venta_Producto.ReadOnly = true;
            // 
            // Stock_Venta_Producto
            // 
            this.Stock_Venta_Producto.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Stock_Venta_Producto.FillWeight = 61.54822F;
            this.Stock_Venta_Producto.HeaderText = "Stock";
            this.Stock_Venta_Producto.MinimumWidth = 8;
            this.Stock_Venta_Producto.Name = "Stock_Venta_Producto";
            this.Stock_Venta_Producto.ReadOnly = true;
            // 
            // Descrip_Venta_Producto
            // 
            this.Descrip_Venta_Producto.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Descrip_Venta_Producto.FillWeight = 61.54822F;
            this.Descrip_Venta_Producto.HeaderText = "Descripción";
            this.Descrip_Venta_Producto.MinimumWidth = 8;
            this.Descrip_Venta_Producto.Name = "Descrip_Venta_Producto";
            this.Descrip_Venta_Producto.ReadOnly = true;
            // 
            // ListaProductosForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Indigo;
            this.ClientSize = new System.Drawing.Size(1302, 698);
            this.Controls.Add(this.Eliminarbtn);
            this.Controls.Add(this.BackBtn);
            this.Controls.Add(this.AgregarBtn);
            this.Controls.Add(this.ListaProductos);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtBuscarProdVenta);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "ListaProductosForm";
            this.Text = "ListaProductosForm";
            ((System.ComponentModel.ISupportInitialize)(this.ListaProductos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BackBtn;
        private System.Windows.Forms.Button AgregarBtn;
        private System.Windows.Forms.DataGridView ListaProductos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBuscarProdVenta;
        private System.Windows.Forms.Button Eliminarbtn;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre_Producto_Venta;
        private System.Windows.Forms.DataGridViewTextBoxColumn Precio_Venta_Producto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Stock_Venta_Producto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descrip_Venta_Producto;
    }
}