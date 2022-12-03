using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BurnoutLegendsTextEditor
{
    public partial class MainWindow : Form
    {
        private String g_filepath;
        private BinaryText g_interpreter;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void updateList()
        {
            uint maxEntries = this.g_interpreter.getMaxEntries();
            textListBox.Items.Clear();

            for(uint i = 0; i < maxEntries; i++)
            {
                textListBox.Items.Add(i);
            }
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(openFileDialog.ShowDialog() == DialogResult.OK)
            {
                String filepath = Path.GetFullPath(openFileDialog.FileName);
                g_interpreter.clear();

                if (!g_interpreter.openFile(filepath))
                {
                    MessageBox.Show("Error Opening File!");
                    return;
                }

                updateList();
                this.g_filepath = filepath;
            }
        }

        private void textListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selectedIndex = textListBox.SelectedIndex;
            if (selectedIndex == -1) return;
            entryTextBox.Text = g_interpreter.getEntryString(selectedIndex);
        }

        private void saveEntryButton_Click(object sender, EventArgs e)
        {
            int selectedIndex = textListBox.SelectedIndex;
            if (selectedIndex == -1) return;
            g_interpreter.setEntyString(entryTextBox.Text, selectedIndex);
        }

        private void deleteEntryButton_Click(object sender, EventArgs e)
        {
            int selectedIndex = textListBox.SelectedIndex;
            if (selectedIndex == -1) return;
            g_interpreter.deleteEntry(selectedIndex);
            updateList();
        }

        private void addEntryButton_Click(object sender, EventArgs e)
        {
            uint currentEntry= g_interpreter.getMaxEntries();
            g_interpreter.addEntryString(entryTextBox.Text);
            textListBox.Items.Add(currentEntry);
        }

        private void MainWindow_Load(object sender, EventArgs e)
        {
            g_interpreter = new BinaryText();
        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                String filepath = Path.GetFullPath(saveFileDialog.FileName);

                if (!g_interpreter.saveFile(filepath))
                {
                    MessageBox.Show("Error Saving File!");
                    return;
                }

                g_filepath = filepath;
            }
        }

        private void importFileButton_Click(object sender, EventArgs e)
        {
            if(importFileDialog.ShowDialog() == DialogResult.OK)
            {
                String filepath = Path.GetFullPath(importFileDialog.FileName);

                try
                {
                    String[] importedStrings;
                    importedStrings = File.ReadAllLines(filepath);
                    g_interpreter.importStrings(importedStrings);
                    MessageBox.Show("Imported " + importedStrings.Length + " New Entries!");
                    updateList();
                }catch(IOException)
                {
                    MessageBox.Show("Error Opening File!");
                }
            }
        }
    }
}
