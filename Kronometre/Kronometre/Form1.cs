namespace Kronometre
{
    public partial class Form1 : Form
    {
        public int sayac = 0;

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
            sayactext.Text = "0";
            zamansayaci.Interval = 100; //miisaniyeyi 100'er artýracak.
        }

        private void zamansayaci_Tick(object sender, EventArgs e)
        {
            sayac++;
            sayactext.Text = sayac.ToString();

        }

        private void reset_Click(object sender, EventArgs e)
        {
            sayac = 0;
        }

    }
}