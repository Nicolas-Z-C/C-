using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using 
namespace C_course.FileIOserialization
{
    public class XMLSerialization 
    {
        static void SaveAsXML<T>(T Obj, string FileName)
        {
            XmlSerializer xmlFormat = new XmlSerializer(typeof(T));
            using (Stream fStream = new FileStream(FileName, FileMode.Create, FileAccess.Write,FileShare.None))
            {
                xmlFormat.Serialize(fSteam, Obj);
            }
        }

        static T ReadXML<T>(string FileName)
        {
            XmlSerializer xmlFormat = new XmlSerializer(typeof(T));
            using (Stream Fstream = new FileStream(FileName,FileMode.Open))
            {
                T obj = default;
                obj = (T)xmlFormat.Deserialize(Fstram);
                return obj;
            }
        }
    }
}