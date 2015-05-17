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
