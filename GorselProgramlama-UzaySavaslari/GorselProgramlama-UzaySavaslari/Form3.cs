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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        int fuzesayisi = 20;
        Boolean fuze_atildimi = false;
        private void Form3_Load(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.Visible = false;
            axWindowsMediaPlayer2.Visible = false;
            oyun();
            axWindowsMediaPlayer1.URL = "C:\\Users\\Yigit\\Desktop\\Görsel Programlama\\GorselProgramlama-UzaySavaslari\\GorselProgramlama-UzaySavaslari\\müzik.mp3";
        }

        public void oyun()
        {
            pictureBox2.Visible = false;
            fuzesayi.Start();
            GemiSınır.Start();
            fuze.Start();
            ufosagsınır.Start();
            ufosolsınır.Start();
            ufosol.Start();
        }

        private void Form3_KeyDown(object sender, KeyEventArgs e)
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
                fuzesayisi -= 1;
            }
            if (e.KeyCode == Keys.X)
            {
                Form4 fr4 = new Form4();
                this.Close();
                fr4.Show();
            }
        }

        //Geminin hareket sınırlarını kontrol eder
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
                    }
                    if (pictureBox4.Bottom >= pictureBox2.Top && pictureBox4.Left <= pictureBox2.Left && pictureBox4.Right >= pictureBox2.Right)
                    {
                        pictureBox4.Visible = false;
                        pictureBox4.Left = 600;
                        pictureBox2.Visible = false;
                    }
                    if (pictureBox5.Bottom >= pictureBox2.Top && pictureBox5.Left <= pictureBox2.Left && pictureBox5.Right >= pictureBox2.Right)
                    {
                        pictureBox5.Visible = false;
                        pictureBox5.Left = 600;
                        pictureBox2.Visible = false;
                    }
                    if (pictureBox6.Bottom >= pictureBox2.Top && pictureBox6.Left <= pictureBox2.Left && pictureBox6.Right >= pictureBox2.Right)
                    {
                        pictureBox6.Visible = false;
                        pictureBox6.Left = 600;
                        pictureBox2.Visible = false;
                    }
                    if (pictureBox7.Bottom >= pictureBox2.Top && pictureBox7.Left <= pictureBox2.Left && pictureBox7.Right >= pictureBox2.Right)
                    {
                        pictureBox7.Visible = false;
                        pictureBox7.Left = 600;
                        pictureBox2.Visible = false;
                    }
                    if (pictureBox8.Bottom >= pictureBox2.Top && pictureBox8.Left <= pictureBox2.Left && pictureBox8.Right >= pictureBox2.Right)
                    {
                        pictureBox8.Visible = false;
                        pictureBox8.Left = 600;
                        pictureBox2.Visible = false;
                    }
                    if (pictureBox9.Bottom >= pictureBox2.Top && pictureBox9.Left <= pictureBox2.Left && pictureBox9.Right >= pictureBox2.Right)
                    {
                        pictureBox9.Visible = false;
                        pictureBox9.Left = 600;
                        pictureBox2.Visible = false;
                    }
                    if (pictureBox10.Bottom >= pictureBox2.Top && pictureBox10.Left <= pictureBox2.Left && pictureBox10.Right >= pictureBox2.Right)
                    {
                        pictureBox10.Visible = false;
                        pictureBox10.Left = 600;
                        pictureBox2.Visible = false;
                    }
                    if (pictureBox11.Bottom >= pictureBox2.Top && pictureBox11.Left <= pictureBox2.Left && pictureBox11.Right >= pictureBox2.Right)
                    {
                        pictureBox11.Visible = false;
                        pictureBox11.Left = 600;
                        pictureBox2.Visible = false;
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

        private void ufosagsınır_Tick_1(object sender, EventArgs e)
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


        //oyunun sonucunu kontrol eder
        public void oyun_sonu()
        {
            if (fuzesayisi >= 0 && pictureBox3.Visible == false && pictureBox4.Visible == false && pictureBox5.Visible == false && pictureBox6.Visible == false && pictureBox7.Visible == false && pictureBox8.Visible == false && pictureBox9.Visible == false && pictureBox10.Visible == false && pictureBox11.Visible == false)
            {
                fuzesayi.Stop();
                GemiSınır.Stop();
                fuze.Stop();
                ufosagsınır.Stop();
                ufosolsınır.Stop();
                ufosol.Stop();
                ufosag.Stop();
                Form10 bolum3bilgi = new Form10();
                bolum3bilgi.Show();
                this.Close();
            }
            else if (fuzesayisi<0)
            {
                fuzesayi.Stop();
                GemiSınır.Stop();
                fuze.Stop();
                ufosagsınır.Stop();
                ufosolsınır.Stop();
                ufosol.Stop();
                ufosag.Stop();
                MessageBox.Show("Oyunu Kaybettin");
                Form9 bolum2bilgi = new Form9();
                bolum2bilgi.Show();
                this.Close();
            }
        }

        private void fuzesayi_Tick(object sender, EventArgs e)
        {
            label2.Text = fuzesayisi.ToString();
            oyun_sonu();
        }
    }
}
