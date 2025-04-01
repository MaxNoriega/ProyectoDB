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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            this.Eliminarbtn = new System.Windows.Forms.Button();
            this.ModifitcarBtn = new System.Windows.Forms.Button();
            this.BackBtn = new System.Windows.Forms.Button();
            this.AgregarBtn = new System.Windows.Forms.Button();
            this.ListaAlumnos = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.txtBuscarProdVenta = new System.Windows.Forms.TextBox();
            this.Nombre_Alumno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NumCtrl = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.ListaAlumnos)).BeginInit();
            this.SuspendLayout();
            // 
            // Eliminarbtn
            // 
            this.Eliminarbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.Eliminarbtn.Location = new System.Drawing.Point(1538, 896);
            this.Eliminarbtn.Name = "Eliminarbtn";
            this.Eliminarbtn.Size = new System.Drawing.Size(334, 93);
            this.Eliminarbtn.TabIndex = 41;
            this.Eliminarbtn.Text = "Eliminar";
            this.Eliminarbtn.UseVisualStyleBackColor = true;
            // 
            // ModifitcarBtn
            // 
            this.ModifitcarBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.ModifitcarBtn.Location = new System.Drawing.Point(160, 896);
            this.ModifitcarBtn.Name = "ModifitcarBtn";
            this.ModifitcarBtn.Size = new System.Drawing.Size(334, 93);
            this.ModifitcarBtn.TabIndex = 40;
            this.ModifitcarBtn.Text = "Modificar";
            this.ModifitcarBtn.UseVisualStyleBackColor = true;
            // 
            // BackBtn
            // 
            this.BackBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.BackBtn.Location = new System.Drawing.Point(43, 12);
            this.BackBtn.Name = "BackBtn";
            this.BackBtn.Size = new System.Drawing.Size(201, 72);
            this.BackBtn.TabIndex = 39;
            this.BackBtn.Text = "Volver";
            this.BackBtn.UseVisualStyleBackColor = true;
            this.BackBtn.Click += new System.EventHandler(this.BackBtn_Click);
            // 
            // AgregarBtn
            // 
            this.AgregarBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.AgregarBtn.Location = new System.Drawing.Point(852, 896);
            this.AgregarBtn.Name = "AgregarBtn";
            this.AgregarBtn.Size = new System.Drawing.Size(334, 93);
            this.AgregarBtn.TabIndex = 38;
            this.AgregarBtn.Text = "Agregar";
            this.AgregarBtn.UseVisualStyleBackColor = true;
            this.AgregarBtn.Click += new System.EventHandler(this.AgregarBtn_Click);
            // 
            // ListaAlumnos
            // 
            this.ListaAlumnos.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle13.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle13.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            dataGridViewCellStyle13.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle13.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle13.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ListaAlumnos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle13;
            this.ListaAlumnos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ListaAlumnos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Nombre_Alumno,
            this.NumCtrl});
            this.ListaAlumnos.Location = new System.Drawing.Point(149, 135);
            this.ListaAlumnos.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ListaAlumnos.Name = "ListaAlumnos";
            dataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle16.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle16.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            dataGridViewCellStyle16.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle16.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle16.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle16.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ListaAlumnos.RowHeadersDefaultCellStyle = dataGridViewCellStyle16;
            this.ListaAlumnos.RowHeadersVisible = false;
            this.ListaAlumnos.RowHeadersWidth = 5;
            this.ListaAlumnos.RowTemplate.Height = 40;
            this.ListaAlumnos.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ListaAlumnos.Size = new System.Drawing.Size(1712, 676);
            this.ListaAlumnos.TabIndex = 37;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS Gothic", 24.75F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(1065, 56);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(386, 50);
            this.label1.TabIndex = 36;
            this.label1.Text = "Buscar Alumno:";
            // 
            // txtBuscarProdVenta
            // 
            this.txtBuscarProdVenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.txtBuscarProdVenta.Location = new System.Drawing.Point(1486, 53);
            this.txtBuscarProdVenta.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtBuscarProdVenta.Name = "txtBuscarProdVenta";
            this.txtBuscarProdVenta.Size = new System.Drawing.Size(346, 53);
            this.txtBuscarProdVenta.TabIndex = 35;
            // 
            // Nombre_Alumno
            // 
            this.Nombre_Alumno.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Nombre_Alumno.DefaultCellStyle = dataGridViewCellStyle14;
            this.Nombre_Alumno.HeaderText = "Nombre";
            this.Nombre_Alumno.MinimumWidth = 8;
            this.Nombre_Alumno.Name = "Nombre_Alumno";
            // 
            // NumCtrl
            // 
            dataGridViewCellStyle15.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NumCtrl.DefaultCellStyle = dataGridViewCellStyle15;
            this.NumCtrl.HeaderText = "Número Control";
            this.NumCtrl.MinimumWidth = 8;
            this.NumCtrl.Name = "NumCtrl";
            this.NumCtrl.Width = 412;
            // 
            // ListaUsuariosForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Indigo;
            this.ClientSize = new System.Drawing.Size(1994, 1059);
            this.Controls.Add(this.Eliminarbtn);
            this.Controls.Add(this.ModifitcarBtn);
            this.Controls.Add(this.BackBtn);
            this.Controls.Add(this.AgregarBtn);
            this.Controls.Add(this.ListaAlumnos);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtBuscarProdVenta);
            this.Name = "ListaUsuariosForm";
            this.Text = "ListaUsuariosForm";
            this.Click += new System.EventHandler(this.ListaUsuariosForm_Click);
            this.DoubleClick += new System.EventHandler(this.ListaUsuariosForm_DoubleClick);
            ((System.ComponentModel.ISupportInitialize)(this.ListaAlumnos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Eliminarbtn;
        private System.Windows.Forms.Button ModifitcarBtn;
        private System.Windows.Forms.Button BackBtn;
        private System.Windows.Forms.Button AgregarBtn;
        private System.Windows.Forms.DataGridView ListaAlumnos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBuscarProdVenta;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre_Alumno;
        private System.Windows.Forms.DataGridViewTextBoxColumn NumCtrl;
    }
}