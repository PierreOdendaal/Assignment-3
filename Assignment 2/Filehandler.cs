using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Assignment_2
{
    class Filehandler
    {
        static FileInfo fi = new FileInfo(@"Person.txt");
        List<Users> usli = new List<Users>();
        public void Writer(List<Users> list)
        {
            FileStream file = fi.Open(FileMode.Append, FileAccess.Write, FileShare.Read);
            StreamWriter writer = new StreamWriter(file);
            foreach (var item in list)
            {
                writer.WriteLine(item.ToString());
            }
            writer.Close();
            file.Close();
        }
        public List<string> ReadData(string fileName)
        {
            FileStream stream;
            StreamReader reader;
            List<string> userData = new List<string>();
            stream = new FileStream(fileName, FileMode.Open, FileAccess.Read);
            reader = new StreamReader(stream);

            string line = string.Empty;

            while ((line = reader.ReadLine()) != null)
            {
                userData.Add(line);
            }            
            
            reader.Close();
            stream.Close();
            
            return userData;
        }
    }
}
