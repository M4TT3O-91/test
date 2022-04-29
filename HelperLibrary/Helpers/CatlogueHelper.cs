using ProdottiCataloghi;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductCatalogueLibrary
{
    public class CatlogueHelper
    {
        private readonly string FilePath;

        public CatlogueHelper(string filePath)
        {
            FilePath = filePath;
        }

        public void AddCatalogue(Catalogue catalogue)
        {
            using (var stream = new StreamWriter(FilePath, true))
            {
                stream.WriteLine(catalogue);
            }
        }

        public List<Catalogue> ReadAllCatalogue()
        {
            var catalogueList = new List<Catalogue>();

            using (var stream = new StreamReader(FilePath))
            {
                var header = "idcatalogo;idprodotto;prezzo;nomecatalogo";

                var firstLine = stream.ReadLine();
                if (!firstLine.Equals(header))
                    throw new Exception("File non conforme!");


                while (!stream.EndOfStream)
                {
                    var row = stream.ReadLine();
                    var splitted = row.Split(";");

                    var catalogue = new Catalogue
                    {
                        ID_Catalogo = splitted[0],
                        ID_Prodotto = splitted[1],
                        Prezzo = splitted[2],
                        NomeCatalogo = splitted[3],
                    };

                    catalogueList.Add(catalogue);
                }

                return catalogueList;
            }
        }
    }
}
