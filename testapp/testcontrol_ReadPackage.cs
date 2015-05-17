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

using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using s4packman;
using System.IO;

namespace testapp
{
	/// <summary>
	/// Description of testcontrol_ReadPackage.
	/// </summary>
	public partial class testcontrol_ReadPackage : UserControl
	{
		private PackageData mcpd;
		private PackageReader mcpr;
		private string defaultpath;
		
		public testcontrol_ReadPackage()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			defaultpath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
			mcpr = new s4packman.PackageReader();
			mcpd = new s4packman.PackageData();
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		void Button_OpenPackageClick(object sender, EventArgs e)
		{
			
			openFileDialog1.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "Electronic Arts\\The Sims 4\\Mods";
			DialogResult dr_ofd = openFileDialog1.ShowDialog();
			if (dr_ofd == DialogResult.OK)
			{
                //string _filename = openFileDialog1.FileName;
                //UInt64 _filesize = _GetFileSizeBytes(openFileDialog1.FileName);
                //label_FileSizeCount.Text = _filesize.ToString();
                bool _isopen = mcpr.OpenPackage(openFileDialog1.FileName);
                if (_isopen)
                {
                    mcpd = mcpr.GetCurrentPackageInfo();

                    label_FileSizeCount.Text = mcpr.CurrentFileSize.ToString();

                    this.Parent.Text = this.Parent.Text + " - " + mcpr.CurrentFileName;

                    listview_PackageInfo.Items.Add("Magic Number").SubItems.Add(new string(mcpd.MagicNumber));
                    listview_PackageInfo.Items.Add("File Version").SubItems.Add(mcpd.FileVersion.ToString());
                    listview_PackageInfo.Items.Add("User Version").SubItems.Add(mcpd.UserVersion.ToString());
                    listview_PackageInfo.Items.Add("Created Time").SubItems.Add(mcpd.CreationTime.AsDateTime.ToString());
                    listview_PackageInfo.Items.Add("Updated Time").SubItems.Add(mcpd.UpdatedTime.AsDateTime.ToString());
                    listview_PackageInfo.Items.Add("Index Record Entry Count").SubItems.Add(mcpd.IndexRecordEntryCount.ToString());
                    listview_PackageInfo.Items.Add("Index Record Position Low").SubItems.Add(mcpd.IndexRecordPositionLow.ToString());
                    listview_PackageInfo.Items.Add("Index Record Size").SubItems.Add(mcpd.IndexRecordSize.ToString());
                    listview_PackageInfo.Items.Add("Index Record Position").SubItems.Add(mcpd.IndexRecordPosition.ToString());

                    label_PositionCount.Text = mcpr.PositionCounter.ToString();

                    MessageBox.Show("Current directory is:\n\n" + mcpr.CurrentDirectory);
                }
                else
                {
                    MessageBox.Show("Could not open file:\n\n" + openFileDialog1.FileName);
                }


			}
        }


	}
}

