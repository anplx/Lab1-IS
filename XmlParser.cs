using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace ExpertSystem
{
    class XmlParser
    {
        public static Dictionary<int, Configuration> Desirialize(string xml)
        {
            XmlSerializer xs = new XmlSerializer(typeof(ConfigDict));
            Dictionary<int, Configuration> result = new Dictionary<int, Configuration>();
            StringReader sr = new StringReader(xml);
            ConfigDict templist = (ConfigDict)xs.Deserialize(sr);
            foreach (Configuration config in templist.Config)
            {
                result.Add(config.MathSum, config);
            }
            return result;
        }
    }
}
