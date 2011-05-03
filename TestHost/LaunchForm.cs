using System;
using System.Windows.Forms;
using TurtleTfs.Forms;

namespace TestHost
{
	public partial class LaunchForm : Form
	{
		public LaunchForm()
		{
			InitializeComponent();
		}

		private void launchIssueBrowserButton_Click(object sender, EventArgs e)
		{
			sampleCommentBox.Text = FormLauncher.LaunchIssueBrowserForm(optionsTextBox.Text, sampleCommentBox.Text);
		}

		private void launchOptionsButton_Click(object sender, EventArgs e)
		{
			optionsTextBox.Text = FormLauncher.LaunchOptionsForm(optionsTextBox.Text);
		}
	}
}