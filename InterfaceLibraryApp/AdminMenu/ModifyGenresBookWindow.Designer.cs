namespace InterfaceLibraryApp
{
    partial class ModifyGenresBookWindow
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
            SearchIdBookTextBox = new TextBox();
            SearchID = new Button();
            BookNametoChange = new Label();
            CurrentGenres = new Label();
            NewGenresTextBox = new TextBox();
            NewGenrePromp = new Label();
            GenrePrompDisclaimer = new Label();
            ChangeGenres = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10F);
            label1.ForeColor = Color.White;
            label1.Location = new Point(14, 12);
            label1.Name = "label1";
            label1.Size = new Size(267, 23);
            label1.TabIndex = 0;
            label1.Text = "Ingrese el ID del libro a modificar:";
            // 
            // SearchIdBookTextBox
            // 
            SearchIdBookTextBox.Location = new Point(287, 11);
            SearchIdBookTextBox.Margin = new Padding(3, 4, 3, 4);
            SearchIdBookTextBox.Name = "SearchIdBookTextBox";
            SearchIdBookTextBox.Size = new Size(159, 27);
            SearchIdBookTextBox.TabIndex = 1;
            // 
            // SearchID
            // 
            SearchID.BackColor = Color.FromArgb(95, 145, 222);
            SearchID.FlatStyle = FlatStyle.Popup;
            SearchID.Location = new Point(452, 9);
            SearchID.Margin = new Padding(3, 4, 3, 4);
            SearchID.Name = "SearchID";
            SearchID.Size = new Size(75, 31);
            SearchID.TabIndex = 2;
            SearchID.Text = "Buscar";
            SearchID.UseVisualStyleBackColor = false;
            SearchID.Click += SearchID_Click;
            // 
            // BookNametoChange
            // 
            BookNametoChange.AutoSize = true;
            BookNametoChange.Font = new Font("Segoe UI", 10F);
            BookNametoChange.ForeColor = Color.White;
            BookNametoChange.Location = new Point(14, 61);
            BookNametoChange.Name = "BookNametoChange";
            BookNametoChange.Size = new Size(55, 23);
            BookNametoChange.TabIndex = 3;
            BookNametoChange.Text = "label2";
            // 
            // CurrentGenres
            // 
            CurrentGenres.AutoSize = true;
            CurrentGenres.Font = new Font("Segoe UI", 10F);
            CurrentGenres.ForeColor = Color.White;
            CurrentGenres.Location = new Point(14, 99);
            CurrentGenres.Name = "CurrentGenres";
            CurrentGenres.Size = new Size(55, 23);
            CurrentGenres.TabIndex = 4;
            CurrentGenres.Text = "label2";
            // 
            // NewGenresTextBox
            // 
            NewGenresTextBox.Location = new Point(14, 176);
            NewGenresTextBox.Margin = new Padding(3, 4, 3, 4);
            NewGenresTextBox.Name = "NewGenresTextBox";
            NewGenresTextBox.Size = new Size(475, 27);
            NewGenresTextBox.TabIndex = 5;
            // 
            // NewGenrePromp
            // 
            NewGenrePromp.AutoSize = true;
            NewGenrePromp.Font = new Font("Segoe UI", 10F);
            NewGenrePromp.ForeColor = Color.White;
            NewGenrePromp.Location = new Point(14, 147);
            NewGenrePromp.Name = "NewGenrePromp";
            NewGenrePromp.Size = new Size(221, 23);
            NewGenrePromp.TabIndex = 6;
            NewGenrePromp.Text = "Ingrese los nuevos generos:";
            // 
            // GenrePrompDisclaimer
            // 
            GenrePrompDisclaimer.AutoSize = true;
            GenrePrompDisclaimer.Font = new Font("Segoe UI", 10F);
            GenrePrompDisclaimer.ForeColor = Color.FromArgb(128, 128, 255);
            GenrePrompDisclaimer.Location = new Point(14, 211);
            GenrePrompDisclaimer.Name = "GenrePrompDisclaimer";
            GenrePrompDisclaimer.Size = new Size(466, 23);
            GenrePrompDisclaimer.TabIndex = 7;
            GenrePrompDisclaimer.Text = "En caso de ingresar multiples generos, separarlos por coma.";
            // 
            // ChangeGenres
            // 
            ChangeGenres.BackColor = Color.FromArgb(95, 145, 222);
            ChangeGenres.FlatStyle = FlatStyle.Popup;
            ChangeGenres.Location = new Point(233, 263);
            ChangeGenres.Margin = new Padding(3, 4, 3, 4);
            ChangeGenres.Name = "ChangeGenres";
            ChangeGenres.Size = new Size(77, 29);
            ChangeGenres.TabIndex = 8;
            ChangeGenres.Text = "Cambiar";
            ChangeGenres.UseVisualStyleBackColor = false;
            ChangeGenres.Click += ChangeGenres_Click;
            // 
            // ModifyGenresBookWindow
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(13, 53, 115);
            ClientSize = new Size(613, 308);
            Controls.Add(ChangeGenres);
            Controls.Add(GenrePrompDisclaimer);
            Controls.Add(NewGenrePromp);
            Controls.Add(NewGenresTextBox);
            Controls.Add(CurrentGenres);
            Controls.Add(BookNametoChange);
            Controls.Add(SearchID);
            Controls.Add(SearchIdBookTextBox);
            Controls.Add(label1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "ModifyGenresBookWindow";
            Text = "ModifyGenresBookWindow";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox SearchIdBookTextBox;
        private Button SearchID;
        private Label BookNametoChange;
        private Label CurrentGenres;
        private TextBox NewGenresTextBox;
        private Label NewGenrePromp;
        private Label GenrePrompDisclaimer;
        private Button ChangeGenres;
    }
}