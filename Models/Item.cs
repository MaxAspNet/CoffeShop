using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Aprel.Models
{
    public class Item
    {
        public int Id { get; set; }
        public ItemType ItemType { get; set; }
        public string Name { get; set; }        
        public int Price { get; set; }
        public string Image { get; set; }
        public string Image1 { get; set; }
        public string Image2 { get; set; }
        public string Image3 { get; set; }
    }
    public class CoffeeMachine : Item
    {

    }

    public class Napitok : Item
    {

    }

    public class Accessory : Item
    {

    }
    public class CoffeemachinesClass : Item
    {

    }

    public enum ItemType {Undefined, Glasses, Spoons, Cups, White, Red, Black, CoffeeBlack, CoffeeMilk, Chokolate }
}