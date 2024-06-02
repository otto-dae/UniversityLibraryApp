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
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(258, 19);
            label1.TabIndex = 0;
            label1.Text = "Ingrese ID de usuario a cambiar nombre:";
            // 
            // SearchIdTextBox
            // 
            SearchIdTextBox.Location = new Point(275, 9);
            SearchIdTextBox.Name = "SearchIdTextBox";
            SearchIdTextBox.Size = new Size(132, 23);
            SearchIdTextBox.TabIndex = 1;
            // 
            // CurrentNameLabel
            // 
            CurrentNameLabel.AutoSize = true;
            CurrentNameLabel.Font = new Font("Segoe UI", 10F);
            CurrentNameLabel.ForeColor = Color.White;
            CurrentNameLabel.Location = new Point(12, 42);
            CurrentNameLabel.Name = "CurrentNameLabel";
            CurrentNameLabel.Size = new Size(102, 19);
            CurrentNameLabel.TabIndex = 2;
            CurrentNameLabel.Text = "Nombre actual:";
            // 
            // NewNameLabel
            // 
            NewNameLabel.AutoSize = true;
            NewNameLabel.Font = new Font("Segoe UI", 10F);
            NewNameLabel.ForeColor = Color.White;
            NewNameLabel.Location = new Point(12, 75);
            NewNameLabel.Name = "NewNameLabel";
            NewNameLabel.Size = new Size(165, 19);
            NewNameLabel.TabIndex = 3;
            NewNameLabel.Text = "Ingrese el nuevo nombre:";
            // 
            // NewNameTextBox
            // 
            NewNameTextBox.Location = new Point(183, 74);
            NewNameTextBox.Name = "NewNameTextBox";
            NewNameTextBox.Size = new Size(346, 23);
            NewNameTextBox.TabIndex = 4;
            // 
            // AcceptNameChange
            // 
            AcceptNameChange.BackColor = Color.FromArgb(95, 145, 222);
            AcceptNameChange.FlatStyle = FlatStyle.Popup;
            AcceptNameChange.Location = new Point(236, 105);
            AcceptNameChange.Name = "AcceptNameChange";
            AcceptNameChange.Size = new Size(68, 23);
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
            SearchId.Location = new Point(413, 9);
            SearchId.Name = "SearchId";
            SearchId.Size = new Size(56, 23);
            SearchId.TabIndex = 6;
            SearchId.Text = "Buscar";
            SearchId.UseVisualStyleBackColor = false;
            SearchId.Click += SearchId_Click;
            // 
            // ChangeNameWindow
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(13, 53, 115);
            ClientSize = new Size(547, 140);
            Controls.Add(SearchId);
            Controls.Add(AcceptNameChange);
            Controls.Add(NewNameTextBox);
            Controls.Add(NewNameLabel);
            Controls.Add(CurrentNameLabel);
            Controls.Add(SearchIdTextBox);
            Controls.Add(label1);
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