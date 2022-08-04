using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;

namespace Laboratoire5
{
    internal class Utilitaires
    {
        string Path;
        string EXE = Assembly.GetExecutingAssembly().GetName().Name;
        [DllImport("kernel32", CharSet = CharSet.Unicode)]
        static extern long WritePrivateProfileString(string Section, string Key, string Value, string FilePath);

        [DllImport("kernel32", CharSet = CharSet.Unicode)]
        static extern int GetPrivateProfileString(string Section, string Key, string Default, StringBuilder RetVal, int Size, string FilePath);
        public string ChargerCheminImage(){
            Microsoft.Win32.OpenFileDialog dlg = new Microsoft.Win32.OpenFileDialog();
            dlg.FileName = "Fichiers Images"; 
            dlg.DefaultExt = ".jpg"; 
            dlg.Filter = "Fichiers Images |*.jpg"; 
            Nullable<bool> result = dlg.ShowDialog();
            if (result == true){return dlg.FileName;}
            return null;
        }
        public string IniFile(string IniPath = null){Path = new FileInfo(IniPath ?? EXE + ".ini").FullName; return Path;}
        public string LireINI(string Key, string Section = null) {
            var RetVal = new StringBuilder(255);
            GetPrivateProfileString(Section ?? EXE, Key, "", RetVal, 255, Path);
            return RetVal.ToString();
        }
        public void EcrireINI(string Key, string Value, string Section = null){WritePrivateProfileString(Section ?? EXE, Key, Value, Path);}
        public void SupprimerSectionINI(string Key, string Section = null){EcrireINI(Key, null, Section ?? EXE);}
        public void SupprimerSection(string Section = null){ EcrireINI(null, null, Section ?? EXE);}
        public bool KeyExists(string Key, string Section = null){return LireINI(Key, Section).Length > 0;}
    }
}
