using System;
using System.Collections.Generic;
using System.Text;

namespace Ex_Objets
{
    class TableauMateriel
    {
        public int GetTableItemCount { get; private set; }
        private string[] table = { "Une carte mère", "Un processeur", " Un disque dur", "Une barrette de mémoire", "Un bloc d'alimentation" };
        private int[] code = {125514414, 1585514414, 12514414, 14414, 67114414 };
        public TableauMateriel()
        {
            this.GetTableItemCount = table.Length;
        }
        public string GetTableauItem(int pos)
        {
            if (pos > table.Length||pos<0) return "Cette valeur est interdite";
            return $"# {code[pos]} : {table[pos]}";
        }
    }
}
