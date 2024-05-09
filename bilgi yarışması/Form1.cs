namespace bilgi_yarışması
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int soruno = 0;
        int doğru;
        int yanlış;
        int süre = 60;
        private void button5_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            button5.Text = "SONRAKİ SORU";
            soruno++;
            label2.Text = soruno.ToString();

            button1.Enabled = true;
            button2.Enabled = true;
            button3.Enabled = true;
            button4.Enabled = true;

            if (soruno == 1)
            {
                richTextBox1.Text = "1 BYTE KAÇ BİT'DİR?";
                button1.Text = "6 BİT";
                button2.Text = "4 BİT";
                button3.Text = "8 BİT";
                button4.Text = "2 BİT";
                label4.Text = "8 BİT";
            }
            if (soruno == 2)
            {
                richTextBox1.Text = "TÜRKİYE KAÇ COĞRAFİ BÖLGEDEN OLUŞUR?";
                button1.Text = "3 BÖLGE";
                button2.Text = "4 BÖLGE";
                button3.Text = "6 BÖLGE";
                button4.Text = "7 BÖLGE";
                label4.Text = "7 BÖLGE";
            }
            if (soruno == 3)
            {
                richTextBox1.Text = "GALATASARAYIN EFSANE KALECİSİ KİMDİR?";
                button1.Text = "VOLKAN DEMİREL";
                button2.Text = "ONANA";
                button3.Text = "FERNANDO MUSLERA";
                button4.Text = "MERT GÜNOK";
                label4.Text = "FERNANDO MUSLERA";
            }
            if (soruno == 4)
            {
                richTextBox1.Text = "BUGÜN SALI İSE BUNDAN 778 GÜN SONRA HANGİ GÜNDÜR?";
                button1.Text = "PAZAR";
                button2.Text = "ÇARŞAMBA";
                button3.Text = "CUMA";
                button4.Text = "SALI";
                label4.Text = "ÇARŞAMBA";
            }
            if(soruno == 5)
            {
                richTextBox1.Text = "TÜRKİYENİN 1. CUMHURBAŞKANI KİMDİR?";
                button1.Text = "İSMET İNÖNÜ";
                button2.Text = "MUSTAFA KEMAL ATATÜRK";
                button3.Text = "MAURO İCARDİ";
                button4.Text = "KERİMCAN DURMAZ";
                label4.Text = "MUSTAFA KEMAL ATATÜRK";

            }
            if (soruno == 6)
            {
                richTextBox1.Text = "6+(8/2)*2-8*1 İŞLEMİNİN SONUCU KAÇTIR?";
                button1.Text = "6";
                button2.Text = "8";
                button3.Text = "1";
                button4.Text = "9";
                label4.Text = "6";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;

            label3.Text = button1.Text;
            if (label3.Text == label4.Text)
            {
                label5.Text = "DOĞRU";
                doğru++;
                label7.Text = doğru.ToString();
            }
            else
            {
                label5.Text = "YANLIŞ!!";
                yanlış++;
                label9.Text = yanlış.ToString();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;

            label3.Text = button2.Text;
            if (label3.Text == label4.Text)
            {
                label5.Text = "DOĞRU";
                doğru++;
                label7.Text = doğru.ToString();
            }
            else
            {
                label5.Text = "YANLIŞ!!";
                yanlış++;
                label9.Text = yanlış.ToString();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;

            label3.Text = button3.Text;
            if (label3.Text == label4.Text)
            {
                label5.Text = "DOĞRU";
                doğru++;
                label7.Text = doğru.ToString();
            }
            else
            {
                label5.Text = "YANLIŞ!!";
                yanlış++;
                label9.Text = yanlış.ToString();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;

            label3.Text = button4.Text;
            if (label3.Text == label4.Text)
            {
                label5.Text = "DOĞRU";
                doğru++;
                label7.Text = doğru.ToString();
            }
            else
            {
                label5.Text = "YANLIŞ!!";
                yanlış++;
                label9.Text = yanlış.ToString();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            süre = Convert.ToInt32(label11.Text);
            süre = süre - 1;
            label11.Text = süre.ToString();
            if (süre == 0)
            {
                timer1.Enabled = false;

                label12.Text = "SÜRENİZ BİTTİ!!";

                button1.Enabled = false;
                button2.Enabled = false;
                button3.Enabled = false;
                button4.Enabled = false;


            }
        }
    }
}