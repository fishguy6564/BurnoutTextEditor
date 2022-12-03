
namespace BurnoutLegendsTextEditor
{
    partial class MainWindow
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
            System.Windows.Forms.Button addEntryButton;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            System.Windows.Forms.Button deleteEntryButton;
            System.Windows.Forms.Button saveEntryButton;
            System.Windows.Forms.Button importFileButton;
            this.textListBox = new System.Windows.Forms.ListBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.creditsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.entryTextBox = new System.Windows.Forms.TextBox();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.label2 = new System.Windows.Forms.Label();
            this.importFileDialog = new System.Windows.Forms.OpenFileDialog();
            addEntryButton = new System.Windows.Forms.Button();
            deleteEntryButton = new System.Windows.Forms.Button();
            saveEntryButton = new System.Windows.Forms.Button();
            importFileButton = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // addEntryButton
            // 
            addEntryButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("addEntryButton.BackgroundImage")));
            addEntryButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            addEntryButton.FlatAppearance.BorderColor = System.Drawing.SystemColors.Window;
            addEntryButton.FlatAppearance.BorderSize = 0;
            addEntryButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            addEntryButton.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            addEntryButton.Location = new System.Drawing.Point(117, 69);
            addEntryButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            addEntryButton.Name = "addEntryButton";
            addEntryButton.Size = new System.Drawing.Size(59, 50);
            addEntryButton.TabIndex = 3;
            addEntryButton.UseVisualStyleBackColor = true;
            addEntryButton.Click += new System.EventHandler(this.addEntryButton_Click);
            // 
            // deleteEntryButton
            // 
            deleteEntryButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("deleteEntryButton.BackgroundImage")));
            deleteEntryButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            deleteEntryButton.FlatAppearance.BorderColor = System.Drawing.SystemColors.Window;
            deleteEntryButton.FlatAppearance.BorderSize = 0;
            deleteEntryButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            deleteEntryButton.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            deleteEntryButton.Location = new System.Drawing.Point(176, 69);
            deleteEntryButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            deleteEntryButton.Name = "deleteEntryButton";
            deleteEntryButton.Size = new System.Drawing.Size(72, 50);
            deleteEntryButton.TabIndex = 4;
            deleteEntryButton.UseVisualStyleBackColor = true;
            deleteEntryButton.Click += new System.EventHandler(this.deleteEntryButton_Click);
            // 
            // saveEntryButton
            // 
            saveEntryButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("saveEntryButton.BackgroundImage")));
            saveEntryButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            saveEntryButton.FlatAppearance.BorderColor = System.Drawing.SystemColors.Window;
            saveEntryButton.FlatAppearance.BorderSize = 0;
            saveEntryButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            saveEntryButton.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            saveEntryButton.Location = new System.Drawing.Point(243, 60);
            saveEntryButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            saveEntryButton.Name = "saveEntryButton";
            saveEntryButton.Size = new System.Drawing.Size(72, 64);
            saveEntryButton.TabIndex = 5;
            saveEntryButton.UseVisualStyleBackColor = true;
            saveEntryButton.Click += new System.EventHandler(this.saveEntryButton_Click);
            // 
            // textListBox
            // 
            this.textListBox.FormattingEnabled = true;
            this.textListBox.ItemHeight = 31;
            this.textListBox.Location = new System.Drawing.Point(11, 143);
            this.textListBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textListBox.Name = "textListBox";
            this.textListBox.Size = new System.Drawing.Size(383, 624);
            this.textListBox.TabIndex = 0;
            this.textListBox.SelectedIndexChanged += new System.EventHandler(this.textListBox_SelectedIndexChanged);
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(40, 40);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.creditsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1011, 60);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.saveAsToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(87, 56);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(302, 54);
            this.openToolStripMenuItem.Text = "Open...";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(302, 54);
            this.saveToolStripMenuItem.Text = "Save";
            // 
            // saveAsToolStripMenuItem
            // 
            this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            this.saveAsToolStripMenuItem.Size = new System.Drawing.Size(302, 54);
            this.saveAsToolStripMenuItem.Text = "Save as...";
            this.saveAsToolStripMenuItem.Click += new System.EventHandler(this.saveAsToolStripMenuItem_Click);
            // 
            // creditsToolStripMenuItem
            // 
            this.creditsToolStripMenuItem.Name = "creditsToolStripMenuItem";
            this.creditsToolStripMenuItem.Size = new System.Drawing.Size(135, 56);
            this.creditsToolStripMenuItem.Text = "Credits";
            // 
            // entryTextBox
            // 
            this.entryTextBox.Location = new System.Drawing.Point(419, 69);
            this.entryTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.entryTextBox.Multiline = true;
            this.entryTextBox.Name = "entryTextBox";
            this.entryTextBox.Size = new System.Drawing.Size(580, 698);
            this.entryTextBox.TabIndex = 2;
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 79);
            this.label2.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 32);
            this.label2.TabIndex = 7;
            this.label2.Text = "Entries:";
            // 
            // importFileButton
            // 
            importFileButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("importFileButton.BackgroundImage")));
            importFileButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            importFileButton.FlatAppearance.BorderColor = System.Drawing.SystemColors.Window;
            importFileButton.FlatAppearance.BorderSize = 0;
            importFileButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            importFileButton.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            importFileButton.Location = new System.Drawing.Point(321, 60);
            importFileButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            importFileButton.Name = "importFileButton";
            importFileButton.Size = new System.Drawing.Size(52, 55);
            importFileButton.TabIndex = 8;
            importFileButton.UseVisualStyleBackColor = true;
            importFileButton.Click += new System.EventHandler(this.importFileButton_Click);
            // 
            // importFileDialog
            // 
            this.importFileDialog.Filter = "Text files|*txt";
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1011, 799);
            this.Controls.Add(importFileButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(saveEntryButton);
            this.Controls.Add(addEntryButton);
            this.Controls.Add(deleteEntryButton);
            this.Controls.Add(this.entryTextBox);
            this.Controls.Add(this.textListBox);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "MainWindow";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.MainWindow_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox textListBox;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveAsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem creditsToolStripMenuItem;
        private System.Windows.Forms.TextBox entryTextBox;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.OpenFileDialog importFileDialog;
    }
}

