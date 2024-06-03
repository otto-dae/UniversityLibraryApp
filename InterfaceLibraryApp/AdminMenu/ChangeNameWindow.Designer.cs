namespace InterfaceLibraryApp
{
    partial class ChangeNameWindow
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
            SearchIdTextBox = new TextBox();
            CurrentNameLabel = new Label();
            NewNameLabel = new Label();
            NewNameTextBox = new TextBox();
            AcceptNameChange = new Button();
            SearchId = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10F);
            label1.ForeColor = Color.White;
            label1.Location = new Point(14, 12);
            label1.Name = "label1";
            label1.Size = new Size(322, 23);
            label1.TabIndex = 0;
            label1.Text = "Ingrese ID de usuario a cambiar nombre:";
            // 
            // SearchIdTextBox
            // 
            SearchIdTextBox.Location = new Point(342, 11);
            SearchIdTextBox.Margin = new Padding(3, 4, 3, 4);
            SearchIdTextBox.Name = "SearchIdTextBox";
            SearchIdTextBox.Size = new Size(150, 27);
            SearchIdTextBox.TabIndex = 1;
            // 
            // CurrentNameLabel
            // 
            CurrentNameLabel.AutoSize = true;
            CurrentNameLabel.Font = new Font("Segoe UI", 10F);
            CurrentNameLabel.ForeColor = Color.White;
            CurrentNameLabel.Location = new Point(14, 56);
            CurrentNameLabel.Name = "CurrentNameLabel";
            CurrentNameLabel.Size = new Size(128, 23);
            CurrentNameLabel.TabIndex = 2;
            CurrentNameLabel.Text = "Nombre actual:";
            // 
            // NewNameLabel
            // 
            NewNameLabel.AutoSize = true;
            NewNameLabel.Font = new Font("Segoe UI", 10F);
            NewNameLabel.ForeColor = Color.White;
            NewNameLabel.Location = new Point(14, 100);
            NewNameLabel.Name = "NewNameLabel";
            NewNameLabel.Size = new Size(205, 23);
            NewNameLabel.TabIndex = 3;
            NewNameLabel.Text = "Ingrese el nuevo nombre:";
            // 
            // NewNameTextBox
            // 
            NewNameTextBox.Location = new Point(225, 100);
            NewNameTextBox.Margin = new Padding(3, 4, 3, 4);
            NewNameTextBox.Name = "NewNameTextBox";
            NewNameTextBox.Size = new Size(395, 27);
            NewNameTextBox.TabIndex = 4;
            // 
            // AcceptNameChange
            // 
            AcceptNameChange.BackColor = Color.FromArgb(95, 145, 222);
            AcceptNameChange.FlatStyle = FlatStyle.Popup;
            AcceptNameChange.Location = new Point(270, 140);
            AcceptNameChange.Margin = new Padding(3, 4, 3, 4);
            AcceptNameChange.Name = "AcceptNameChange";
            AcceptNameChange.Size = new Size(78, 31);
            AcceptNameChange.TabIndex = 5;
            AcceptNameChange.Text = "Aceptar";
            AcceptNameChange.TextAlign = ContentAlignment.TopCenter;
            AcceptNameChange.UseVisualStyleBackColor = false;
            AcceptNameChange.Click += AcceptNameChange_Click;
            // 
            // SearchId
            // 
            SearchId.BackColor = Color.FromArgb(95, 145, 222);
            SearchId.BackgroundImageLayout = ImageLayout.None;
            SearchId.FlatStyle = FlatStyle.Popup;
            SearchId.Location = new Point(498, 9);
            SearchId.Margin = new Padding(3, 4, 3, 4);
            SearchId.Name = "SearchId";
            SearchId.Size = new Size(64, 31);
            SearchId.TabIndex = 6;
            SearchId.Text = "Buscar";
            SearchId.UseVisualStyleBackColor = false;
            SearchId.Click += SearchId_Click;
            // 
            // ChangeNameWindow
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(13, 53, 115);
            ClientSize = new Size(634, 187);
            Controls.Add(SearchId);
            Controls.Add(AcceptNameChange);
            Controls.Add(NewNameTextBox);
            Controls.Add(NewNameLabel);
            Controls.Add(CurrentNameLabel);
            Controls.Add(SearchIdTextBox);
            Controls.Add(label1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "ChangeNameWindow";
            Text = "ChangeNameWindow";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox SearchIdTextBox;
        private Label CurrentNameLabel;
        private Label NewNameLabel;
        private TextBox NewNameTextBox;
        private Button AcceptNameChange;
        private Button SearchId;
    }
}