namespace InterfaceLibraryApp
{
    partial class ModifyQUantityBookWindow
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
            SearchBookId = new TextBox();
            label2 = new Label();
            NewBookQuantity = new TextBox();
            AcceptChangesButton = new Button();
            NameBookTextBox = new Label();
            SearchIdBook = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10F);
            label1.ForeColor = Color.White;
            label1.Location = new Point(14, 12);
            label1.Name = "label1";
            label1.Size = new Size(321, 23);
            label1.TabIndex = 0;
            label1.Text = "Ingrese ID de libro a cambiar inventario: ";
            // 
            // SearchBookId
            // 
            SearchBookId.Location = new Point(14, 41);
            SearchBookId.Margin = new Padding(3, 4, 3, 4);
            SearchBookId.Name = "SearchBookId";
            SearchBookId.Size = new Size(182, 27);
            SearchBookId.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10F);
            label2.ForeColor = Color.White;
            label2.Location = new Point(14, 141);
            label2.Name = "label2";
            label2.Size = new Size(321, 23);
            label2.TabIndex = 2;
            label2.Text = "Ingrese la nueva cantidad de ejemplares:";
            // 
            // NewBookQuantity
            // 
            NewBookQuantity.Location = new Point(14, 171);
            NewBookQuantity.Margin = new Padding(3, 4, 3, 4);
            NewBookQuantity.Name = "NewBookQuantity";
            NewBookQuantity.Size = new Size(99, 27);
            NewBookQuantity.TabIndex = 3;
            // 
            // AcceptChangesButton
            // 
            AcceptChangesButton.BackColor = Color.FromArgb(95, 145, 222);
            AcceptChangesButton.FlatStyle = FlatStyle.Popup;
            AcceptChangesButton.Location = new Point(240, 224);
            AcceptChangesButton.Margin = new Padding(3, 4, 3, 4);
            AcceptChangesButton.Name = "AcceptChangesButton";
            AcceptChangesButton.Size = new Size(75, 31);
            AcceptChangesButton.TabIndex = 4;
            AcceptChangesButton.Text = "Aceptar";
            AcceptChangesButton.UseVisualStyleBackColor = false;
            AcceptChangesButton.Click += AcceptChangesButton_Click;
            // 
            // NameBookTextBox
            // 
            NameBookTextBox.AutoSize = true;
            NameBookTextBox.Font = new Font("Segoe UI", 10F);
            NameBookTextBox.ForeColor = Color.White;
            NameBookTextBox.Location = new Point(14, 95);
            NameBookTextBox.Name = "NameBookTextBox";
            NameBookTextBox.Size = new Size(55, 23);
            NameBookTextBox.TabIndex = 5;
            NameBookTextBox.Text = "label3";
            // 
            // SearchIdBook
            // 
            SearchIdBook.BackColor = Color.FromArgb(95, 145, 222);
            SearchIdBook.FlatStyle = FlatStyle.Popup;
            SearchIdBook.Location = new Point(229, 41);
            SearchIdBook.Margin = new Padding(3, 4, 3, 4);
            SearchIdBook.Name = "SearchIdBook";
            SearchIdBook.Size = new Size(65, 27);
            SearchIdBook.TabIndex = 6;
            SearchIdBook.Text = "Buscar";
            SearchIdBook.UseVisualStyleBackColor = false;
            SearchIdBook.Click += SearchIdBook_Click;
            // 
            // ModifyQUantityBookWindow
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(13, 53, 115);
            ClientSize = new Size(558, 268);
            Controls.Add(SearchIdBook);
            Controls.Add(NameBookTextBox);
            Controls.Add(AcceptChangesButton);
            Controls.Add(NewBookQuantity);
            Controls.Add(label2);
            Controls.Add(SearchBookId);
            Controls.Add(label1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "ModifyQUantityBookWindow";
            Text = "ModifyQUantityBookWindow";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox SearchBookId;
        private Label label2;
        private TextBox NewBookQuantity;
        private Button AcceptChangesButton;
        private Label NameBookTextBox;
        private Button SearchIdBook;
    }
}