namespace Laboratoire5
{
    class LigneCommande
    {
        Item Item;
        int Quantite;
         public LigneCommande(Item item)
        {
            this.Item = item;
             this.Quantite = 1;
        }


        public Item GetItem()
        {
            return this.Item;
        }

        public int GetQuantite()
        {
            return this.Quantite;
        }

        public void Incremente()
        {
            this.Quantite++;
        }

        public void Decremente()
        {
            this.Quantite--;
        }
    }
}