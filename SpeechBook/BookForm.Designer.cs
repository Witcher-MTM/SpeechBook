
namespace SpeechBook
{
    partial class BookForm
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
            this.BookText = new System.Windows.Forms.TextBox();
            this.BookHeader = new System.Windows.Forms.Label();
            this.BtnBack = new System.Windows.Forms.Button();
            this.BtnAudio = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BookText
            // 
            this.BookText.Location = new System.Drawing.Point(410, 57);
            this.BookText.Multiline = true;
            this.BookText.Name = "BookText";
            this.BookText.ReadOnly = true;
            this.BookText.Size = new System.Drawing.Size(378, 381);
            this.BookText.TabIndex = 0;
            // 
            // BookHeader
            // 
            this.BookHeader.AutoSize = true;
            this.BookHeader.Location = new System.Drawing.Point(410, 13);
            this.BookHeader.Name = "BookHeader";
            this.BookHeader.Size = new System.Drawing.Size(35, 13);
            this.BookHeader.TabIndex = 1;
            this.BookHeader.Text = "label1";
            // 
            // BtnBack
            // 
            this.BtnBack.Location = new System.Drawing.Point(13, 414);
            this.BtnBack.Name = "BtnBack";
            this.BtnBack.Size = new System.Drawing.Size(120, 23);
            this.BtnBack.TabIndex = 2;
            this.BtnBack.Text = "Back";
            this.BtnBack.UseVisualStyleBackColor = true;
            this.BtnBack.Click += new System.EventHandler(this.BtnBack_Click);
            // 
            // BtnAudio
            // 
            this.BtnAudio.Location = new System.Drawing.Point(12, 13);
            this.BtnAudio.Name = "BtnAudio";
            this.BtnAudio.Size = new System.Drawing.Size(207, 23);
            this.BtnAudio.TabIndex = 3;
            this.BtnAudio.Text = "Play Audio Book";
            this.BtnAudio.UseVisualStyleBackColor = true;
            this.BtnAudio.Click += new System.EventHandler(this.BtnAudio_Click);
            // 
            // BookForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BtnAudio);
            this.Controls.Add(this.BtnBack);
            this.Controls.Add(this.BookHeader);
            this.Controls.Add(this.BookText);
            this.Name = "BookForm";
            this.Text = "BookForm";
            this.Load += new System.EventHandler(this.BookForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox BookText;
        private System.Windows.Forms.Label BookHeader;
        private System.Windows.Forms.Button BtnBack;
        private System.Windows.Forms.Button BtnAudio;
    }
}