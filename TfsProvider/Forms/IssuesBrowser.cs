using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Microsoft.TeamFoundation.Client;
using Microsoft.TeamFoundation.WorkItemTracking.Client;

namespace TurtleTfs.Forms
{
	public partial class IssuesBrowser : Form
	{
		private readonly List<MyWorkItem> associatedWorkItems = new List<MyWorkItem>();
		private readonly ListViewColumnSorter listViewColumnSorter;
		private readonly TfsProviderOptions options;
		private TeamFoundationServer tfs;
		private WorkItemStore workItemStore;

		public IssuesBrowser(string parameters, string comment)
		{
			InitializeComponent();
			Comment = comment;
			options = TfsOptionsSerializer.Deserialize(parameters);

			ColumnHeader idColumnHeader = listViewIssues.Columns.Cast<ColumnHeader>().FirstOrDefault(header => header.Name == "ID");
			int idColumnIndex = idColumnHeader == null ? 2 : idColumnHeader.Index;
			listViewColumnSorter = new ListViewColumnSorter(idColumnIndex);
			listViewIssues.ListViewItemSorter = listViewColumnSorter;
		}

		public string Comment { get { return commentBox.Text; } private set { commentBox.Text = value; } }

		public string AssociatedWorkItems
		{
			get
			{
				var result = new StringBuilder();
				foreach (var workItem in associatedWorkItems) result.AppendFormat("{0} {1}: {2}\n", workItem.type, workItem.id, workItem.title);
				return result.ToString();
			}
		}

		private WorkItemStore ConnectToTfs()
		{
			tfs = TeamFoundationServerFactory.GetServer(options.ServerName);
			tfs.EnsureAuthenticated();
			return (WorkItemStore) tfs.GetService(typeof (WorkItemStore));
		}

		private IEnumerable<MyWorkItem> GetWorkItems(TfsQuery query)
		{
			var context = new Dictionary<string, string> {{"project", query.Query.Project.Name}};
			return (from WorkItem workItem in workItemStore.Query(query.Query.QueryText, context)
					select new MyWorkItem(workItem.Id, workItem.State, workItem.Title, workItem.Type.Name)
					).ToList();
		}

		private void PopulateComboBoxWithSavedQueries(ComboBox comboBox)
		{
			Project project = workItemStore.Projects[options.ProjectName];
			StoredQueryCollection storedQueries = project.StoredQueries;
			foreach (StoredQuery query in storedQueries) comboBox.Items.Add(new TfsQuery(query));
			if (comboBox.Items.Count > 0) comboBox.SelectedIndex = 0;
		}

		private void MyIssuesForm_Load(object sender, EventArgs e)
		{
			workItemStore = ConnectToTfs();
			PopulateComboBoxWithSavedQueries(queryComboBox);
		}

		private void PopulateWorkItemsList(ListView listView, TfsQuery query)
		{
			listView.Items.Clear();
			IEnumerable<MyWorkItem> workItems = GetWorkItems(query);
			foreach (var workItem in workItems)
			{
				var lvi = new ListViewItem {Text = "", Tag = workItem,};
				lvi.SubItems.Add(workItem.type);
				lvi.SubItems.Add(workItem.id.ToString());
				lvi.SubItems.Add(workItem.state);
				lvi.SubItems.Add(workItem.title);
				listView.Items.Add(lvi);
			}
			foreach (ColumnHeader column in listViewIssues.Columns) column.Width = -1;
		}

		private void okButton_Click(object sender, EventArgs e)
		{
			foreach (ListViewItem lvi in listViewIssues.Items.Cast<ListViewItem>().Where(lvi => lvi.Checked))
				associatedWorkItems.Add((MyWorkItem)lvi.Tag);
		}

		private void queryComboBox_SelectedValueChanged(object sender, EventArgs e)
		{
			PopulateWorkItemsList(listViewIssues, (TfsQuery) queryComboBox.SelectedItem);
		}

		private void listViewIssues_ColumnClick(object sender, ColumnClickEventArgs e)
		{
			if (e.Column == listViewColumnSorter.SortColumn)
				listViewColumnSorter.InvertOrder();
			else
			{
				listViewColumnSorter.SortColumn = e.Column;
				listViewColumnSorter.Order = SortOrder.Ascending;
			}
			listViewIssues.Sort();
		}
	}

	internal class TfsQuery
	{
		public TfsQuery(StoredQuery query)
		{
			Query = query;
			Name = query.Name;
		}

		private string Name { get; set; }
		public StoredQuery Query { get; private set; }

		public override string ToString()
		{
			return Name;
		}
	}

	public struct MyWorkItem
	{
		public MyWorkItem(int id, string state, string title, string type)
		{
			this.id = id;
			this.state = state;
			this.title = title;
			this.type = type;
		}

		public int id;
		public string state;
		public string title;
		public string type;
	}
}