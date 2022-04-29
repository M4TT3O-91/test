using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProdottiCataloghi
{
    public class Catalogue
    {
        public string ID_Catalogo { get; set; }
        public string ID_Prodotto { get; set; }
        public string Prezzo { get; set; }
        public string NomeCatalogo { get; set; }

        public override string ToString()
        {
            return $"{ID_Catalogo};{ID_Prodotto};{Prezzo};{NomeCatalogo}";
        }
    }
}
