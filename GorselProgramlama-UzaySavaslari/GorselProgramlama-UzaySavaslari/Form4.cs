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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }
        bool[] ufovuruldumu = new bool[9];
        Random rastgele = new Random();
        int sayac = 1;
        int can = 3;
        Boolean fuze_atildimi = false;
        Boolean dusman_fuze_atildimi = false;

        private void Form4_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < ufovuruldumu.Length; i++)
            {
                ufovuruldumu[i] = false;
            }
            axWindowsMediaPlayer1.Visible = false;
            axWindowsMediaPlayer2.Visible = false;
            axWindowsMediaPlayer3.Visible = false;
            oyun();
            axWindowsMediaPlayer1.URL = "C:\\Users\\Yigit\\Desktop\\Görsel Programlama\\GorselProgramlama-UzaySavaslari\\GorselProgramlama-UzaySavaslari\\müzik.mp3";
        }

        public void oyun()
        {
            pictureBox12.Visible = false;
            pictureBox2.Visible = false;
            oyunbittimi.Start();
            GemiSınır.Start();
            fuze.Start();
            ufosagsınır.Start();
            ufosolsınır.Start();
            ufosol.Start();
            dusmanfuzesec.Start();
            dusmanfuze.Start();
            ufoasagi.Start();
        }

        private void Form4_KeyDown(object sender, KeyEventArgs e)
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
        }

        private void fuze_Tick(object sender, EventArgs e)
        {
            if (fuze_atildimi)
            {
                //fuze atıldı ve ust sınırdan asagıda ise ilerlemeye devam eder
                if (pictureBox2.Top > 85)
                {
                    if (pictureBox3.Bottom >= pictureBox2.Top && pictureBox3.Left <= pictureBox2.Left && pictureBox3.Right >= pictureBox2.Right)
                    {
                        pictureBox3.Visible = false;
                        pictureBox3.Left = 600;
                        pictureBox2.Visible = false;
                        ufovuruldumu[0] = true;
                    }
                    if (pictureBox4.Bottom >= pictureBox2.Top && pictureBox4.Left <= pictureBox2.Left && pictureBox4.Right >= pictureBox2.Right)
                    {
                        pictureBox4.Visible = false;
                        pictureBox4.Left = 600;
                        pictureBox2.Visible = false;
                        ufovuruldumu[1] = true;
                    }
                    if (pictureBox5.Bottom >= pictureBox2.Top && pictureBox5.Left <= pictureBox2.Left && pictureBox5.Right >= pictureBox2.Right)
                    {
                        pictureBox5.Visible = false;
                        pictureBox5.Left = 600;
                        pictureBox2.Visible = false;
                        ufovuruldumu[2] = true;
                    }
                    if (pictureBox6.Bottom >= pictureBox2.Top && pictureBox6.Left <= pictureBox2.Left && pictureBox6.Right >= pictureBox2.Right)
                    {
                        pictureBox6.Visible = false;
                        pictureBox6.Left = 600;
                        pictureBox2.Visible = false;
                        ufovuruldumu[3] = true;
                    }
                    if (pictureBox7.Bottom >= pictureBox2.Top && pictureBox7.Left <= pictureBox2.Left && pictureBox7.Right >= pictureBox2.Right)
                    {
                        pictureBox7.Visible = false;
                        pictureBox7.Left = 600;
                        pictureBox2.Visible = false;
                        ufovuruldumu[4] = true;
                    }
                    if (pictureBox8.Bottom >= pictureBox2.Top && pictureBox8.Left <= pictureBox2.Left && pictureBox8.Right >= pictureBox2.Right)
                    {
                        pictureBox8.Visible = false;
                        pictureBox8.Left = 600;
                        pictureBox2.Visible = false;
                        ufovuruldumu[5] = true;
                    }
                    if (pictureBox9.Bottom >= pictureBox2.Top && pictureBox9.Left <= pictureBox2.Left && pictureBox9.Right >= pictureBox2.Right)
                    {
                        pictureBox9.Visible = false;
                        pictureBox9.Left = 600;
                        pictureBox2.Visible = false;
                        ufovuruldumu[6] = true;
                    }
                    if (pictureBox10.Bottom >= pictureBox2.Top && pictureBox10.Left <= pictureBox2.Left && pictureBox10.Right >= pictureBox2.Right)
                    {
                        pictureBox10.Visible = false;
                        pictureBox10.Left = 600;
                        pictureBox2.Visible = false;
                        ufovuruldumu[7] = true;
                    }
                    if (pictureBox11.Bottom >= pictureBox2.Top && pictureBox11.Left <= pictureBox2.Left && pictureBox11.Right >= pictureBox2.Right)
                    {
                        pictureBox11.Visible = false;
                        pictureBox11.Left = 600;
                        pictureBox2.Visible = false;
                        ufovuruldumu[8] = true;
                    }
                    pictureBox2.Location = new Point(pictureBox2.Location.X, pictureBox2.Location.Y - 35);

                    //füze hicbir hedefe isabet etmemisse ve sınıra ulasmıssa baslangıc konumuna doner ve gozukmez
                    if (pictureBox2.Top <= 85)
                    {
                        pictureBox2.Location = new Point(pictureBox1.Location.X + 28, pictureBox1.Location.Y - 30);
                        fuze_atildimi = false;
                        pictureBox2.Visible = false;
                    }
                }
            }
        }

        private void ufosol_Tick(object sender, EventArgs e)
        {
            pictureBox3.Location = new Point(pictureBox3.Location.X - 15, pictureBox3.Location.Y);
            pictureBox4.Location = new Point(pictureBox4.Location.X - 15, pictureBox4.Location.Y);
            pictureBox5.Location = new Point(pictureBox5.Location.X - 15, pictureBox5.Location.Y);
            pictureBox6.Location = new Point(pictureBox6.Location.X - 15, pictureBox6.Location.Y);
            pictureBox7.Location = new Point(pictureBox7.Location.X - 15, pictureBox7.Location.Y);
            pictureBox8.Location = new Point(pictureBox8.Location.X - 15, pictureBox8.Location.Y);
            pictureBox9.Location = new Point(pictureBox9.Location.X - 15, pictureBox9.Location.Y);
            pictureBox10.Location = new Point(pictureBox10.Location.X - 15, pictureBox10.Location.Y);
            pictureBox11.Location = new Point(pictureBox11.Location.X - 15, pictureBox11.Location.Y);
        }

        private void ufosag_Tick(object sender, EventArgs e)
        {
            pictureBox3.Location = new Point(pictureBox3.Location.X + 15, pictureBox3.Location.Y);
            pictureBox4.Location = new Point(pictureBox4.Location.X + 15, pictureBox4.Location.Y);
            pictureBox5.Location = new Point(pictureBox5.Location.X + 15, pictureBox5.Location.Y);
            pictureBox6.Location = new Point(pictureBox6.Location.X + 15, pictureBox6.Location.Y);
            pictureBox7.Location = new Point(pictureBox7.Location.X + 15, pictureBox7.Location.Y);
            pictureBox8.Location = new Point(pictureBox8.Location.X + 15, pictureBox8.Location.Y);
            pictureBox9.Location = new Point(pictureBox9.Location.X + 15, pictureBox9.Location.Y);
            pictureBox10.Location = new Point(pictureBox10.Location.X + 15, pictureBox10.Location.Y);
            pictureBox11.Location = new Point(pictureBox11.Location.X + 15, pictureBox11.Location.Y);
        }

        private void ufosolsınır_Tick(object sender, EventArgs e)
        {
            if (pictureBox3.Left <= 15)
            {
                ufosol.Stop();
                ufosag.Start();
            }

            else if (pictureBox4.Left <= 15)
            {
                ufosol.Stop();
                ufosag.Start();
            }

            else if (pictureBox5.Left <= 15)
            {
                ufosol.Stop();
                ufosag.Start();
            }

            else if (pictureBox6.Left <= 15)
            {
                ufosol.Stop();
                ufosag.Start();
            }

            else if (pictureBox7.Left <= 15)
            {
                ufosol.Stop();
                ufosag.Start();
            }

            else if (pictureBox8.Left <= 15)
            {
                ufosol.Stop();
                ufosag.Start();
            }

            else if (pictureBox9.Left <= 15)
            {
                ufosol.Stop();
                ufosag.Start();
            }
            else if (pictureBox10.Left <= 15)
            {
                ufosol.Stop();
                ufosag.Start();
            }
            else if (pictureBox11.Left <= 15)
            {
                ufosol.Stop();
                ufosag.Start();
            }
        }

        private void ufosagsınır_Tick(object sender, EventArgs e)
        {
            if (pictureBox11.Right >= 1330)
            {
                ufosag.Stop();
                ufosol.Start();
            }
            if (pictureBox10.Right >= 1330)
            {
                ufosag.Stop();
                ufosol.Start();
            }
            if (pictureBox9.Right >= 1330)
            {
                ufosag.Stop();
                ufosol.Start();
            }
            else if (pictureBox8.Right >= 1330)
            {
                ufosag.Stop();
                ufosol.Start();
            }
            else if (pictureBox7.Right >= 1330)
            {
                ufosag.Stop();
                ufosol.Start();
            }
            else if (pictureBox6.Right >= 1330)
            {
                ufosag.Stop();
                ufosol.Start();
            }
            else if (pictureBox5.Right >= 1330)
            {
                ufosag.Stop();
                ufosol.Start();
            }
            else if (pictureBox4.Right >= 1330)
            {
                ufosag.Stop();
                ufosol.Start();
            }
            else if (pictureBox3.Right >= 1330)
            {
                ufosag.Stop();
                ufosol.Start();
            }
        }

        public void oyun_sonu()
        {
            if (can>0 && pictureBox3.Visible == false && pictureBox4.Visible == false && pictureBox5.Visible == false && pictureBox6.Visible == false && pictureBox7.Visible == false && pictureBox8.Visible == false && pictureBox9.Visible == false && pictureBox10.Visible == false && pictureBox11.Visible == false)
            {
                oyunbittimi.Stop();
                GemiSınır.Stop();
                fuze.Stop();
                ufosagsınır.Stop();
                ufosolsınır.Stop();
                ufosol.Stop();
                ufosag.Stop();
                dusmanfuzesec.Stop();
                dusmanfuze.Stop();
                ufoasagi.Stop();
                ufoyukari.Stop();
                Form11 bolum4bilgi = new Form11();
                bolum4bilgi.Show();
                this.Close();
            }
            else if (can == 0 )
            {
                oyunbittimi.Stop();
                GemiSınır.Stop();
                fuze.Stop();
                ufosagsınır.Stop();
                ufosolsınır.Stop();
                ufosol.Stop();
                ufosag.Stop();
                dusmanfuzesec.Stop();
                dusmanfuze.Stop();
                ufoasagi.Stop();
                ufoyukari.Stop();
                MessageBox.Show("Kaybettin");
                Form10 bolum3 = new Form10();
                bolum3.Show();
                this.Close();
            }
        }

        private void oyunbittimi_Tick(object sender, EventArgs e)
        {
            oyun_sonu();
        }

        private void dusmanfuze_Tick(object sender, EventArgs e)
        {
            if (dusman_fuze_atildimi)
            {
                if (pictureBox12.Bottom < 720)
                {
                    if (pictureBox1.Top < pictureBox12.Bottom && pictureBox1.Left <= pictureBox12.Left && pictureBox1.Right >= pictureBox12.Right)
                    {
                        can--;
                        axWindowsMediaPlayer3.URL = "C:\\Users\\Yigit\\Desktop\\Görsel Programlama\\GorselProgramlama-UzaySavaslari\\GorselProgramlama-UzaySavaslari\\vurulmamusic.mp3 ";
                        pictureBox12.Visible = false;
                        pictureBox12.Location = new Point(pictureBox12.Location.X -600 , pictureBox12.Location.Y + 600);
                        if (can == 0)
                        {
                            pictureBox1.Visible = false;
                        }
                    }

                    pictureBox12.Location = new Point(pictureBox12.Location.X, pictureBox12.Location.Y + 75);
                }

                //füze hicbir hedefe isabet etmemisse ve sınıra ulasmıssa baslangıc konumuna doner ve gozukmez
                if (pictureBox12.Top >= 720)
                {
                    dusman_fuze_atildimi = false;
                    pictureBox12.Visible = false;
                }
            }
        }

        private void dusmanfuzesec_Tick(object sender, EventArgs e)
        {
            label2.Text = can.ToString();

            
                int dusmangemisi = rastgele.Next(3, 12);

                if (dusmangemisi == 3)
                {
                    if (ufovuruldumu[0] == true)
                    {
                        dusmangemisi = rastgele.Next(3, 12);
                    }
                    else
                    {
                        pictureBox12.Location = new Point(pictureBox3.Location.X, pictureBox3.Location.Y + 30);
                        dusman_fuze_atildimi = true;
                        pictureBox12.Visible = true;
                    }

                }
                else if (dusmangemisi == 4)
                {
                    if (ufovuruldumu[1] == true)
                    {
                        dusmangemisi = rastgele.Next(3, 12);
                    }
                    else
                    {
                        pictureBox12.Location = new Point(pictureBox4.Location.X, pictureBox4.Location.Y + 30);
                        dusman_fuze_atildimi = true;
                        pictureBox12.Visible = true;
                    }
                }
                else if (dusmangemisi == 5)
                {
                    if (ufovuruldumu[2] == true)
                    {
                        dusmangemisi = rastgele.Next(3, 12);
                    }
                    else
                    {
                        pictureBox12.Location = new Point(pictureBox5.Location.X, pictureBox5.Location.Y + 30);
                        dusman_fuze_atildimi = true;
                        pictureBox12.Visible = true;
                    }

                }
                else if (dusmangemisi == 6)
                {
                    if (ufovuruldumu[3] == true)
                    {
                        dusmangemisi = rastgele.Next(3, 12);
                    }
                    else
                    {
                        pictureBox12.Location = new Point(pictureBox6.Location.X, pictureBox6.Location.Y + 30);
                        dusman_fuze_atildimi = true;
                        pictureBox12.Visible = true;
                    }

                }
                else if (dusmangemisi == 7)
                {
                    if (ufovuruldumu[4] == true)
                    {
                        dusmangemisi = rastgele.Next(3, 12);
                    }
                    else
                    {
                        pictureBox12.Location = new Point(pictureBox7.Location.X, pictureBox7.Location.Y + 30);
                        dusman_fuze_atildimi = true;
                        pictureBox12.Visible = true;
                    }

                }
                else if (dusmangemisi == 8)
                {
                    if (ufovuruldumu[5] == true)
                    {
                        dusmangemisi = rastgele.Next(3, 12);
                    }
                    else
                    {
                        pictureBox12.Location = new Point(pictureBox8.Location.X, pictureBox8.Location.Y + 30);
                        dusman_fuze_atildimi = true;
                        pictureBox12.Visible = true;
                    }

                }
                else if (dusmangemisi == 9)
                {
                    if (ufovuruldumu[6] == true)
                    {
                        dusmangemisi = rastgele.Next(3, 12);
                    }
                    else
                    {
                        pictureBox12.Location = new Point(pictureBox9.Location.X, pictureBox9.Location.Y + 30);
                        dusman_fuze_atildimi = true;
                        pictureBox12.Visible = true;
                    }

                }
                else if (dusmangemisi == 10)
                {
                    if (ufovuruldumu[7] == true)
                    {
                        dusmangemisi = rastgele.Next(3, 12);
                    }
                    else
                    {
                        pictureBox12.Location = new Point(pictureBox10.Location.X, pictureBox10.Location.Y + 30);
                        dusman_fuze_atildimi = true;
                        pictureBox12.Visible = true;
                    }

                }
                else if (dusmangemisi == 11)
                {
                    if (ufovuruldumu[8] == true)
                    {
                        dusmangemisi = rastgele.Next(3, 12);
                    }
                    else
                    {
                        pictureBox12.Location = new Point(pictureBox11.Location.X, pictureBox11.Location.Y + 30);
                        dusman_fuze_atildimi = true;
                        pictureBox12.Visible = true;
                    }

                }
        }

        private void ufoasagi_Tick(object sender, EventArgs e)
        {
            if (pictureBox4.Bottom >= 320)
            {
               ufoasagi.Stop();
               ufoyukari.Start();
            }
            pictureBox3.Location = new Point(pictureBox3.Location.X, pictureBox3.Location.Y + 5);
            pictureBox4.Location = new Point(pictureBox4.Location.X, pictureBox4.Location.Y + 5);
            pictureBox5.Location = new Point(pictureBox5.Location.X, pictureBox5.Location.Y + 5);
            pictureBox6.Location = new Point(pictureBox6.Location.X, pictureBox6.Location.Y + 5);
            pictureBox7.Location = new Point(pictureBox7.Location.X, pictureBox7.Location.Y + 5);
            pictureBox8.Location = new Point(pictureBox8.Location.X, pictureBox8.Location.Y + 5);
            pictureBox9.Location = new Point(pictureBox9.Location.X, pictureBox9.Location.Y + 5);
            pictureBox10.Location = new Point(pictureBox10.Location.X, pictureBox10.Location.Y + 5);
            pictureBox11.Location = new Point(pictureBox11.Location.X, pictureBox11.Location.Y + 5);
        }

        private void ufoyukari_Tick(object sender, EventArgs e)
        {
            if (pictureBox3.Bottom <= 120)
            {
                ufoyukari.Stop();
                ufoasagi.Start();
            }
            pictureBox3.Location = new Point(pictureBox3.Location.X, pictureBox3.Location.Y - 5);
            pictureBox4.Location = new Point(pictureBox4.Location.X, pictureBox4.Location.Y - 5);
            pictureBox5.Location = new Point(pictureBox5.Location.X, pictureBox5.Location.Y - 5);
            pictureBox6.Location = new Point(pictureBox6.Location.X, pictureBox6.Location.Y - 5);
            pictureBox7.Location = new Point(pictureBox7.Location.X, pictureBox7.Location.Y - 5);
            pictureBox8.Location = new Point(pictureBox8.Location.X, pictureBox8.Location.Y - 5);
            pictureBox9.Location = new Point(pictureBox9.Location.X, pictureBox9.Location.Y - 5);
            pictureBox10.Location = new Point(pictureBox10.Location.X, pictureBox10.Location.Y - 5);
            pictureBox11.Location = new Point(pictureBox11.Location.X, pictureBox11.Location.Y - 5);
        }
    }
}
