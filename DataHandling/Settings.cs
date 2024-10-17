using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Newtonsoft.Json;
using System.Xml;

namespace ShareManV3
{
    public class Settings
    {
        public string Path { get; set; }

        public string Theme { get; set; }

        public string Api_Key { get; set; }

        public string alphavantage_Key { get; set; }

        public int maxSearches { get; set; }


        public static Settings Load(string filePath)
        {
            if (!File.Exists(filePath))
            {
                return new Settings(); // Return default settings if file doesn't exist
            }

            string json = File.ReadAllText(filePath);
            return JsonConvert.DeserializeObject<Settings>(json);
        }

        // Method to save settings to a file
        public void Save(string filePath)
        {
            string json = JsonConvert.SerializeObject(this, Newtonsoft.Json.Formatting.Indented);
            File.WriteAllText(filePath, json);
        }
    }
}
