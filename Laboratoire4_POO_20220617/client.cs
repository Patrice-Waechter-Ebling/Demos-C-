namespace Laboratoire4_POO
{
    internal class Client
    {
        private string Adressse;
        public Client(string Adressse)
        {
            this.Adressse = Adressse;
        }
        public string GetAdrresse()
        {
            return this.Adressse;
        }
    }
}