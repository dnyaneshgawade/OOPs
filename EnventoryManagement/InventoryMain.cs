using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace EnventoryManagement
{
    public class InventoryMain
    {
        public void DisplayData(string filepath)
        {
            try
            {
                if (File.Exists(filepath))
                {
                    string jsonData = File.ReadAllText(filepath);
                    InventoryStructure jsonObjectArray = JsonConvert.DeserializeObject<InventoryStructure>(jsonData);
                    Console.WriteLine("\nPrice table for Rice\nName\tWeight\tPricePerKg\tAmount");
                    List<Rice> rice = jsonObjectArray.RiceList;
                    foreach (var item in rice)
                    {
                        Console.WriteLine("{0}" + "\t" + "{1}" + "\t" + "{2}" + "\t\t" + "{3}", item.Name, item.Weight, item.PricePerKg, item.Weight * item.PricePerKg);
                    }
                    Console.WriteLine("\nPrice table for Wheat\nName\tWeight\tPricePerKg\tAmount");
                    List<Wheat> wheat = jsonObjectArray.WheatList;
                    foreach (var item in wheat)
                    {
                        Console.WriteLine("{0}" + "\t" + "{1}" + "\t" + "{2}" + "\t\t" + "{3}", item.Name, item.Weight, item.PricePerKg, item.Weight * item.PricePerKg);
                    }
                    Console.WriteLine("\nPrice table for Pulses\nName\tWeight\tPricePerKg\tAmount");
                    List<Pulses> pulses = jsonObjectArray.PulsesList;
                    foreach (var item in pulses)
                    {
                        Console.WriteLine("{0}" + "\t" + "{1}" + "\t" + "{2}" + "\t\t" + "{3}", item.Name, item.Weight, item.PricePerKg, item.Weight * item.PricePerKg);
                    }
                }
                else
                {
                    Console.WriteLine("\nspecified path is not present");
                }
            }
            catch(Exception e)
            {
                throw new Exception(e.Message);
            }
        }
        public void RemoveData(string filepath)
        {
            string jsonData = File.ReadAllText(filepath);
            InventoryStructure jsonObjectArray = JsonConvert.DeserializeObject<InventoryStructure>(jsonData);
            string name;
            Console.WriteLine("\n press 1 for deleting the item from ricelist.\n press 2 for deleting the item from wheatlist.\n press 3 for deleting the item from pulseslist.");
            int switchChoice = Convert.ToInt16(Console.ReadLine());
            switch (switchChoice)
            {
                case 1:
                    Console.WriteLine("Enter the name of Rice you want to delete");
                    name = Console.ReadLine().ToLower();
                    List<Rice> rice = jsonObjectArray.RiceList;
                    foreach (var item in rice)
                    {
                        if (item.Name.ToLower() == name)
                        {
                            rice.Remove(item);
                        }
                        else
                        {
                            Console.WriteLine("name not found ");
                            
                        }

                    }
                    
                    break;
                case 2:
                    Console.WriteLine("Enter the name of Wheat you want to delete");
                    name = Console.ReadLine().ToLower();
                    List<Wheat> wheat = jsonObjectArray.WheatList;
                    foreach (var item in wheat)
                    {
                        if (item.Name.ToLower() == name)
                        {
                            wheat.Remove(item);
                        }
                        else
                        {
                            Console.WriteLine("name not found ");

                        }

                    }
                    break;
                case 3:
                    Console.WriteLine("Enter the name of Pulses you want to delete");
                    name = Console.ReadLine().ToLower();
                    List<Pulses> pulses = jsonObjectArray.PulsesList;
                    foreach (var item in pulses)
                    {
                        if (item.Name.ToLower() == name)
                        {
                            pulses.Remove(item);
                        }
                        else
                        {
                            Console.WriteLine("name not found ");

                        }

                    }
                    break;
            }
        }
        public void UpdateData(string filepath)
        {
            string jsonData = File.ReadAllText(filepath);
            InventoryStructure jsonObjectArray = JsonConvert.DeserializeObject<InventoryStructure>(jsonData);
            string name;
            Console.WriteLine("\n press 1 for editing the ricelist.\n press 2 for editing the wheatlist.\n press 3 for editing the pulseslist.");
            int switchChoice = Convert.ToInt16(Console.ReadLine());
            switch (switchChoice)
            {
                case 1:
                    Console.WriteLine("what do you want to edit");
                    name = Console.ReadLine().ToLower();
                    List<Rice> rice = jsonObjectArray.RiceList;
                    foreach (var item in rice)
                    {
                        if (item.Name.ToLower() == name)
                        {
                            Console.WriteLine("Enter Name :");
                            item.Name = Console.ReadLine();
                            Console.WriteLine("Enter Weight :");
                            item.Weight = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("Enter PricePerKg :");
                            item.PricePerKg = Convert.ToInt32(Console.ReadLine());
                        }
                        else
                        {
                            Console.WriteLine("name not found ");

                        }
                        string json = JsonConvert.SerializeObject(jsonObjectArray);
                        File.WriteAllText(@"C:\Users\dnyan\dnyana\EnventoryManagement\EnventoryManagementt\EnventoryManagement.json", json);
                    }
                    break;
                case 2:
                    Console.WriteLine("what do you want to edit");
                    name = Console.ReadLine().ToLower();
                    List<Wheat> wheat = jsonObjectArray.WheatList;
                    foreach (var item in wheat)
                    {
                        if (item.Name.ToLower() == name)
                        {
                            Console.WriteLine("Enter Name :");
                            item.Name = Console.ReadLine();
                            Console.WriteLine("Enter Weight :");
                            item.Weight = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("Enter PricePerKg :");
                            item.PricePerKg = Convert.ToInt32(Console.ReadLine());
                        }
                        else
                        {
                            Console.WriteLine("name not found ");

                        }
                        string json = JsonConvert.SerializeObject(jsonObjectArray);
                        File.WriteAllText(@"C:\Users\dnyan\dnyana\EnventoryManagement\EnventoryManagementt\EnventoryManagement.json", json);
                    }
                    break;
                case 3:

                    Console.WriteLine("what do you want to edit");
                    name = Console.ReadLine().ToLower();
                    List<Pulses> pulses = jsonObjectArray.PulsesList;
                    foreach (var item in pulses)
                    {
                        if (item.Name.ToLower() == name)
                        {
                            Console.WriteLine("Enter Name :");
                            item.Name = Console.ReadLine();
                            Console.WriteLine("Enter Weight :");
                            item.Weight = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("Enter PricePerKg :");
                            item.PricePerKg = Convert.ToInt32(Console.ReadLine());
                        }
                        else
                        {
                            Console.WriteLine("name not found ");

                        }
                        string json = JsonConvert.SerializeObject(jsonObjectArray);
                        File.WriteAllText(@"C:\Users\dnyan\dnyana\EnventoryManagement\EnventoryManagementt\EnventoryManagement.json", json);
                    }
                    break;
            }

        }
        public void CRUD(string filepath)
        { 
            int Choice=0;
            while (Choice != 4)
            {
                Console.WriteLine(" \nEnter 1 for Display\n Enter 2 for Edit\n Enter 3 for Add\n Enter  4 for exit ");
                Choice = Convert.ToInt32(Console.ReadLine());
                switch (Choice)
                {
                    case 1:

                        DisplayData(filepath);
                        break;
                    case 2:
                        UpdateData(filepath);
                        break;
                    case 3:
                        RemoveData(filepath);
                        break;
                    default:
                        Console.WriteLine("Enter wrong input");
                        break;
                }
            }
        }
    }  
}
