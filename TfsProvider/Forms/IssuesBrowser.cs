using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace TsvnTfsProvider
{
	public partial class IssuesBrowser: Form
	{
		private readonly List<WorkItem> associatedWorkItems = new List<WorkItem>();
		private readonly IEnumerable<WorkItem> workItems;

		public IssuesBrowser()
		{
			InitializeComponent();
			workItems = GetWorkItems();
		}

		private static IEnumerable<WorkItem> GetWorkItems()
		{
			var myWorkItems = new List<WorkItem>()
			                  	{
			                  		new WorkItem() {type="bug", id = 1, title="some nasty bug"},
									new WorkItem() {type = "issue", id =2, title = "надо что-то сделать"}
			                  	};
			
			// calling TFS
			
			return myWorkItems;
		}

		public IEnumerable<WorkItem> AssociatedWorkItems
		{
			get { return associatedWorkItems; }
		}

		private void MyIssuesForm_Load(object sender, EventArgs e)
		{
			listViewIssues.Columns.Add("");
			listViewIssues.Columns.Add("Type");
			listViewIssues.Columns.Add("ID");
			listViewIssues.Columns.Add("Title");

			foreach (var workItem in workItems)
			{
				var lvi = new ListViewItem
				          	{
				          		Text = "",
				          		Tag = workItem,
				          	};
				lvi.SubItems.Add(workItem.type);
				lvi.SubItems.Add(workItem.id.ToString());
				lvi.SubItems.Add(workItem.title);
				listViewIssues.Items.Add(lvi);
			}

			listViewIssues.Columns[0].Width = -1;
			listViewIssues.Columns[1].Width = -1;
			listViewIssues.Columns[2].Width = -1;
			listViewIssues.Columns[3].Width = -1;
		}

		private void okButton_Click(object sender, EventArgs e)
		{
			foreach (ListViewItem lvi in listViewIssues.Items)
				if (lvi.Checked) associatedWorkItems.Add((WorkItem)lvi.Tag);
		}
	}

	public struct WorkItem
	{
		public string type;
		public int id;
		public string title;
	}
}