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
    public partial class Level_Two : Form
    {
        SoundPlayer simpleSound;
        int counter = 120;
        public Level_Two()
        {
            simpleSound = new SoundPlayer(Directory.GetCurrentDirectory().Replace("\\bin\\Debug", "\\Sounds\\Level3.wav"));
            InitializeComponent();
            lbl_time.Text = counter.ToString() + " sec";
        }
        public Level_Two(bool val)
            : this()
        {
            if (val == false)
            {
                simpleSound.Stop();
            }
            else
            {
                simpleSound.Play();
                simpleSound.PlayLooping();
            }
        }

        private void Level_Three_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Right:
                    if (picFrame.Left + 5 < (this.Width - picFrame.Width))
                        picFrame.Left += 5;
                    break;
                case Keys.Left:
                    if (picFrame.Left + 5 > 0)
                        picFrame.Left -= 5;
                    break;
                case Keys.Up:
                    if (picFrame.Top + 5 > 0)
                        picFrame.Top -= 5;
                    break;

                case Keys.Down:
                    if (picFrame.Top + 5 < (this.Height - picFrame.Height))
                        picFrame.Top += 5;
                    break;
            }
            Controls.Remove(pictureBox34);
            foreach (Control c2 in Controls)
            {
                var returnPic = Controls.Find("pictureBox35", true);
                if (!c2.Equals(picFrame) && c2 is PictureBox
                && picFrame.Bounds.IntersectsWith(returnPic[0].Bounds))
                {
                    Controls.Remove(pictureBox2);
                    Controls.Remove(pictureBox36);
                    Controls.Remove(pictureBox1);
                    simpleSound.Stop();
                    DialogResult res = MessageBox.Show(" You are win !!! \n You have finished your mission ", "Congratulation", MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
                    if (res == DialogResult.OK)
                    {
                        Start st = new Start();
                        st.Show();
                        this.Hide();
                        return;
                    }
                    else
                    {
                        this.Close();
                    }
                }
                if (!c2.Equals(picFrame) && c2 is PictureBox /* if you want it to be just buttons */
                    && picFrame.Bounds.IntersectsWith(c2.Bounds))
                {
                    timer1.Stop();
                    DialogResult result = MessageBox.Show(" You had an accident....\n Game Over \n are you want to play again", "Alert", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                    if (result == DialogResult.Yes)
                    {

                        restoreAll(this);
                        return;
                    }
                    else
                    {
                        this.Close();
                    }
                }

            }
        }
        void restoreAll(Level_Two f)
        {
            this.picFrame.Location = new Point(1020, 40);
            Controls.Add(pictureBox34);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox36);
            Controls.Add(pictureBox1);
            lbl_time.ForeColor = Color.White;
            simpleSound.Play();
            simpleSound.PlayLooping();
            counter = 120;
            timer1.Start();
            timer1_Tick(null, null);
            FileStream file = new FileStream("sound.txt", FileMode.OpenOrCreate, FileAccess.ReadWrite);
            StreamReader sw = new StreamReader(file);
            var sound = sw.ReadLine();
            if (sound == "false")
            {
                simpleSound.Stop();
                sw.Close();
                file.Close();
            }
            else
            {
                simpleSound.Play();
                simpleSound.PlayLooping();
                sw.Close();
                file.Close();
            }
        }

        private void Level_Three_FormClosed(object sender, FormClosedEventArgs e)
        {
            simpleSound.Stop();
            Application.Exit();
        }


        private void label2_Click(object sender, EventArgs e)
        {
            Start s = new Start();
            s.Show();
            this.Hide();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            --counter;
            lbl_time.Text = counter.ToString() + " sec";
            if (counter > 0 && counter < 20)
            {
                lbl_time.ForeColor = Color.Red; ;
            }
            if (counter == 0)
            {
                timer1.Stop();
                DialogResult result = MessageBox.Show(" Time is over you have lost....\n Game Over \n are you want to play again", "Alert", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {

                    restoreAll(this);
                    return;
                }
                else
                {
                    this.Close();
                }
            }
        }
    }
}
