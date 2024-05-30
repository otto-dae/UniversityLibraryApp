namespace InterfaceLibraryApp
{
    partial class SearchBookGenreWindows
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
            GenreBookTextBox = new TextBox();
            SearchGenreButton = new Button();
            GenreBookSearchGrid = new DataGridView();
            IDGenre = new DataGridViewTextBoxColumn();
            NameGenre = new DataGridViewTextBoxColumn();
            GenreGenre = new DataGridViewTextBoxColumn();
            QuiantityGenres = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)GenreBookSearchGrid).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.White;
            label1.Location = new Point(12, 18);
            label1.Name = "label1";
            label1.Size = new Size(212, 23);
            label1.TabIndex = 0;
            label1.Text = "Ingrese genero/s a buscar:";
            // 
            // GenreBookTextBox
            // 
            GenreBookTextBox.Location = new Point(230, 18);
            GenreBookTextBox.Name = "GenreBookTextBox";
            GenreBookTextBox.Size = new Size(347, 30);
            GenreBookTextBox.TabIndex = 1;
            // 
            // SearchGenreButton
            // 
            SearchGenreButton.ForeColor = Color.Black;
            SearchGenreButton.Location = new Point(583, 18);
            SearchGenreButton.Name = "SearchGenreButton";
            SearchGenreButton.Size = new Size(70, 30);
            SearchGenreButton.TabIndex = 2;
            SearchGenreButton.Text = "Buscar";
            SearchGenreButton.UseVisualStyleBackColor = true;
            SearchGenreButton.Click += SearchGenreButton_Click;
            // 
            // GenreBookSearchGrid
            // 
            GenreBookSearchGrid.BackgroundColor = Color.FromArgb(128, 128, 255);
            GenreBookSearchGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            GenreBookSearchGrid.Columns.AddRange(new DataGridViewColumn[] { IDGenre, NameGenre, GenreGenre, QuiantityGenres });
            GenreBookSearchGrid.Location = new Point(12, 105);
            GenreBookSearchGrid.Name = "GenreBookSearchGrid";
            GenreBookSearchGrid.RowHeadersWidth = 51;
            GenreBookSearchGrid.Size = new Size(798, 368);
            GenreBookSearchGrid.TabIndex = 3;
            // 
            // IDGenre
            // 
            IDGenre.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            IDGenre.HeaderText = "ID";
            IDGenre.MinimumWidth = 6;
            IDGenre.Name = "IDGenre";
            IDGenre.Width = 56;
            // 
            // NameGenre
            // 
            NameGenre.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            NameGenre.HeaderText = "Nombre";
            NameGenre.MinimumWidth = 6;
            NameGenre.Name = "NameGenre";
            NameGenre.Width = 102;
            // 
            // GenreGenre
            // 
            GenreGenre.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            GenreGenre.HeaderText = "Generos";
            GenreGenre.MinimumWidth = 6;
            GenreGenre.Name = "GenreGenre";
            GenreGenre.Width = 102;
            // 
            // QuiantityGenres
            // 
            QuiantityGenres.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            QuiantityGenres.HeaderText = "Disponibles";
            QuiantityGenres.MinimumWidth = 6;
            QuiantityGenres.Name = "QuiantityGenres";
            QuiantityGenres.Width = 126;
            // 
            // SearchBookGenreWindows
            // 
            AutoScaleDimensions = new SizeF(9F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(13, 53, 115);
            ClientSize = new Size(822, 493);
            Controls.Add(GenreBookSearchGrid);
            Controls.Add(SearchGenreButton);
            Controls.Add(GenreBookTextBox);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 10F);
            ForeColor = Color.Black;
            Name = "SearchBookGenreWindows";
            Text = "SearchBookGenreWindows";
            ((System.ComponentModel.ISupportInitialize)GenreBookSearchGrid).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox GenreBookTextBox;
        private Button SearchGenreButton;
        private DataGridView GenreBookSearchGrid;
        private DataGridViewTextBoxColumn IDGenre;
        private DataGridViewTextBoxColumn NameGenre;
        private DataGridViewTextBoxColumn GenreGenre;
        private DataGridViewTextBoxColumn QuiantityGenres;
    }
}