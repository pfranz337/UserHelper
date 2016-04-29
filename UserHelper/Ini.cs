using System;
using System.Runtime.InteropServices;
using System.Text;

namespace Ini
{
	// ***********************************************************************************************************
	/// <summary>
    /// Create a New INI file to store or load data
    /// </summary>
    public class IniFile
    {
    	readonly string path;

    	[DllImport("kernel32")]     //for deleteWholeSection(string Section)
        private static extern long WritePrivateProfileString(string section, string key, string val, string filePath);

		[DllImport("kernel32")]		//for IniReadValue(string Section, string Key)
		private static extern int GetPrivateProfileString(string section, string key,string def, StringBuilder retVal, int size,string filePath);

		[DllImport("kernel32")]		//for readSection(string Section)
		private static extern int GetPrivateProfileSection(string section, IntPtr lpReturnedString, int nSize, string lpFileName);												
		
		[DllImport ("kernel32")]	//for getSectionNames()
        static extern int GetPrivateProfileString (int Section, string Key, string Value, [MarshalAs (UnmanagedType.LPArray)] byte[] Result, int Size, string FileName);
    	
    	// ***********************************************************************************************************
        /// <summary>
        /// INIFile Constructor
        /// </summary>
        /// <PARAM name="INIPath">File path</PARAM>
        public IniFile(string INIPath)
        {
            path = INIPath;
        }                
        
        // ***********************************************************************************************************
        /// <summary>
        /// Delete all Data From the section
        /// </summary>
        /// <PARAM name="Section">section to delete</PARAM>
        public void deleteWholeSection(string Section)
        {
        	WritePrivateProfileString(Section, null, null, path);
        }

        // ***********************************************************************************************************
        /// <summary>
        /// Read Data Value From the Ini File
        /// </summary>
        /// <PARAM name="Section">section to read</PARAM>
        /// <PARAM name="Key">key from section</PARAM>
        /// <returns>Returns value Key in Section (need be splitted by '=')</returns>
        public string IniReadValue(string Section, string Key)
        {
            var temp = new StringBuilder(255);
            int i = GetPrivateProfileString(Section, Key, "", temp, 255, this.path);
            return temp.ToString();
        }       
        
        // ***********************************************************************************************************
        /// <summary>
		/// Reads a whole section of the INI file
		/// </summary>
		/// <param name="Section">Section to read</param>
		/// <returns>Returns string[] value containing all rows in Section (need be splitted by ';')</returns>
		public string[] ReadSection(string Section)
		{
			const int bufferSize = 8*4096;
			var returnedString = new StringBuilder();
			IntPtr pReturnedString = Marshal.AllocCoTaskMem(bufferSize);
			try {
				int bytesReturned = GetPrivateProfileSection(Section, pReturnedString, bufferSize, this.path);
				for (int i = 0; i < bytesReturned-1; i++)	// 'bytesReturned -1' to remove trailing \0
					returnedString.Append((char)Marshal.ReadByte(new IntPtr((uint)pReturnedString + (uint)i)));
			} finally {
				Marshal.FreeCoTaskMem(pReturnedString);
			}
			string sectionData = returnedString.ToString();
			return sectionData.Split('\0');
		}
		                                     
        // ***********************************************************************************************************
        /// <summary>
        /// Read all section name
        /// </summary>
        /// <returns>Returns all section names</returns>
		public string[] GetSectionNames()
        {
            for (int maxsize = 500; true; maxsize*=2)
            {
                var bytes = new byte[maxsize];
                int size = GetPrivateProfileString(0,"","",bytes,maxsize,path);                
                if (size < maxsize -2)
                {
                    string Selected = Encoding.ASCII.GetString(bytes,0, 
                                               size - (size >0 ? 1:0));
                    return Selected.Split(new char[] {'\0'});
                }
            }
        }
    }
}