using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AudioPlayerApp
{
    public partial class AudioPlayerApp : Form
    {
        public AudioPlayerApp()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        //Create Global Variables pf String Type Array to save the titles or name of the Tracks and path of the track
        String[] paths, files;

        private void buttonSelectSongs_Click(object sender, EventArgs e)
        {
            // Code to Select Songs
            OpenFileDialog ofd = new OpenFileDialog();
            //Code to select multiple songs
            ofd.Multiselect = true;
            if(ofd.ShowDialog()==System.Windows.Forms.DialogResult.OK)
            {
                files = ofd.SafeFileNames; //Save the names of the track in files array
                paths = ofd.FileNames; // Save the paths of the tracks in path array
                //Display the music titles in listbox

            for (int i=0; i < files.Length; i++)
                {
                    listBoxSongs.Items.Add(files[i]); //Display Songs in ListBox

                }
            }
        }

        private void listBoxSongs_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Write a code to play music
            axWindowsMediaPlayerMusic.URL = paths[listBoxSongs.SelectedIndex];
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            //Code to closer the app

            Environment.Exit(1);
        }
    }
}
