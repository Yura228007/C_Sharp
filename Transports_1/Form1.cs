namespace Transports_1
{
    public partial class MainForm : Form
    {
        public List<Transport> _vehicles = new List<Transport>();
        public Dictionary<string, int> fuelVolume = new Dictionary<string, int>();
        public MainForm()
        {
            InitializeComponent();
            _vehicles.Add(new PassengerCar("PassengerCar1", 15, 90, FuelType.dieselSummer));
            _vehicles.Add(new PassengerCar("PassengerCar2", 12, 80, FuelType.АИ98));
            _vehicles.Add(new Truck("Truck1", 30, 60, FuelType.methane));
            _vehicles.Add(new Bus("Bus1", 20, 75, FuelType.АИ98));
            foreach (var i in _vehicles)
            {
                listBox_transports.Items.Add(i.Name);
            }
            comboBox_fuelType.Items.AddRange(new string[] { "Дизель", "Газ", "Бензин" });
            comboBox_purposeCar.Items.AddRange(new string[] { "Легковая", "Грузовик", "Автобус" });

            foreach (FuelType i in Enum.GetValues(typeof(FuelType)))
            {
                fuelVolume.Add(Determining_FuelTypeString(i), 500);
            }

            foreach (var line in fuelVolume)
            {
                anonLabel_tableLayoutPanel_fuelVolume(line.Key, line.Value);
            }
        }

        private void anonLabel_tableLayoutPanel_fuelVolume(string text, int val)
        {
            Label label = new Label();
            label.Text = text;
            tableLayoutPanel_fuelVolume.Controls.Add(label);

            NumericUpDown numericUpDown = new NumericUpDown();
            numericUpDown.Minimum = 0;
            numericUpDown.Maximum = 1000;
            numericUpDown.Value = val;
            numericUpDown.Tag = label;
            numericUpDown.BorderStyle = BorderStyle.None;
            tableLayoutPanel_fuelVolume.Controls.Add(numericUpDown);
        }

        private string Determining_FuelTypeString(FuelType fuel)
        {
            if (fuel == FuelType.dieselSummer)
            {
                return "Дизель летний";
            }
            else if (fuel == FuelType.dieselWinter)
            {
                return "Дизель зимний";
            }
            else if (fuel == FuelType.hydrogen)
            {
                return "Газ водород";
            }
            else if (fuel == FuelType.methane)
            {
                return "Газ метан";
            }
            else
            {
                return fuel.ToString();
            }
        }

        private FuelType Determining_FuelTypeEnum()
        {
            if (comboBox_fuelSubtype.Text == "Летний")
            {
                return FuelType.dieselSummer;
            }
            else if (comboBox_fuelSubtype.Text == "Зимний")
            {
                return FuelType.dieselWinter;
            }
            else if (comboBox_fuelSubtype.Text == "Водород")
            {
                return FuelType.hydrogen;
            }
            else if (comboBox_fuelSubtype.Text == "Метан")
            {
                return FuelType.methane;
            }
            else if (comboBox_fuelSubtype.Text == "АИ92")
            {
                return FuelType.АИ92;
            }
            else if (comboBox_fuelSubtype.Text == "АИ95")
            {
                return FuelType.АИ95;
            }
            else if (comboBox_fuelSubtype.Text == "АИ98")
            {
                return FuelType.АИ98;
            }
            else if (comboBox_fuelSubtype.Text == "АИ76")
            {
                return FuelType.АИ76;
            }
            else if (comboBox_fuelSubtype.Text == "АИ80")
            {
                return FuelType.АИ80;
            }
            else
            {
                return 0;
            }
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
                            FuelType fuel = Determining_FuelTypeEnum();
                            if (fuel != 0)
                            {
                                if (comboBox_purposeCar.Text == "Легковая")
                                {
                                    PassengerCar car = new PassengerCar(textBox_nameCar.Text, Int32.Parse(textBox_fuelConsumption.Text), Int32.Parse(textBox_averageSpeed.Text), fuel);
                                    _vehicles.Add(car);
                                    listBox_transports.Items.Add(car.Name);
                                    MessageBox.Show("Успешно!");
                                    panel_addTransport.Visible = false;
                                    button_add.Visible = true;
                                }
                                else if (comboBox_purposeCar.Text == "Грузовик")
                                {
                                    Truck car = new Truck(textBox_nameCar.Text, Int32.Parse(textBox_fuelConsumption.Text), Int32.Parse(textBox_averageSpeed.Text), fuel);
                                    _vehicles.Add(car);
                                    listBox_transports.Items.Add(car.Name);
                                    MessageBox.Show("Успешно!");
                                    panel_addTransport.Visible = false;
                                    button_add.Visible = true;
                                }
                                else if (comboBox_purposeCar.Text == "Автобус")
                                {
                                    Bus car = new Bus(textBox_nameCar.Text, Int32.Parse(textBox_fuelConsumption.Text), Int32.Parse(textBox_averageSpeed.Text), fuel);
                                    _vehicles.Add(car);
                                    listBox_transports.Items.Add(car.Name);
                                    MessageBox.Show("Успешно!");
                                    panel_addTransport.Visible = false;
                                    button_add.Visible = true;
                                }
                            }
                        }
                    }
                }
            }
        }

        private void clear_textBoxes_panelAdd()
        {
            textBox_nameCar.Text = "";
            comboBox_purposeCar.Text = "";
            textBox_fuelConsumption.Text = "";
            textBox_averageSpeed.Text = "";
            comboBox_fuelType.Text = "";
            comboBox_fuelSubtype.Items.Clear();
        }

        private void comboBox_fuelType_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox_fuelSubtype.Items.Clear();
            if (comboBox_fuelType.Text == "Дизель")
            {
                comboBox_fuelSubtype.Items.AddRange(new string[] { "Летний", "Зимний" });
            }
            if (comboBox_fuelType.Text == "Газ")
            {
                comboBox_fuelSubtype.Items.AddRange(new string[] { "Водород", "Метан" });
            }
            if (comboBox_fuelType.Text == "Бензин")
            {
                comboBox_fuelSubtype.Items.AddRange(new string[] { "АИ92", "АИ95", "АИ98", "АИ76", "АИ80" });
            }
        }

        private void button_add_Click(object sender, EventArgs e)
        {
            panel_addTransport.Visible = true;
            button_add.Visible = false;
            clear_textBoxes_panelAdd();
        }

        private void listBox_transports_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (var i in _vehicles)
            {

            }
        }

        private void button_calculation_Click(object sender, EventArgs e)
        {
            CalculatingExpenses calculatingExpenses = new CalculatingExpenses();
            calculatingExpenses.Owner = this;
            calculatingExpenses.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            fuelVolume.Clear();
            foreach (Control control in tableLayoutPanel_fuelVolume.Controls)
            {
                if (control is Label label)
                {
                    string line = label.Text;

                    int index = tableLayoutPanel_fuelVolume.Controls.IndexOf(control);

                    if (index + 1 < tableLayoutPanel_fuelVolume.Controls.Count)
                    {
                        Control nextControl = tableLayoutPanel_fuelVolume.Controls[index + 1];
                        if (nextControl is NumericUpDown numericUpDown)
                        {
                            int value = (int)numericUpDown.Value;
                            fuelVolume.Add(line, value);
                        }
                    }
                }
            }
        }
    }
}
