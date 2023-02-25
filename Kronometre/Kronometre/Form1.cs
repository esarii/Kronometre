using System;

namespace Kronometre
{
    public partial class Form1 : Form
    {
        //public int sayac = 0;

        public int saat = 0;
        public int dakika = 0;
        public int saniye = 0;
        public int salise = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void start_Click(object sender, EventArgs e)
        {
            zamansayaci.Start();
        }

        private void stop_Click(object sender, EventArgs e)
        {
            zamansayaci.Stop();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            saniyetext.Text = "0";
            zamansayaci.Interval = 10; //miisaniyeyi 10'ar artýracak.
        }

        private void zamansayaci_Tick(object sender, EventArgs e)
        {
            //sayac++;
            salise++;

            if(salise == 60)
            {
                salise = 0;
                saniye++;
            }
            if(saniye == 60)
            {
                saniye = 0;
                dakika++;

            }
            if (dakika == 60)
            {
                dakika = 0;
                saat++;
            }

            salisetext.Text = salise.ToString();
            saniyetext.Text = saniye.ToString();
            dakikatext.Text = dakika.ToString();
            saattext.Text = saat.ToString();

            sdsekran.Text = sdsekran.ToString();
            sdsekran.Text = String.Format("Time: {0}h {1}m {2}s {3}ms", saat, dakika, saniye, salise);
        }

        private void reset_Click(object sender, EventArgs e)
        {
            salise = 0;
            saniye = 0;
            dakika = 0;
            saat = 0;
            salisetext.Text = "0";
            saniyetext.Text = "0";
            dakikatext.Text = "0";
            saattext.Text = "0";
        }

    }
}