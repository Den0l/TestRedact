using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Newtonsoft.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using System.IO;
using System.Numerics;

namespace Pract2
{
    internal class Json
    {
        static public string desktop = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
        static public void Serilaz<T>(T Marks)
        {
            string json = JsonConvert.SerializeObject(Marks);
            File.WriteAllText(desktop + "\\Mark.json", json);
        }
        static public T Deserilaz<T>()
        {
            string json = File.ReadAllText(desktop + "\\Mark.json");
            T Marks = JsonConvert.DeserializeObject<T>(json);
            return Marks;
        }
    }
}
