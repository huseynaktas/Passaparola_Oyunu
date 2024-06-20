﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Passaparola_Oyunu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int soruno = 0, dogru = 0, yanlis = 0;

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                switch (soruno)
                {
                    case 1:
                        if (textBox1.Text == "akdeniz")
                        {
                            btnA.BackColor = Color.Green;
                            dogru++;
                            lblDogru.Text = dogru.ToString();
                        }
                        else
                        {
                            btnA.BackColor = Color.Red;
                            yanlis++;
                            lblYanlis.Text = yanlis.ToString();
                        }
                        break;

                    case 2:
                        if (textBox1.Text == "bursa")
                        {
                            btnB.BackColor = Color.Green;
                            dogru++;
                            lblDogru.Text = dogru.ToString();
                        }
                        else
                        {
                            btnB.BackColor = Color.Red;
                            yanlis++;
                            lblYanlis.Text = yanlis.ToString();
                        }
                        break;

                    case 3:
                        if (textBox1.Text == "cuma")
                        {
                            btnC.BackColor = Color.Green;
                            dogru++;
                            lblDogru.Text = dogru.ToString();
                        }
                        else
                        {
                            btnC.BackColor = Color.Red;
                            yanlis++;
                            lblYanlis.Text = yanlis.ToString();
                        }
                        break;

                    case 4:
                        if (textBox1.Text == "diyarbakır")
                        {
                            btnD.BackColor = Color.Green;
                            dogru++;
                            lblDogru.Text = dogru.ToString();
                        }
                        else
                        {
                            btnD.BackColor = Color.Red;
                            yanlis++;
                            lblYanlis.Text = yanlis.ToString();
                        }
                        break;

                    case 5:
                        if (textBox1.Text == "eski")
                        {
                            btnE.BackColor = Color.Green;
                            dogru++;
                            lblDogru.Text = dogru.ToString();
                        }
                        else
                        {
                            btnE.BackColor = Color.Red;
                            yanlis++;
                            lblYanlis.Text = yanlis.ToString();
                        }
                        break;

                    case 6:
                        if (textBox1.Text == "ferman")
                        {
                            btnF.BackColor = Color.Green;
                            dogru++;
                            lblDogru.Text = dogru.ToString();
                        }
                        else
                        {
                            btnF.BackColor = Color.Red;
                            yanlis++;
                            lblYanlis.Text = yanlis.ToString();
                        }
                        break;

                    case 7:
                        if (textBox1.Text == "güneş")
                        {
                            btnG.BackColor = Color.Green;
                            dogru++;
                            lblDogru.Text = dogru.ToString();
                        }
                        else
                        {
                            btnG.BackColor = Color.Red;
                            yanlis++;
                            lblYanlis.Text = yanlis.ToString();
                        }
                        break;

                    case 8:
                        if (textBox1.Text == "halı")
                        {
                            btnH.BackColor = Color.Green;
                            dogru++;
                            lblDogru.Text = dogru.ToString();
                        }
                        else
                        {
                            btnH.BackColor = Color.Red;
                            yanlis++;
                            lblYanlis.Text = yanlis.ToString();
                        }
                        break;

                    case 9:
                        if (textBox1.Text == "ısparta")
                        {
                            btnI.BackColor = Color.Green;
                            dogru++;
                            lblDogru.Text = dogru.ToString();
                        }
                        else
                        {
                            btnI.BackColor = Color.Red;
                            yanlis++;
                            lblYanlis.Text = yanlis.ToString();
                        }
                        break;

                    case 10:
                        if (textBox1.Text == "içel")
                        {
                            btnI2.BackColor = Color.Green;
                            dogru++;
                            lblDogru.Text = dogru.ToString();
                        }
                        else
                        {
                            btnI2.BackColor = Color.Red;
                            yanlis++;
                            lblYanlis.Text = yanlis.ToString();
                        }
                        break;

                    case 11:
                        if (textBox1.Text == "jandarma")
                        {
                            btnJ.BackColor = Color.Green;
                            dogru++;
                            lblDogru.Text = dogru.ToString();
                        }
                        else
                        {
                            btnJ.BackColor = Color.Red;
                            yanlis++;
                            lblYanlis.Text = yanlis.ToString();
                        }
                        break;

                    case 12:
                        if (textBox1.Text == "kayısı")
                        {
                            btnK.BackColor = Color.Green;
                            dogru++;
                            lblDogru.Text = dogru.ToString();
                        }
                        else
                        {
                            btnK.BackColor = Color.Red;
                            yanlis++;
                            lblYanlis.Text = yanlis.ToString();
                        }
                        break;

                    case 13:
                        if (textBox1.Text == "lale")
                        {
                            btnL.BackColor = Color.Green;
                            dogru++;
                            lblDogru.Text = dogru.ToString();
                        }
                        else
                        {
                            btnL.BackColor = Color.Red;
                            yanlis++;
                            lblYanlis.Text = yanlis.ToString();
                        }
                        break;

                    case 14:
                        if (textBox1.Text == "mart")
                        {
                            btnM.BackColor = Color.Green;
                            dogru++;
                            lblDogru.Text = dogru.ToString();
                        }
                        else
                        {
                            btnM.BackColor = Color.Red;
                            yanlis++;
                            lblYanlis.Text = yanlis.ToString();
                        }
                        break;

                    case 15:
                        if (textBox1.Text == "ney")
                        {
                            btnN.BackColor = Color.Green;
                            dogru++;
                            lblDogru.Text = dogru.ToString();
                        }
                        else
                        {
                            btnN.BackColor = Color.Red;
                            yanlis++;
                            lblYanlis.Text = yanlis.ToString();
                        }
                        break;

                    case 16:
                        if (textBox1.Text == "ozan")
                        {
                            btnO.BackColor = Color.Green;
                            dogru++;
                            lblDogru.Text = dogru.ToString();
                        }
                        else
                        {
                            btnO.BackColor = Color.Red;
                            yanlis++;
                            lblYanlis.Text = yanlis.ToString();
                        }
                        break;

                    case 17:
                        if (textBox1.Text == "pırasa")
                        {
                            btnP.BackColor = Color.Green;
                            dogru++;
                            lblDogru.Text = dogru.ToString();
                        }
                        else
                        {
                            btnP.BackColor = Color.Red;
                            yanlis++;
                            lblYanlis.Text = yanlis.ToString();
                        }
                        break;

                    case 18:
                        if (textBox1.Text == "ramazan")
                        {
                            btnR.BackColor = Color.Green;
                            dogru++;
                            lblDogru.Text = dogru.ToString();
                        }
                        else
                        {
                            btnR.BackColor = Color.Red;
                            yanlis++;
                            lblYanlis.Text = yanlis.ToString();
                        }
                        break;

                    case 19:
                        if (textBox1.Text == "snake")
                        {
                            btnS.BackColor = Color.Green;
                            dogru++;
                            lblDogru.Text = dogru.ToString();
                        }
                        else
                        {
                            btnS.BackColor = Color.Red;
                            yanlis++;
                            lblYanlis.Text = yanlis.ToString();
                        }
                        break;

                    case 20:
                        if (textBox1.Text == "tulumba")
                        {
                            btnT.BackColor = Color.Green;
                            dogru++;
                            lblDogru.Text = dogru.ToString();
                        }
                        else
                        {
                            btnT.BackColor = Color.Red;
                            yanlis++;
                            lblYanlis.Text = yanlis.ToString();
                        }
                        break;

                    case 21:
                        if (textBox1.Text == "umut")
                        {
                            btnU.BackColor = Color.Green;
                            dogru++;
                            lblDogru.Text = dogru.ToString();
                        }
                        else
                        {
                            btnU.BackColor = Color.Red;
                            yanlis++;
                            lblYanlis.Text = yanlis.ToString();
                        }
                        break;

                    case 22:
                        if (textBox1.Text == "van")
                        {
                            btnV.BackColor = Color.Green;
                            dogru++;
                            lblDogru.Text = dogru.ToString();
                        }
                        else
                        {
                            btnV.BackColor = Color.Red;
                            yanlis++;
                            lblYanlis.Text = yanlis.ToString();
                        }
                        break;

                    case 23:
                        if (textBox1.Text == "yanlış")
                        {
                            btnY.BackColor = Color.Green;
                            dogru++;
                            lblDogru.Text = dogru.ToString();
                        }
                        else
                        {
                            btnY.BackColor = Color.Red;
                            yanlis++;
                            lblYanlis.Text = yanlis.ToString();
                        }
                        break;

                    case 24:
                        if (textBox1.Text == "zeytin")
                        {
                            btnZ.BackColor = Color.Green;
                            dogru++;
                            lblDogru.Text = dogru.ToString();
                        }
                        else
                        {
                            btnZ.BackColor = Color.Red;
                            yanlis++;
                            lblYanlis.Text = yanlis.ToString();
                        }
                        break;
                }

            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            linkLabel1.Text = "Sonraki Soru";
            soruno++;
            this.Text = soruno.ToString();

            if (soruno == 1)
            {
                richTextBox1.Text = "Ülkemizin güney kısmındaki kıyı bölgesi?";
                btnA.BackColor = Color.Yellow;
            }
            if (soruno == 2)
            {
                richTextBox1.Text = "Yeşiliyle ünlü Marmara ilimiz?";
                btnB.BackColor = Color.Yellow;
            }
            if (soruno == 3)
            {
                richTextBox1.Text = "Müslümanların kutsal günü?";
                btnC.BackColor = Color.Yellow;
            }
            if (soruno == 4)
            {
                richTextBox1.Text = "Karpuzuyla ünlü ilimiz?";
                btnD.BackColor = Color.Yellow;
            }
            if (soruno == 5)
            {
                richTextBox1.Text = "Yeni kelimesinin zıt anlamlısı?";
                btnE.BackColor = Color.Yellow;
            }
            if (soruno == 6)
            {
                richTextBox1.Text = "Padişahın emirlerinin yazılı hali?";
                btnF.BackColor = Color.Yellow;
            }
            if (soruno == 7)
            {
                richTextBox1.Text = "Dünyanın sıcaklık kaynağı?";
                btnG.BackColor = Color.Yellow;
            }
            if (soruno == 8)
            {
                richTextBox1.Text = "Öğrencilerin kötü karne getirince bakıştığı nesne?";
                btnH.BackColor = Color.Yellow;
            }
            if (soruno == 9)
            {
                richTextBox1.Text = "Gülüyle ünlü ilimiz?";
                btnI.BackColor = Color.Yellow;
            }
            if (soruno == 10)
            {
                richTextBox1.Text = "Mersin ilinin diğer ismi?";
                btnI2.BackColor = Color.Yellow;
            }
            if (soruno == 11)
            {
                richTextBox1.Text = "Askeri bir topluluk?";
                btnJ.BackColor = Color.Yellow;
            }
            if (soruno == 12)
            {
                richTextBox1.Text = "Malataya ilinin meşhur meyvesi?";
                btnK.BackColor = Color.Yellow;
            }
            if (soruno == 13)
            {
                richTextBox1.Text = "her yıl bahar aylarında düzenlenen meşhur çiçek festivali?";
                btnL.BackColor = Color.Yellow;
            }
            if (soruno == 14)
            {
                richTextBox1.Text = "Yılın üçüncü ayı?";
                btnM.BackColor = Color.Yellow;
            }
            if (soruno == 15)
            {
                richTextBox1.Text = "Üflemeli bir müzk aleti?";
                btnN.BackColor = Color.Yellow;
            }
            if (soruno == 16)
            {
                richTextBox1.Text = "Halk şairi?";
                btnO.BackColor = Color.Yellow;
            }
            if (soruno == 17)
            {
                richTextBox1.Text = "Çocukların pek sevmediği pirinç havuç gibi sebzeler ile yapılan yemek?";
                btnP.BackColor = Color.Yellow;
            }
            if (soruno == 18)
            {
                richTextBox1.Text = "11 ayın sultanı?";
                btnR.BackColor = Color.Yellow;
            }
            if (soruno == 19)
            {
                richTextBox1.Text = "İngilizcede yılan?";
                btnS.BackColor = Color.Yellow;
            }
            if (soruno == 20)
            {
                richTextBox1.Text = "Bir tatlı çeşidi?";
                btnT.BackColor = Color.Yellow;
            }
            if (soruno == 21)
            {
                richTextBox1.Text = "Ümit kelimesinin eş anlamlısı?";
                btnU.BackColor = Color.Yellow;
            }
            if (soruno == 22)
            {
                richTextBox1.Text = "Doğunun incisi olan şehrimiz?";
                btnV.BackColor = Color.Yellow;
            }
            if (soruno == 23)
            {
                richTextBox1.Text = "Doğru olmayan şey?";
                btnY.BackColor = Color.Yellow;
            }
            if (soruno == 24)
            {
                richTextBox1.Text = "Kahvaltıda yenilen bir yiyecek?";
                btnZ.BackColor = Color.Yellow;
            }
        }
    }
}
