using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace C_course.FileIOserialization
{
    public class JSONSerialization
    {
        /*
        var options = new JsonSerializerOptions
        {
            IncludeFields = true;
            WriteIndented = true;
        }
        */
        static void JSON<T>( T obj, string file)
        {
            File.WriteAllText(file, System.Text.Json.JsonSerializer.Serialize(obj));
        }
    }
}