using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Aprel.Models;

namespace Aprel.Models





{
    public class Cart
    {
        private List<CartLine> lineCollection = new List<CartLine>();


        //добавим свойство lines позволяющее обратиться к содержимому корзины
        public IEnumerable<CartLine> Lines { get { return lineCollection; } }


        //метод добавдления элементов в корзину
        public void AddItem(Item item, int quantity)
        {
            CartLine line = lineCollection
                .Where(b => b.Item.Id == item.Id && b.Item.ItemType == item.ItemType)
                .FirstOrDefault();

            if (line == null)
            {
                lineCollection.Add(new CartLine { Item = item, Quantity = quantity });
            }
            else
            {
                line.Quantity += quantity;
            }
        }

        //метод удаления элемента из корзины
        public void RemoveLine(Item item)
        {
            lineCollection.RemoveAll(l => l.Item.Id == item.Id);
        }

        //метод вычисления общей стоимости товара
        public decimal ComputeTotalValue()
        {
            return lineCollection.Sum(e => e.Item.Price * e.Quantity);
        }

        //метод очистки корзины путем удаления всех элементов
        public void Clear()
        {
            lineCollection.Clear();
        }
    }

    public class CartLine
    {
        public Item Item { get; set; }
        public int Quantity { get; set; }
    }


}