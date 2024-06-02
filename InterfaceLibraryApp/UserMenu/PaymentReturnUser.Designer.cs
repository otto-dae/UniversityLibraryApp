namespace InterfaceLibraryApp
{
    partial class PaymentReturnUser
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
            PaymountAmountPrompt = new Label();
            label2 = new Label();
            CardTextBox = new TextBox();
            label3 = new Label();
            CVVTextBox = new TextBox();
            PayConfirmButton = new Button();
            label1 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            SuspendLayout();
            // 
            // PaymountAmountPrompt
            // 
            PaymountAmountPrompt.AutoSize = true;
            PaymountAmountPrompt.Font = new Font("Segoe UI", 10F);
            PaymountAmountPrompt.ForeColor = Color.White;
            PaymountAmountPrompt.Location = new Point(12, 9);
            PaymountAmountPrompt.Name = "PaymountAmountPrompt";
            PaymountAmountPrompt.Size = new Size(237, 19);
            PaymountAmountPrompt.TabIndex = 0;
            PaymountAmountPrompt.Text = "Fecha en retraso, es necesario pagar: ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.White;
            label2.Location = new Point(12, 50);
            label2.Name = "label2";
            label2.Size = new Size(136, 15);
            label2.TabIndex = 1;
            label2.Text = "Num. Tarjeta (16digitos):";
            // 
            // CardTextBox
            // 
            CardTextBox.Location = new Point(12, 68);
            CardTextBox.Name = "CardTextBox";
            CardTextBox.Size = new Size(274, 23);
            CardTextBox.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = Color.White;
            label3.Location = new Point(12, 107);
            label3.Name = "label3";
            label3.Size = new Size(88, 15);
            label3.TabIndex = 3;
            label3.Text = "CVV (3 digitos):";
            // 
            // CVVTextBox
            // 
            CVVTextBox.Location = new Point(12, 129);
            CVVTextBox.Name = "CVVTextBox";
            CVVTextBox.Size = new Size(98, 23);
            CVVTextBox.TabIndex = 4;
            // 
            // PayConfirmButton
            // 
            PayConfirmButton.BackColor = Color.FromArgb(95, 145, 222);
            PayConfirmButton.FlatStyle = FlatStyle.Popup;
            PayConfirmButton.Location = new Point(12, 165);
            PayConfirmButton.Name = "PayConfirmButton";
            PayConfirmButton.Size = new Size(60, 24);
            PayConfirmButton.TabIndex = 5;
            PayConfirmButton.Text = "Pagar";
            PayConfirmButton.UseVisualStyleBackColor = false;
            PayConfirmButton.Click += PayConfirmButton_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.White;
            label1.Location = new Point(167, 129);
            label1.Name = "label1";
            label1.Size = new Size(147, 15);
            label1.TabIndex = 6;
            label1.Text = "En caso de no poder pagar";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = Color.White;
            label4.Location = new Point(167, 144);
            label4.Name = "label4";
            label4.Size = new Size(111, 15);
            label4.TabIndex = 7;
            label4.Text = "en estos momentos";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.ForeColor = Color.White;
            label5.Location = new Point(167, 162);
            label5.Name = "label5";
            label5.Size = new Size(120, 15);
            label5.TabIndex = 8;
            label5.Text = "dirijase a la recepcion";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.ForeColor = Color.White;
            label6.Location = new Point(167, 177);
            label6.Name = "label6";
            label6.Size = new Size(87, 15);
            label6.TabIndex = 9;
            label6.Text = "en la biblioteca";
            // 
            // PaymentReturnUser
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(13, 53, 115);
            ClientSize = new Size(326, 201);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label1);
            Controls.Add(PayConfirmButton);
            Controls.Add(CVVTextBox);
            Controls.Add(label3);
            Controls.Add(CardTextBox);
            Controls.Add(label2);
            Controls.Add(PaymountAmountPrompt);
            Name = "PaymentReturnUser";
            Text = "PaymentReturnUser";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label PaymountAmountPrompt;
        private Label label2;
        private TextBox CardTextBox;
        private Label label3;
        private TextBox CVVTextBox;
        private Button PayConfirmButton;
        private Label label1;
        private Label label4;
        private Label label5;
        private Label label6;
    }
}