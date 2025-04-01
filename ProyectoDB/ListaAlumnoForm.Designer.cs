namespace ProyectoDB
{
    partial class ListaUsuariosForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.Eliminarbtn = new System.Windows.Forms.Button();
            this.BackBtn = new System.Windows.Forms.Button();
            this.AgregarBtn = new System.Windows.Forms.Button();
            this.ListaAlumnos = new System.Windows.Forms.DataGridView();
            this.NumCtrl = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre_Alumno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.txtBuscarProdVenta = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.ListaAlumnos)).BeginInit();
            this.SuspendLayout();
            // 
            // Eliminarbtn
            // 
            this.Eliminarbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.Eliminarbtn.Location = new System.Drawing.Point(43, 582);
            this.Eliminarbtn.Margin = new System.Windows.Forms.Padding(2);
            this.Eliminarbtn.Name = "Eliminarbtn";
            this.Eliminarbtn.Size = new System.Drawing.Size(223, 60);
            this.Eliminarbtn.TabIndex = 41;
            this.Eliminarbtn.Text = "Eliminar";
            this.Eliminarbtn.UseVisualStyleBackColor = true;
            this.Eliminarbtn.Click += new System.EventHandler(this.Eliminarbtn_Click);
            // 
            // BackBtn
            // 
            this.BackBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.BackBtn.Location = new System.Drawing.Point(29, 8);
            this.BackBtn.Margin = new System.Windows.Forms.Padding(2);
            this.BackBtn.Name = "BackBtn";
            this.BackBtn.Size = new System.Drawing.Size(134, 47);
            this.BackBtn.TabIndex = 39;
            this.BackBtn.Text = "Volver";
            this.BackBtn.UseVisualStyleBackColor = true;
            this.BackBtn.Click += new System.EventHandler(this.BackBtn_Click);
            // 
            // AgregarBtn
            // 
            this.AgregarBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.AgregarBtn.Location = new System.Drawing.Point(568, 582);
            this.AgregarBtn.Margin = new System.Windows.Forms.Padding(2);
            this.AgregarBtn.Name = "AgregarBtn";
            this.AgregarBtn.Size = new System.Drawing.Size(223, 60);
            this.AgregarBtn.TabIndex = 38;
            this.AgregarBtn.Text = "Agregar";
            this.AgregarBtn.UseVisualStyleBackColor = true;
            this.AgregarBtn.Click += new System.EventHandler(this.AgregarBtn_Click);
            // 
            // ListaAlumnos
            // 
            this.ListaAlumnos.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ListaAlumnos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.ListaAlumnos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ListaAlumnos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NumCtrl,
            this.Nombre_Alumno});
            this.ListaAlumnos.Location = new System.Drawing.Point(99, 88);
            this.ListaAlumnos.Name = "ListaAlumnos";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ListaAlumnos.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.ListaAlumnos.RowHeadersVisible = false;
            this.ListaAlumnos.RowHeadersWidth = 5;
            this.ListaAlumnos.RowTemplate.Height = 40;
            this.ListaAlumnos.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ListaAlumnos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ListaAlumnos.Size = new System.Drawing.Size(1141, 439);
            this.ListaAlumnos.TabIndex = 37;
            this.ListaAlumnos.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ListaAlumnos_CellDoubleClick);
            // 
            // NumCtrl
            // 
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NumCtrl.DefaultCellStyle = dataGridViewCellStyle2;
            this.NumCtrl.HeaderText = "Número Control";
            this.NumCtrl.MinimumWidth = 8;
            this.NumCtrl.Name = "NumCtrl";
            this.NumCtrl.Width = 412;
            // 
            // Nombre_Alumno
            // 
            this.Nombre_Alumno.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Nombre_Alumno.DefaultCellStyle = dataGridViewCellStyle3;
            this.Nombre_Alumno.HeaderText = "Nombre";
            this.Nombre_Alumno.MinimumWidth = 8;
            this.Nombre_Alumno.Name = "Nombre_Alumno";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS Gothic", 24.75F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(710, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(267, 33);
            this.label1.TabIndex = 36;
            this.label1.Text = "Buscar Alumno:";
            // 
            // txtBuscarProdVenta
            // 
            this.txtBuscarProdVenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.txtBuscarProdVenta.Location = new System.Drawing.Point(991, 34);
            this.txtBuscarProdVenta.Name = "txtBuscarProdVenta";
            this.txtBuscarProdVenta.Size = new System.Drawing.Size(232, 38);
            this.txtBuscarProdVenta.TabIndex = 35;
            // 
            // ListaUsuariosForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Indigo;
            this.ClientSize = new System.Drawing.Size(1329, 688);
            this.Controls.Add(this.Eliminarbtn);
            this.Controls.Add(this.BackBtn);
            this.Controls.Add(this.AgregarBtn);
            this.Controls.Add(this.ListaAlumnos);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtBuscarProdVenta);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "ListaUsuariosForm";
            this.Text = "ListaUsuariosForm";
            this.Click += new System.EventHandler(this.ListaUsuariosForm_Click);
            ((System.ComponentModel.ISupportInitialize)(this.ListaAlumnos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Eliminarbtn;
        private System.Windows.Forms.Button BackBtn;
        private System.Windows.Forms.Button AgregarBtn;
        private System.Windows.Forms.DataGridView ListaAlumnos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBuscarProdVenta;
        private System.Windows.Forms.DataGridViewTextBoxColumn NumCtrl;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre_Alumno;
    }
}