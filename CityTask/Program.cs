using System;

namespace CityTask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Sheherlerin sayi: ");
            if (int.TryParse(Console.ReadLine(), out int cityCount) && cityCount > 0)
            {
                ChinaCity[] chinaCities = new ChinaCity[cityCount];
                int totalPopulation = 0;

                for (int i = 0; i < cityCount; i++)
                {
                    ChinaCity chinaCity = new ChinaCity();

                    do
                    {
                        Console.Write($"{i + 1}. Adi daxil edin: ");
                        chinaCity.Name = Console.ReadLine();
                    } while (string.IsNullOrWhiteSpace(chinaCity.Name));

                    string StrChinaCityPopulation;
                    int chinaCityPopulation;

                    do
                    {
                        Console.Write("Ehali sayini daxil edin: ");
                        StrChinaCityPopulation = Console.ReadLine();

                    } while (!int.TryParse(StrChinaCityPopulation, out chinaCityPopulation));

                    chinaCity.Population = chinaCityPopulation;
                    chinaCities[i] = chinaCity;
                    totalPopulation += chinaCity.Population;
                }
                int avaragePopulation = 0;
                for (int i = 0; i < chinaCities.Length; i++)
                {
                    Console.WriteLine($"{chinaCities[i].Name}-{chinaCities[i].Population}");
                }
                Console.WriteLine($"Ortalama ehali: " + totalPopulation / cityCount);



            }

        }
    }
}
