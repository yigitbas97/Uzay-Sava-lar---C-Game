using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GorselProgramlama_UzaySavaslari
{
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }

        int can = 3;
        int dusmancan = 20;
        Boolean fuze_atildimi = false;
        Boolean dusman_fuze_atildimi = false;

        private void Form7_Load(object sender, EventArgs e)
        {
            progressBar1.Value = 100;
            oyun();
            pictureBox4.Visible = false;
            pictureBox5.Visible = false;
            pictureBox6.Visible = false;
            axWindowsMediaPlayer1.Visible = false;
            axWindowsMediaPlayer2.Visible = false;
            axWindowsMediaPlayer3.Visible = false;
            axWindowsMediaPlayer1.URL = "C:\\Users\\Yigit\\Desktop\\Görsel Programlama\\GorselProgramlama-UzaySavaslari\\GorselProgramlama-UzaySavaslari\\müzik.mp3";
        }

        public void oyun()
        {
            pictureBox2.Visible = false;
            GemiSınır.Start();
            fuze.Start();
            dusmangemisol.Start();
            dusmangemisolsınır.Start();
            dusmangemisagsınır.Start();
            oyunbittimi.Start();
            dusmanfuzekonumlandır.Start();
            dusmanfuze.Start();
            dusmangemiasagi.Start();
        }

        private void Form7_KeyDown(object sender, KeyEventArgs e)
        {
            int gemi_x = pictureBox1.Location.X;
            int gemi_y = pictureBox1.Location.Y;
            int fuze_x = pictureBox2.Location.X;
            int fuze_y = pictureBox2.Location.Y;

            if (e.KeyCode == Keys.Right)
            {
                gemi_x += 15;
                pictureBox1.Location = new Point(gemi_x, gemi_y);
            }
            if (e.KeyCode == Keys.Left)
            {
                gemi_x -= 15;
                pictureBox1.Location = new Point(gemi_x, gemi_y);
            }
            if (e.KeyCode == Keys.Up)
            {
                gemi_y -= 15;
                pictureBox1.Location = new Point(gemi_x, gemi_y);
            }
            if (e.KeyCode == Keys.Down)
            {
                gemi_y += 15;
                pictureBox1.Location = new Point(gemi_x, gemi_y);
            }
            if (e.KeyCode == Keys.Space)
            {
                pictureBox2.Visible = true;
                fuze_x = gemi_x + 28;
                fuze_y = gemi_y - 30;
                pictureBox2.Location = new Point(fuze_x, fuze_y);
                fuze_atildimi = true;
                axWindowsMediaPlayer2.URL = "C:\\Users\\Yigit\\Desktop\\c#\\Uzay Savaşları\\oyun_sesi.mp3";
            }
        }

        private void GemiSınır_Tick(object sender, EventArgs e)
        {
            if (pictureBox1.Top <= 495)
            {
                pictureBox1.Location = new Point(pictureBox1.Location.X, 505);
            }
            if (pictureBox1.Bottom > 695)
            {
                pictureBox1.Location = new Point(pictureBox1.Location.X, 630);
            }
            if (pictureBox1.Right >= 1300)
            {
                pictureBox1.Location = new Point(1210, pictureBox1.Location.Y);
            }
            if (pictureBox1.Left <= 12)
            {
                pictureBox1.Location = new Point(42, pictureBox1.Location.Y);
            }

            label2.Text = can.ToString();
            progressBar1.Value = Convert.ToInt32((dusmancan * 100) / 20);
            label4.Text = "% "+progressBar1.Value.ToString();
        }

        private void fuze_Tick(object sender, EventArgs e)
        {
            if (fuze_atildimi)
            {
                //fuze atıldı ve ust sınırdan asagıda ise ilerlemeye devam eder
                if (pictureBox2.Top > 90)
                {
                    if (pictureBox3.Bottom >= pictureBox2.Top && pictureBox3.Left <= pictureBox2.Left && pictureBox3.Right >= pictureBox2.Right)
                    {
                        dusmancan--;
                        if (dusmancan == 0)
                        {
                            pictureBox3.Visible = false;
                            pictureBox3.Left = 600;
                            pictureBox2.Visible = false;
                            
                        }
                        fuze_atildimi = false;
                        pictureBox2.Visible = false;
                    }

                    pictureBox2.Location = new Point(pictureBox2.Location.X, pictureBox2.Location.Y - 35);

                    //füze hicbir hedefe isabet etmemisse ve sınıra ulasmıssa baslangıc konumuna doner ve gozukmez
                    if (pictureBox2.Top <= 90)
                    {
                        pictureBox2.Visible = false;
                        pictureBox2.Location = new Point(pictureBox1.Location.X + 28, pictureBox1.Location.Y - 30);
                        fuze_atildimi = false;
                        
                    }
                }
            }
        }

        private void dusmangemisol_Tick(object sender, EventArgs e)
        {
            pictureBox3.Location = new Point(pictureBox3.Location.X - 15, pictureBox3.Location.Y);
        }

        private void dusmangemisag_Tick(object sender, EventArgs e)
        {
            pictureBox3.Location = new Point(pictureBox3.Location.X + 15, pictureBox3.Location.Y);
        }

        private void dusmangemisolsınır_Tick(object sender, EventArgs e)
        {
            if (pictureBox3.Left <= 15)
            {
                dusmangemisol.Stop();
                dusmangemisag.Start();
            }
        }

        private void dusmangemisagsınır_Tick(object sender, EventArgs e)
        {
            if (pictureBox3.Right >= 1330)
            {
                dusmangemisag.Stop();
                dusmangemisol.Start();
            }
        }

        private void oyunbittimi_Tick_1(object sender, EventArgs e)
        {
            oyun_sonu();
        }

        public void oyun_sonu()
        {
            if (can > 0 && pictureBox3.Visible == false)
            {
                GemiSınır.Stop();
                fuze.Stop();
                dusmangemisol.Stop();
                dusmangemisolsınır.Stop();
                dusmangemisagsınır.Stop();
                oyunbittimi.Stop();
                dusmanfuzekonumlandır.Stop();
                dusmanfuze.Stop();
                dusmangemiasagi.Stop();
                Form12 final = new Form12();
                final.Show();
                this.Close();
            }
            else if (can == 0)
            {
                GemiSınır.Stop();
                fuze.Stop();
                dusmangemisol.Stop();
                dusmangemisolsınır.Stop();
                dusmangemisagsınır.Stop();
                oyunbittimi.Stop();
                dusmanfuzekonumlandır.Stop();
                dusmanfuze.Stop();
                dusmangemiasagi.Stop();
                
                MessageBox.Show("Kaybettin");
                Form11 bolum4bilgi = new Form11();
                bolum4bilgi.Show();
                this.Close();
            }
        }

        private void dusmanfuzekonumlandır_Tick(object sender, EventArgs e)
        {
            pictureBox4.Location = new Point(pictureBox3.Location.X+30, pictureBox3.Location.Y + 190);
            pictureBox5.Location = new Point(pictureBox3.Location.X+180, pictureBox3.Location.Y + 190);
            pictureBox6.Location = new Point(pictureBox3.Location.X+330, pictureBox3.Location.Y + 190);
            dusman_fuze_atildimi = true;
            pictureBox4.Visible = true;
            pictureBox5.Visible = true;
            pictureBox6.Visible = true;
        }

        private void dusmanfuze_Tick(object sender, EventArgs e)
        {
            if (dusman_fuze_atildimi)
            {
                if (pictureBox4.Bottom < 720 && pictureBox5.Bottom < 720 && pictureBox6.Bottom < 720)
                {
                    if ((pictureBox1.Top < pictureBox4.Bottom && pictureBox1.Left <= pictureBox4.Left && pictureBox1.Right >= pictureBox4.Right) || (pictureBox1.Top < pictureBox5.Bottom && pictureBox1.Left <= pictureBox5.Left && pictureBox1.Right >= pictureBox5.Right) || (pictureBox1.Top < pictureBox6.Bottom && pictureBox1.Left <= pictureBox6.Left && pictureBox1.Right >= pictureBox6.Right))
                    {
                        can--;
                        axWindowsMediaPlayer3.URL = "C:\\Users\\Yigit\\Desktop\\Görsel Programlama\\GorselProgramlama-UzaySavaslari\\GorselProgramlama-UzaySavaslari\\vurulmamusic.mp3 ";
                        pictureBox4.Visible = false;
                        pictureBox5.Visible = false;
                        pictureBox6.Visible = false;
                        pictureBox4.Location = new Point(pictureBox3.Location.X + 50, pictureBox3.Location.Y + 190);
                        pictureBox5.Location = new Point(pictureBox3.Location.X + 180, pictureBox3.Location.Y + 190);
                        pictureBox6.Location = new Point(pictureBox3.Location.X + 310, pictureBox3.Location.Y + 190);

                        if (can == 0)
                        {
                            pictureBox1.Visible = false;
                        }
                        dusman_fuze_atildimi = false;
                    }

                    pictureBox4.Location = new Point(pictureBox4.Location.X, pictureBox4.Location.Y + 50);
                    pictureBox5.Location = new Point(pictureBox5.Location.X, pictureBox5.Location.Y + 50);
                    pictureBox6.Location = new Point(pictureBox6.Location.X, pictureBox6.Location.Y + 50);
                }

                //füze hicbir hedefe isabet etmemisse ve sınıra ulasmıssa baslangıc konumuna doner ve gozukmez
                if (pictureBox4.Top >= 720)
                {
                    dusman_fuze_atildimi = false;
                    pictureBox4.Visible = false;
                    pictureBox5.Visible = false;
                    pictureBox6.Visible = false;
                }
            }
        }

        private void dusmangemiasagi_Tick(object sender, EventArgs e)
        {
            if (pictureBox3.Bottom >= 350)
            {
                dusmangemiasagi.Stop();
                dusmangemiyukari.Start();
            }
            pictureBox3.Location = new Point(pictureBox3.Location.X , pictureBox3.Location.Y+5);
        }

        private void dusmangemiyukari_Tick(object sender, EventArgs e)
        {
            if (pictureBox3.Bottom <= 180)
            {
                dusmangemiyukari.Stop();
                dusmangemiasagi.Start();
            }
            pictureBox3.Location = new Point(pictureBox3.Location.X, pictureBox3.Location.Y - 5);
        }
    }
}
       
