using System;
using System.Collections.Generic;
using System.Text;

namespace Laboratoire5
{
    class MenuItems
    {
        List<Item> Items;

        public MenuItems()
        {
            this.Items = new List<Item>();
        }

        public void AjouterItem(Item i)
        {
            this.Items.Add(i);
        }

        public List<Item> GetItems()
        {
            return this.Items;
        }

        public Item Trouver(int tag)
        {
            foreach(Item i in this.Items)
            {
                if (i.GetId() == tag)
                    return i;
            }

            throw new Exception("item non existant.");
        }
    }
}
