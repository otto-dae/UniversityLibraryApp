namespace InterfaceLibraryApp
{
    partial class ReadBooksWindow
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
            ReadBooksGrid = new DataGridView();
            ID = new DataGridViewTextBoxColumn();
            Nombre = new DataGridViewTextBoxColumn();
            Generos = new DataGridViewTextBoxColumn();
            Cantidad = new DataGridViewTextBoxColumn();
            Status = new DataGridViewTextBoxColumn();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)ReadBooksGrid).BeginInit();
            SuspendLayout();
            // 
            // ReadBooksGrid
            // 
            ReadBooksGrid.BackgroundColor = Color.FromArgb(13, 53, 115);
            ReadBooksGrid.BorderStyle = BorderStyle.None;
            ReadBooksGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            ReadBooksGrid.Columns.AddRange(new DataGridViewColumn[] { ID, Nombre, Generos, Cantidad, Status });
            ReadBooksGrid.Location = new Point(12, 41);
            ReadBooksGrid.Name = "ReadBooksGrid";
            ReadBooksGrid.Size = new Size(776, 482);
            ReadBooksGrid.TabIndex = 3;
            // 
            // ID
            // 
            ID.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            ID.HeaderText = "ID";
            ID.Name = "ID";
            ID.Width = 43;
            // 
            // Nombre
            // 
            Nombre.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            Nombre.HeaderText = "Nombre";
            Nombre.Name = "Nombre";
            Nombre.Width = 76;
            // 
            // Generos
            // 
            Generos.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            Generos.HeaderText = "Generos";
            Generos.Name = "Generos";
            Generos.Width = 75;
            // 
            // Cantidad
            // 
            Cantidad.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            Cantidad.HeaderText = "Cantidad";
            Cantidad.Name = "Cantidad";
            Cantidad.Width = 80;
            // 
            // Status
            // 
            Status.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            Status.HeaderText = "Status";
            Status.Name = "Status";
            Status.Width = 64;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11F);
            label1.ForeColor = Color.White;
            label1.Location = new Point(12, 4);
            label1.Name = "label1";
            label1.Size = new Size(142, 20);
            label1.TabIndex = 2;
            label1.Text = "Libros en el sistema:";
            // 
            // ReadBooksWindow
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(13, 53, 115);
            ClientSize = new Size(798, 530);
            Controls.Add(ReadBooksGrid);
            Controls.Add(label1);
            Name = "ReadBooksWindow";
            Text = "ReadBooksWindow";
            ((System.ComponentModel.ISupportInitialize)ReadBooksGrid).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView ReadBooksGrid;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn Nombre;
        private DataGridViewTextBoxColumn Generos;
        private DataGridViewTextBoxColumn Cantidad;
        private DataGridViewTextBoxColumn Status;
        private Label label1;
    }
}