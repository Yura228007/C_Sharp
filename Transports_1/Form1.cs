namespace Transports_1
{
    public partial class MainForm : Form
    {
        public List<Transport> _vehicles = new List<Transport>();
        public Dictionary<string, int> fuelVolume = new Dictionary<string, int>();
        public MainForm()
        {
            InitializeComponent();
            _vehicles.Add(new PassengerCar("PassengerCar1", 15, 90, FuelType.hydrogen));
            _vehicles.Add(new PassengerCar("PassengerCar2", 15, 90, FuelType.hydrogen));
            _vehicles.Add(new PassengerCar("PassengerCar3", 15, 90, FuelType.hydrogen));
            _vehicles.Add(new Truck("Truck1", 30, 60, FuelType.��92));
            _vehicles.Add(new Truck("Truck2", 30, 60, FuelType.��92));
            _vehicles.Add(new Truck("Truck3", 30, 60, FuelType.��92));
            _vehicles.Add(new Bus("Bus1", 20, 75, FuelType.dieselSummer));
            _vehicles.Add(new Bus("Bus2", 20, 75, FuelType.dieselSummer));
            _vehicles.Add(new Bus("Bus3", 20, 75, FuelType.dieselSummer));
            foreach (var i in _vehicles)
            {
                listBox_transports.Items.Add(i.Name);
            }
            comboBox_fuelType.Items.AddRange(new string[] { "������", "���", "������" });
            comboBox_purposeCar.Items.AddRange(new string[] { "��������", "��������", "�������" });

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
                return "������ ������";
            }
            else if (fuel == FuelType.dieselWinter)
            {
                return "������ ������";
            }
            else if (fuel == FuelType.hydrogen)
            {
                return "��� �������";
            }
            else if (fuel == FuelType.methane)
            {
                return "��� �����";
            }
            else
            {
                return fuel.ToString();
            }
        }

        private FuelType Determining_FuelTypeEnum()
        {
            if (comboBox_fuelSubtype.Text == "������")
            {
                return FuelType.dieselSummer;
            }
            else if (comboBox_fuelSubtype.Text == "������")
            {
                return FuelType.dieselWinter;
            }
            else if (comboBox_fuelSubtype.Text == "�������")
            {
                return FuelType.hydrogen;
            }
            else if (comboBox_fuelSubtype.Text == "�����")
            {
                return FuelType.methane;
            }
            else if (comboBox_fuelSubtype.Text == "��92")
            {
                return FuelType.��92;
            }
            else if (comboBox_fuelSubtype.Text == "��95")
            {
                return FuelType.��95;
            }
            else if (comboBox_fuelSubtype.Text == "��98")
            {
                return FuelType.��98;
            }
            else if (comboBox_fuelSubtype.Text == "��76")
            {
                return FuelType.��76;
            }
            else if (comboBox_fuelSubtype.Text == "��80")
            {
                return FuelType.��80;
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
                                if (comboBox_purposeCar.Text == "��������")
                                {
                                    PassengerCar car = new PassengerCar(textBox_nameCar.Text, Int32.Parse(textBox_fuelConsumption.Text), Int32.Parse(textBox_averageSpeed.Text), fuel);
                                    _vehicles.Add(car);
                                    listBox_transports.Items.Add(car.Name);
                                    MessageBox.Show("�������!");
                                    panel_addTransport.Visible = false;
                                    button_add.Visible = true;
                                }
                                else if (comboBox_purposeCar.Text == "��������")
                                {
                                    Truck car = new Truck(textBox_nameCar.Text, Int32.Parse(textBox_fuelConsumption.Text), Int32.Parse(textBox_averageSpeed.Text), fuel);
                                    _vehicles.Add(car);
                                    listBox_transports.Items.Add(car.Name);
                                    MessageBox.Show("�������!");
                                    panel_addTransport.Visible = false;
                                    button_add.Visible = true;
                                }
                                else if (comboBox_purposeCar.Text == "�������")
                                {
                                    Bus car = new Bus(textBox_nameCar.Text, Int32.Parse(textBox_fuelConsumption.Text), Int32.Parse(textBox_averageSpeed.Text), fuel);
                                    _vehicles.Add(car);
                                    listBox_transports.Items.Add(car.Name);
                                    MessageBox.Show("�������!");
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
            if (comboBox_fuelType.Text == "������")
            {
                comboBox_fuelSubtype.Items.AddRange(new string[] { "������", "������" });
            }
            if (comboBox_fuelType.Text == "���")
            {
                comboBox_fuelSubtype.Items.AddRange(new string[] { "�������", "�����" });
            }
            if (comboBox_fuelType.Text == "������")
            {
                comboBox_fuelSubtype.Items.AddRange(new string[] { "��92", "��95", "��98", "��76", "��80" });
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