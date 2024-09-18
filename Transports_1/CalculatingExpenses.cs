using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Transports_1
{
    public partial class CalculatingExpenses : Form
    {
        Dictionary <string, double> resoursec = new Dictionary <string, double>();
        public CalculatingExpenses()
        {
            InitializeComponent();
        }
        private void CalculatingExpenses_Load(object sender, EventArgs e)
        {
            
        }

        private void buttonCalc_Click(object sender, EventArgs e)
        {
            if (this.Owner is MainForm mainform)
            {
                
                if (textBox_mileagePassenger.Text != "" &&
                    textBox_mileageTruck.Text != "" &&
                    textBox_mileageBus.Text != "")
                {
                    bool isNumberPassenger = Double.TryParse(textBox_mileagePassenger.Text, out double tempMileagePassenger);
                    bool isNumberTruck = Double.TryParse(textBox_mileageTruck.Text, out double tempMileageTruck);
                    bool isNumberBus = Double.TryParse(textBox_mileageBus.Text, out double tempMileageBus);
                    if (isNumberPassenger&&isNumberTruck&&isNumberBus)
                    {
                        foreach (var vehicle in mainform._vehicles)
                        {
                            string fuel = Determining_FuelType(vehicle.GetFuelType());
                            if (!resoursec.ContainsKey(fuel))
                            {
                                if (vehicle is PassengerCar)
                                    resoursec.Add(fuel, tempMileagePassenger * vehicle.FuelConsumption / 100);
                                else if (vehicle is Truck)
                                    resoursec.Add(fuel, tempMileageTruck * vehicle.FuelConsumption / 100);
                                else if (vehicle is Bus)
                                    resoursec.Add(fuel, tempMileageBus * vehicle.FuelConsumption / 100);
                            }
                            else
                            {
                                if (vehicle is PassengerCar)
                                    resoursec[fuel] += Double.Parse(textBox_mileagePassenger.Text) * vehicle.FuelConsumption / 100;
                                else if (vehicle is Truck)
                                    resoursec[fuel] += Double.Parse(textBox_mileageTruck.Text) * vehicle.FuelConsumption / 100;
                                else if (vehicle is Bus)
                                    resoursec[fuel] += Double.Parse(textBox_mileageBus.Text) * vehicle.FuelConsumption / 100;
                            }
                        }
                        string result = "";
                        foreach (var res in resoursec)
                        {
                            result += $"{res.Key.ToString()}: {res.Value.ToString()}\n";
                        }
                        if (resoursec.Count > 0)
                        {
                            MessageBox.Show(result);
                            resoursec.Clear();
                        }
                        else MessageBox.Show("В автопарке нет машин!");
                    }
                    else MessageBox.Show("Какая-то из строк не является числом!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else MessageBox.Show("Заполните все строки!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private string Determining_FuelType(FuelType fuel)
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
    }
}
