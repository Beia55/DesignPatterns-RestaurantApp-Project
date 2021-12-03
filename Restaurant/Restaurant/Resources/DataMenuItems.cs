using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant.Resources
{
    public class DataMenuItems
    {
        public List<string> CapriciosaPizza = new List<string>{ "Capriciosa Pizza", "24", "tomato puree, mozzarella, cremini mushrooms, artichoke hearts, black olives, prosciutto cotto", "Pi-1" };
        public List<string> QuattroStagioniPizza = new List<string>{ "Quattro Stagioni Pizza", "23", "artichokes, tomatoes, basil, prosciutto, ham, mushrooms, olives", "Pi-2" };
        public List<string> ProsciutoEFunghiPizza = new List<string>{ "Prosciuto E Funghi Pizza", "22", "champignon mushrooms, ham, mozzarella, broth, oregano", "Pi-3" };
        public List<string> MargheritaPizza = new List<string>{ "Margherita", "20", "red tomato sauce, white mozzarella, fresh green basil", "Pi-4" };
        
        public List<string> CarbonaraPasta = new List<string>{ "Carbonara Pasta", "21", "bacon, parmesan or pecorino cheese, spaghetti, black pepper", "Pa-1" };
        public List<string> SeaFoodPasta = new List<string>{ "Sea Food Pasta", "22", "Seafood: shrimp/prawns, calamari, squid heads and mussels, fresh garlic, lemon juice, white wine, cream, parsley", "Pa-2" };
        public List<string> GnochiPasta = new List<string>{ "Gnochi Pasta", "21", "Gnocchi alla Sorrentina, cooked mashed potatoes, ricotta", "Pa-3" };
        public List<string> QuattroFormaggiPasta = new List<string>{ "Quattro Formaggi Pasta", "19", "heavy cream, thyme, Taleggio, Gruyère, Parmigiano-Reggiano, Kosher salt, dried fusilli, penne, gorgonzola", "Pa-4" };
        
        public List<string> ChickenMeat = new List<string>{ "Chicken Meat", "22", "whole cooked chicken, salt, pepper", "M-1" };
        public List<string> DuckMeat = new List<string>{ "Duck Meat", "25", "whole cooked duck, salt, pepper", "M-2" };
        public List<string> HamburgerMeat = new List<string>{ "Hamburger Meat", "19", "minced onion, Worcestershire, hamburger buns, mayonnaise, ketchup, iceberg lettuce leaves, tomato, onion", "M-3" };
        public List<string> SteakMeat = new List<string>{ "Steak Meat", "23", "cooked cow steak meat, salt, pepper", "M-4" };
        public List<string> PorkChopsMeat = new List<string>{ "Pork Chops Meat", "26", "cooked pork chops, salt, pepper", "M-5" };

        public List<string> FrenchFriessSideDish = new List<string>{ "French Fries Side Dish", "14", "french fries, salt, pepper", "SD-1" };
        public List<string> RiceSideDish = new List<string>{ "Rice Side Dish", "13", "rice, salt, pepper", "SD-2" };
        public List<string> MashedPotatoesSideDish = new List<string>{ "Mashed Potatoes Side Dish", "12", "mashed potatoes, salt, pepper", "SD-3" };
        
        public List<string> KetchupDressing = new List<string>{ "Ketchup Dressing", "1.5", "Ketchup", "Dres-1" };
        public List<string> MayoDressing = new List<string>{ "Mayo Dressing", "1.7", "Mayo", "Dres-2" };
        public List<string> TzatzikiDressing = new List<string>{ "Tzatziki Dressing", "2", "Tzatziki", "Dres-3" };
        
        public List<string> LavaCakeDesert = new List<string>{ "Lava Cake Desert", "13", "sugar, milk, jam, chocolate", "De-1" };
        public List<string> IcecreamDesert = new List<string>{ "Icecream Desert", "9", "ice cream cups, topping", "De-2" };
        
        public List<string> WaterDrink = new List<string>{ "Water Drink", "2.5", "natural water", "Dri-1" };
        public List<string> ColaDrink = new List<string>{ "Cola Drink", "4.5", "Coca Cola", "Dri-2" };
        public List<string> FantaDrink = new List<string>{ "Fanta Drink", "3", "Fanta", "Dri-3" };
        public List<string> LemonadeDrink = new List<string>{ "Lemonade Drink", "7", "sugar, water, mint, ice, shock syrup, oranges/lemons", "Dri-4" };
        public List<string> FreshDrink = new List<string>{ "Fresh Drink", "5", "sugar, water, oranges/lemons", "Dri-5" };
        public List<string> CoffeeDrink = new List<string>{ "Coffee Drink", "4", "cofee, sugar, milk", "Dri-6" };
    }
}
