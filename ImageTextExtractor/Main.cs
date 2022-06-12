using IronOcr;
using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace ImageTextExtractor
{
    public partial class Main : Form
    {
        private string path = string.Empty;

        public Main()
        {
            InitializeComponent();
        }

        private void ShowProgress(bool show)
        {
            lblProgress.Visible = show;
        }
        private void SelectImage(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Images|*.png;*.jpg;*.jpeg;*.gif";
            ofd.Title = "Select an Image";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                imgPreview.Image = Image.FromFile(ofd.FileName);
                lblName.Text = Path.GetFileName(ofd.FileName);
                lblPath.Text = ofd.FileName;
                lblName.Show();
                lblPath.Show();
                path = ofd.FileName;
                ShowProgress(true);
                worker.RunWorkerAsync();
            }
        }

        private void btnCopy_Click(object sender, EventArgs e)
        {
            if (textOutput.Text.Length > 0)
            {
                textOutput.Copy();
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "Txt File|*.txt";
            sfd.FileName = "text_output";
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                File.WriteAllText(sfd.FileName, textOutput.Text);
            }
        }

        private void worker_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {
            if (path != null && path.Length > 0)
            {
                OcrResult result = new IronTesseract().Read(path);
                textOutput.Invoke((MethodInvoker)delegate
                {
                    textOutput.Text = result.Text;
                });

                }    
        }

        private void worker_RunWorkerCompleted(object sender, System.ComponentModel.RunWorkerCompletedEventArgs e)
        {
            ShowProgress(false);
        }
    }
}
