﻿namespace InterfaceLibraryApp
{
    partial class ReturnBookUserWindows
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
            IDBookReturnBox = new TextBox();
            ReturnButton = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10F);
            label1.ForeColor = Color.White;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(209, 19);
            label1.TabIndex = 0;
            label1.Text = "Ingrese el ID del libro a devolver:";
            // 
            // IDBookReturnBox
            // 
            IDBookReturnBox.Location = new Point(227, 9);
            IDBookReturnBox.Name = "IDBookReturnBox";
            IDBookReturnBox.Size = new Size(121, 23);
            IDBookReturnBox.TabIndex = 1;
            // 
            // ReturnButton
            // 
            ReturnButton.BackColor = Color.FromArgb(95, 145, 222);
            ReturnButton.FlatStyle = FlatStyle.Popup;
            ReturnButton.Location = new Point(155, 70);
            ReturnButton.Name = "ReturnButton";
            ReturnButton.Size = new Size(75, 23);
            ReturnButton.TabIndex = 2;
            ReturnButton.Text = "Devolver";
            ReturnButton.UseVisualStyleBackColor = false;
            ReturnButton.Click += ReturnButton_Click;
            // 
            // ReturnBookUserWindows
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(13, 53, 115);
            ClientSize = new Size(389, 106);
            Controls.Add(ReturnButton);
            Controls.Add(IDBookReturnBox);
            Controls.Add(label1);
            Name = "ReturnBookUserWindows";
            Text = "ReturnBookUserWindows";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox IDBookReturnBox;
        private Button ReturnButton;
    }
}