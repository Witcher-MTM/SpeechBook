using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Speech.Synthesis;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SpeechBook
{
    public partial class BookForm : Form
    {
        bool speak = false;
        string FileName = string.Empty;
        public BookForm(string file)
        {
            FileName = file;
            InitializeComponent();
        }

        private void BookForm_Load(object sender, EventArgs e)
        {
            this.BookText.Text = File.ReadAllText(FileName);
            this.BookHeader.Text = Path.GetFileName(FileName);
        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            this.Hide();
            form.ShowDialog();

        }

        private void BtnAudio_Click(object sender, EventArgs e)
        {
            SpeechSynthesizer synthesizer = new SpeechSynthesizer();
            if (speak)
            {
                synthesizer.Volume = 100;  // 0...100
                synthesizer.Rate = -2;     // -10...10// Synchronous
                synthesizer.SpeakAsync(this.BookText.Text);
                speak = false;
            }
            else
            {
                synthesizer.Pause();
                speak = true;
            }
           
           


        }
    }
}
