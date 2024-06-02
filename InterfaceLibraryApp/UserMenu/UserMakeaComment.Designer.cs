namespace InterfaceLibraryApp
{
    partial class UserMakeaComment
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
            CommentBox = new TextBox();
            CommentButton = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11F);
            label1.ForeColor = Color.White;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(156, 20);
            label1.TabIndex = 0;
            label1.Text = "Ingrese el comentario:";
            // 
            // CommentBox
            // 
            CommentBox.Location = new Point(12, 32);
            CommentBox.Name = "CommentBox";
            CommentBox.Size = new Size(289, 23);
            CommentBox.TabIndex = 1;
            // 
            // CommentButton
            // 
            CommentButton.Location = new Point(166, 267);
            CommentButton.Name = "CommentButton";
            CommentButton.Size = new Size(77, 23);
            CommentButton.TabIndex = 2;
            CommentButton.Text = "Comentar";
            CommentButton.UseVisualStyleBackColor = true;
            CommentButton.Click += CommentButton_Click;
            // 
            // UserMakeaComment
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(13, 53, 115);
            ClientSize = new Size(406, 302);
            Controls.Add(CommentButton);
            Controls.Add(CommentBox);
            Controls.Add(label1);
            Name = "UserMakeaComment";
            Text = "UserMakeaComment";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox CommentBox;
        private Button CommentButton;
    }
}