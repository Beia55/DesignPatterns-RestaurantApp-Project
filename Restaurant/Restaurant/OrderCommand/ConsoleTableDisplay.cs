using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Restaurant.Resources;
using ConsoleTables;

namespace Restaurant.OrderCommand
{
    class ConsoleTableDisplay
    {
        DataMenuItems _data = new DataMenuItems();

        public void DisplayTable()
        {
            Console.BackgroundColor = ConsoleColor.Red;
            Console.WriteLine("\n\n       ----------> RESTAURANT MENU <----------     \n\n");
            Console.BackgroundColor = ConsoleColor.Black;

            Console.WriteLine(" ~~~ Here is the menu with your options. \n" +
                " # Please look carefully and choose what you want. \n" +
                " # For the desired type, please enter the corresponding code, displayed next to each item ! \n\n\n");

            Console.BackgroundColor = ConsoleColor.DarkGreen;
            Console.Write("           ----- PIZZA -----           \n");
            var table1 = new ConsoleTable("Code", "Name", "Price", "Ingredience");
            table1.AddRow(_data.CapriciosaPizza[3], _data.CapriciosaPizza[0], _data.CapriciosaPizza[1], _data.CapriciosaPizza[2])
                 .AddRow(_data.QuattroStagioniPizza[3], _data.QuattroStagioniPizza[0], _data.QuattroStagioniPizza[1], _data.QuattroStagioniPizza[2])
                 .AddRow(_data.ProsciutoEFunghiPizza[3], _data.ProsciutoEFunghiPizza[0], _data.ProsciutoEFunghiPizza[1], _data.ProsciutoEFunghiPizza[2])
                 .AddRow(_data.MargheritaPizza[3], _data.MargheritaPizza[0], _data.MargheritaPizza[1], _data.MargheritaPizza[2]);
            Console.WriteLine(table1);

            Console.BackgroundColor = ConsoleColor.DarkMagenta;
            Console.Write("           ----- PASTA -----           \n");
            var table2 = new ConsoleTable("Code", "Name", "Price", "Ingredience");
            table2.AddRow(_data.CarbonaraPasta[3], _data.CarbonaraPasta[0], _data.CarbonaraPasta[1], _data.CarbonaraPasta[2])
                 .AddRow(_data.SeaFoodPasta[3], _data.SeaFoodPasta[0], _data.SeaFoodPasta[1], _data.SeaFoodPasta[2])
                 .AddRow(_data.GnochiPasta[3], _data.GnochiPasta[0], _data.GnochiPasta[1], _data.GnochiPasta[2])
                 .AddRow(_data.QuattroFormaggiPasta[3], _data.QuattroFormaggiPasta[0], _data.QuattroFormaggiPasta[1], _data.QuattroFormaggiPasta[2]);
            Console.WriteLine(table2);

            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.Write("           ----- MEAT -----           \n");
            var table3 = new ConsoleTable("Code", "Name", "Price", "Ingredience");
            table3.AddRow(_data.ChickenMeat[3], _data.ChickenMeat[0], _data.ChickenMeat[1], _data.ChickenMeat[2])
                 .AddRow(_data.DuckMeat[3], _data.DuckMeat[0], _data.DuckMeat[1], _data.DuckMeat[2])
                 .AddRow(_data.HamburgerMeat[3], _data.HamburgerMeat[0], _data.HamburgerMeat[1], _data.HamburgerMeat[2])
                 .AddRow(_data.SteakMeat[3], _data.SteakMeat[0], _data.SteakMeat[1], _data.SteakMeat[2])
                 .AddRow(_data.PorkChopsMeat[3], _data.PorkChopsMeat[0], _data.PorkChopsMeat[1], _data.PorkChopsMeat[2]);
            Console.WriteLine(table3);

            Console.BackgroundColor = ConsoleColor.DarkCyan;
            Console.Write("           ----- SIDE DISH -----           \n");
            var table4 = new ConsoleTable("Code", "Name", "Price", "Ingredience");
            table4.AddRow(_data.FrenchFriessSideDish[3], _data.FrenchFriessSideDish[0], _data.FrenchFriessSideDish[1], _data.FrenchFriessSideDish[2])
                 .AddRow(_data.RiceSideDish[3], _data.RiceSideDish[0], _data.RiceSideDish[1], _data.RiceSideDish[2])
                 .AddRow(_data.MashedPotatoesSideDish[3], _data.MashedPotatoesSideDish[0], _data.MashedPotatoesSideDish[1], _data.MashedPotatoesSideDish[2]);
            Console.WriteLine(table4);

            Console.BackgroundColor = ConsoleColor.DarkGray;
            Console.Write("           ----- DRESSING -----           \n");
            var table5 = new ConsoleTable("Code", "Name", "Price", "Ingredience");
            table5.AddRow(_data.KetchupDressing[3], _data.KetchupDressing[0], _data.KetchupDressing[1], _data.KetchupDressing[2])
                 .AddRow(_data.MayoDressing[3], _data.MayoDressing[0], _data.MayoDressing[1], _data.MayoDressing[2])
                 .AddRow(_data.TzatzikiDressing[3], _data.TzatzikiDressing[0], _data.TzatzikiDressing[1], _data.TzatzikiDressing[2]);
            Console.WriteLine(table5);

            Console.BackgroundColor = ConsoleColor.DarkRed;
            Console.Write("           ----- DESERT -----           \n");
            var table6 = new ConsoleTable("Code", "Name", "Price", "Ingredience");
            table6.AddRow(_data.LavaCakeDesert[3], _data.LavaCakeDesert[0], _data.LavaCakeDesert[1], _data.LavaCakeDesert[2])
                 .AddRow(_data.IcecreamDesert[3], _data.IcecreamDesert[0], _data.IcecreamDesert[1], _data.IcecreamDesert[2]);
            Console.WriteLine(table6);

            Console.BackgroundColor = ConsoleColor.DarkYellow;
            Console.Write("           ----- DRINKS -----           \n");
            var table7 = new ConsoleTable("Code", "Name", "Price", "Ingredience");
            table7.AddRow(_data.WaterDrink[3], _data.WaterDrink[0], _data.WaterDrink[1], _data.WaterDrink[2])
                 .AddRow(_data.ColaDrink[3], _data.ColaDrink[0], _data.ColaDrink[1], _data.ColaDrink[2])
                 .AddRow(_data.FantaDrink[3], _data.FantaDrink[0], _data.FantaDrink[1], _data.FantaDrink[2])
                 .AddRow(_data.LemonadeDrink[3], _data.LemonadeDrink[0], _data.LemonadeDrink[1], _data.LemonadeDrink[2])
                 .AddRow(_data.FreshDrink[3], _data.FreshDrink[0], _data.FreshDrink[1], _data.FreshDrink[2])
                 .AddRow(_data.CoffeeDrink[3], _data.CoffeeDrink[0], _data.CoffeeDrink[1], _data.CoffeeDrink[2]);
            Console.WriteLine(table7);
            Console.BackgroundColor = ConsoleColor.Black;

        }
    }
}
