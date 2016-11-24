using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookListService
{
    internal class BookListStorage
    {
        private string filePath;

        public BookListStorage(string filePath)
        {
            this.filePath = filePath;
        }

        public List<Book> LoadBooks(string file)
        {
            List<Book> list = new List<Book>();
            if (File.Exists(filePath))
            {
                using (BinaryReader br = new BinaryReader(File.Open(file,FileMode.Open)))
                {
                    string str = br.ReadString();
                    do
                    {
                        string[] array = str.Split(',');
                        list.Add(new Book(int.Parse(array[0]), array[1], array[2], int.Parse(array[3]),
                            int.Parse(array[4]), int.Parse(array[5])));
                        str = br.ReadString();
                    } while (string.IsNullOrEmpty(str) == false);

                }
            }
            return list;


        }

        public void SaveBooks(List<Book> books)
        {
            
        }
    }
}
