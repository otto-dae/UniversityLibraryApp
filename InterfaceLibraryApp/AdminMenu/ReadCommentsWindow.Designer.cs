namespace InterfaceLibraryApp
{
    partial class ReadCommentsWindow
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
            ViewComments = new DataGridView();
            CommentId = new DataGridViewTextBoxColumn();
            userName = new DataGridViewTextBoxColumn();
            Comment = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)ViewComments).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10F);
            label1.ForeColor = Color.White;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(163, 19);
            label1.TabIndex = 0;
            label1.Text = "Comentarios publicados: ";
            // 
            // ViewComments
            // 
            ViewComments.BackgroundColor = Color.FromArgb(13, 53, 115);
            ViewComments.BorderStyle = BorderStyle.None;
            ViewComments.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            ViewComments.Columns.AddRange(new DataGridViewColumn[] { CommentId, userName, Comment });
            ViewComments.Location = new Point(12, 43);
            ViewComments.Name = "ViewComments";
            ViewComments.Size = new Size(553, 610);
            ViewComments.TabIndex = 1;
            // 
            // CommentId
            // 
            CommentId.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            CommentId.HeaderText = "Id Comentario";
            CommentId.Name = "CommentId";
            CommentId.Width = 108;
            // 
            // userName
            // 
            userName.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            userName.HeaderText = "Autor";
            userName.Name = "userName";
            userName.Width = 62;
            // 
            // Comment
            // 
            Comment.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            Comment.HeaderText = "Comentario";
            Comment.Name = "Comment";
            Comment.Width = 95;
            // 
            // ReadCommentsWindow
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(13, 53, 115);
            ClientSize = new Size(577, 665);
            Controls.Add(ViewComments);
            Controls.Add(label1);
            Name = "ReadCommentsWindow";
            Text = "ReadCommentsWindow";
            ((System.ComponentModel.ISupportInitialize)ViewComments).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private DataGridView ViewComments;
        private DataGridViewTextBoxColumn CommentId;
        private DataGridViewTextBoxColumn userName;
        private DataGridViewTextBoxColumn Comment;
    }
}