namespace InterfaceLibraryApp
{
    partial class IdUp
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
            IdUPTextBox = new TextBox();
            AcceptButton = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10F);
            label1.ForeColor = Color.White;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(169, 19);
            label1.TabIndex = 0;
            label1.Text = "Ingrese el ID a dar de alta:";
            // 
            // IdUPTextBox
            // 
            IdUPTextBox.Location = new Point(187, 12);
            IdUPTextBox.Name = "IdUPTextBox";
            IdUPTextBox.Size = new Size(100, 23);
            IdUPTextBox.TabIndex = 1;
            // 
            // AcceptButton
            // 
            AcceptButton.BackColor = Color.FromArgb(95, 145, 222);
            AcceptButton.FlatStyle = FlatStyle.Popup;
            AcceptButton.Location = new Point(115, 38);
            AcceptButton.Name = "AcceptButton";
            AcceptButton.Size = new Size(56, 23);
            AcceptButton.TabIndex = 2;
            AcceptButton.Text = "Aceptar";
            AcceptButton.UseVisualStyleBackColor = false;
            AcceptButton.Click += AcceptButton_Click;
            // 
            // IdUp
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(13, 53, 115);
            ClientSize = new Size(296, 73);
            Controls.Add(AcceptButton);
            Controls.Add(IdUPTextBox);
            Controls.Add(label1);
            Name = "IdUp";
            Text = "IdUp";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox IdUPTextBox;
        private Button AcceptButton;
    }
}