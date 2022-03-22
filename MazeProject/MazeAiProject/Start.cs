using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MazeAiProject
{
    public partial class Start : Form
    {
        bool isSoundActive = true;
        SoundPlayer simpleSound;
        public Start()
        {
            simpleSound = new SoundPlayer(Directory.GetCurrentDirectory().Replace("\\bin\\Debug", "\\Sounds\\Start Sound.wav"));
            InitializeComponent();
            if (!File.Exists("sound.txt"))
            {
                FileStream filenew = new FileStream("sound.txt", FileMode.Create, FileAccess.ReadWrite);
                StreamWriter swnew = new StreamWriter(filenew);
                swnew.WriteLine("true");
                swnew.Close();
                filenew.Close();
            }


        }

        private void btn_1_Click(object sender, EventArgs e)
        {

            Level_One fm = new Level_One(isSoundActive);
            fm.Show();
            this.Hide();

        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_2_Click(object sender, EventArgs e)
        {

            Level_Two fm = new Level_Two(isSoundActive);
            fm.Show();
            this.Hide();
        }

        private void btn_3_Click(object sender, EventArgs e)
        {
            Level_Three fm = new Level_Three(isSoundActive);
            fm.Show();
            this.Hide();
        }

        private void Start_FormClosed(object sender, FormClosedEventArgs e)
        {
            simpleSound.Stop();
            Application.Exit();
        }

        private void Start_Load(object sender, EventArgs e)
        {
            FileStream file = new FileStream("sound.txt", FileMode.Open, FileAccess.ReadWrite);
            StreamReader sw = new StreamReader(file);
            var sound = sw.ReadLine();
            if (sound == "false")
            {
                simpleSound.Stop();
                rdi_off.Checked = true;
            }
            else
            {
                simpleSound.Play();
                simpleSound.PlayLooping();
                rdi_on.Checked = true;
            }
            sw.Close();
            file.Close();
        }

        private void rdi_on_Click(object sender, EventArgs e)
        {

            FileStream file = new FileStream("sound.txt", FileMode.OpenOrCreate, FileAccess.ReadWrite);
            StreamWriter sw = new StreamWriter(file);
            sw.WriteLine("true");
            sw.Close();
            file.Close();
            simpleSound.Play();
            simpleSound.PlayLooping();
            isSoundActive = true;
        }

        private void rdi_off_Click(object sender, EventArgs e)
        {
            FileStream file = new FileStream("sound.txt", FileMode.OpenOrCreate, FileAccess.ReadWrite);
            StreamWriter sw = new StreamWriter(file);
            sw.WriteLine("false");
            sw.Close();
            file.Close();
            simpleSound.Stop();
            isSoundActive = false;
        }
    }
}
