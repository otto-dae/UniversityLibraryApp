namespace InterfaceLibraryApp
{
    partial class ActivateBookWindow
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
            AcceptButton = new Button();
            SearchIdTextBox = new TextBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // AcceptButton
            // 
            AcceptButton.BackColor = Color.FromArgb(95, 145, 222);
            AcceptButton.FlatStyle = FlatStyle.Popup;
            AcceptButton.Location = new Point(123, 53);
            AcceptButton.Name = "AcceptButton";
            AcceptButton.Size = new Size(60, 23);
            AcceptButton.TabIndex = 5;
            AcceptButton.Text = "Aceptar";
            AcceptButton.UseVisualStyleBackColor = false;
            AcceptButton.Click += AcceptButton_Click;
            // 
            // SearchIdTextBox
            // 
            SearchIdTextBox.Location = new Point(177, 15);
            SearchIdTextBox.Name = "SearchIdTextBox";
            SearchIdTextBox.Size = new Size(116, 23);
            SearchIdTextBox.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10F);
            label1.ForeColor = Color.White;
            label1.Location = new Point(12, 15);
            label1.Name = "label1";
            label1.Size = new Size(156, 19);
            label1.TabIndex = 3;
            label1.Text = "ID de libro a dar de alta:";
            // 
            // ActivateBookWindow
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(13, 53, 115);
            ClientSize = new Size(304, 91);
            Controls.Add(AcceptButton);
            Controls.Add(SearchIdTextBox);
            Controls.Add(label1);
            Name = "ActivateBookWindow";
            Text = "ActivateBookWindow";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button AcceptButton;
        private TextBox SearchIdTextBox;
        private Label label1;
    }
}