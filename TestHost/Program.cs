﻿using System;
using System.Windows.Forms;
using TsvnTfsProvider;

namespace TestHost
{
	internal static class Program
	{
		[STAThread]
		private static void Main()
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Application.Run(new IssuesBrowser("some comment"));
		}
	}
}