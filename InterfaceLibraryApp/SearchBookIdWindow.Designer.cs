namespace InterfaceLibraryApp
{
    partial class SearchBookIdWindow
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
            IdBookTextBox = new TextBox();
            label2 = new Label();
            NameLabelBook = new Label();
            GenreLabelBook = new Label();
            QuantityBookLabel = new Label();
            SearchButtonID = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10F);
            label1.ForeColor = Color.White;
            label1.Location = new Point(12, 21);
            label1.Name = "label1";
            label1.Size = new Size(254, 23);
            label1.TabIndex = 0;
            label1.Text = "Ingrese el Id del libro a buscar : ";
            // 
            // IdBookTextBox
            // 
            IdBookTextBox.Location = new Point(272, 21);
            IdBookTextBox.Name = "IdBookTextBox";
            IdBookTextBox.Size = new Size(174, 27);
            IdBookTextBox.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10F);
            label2.ForeColor = Color.White;
            label2.Location = new Point(12, 80);
            label2.Name = "label2";
            label2.Size = new Size(145, 23);
            label2.TabIndex = 2;
            label2.Text = "Libro Encontrado:";
            // 
            // NameLabelBook
            // 
            NameLabelBook.AutoSize = true;
            NameLabelBook.Font = new Font("Segoe UI", 10F);
            NameLabelBook.ForeColor = Color.White;
            NameLabelBook.Location = new Point(163, 80);
            NameLabelBook.Name = "NameLabelBook";
            NameLabelBook.Size = new Size(56, 23);
            NameLabelBook.TabIndex = 3;
            NameLabelBook.Text = "Name";
            // 
            // GenreLabelBook
            // 
            GenreLabelBook.AutoSize = true;
            GenreLabelBook.Font = new Font("Segoe UI", 10F);
            GenreLabelBook.ForeColor = Color.White;
            GenreLabelBook.Location = new Point(12, 114);
            GenreLabelBook.Name = "GenreLabelBook";
            GenreLabelBook.Size = new Size(82, 23);
            GenreLabelBook.TabIndex = 4;
            GenreLabelBook.Text = "Generos: ";
            // 
            // QuantityBookLabel
            // 
            QuantityBookLabel.AutoSize = true;
            QuantityBookLabel.Font = new Font("Segoe UI", 9F);
            QuantityBookLabel.ForeColor = Color.White;
            QuantityBookLabel.Location = new Point(333, 159);
            QuantityBookLabel.Name = "QuantityBookLabel";
            QuantityBookLabel.Size = new Size(90, 20);
            QuantityBookLabel.TabIndex = 5;
            QuantityBookLabel.Text = "Disponibles:";
            // 
            // SearchButtonID
            // 
            SearchButtonID.Location = new Point(452, 21);
            SearchButtonID.Name = "SearchButtonID";
            SearchButtonID.Size = new Size(60, 27);
            SearchButtonID.TabIndex = 6;
            SearchButtonID.Text = "Buscar";
            SearchButtonID.UseVisualStyleBackColor = true;
            SearchButtonID.Click += SearchButtonID_Click;
            // 
            // SearchBookIdWindow
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(13, 53, 115);
            ClientSize = new Size(524, 199);
            Controls.Add(SearchButtonID);
            Controls.Add(QuantityBookLabel);
            Controls.Add(GenreLabelBook);
            Controls.Add(NameLabelBook);
            Controls.Add(label2);
            Controls.Add(IdBookTextBox);
            Controls.Add(label1);
            Name = "SearchBookIdWindow";
            Text = "SearchBookIdWindow";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox IdBookTextBox;
        private Label label2;
        private Label NameLabelBook;
        private Label GenreLabelBook;
        private Label QuantityBookLabel;
        private Button SearchButtonID;
    }
}