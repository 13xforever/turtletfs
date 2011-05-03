namespace TurtleTfs.Forms
{
	partial class IssuesBrowser
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.buttonOk = new System.Windows.Forms.Button();
			this.buttonCancel = new System.Windows.Forms.Button();
			this.listViewIssues = new System.Windows.Forms.ListView();
			this.checkBoxColumn = new System.Windows.Forms.ColumnHeader();
			this.typeColumn = new System.Windows.Forms.ColumnHeader();
			this.idColumn = new System.Windows.Forms.ColumnHeader();
			this.stateColumn = new System.Windows.Forms.ColumnHeader();
			this.titleColumn = new System.Windows.Forms.ColumnHeader();
			this.commentBox = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.queryComboBox = new System.Windows.Forms.ComboBox();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// buttonOk
			// 
			this.buttonOk.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.buttonOk.DialogResult = System.Windows.Forms.DialogResult.OK;
			this.buttonOk.Location = new System.Drawing.Point(680, 479);
			this.buttonOk.Name = "buttonOk";
			this.buttonOk.Size = new System.Drawing.Size(46, 23);
			this.buttonOk.TabIndex = 2;
			this.buttonOk.Text = "OK";
			this.buttonOk.UseVisualStyleBackColor = true;
			this.buttonOk.Click += new System.EventHandler(this.okButton_Click);
			// 
			// buttonCancel
			// 
			this.buttonCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.buttonCancel.Location = new System.Drawing.Point(732, 479);
			this.buttonCancel.Name = "buttonCancel";
			this.buttonCancel.Size = new System.Drawing.Size(75, 23);
			this.buttonCancel.TabIndex = 3;
			this.buttonCancel.Text = "Cancel";
			this.buttonCancel.UseVisualStyleBackColor = true;
			// 
			// listViewIssues
			// 
			this.listViewIssues.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
						| System.Windows.Forms.AnchorStyles.Left)
						| System.Windows.Forms.AnchorStyles.Right)));
			this.listViewIssues.CheckBoxes = true;
			this.listViewIssues.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.checkBoxColumn,
            this.typeColumn,
            this.idColumn,
            this.stateColumn,
            this.titleColumn});
			this.listViewIssues.FullRowSelect = true;
			this.listViewIssues.Location = new System.Drawing.Point(12, 53);
			this.listViewIssues.Name = "listViewIssues";
			this.listViewIssues.Size = new System.Drawing.Size(795, 286);
			this.listViewIssues.TabIndex = 0;
			this.listViewIssues.UseCompatibleStateImageBehavior = false;
			this.listViewIssues.View = System.Windows.Forms.View.Details;
			this.listViewIssues.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.listViewIssues_ColumnClick);
			// 
			// checkBoxColumn
			// 
			this.checkBoxColumn.Text = "";
			this.checkBoxColumn.Width = 23;
			// 
			// typeColumn
			// 
			this.typeColumn.DisplayIndex = 2;
			this.typeColumn.Text = "Type";
			this.typeColumn.Width = 64;
			// 
			// idColumn
			// 
			this.idColumn.DisplayIndex = 1;
			this.idColumn.Text = "ID";
			this.idColumn.Width = 54;
			// 
			// stateColumn
			// 
			this.stateColumn.Text = "State";
			this.stateColumn.Width = 102;
			// 
			// titleColumn
			// 
			this.titleColumn.Text = "Title";
			this.titleColumn.Width = 527;
			// 
			// commentBox
			// 
			this.commentBox.AcceptsReturn = true;
			this.commentBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
						| System.Windows.Forms.AnchorStyles.Right)));
			this.commentBox.Location = new System.Drawing.Point(12, 370);
			this.commentBox.Multiline = true;
			this.commentBox.Name = "commentBox";
			this.commentBox.Size = new System.Drawing.Size(795, 103);
			this.commentBox.TabIndex = 1;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(13, 13);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(38, 13);
			this.label1.TabIndex = 4;
			this.label1.Text = "Query:";
			// 
			// queryComboBox
			// 
			this.queryComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
						| System.Windows.Forms.AnchorStyles.Right)));
			this.queryComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.queryComboBox.FormattingEnabled = true;
			this.queryComboBox.Location = new System.Drawing.Point(58, 10);
			this.queryComboBox.Name = "queryComboBox";
			this.queryComboBox.Size = new System.Drawing.Size(749, 21);
			this.queryComboBox.TabIndex = 4;
			this.queryComboBox.SelectedValueChanged += new System.EventHandler(this.queryComboBox_SelectedValueChanged);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(13, 37);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(64, 13);
			this.label2.TabIndex = 7;
			this.label2.Text = "Work Items:";
			// 
			// label3
			// 
			this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(9, 354);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(54, 13);
			this.label3.TabIndex = 8;
			this.label3.Text = "Comment:";
			// 
			// IssuesBrowser
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(819, 514);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.queryComboBox);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.commentBox);
			this.Controls.Add(this.listViewIssues);
			this.Controls.Add(this.buttonCancel);
			this.Controls.Add(this.buttonOk);
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "IssuesBrowser";
			this.ShowIcon = false;
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "IssuesBrowser";
			this.Load += new System.EventHandler(this.MyIssuesForm_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button buttonOk;
		private System.Windows.Forms.Button buttonCancel;
		private System.Windows.Forms.ListView listViewIssues;
		private System.Windows.Forms.TextBox commentBox;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.ComboBox queryComboBox;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.ColumnHeader checkBoxColumn;
		private System.Windows.Forms.ColumnHeader idColumn;
		private System.Windows.Forms.ColumnHeader typeColumn;
		private System.Windows.Forms.ColumnHeader stateColumn;
		private System.Windows.Forms.ColumnHeader titleColumn;
	}
}