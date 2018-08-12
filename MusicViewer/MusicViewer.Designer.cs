namespace MusicViewer
{
    partial class MusicViewer
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
            this.components = new System.ComponentModel.Container();
            this.loadButton = new System.Windows.Forms.Button();
            this.albumsComboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tracksListBox = new System.Windows.Forms.ListBox();
            this.albumLabel = new System.Windows.Forms.Label();
            this.lengthLable = new System.Windows.Forms.Label();
            this.realeseLable = new System.Windows.Forms.Label();
            this.genreLabel = new System.Windows.Forms.Label();
            this.albumDataLabel = new System.Windows.Forms.Label();
            this.realeseDataLabel = new System.Windows.Forms.Label();
            this.genreDataLabel = new System.Windows.Forms.Label();
            this.lengthDataLabel = new System.Windows.Forms.Label();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.MinimumDatePicker = new System.Windows.Forms.DateTimePicker();
            this.MaximumDatePicker = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // loadButton
            // 
            this.loadButton.Location = new System.Drawing.Point(12, 12);
            this.loadButton.Name = "loadButton";
            this.loadButton.Size = new System.Drawing.Size(75, 23);
            this.loadButton.TabIndex = 0;
            this.loadButton.Text = "Load";
            this.loadButton.UseVisualStyleBackColor = true;
            this.loadButton.Click += new System.EventHandler(this.LoadButton_Click);
            // 
            // albumsComboBox
            // 
            this.albumsComboBox.FormattingEnabled = true;
            this.albumsComboBox.Location = new System.Drawing.Point(93, 12);
            this.albumsComboBox.Name = "albumsComboBox";
            this.albumsComboBox.Size = new System.Drawing.Size(421, 24);
            this.albumsComboBox.TabIndex = 1;
            this.albumsComboBox.SelectedIndexChanged += new System.EventHandler(this.AlbumsComboBox_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "From:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(279, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "To:";
            // 
            // tracksListBox
            // 
            this.tracksListBox.FormattingEnabled = true;
            this.tracksListBox.ItemHeight = 16;
            this.tracksListBox.Location = new System.Drawing.Point(12, 88);
            this.tracksListBox.Name = "tracksListBox";
            this.tracksListBox.Size = new System.Drawing.Size(238, 292);
            this.tracksListBox.TabIndex = 6;
            this.tracksListBox.SelectedIndexChanged += new System.EventHandler(this.TracksListBox_SelectedIndexChanged);
            // 
            // albumLabel
            // 
            this.albumLabel.AutoSize = true;
            this.albumLabel.Location = new System.Drawing.Point(283, 78);
            this.albumLabel.Name = "albumLabel";
            this.albumLabel.Size = new System.Drawing.Size(51, 17);
            this.albumLabel.TabIndex = 7;
            this.albumLabel.Text = "Album:";
            // 
            // lengthLable
            // 
            this.lengthLable.AutoSize = true;
            this.lengthLable.Location = new System.Drawing.Point(278, 142);
            this.lengthLable.Name = "lengthLable";
            this.lengthLable.Size = new System.Drawing.Size(56, 17);
            this.lengthLable.TabIndex = 8;
            this.lengthLable.Text = "Length:";
            // 
            // realeseLable
            // 
            this.realeseLable.AutoSize = true;
            this.realeseLable.Location = new System.Drawing.Point(262, 112);
            this.realeseLable.Name = "realeseLable";
            this.realeseLable.Size = new System.Drawing.Size(72, 17);
            this.realeseLable.TabIndex = 9;
            this.realeseLable.Text = "Released:";
            // 
            // genreLabel
            // 
            this.genreLabel.AutoSize = true;
            this.genreLabel.Location = new System.Drawing.Point(278, 170);
            this.genreLabel.Name = "genreLabel";
            this.genreLabel.Size = new System.Drawing.Size(52, 17);
            this.genreLabel.TabIndex = 10;
            this.genreLabel.Text = "Genre:";
            // 
            // albumDataLabel
            // 
            this.albumDataLabel.AutoSize = true;
            this.albumDataLabel.Location = new System.Drawing.Point(340, 78);
            this.albumDataLabel.Name = "albumDataLabel";
            this.albumDataLabel.Size = new System.Drawing.Size(0, 17);
            this.albumDataLabel.TabIndex = 11;
            // 
            // realeseDataLabel
            // 
            this.realeseDataLabel.AutoSize = true;
            this.realeseDataLabel.Location = new System.Drawing.Point(340, 112);
            this.realeseDataLabel.Name = "realeseDataLabel";
            this.realeseDataLabel.Size = new System.Drawing.Size(0, 17);
            this.realeseDataLabel.TabIndex = 14;
            // 
            // genreDataLabel
            // 
            this.genreDataLabel.AutoSize = true;
            this.genreDataLabel.Location = new System.Drawing.Point(340, 170);
            this.genreDataLabel.Name = "genreDataLabel";
            this.genreDataLabel.Size = new System.Drawing.Size(0, 17);
            this.genreDataLabel.TabIndex = 15;
            // 
            // lengthDataLabel
            // 
            this.lengthDataLabel.AutoSize = true;
            this.lengthDataLabel.Location = new System.Drawing.Point(340, 142);
            this.lengthDataLabel.Name = "lengthDataLabel";
            this.lengthDataLabel.Size = new System.Drawing.Size(0, 17);
            this.lengthDataLabel.TabIndex = 16;
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog";
            // 
            // timer
            // 
            this.timer.Interval = 4000;
            // 
            // MinimumDatePicker
            // 
            this.MinimumDatePicker.Location = new System.Drawing.Point(59, 42);
            this.MinimumDatePicker.Name = "MinimumDatePicker";
            this.MinimumDatePicker.Size = new System.Drawing.Size(200, 22);
            this.MinimumDatePicker.TabIndex = 17;
            this.MinimumDatePicker.ValueChanged += new System.EventHandler(this.MinimumDatePicker_ValueChanged);
            // 
            // MaximumDatePicker
            // 
            this.MaximumDatePicker.Location = new System.Drawing.Point(314, 42);
            this.MaximumDatePicker.Name = "MaximumDatePicker";
            this.MaximumDatePicker.Size = new System.Drawing.Size(200, 22);
            this.MaximumDatePicker.TabIndex = 18;
            this.MaximumDatePicker.ValueChanged += new System.EventHandler(this.MaximumDatePicker_ValueChanged);
            // 
            // MusicViewer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(526, 392);
            this.Controls.Add(this.MaximumDatePicker);
            this.Controls.Add(this.MinimumDatePicker);
            this.Controls.Add(this.lengthDataLabel);
            this.Controls.Add(this.genreDataLabel);
            this.Controls.Add(this.realeseDataLabel);
            this.Controls.Add(this.albumDataLabel);
            this.Controls.Add(this.genreLabel);
            this.Controls.Add(this.realeseLable);
            this.Controls.Add(this.lengthLable);
            this.Controls.Add(this.albumLabel);
            this.Controls.Add(this.tracksListBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.albumsComboBox);
            this.Controls.Add(this.loadButton);
            this.Name = "MusicViewer";
            this.RightToLeftLayout = true;
            this.Text = "MusicViewer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label albumLabel;
        private System.Windows.Forms.Label albumDataLabel;
        private System.Windows.Forms.ComboBox albumsComboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button loadButton;
        private System.Windows.Forms.ListBox tracksListBox;
        private System.Windows.Forms.Label lengthLable;
        private System.Windows.Forms.Label realeseLable;
        private System.Windows.Forms.Label genreLabel;
        private System.Windows.Forms.Label realeseDataLabel;
        private System.Windows.Forms.Label genreDataLabel;
        private System.Windows.Forms.Label lengthDataLabel;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.DateTimePicker MinimumDatePicker;
        private System.Windows.Forms.DateTimePicker MaximumDatePicker;
    }
}