using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gudioapp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            imgDragArea.AllowDrop = true;
        }

        private void btnChangeBackgroundColor_Click(object sender, EventArgs e)
        {
            colorDialog.ShowDialog();
            this.BackColor = colorDialog.Color;
        }

        private void btnOpenFile_Click(object sender, EventArgs e)
        {
            fileDialog1.ShowDialog();
        }

        private void btnDeleteFile_Click(object sender, EventArgs e)
        {
            if (File.Exists(fileDialog1.FileName))
            {
                File.Delete(fileDialog1.FileName);
            }
        }

        private void btnReadData_Click(object sender, EventArgs e)
        {
            if (File.Exists(fileDialog1.FileName))
            {
                fileDatatxtBox.Text = File.ReadAllText(fileDialog1.FileName);
            }
            MessageBox.Show("File Not Found");
        }

        private void btnWriteData_Click(object sender, EventArgs e)
        {
            if (File.Exists(fileDialog1.FileName))
            {
                StreamWriter sw = new StreamWriter(fileDialog1.FileName);
                sw.Write(fileDatatxtBox.Text);
                sw.Close();
            }
        }


        private void imgDragArea_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect |= DragDropEffects.Copy;
        }
        private void imgDragArea_DragDrop(object sender, DragEventArgs e)
        {
            string[] files = e.Data.GetData(DataFormats.FileDrop) as string[];
            foreach (string file in files)
            {
                imgComboBox.Items.Add(file);
            }
        }

      

        private void imgComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string filePath = imgComboBox.SelectedItem as string;
            Console.WriteLine(filePath);
            if (filePath != null && File.Exists(filePath))
            {
                pictureBox.Image = Image.FromFile(imgComboBox.SelectedItem as string);
            }
 
        }

        private void btnAddToListBox_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(contentForListBox.Text);
        }

        private void btnConvertCaps_Click(object sender, EventArgs e)
        {
            string newText = "";
            foreach (char c in textToConvertBox.Text)
            {
                newText += (!(c <= 96 || c >= 123)) ? (char)(c - 32) : c;
            }
            textToConvertBox.Text = newText;
        }

        private async void btnWebhook_Click(object sender, EventArgs e)
        {
            string webhookUrl = "https://webhook.site/6e922558-fdd1-4166-a25f-8412100f43e3"; // Replace with your webhook URL
            string jsonPayload = "{\"message\": \"Hello, Webhook!\"}"; // Simple JSON payload

            HttpClient client = new HttpClient();
            var content = new StringContent(jsonPayload, Encoding.UTF8, "application/json");
            await client.PostAsync(webhookUrl, content);
        }

        private void btnReadCsv_Click(object sender, EventArgs e)
        {
            fileDialogCSV.Filter = "CSV files (*.csv)|*.csv|All files (*.*)|*.*";
            fileDialogCSV.Title = "Select a CSV File";
            fileDialogCSV.ShowDialog();
            string filePath = fileDialogCSV.FileName;
            StreamReader sr = new StreamReader(filePath);
            Console.WriteLine("hi");
            string line;
            List<List<string>> rows = new List<List<string>>();
            while ((line = sr.ReadLine()) != null)
            {

                List<string> columns = new List<string>(line.Split(','));
                rows.Add(columns);
                Console.WriteLine("hi");
            }
            bool rowsCreated = false;
            int topPosition = 10;
            foreach (var row in rows)
            {
                if (!rowsCreated)
                {
                    Console.WriteLine(row.Count);
                    int totalWidth = row.Count * 110;
                    int startX = (this.ClientSize.Width - totalWidth) / 2;
                    int leftPosition = startX;
                    for (int i = 0; i < row.Count; i++)
                    {



                        TextBox textBox = new TextBox
                        {
                            Text = row[i],
                            Left = leftPosition,
                            Top = topPosition,
                            Width = 100 // Width of each TextBox
                        };

                        // Add the TextBox to the form's Controls
                        this.Controls.Add(textBox);

                        // Update the left position for the next TextBox
                        leftPosition += 110; // Increase to avoid overlapping
                    }
                    rowsCreated = true;
                    // Update the top position for the next row of TextBoxes
                    topPosition += 30; // Increase for next row of textboxes
                    
                }
            }  
                }
            }        
        }

    

