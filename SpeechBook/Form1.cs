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

namespace SpeechBook
{
    public partial class Form1 : Form
    {
        string fileContent = string.Empty;
        string filePath = string.Empty;
        string fileName = string.Empty;
        List<Button> btns = new List<Button>();
        List<string> PathFiles = new List<string>();
        public Form1()
        {
            InitializeComponent();
            if (!File.Exists("Book1.txt"))
            {
                File.Create("Book1.txt").Close();
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < 9; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    btns.Add(new Button
                    {
                        Size = new Size(80, 120),
                        Name = $"0",
                        Location = new Point(i * 80, j * 120),
                        Visible = false,
                        
                    });
                }
            }
            if (File.Exists("tmp.txt"))
            {
                foreach (var item in File.ReadAllLines("tmp.txt"))
                {
                    filePath = item;
                    fileName = Path.GetFileName(item);
                    fileContent = File.ReadAllText(item);
                    foreach (var button in btns)
                    {
                        if (button.Name == "0")
                        {
                            button.Visible = true;
                            button.Name = filePath;
                            button.Text = fileName;
                            PathFiles.Add($"{filePath}\n");
                            break;
                        }
                        else
                        {
                            MessageBox.Show("You havent empty space");
                        }
                    }

                }
            }
            
            foreach (var item in btns)
            {
                item.Click += Btns_Click;
            }
            this.Controls.AddRange(btns.ToArray());
        }

        private void Btns_Click(object sender, EventArgs e)
        {
            string BtnName = (sender as Button).Name;
           
            BookForm book = new BookForm(BtnName);
           
            this.Hide();
            book.ShowDialog();
          

        }

       
        private void AddBookBtn_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog file = new OpenFileDialog())
            {
                file.Filter = "txt files (*.txt)|*.txt|pdf file(*.pdf)|*.pdf";
                file.FilterIndex = 2;
                file.RestoreDirectory = true;
                if (file.ShowDialog() == DialogResult.OK)
                {
                    filePath = file.FileName;
                    fileName = Path.GetFileName(filePath);
                    fileContent = File.ReadAllText(filePath);
                    File.WriteAllText(fileName, fileContent);
                    foreach (var item in btns)
                    {
                        if (item.Name == "0")
                        {
                            item.Visible = true;
                            item.Name = filePath;
                            item.Text = fileName;
                            PathFiles.Add($"{filePath}\n");
                            break;
                        }
                        else
                        {
                            MessageBox.Show("You havent empty space");
                        }
                    }
                }
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            File.Create("tmp.txt").Close();
            foreach (var item in PathFiles)
            {
                File.AppendAllText("tmp.txt", item);
            }
        }
    }
}
