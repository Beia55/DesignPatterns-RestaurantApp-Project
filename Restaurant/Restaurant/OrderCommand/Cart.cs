using System;
using Restaurant.Menu;
using Restaurant.Menu.MenuBuilders;
using Restaurant.Resources;

namespace Restaurant.OrderCommand
{
    class Cart
    {
        DataMenuItems _data = new DataMenuItems();
        ConsoleTableDisplay _consoleDisplay = new ConsoleTableDisplay();
        MenuBuilder menu = new MenuBuilder();
        
        // din cash register cu Cart ca si parametru, ca sa salvez direct mai multe carturi pe care 
        // sa le adune

        // si aici voi pune conditiile pentru o consola dinamica (toate conditiile pentru buider)

        private bool Continue()
        {
            Console.WriteLine("ADD more? Write y - from yes - or n - from no ");
            string response = Console.ReadLine();

            if (response == "y" || response == "yes" || response == "Y" || response == "Yes" || response == "YES")
            {
                return false;
            } else if (response == "n" || response == "no" || response == "N" || response == "No" || response == "NO")
            {
                return true;
            } else
            {
                Console.WriteLine("Command doesn't exist ! Default = continue");
                return false;
            }
        }

        private string ChooseSideDishForMeet()
        {
            Console.WriteLine("Please, select Garniture for meat: \n" +
                "Press 1 for: "+_data.RiceSideDish[0]+ " - default " + "\n" +
                "Press 2 for: "+_data.FrenchFriessSideDish[0]+"\n" +
                "Press 3 for: "+_data.MashedPotatoesSideDish[0]);
            string option =  Console.ReadLine();
            if (option == "1")
            {
                return _data.RiceSideDish[1];
            }
            else if (option == "2")
            {
                return _data.FrenchFriessSideDish[1];
            }
            else if (option == "3")
            {
                return _data.MashedPotatoesSideDish[1];
            }
            else
            {
                Console.WriteLine("Command doesn't exist ! Default = " + _data.RiceSideDish);
                return _data.RiceSideDish[1];
            }
        }

        private MeatType ChooseTypeForMeet()
        {
            Console.WriteLine("Please, select the meat type you prefer: \n" +
                "Press 1 for: " + MeatType.Rare + "\n" +
                "Press 2 for: " + MeatType.Medium + " - default " + "\n" +
                "Press 3 for: " + MeatType.WellCooked);
            var type = Console.ReadLine();
            if (type == "1")
            {
                return MeatType.Rare;
            } else if (type == "2")
            {
                return MeatType.Medium;
            } else if (type == "3")
            {
                return MeatType.WellCooked;
            } else
            {
                Console.WriteLine("Command doesn't exist ! Default = " + MeatType.Medium);
                return MeatType.Medium;
            }
        }

