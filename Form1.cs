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
        private Mp3Player mp3Player = new Mp3Player();

        public AudioPlayerApp()
        {
            InitializeComponent();
        }
        //Create Global Variables of String Type Array to save  the titles  of the Tracks  and path of the track
        String[] paths, files;

        private void Form1_Load(object sender, EventArgs e)
        {

        }
  

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            //Code to closer the app

            Environment.Exit(1);
        }

        private void button1_Click(object sender, EventArgs e)
        {// Code to Select Songs
            using (OpenFileDialog ofd = new OpenFileDialog())

            {
                ofd.Filter = "Mp3 Files|*.mp3";

                //Code to Select Multiple Songs
                ofd.Multiselect = true;

                if  (ofd.ShowDialog() == System.Windows.Forms.DialogResult.OK)

                {    
                    files = ofd.SafeFileNames; //Save the names of the track in filles array
                    paths = ofd.FileNames; //Save the paths of the tracks  in path array 
                    mp3Player.open(ofd.FileName);

                    // Dispay  the music  titles in listbox

                    for  (int i =0; i < files.Length; i++)
                    {

                        listBoxSongs.Items.Add(files[i]); //Display songs in Listbox
                    }

             
                }


            }

        }

        private void button3_Click(object sender, EventArgs e)
        { // Code to play music
            mp3Player.play();

        }

        private void listBoxSongs_SelectedIndexChanged(object sender, EventArgs e)
        {
          
        }

        private void button5_Click(object sender, EventArgs e)
        {// code to stop music
            mp3Player.stop();

        }
    }
}
