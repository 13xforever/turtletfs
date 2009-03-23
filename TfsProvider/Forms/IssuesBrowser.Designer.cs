namespace TsvnTfsProvider
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
			this.SuspendLayout();
			// 
			// buttonOk
			// 
			this.buttonOk.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.buttonOk.DialogResult = System.Windows.Forms.DialogResult.OK;
			this.buttonOk.Location = new System.Drawing.Point(145, 227);
			this.buttonOk.Name = "buttonOk";
			this.buttonOk.Size = new System.Drawing.Size(46, 23);
			this.buttonOk.TabIndex = 0;
			this.buttonOk.Text = "OK";
			this.buttonOk.UseVisualStyleBackColor = true;
			this.buttonOk.Click += new System.EventHandler(this.okButton_Click);
			// 
			// buttonCancel
			// 
			this.buttonCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.buttonCancel.Location = new System.Drawing.Point(197, 227);
			this.buttonCancel.Name = "buttonCancel";
			this.buttonCancel.Size = new System.Drawing.Size(75, 23);
			this.buttonCancel.TabIndex = 1;
			this.buttonCancel.Text = "Cancel";
			this.buttonCancel.UseVisualStyleBackColor = true;
			// 
			// listViewIssues
			// 
			this.listViewIssues.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
						| System.Windows.Forms.AnchorStyles.Left)
						| System.Windows.Forms.AnchorStyles.Right)));
			this.listViewIssues.CheckBoxes = true;
			this.listViewIssues.FullRowSelect = true;
			this.listViewIssues.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
			this.listViewIssues.Location = new System.Drawing.Point(13, 13);
			this.listViewIssues.Name = "listViewIssues";
			this.listViewIssues.Size = new System.Drawing.Size(259, 208);
			this.listViewIssues.TabIndex = 2;
			this.listViewIssues.UseCompatibleStateImageBehavior = false;
			this.listViewIssues.View = System.Windows.Forms.View.Details;
			// 
			// IssuesBrowser
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(284, 262);
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

		}

		#endregion

		private System.Windows.Forms.Button buttonOk;
		private System.Windows.Forms.Button buttonCancel;
		private System.Windows.Forms.ListView listViewIssues;
	}
}