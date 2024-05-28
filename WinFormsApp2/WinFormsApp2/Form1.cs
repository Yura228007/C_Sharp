namespace WinFormsApp2
{
    public partial class Form1 : Form
    {
        private Car_Toyota ct;
        private int meter;
        private int tmr_hit;
        public Form1()
        {
            InitializeComponent();
            ct = new Car_Toyota("corolla");
            ct.hit_from_pit += ct.hit_handler;
            meter = 0;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void DecreaseButton_Click(object sender, EventArgs e)
        {
            counter -= 1;
            show_text.Text = counter.ToString();
        }

        private void increaseButton_Click(object sender, EventArgs e)
        {
            counter += 1;
            show_text.Text = counter.ToString();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            meter += ct.Speed;
            show_meter.Text = meter.ToString();
            show_life.Text = ct.Life.ToString();

            Random rand = new Random();
            if (rand.Next(1,5) == 3)
            {
                show_hit.Visible = true;
                tmr_hit = 8;
                if (!ct.hit_handler(1))
                {
                    timer1.Stop();
                    show_hit.Text = meter.ToString();
                }
            }
            tmr_hit = tmr_hit > 0 ? tmr_hit - 1 : 0;
            if (tmr_hit == 0) show_hit.Visible = false;
        }

        private void button_start_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            timer1.Start();
            show_life.Text = ct.Life.ToString();
            show_meter.Text = meter.ToString();
        }
    }
}
