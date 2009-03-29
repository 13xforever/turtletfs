using System.Windows.Forms;

namespace TsvnTfsProvider.Forms
{
	public static class FormLauncher
	{
		public static string LaunchIssueBrowserForm(string parameters, string originalMessage)
		{
			var form = new IssuesBrowser(parameters, originalMessage);
			if (form.ShowDialog() != DialogResult.OK) return originalMessage;
			string result = form.AssociatedWorkItems;
			string comment = form.Comment.Trim();
			if (!string.IsNullOrEmpty(comment)) result += "\n\n" + comment;
			return result;
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