/*
 * s4packman.dll
 * A .NET class library to read and modify .package files for The Sims 4 by Electronic Arts.
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
