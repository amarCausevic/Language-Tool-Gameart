namespace LanguageToolAmar
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.getURLBtn = new System.Windows.Forms.Button();
            this.serverFileViewGrid = new System.Windows.Forms.DataGridView();
            this.localFileViewGrid = new System.Windows.Forms.DataGridView();
            this.browseForLocalFile = new System.Windows.Forms.Button();
            this.searchParamter = new System.Windows.Forms.TextBox();
            this.searchButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.langSelector = new System.Windows.Forms.ComboBox();
            this.gameSelector = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.commonCheckBox = new System.Windows.Forms.CheckBox();
            this.jsonComparerBtn = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.serverWithLocalChckBox = new System.Windows.Forms.CheckBox();
            this.localWithServerChckBox = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.sumDiffLbl = new System.Windows.Forms.Label();
            this.diffStatusLbl = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.titleCheckBtn = new System.Windows.Forms.Button();
            this.clearColorGridsBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.serverFileViewGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.localFileViewGrid)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // getURLBtn
            // 
            this.getURLBtn.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.getURLBtn.Location = new System.Drawing.Point(610, 192);
            this.getURLBtn.Margin = new System.Windows.Forms.Padding(6);
            this.getURLBtn.Name = "getURLBtn";
            this.getURLBtn.Size = new System.Drawing.Size(138, 42);
            this.getURLBtn.TabIndex = 3;
            this.getURLBtn.Text = "Confirm";
            this.getURLBtn.UseVisualStyleBackColor = true;
            this.getURLBtn.Click += new System.EventHandler(this.getURLBtn_Click);
            // 
            // serverFileViewGrid
            // 
            this.serverFileViewGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.serverFileViewGrid.Location = new System.Drawing.Point(22, 246);
            this.serverFileViewGrid.Margin = new System.Windows.Forms.Padding(6);
            this.serverFileViewGrid.Name = "serverFileViewGrid";
            this.serverFileViewGrid.RowHeadersWidth = 72;
            this.serverFileViewGrid.Size = new System.Drawing.Size(726, 329);
            this.serverFileViewGrid.TabIndex = 4;
            // 
            // localFileViewGrid
            // 
            this.localFileViewGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.localFileViewGrid.Location = new System.Drawing.Point(775, 246);
            this.localFileViewGrid.Margin = new System.Windows.Forms.Padding(6);
            this.localFileViewGrid.Name = "localFileViewGrid";
            this.localFileViewGrid.RowHeadersWidth = 72;
            this.localFileViewGrid.Size = new System.Drawing.Size(726, 329);
            this.localFileViewGrid.TabIndex = 5;
            // 
            // browseForLocalFile
            // 
            this.browseForLocalFile.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.browseForLocalFile.Location = new System.Drawing.Point(1363, 194);
            this.browseForLocalFile.Margin = new System.Windows.Forms.Padding(6);
            this.browseForLocalFile.Name = "browseForLocalFile";
            this.browseForLocalFile.Size = new System.Drawing.Size(138, 42);
            this.browseForLocalFile.TabIndex = 6;
            this.browseForLocalFile.Text = "Browse";
            this.browseForLocalFile.UseVisualStyleBackColor = true;
            this.browseForLocalFile.Click += new System.EventHandler(this.browseForLocalFile_Click);
            // 
            // searchParamter
            // 
            this.searchParamter.Location = new System.Drawing.Point(20, 693);
            this.searchParamter.Margin = new System.Windows.Forms.Padding(6);
            this.searchParamter.Name = "searchParamter";
            this.searchParamter.Size = new System.Drawing.Size(552, 20);
            this.searchParamter.TabIndex = 7;
            this.searchParamter.TextChanged += new System.EventHandler(this.searchParamter_TextChanged);
            // 
            // searchButton
            // 
            this.searchButton.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchButton.Location = new System.Drawing.Point(434, 627);
            this.searchButton.Margin = new System.Windows.Forms.Padding(6);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(138, 42);
            this.searchButton.TabIndex = 8;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Verdana", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(15, 640);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(413, 29);
            this.label1.TabIndex = 9;
            this.label1.Text = "Search for PROPERTY";
            // 
            // langSelector
            // 
            this.langSelector.FormattingEnabled = true;
            this.langSelector.Location = new System.Drawing.Point(22, 216);
            this.langSelector.Name = "langSelector";
            this.langSelector.Size = new System.Drawing.Size(217, 21);
            this.langSelector.TabIndex = 11;
            // 
            // gameSelector
            // 
            this.gameSelector.FormattingEnabled = true;
            this.gameSelector.Location = new System.Drawing.Point(245, 216);
            this.gameSelector.Name = "gameSelector";
            this.gameSelector.Size = new System.Drawing.Size(217, 21);
            this.gameSelector.TabIndex = 17;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Trebuchet MS", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(157, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(366, 43);
            this.label3.TabIndex = 15;
            this.label3.Text = "JSON FROM SERVER";
            this.label3.UseWaitCursor = true;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Trebuchet MS", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(978, 110);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(271, 43);
            this.label4.TabIndex = 16;
            this.label4.Text = "LOCAL JSON";
            this.label4.UseWaitCursor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(32, 186);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(187, 25);
            this.label2.TabIndex = 18;
            this.label2.Text = "Select Language";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(280, 186);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(146, 25);
            this.label5.TabIndex = 19;
            this.label5.Text = "Select Game";
            // 
            // commonCheckBox
            // 
            this.commonCheckBox.AutoSize = true;
            this.commonCheckBox.Font = new System.Drawing.Font("Trebuchet MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.commonCheckBox.Location = new System.Drawing.Point(485, 205);
            this.commonCheckBox.Name = "commonCheckBox";
            this.commonCheckBox.Size = new System.Drawing.Size(109, 31);
            this.commonCheckBox.TabIndex = 20;
            this.commonCheckBox.Text = "Common";
            this.commonCheckBox.UseVisualStyleBackColor = true;
            this.commonCheckBox.CheckedChanged += new System.EventHandler(this.commonCheckBox_CheckedChanged);
            // 
            // jsonComparerBtn
            // 
            this.jsonComparerBtn.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.jsonComparerBtn.Location = new System.Drawing.Point(701, 704);
            this.jsonComparerBtn.Name = "jsonComparerBtn";
            this.jsonComparerBtn.Size = new System.Drawing.Size(119, 43);
            this.jsonComparerBtn.TabIndex = 21;
            this.jsonComparerBtn.Text = "Compare";
            this.jsonComparerBtn.UseVisualStyleBackColor = true;
            this.jsonComparerBtn.Click += new System.EventHandler(this.jsonComparerBtn_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(661, 592);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(190, 31);
            this.label12.TabIndex = 22;
            this.label12.Text = "Compare Files";
            // 
            // serverWithLocalChckBox
            // 
            this.serverWithLocalChckBox.AutoSize = true;
            this.serverWithLocalChckBox.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.serverWithLocalChckBox.Location = new System.Drawing.Point(667, 633);
            this.serverWithLocalChckBox.Name = "serverWithLocalChckBox";
            this.serverWithLocalChckBox.Size = new System.Drawing.Size(199, 27);
            this.serverWithLocalChckBox.TabIndex = 23;
            this.serverWithLocalChckBox.Text = "Server With Local";
            this.serverWithLocalChckBox.UseVisualStyleBackColor = true;
            // 
            // localWithServerChckBox
            // 
            this.localWithServerChckBox.AutoSize = true;
            this.localWithServerChckBox.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.localWithServerChckBox.Location = new System.Drawing.Point(667, 670);
            this.localWithServerChckBox.Name = "localWithServerChckBox";
            this.localWithServerChckBox.Size = new System.Drawing.Size(199, 27);
            this.localWithServerChckBox.TabIndex = 24;
            this.localWithServerChckBox.Text = "Local With Server";
            this.localWithServerChckBox.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.sumDiffLbl);
            this.groupBox1.Controls.Add(this.diffStatusLbl);
            this.groupBox1.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(931, 598);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(423, 158);
            this.groupBox1.TabIndex = 25;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Information";
            // 
            // sumDiffLbl
            // 
            this.sumDiffLbl.AutoSize = true;
            this.sumDiffLbl.Font = new System.Drawing.Font("Verdana", 12F);
            this.sumDiffLbl.Location = new System.Drawing.Point(16, 106);
            this.sumDiffLbl.Name = "sumDiffLbl";
            this.sumDiffLbl.Size = new System.Drawing.Size(128, 18);
            this.sumDiffLbl.TabIndex = 1;
            this.sumDiffLbl.Text = "Σ differences: ";
            // 
            // diffStatusLbl
            // 
            this.diffStatusLbl.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.diffStatusLbl.Location = new System.Drawing.Point(16, 42);
            this.diffStatusLbl.Name = "diffStatusLbl";
            this.diffStatusLbl.Size = new System.Drawing.Size(401, 57);
            this.diffStatusLbl.TabIndex = 0;
            this.diffStatusLbl.Text = "Status: ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(1364, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(144, 18);
            this.label6.TabIndex = 26;
            this.label6.Text = "Amar Causevic 2020";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::LanguageToolAmar.Properties.Resources.ga_logo_finale_resized;
            this.pictureBox1.Location = new System.Drawing.Point(535, -1);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(405, 72);
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // titleCheckBtn
            // 
            this.titleCheckBtn.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleCheckBtn.Location = new System.Drawing.Point(1363, 618);
            this.titleCheckBtn.Margin = new System.Windows.Forms.Padding(6);
            this.titleCheckBtn.Name = "titleCheckBtn";
            this.titleCheckBtn.Size = new System.Drawing.Size(138, 42);
            this.titleCheckBtn.TabIndex = 27;
            this.titleCheckBtn.Text = "Title Check";
            this.titleCheckBtn.UseVisualStyleBackColor = true;
            this.titleCheckBtn.Click += new System.EventHandler(this.titleCheckBtn_Click);
            // 
            // clearColorGridsBtn
            // 
            this.clearColorGridsBtn.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clearColorGridsBtn.Location = new System.Drawing.Point(1363, 680);
            this.clearColorGridsBtn.Margin = new System.Windows.Forms.Padding(6);
            this.clearColorGridsBtn.Name = "clearColorGridsBtn";
            this.clearColorGridsBtn.Size = new System.Drawing.Size(138, 42);
            this.clearColorGridsBtn.TabIndex = 28;
            this.clearColorGridsBtn.Text = "Clear Color (Grids)";
            this.clearColorGridsBtn.UseVisualStyleBackColor = true;
            this.clearColorGridsBtn.Click += new System.EventHandler(this.clearColorGridsBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(1520, 768);
            this.Controls.Add(this.clearColorGridsBtn);
            this.Controls.Add(this.titleCheckBtn);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.localWithServerChckBox);
            this.Controls.Add(this.serverWithLocalChckBox);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.jsonComparerBtn);
            this.Controls.Add(this.commonCheckBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.gameSelector);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.langSelector);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.searchParamter);
            this.Controls.Add(this.browseForLocalFile);
            this.Controls.Add(this.localFileViewGrid);
            this.Controls.Add(this.serverFileViewGrid);
            this.Controls.Add(this.getURLBtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Form1";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Language Tool (Amar Causevic)";
            ((System.ComponentModel.ISupportInitialize)(this.serverFileViewGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.localFileViewGrid)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button getURLBtn;
        private System.Windows.Forms.DataGridView serverFileViewGrid;
        private System.Windows.Forms.DataGridView localFileViewGrid;
        private System.Windows.Forms.Button browseForLocalFile;
        private System.Windows.Forms.TextBox searchParamter;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox langSelector;
        private System.Windows.Forms.ComboBox gameSelector;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox commonCheckBox;
        private System.Windows.Forms.Button jsonComparerBtn;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.CheckBox serverWithLocalChckBox;
        private System.Windows.Forms.CheckBox localWithServerChckBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label diffStatusLbl;
        private System.Windows.Forms.Label sumDiffLbl;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button titleCheckBtn;
        private System.Windows.Forms.Button clearColorGridsBtn;
    }
}