        private void OrderPerId()
        {
            Console.WriteLine("\n\n\n");
            var endOrder = false;

            while (endOrder == false)
            {
                Console.WriteLine("Write item id HERE: ");
                string itemID = "";
                itemID = Console.ReadLine();
                    // PIZZA
                if (itemID == _data.CapriciosaPizza[3] || itemID == _data.CapriciosaPizza[3].ToLower() || itemID == _data.CapriciosaPizza[3].ToUpper())
                {
                    menu.Pizza.BuildCapriciosa();
                    endOrder = this.Continue();
                } 
                else if (itemID == _data.MargheritaPizza[3] || itemID == _data.MargheritaPizza[3].ToLower() || itemID == _data.MargheritaPizza[3].ToUpper())
                {
                    menu.Pizza.BuildMargherita();
                    endOrder = this.Continue();
                }
                else if (itemID == _data.ProsciutoEFunghiPizza[3] || itemID == _data.ProsciutoEFunghiPizza[3].ToLower() || itemID == _data.ProsciutoEFunghiPizza[3].ToUpper())
                {
                    menu.Pizza.BuildProsciuto();
                    endOrder = this.Continue();
                }
                else if (itemID == _data.QuattroStagioniPizza[3] || itemID == _data.QuattroStagioniPizza[3].ToLower() || itemID == _data.QuattroStagioniPizza[3].ToUpper())
                {
                    menu.Pizza.BuildQuattroStagioni();
                    endOrder = this.Continue();
                }
                    // PASTA
                else if (itemID == _data.CarbonaraPasta[3] || itemID == _data.CarbonaraPasta[3].ToLower() || itemID == _data.CarbonaraPasta[3].ToUpper())
                {
                    menu.Pasta.BuildCarbonara();
                    endOrder = this.Continue();
                }
                else if (itemID == _data.GnochiPasta[3] || itemID == _data.GnochiPasta[3].ToLower() || itemID == _data.GnochiPasta[3].ToUpper())
                {
                    menu.Pasta.BuildGnochi();
                    endOrder = this.Continue();
                }
                else if (itemID == _data.QuattroFormaggiPasta[3] || itemID == _data.QuattroFormaggiPasta[3].ToLower() || itemID == _data.QuattroFormaggiPasta[3].ToUpper())
                {
                    menu.Pasta.BuildQuattroFormaggi();
                    endOrder = this.Continue();
                }
                else if (itemID == _data.SeaFoodPasta[3] || itemID == _data.SeaFoodPasta[3].ToLower() || itemID == _data.SeaFoodPasta[3].ToUpper())
                {
                    menu.Pasta.BuildSeaFood();
                    endOrder = this.Continue();
                }
                    // SIDE DISH
                else if (itemID == _data.FrenchFriessSideDish[3] || itemID == _data.FrenchFriessSideDish[3].ToLower() || itemID == _data.FrenchFriessSideDish[3].ToUpper())
                {
                    menu.SideDish.BuildFrenchFries();
                    endOrder = this.Continue();
                }
                else if (itemID == _data.RiceSideDish[3] || itemID == _data.RiceSideDish[3].ToLower() || itemID == _data.RiceSideDish[3].ToUpper())
                {
                    menu.SideDish.BuildRice();
                    endOrder = this.Continue();
                }
                else if (itemID == _data.MashedPotatoesSideDish[3] || itemID == _data.MashedPotatoesSideDish[3].ToLower() || itemID == _data.MashedPotatoesSideDish[3].ToUpper())
                {
                    menu.SideDish.BuildMashedPotatoes();
                    endOrder = this.Continue();
                }
                    // DRESSING
                else if (itemID == _data.KetchupDressing[3] || itemID == _data.KetchupDressing[3].ToLower() || itemID == _data.KetchupDressing[3].ToUpper())
                {
                    menu.Dressing.BuildKetchup();
                    endOrder = this.Continue();
                }
                else if (itemID == _data.MayoDressing[3] || itemID == _data.MayoDressing[3].ToLower() || itemID == _data.MayoDressing[3].ToUpper())
                {
                    menu.Dressing.BuildMayo();
                    endOrder = this.Continue();
                }
                else if (itemID == _data.TzatzikiDressing[3] || itemID == _data.TzatzikiDressing[3].ToLower() || itemID == _data.TzatzikiDressing[3].ToUpper())
                {
                    menu.Dressing.BuildTzatziki();
                    endOrder = this.Continue();
                }
                    // DESERT
                else if (itemID == _data.LavaCakeDesert[3] || itemID == _data.LavaCakeDesert[3].ToLower() || itemID == _data.LavaCakeDesert[3].ToUpper())
                {
                    menu.Desert.BuildLavaCake();
                    endOrder = this.Continue();
                }
                else if (itemID == _data.IcecreamDesert[3] || itemID == _data.IcecreamDesert[3].ToLower() || itemID == _data.IcecreamDesert[3].ToUpper())
                {
                    menu.Desert.BuildIcecream();
                    endOrder = this.Continue();
                }
                // DRINKS
                else if (itemID == _data.WaterDrink[3] || itemID == _data.WaterDrink[3].ToLower() || itemID == _data.WaterDrink[3].ToUpper())
                {
                    menu.Drink.BuildWater();
                    endOrder = this.Continue();
                }
                else if (itemID == _data.ColaDrink[3] || itemID == _data.ColaDrink[3].ToLower() || itemID == _data.ColaDrink[3].ToUpper())
                {
                    menu.Drink.BuildCola();
                    endOrder = this.Continue();
                }
                else if (itemID == _data.FantaDrink[3] || itemID == _data.FantaDrink[3].ToLower() || itemID == _data.FantaDrink[3].ToUpper())
                {
                    menu.Drink.BuildFanta();
                    endOrder = this.Continue();
                }
                else if (itemID == _data.LemonadeDrink[3] || itemID == _data.LemonadeDrink[3].ToLower() || itemID == _data.LemonadeDrink[3].ToUpper())
                {
                    menu.Drink.BuildLemonade();
                    endOrder = this.Continue();
                }
                else if (itemID == _data.FreshDrink[3] || itemID == _data.FreshDrink[3].ToLower() || itemID == _data.FreshDrink[3].ToUpper())
                {
                    menu.Drink.BuildFresh();
                    endOrder = this.Continue();
                }
                else if (itemID == _data.CoffeeDrink[3] || itemID == _data.CoffeeDrink[3].ToLower() || itemID == _data.CoffeeDrink[3].ToUpper())
                {
                    menu.Drink.BuildCoffee();
                    endOrder = this.Continue();
                }
                // MEAT
                else if (itemID == _data.ChickenMeat[3] || itemID == _data.ChickenMeat[3].ToLower() || itemID == _data.ChickenMeat[3].ToUpper())
                {
                    string sideDishOption = this.ChooseSideDishForMeet();
                    menu.Meat.BuildChicken(sideDishOption);
                    endOrder = this.Continue();
                }
                else if (itemID == _data.DuckMeat[3] || itemID == _data.DuckMeat[3].ToLower() || itemID == _data.DuckMeat[3].ToUpper())
                {
                    string sideDishOption = this.ChooseSideDishForMeet();
                    MeatType typeDishOption = this.ChooseTypeForMeet();
                    menu.Meat.BuildDuck(typeDishOption,sideDishOption);
                    endOrder = this.Continue();
                }
                else if (itemID == _data.HamburgerMeat[3] || itemID == _data.HamburgerMeat[3].ToLower() || itemID == _data.HamburgerMeat[3].ToUpper())
                {
                    string sideDishOption = this.ChooseSideDishForMeet();
                    MeatType typeDishOption = this.ChooseTypeForMeet();
                    menu.Meat.BuildHamburger(typeDishOption, sideDishOption);
                    endOrder = this.Continue();
                }
                else if (itemID == _data.PorkChopsMeat[3] || itemID == _data.PorkChopsMeat[3].ToLower() || itemID == _data.PorkChopsMeat[3].ToUpper())
                {
                    string sideDishOption = this.ChooseSideDishForMeet();
                    menu.Meat.BuildPork(sideDishOption);
                    endOrder = this.Continue();
                }
                else if (itemID == _data.SteakMeat[3] || itemID == _data.SteakMeat[3].ToLower() || itemID == _data.SteakMeat[3].ToUpper())
                {
                    string sideDishOption = this.ChooseSideDishForMeet();
                    MeatType typeDishOption = this.ChooseTypeForMeet();
                    menu.Meat.BuildSteak(typeDishOption, sideDishOption);
                    endOrder = this.Continue();
                }
                // ERROR
                else
                {
                    Console.WriteLine("Sorry! You have selected an invalid code!");
                    endOrder = this.Continue();
                }
            }
            Console.WriteLine("\n\n\n Thank you for ordering from us !");
            Console.WriteLine("\n\n\n MENU --- "+menu.ToString());

            menu.ChangeIdOrder();
        }

        public void ChooseItems()
        {
            _consoleDisplay.DisplayTable();

            this.OrderPerId();

            /*menu.Meat.BuildSteak(MeatType.Medium, "Mashed Potatoes");
            menu.Meat.BuildChicken("French Fries");

            Console.WriteLine("HERE --- " + menu.ToString() + "\n");
            menu.ChangeIdOrder();

            Console.WriteLine("\n \n \n START NEW TASK ---------------------\n");
            menu.Meat.BuildSteak(MeatType.WellCooked, "Rice");
            Console.WriteLine("HERE --- " + menu.ToString() + "\n");
            menu.ChangeIdOrder();

            Console.WriteLine("\n \n \n START NEW TASK ---------------------\n");
            menu.Desert.BuildIcecream();
            Console.WriteLine("HERE --- " + menu.ToString() + "\n");

            menu.ChangeIdOrder();
            Console.WriteLine("\n \n \n START NEW TASK ---------------------\n");*/

        }
    }
}
