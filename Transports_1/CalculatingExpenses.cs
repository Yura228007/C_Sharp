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
        Dictionary<string, double> resoursec = new Dictionary<string, double>();
        Dictionary<string, double> resoursecShortage = new Dictionary<string, double>();
        bool flag = true;

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
                    
                    int multiplier = DeterminingMultiplier();
                    int fuelForWarming = radioButton_summer.Checked ? 2 : 5;

                    if (isNumberPassenger && isNumberTruck && isNumberBus)
                    {
                        foreach (var vehicle in mainform._vehicles)
                        {
                            string fuel = Determining_FuelTypeString(vehicle.GetFuelType());
                            if (!resoursec.ContainsKey(fuel))
                            {
                                if (vehicle is PassengerCar)
                                    resoursec.Add(fuel, multiplier * tempMileagePassenger * vehicle.FuelConsumption / 100 + fuelForWarming);
                                else if (vehicle is Truck)
                                    resoursec.Add(fuel, multiplier * tempMileageTruck * vehicle.FuelConsumption / 100 + fuelForWarming);
                                else if (vehicle is Bus)
                                    resoursec.Add(fuel, multiplier * tempMileageBus * vehicle.FuelConsumption / 100 + fuelForWarming);
                            }
                            else
                            {
                                if (vehicle is PassengerCar)
                                    resoursec[fuel] += multiplier * Double.Parse(textBox_mileagePassenger.Text) * vehicle.FuelConsumption / 100 + fuelForWarming;
                                else if (vehicle is Truck)
                                    resoursec[fuel] += multiplier * Double.Parse(textBox_mileageTruck.Text) * vehicle.FuelConsumption / 100 + fuelForWarming;
                                else if (vehicle is Bus)
                                    resoursec[fuel] += multiplier * Double.Parse(textBox_mileageBus.Text) * vehicle.FuelConsumption / 100 + fuelForWarming;
                                }
                        }
                        //
                        foreach (var key in resoursec.Keys)
                        {
                            if (this.Owner is MainForm mainForm)
                            {
                                if (resoursec[key] > mainForm.fuelVolume[key])
                                {
                                    resoursecShortage.Add(key, resoursec[key] - mainForm.fuelVolume[key]);
                                }
                            }
                        }
                        //
                        string result = "";
                        if (resoursecShortage.Count > 0)
                        {
                            foreach (var res in resoursecShortage)
                            {
                                result += $"{res.Key.ToString()}: {res.Value.ToString()}\n";
                            }
                            MessageBox.Show($"Не хватает топлива:\n {result}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else if (resoursec.Count > 0)
                        {
                            foreach (var res in resoursec)
                            {
                                result += $"{res.Key.ToString()}: {res.Value.ToString()}\n";
                            }
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



        private void radioButton_day_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton_day.Checked)
            {
                radioButton_week.Checked = false;
                radioButton_month.Checked = false;
                radioButton_season.Checked = false;
            }
        }

        private void radioButton_week_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton_week.Checked)
            {
                radioButton_day.Checked = false;
                radioButton_month.Checked = false;
                radioButton_season.Checked = false;
            }
        }

        private void radioButton_month_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton_month.Checked)
            {
                radioButton_day.Checked = false;
                radioButton_week.Checked = false;
                radioButton_season.Checked = false;
            }
        }

        private void radioButton_season_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton_season.Checked)
            {
                radioButton_day.Checked = false;
                radioButton_week.Checked = false;
                radioButton_month.Checked = false;
            }
        }

        private int DeterminingMultiplier()
        {
            if (radioButton_day.Checked)
                return 1;
            else if (radioButton_week.Checked)
                return 7;
            else if (radioButton_month.Checked)
                return 30;
            else
                return 90;
        }

        private void radioButton_summer_CheckedChanged(object sender, EventArgs e)
        {
            radioButton_winter.Checked = !radioButton_summer.Checked;
        }

        private void radioButton_winter_CheckedChanged(object sender, EventArgs e)
        {
            radioButton_summer.Checked = !radioButton_winter.Checked;
        }

    }
}
