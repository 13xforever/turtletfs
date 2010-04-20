using System;
using System.Windows.Forms;
using Microsoft.TeamFoundation.Client;
using Microsoft.TeamFoundation.WorkItemTracking.Client;

namespace TsvnTfsProvider.Forms
{
	public partial class Options : Form
	{
		private readonly TfsProviderOptions options;

		public Options(string parameters)
		{
			InitializeComponent();
			Parameters = parameters;
			options = TfsOptionsSerializer.Deserialize(parameters);
			tfsAddressTextBox.Text = options.ServerName;
		}

		public string Parameters { get; private set; }

		private void okButton_Click(object sender, EventArgs e)
		{
			options.ServerName = tfsAddressTextBox.Text;
			options.ProjectName = projectComboBox.Text;
			Parameters = TfsOptionsSerializer.Serialize(options);
		}

		private void Options_Load(object sender, EventArgs e)
		{
			PopulateProjectNameComboBox();
		}

		private void PopulateProjectNameComboBox()
		{
			string url = tfsAddressTextBox.Text;
			if (!Uri.IsWellFormedUriString(url, UriKind.Absolute)) return;
			var tfs = TeamFoundationServerFactory.GetServer(url);
			tfs.EnsureAuthenticated();
			var workItemStore = (WorkItemStore)tfs.GetService(typeof (WorkItemStore));
			projectComboBox.Items.Clear();
			foreach (Project project in workItemStore.Projects) projectComboBox.Items.Add(project.Name);
			int existingProjectIndex = -1;
			if (!string.IsNullOrEmpty(options.ProjectName))
				existingProjectIndex = projectComboBox.Items.IndexOf(options.ProjectName);
			projectComboBox.SelectedIndex = existingProjectIndex > 0 ? existingProjectIndex : 0;
		}

		private void refreshProjectsButton_Click(object sender, EventArgs e)
		{
			PopulateProjectNameComboBox();
		}
	}
}