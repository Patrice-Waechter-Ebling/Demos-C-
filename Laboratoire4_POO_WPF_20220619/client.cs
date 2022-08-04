namespace Laboratoire4_POO_WPF_20220619
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