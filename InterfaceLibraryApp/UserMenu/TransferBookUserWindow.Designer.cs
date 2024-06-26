﻿namespace InterfaceLibraryApp
{
    partial class TransferBookUserWindow
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
            IdBookTransferUser = new TextBox();
            button1 = new Button();
            InsertIdTargetPrompt = new Label();
            IdTargetTransferUser = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10F);
            label1.ForeColor = Color.White;
            label1.Location = new Point(14, 49);
            label1.Name = "label1";
            label1.Size = new Size(255, 23);
            label1.TabIndex = 0;
            label1.Text = "Ingrse el ID del libro a transferir:";
            // 
            // IdBookTransferUser
            // 
            IdBookTransferUser.Location = new Point(275, 49);
            IdBookTransferUser.Margin = new Padding(3, 4, 3, 4);
            IdBookTransferUser.Name = "IdBookTransferUser";
            IdBookTransferUser.Size = new Size(125, 27);
            IdBookTransferUser.TabIndex = 1;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(95, 145, 222);
            button1.FlatStyle = FlatStyle.Popup;
            button1.Location = new Point(183, 178);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(69, 32);
            button1.TabIndex = 2;
            button1.Text = "Aceptar";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // InsertIdTargetPrompt
            // 
            InsertIdTargetPrompt.AutoSize = true;
            InsertIdTargetPrompt.Font = new Font("Segoe UI", 10F);
            InsertIdTargetPrompt.ForeColor = Color.White;
            InsertIdTargetPrompt.Location = new Point(14, 97);
            InsertIdTargetPrompt.Name = "InsertIdTargetPrompt";
            InsertIdTargetPrompt.Size = new Size(238, 23);
            InsertIdTargetPrompt.TabIndex = 3;
            InsertIdTargetPrompt.Text = "Ingrese el ID del destinatario: ";
            // 
            // IdTargetTransferUser
            // 
            IdTargetTransferUser.Location = new Point(255, 97);
            IdTargetTransferUser.Margin = new Padding(3, 4, 3, 4);
            IdTargetTransferUser.Name = "IdTargetTransferUser";
            IdTargetTransferUser.Size = new Size(125, 27);
            IdTargetTransferUser.TabIndex = 4;
            // 
            // TransferBookUserWindow
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(13, 53, 115);
            ClientSize = new Size(445, 223);
            Controls.Add(IdTargetTransferUser);
            Controls.Add(InsertIdTargetPrompt);
            Controls.Add(button1);
            Controls.Add(IdBookTransferUser);
            Controls.Add(label1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "TransferBookUserWindow";
            Text = "TransferBookUserWindow";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox IdBookTransferUser;
        private Button button1;
        private Label InsertIdTargetPrompt;
        private TextBox IdTargetTransferUser;
    }
}