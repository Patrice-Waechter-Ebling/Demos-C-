namespace Laboratoire4
{
    internal class ConsommateurMaison
    {
        private string Adressse;
        public ConsommateurMaison(string Adressse)
        {
            this.Adressse = Adressse;
        }
        public string GetAdrresse()
        {
            return this.Adressse;
        }
    }
}