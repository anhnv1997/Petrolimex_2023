using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetrolimexConfig.Helper
{
    public class FileXML
    {
        public static void WriteXML<T>(string filename, List<T> conns) where T : class
        {
            System.IO.StreamWriter file = new System.IO.StreamWriter(filename);
            try
            {
                System.Xml.Serialization.XmlSerializer writer = new System.Xml.Serialization.XmlSerializer(typeof(List<T>));

                //System.IO.StreamWriter file = new System.IO.StreamWriter(filename); // @"c:\temp\SerializationOverview.xml");
                writer.Serialize(file, conns);
                file.Close();
            }
            catch (Exception ex)
            {
                // System.Windows.Forms.MessageBox.Show(ex.Message);
                file.Close();
                File.Delete(filename);
            }
        }
        public static void ReadXMLSQLConn<T>(string filename, ref T[] sqlconns)
        {
            try
            {
                if (File.Exists(filename))
                {
                    sqlconns = null;
                    System.Xml.Serialization.XmlSerializer reader =
                        new System.Xml.Serialization.XmlSerializer(typeof(T[]));
                    System.IO.StreamReader file = new System.IO.StreamReader(filename); // @"c:\temp\SerializationOverview.xml");
                    sqlconns = (T[])reader.Deserialize(file);
                    file.Close();
                }
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }
    }
}
