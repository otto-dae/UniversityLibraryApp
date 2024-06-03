namespace InterfaceLibraryApp
{
    partial class ReadLogsWindow
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
            LogsView = new DataGridView();
            UserID = new DataGridViewTextBoxColumn();
            Date = new DataGridViewTextBoxColumn();
            Action = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)LogsView).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11F);
            label1.ForeColor = Color.White;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(67, 20);
            label1.TabIndex = 0;
            label1.Text = "Bitacora:";
            // 
            // LogsView
            // 
            LogsView.BackgroundColor = Color.FromArgb(13, 53, 115);
            LogsView.BorderStyle = BorderStyle.None;
            LogsView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            LogsView.Columns.AddRange(new DataGridViewColumn[] { UserID, Date, Action });
            LogsView.Location = new Point(12, 41);
            LogsView.Name = "LogsView";
            LogsView.Size = new Size(770, 397);
            LogsView.TabIndex = 1;
            // 
            // UserID
            // 
            UserID.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            UserID.HeaderText = "ID de usuario";
            UserID.Name = "UserID";
            UserID.Width = 101;
            // 
            // Date
            // 
            Date.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            Date.HeaderText = "Fecha";
            Date.Name = "Date";
            Date.Width = 63;
            // 
            // Action
            // 
            Action.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            Action.HeaderText = "Accion";
            Action.Name = "Action";
            Action.Width = 69;
            // 
            // ReadLogsWindow
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(13, 53, 115);
            ClientSize = new Size(800, 450);
            Controls.Add(LogsView);
            Controls.Add(label1);
            Name = "ReadLogsWindow";
            Text = "ReadLogsWindow";
            ((System.ComponentModel.ISupportInitialize)LogsView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private DataGridView LogsView;
        private DataGridViewTextBoxColumn UserID;
        private DataGridViewTextBoxColumn Date;
        private DataGridViewTextBoxColumn Action;
    }
}