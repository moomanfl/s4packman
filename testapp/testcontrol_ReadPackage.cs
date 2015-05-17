/*
 * Created by SharpDevelop.
 * User: Timothy
 * Date: 5/11/2015
 * Time: 11:20 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
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

