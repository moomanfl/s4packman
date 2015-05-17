/*
 * Created by SharpDevelop.
 * User: Timothy
 * Date: 5/13/2015
 * Time: 1:04 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.IO;

namespace s4packman
{
	/// <summary>
	/// Description of Helpers.
	/// </summary>
	public class Helpers
	{
		public Helpers()
		{
			
		}
		
		public System.DateTime Time_tToDateTime(UInt32 tTime)
		{
 			return  new System.DateTime(1970,1,1).AddSeconds(tTime);
		}
		
		public static byte[] ReverseByteArray(byte[] array1)
		{
			
			byte[] array2;
			array2 = new Byte[array1.Length];
			
			for (int i = 0; i < array1.Length; i++)
			{
				array2[(array1.Length - 1) - i] = array1[i];
			}
			
			return array2;
		}

        private UInt64 _GetFileSizeBytes(string filepath)
        {
            FileInfo _fileinfo = new FileInfo(filepath);
            return Convert.ToUInt64(_fileinfo.Length);
        }
	}
}
