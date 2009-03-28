using System;
using System.Runtime.InteropServices;
using Interop.BugTraqProvider;
using TsvnTfsProvider.Forms;

namespace TsvnTfsProvider
{
	[ComVisible(true), Guid("75971BA7-A422-4100-89E4-79E9FC56C699"), ClassInterface(ClassInterfaceType.None)]
	public class TfsProvider : IBugTraqProvider2
	{
		#region IBugTraqProvider2 Members

		public bool ValidateParameters(IntPtr hParentWnd, string parameters)
		{
			bool result = true;
			try
			{
				TfsOptionsSerializer.Deserialize(parameters);
			}
			catch
			{
				result = false;
			}
			return result;
		}

		public string GetLinkText(IntPtr hParentWnd, string parameters)
		{
			return "Work Items";
		}

		public string GetCommitMessage(IntPtr hParentWnd, string parameters, string commonRoot, string[] pathList, string originalMessage)
		{
			return FormLauncher.LaunchIssueBrowserForm(parameters, originalMessage);
		}

		public string GetCommitMessage2(IntPtr hParentWnd, string parameters, string commonURL, string commonRoot, string[] pathList, string originalMessage,
		                                string bugID, out string bugIDOut, out string[] revPropNames, out string[] revPropValues)
		{
			bugIDOut = bugID;
			revPropNames = new string[] {};
			revPropValues = new string[] {};
			return FormLauncher.LaunchIssueBrowserForm(parameters, originalMessage);
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
			return true;
		}

		public string ShowOptionsDialog(IntPtr hParentWnd, string parameters)
		{
			return FormLauncher.LaunchOptionsForm(parameters);
		}

		#endregion
	}
}