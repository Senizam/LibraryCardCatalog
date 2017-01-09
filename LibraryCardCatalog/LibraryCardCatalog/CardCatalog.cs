using Library;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

namespace Library
{
        public class CardCatalog
        {
            public CardCatalog(string fileName)
            {
                _filename = fileName;
            if (File.Exists(fileName))
            {
                XmlSerializer serializer = new XmlSerializer(typeof(List<Book>));

                using (FileStream fs = new FileStream(fileName, FileMode.Open))
                {
                    using (XmlReader reader = XmlReader.Create(fs))
                    {

                        books = (List<Book>)serializer.Deserialize(reader);
                    }
                }
            }
            else
            {
                books = new List<Book>();
            }
            }
            private string _filename;
            private List<Book> books;

            public List<Book> ListBooks()
            {
                return books;
            }
            public void AddBook(Book book)
            {
                books.Add(book);
            }
            public void Save()
            {
                XmlSerializer serializer = new XmlSerializer(typeof(List<Book>));

            using (FileStream fs = new FileStream(_filename, FileMode.OpenOrCreate))
            {
                using (XmlWriter writer = XmlWriter.Create(fs))
                {
                    serializer.Serialize(writer, books);
                }
            }
            }












        }
    }

