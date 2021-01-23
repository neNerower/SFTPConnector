namespace Connector_SFTP_GUI_Prototip
{
    partial class SettingsForm
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
            this.folderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.passwordToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.changePasswordToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dropPasswordToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.LocalFolderPathLabel = new System.Windows.Forms.Label();
            this.CsvTaskFilePathLabel = new System.Windows.Forms.Label();
            this.CsvLogFilePathLabel = new System.Windows.Forms.Label();
            this.CsvExcFilePathLabel = new System.Windows.Forms.Label();
            this.LocalFolderPathChangeButton = new System.Windows.Forms.Button();
            this.CsvTaskFilePathChangeButton = new System.Windows.Forms.Button();
            this.CsvLogFilePathChangeButton = new System.Windows.Forms.Button();
            this.CsvExcFilePathChangeButton = new System.Windows.Forms.Button();
            this.LocalFolderPathTextBox = new System.Windows.Forms.TextBox();
            this.CsvTaskFilePathTextBox = new System.Windows.Forms.TextBox();
            this.CsvLogFilePathTextBox = new System.Windows.Forms.TextBox();
            this.CsvExcFilePathTextBox = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.SaveSettingsButton = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // folderBrowserDialog
            // 
            this.folderBrowserDialog.Description = "Select the directory that you want to download files in";
            this.folderBrowserDialog.RootFolder = System.Environment.SpecialFolder.MyComputer;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.menuStrip1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1000, 563);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveToolStripMenuItem,
            this.passwordToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1000, 28);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(54, 24);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // passwordToolStripMenuItem
            // 
            this.passwordToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.changePasswordToolStripMenuItem,
            this.dropPasswordToolStripMenuItem});
            this.passwordToolStripMenuItem.Name = "passwordToolStripMenuItem";
            this.passwordToolStripMenuItem.Size = new System.Drawing.Size(84, 24);
            this.passwordToolStripMenuItem.Text = "Password";
            // 
            // changePasswordToolStripMenuItem
            // 
            this.changePasswordToolStripMenuItem.Name = "changePasswordToolStripMenuItem";
            this.changePasswordToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.changePasswordToolStripMenuItem.Text = "Change password";
            this.changePasswordToolStripMenuItem.Click += new System.EventHandler(this.changePasswordToolStripMenuItem_Click);
            // 
            // dropPasswordToolStripMenuItem
            // 
            this.dropPasswordToolStripMenuItem.Name = "dropPasswordToolStripMenuItem";
            this.dropPasswordToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.dropPasswordToolStripMenuItem.Text = "Drop password";
            this.dropPasswordToolStripMenuItem.Click += new System.EventHandler(this.dropPasswordToolStripMenuItem_Click);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 7;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 15F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 15F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.LocalFolderPathLabel, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.CsvTaskFilePathLabel, 1, 3);
            this.tableLayoutPanel2.Controls.Add(this.CsvLogFilePathLabel, 1, 5);
            this.tableLayoutPanel2.Controls.Add(this.CsvExcFilePathLabel, 1, 7);
            this.tableLayoutPanel2.Controls.Add(this.LocalFolderPathChangeButton, 3, 1);
            this.tableLayoutPanel2.Controls.Add(this.CsvTaskFilePathChangeButton, 3, 3);
            this.tableLayoutPanel2.Controls.Add(this.CsvLogFilePathChangeButton, 3, 5);
            this.tableLayoutPanel2.Controls.Add(this.CsvExcFilePathChangeButton, 3, 7);
            this.tableLayoutPanel2.Controls.Add(this.LocalFolderPathTextBox, 5, 1);
            this.tableLayoutPanel2.Controls.Add(this.CsvTaskFilePathTextBox, 5, 3);
            this.tableLayoutPanel2.Controls.Add(this.CsvLogFilePathTextBox, 5, 5);
            this.tableLayoutPanel2.Controls.Add(this.CsvExcFilePathTextBox, 5, 7);
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel3, 5, 9);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(4, 31);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 10;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(992, 529);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // LocalFolderPathLabel
            // 
            this.LocalFolderPathLabel.AutoSize = true;
            this.LocalFolderPathLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LocalFolderPathLabel.Location = new System.Drawing.Point(29, 25);
            this.LocalFolderPathLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LocalFolderPathLabel.Name = "LocalFolderPathLabel";
            this.LocalFolderPathLabel.Size = new System.Drawing.Size(150, 77);
            this.LocalFolderPathLabel.TabIndex = 0;
            this.LocalFolderPathLabel.Text = "Local Folder Path";
            // 
            // CsvTaskFilePathLabel
            // 
            this.CsvTaskFilePathLabel.AutoSize = true;
            this.CsvTaskFilePathLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CsvTaskFilePathLabel.Location = new System.Drawing.Point(29, 112);
            this.CsvTaskFilePathLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.CsvTaskFilePathLabel.Name = "CsvTaskFilePathLabel";
            this.CsvTaskFilePathLabel.Size = new System.Drawing.Size(150, 77);
            this.CsvTaskFilePathLabel.TabIndex = 1;
            this.CsvTaskFilePathLabel.Text = "Csv Task File Path";
            // 
            // CsvLogFilePathLabel
            // 
            this.CsvLogFilePathLabel.AutoSize = true;
            this.CsvLogFilePathLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CsvLogFilePathLabel.Location = new System.Drawing.Point(29, 199);
            this.CsvLogFilePathLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.CsvLogFilePathLabel.Name = "CsvLogFilePathLabel";
            this.CsvLogFilePathLabel.Size = new System.Drawing.Size(150, 77);
            this.CsvLogFilePathLabel.TabIndex = 2;
            this.CsvLogFilePathLabel.Text = "Csv Log File Path";
            // 
            // CsvExcFilePathLabel
            // 
            this.CsvExcFilePathLabel.AutoSize = true;
            this.CsvExcFilePathLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CsvExcFilePathLabel.Location = new System.Drawing.Point(29, 286);
            this.CsvExcFilePathLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.CsvExcFilePathLabel.Name = "CsvExcFilePathLabel";
            this.CsvExcFilePathLabel.Size = new System.Drawing.Size(150, 77);
            this.CsvExcFilePathLabel.TabIndex = 3;
            this.CsvExcFilePathLabel.Text = "Csv Exc File Path";
            // 
            // LocalFolderPathChangeButton
            // 
            this.LocalFolderPathChangeButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LocalFolderPathChangeButton.Location = new System.Drawing.Point(202, 28);
            this.LocalFolderPathChangeButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.LocalFolderPathChangeButton.Name = "LocalFolderPathChangeButton";
            this.LocalFolderPathChangeButton.Size = new System.Drawing.Size(304, 71);
            this.LocalFolderPathChangeButton.TabIndex = 4;
            this.LocalFolderPathChangeButton.Text = "Choose folder";
            this.LocalFolderPathChangeButton.UseVisualStyleBackColor = true;
            this.LocalFolderPathChangeButton.Click += new System.EventHandler(this.LocalFolderPathChangeButton_Click);
            // 
            // CsvTaskFilePathChangeButton
            // 
            this.CsvTaskFilePathChangeButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CsvTaskFilePathChangeButton.Enabled = false;
            this.CsvTaskFilePathChangeButton.Location = new System.Drawing.Point(202, 115);
            this.CsvTaskFilePathChangeButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.CsvTaskFilePathChangeButton.Name = "CsvTaskFilePathChangeButton";
            this.CsvTaskFilePathChangeButton.Size = new System.Drawing.Size(304, 71);
            this.CsvTaskFilePathChangeButton.TabIndex = 5;
            this.CsvTaskFilePathChangeButton.Text = "Choose file";
            this.CsvTaskFilePathChangeButton.UseVisualStyleBackColor = true;
            // 
            // CsvLogFilePathChangeButton
            // 
            this.CsvLogFilePathChangeButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CsvLogFilePathChangeButton.Location = new System.Drawing.Point(202, 202);
            this.CsvLogFilePathChangeButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.CsvLogFilePathChangeButton.Name = "CsvLogFilePathChangeButton";
            this.CsvLogFilePathChangeButton.Size = new System.Drawing.Size(304, 71);
            this.CsvLogFilePathChangeButton.TabIndex = 6;
            this.CsvLogFilePathChangeButton.Text = "Choose file";
            this.CsvLogFilePathChangeButton.UseVisualStyleBackColor = true;
            // 
            // CsvExcFilePathChangeButton
            // 
            this.CsvExcFilePathChangeButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CsvExcFilePathChangeButton.Location = new System.Drawing.Point(202, 289);
            this.CsvExcFilePathChangeButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.CsvExcFilePathChangeButton.Name = "CsvExcFilePathChangeButton";
            this.CsvExcFilePathChangeButton.Size = new System.Drawing.Size(304, 71);
            this.CsvExcFilePathChangeButton.TabIndex = 7;
            this.CsvExcFilePathChangeButton.Text = "Choose file";
            this.CsvExcFilePathChangeButton.UseVisualStyleBackColor = true;
            // 
            // LocalFolderPathTextBox
            // 
            this.LocalFolderPathTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LocalFolderPathTextBox.Enabled = false;
            this.LocalFolderPathTextBox.Location = new System.Drawing.Point(529, 28);
            this.LocalFolderPathTextBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.LocalFolderPathTextBox.Multiline = true;
            this.LocalFolderPathTextBox.Name = "LocalFolderPathTextBox";
            this.LocalFolderPathTextBox.Size = new System.Drawing.Size(305, 71);
            this.LocalFolderPathTextBox.TabIndex = 8;
            // 
            // CsvTaskFilePathTextBox
            // 
            this.CsvTaskFilePathTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CsvTaskFilePathTextBox.Enabled = false;
            this.CsvTaskFilePathTextBox.Location = new System.Drawing.Point(529, 115);
            this.CsvTaskFilePathTextBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.CsvTaskFilePathTextBox.Multiline = true;
            this.CsvTaskFilePathTextBox.Name = "CsvTaskFilePathTextBox";
            this.CsvTaskFilePathTextBox.Size = new System.Drawing.Size(305, 71);
            this.CsvTaskFilePathTextBox.TabIndex = 9;
            // 
            // CsvLogFilePathTextBox
            // 
            this.CsvLogFilePathTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CsvLogFilePathTextBox.Enabled = false;
            this.CsvLogFilePathTextBox.Location = new System.Drawing.Point(529, 202);
            this.CsvLogFilePathTextBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.CsvLogFilePathTextBox.Multiline = true;
            this.CsvLogFilePathTextBox.Name = "CsvLogFilePathTextBox";
            this.CsvLogFilePathTextBox.Size = new System.Drawing.Size(305, 71);
            this.CsvLogFilePathTextBox.TabIndex = 10;
            // 
            // CsvExcFilePathTextBox
            // 
            this.CsvExcFilePathTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CsvExcFilePathTextBox.Enabled = false;
            this.CsvExcFilePathTextBox.Location = new System.Drawing.Point(529, 289);
            this.CsvExcFilePathTextBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.CsvExcFilePathTextBox.Multiline = true;
            this.CsvExcFilePathTextBox.Name = "CsvExcFilePathTextBox";
            this.CsvExcFilePathTextBox.Size = new System.Drawing.Size(305, 71);
            this.CsvExcFilePathTextBox.TabIndex = 11;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 3;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33332F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanel3.Controls.Add(this.SaveSettingsButton, 1, 1);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(528, 376);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 3;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 29.34783F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 36.95652F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(307, 150);
            this.tableLayoutPanel3.TabIndex = 12;
            // 
            // SaveSettingsButton
            // 
            this.SaveSettingsButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SaveSettingsButton.Enabled = false;
            this.SaveSettingsButton.Location = new System.Drawing.Point(105, 47);
            this.SaveSettingsButton.Name = "SaveSettingsButton";
            this.SaveSettingsButton.Size = new System.Drawing.Size(96, 49);
            this.SaveSettingsButton.TabIndex = 0;
            this.SaveSettingsButton.Text = "Save";
            this.SaveSettingsButton.UseVisualStyleBackColor = true;
            this.SaveSettingsButton.Click += new System.EventHandler(this.SaveSettingsButton_Click);
            // 
            // SettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 563);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "SettingsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SFTP Controller | Settings";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label LocalFolderPathLabel;
        private System.Windows.Forms.Label CsvTaskFilePathLabel;
        private System.Windows.Forms.Label CsvLogFilePathLabel;
        private System.Windows.Forms.Label CsvExcFilePathLabel;
        private System.Windows.Forms.Button LocalFolderPathChangeButton;
        private System.Windows.Forms.Button CsvTaskFilePathChangeButton;
        private System.Windows.Forms.Button CsvLogFilePathChangeButton;
        private System.Windows.Forms.Button CsvExcFilePathChangeButton;
        private System.Windows.Forms.TextBox LocalFolderPathTextBox;
        private System.Windows.Forms.TextBox CsvTaskFilePathTextBox;
        private System.Windows.Forms.TextBox CsvLogFilePathTextBox;
        private System.Windows.Forms.TextBox CsvExcFilePathTextBox;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Button SaveSettingsButton;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem passwordToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem changePasswordToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dropPasswordToolStripMenuItem;
    }
}