namespace TestHost
{
	partial class LaunchForm
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
			this.launchIssueBrowserButton = new System.Windows.Forms.Button();
			this.sampleCommentBox = new System.Windows.Forms.TextBox();
			this.launchOptionsButton = new System.Windows.Forms.Button();
			this.optionsTextBox = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// launchIssueBrowserButton
			// 
			this.launchIssueBrowserButton.Location = new System.Drawing.Point(225, 13);
			this.launchIssueBrowserButton.Name = "launchIssueBrowserButton";
			this.launchIssueBrowserButton.Size = new System.Drawing.Size(102, 23);
			this.launchIssueBrowserButton.TabIndex = 0;
			this.launchIssueBrowserButton.Text = "Issue Browser";
			this.launchIssueBrowserButton.UseVisualStyleBackColor = true;
			this.launchIssueBrowserButton.Click += new System.EventHandler(this.launchIssueBrowserButton_Click);
			// 
			// sampleCommentBox
			// 
			this.sampleCommentBox.Location = new System.Drawing.Point(13, 13);
			this.sampleCommentBox.Name = "sampleCommentBox";
			this.sampleCommentBox.Size = new System.Drawing.Size(206, 20);
			this.sampleCommentBox.TabIndex = 1;
			this.sampleCommentBox.Text = "Some comment";
			// 
			// launchOptionsButton
			// 
			this.launchOptionsButton.Location = new System.Drawing.Point(225, 43);
			this.launchOptionsButton.Name = "launchOptionsButton";
			this.launchOptionsButton.Size = new System.Drawing.Size(102, 23);
			this.launchOptionsButton.TabIndex = 2;
			this.launchOptionsButton.Text = "Options";
			this.launchOptionsButton.UseVisualStyleBackColor = true;
			this.launchOptionsButton.Click += new System.EventHandler(this.launchOptionsButton_Click);
			// 
			// optionsTextBox
			// 
			this.optionsTextBox.Location = new System.Drawing.Point(13, 45);
			this.optionsTextBox.Name = "optionsTextBox";
			this.optionsTextBox.Size = new System.Drawing.Size(206, 20);
			this.optionsTextBox.TabIndex = 3;
			// 
			// LaunchForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(339, 145);
			this.Controls.Add(this.optionsTextBox);
			this.Controls.Add(this.launchOptionsButton);
			this.Controls.Add(this.sampleCommentBox);
			this.Controls.Add(this.launchIssueBrowserButton);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.MaximizeBox = false;
			this.Name = "LaunchForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "LaunchForm";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button launchIssueBrowserButton;
		private System.Windows.Forms.TextBox sampleCommentBox;
		private System.Windows.Forms.Button launchOptionsButton;
		private System.Windows.Forms.TextBox optionsTextBox;
	}
}