/*
 * Created by SharpDevelop.
 * User: Timothy
 * Date: 5/13/2015
 * Time: 3:08 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace s4packman
{
	/// <summary>
	/// Description of Time.
	/// </summary>
	public class Time
	{
		private UInt32 _time_t;
		private System.DateTime _datetime;
        private Helpers _helpers;
		
		public UInt32 AsTime_T
		{
			get{ return _time_t; }
			set
            {
                _time_t = value;
                _datetime = _helpers.Time_tToDateTime(_time_t);
            }
		}

        public DateTime AsDateTime
        {
            get { return _datetime; }
        }

        public enum TimeType
        {
            DateTimeFormat = 0x01,
            Time_TFormat = 0x02
        }

        public Time()
        {
            _helpers = new Helpers();
        }
	}
}
