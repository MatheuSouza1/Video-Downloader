using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using FFMpegCore;
using VideoLibrary;

namespace vidDownloader
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            progressBar.Visible = false;
            txtBoxPath.Text = GetDefaultPath();
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            using (var folderDialog = new FolderBrowserDialog())
            {
                if (folderDialog.ShowDialog() == DialogResult.OK)
                    txtBoxPath.Text = folderDialog.SelectedPath + "\\";
            }
        }

        private string GetDefaultPath()
        {
            var home = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile);

            return Path.Combine(home, "Downloads");
        }
    }
}
