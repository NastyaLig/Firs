using System;
using System.Collections.Generic;
using System.IO;
using Lab_6.Controller;
using Lab_6.Exceptions;
using System.Text.Json;
using System.Threading.Tasks;
using static Lab_6.Logger.Logger;

namespace Lab_6
{
    class Program
    {

        static void Main(string[] args)
        {
            try
            {
                Flower flower = new Flower(50, "red");
                Flower flower1 = new Flower(20, "green");
                Flower flower2 = new Flower(30, "blue");
                //flower.Pour(54);  //Assert
                flower.Pour(-3);
               Flower flower3 = new Flower(-10, "blue");
                Bouquete bouquete = new Bouquete();
                bouquete.Add(flower);
                bouquete.Add(flower1);
                bouquete.Add(flower2);
                Console.WriteLine("---------------До сортировки--------------");
                foreach (Flower item in bouquete.Flwrs)
                {
                    Console.WriteLine(item.price + " " + item.color);
                }
                Console.WriteLine("Общая цена букета: " + bouquete.GetPrice());
                Console.WriteLine("------------После сортировки по стоимости цветков------------");
                BouqContr.FS(bouquete);
                foreach (Flower item in bouquete.Flwrs)
                {
                    Console.WriteLine(item.price + " " + item.color);
                }

                BouqContr.FindByColor(bouquete, "red");

                Bouquete bq1 = new Bouquete();
                BouqContr.ParseFile(bq1);
                foreach (Flower item in bq1.Flwrs)
                {
                    Console.WriteLine(item.price + " " + item.color);
                }
            }
            catch (FlowerException ex)
            {
                Console.WriteLine($"Error: {ex.Message} - {ex.ErrorPrice}");
            }
            catch (PlantException ex)
            {
                Console.WriteLine($"Error: {ex.Message} - {ex.ErrorPour}");
            }
            catch (CustomException ex)
            {
                Console.WriteLine($"Error: {ex.Message}, in class {ex.ErrorClass}");
                FileLogger.WriteLog(ex);
            }
            finally
            {
                Console.WriteLine("Работа после обнаружения ошибки с помощью finally ");
            }
        }
    }
}