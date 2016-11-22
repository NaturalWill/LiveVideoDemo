using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaterialDesignDemo.Helper
{
    class ConfigHelper
    {
        static string ConfigBaseDirectory
        {
            get { return System.AppDomain.CurrentDomain.BaseDirectory + @"conf\"; }
        }

        public static bool WriteConfig(string name, object o)
        {
            try
            {
                if (!Directory.Exists(ConfigBaseDirectory))
                {
                    Directory.CreateDirectory(ConfigBaseDirectory);
                }

                string configPath = ConfigBaseDirectory + name;

                string output = Newtonsoft.Json.JsonConvert.SerializeObject(o);

                System.IO.File.WriteAllText(configPath, output);

                return true;
            }
            catch
            {
                return false;
            }
        }

        public static T ReadConfig<T>(string name)
        {
            string configPath = ConfigBaseDirectory + name;

            try
            {

                if (File.Exists(configPath))
                {
                    string s = File.ReadAllText(configPath);

                    T obj = Newtonsoft.Json.JsonConvert.DeserializeObject<T>(s);

                    return obj;
                }
            }
            catch
            {

                return default(T);
            }

            return default(T);
        }
    }
}
