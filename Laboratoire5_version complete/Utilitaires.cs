using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows;

namespace Laboratoire5
{
    class Utilitaires
    {
        private string Path=Environment.CurrentDirectory;
        string EXE = Assembly.GetExecutingAssembly().GetName().Name;
        [DllImport("kernel32", CharSet = CharSet.Unicode)]
        static extern long WritePrivateProfileString(string Section, string Key, string Value, string FilePath);

        [DllImport("kernel32", CharSet = CharSet.Unicode)]
        static extern int GetPrivateProfileString(string Section, string Key, string Default, StringBuilder RetVal, int Size, string FilePath);
        public string ChargerCheminImage(){
            Microsoft.Win32.OpenFileDialog dlg = new Microsoft.Win32.OpenFileDialog();
            dlg.FileName = "Fichiers Images";
            dlg.InitialDirectory = Environment.CurrentDirectory + "\\images";
            dlg.DefaultExt = ".png"; 
            dlg.Filter = "Fichiers Images |*.jpg;*.gif;*.png;*.bmp;*.ico"; 
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
        public string ExtraireDateHeure()
        {
            DateTime dt = DateTime.Now;
            string tmp = $"{dt.Year}";
            if (dt.Month < 10) { tmp += "0" + dt.Month; } else { tmp += dt.Month; }
            if (dt.Day < 10) { tmp += "0" + dt.Day; } else { tmp += dt.Day; }
            tmp += "_";
            if (dt.Hour < 10) { tmp += "0" + dt.Hour; } else { tmp += dt.Hour; }
            if (dt.Minute < 10) { tmp += "0" + dt.Minute; } else { tmp += dt.Minute; }
            if (dt.Second < 10) { tmp += "0" + dt.Second; } else { tmp += dt.Second; }
            return tmp;
        }
        public void MessageErreur(string Texte, string Titre) 
        {
            MessageBox.Show(Texte,Titre, MessageBoxButton.OK, MessageBoxImage.Error);
        }
    }
}
