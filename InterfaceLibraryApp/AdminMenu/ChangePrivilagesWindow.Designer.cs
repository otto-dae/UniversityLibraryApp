namespace InterfaceLibraryApp
{
    partial class ChangePrivilagesWindow
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
            IdSearchPrivilagesTextBox = new TextBox();
            SearchID = new Button();
            AcutalStatusLabel = new Label();
            SoonTobePrivilages = new Label();
            AcceptChangesButton = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10F);
            label1.ForeColor = Color.White;
            label1.Location = new Point(12, 18);
            label1.Name = "label1";
            label1.Size = new Size(217, 19);
            label1.TabIndex = 0;
            label1.Text = "Ingrese el ID a cambiar privilegios:";
            // 
            // IdSearchPrivilagesTextBox
            // 
            IdSearchPrivilagesTextBox.Location = new Point(12, 40);
            IdSearchPrivilagesTextBox.Name = "IdSearchPrivilagesTextBox";
            IdSearchPrivilagesTextBox.Size = new Size(150, 23);
            IdSearchPrivilagesTextBox.TabIndex = 1;
            // 
            // SearchID
            // 
            SearchID.Location = new Point(176, 40);
            SearchID.Name = "SearchID";
            SearchID.Size = new Size(53, 25);
            SearchID.TabIndex = 2;
            SearchID.Text = "Search";
            SearchID.UseVisualStyleBackColor = true;
            SearchID.Click += SearchID_Click;
            // 
            // AcutalStatusLabel
            // 
            AcutalStatusLabel.AutoSize = true;
            AcutalStatusLabel.Font = new Font("Segoe UI", 10F);
            AcutalStatusLabel.ForeColor = Color.White;
            AcutalStatusLabel.Location = new Point(12, 81);
            AcutalStatusLabel.Name = "AcutalStatusLabel";
            AcutalStatusLabel.Size = new Size(126, 19);
            AcutalStatusLabel.TabIndex = 3;
            AcutalStatusLabel.Text = "Privilegios actuales:";
            // 
            // SoonTobePrivilages
            // 
            SoonTobePrivilages.AutoSize = true;
            SoonTobePrivilages.Font = new Font("Segoe UI", 10F);
            SoonTobePrivilages.ForeColor = Color.White;
            SoonTobePrivilages.Location = new Point(12, 100);
            SoonTobePrivilages.Name = "SoonTobePrivilages";
            SoonTobePrivilages.Size = new Size(154, 19);
            SoonTobePrivilages.TabIndex = 4;
            SoonTobePrivilages.Text = "Privilegios cambiarian a:";
            // 
            // AcceptChangesButton
            // 
            AcceptChangesButton.BackColor = Color.FromArgb(95, 145, 222);
            AcceptChangesButton.FlatStyle = FlatStyle.Popup;
            AcceptChangesButton.Location = new Point(12, 135);
            AcceptChangesButton.Name = "AcceptChangesButton";
            AcceptChangesButton.Size = new Size(58, 24);
            AcceptChangesButton.TabIndex = 5;
            AcceptChangesButton.Text = "Aceptar";
            AcceptChangesButton.UseVisualStyleBackColor = false;
            AcceptChangesButton.Click += AcceptChangesButton_Click;
            // 
            // ChangePrivilagesWindow
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(13, 53, 115);
            ClientSize = new Size(252, 171);
            Controls.Add(AcceptChangesButton);
            Controls.Add(SoonTobePrivilages);
            Controls.Add(AcutalStatusLabel);
            Controls.Add(SearchID);
            Controls.Add(IdSearchPrivilagesTextBox);
            Controls.Add(label1);
            Name = "ChangePrivilagesWindow";
            Text = "ChangePrivilagesWindow";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox IdSearchPrivilagesTextBox;
        private Button SearchID;
        private Label AcutalStatusLabel;
        private Label SoonTobePrivilages;
        private Button AcceptChangesButton;
    }
}