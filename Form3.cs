using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mp3_Player
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void buttonexit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        string[] paths, files;

        private void buttonMin_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;   
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void listBoxSong_SelectedIndexChanged(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.URL = paths[listBoxSong.SelectedIndex];

        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void AddMusicbutton_Click(object sender, EventArgs e)
        {
           OpenFileDialog ofd= new OpenFileDialog();
            ofd.Multiselect = true;
            if(ofd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                files = ofd.SafeFileNames;
                paths = ofd.FileNames;
                for(int i = 0; i < files.Length; i++)
                {
                    listBoxSong.Items.Add(files[i]);
                }
            }
        }
    }
}
