namespace InterfaceLibraryApp
{
    partial class MakeALoanUserWindow
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
            InsertIdBookLoanUser = new TextBox();
            SearchBookForLoanButton = new Button();
            NameBookLoanPompt = new Label();
            BookNameForLoanUser = new Label();
            AcceptButtonLoanUser = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10F);
            label1.ForeColor = Color.White;
            label1.Location = new Point(12, 30);
            label1.Name = "label1";
            label1.Size = new Size(212, 19);
            label1.TabIndex = 0;
            label1.Text = "Ingrese el ID del libro que desee: ";
            // 
            // InsertIdBookLoanUser
            // 
            InsertIdBookLoanUser.Location = new Point(230, 31);
            InsertIdBookLoanUser.Name = "InsertIdBookLoanUser";
            InsertIdBookLoanUser.Size = new Size(137, 23);
            InsertIdBookLoanUser.TabIndex = 1;
            // 
            // SearchBookForLoanButton
            // 
            SearchBookForLoanButton.BackColor = Color.FromArgb(95, 145, 222);
            SearchBookForLoanButton.FlatStyle = FlatStyle.Popup;
            SearchBookForLoanButton.Location = new Point(373, 30);
            SearchBookForLoanButton.Name = "SearchBookForLoanButton";
            SearchBookForLoanButton.Size = new Size(63, 24);
            SearchBookForLoanButton.TabIndex = 2;
            SearchBookForLoanButton.Text = "Buscar";
            SearchBookForLoanButton.UseVisualStyleBackColor = false;
            SearchBookForLoanButton.Click += SearchBookForLoanButton_Click;
            // 
            // NameBookLoanPompt
            // 
            NameBookLoanPompt.AutoSize = true;
            NameBookLoanPompt.Font = new Font("Segoe UI", 10F);
            NameBookLoanPompt.ForeColor = Color.White;
            NameBookLoanPompt.Location = new Point(12, 78);
            NameBookLoanPompt.Name = "NameBookLoanPompt";
            NameBookLoanPompt.Size = new Size(205, 19);
            NameBookLoanPompt.TabIndex = 3;
            NameBookLoanPompt.Text = "Esta seguro de tomar prestado: ";
            // 
            // BookNameForLoanUser
            // 
            BookNameForLoanUser.AutoSize = true;
            BookNameForLoanUser.Font = new Font("Segoe UI", 10F);
            BookNameForLoanUser.ForeColor = Color.White;
            BookNameForLoanUser.Location = new Point(12, 106);
            BookNameForLoanUser.Name = "BookNameForLoanUser";
            BookNameForLoanUser.Size = new Size(49, 19);
            BookNameForLoanUser.TabIndex = 4;
            BookNameForLoanUser.Text = "Libro...";
            // 
            // AcceptButtonLoanUser
            // 
            AcceptButtonLoanUser.BackColor = Color.FromArgb(95, 145, 222);
            AcceptButtonLoanUser.FlatStyle = FlatStyle.Popup;
            AcceptButtonLoanUser.Location = new Point(12, 140);
            AcceptButtonLoanUser.Name = "AcceptButtonLoanUser";
            AcceptButtonLoanUser.Size = new Size(59, 24);
            AcceptButtonLoanUser.TabIndex = 5;
            AcceptButtonLoanUser.Text = "Aceptar";
            AcceptButtonLoanUser.UseVisualStyleBackColor = false;
            AcceptButtonLoanUser.Click += AcceptButtonLoanUser_Click;
            // 
            // MakeALoanUserWindow
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(13, 53, 115);
            ClientSize = new Size(448, 175);
            Controls.Add(AcceptButtonLoanUser);
            Controls.Add(BookNameForLoanUser);
            Controls.Add(NameBookLoanPompt);
            Controls.Add(SearchBookForLoanButton);
            Controls.Add(InsertIdBookLoanUser);
            Controls.Add(label1);
            Name = "MakeALoanUserWindow";
            Text = "MakeALoanUserWindow";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox InsertIdBookLoanUser;
        private Button SearchBookForLoanButton;
        private Label NameBookLoanPompt;
        private Label BookNameForLoanUser;
        private Button AcceptButtonLoanUser;
    }
}