using System;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;
using Interop.BugTraqProvider;

namespace TsvnTfsProvider
{
	[ComVisible(true), Guid("75971BA7-A422-4100-89E4-79E9FC56C699"), ClassInterface(ClassInterfaceType.None)]
	public class TfsProvider: IBugTraqProvider2
	{
		public bool ValidateParameters(IntPtr hParentWnd, string parameters)
		{
			return true;
		}

		public string GetLinkText(IntPtr hParentWnd, string parameters)
		{
			return "Work Items";
		}

		public string GetCommitMessage(IntPtr hParentWnd, string parameters, string commonRoot, string[] pathList, string originalMessage)
		{
			var form = new IssuesBrowser(originalMessage);
			if (form.ShowDialog() != DialogResult.OK) return originalMessage;

			var result = new StringBuilder(form.Comment);
			if (originalMessage.Length != 0 && !originalMessage.EndsWith("\n")) result.AppendLine();

			foreach (var workItem in form.AssociatedWorkItems)
			{
				result.AppendFormat("{0} {1}: {2}", workItem.type, workItem.id, workItem.title);
				result.AppendLine();
			}

			return result.ToString();
		}

		public string GetCommitMessage2(IntPtr hParentWnd, string parameters, string commonURL, string commonRoot, string[] pathList, string originalMessage,
		                                string bugID, out string bugIDOut, out string[] revPropNames, out string[] revPropValues)
		{
			bugIDOut = bugID;
			revPropNames = new string[] {};
			revPropValues = new string[] {};
			return GetCommitMessage(hParentWnd, parameters, commonRoot, pathList, originalMessage);
		}

		public string CheckCommit(IntPtr hParentWnd, string parameters, string commonURL, string commonRoot, string[] pathList, string commitMessage)
		{
			return string.Empty;
		}

		public string OnCommitFinished(IntPtr hParentWnd, string commonRoot, string[] pathList, string logMessage, int revision)
		{
			//спросить, надо ли пометить задачу Resolved
			return string.Empty;
		}

		public bool HasOptions()
		{
			return false;
		}

		public string ShowOptionsDialog(IntPtr hParentWnd, string parameters)
		{
			throw new NotImplementedException();
		}
	}
}