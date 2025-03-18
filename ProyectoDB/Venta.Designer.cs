namespace ProyectoDB
{
    partial class Venta
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.txtBuscarProdVenta = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNumCtrlVenta = new System.Windows.Forms.TextBox();
            this.txtCostoTotal = new System.Windows.Forms.TextBox();
            this.txtPtosGenerados = new System.Windows.Forms.TextBox();
            this.ListaProductos = new System.Windows.Forms.DataGridView();
            this.IdProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre_Producto_Venta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Precio_Venta_Producto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PtosGen_Producto_Venta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.ListaProductos)).BeginInit();
            this.SuspendLayout();
            // 
            // txtBuscarProdVenta
            // 
            this.txtBuscarProdVenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.txtBuscarProdVenta.Location = new System.Drawing.Point(978, 41);
            this.txtBuscarProdVenta.Name = "txtBuscarProdVenta";
            this.txtBuscarProdVenta.Size = new System.Drawing.Size(232, 38);
            this.txtBuscarProdVenta.TabIndex = 0;
            this.txtBuscarProdVenta.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtBuscarProdVenta_KeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS Gothic", 24.75F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(669, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(303, 33);
            this.label1.TabIndex = 1;
            this.label1.Text = "Buscar Producto:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MS PGothic", 20.25F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(37, 503);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(178, 27);
            this.label2.TabIndex = 2;
            this.label2.Text = "Núm. Control:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("MS PGothic", 20.25F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(485, 503);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 27);
            this.label3.TabIndex = 3;
            this.label3.Text = "Total:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("MS PGothic", 20.25F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(758, 503);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(243, 27);
            this.label4.TabIndex = 4;
            this.label4.Text = "Puntos Generados:";
            // 
            // txtNumCtrlVenta
            // 
            this.txtNumCtrlVenta.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.txtNumCtrlVenta.Location = new System.Drawing.Point(221, 497);
            this.txtNumCtrlVenta.Name = "txtNumCtrlVenta";
            this.txtNumCtrlVenta.Size = new System.Drawing.Size(190, 39);
            this.txtNumCtrlVenta.TabIndex = 5;
            // 
            // txtCostoTotal
            // 
            this.txtCostoTotal.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.txtCostoTotal.Location = new System.Drawing.Point(574, 497);
            this.txtCostoTotal.Name = "txtCostoTotal";
            this.txtCostoTotal.ReadOnly = true;
            this.txtCostoTotal.Size = new System.Drawing.Size(140, 39);
            this.txtCostoTotal.TabIndex = 6;
            this.txtCostoTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtPtosGenerados
            // 
            this.txtPtosGenerados.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.txtPtosGenerados.Location = new System.Drawing.Point(1007, 497);
            this.txtPtosGenerados.Name = "txtPtosGenerados";
            this.txtPtosGenerados.ReadOnly = true;
            this.txtPtosGenerados.Size = new System.Drawing.Size(140, 39);
            this.txtPtosGenerados.TabIndex = 7;
            this.txtPtosGenerados.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // ListaProductos
            // 
            this.ListaProductos.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ListaProductos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.ListaProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ListaProductos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdProducto,
            this.Nombre_Producto_Venta,
            this.Precio_Venta_Producto,
            this.PtosGen_Producto_Venta});
            this.ListaProductos.Location = new System.Drawing.Point(97, 94);
            this.ListaProductos.Name = "ListaProductos";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ListaProductos.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.ListaProductos.Size = new System.Drawing.Size(1131, 344);
            this.ListaProductos.TabIndex = 8;
            // 
            // IdProducto
            // 
            this.IdProducto.HeaderText = "ID Producto";
            this.IdProducto.Name = "IdProducto";
            this.IdProducto.Visible = false;
            // 
            // Nombre_Producto_Venta
            // 
            this.Nombre_Producto_Venta.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Nombre_Producto_Venta.HeaderText = "Nombre";
            this.Nombre_Producto_Venta.Name = "Nombre_Producto_Venta";
            // 
            // Precio_Venta_Producto
            // 
            this.Precio_Venta_Producto.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Precio_Venta_Producto.HeaderText = "Precio";
            this.Precio_Venta_Producto.Name = "Precio_Venta_Producto";
            // 
            // PtosGen_Producto_Venta
            // 
            this.PtosGen_Producto_Venta.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.PtosGen_Producto_Venta.HeaderText = "Puntos Generados";
            this.PtosGen_Producto_Venta.Name = "PtosGen_Producto_Venta";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Indigo;
            this.ClientSize = new System.Drawing.Size(1285, 656);
            this.Controls.Add(this.ListaProductos);
            this.Controls.Add(this.txtPtosGenerados);
            this.Controls.Add(this.txtCostoTotal);
            this.Controls.Add(this.txtNumCtrlVenta);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtBuscarProdVenta);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.ListaProductos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBuscarProdVenta;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtNumCtrlVenta;
        private System.Windows.Forms.TextBox txtCostoTotal;
        private System.Windows.Forms.TextBox txtPtosGenerados;
        private System.Windows.Forms.DataGridView ListaProductos;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre_Producto_Venta;
        private System.Windows.Forms.DataGridViewTextBoxColumn Precio_Venta_Producto;
        private System.Windows.Forms.DataGridViewTextBoxColumn PtosGen_Producto_Venta;
    }
}

