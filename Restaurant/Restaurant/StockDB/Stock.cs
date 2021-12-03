using Nancy.Json;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Restaurant.Menu.MenuBuilders;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant.StockDB
{
    public class ModelItemStock: IStockArgs
    {
        private static readonly object _lockObject = new object();
        private static ModelItemStock _model;
        private static int _counter = 0;
        private DrinksBuilder _drink;

        public int Oranges { get; set; }
        public int Lemons { get; set; }
        public double Sugar { get; set; }
        public double Water { get; set; }
        public double Cafee { get; set; }

        private int NoOfUsedFruits = 2;

        private ModelItemStock()
        {   }

        public static ModelItemStock Instance
        {
            get
            {
                if (_model == null)
                {
                    lock (_lockObject)
                    {
                        if (_model == null)
                        {
                            _model = new ModelItemStock();
                            _counter++;
                        }
                    }
                }
                return _model;
            }
        }

        public int GetFruit() => NoOfUsedFruits;

        public int UseFruitsForDrink(string fruitType) 
        {
            if (fruitType == "oranges" && this.Oranges >=2)
            {
                this.Oranges -= this.NoOfUsedFruits;
                return this.Oranges;
            } else if (fruitType == "lemons" && this.Lemons >= 2)
            {
                this.Lemons -= this.NoOfUsedFruits;
                return this.Lemons;
            } else
            {
                if (fruitType == "oranges")
                {
                    return -1;
                }else
                {
                    return -1;
                }
            }
        }

        public override string ToString()
        {
            return "\n\nOranges-" + this.Oranges + "\n" +
                "Lemons-" + this.Lemons + "\n" +
                "Sugar-" + this.Sugar + "\n" +
                "Water-" + this.Water + "\n" +
                "Cafee-" + this.Cafee + "\n\n";
        }

        public DrinksBuilder InstantiateDrinkBuilder(DrinksBuilder drink)
        {
            this._drink = drink;
            return _drink;
        }

        public void Notify(string type)
        {
            if (type == "oranges" && this.Oranges < 2)
            {
                Console.WriteLine(this._drink.Update() + " the "+ type + " stock isn't enought !");
            }else if(type == "lemons" && this.Lemons < 2)
            {
                Console.WriteLine(this._drink.Update() + " the " + type + " stock isn't enought !");
            }
            else
            {
                Console.WriteLine(this._drink.Update() + " it is ready !");
            }
            this._drink.SetDrinkName();
        }
    }

    public class Stock : IStock
    {
        private string JsonURL = @"D:\IT\Anul_2_sem_1\InginerieSoftware\FirstProject\Implementation\Restaurant\Restaurant\StockDB\StockItems.json";

        public void GetData()
        {
            JObject _stocks = JObject.Parse(File.ReadAllText(JsonURL));
            ModelItemStock model = ModelItemStock.Instance;
            model.Oranges = (int)_stocks["oranges"];
            model.Lemons = (int)_stocks["lemons"];
            model.Sugar = (double)_stocks["sugar"];
            model.Water = (double)_stocks["water"];
            model.Cafee = (double)_stocks["cafee"];

            Console.WriteLine( model.ToString());
        }

        public void AddData(string type, int value)
        {
            JObject _stocks = JObject.Parse(File.ReadAllText(JsonURL));

            _stocks[type] = value;
            string output = Newtonsoft.Json.JsonConvert.SerializeObject(_stocks, Newtonsoft.Json.Formatting.Indented);
            File.WriteAllText(JsonURL, output);
        }
    }
}
