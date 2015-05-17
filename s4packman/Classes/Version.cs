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

namespace s4packman
{
	/// <summary>
	/// Description of Struct1.
	/// </summary>
	public class Version
	{
		private UInt32 _Major;
		private UInt32 _Minor;
		
		public UInt32 Major
		{
			get{ return _Major; }
			set{ _Major = value; }
		}
		
		public UInt32 Minor
		{
			get{ return _Minor; }
			set{ _Minor = value; }
		}
			
		public override string ToString()
		{
			string s = String.Format("{0}.{1}", _Major, _Minor);
			return s;
		}
	}
}
