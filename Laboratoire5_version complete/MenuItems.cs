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
        public string GetCheminImage(int index)
        {
            return this.Items[index].GetCheminImage();
        }
        public int GetNombreItem()
        {
            return this.Items.Count;
        }
        public void AjouterItem(Item i)
        {
            this.Items.Add(i);
        }
        public string GetNomItem(int index)
        {
            return this.Items[index].GetNom();
        }
        public double GetPrixItem(int index)
        {
            return this.Items[index].GetPrix();
        }
    }
}
