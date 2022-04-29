using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProdottiCataloghi
{
    public class Product
    {
        public string ID_Prodotto { get; set; }
        public string NomeProdotto { get; set; }
        public string QtaProdotto { get; set; }

        public override string ToString()
        {
            return $"{ID_Prodotto};{NomeProdotto};{QtaProdotto}";
        }
    }    
}
