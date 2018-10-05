using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;


namespace Aprel.Models
{
    public class EFBookRepository : IBookRepository
    {
        CoffeeContext context = new CoffeeContext();

        public IEnumerable<Item> Napitki
        {
            get { return context.Napitki; }
        }

        public IEnumerable<Item> Coffeemachines
        {
            get { return context.Coffeemachines; }
        }

        public IEnumerable<Item> Accessories
        {
            get { return context.Accessories; }
        }

    }
}
