namespace Laboratoire1
{
    class Commande
    {
        int No, nbrProduits;
        /*// avec Maurice
         * 
         *  1ere facon
         *      Produit[] Produit {get; set;}
         * 2eme facon 
         *   Produit[] Produits  {
         *   get {return this.Produits; } 
         *   set { Produits = value; }
         *   }
        */
        Produit[] Produits;
        public Produit[] GetProduits() { return this.Produits; }
        public int GetNumero() { return this.No; }
        public int GetNombreDeProduit() { return this.nbrProduits; }
        public void SetProduit(int pos, Produit produit) { this.Produits[pos] = produit; }
        public void SetNombreDeProduit(int valeur) { this.nbrProduits = valeur; }
        public void SetNumero(int valeur) { this.No = valeur; }
        public Commande(int no, int nbProduits)
        {
            this.No = no;
            this.nbrProduits = nbProduits;
            this.Produits = new Produit[this.nbrProduits];
        }
    }
}
