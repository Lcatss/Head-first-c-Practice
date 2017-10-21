using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Runtime.Serialization;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        private Excuse currentExcuse = new Excuse();
        private string currentFolder = "";
        private bool formChanged = false;
        Random random = new Random();

        public Form1()
        {
            InitializeComponent();
            currentExcuse.LastUsed = lastUsed.Value;

        }

        private void flowLayoutPanel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Save.Enabled = false;
            Open.Enabled = false;
            Random.Enabled = false;
        }

        private void UpdateForm(bool changed)
        {
            if (!changed)
            {
                this.description.Text = currentExcuse.Description;
                this.results.Text = currentExcuse.Results;
                this.lastUsed.Value = currentExcuse.LastUsed;
                if (!string.IsNullOrEmpty(currentExcuse.ExcusePath))
                {
                    fileDate.Text = File.GetLastWriteTime(currentExcuse.ExcusePath).ToString();
                    this.Text = "Excuse Manager";
                }
            }
            else
                this.Text = "Excuse Manager*";
            this.formChanged = changed;
            
        }




        private void Folder_Click(object sender, EventArgs e)
        {
            folderBrowserDialog1.SelectedPath = currentFolder;
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                currentFolder = folderBrowserDialog1.SelectedPath;
                Save.Enabled = true;
                Open.Enabled = true;
                Random.Enabled = true;
            }

        }

        private void Save_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(description.Text)||string.IsNullOrEmpty(results.Text))
            {
                MessageBox.Show("Please specify an excuse and a result","Unable to save",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
                return;
            }
            saveFileDialog1.InitialDirectory = currentFolder;
            saveFileDialog1.FileName = currentExcuse.Description + ".excuse";
            saveFileDialog1.Filter = "Excuse Files|*.excuse";
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                currentExcuse.Save(saveFileDialog1.FileName);
                UpdateForm(false);
                MessageBox.Show("Excuse written");
            }
        }

        private void Open_Click(object sender, EventArgs e)
        {
            if (CheckChanged())
            {

                openFileDialog1.InitialDirectory = currentFolder;
                openFileDialog1.Filter = "Excuse Files|*.excuse";
                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    bool clearForm=false;
                    try
                    {
                        currentExcuse = new Excuse(openFileDialog1.FileName);
                        try
                        {
                            UpdateForm(false);
                        }
                        catch (ArgumentOutOfRangeException
                            )
                        {
                            clearForm = true;
                        }
                    }
                    catch (SerializationException)
                    {
                        MessageBox.Show("The excuse file '" + openFileDialog1.FileName + "' is invalid");
                        clearForm = true;

                    }
                    finally
                    {
                        if (clearForm)
                        {
                            currentExcuse.Description = "";
                            currentExcuse.Results = "";
                            currentExcuse.LastUsed = DateTime.Now;
                        }
                    }
                            
                }
                        


                
            }

        }

        private void Random_Click(object sender, EventArgs e)
        {
            currentExcuse = new Excuse(random, currentFolder);
            UpdateForm(false);
        }

        private void description_TextChanged(object sender, EventArgs e)
        {
            currentExcuse.Description = description.Text;
            UpdateForm(true);
        }

        private void results_TextChanged(object sender, EventArgs e)
        {
            currentExcuse.Results = results.Text;
            UpdateForm(true);

        }

        private void lastUsed_ValueChanged(object sender, EventArgs e)
        {
            currentExcuse.LastUsed = lastUsed.Value;
            UpdateForm(true);
        }

        private bool CheckChanged()
        {
            if (formChanged)
            {
                DialogResult result = MessageBox.Show("The current excuse has not been saved.Continue?", "Waring", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                    return true;
                else
                    return false;
            }
            return true;
        }

                


        
    }
}
