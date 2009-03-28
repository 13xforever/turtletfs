using System.Text;
using System.Windows.Forms;

namespace TsvnTfsProvider.Forms
{
	public static class FormLauncher
	{
		public static string LaunchIssueBrowserForm(string parameters, string originalMessage)
		{
			var form = new IssuesBrowser(parameters, originalMessage);
			if (form.ShowDialog() != DialogResult.OK) return originalMessage;

			var result = new StringBuilder();
			if (originalMessage.Length != 0 && !originalMessage.EndsWith("\n")) result.AppendLine();

			foreach (var workItem in form.AssociatedWorkItems)
			{
				result.AppendFormat("{0} {1}: {2}", workItem.type, workItem.id, workItem.title);
				result.AppendLine();
			}
			result.AppendLine();
			result.AppendLine(form.Comment);

			return result.ToString();
		}

		public static string LaunchOptionsForm(string parameters)
		{
			if (string.IsNullOrEmpty(parameters)) parameters = TfsOptionsSerializer.Serialize(new TfsProviderOptions());
			var form = new Options(parameters);
			if (form.ShowDialog() != DialogResult.OK) return parameters;
			return form.Parameters;
		}
	}
}