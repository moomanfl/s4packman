/*
 * testapp.exe
 * A program to test progress and capabilities of the s4packman.dll class library.
 * 
 * Copyright (C) 2015  Timothy Browning
 * 
 * moomanfl@gmail.com
 * 
 * 2536 Anastasia Dr.
 * South Daytona, FL USA
 * 32119
 * 
 * This program is free software: you can redistribute it and/or modify
 * it under the terms of the GNU General Public License as published by
 * the Free Software Foundation, either version 3 of the License, or
 * (at your option) any later version.
 * 
 * This program is distributed in the hope that it will be useful,
 * but WITHOUT ANY WARRANTY; without even the implied warranty of
 * MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
 * GNU General Public License for more details.
 * 
 * You should have received a copy of the GNU General Public License
 * along with this program.  If not, see <http://www.gnu.org/licenses/>.
 */

namespace testapp
{
	partial class testcontrol_ReadPackage
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
		/// <summary>
		/// Disposes resources used by the control.
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
            this.listview_PackageInfo = new System.Windows.Forms.ListView();
            this.colheader_Type = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colheader_Value = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panel1 = new System.Windows.Forms.Panel();
            this.button_OpenPackage = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.label_Position = new System.Windows.Forms.Label();
            this.label_PositionCount = new System.Windows.Forms.Label();
            this.label_FileSizeCount = new System.Windows.Forms.Label();
            this.label_FileSize = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // listview_PackageInfo
            // 
            this.listview_PackageInfo.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colheader_Type,
            this.colheader_Value});
            this.listview_PackageInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listview_PackageInfo.GridLines = true;
            this.listview_PackageInfo.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.listview_PackageInfo.Location = new System.Drawing.Point(0, 0);
            this.listview_PackageInfo.Name = "listview_PackageInfo";
            this.listview_PackageInfo.Size = new System.Drawing.Size(286, 231);
            this.listview_PackageInfo.TabIndex = 1;
            this.listview_PackageInfo.UseCompatibleStateImageBehavior = false;
            this.listview_PackageInfo.View = System.Windows.Forms.View.Details;
            // 
            // colheader_Type
            // 
            this.colheader_Type.Text = "Type";
            this.colheader_Type.Width = 200;
            // 
            // colheader_Value
            // 
            this.colheader_Value.Text = "Value";
            this.colheader_Value.Width = 500;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label_FileSizeCount);
            this.panel1.Controls.Add(this.label_FileSize);
            this.panel1.Controls.Add(this.label_PositionCount);
            this.panel1.Controls.Add(this.label_Position);
            this.panel1.Controls.Add(this.button_OpenPackage);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 182);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(286, 49);
            this.panel1.TabIndex = 2;
            // 
            // button_OpenPackage
            // 
            this.button_OpenPackage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button_OpenPackage.Location = new System.Drawing.Point(176, 13);
            this.button_OpenPackage.Name = "button_OpenPackage";
            this.button_OpenPackage.Size = new System.Drawing.Size(96, 23);
            this.button_OpenPackage.TabIndex = 1;
            this.button_OpenPackage.Text = "Open Package";
            this.button_OpenPackage.UseVisualStyleBackColor = true;
            this.button_OpenPackage.Click += new System.EventHandler(this.Button_OpenPackageClick);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.DefaultExt = "package";
            this.openFileDialog1.Filter = "Package File|*.package";
            this.openFileDialog1.Title = "Open Sims 4 Package File";
            // 
            // label_Position
            // 
            this.label_Position.AutoSize = true;
            this.label_Position.Location = new System.Drawing.Point(3, 13);
            this.label_Position.Name = "label_Position";
            this.label_Position.Size = new System.Drawing.Size(47, 13);
            this.label_Position.TabIndex = 2;
            this.label_Position.Text = "Position:";
            // 
            // label_PositionCount
            // 
            this.label_PositionCount.AutoSize = true;
            this.label_PositionCount.Location = new System.Drawing.Point(48, 13);
            this.label_PositionCount.Name = "label_PositionCount";
            this.label_PositionCount.Size = new System.Drawing.Size(13, 13);
            this.label_PositionCount.TabIndex = 3;
            this.label_PositionCount.Text = "0";
            // 
            // label_FileSizeCount
            // 
            this.label_FileSizeCount.AutoSize = true;
            this.label_FileSizeCount.Location = new System.Drawing.Point(48, 26);
            this.label_FileSizeCount.Name = "label_FileSizeCount";
            this.label_FileSizeCount.Size = new System.Drawing.Size(13, 13);
            this.label_FileSizeCount.TabIndex = 5;
            this.label_FileSizeCount.Text = "0";
            // 
            // label_FileSize
            // 
            this.label_FileSize.AutoSize = true;
            this.label_FileSize.Location = new System.Drawing.Point(3, 26);
            this.label_FileSize.Name = "label_FileSize";
            this.label_FileSize.Size = new System.Drawing.Size(49, 13);
            this.label_FileSize.TabIndex = 4;
            this.label_FileSize.Text = "File Size:";
            // 
            // testcontrol_ReadPackage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.listview_PackageInfo);
            this.Name = "testcontrol_ReadPackage";
            this.Size = new System.Drawing.Size(286, 231);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

		}
		public System.Windows.Forms.OpenFileDialog openFileDialog1;
		private System.Windows.Forms.ColumnHeader colheader_Value;
		private System.Windows.Forms.ColumnHeader colheader_Type;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.ListView listview_PackageInfo;
		private System.Windows.Forms.Button button_OpenPackage;
        private System.Windows.Forms.Label label_FileSizeCount;
        private System.Windows.Forms.Label label_FileSize;
        private System.Windows.Forms.Label label_PositionCount;
        private System.Windows.Forms.Label label_Position;
	}
}
