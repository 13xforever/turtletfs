using System;
using System.Runtime.InteropServices;

namespace Interop.BugTraqProvider
{
	[ComVisible(true), InterfaceType(ComInterfaceType.InterfaceIsIUnknown), Guid("298B927C-7220-423C-B7B4-6E241F00CD93")]
	public interface IBugTraqProvider
	{
		///	<summary>
		/// <para>A provider might need some parameters (e.g. a web service URL or a database connection string).
		///	This information is passed as a simple string. It's up to the individual provider to parse and
		///	validate it.</para>
		///	<para>The <c>ValidateParameters</c> method is called from the settings dialog. This allows the provider to check
		///	that the parameters are OK. The provider can do basic syntax checking, it can check that the server
		///	is reachable, or it can do nothing.</para>
		///	<para>If the provider needs to report a validation error, it should do this itself, using <paramref name="hParentWnd"/> as
		///	the parent of any displayed UI.</para>
		/// </summary>
		/// 
		/// <param name="hParentWnd">Parent window for any UI that needs to be displayed during validation.</param>
		/// <param name="parameters">The parameter string that needs to be validated.</param>
		/// <returns>Is the string valid?</returns>
		[return: MarshalAs(UnmanagedType.VariantBool)]
		bool ValidateParameters(IntPtr hParentWnd, [MarshalAs(UnmanagedType.BStr)] string parameters);

		///<summary>
		///In the commit dialog, the provider is accessed from a button. It needs to know what text to
		///display (e.g. "Choose Bug" or "Select Ticket").
		///</summary>
		/// 
		/// <param name="hParentWnd">Parent window for any (error) UI that needs to be displayed.</param>
		/// <param name="parameters">The parameter string, just in case you need to talk to your web service (e.g.) to find out what the correct text is.</param>
		/// <returns>What text do you want to display? Use the current thread locale.</returns>
		[return: MarshalAs(UnmanagedType.BStr)]
		string GetLinkText(IntPtr hParentWnd, [MarshalAs(UnmanagedType.BStr)] string parameters);

		/// <summary>
		/// Get the commit message. This would normally involve displaying a dialog with a list of the
		/// issues assigned to the current user.
		/// </summary>
		/// <param name="hParentWnd">Parent window for your provider's UI.</param>
		/// <param name="parameters">Parameters for your provider.</param>
		/// <param name="commonRoot">The common root of all paths that got committed.</param>
		/// <param name="pathList">All the paths that got committed.</param>
		/// <param name="originalMessage">The text already present in the commit message.
		/// Your provider should include this text in the new message, where appropriate.</param>
		/// <returns>The new text for the commit message. This replaces the original message.</returns>
		[return: MarshalAs(UnmanagedType.BStr)]
		string GetCommitMessage(IntPtr hParentWnd,
		                        [MarshalAs(UnmanagedType.BStr)] string parameters,
		                        [MarshalAs(UnmanagedType.BStr)] string commonRoot,
		                        [MarshalAs(UnmanagedType.SafeArray, SafeArraySubType = VarEnum.VT_BSTR)] string[] pathList,
		                        [MarshalAs(UnmanagedType.BStr)] string originalMessage);
	}

	[ComVisible(true), InterfaceType(ComInterfaceType.InterfaceIsIUnknown), Guid("C5C85E31-2F9B-4916-A7BA-8E27D481EE83")]
	public interface IBugTraqProvider2: IBugTraqProvider
	{
		[return: MarshalAs(UnmanagedType.VariantBool)]
		new bool ValidateParameters(IntPtr hParentWnd, [MarshalAs(UnmanagedType.BStr)] string parameters);

		[return: MarshalAs(UnmanagedType.BStr)]
		new string GetLinkText(IntPtr hParentWnd, [MarshalAs(UnmanagedType.BStr)] string parameters);

		[return: MarshalAs(UnmanagedType.BStr)]
		new string GetCommitMessage(IntPtr hParentWnd,
		                            [MarshalAs(UnmanagedType.BStr)] string parameters,
		                            [MarshalAs(UnmanagedType.BStr)] string commonRoot,
		                            [MarshalAs(UnmanagedType.SafeArray, SafeArraySubType = VarEnum.VT_BSTR)] string[] pathList,
		                            [MarshalAs(UnmanagedType.BStr)] string originalMessage);

