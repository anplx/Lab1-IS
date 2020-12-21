
using System.Xml.Serialization;
using System.Collections.Generic;
namespace ExpertSystem
{
	[XmlRoot(ElementName = "Config")]
	public class Configuration
	{
		[XmlElement(ElementName = "CPU")]
		public string CPU { get; set; }
		[XmlElement(ElementName = "GPU")]
		public string GPU { get; set; }
		[XmlElement(ElementName = "RAM")]
		public string RAM { get; set; }
		[XmlElement(ElementName = "MotherBoard")]
		public string MotherBoard { get; set; }
		[XmlElement(ElementName = "StorageDevice")]
		public string StorageDevice { get; set; }
		[XmlElement(ElementName = "PowerSupply")]
		public string PowerSupply { get; set; }
		[XmlElement(ElementName = "MathSum")]
		public int MathSum { get; set; }
	}

	[XmlRoot(ElementName = "ConfigDict")]
	public class ConfigDict
	{
		[XmlElement(ElementName = "Config")]
		public List<Configuration> Config { get; set; }
	}

}
