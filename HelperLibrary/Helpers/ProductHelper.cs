using ProdottiCataloghi;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductCatalogueLibrary
{
    public class ProductHelper
    {
        private readonly string FilePath;

        public ProductHelper(string filePath)
        {
            FilePath = filePath;
        }

        public void AddProduct(Product product)
        {
            using (var stream = new StreamWriter(FilePath, true))
            {
                stream.WriteLine(product);
            }
        }

        public List<Product> ReadAllProduct()
        {
            var productList = new List<Product>();

            using (var stream = new StreamReader(FilePath))
            {
                var header = "idprodotto;nomeprodotto;quantità";

                var firstLine = stream.ReadLine();
                if (!firstLine.Equals(header))
                    throw new Exception("File non conforme!");


                while (!stream.EndOfStream)
                {
                    var row = stream.ReadLine();
                    var splitted = row.Split(";");

                    var product = new Product
                    {
                        ID_Prodotto = splitted[0],
                        NomeProdotto = splitted[1],
                        QtaProdotto = splitted[2],
                    };

                    productList.Add(product);
                }

                return productList;
            }
        }

    }
}
