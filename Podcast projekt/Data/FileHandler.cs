using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Xml;
using System.Xml.Serialization;

namespace Data
{
    public static class FileHandler
    {
        public static XmlDocument GetRssXML(string url)
        {
            var xml = "";
            using (var client = new WebClient())
            {
                client.Encoding = Encoding.UTF8;
                xml = client.DownloadString(url);

            }
            var document = new XmlDocument();
            document.LoadXml(xml);
            return document;
        }

        public static void SparaKategoriILista(List<Kategori> kategoriLista)
        {
            var serializer = new XmlSerializer(typeof(List<Kategori>));

            //Vart kommer savefile.xml ifrån? Möjligt att det är default namnet när det skapas i XmlDocument
            using (var stream = new StreamWriter("savefile.xml"))
            {
                serializer.Serialize(stream, kategoriLista);


            }
        }

        public static List<Kategori> GetKategoriListan(string kategoriNamn)
        {
            var serializer = new XmlSerializer(typeof(List<Kategori>));
            var kategoriLista = new List<Kategori>();

            //Vart kommer savefile.xml ifrån? Möjligt att det är default namnet när det skapas i XmlDocument
            if (File.Exists("savefile.xml"))
            {
                using (var sr = new StreamReader("savefile.xml"))
                {
                    kategoriLista = (List<Kategori>)serializer.Deserialize(sr);
                }
            }

            return kategoriLista;
        }

        public static List<Kategori> GetKategoriListan()
        {
            var seralizer = new XmlSerializer(typeof(List<Kategori>));
            var kategoriLista = new List<Kategori>();

            if (File.Exists("savefile.xml"))
            {
                using (var sr = new StreamReader("savefile.xml"))
                {
                    kategoriLista = (List<Kategori>) seralizer.Deserialize(sr);
                }
                
            }
            return kategoriLista;

        }

    }


}
   

