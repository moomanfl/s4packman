/*
 * Created by SharpDevelop.
 * User: Timothy
 * Date: 5/13/2015
 * Time: 12:59 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace s4packman
{
	/// <summary>
	/// This is the main class that formats the data in the package for return to the user.
	/// </summary>

	public class PackageData
	{
		private char[] _fileidentifier; // fileidentifier[4]
		
		private s4packman.Version _FileVersion;
		private s4packman.Version _UserVersion;

        private s4packman.Time _CreationTime;
        private s4packman.Time _UpdatedTime;


        private UInt32 _IndexRecordEntryCount;
        private UInt32 _IndexRecordPositionLow;
        private UInt32 _IndexRecordSize;
        private UInt64 _IndexRecordPosition;


//      EA struct info
//		
//		private UInt32[] unused5; //unused5[6]
//		
//								// 4 bytes. Must reverse byte order to get useable data.
//		private UInt32 flags;	// Will be parsed with bitwise operators into the Flags struct
//								// First 3 bits are used for the constantType, constantGroup, and constantInstanceEx.
//								// Remainder of 29 bits used for 'reserved'.
//								// Might be able to split the bits off using a modification of this code:
//								//
//								//	byte x = 0xA7;
//								//	byte nibble1 = (byte) (x & 0x0F);
//								//	byte nibble2 = (byte)((x & 0xF0) >> 4);
//								//
//								//	Or alternatively...
//								//
//								//	nibble2 = (byte)((x >> 4) & 0x0F);
//								//	byte original = (byte)((nibble2 << 4) | nibble1);
//		
//		private struct Flags
//		{
//			UInt32 constantType; // single bit
//		    UInt32 constantGroup;  // single bit
//		    UInt32 constantInstanceEx;  // single bit
//		    UInt32 reserved;  // 29 bits or max 0x7ffffff
//		    
//		    // 'UInt32' is probably used for the single bit variables instead of 'bool' to reduce steps to covert back
//		    // Sacrifices 3 bytes of memory for the sake of a little more speed due to less operations?
//		}
//		
//		// These two only get read if the respective variables from the 'Flags' struct are set to 1 (true).
//		// If they are not set then the bytes are never written to the *.package thereby saving filesize.
//		private UInt32 constantTypeId;
//		private UInt32 constantGroupId;
//		private UInt32 constantInstanceIdEx;
//		
//		struct IndexEntry
//		{
//		    
//			UInt32 mType;
//		    UInt32 mGroup;
//		    UInt32 mInstanceEx;
//		
//		    UInt32 mInstance;
//		    UInt32 mnPosition;
//		    UInt32 mnSize; // 31 bits combined with 1 bit for mbExtendedCompressionType in a Uint32
//		    UInt32 mbExtendedCompressionType; //1 bit. See above.
//		    UInt32 mnSizeDecompressed;
//		    
//		    // Thise two should inly be set if mbExtendedCompressionType is set.
//		    UInt16 mnCompressionType; //Set from C
//		    UInt16 mnCommitted; // typically 1
//		}

//			public PackageData(bool b)
//			{
//				MessageBox.Show("PackageData constructor...");
//			}
	
		public char[] MagicNumber
		{
			get{ return _fileidentifier; }
			set{ _fileidentifier = value; }
		}
		
		public Version FileVersion
		{
			get{ return _FileVersion; }
			set{ _FileVersion = value; }
		}
		
		public Version UserVersion
		{
			get{ return _UserVersion; }
			set{ _UserVersion = value; }
		}

        public Time CreationTime
        {
            get { return _CreationTime; }
            set { _CreationTime = value; }
        }

        public Time UpdatedTime
        {
            get { return _UpdatedTime; }
            set { _UpdatedTime = value; }
        }

        public UInt32 IndexRecordEntryCount
        {
            get { return _IndexRecordEntryCount; }
            set { _IndexRecordEntryCount = value; }
        }

        public UInt32 IndexRecordPositionLow
        {
            get { return _IndexRecordPositionLow; }
            set { _IndexRecordPositionLow = value; }
        }

        public UInt32 IndexRecordSize
        {
            get { return _IndexRecordSize; }
            set { _IndexRecordSize = value; }
        }

        public UInt64 IndexRecordPosition
        {
            get { return _IndexRecordPosition; }
            set { _IndexRecordPosition = value; }
        }


		
		public PackageData() : base()
		{
			_fileidentifier = new char[4];
			_FileVersion = new Version();	
			_UserVersion = new Version();
            _CreationTime = new Time();
            _UpdatedTime = new Time();
		}
	}
}
