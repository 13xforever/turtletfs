using System.Collections;
using System.Windows.Forms;

namespace TurtleTfs
{
	public class ListViewColumnSorter: IComparer
	{
		private readonly int numericalColumn;
		private readonly NumericalComparer ObjectCompareAsNumbers;
		private readonly CaseInsensitiveComparer ObjectCompareAsText;

		public ListViewColumnSorter(int numericalColumn)
		{
			this.numericalColumn = numericalColumn;
			SortColumn = numericalColumn;
			Order = SortOrder.None;
			ObjectCompareAsText = new CaseInsensitiveComparer();
			ObjectCompareAsNumbers = new NumericalComparer();
		}

		public int SortColumn { get; set; }
		public SortOrder Order { set; private get; }

		#region IComparer Members

		public int Compare(object x, object y)
		{
			var itemX = (ListViewItem)x;
			var itemY = (ListViewItem)y;

			IComparer currentComparer = SortColumn == numericalColumn ? ObjectCompareAsNumbers : (IComparer)ObjectCompareAsText;
			int compareResult = currentComparer.Compare(itemX.SubItems[SortColumn].Text, itemY.SubItems[SortColumn].Text);

			if (Order == SortOrder.Ascending) return compareResult;
			if (Order == SortOrder.Descending) return -compareResult;
			return 0;
		}

		#endregion

		public void InvertOrder()
		{
			Order = Order == SortOrder.Ascending ? SortOrder.Descending : SortOrder.Ascending;
		}
	}

	internal class NumericalComparer: IComparer
	{
		#region IComparer Members

		public int Compare(object x, object y)
		{
			long longX = long.Parse((string)x);
			long longY = long.Parse((string)y);

			if (longX < longY) return -1;
			if (longX > longY) return 1;
			return 0;
		}

		#endregion
	}
}