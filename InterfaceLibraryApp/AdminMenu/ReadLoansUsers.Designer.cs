namespace InterfaceLibraryApp
{
    partial class ReadLoansUsers
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
            label1 = new Label();
            LoanVisualizerUser = new DataGridView();
            userID = new DataGridViewTextBoxColumn();
            BookId1 = new DataGridViewTextBoxColumn();
            BookDate1 = new DataGridViewTextBoxColumn();
            BookId2 = new DataGridViewTextBoxColumn();
            BookDate2 = new DataGridViewTextBoxColumn();
            BookId3 = new DataGridViewTextBoxColumn();
            BookDate3 = new DataGridViewTextBoxColumn();
            BookId4 = new DataGridViewTextBoxColumn();
            Bookdate4 = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)LoanVisualizerUser).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10F);
            label1.ForeColor = Color.White;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(128, 19);
            label1.TabIndex = 0;
            label1.Text = "Lista de prestamos ";
            // 
            // LoanVisualizerUser
            // 
            LoanVisualizerUser.BackgroundColor = Color.FromArgb(13, 53, 115);
            LoanVisualizerUser.BorderStyle = BorderStyle.None;
            LoanVisualizerUser.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            LoanVisualizerUser.Columns.AddRange(new DataGridViewColumn[] { userID, BookId1, BookDate1, BookId2, BookDate2, BookId3, BookDate3, BookId4, Bookdate4 });
            LoanVisualizerUser.Location = new Point(12, 31);
            LoanVisualizerUser.Name = "LoanVisualizerUser";
            LoanVisualizerUser.Size = new Size(1044, 606);
            LoanVisualizerUser.TabIndex = 2;
            // 
            // userID
            // 
            userID.HeaderText = "ID de usuario";
            userID.Name = "userID";
            // 
            // BookId1
            // 
            BookId1.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            BookId1.HeaderText = "Libro 1";
            BookId1.Name = "BookId1";
            BookId1.Width = 68;
            // 
            // BookDate1
            // 
            BookDate1.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            BookDate1.HeaderText = "Fecha Entrega";
            BookDate1.Name = "BookDate1";
            BookDate1.Width = 106;
            // 
            // BookId2
            // 
            BookId2.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            BookId2.HeaderText = "Libro 2";
            BookId2.Name = "BookId2";
            BookId2.Width = 68;
            // 
            // BookDate2
            // 
            BookDate2.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            BookDate2.HeaderText = "Fecha Entrega";
            BookDate2.Name = "BookDate2";
            BookDate2.Width = 106;
            // 
            // BookId3
            // 
            BookId3.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            BookId3.HeaderText = "Libro 3";
            BookId3.Name = "BookId3";
            BookId3.Width = 68;
            // 
            // BookDate3
            // 
            BookDate3.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            BookDate3.HeaderText = "Fecha Entrega";
            BookDate3.Name = "BookDate3";
            BookDate3.Width = 106;
            // 
            // BookId4
            // 
            BookId4.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            BookId4.HeaderText = "Libro 4";
            BookId4.Name = "BookId4";
            BookId4.Width = 68;
            // 
            // Bookdate4
            // 
            Bookdate4.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            Bookdate4.HeaderText = "Fecha Entrega";
            Bookdate4.Name = "Bookdate4";
            Bookdate4.Width = 106;
            // 
            // ReadLoansUsers
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(13, 53, 115);
            ClientSize = new Size(1078, 665);
            Controls.Add(LoanVisualizerUser);
            Controls.Add(label1);
            Name = "ReadLoansUsers";
            Text = "ReadLoansUser";
            ((System.ComponentModel.ISupportInitialize)LoanVisualizerUser).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private DataGridView LoanVisualizerUser;
        private DataGridViewTextBoxColumn userID;
        private DataGridViewTextBoxColumn BookId1;
        private DataGridViewTextBoxColumn BookDate1;
        private DataGridViewTextBoxColumn BookId2;
        private DataGridViewTextBoxColumn BookDate2;
        private DataGridViewTextBoxColumn BookId3;
        private DataGridViewTextBoxColumn BookDate3;
        private DataGridViewTextBoxColumn BookId4;
        private DataGridViewTextBoxColumn Bookdate4;
    }
}