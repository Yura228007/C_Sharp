using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dzwitharr.yura
{
    internal class Program
    {
        enum Transport
        {
            Motorcycle = 200,
            Car = 500,
            Van = 1000,
            Truck = 2000,
            SemiTruck = 10000,
            None
        }

        static void Main(string[] args)
        {
            //TASK 1
            /*            int[] arr = new int[10];
                        Random random = new Random();
                        for (int i = 0; i < arr.Length; i++)
                        {
                            arr[i] = random.Next(-20, 21);
                            Console.Write(arr[i]+ " ");
                        }
                        Console.WriteLine();
                        int j = 0;
                        for (int i = 0; i < arr.Length; i++)
                        {
                            if (arr[i] < 0)
                            {
                                int temp = arr[i];
                                arr[i] = arr[j];
                                arr[j] = temp;
                                j++;
                            }
                        }
                        for (int i = 0; i < arr.Length; i++)
                        {
                            Console.Write(arr[i] + " ");
                        }
                        Console.ReadKey();*/

            //TASK 2
            /*            int[] arr = new int[10];
                        Random random = new Random();
                        for (int i = 0; i < arr.Length; i++)
                        {
                            arr[i] = random.Next(0, 11);
                            Console.Write(arr[i] + " ");
                        }
                        Console.Write("Введите число от 0 до 10: ");
                        int numberUser = int.Parse(Console.ReadLine());
                        int k = 0;
                        for (int i = 0; i < arr.Length; i++)
                        {
                            if (arr[i] == numberUser) {  k++; }
                        }
                        Console.WriteLine($"Ваше число встречается в массиве {k} раз");
                        Console.ReadKey();*/

            //TASK 3
            Console.WriteLine("Введите вес груза:");
            int weight = int.Parse(Console.ReadLine());

            Transport selectedTransport = Transport.None; // По умолчанию выбираем автомобиль

            foreach (Transport transport in Enum.GetValues(typeof(Transport)))
            {
                if ((int)transport >= weight)
                {
                    selectedTransport = transport;
                    break;
                }
            }
            if (selectedTransport != Transport.None)
            {
                Console.WriteLine("Подходящий вид транспорта: " + selectedTransport);
            }
            else
            {
                Console.WriteLine("Транспорта для данного веса не существует");
            }
            Console.ReadKey();
        }
    }
}
