using System;
using System.IO;
using System.Text;
using System.Xml;
using System.Xml.Serialization;

namespace TurtleTfs
{
	public static class TfsOptionsSerializer
	{
		public static string Serialize(TfsProviderOptions options)
		{
			var stringBuilder = new StringBuilder();
			var settings = new XmlWriterSettings
			               	{
			               		ConformanceLevel = ConformanceLevel.Auto,
			               		Encoding = new UTF8Encoding(false),
			               		Indent = false,
			               		NewLineOnAttributes = false,
			               		OmitXmlDeclaration = true,
			               	};
			var namespaces = new XmlSerializerNamespaces();
			namespaces.Add("","");
			using (var writer = XmlWriter.Create(stringBuilder, settings))
				new XmlSerializer(typeof (TfsProviderOptions)).Serialize(writer, options, namespaces);
			return stringBuilder.ToString();
		}

		public static TfsProviderOptions Deserialize(string parameters)
		{
			if (string.IsNullOrEmpty(parameters)) return new TfsProviderOptions();
			TfsProviderOptions options;
			using (var reader = new StringReader(parameters))
			{
				options = new XmlSerializer(typeof (TfsProviderOptions)).Deserialize(reader) as TfsProviderOptions;
				if (options == null) throw new ArgumentException("Invalid parameters string.", parameters);
			}
			return options;
		}
	}
}