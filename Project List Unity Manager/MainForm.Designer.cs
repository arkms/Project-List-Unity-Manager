/*
 * Created by SharpDevelop.
 * User: Arkms
 * Date: 18/12/2013
 * Time: 7:08
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Project_List_Unity_Manager
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			this.button1 = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.ListProjectsBox = new System.Windows.Forms.CheckedListBox();
			this.SuspendLayout();
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(138, 227);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(105, 41);
			this.button1.TabIndex = 0;
			this.button1.Text = "Delete";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.Button1Click);
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(12, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(231, 36);
			this.label1.TabIndex = 2;
			this.label1.Text = "Made by ARKMs";
			// 
			// ListProjectsBox
			// 
			this.ListProjectsBox.CheckOnClick = true;
			this.ListProjectsBox.FormattingEnabled = true;
			this.ListProjectsBox.Location = new System.Drawing.Point(13, 49);
			this.ListProjectsBox.Name = "ListProjectsBox";
			this.ListProjectsBox.Size = new System.Drawing.Size(385, 169);
			this.ListProjectsBox.TabIndex = 3;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(410, 305);
			this.Controls.Add(this.ListProjectsBox);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.button1);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "MainForm";
			this.Text = "Project List Unity Manager v5";
			this.ResumeLayout(false);

		}
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.CheckedListBox ListProjectsBox;
	}
}
