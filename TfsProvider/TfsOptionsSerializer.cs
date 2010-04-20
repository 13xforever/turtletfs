using System;
using System.IO;
using System.Text;
using System.Xml;
using System.Xml.Serialization;

namespace TsvnTfsProvider
{
	public static class TfsOptionsSerializer
	{
		public static string Serialize(TfsProviderOptions options)
		{
			var stringBuilder = new StringBuilder();
			var settings = new XmlWriterSettings
			               	{
			               		ConformanceLevel = ConformanceLevel.Auto,
			               		Encoding = Encoding.UTF8,
			               		Indent = false,
			               		NewLineOnAttributes = false,
			               		OmitXmlDeclaration = true,
			               	};
			using (var writer = XmlWriter.Create(stringBuilder, settings))
			{
				if (writer == null) throw new OperationCanceledException("Cannot serialize options.");
				new XmlSerializer(typeof (TfsProviderOptions)).Serialize(writer, options);
			}
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