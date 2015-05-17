/*
 * Created by SharpDevelop.
 * User: Timothy
 * Date: 5/10/2015
 * Time: 1:11 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace testapp
{
	partial class form_Main
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
			this.testcontrol_ReadPackage1 = new testapp.testcontrol_ReadPackage();
			this.SuspendLayout();
			// 
			// testcontrol_ReadPackage1
			// 
			this.testcontrol_ReadPackage1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.testcontrol_ReadPackage1.Location = new System.Drawing.Point(0, 0);
			this.testcontrol_ReadPackage1.Name = "testcontrol_ReadPackage1";
			this.testcontrol_ReadPackage1.Size = new System.Drawing.Size(806, 431);
			this.testcontrol_ReadPackage1.TabIndex = 0;
			// 
			// form_Main
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(806, 431);
			this.Controls.Add(this.testcontrol_ReadPackage1);
			this.Name = "form_Main";
			this.Text = "Testapp";
			this.ResumeLayout(false);
		}
		private testapp.testcontrol_ReadPackage testcontrol_ReadPackage1;
	}
}
