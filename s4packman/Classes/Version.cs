/*
 * Created by SharpDevelop.
 * User: Timothy
 * Date: 5/13/2015
 * Time: 1:44 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
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
