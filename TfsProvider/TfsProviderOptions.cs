using System;
using System.Xml.Serialization;

namespace TsvnTfsProvider
{
	[Serializable, XmlRoot(ElementName = "Parameters")]
	public class TfsProviderOptions
	{
		public TfsProviderOptions()
		{
		}

		[XmlElement]
		public string ServerName { get; set; }

		[XmlElement]
		public string ProjectName { get; set; }
	}
}