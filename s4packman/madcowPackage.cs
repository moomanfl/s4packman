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
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace s4packman
{
	/// <summary>
	/// Description of PackageReader.
	/// </summary>
	public class PackageReader
    {
        #region Private Variables

        private UInt64 _positioncounter     = 0; //private for property - keeps track of current byte position in the .package file for BitReader EOF and progress u_currentpackagedataates.

        private string _currentfilename     = ""; //private for property - keeps track of current open file name.

        private string _currentdirectory    = ""; //private for property - directory that contains the currently open .package file.

        private UInt64 _currentfilesize     = 0; //private for property - keeps track of the current open .package file's size in bytes.

        private bool _isopen                = false; //private for property - is the file open?

        private Stream _currentfilestream; // Internal property - reference to the Stream for the current open .package file.

        private PackageHeader _packageheader; // most likely to be consolodated into _currentpackagedata once it is reorganized by subclassing.

        private PackageData _currentpackagedata; //private for property to expose a reference to the package data of the current open .package file.

        #endregion

        #region Public Properties

        //Current byte position within the .package file being read.
        public UInt64 PositionCounter
        { get { return _positioncounter; } }

        //File name of the currently open .package file.
        public String CurrentFileName
        { get { return _currentfilename; } }

        //Directory of the currently open .package file.
        public String CurrentDirectory
        { get { return _currentdirectory; } }

        //File size in bytes of the currently open .package file.
        public UInt64 CurrentFileSize
        { get { return _currentfilesize; } }

        //Exposes the package data of the currently open package file to the calling program.
        public PackageData CurrentPackageData
        {
            get { return _currentpackagedata; }
        }

        #endregion

        #region Protected Properties

        //Internally expose the current filestream to all the other classes.
        protected Stream CurrentFileStream
        { get { return _currentfilestream; } }

        #endregion

        //Class constructor
        public PackageReader()
        {
           
        }

        //Starts the process of reading the package by opening the requested filepath specified and attempting to read it.
        //If the file doesn't exist the error will be trapped and false returned to the caller.
        public bool OpenPackage(string _filepath)
        {
            try // Give a go to opening the requested file.
            {

                // Open the file for retrieving general file information.
                FileInfo _fileinfo = new FileInfo(_filepath);

                // Get general info on the file and set the respective properties.
                _currentfilename = Path.GetFileName(_filepath);
                _currentdirectory = Path.GetDirectoryName(_filepath);
                _currentfilesize = Convert.ToUInt64(_fileinfo.Length); 
                _currentfilestream = new FileStream(_filepath, FileMode.Open);
                _isopen = true;

                // It was a success! Tell someone!
                return true;

            }
            catch //if there is an error then catch it and return false to the caller
            {

                //Ooops! Bummer!
                _isopen = false;
                return false;

            }
            
        }
		
        //Starts reading the package info (eg. file header and index headers).
        //TODO: verify that file is a valid package and return an error if it is not.
		public PackageData GetCurrentPackageInfo()
		{
            // This variable will be reused many times since the data will never be returned to the user.
			UInt32 _unuseddata32;

            // Get instance of PackageData() to set the property for the user.
			_currentpackagedata = new PackageData();

            // Open the file for binary access.
            BinaryReader br = new BinaryReader(CurrentFileStream);

            //Lets start reading the file!!!

			_currentpackagedata.MagicNumber = _ReadChars(br, 4);
			
			_currentpackagedata.FileVersion.Major = _ReadUInt32(br);
			_currentpackagedata.FileVersion.Minor = _ReadUInt32(br);

			_currentpackagedata.UserVersion.Major = _ReadUInt32(br);
			_currentpackagedata.UserVersion.Minor = _ReadUInt32(br);

			
			_unuseddata32 = _ReadUInt32(br);

            _currentpackagedata.CreationTime.AsTime_T = _ReadUInt32(br);
            _currentpackagedata.UpdatedTime.AsTime_T = _ReadUInt32(br);

            _unuseddata32 = _ReadUInt32(br);

            _currentpackagedata.IndexRecordEntryCount = _ReadUInt32(br);
            _currentpackagedata.IndexRecordPositionLow = _ReadUInt32(br);
            _currentpackagedata.IndexRecordSize = _ReadUInt32(br);

            //unused data block: 4 bytes
            for (int i = 0; i < 4; i++ )
            {
               _unuseddata32 = _ReadUInt32(br);
            }

            _currentpackagedata.IndexRecordPosition = _ReadUInt64(br);

            //unused data block: 6 bytes
            for (int i = 0; i < 6; i++)
            {
                _unuseddata32 = _ReadUInt32(br);
            }

               CurrentFileStream.Close();

			return _currentpackagedata;
		}
		
        protected UInt32 _ReadUInt32(BinaryReader br)
        {
            UInt32 _ui32;

            _ui32 = br.ReadUInt32();
            _positioncounter += 4;

            return _ui32;
        }

        protected UInt64 _ReadUInt64(BinaryReader br)
        {
            UInt64 _ui64;

            _ui64 = br.ReadUInt64();
            _positioncounter += 4;

            return _ui64;
        }

        protected char[] _ReadChars(BinaryReader br, int n)
        {
            char[] _ch = new char[n];

            _ch = br.ReadChars(n);
            _positioncounter += 4;

            return _ch;
        }

	}
}