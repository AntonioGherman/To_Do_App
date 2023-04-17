using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ToDo
{
    public partial class Form1 : Form
    {
        private ToDoItem editorState = new ToDoItem();

        public Form1()
        {
            InitializeComponent();

          
        }

        private void updateUI()
        {
            string fileName = "Untitled";
            string fullFileName = "Untitled";
            string savedState = editorState.IsSaved ? "" : "*";

            if (editorState.FileName != null)
            {
                fullFileName = editorState.FileName;
                fileName = new FileInfo(fullFileName).Name;
            }

            this.Text = "ToDo List - " + savedState + fileName;
          //  toolStripStatusLabel1.Text = editorState.FileName != null ? fullFileName : "Ready.";

        }

        private void adaugaSarcina_Click(object sender, EventArgs e)
        {
            Sarcina item = new Sarcina(
                numeSarcina.Text,
                descriereSarcina.Text,
                dataTerminare.Text,
                prioritate.SelectedItem.ToString());

            afisareSarcini.Items.Add(item.numeSarcina);
            afisareSarcini.Items.Add(item.descriere);
            afisareSarcini.Items.Add(item.dataFinalizare);
            afisareSarcini.Items.Add(item.prioritate);
            afisareSarcini.Items.Add(" ");
            Console.Write(new Sarcina(
                numeSarcina.Text,
                descriereSarcina.Text,
                dataTerminare.Text,
                prioritate.SelectedItem.ToString()).ToString());


        }

        private void nouToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (editorState.IsSaved)
            {
                DialogResult dr = MessageBox.Show(
                    "Do you want to save it?",
                    "Confirmation",
                    MessageBoxButtons.YesNoCancel,
                    MessageBoxIcon.Question);

                if (dr == DialogResult.Yes)
                {
                    salvareCaToolStripMenuItem_Click(sender, null);
                }

                if (dr != DialogResult.Cancel)
                {
                    initEditor();
                }
                else
                {
                   // afisareSarcini.
                }
            }
            else
            {
                initEditor();
            }
        }

        private void initEditor()
        {
           afisareSarcini.Items.Clear();
            editorState.FileName = null;
            editorState.IsSaved = true;

            updateUI();
        }

        private void iesireToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void salvareCaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    StreamWriter sw = new StreamWriter(saveFileDialog1.FileName);

                    for(int i=0;i<afisareSarcini.Items.Count;i++) 
                    {
                        sw.Write(afisareSarcini.Items[i].ToString()+"\r\n");
                       
                    }
                    sw.Close();


                    editorState.FileName = saveFileDialog1.FileName;
                    editorState.IsSaved = true;

                    updateUI();
                }
                catch
                {
                    MessageBox.Show("Could not save file", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void salvareToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (editorState.FileName == null)
            {
                salvareCaToolStripMenuItem_Click(sender, null);
            }
            else
            {
                try
                {
                    StreamWriter sw = new StreamWriter(editorState.FileName);
                    for (int i = 0; i < afisareSarcini.Items.Count; i++)
                    {
                        sw.Write(afisareSarcini.Items[i].ToString() + "\r\n");

                    }
                    sw.Close();

                    editorState.IsSaved = true;

                    updateUI();
                }
                catch
                {
                    MessageBox.Show("Could not save file", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void deschidereToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!editorState.IsSaved)
            {
                DialogResult dr = MessageBox.Show(
                    "You have changes in your file. Do you want to save it?",
                    "Confirmation",
                    MessageBoxButtons.YesNoCancel,
                    MessageBoxIcon.Question);

                if (dr == DialogResult.Yes)
                {
                    salvareCaToolStripMenuItem_Click(sender, null);
                }

                if (dr == DialogResult.Cancel)
                {
                    return;
                }
            }

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    StreamReader sr = new StreamReader(openFileDialog1.FileName);
                    String line;
                    while ((line = sr.ReadLine()) != null) {
                        afisareSarcini.Items.Add(line);
                    }
                        
                    sr.Close();

                    editorState.FileName = openFileDialog1.FileName;
                    editorState.IsSaved = true;

                    updateUI();
                }
                catch
                {
                    MessageBox.Show("Could not load file", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void adaugatiSarcinaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            numeSarcina.Clear();
            descriereSarcina.Clear();
        }

        private void editatiSarcinaToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void stergetiSarcinaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (afisareSarcini.SelectedIndex != -1)
            {

                while (afisareSarcini.SelectedItems.Count != 0)
                {

                    afisareSarcini.Items.Remove(afisareSarcini.SelectedItems[0]);

                }

            }
            else {

                MessageBox.Show("Please selected an item(s)");
            }
        }
    }
}
