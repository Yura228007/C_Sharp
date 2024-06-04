namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        private Car_Toyota ct;
        private double meter;
        private int tmr_hit;
        private int attraction;
        private bool inGame;
        private int accelerate_h;
        const int accelerate_g = 1;

        public Form1()
        {
            InitializeComponent();
            ct = new Car_Toyota("corolla");
            ct.hit_from_pit += ct.hit_handler;
            meter = 0;
            attraction = 0;
            inGame = false;
            ct.Y = 165;
            accelerate_h = 6;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void Decr_button_Click(object sender, EventArgs e)
        {
            counter -= 1;
            ct.Speed -= 1;
            show_text.Text = ct.Speed.ToString();
        }
        private void Incr_button_Click(object sender, EventArgs e)
        {
            counter += 1;
            ct.Speed += 1;
            show_text.Text = ct.Speed.ToString();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.A)
            {
                attraction -= 165;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            attraction += accelerate_g - accelerate_h;

            meter = Math.Round(meter + ct.Speed * 0.1, 1);
            show_meter.Text = "Meters: " + meter.ToString();
            show_life.Text = "Life: " + ct.Life.ToString();
            Random rand = new Random();

            if (car_player.Top >= BG_1.Top - car_player.Height)
            {
                car_player.Top = BG_1.Top - car_player.Height-1;
                attraction = 0;
            }
            car_player.Top += attraction;

            accelerate_h = accelerate_h > 0 ? accelerate_h - 1 : accelerate_h = 0;

            show_attr_Y.Text = attraction.ToString() + "  ,  " + ct.Y;

            if (rand.Next(1, 180) == 3)
            {
                show_hit.Visible = true;
                tmr_hit = 10;
                if (!ct.hit_handler(1))
                {
                    timer1.Stop();
                    show_hit.Text = "meters: " + meter.ToString();
                }
            }
            tmr_hit = tmr_hit > 0 ? tmr_hit - 1 : 0;
            if (tmr_hit == 0) show_hit.Visible = false;

            BG_1.Left -= ct.Speed * 1;
            BG_2.Left -= ct.Speed * 1;
            if (BG_1.Left < -800)
            {
                BG_1.Left = 0;
                BG_2.Left = BG_1.Right;
            }
        }

        private void buttn_start_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            timer1.Start();
            ct.Life = 30;
            meter = 0;
            show_life.Text = ct.Life.ToString();
            show_meter.Text = meter.ToString();
            show_text.Text = ct.Speed.ToString();

            button_stop_resume.Visible = true;
            button_stop_resume.Enabled = true;
            button_restart.Visible = true;
            button_restart.Enabled = true;

            button_start.Enabled = false;
            button_start.Visible = false;
            inGame = true;

        }

        private void button_stop_resume_Click(object sender, EventArgs e)
        {
            if (inGame)
            {
                timer1.Stop();
                button_stop_resume.Text = "resume";
                inGame = false;
            }
            else if (ct.Life > 0)
            {
                timer1.Start();
                button_stop_resume.Text = "stop";
                inGame = true;
            }
        }

        private void button_restart_Click(object sender, EventArgs e)
        {
            timer1.Start();
            ct.Life = 30;
            meter = 0;
            show_life.Text = ct.Life.ToString();
            show_meter.Text = meter.ToString();
            inGame = true;
            button_stop_resume.Text = "stop";
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void car_player_Click(object sender, EventArgs e)
        {
            accelerate_h = accelerate_g * 4;
        }

        private void BG_1_Click(object sender, EventArgs e)
        {

        }

        private void show_text_Click(object sender, EventArgs e)
        {

        }

        private void Form1_KeyDown_1(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.A)
            {
                accelerate_h = accelerate_g * 2;
            }
        }

        private void Form1_Click(object sender, EventArgs e)
        {
            accelerate_h = accelerate_g * 4;
        }

        private void button_jump_Click(object sender, EventArgs e)
        {
            accelerate_h = accelerate_g * 4;
        }
    }
}