using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Newtonsoft.Json;
using System.Text.Json.Serialization;

namespace Tests
{
    class Json
    {
        static public string desktop = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\Tests.json";
        static public void Serilaz<T>(T Tests)
        {
            string json = JsonConvert.SerializeObject(Tests);
            File.WriteAllText(desktop, json);
        }
        static public T Deserilaz<T>()
        {
            string json = File.ReadAllText(desktop);
            T Tests = JsonConvert.DeserializeObject<T>(json);
            return Tests;
        }
    }
}