		/// <summary>
		/// <para>Get the commit message. This would normally involve displaying a dialog with a list of the
		/// issues assigned to the current user.</para>
		/// <para>You can assign custom revision properties to a commit by setting the <paramref name="bugID"/> and <paramref name="bugIDOut"/> params.</para>
		/// <para><strong>Note</strong>: both <paramref name="revPropNames"/> and <paramref name="revPropValues"/> must be of the same length.
		/// For every property name there must be a property value!</para>
		/// </summary>
		/// <param name="hParentWnd">Parent window for your provider's UI.</param>
		/// <param name="parameters">Parameters for your provider.</param>
		/// <param name="commonURL">The common url of the commit</param>
		/// <param name="commonRoot">The common root of all paths that got committed.</param>
		/// <param name="pathList">All the paths that got committed.</param>
		/// <param name="originalMessage">The text already present in the commit message.
		/// Your provider should include this text in the new message, where appropriate.</param>
		/// <param name="bugID">The content of the bugID field (if shown)</param>
		/// <param name="bugIDOut">Modified content of the bugID field</param>
		/// <param name="revPropNames">A list of revision property names which are applied to the commit</param>
		/// <param name="revPropValues">A list of revision property values which are applied to the commit</param>
		/// <returns>The new text for the commit message. This replaces the original message.</returns>
		[return: MarshalAs(UnmanagedType.BStr)]
		string GetCommitMessage2(IntPtr hParentWnd,
		                         [MarshalAs(UnmanagedType.BStr)] string parameters,
		                         [MarshalAs(UnmanagedType.BStr)] string commonURL,
		                         [MarshalAs(UnmanagedType.BStr)] string commonRoot,
		                         [MarshalAs(UnmanagedType.SafeArray, SafeArraySubType = VarEnum.VT_BSTR)] string[] pathList,
		                         [MarshalAs(UnmanagedType.BStr)] string originalMessage,
		                         [MarshalAs(UnmanagedType.BStr)] string bugID,
		                         [MarshalAs(UnmanagedType.BStr)] out string bugIDOut,
		                         [MarshalAs(UnmanagedType.SafeArray, SafeArraySubType = VarEnum.VT_BSTR)] out string[] revPropNames,
		                         [MarshalAs(UnmanagedType.SafeArray, SafeArraySubType = VarEnum.VT_BSTR)] out string[] revPropValues);

		/// <summary>
		/// Called right before the commit dialog is dismissed. This is the last chance to reject
		/// a commit. You can check the commit log message here and return an error message if it does not
		/// match your specification. An empty error string means the commit is allowed.
		/// </summary>
		/// <param name="hParentWnd"></param>
		/// <param name="parameters"></param>
		/// <param name="commonURL">The common url of the commit</param>
		/// <param name="commonRoot">The common root of all paths that got committed.</param>
		/// <param name="pathList">All the paths that got committed.</param>
		/// <param name="commitMessage"></param>
		/// <returns></returns>
		[return: MarshalAs(UnmanagedType.BStr)]
		string CheckCommit(IntPtr hParentWnd,
		                   [MarshalAs(UnmanagedType.BStr)] string parameters,
		                   [MarshalAs(UnmanagedType.BStr)] string commonURL,
		                   [MarshalAs(UnmanagedType.BStr)] string commonRoot,
		                   [MarshalAs(UnmanagedType.SafeArray, SafeArraySubType = VarEnum.VT_BSTR)] string[] pathList,
		                   [MarshalAs(UnmanagedType.BStr)] string commitMessage);

		/// <summary>
		/// 
		/// </summary>
		/// <param name="hParentWnd">Parent window for any (error) UI that needs to be displayed.</param>
		/// <param name="commonRoot">The common root of all paths that got committed.</param>
		/// <param name="pathList">All the paths that got committed.</param>
		/// <param name="logMessage">The text already present in the commit message.</param>
		/// <param name="revision">The revision of the commit.</param>
		/// <returns>An error to show to the user if this function returns something else than S_OK</returns>
		[return: MarshalAs(UnmanagedType.BStr)]
		string OnCommitFinished(
			IntPtr hParentWnd,
			[MarshalAs(UnmanagedType.BStr)] string commonRoot,
			[MarshalAs(UnmanagedType.SafeArray, SafeArraySubType = VarEnum.VT_BSTR)] string[] pathList,
			[MarshalAs(UnmanagedType.BStr)] string logMessage,
			[MarshalAs(UnmanagedType.U4)] int revision);

		/// <summary>
		/// Whether the provider provides options
		/// </summary>
		/// <returns></returns>
		[return: MarshalAs(UnmanagedType.VariantBool)]
		bool HasOptions();

		/// <summary>
		/// This method is called if HasOptions() returned true before.
		/// Use this to show a custom dialog so the user doesn't have to
		/// create the parameters string manually
		/// </summary>
		/// <param name="hParentWnd">Parent window for the options dialog</param>
		/// <param name="parameters">Parameters for your provider.</param>
		/// <returns>The parameters string</returns>
		[return: MarshalAs(UnmanagedType.BStr)]
		string ShowOptionsDialog(IntPtr hParentWnd,[MarshalAs(UnmanagedType.BStr)] string parameters);
	}
}