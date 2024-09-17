namespace Transports_1
{
    public partial class Form1 : Form
    {
            List<Transport> _vehicles = new List<Transport>();
        public Form1()
        {
            InitializeComponent();
            _vehicles.Add(new PassengerCar("Car1", 15, 90, FuelType.dieselSummer));
            _vehicles.Add(new Truck("Car2", 30, 60, FuelType.methane));
            _vehicles.Add(new Bus("Car3", 20, 75, FuelType.¿»98));
            foreach (var i in _vehicles)
            {
                listBox_transports.Items.Add(i.Name);
            }
            comboBox_fuelType.Items.AddRange(new string[] { "ƒËÁÂÎ¸", "√‡Á", "¡ÂÌÁËÌ" });
        }

        private void button_addCar_Click(object sender, EventArgs e)
        {
            if (textBox_nameCar.Text != "")
            {
                if (textBox_fuelConsumption.Text != "")
                {
                    if (textBox_averageSpeed.Text != "")
                    {
                        if (comboBox_fuelSubtype.SelectedItem != null)
                        {
                            FuelType fuel = FuelType.hydrogen;
                            if (comboBox_fuelSubtype.Text == "summer")
                            {
                                fuel = FuelType.dieselSummer;
                            }
                            else if (comboBox_fuelSubtype.Text == "winter")
                            {
                                fuel = FuelType.dieselWinter;
                            }
                            else if (comboBox_fuelSubtype.Text == "hydrogen")
                            {
                                fuel = FuelType.hydrogen;
                            }
                            else if (comboBox_fuelSubtype.Text == "methane")
                            {
                                fuel = FuelType.methane;
                            }
                            else if (comboBox_fuelSubtype.Text == "¿»92")
                            {
                                fuel = FuelType.¿»92;
                            }
                            else if (comboBox_fuelSubtype.Text == "¿»95")
                            {
                                fuel = FuelType.¿»95;
                            }
                            else if (comboBox_fuelSubtype.Text == "¿»98")
                            {
                                fuel = FuelType.¿»98;
                            }
                            else if (comboBox_fuelSubtype.Text == "¿»76")
                            {
                                fuel = FuelType.¿»76;
                            }
                            else if (comboBox_fuelSubtype.Text == "¿»80")
                            {
                                fuel = FuelType.¿»80;
                            }
                            if (textBox_purposeCar.Text == "Passenger")
                            {
                                PassengerCar car = new PassengerCar(textBox_nameCar.Text, Int32.Parse(textBox_fuelConsumption.Text), Int32.Parse(textBox_averageSpeed.Text), fuel);
                                _vehicles.Add(car);
                                listBox_transports.Items.Add(car.Name);
                                MessageBox.Show("”ÒÔÂ¯ÌÓ!");
                                panel_addTransport.Visible = false;
                                button_add.Visible = true;
                            }
                            else if (textBox_purposeCar.Text == "Truck")
                            {
                                Truck car = new Truck(textBox_nameCar.Text, Int32.Parse(textBox_fuelConsumption.Text), Int32.Parse(textBox_averageSpeed.Text), fuel);
                                _vehicles.Add(car);
                                listBox_transports.Items.Add(car.Name);
                                MessageBox.Show("”ÒÔÂ¯ÌÓ!");
                                panel_addTransport.Visible = false;
                                button_add.Visible = true;
                            }
                            else if (textBox_purposeCar.Text == "Bus")
                            {
                                Bus car = new Bus(textBox_nameCar.Text, Int32.Parse(textBox_fuelConsumption.Text), Int32.Parse(textBox_averageSpeed.Text), fuel);
                                _vehicles.Add(car);
                                listBox_transports.Items.Add(car.Name);
                                MessageBox.Show("”ÒÔÂ¯ÌÓ!");
                                panel_addTransport.Visible = false;
                                button_add.Visible = true;
                            }
                        }
                    }
                }
            }
        }

        private void clear_textBoxes_panelAdd()
        {
            textBox_nameCar.Text = "";
            textBox_purposeCar.Text = "";
            textBox_fuelConsumption.Text = "";
            textBox_averageSpeed.Text = "";
            comboBox_fuelType.Text = "";
            comboBox_fuelSubtype.Items.Clear();
        }

        private void comboBox_fuelType_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox_fuelSubtype.Items.Clear();
            if (comboBox_fuelType.Text == "ƒËÁÂÎ¸")
            {
                comboBox_fuelSubtype.Items.AddRange(new string[] { "summer", "winter" });
            }
            if (comboBox_fuelType.Text == "√‡Á")
            {
                comboBox_fuelSubtype.Items.AddRange(new string[] { "hydrogen", "methane" });
            }
            if (comboBox_fuelType.Text == "¡ÂÌÁËÌ")
            {
                comboBox_fuelSubtype.Items.AddRange(new string[] { "¿»92", "¿»95", "¿»98", "¿»76", "¿»80" });
            }
        }

        private void button_add_Click(object sender, EventArgs e)
        {
            panel_addTransport.Visible = true;
            button_add.Visible = false;
            clear_textBoxes_panelAdd();
        }
    }
}
