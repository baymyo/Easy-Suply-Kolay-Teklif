using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using DevExpress.LookAndFeel;

namespace EasySupply
{   
    [Serializable]
    public class LookAndFeelSettings
    {
        public string SkinName;
        public DevExpress.LookAndFeel.LookAndFeelStyle Style;
        public bool UseWindowsXPTheme;

        public static void Save(string fileName)
        {
            try
            {
                fileName = Commons.FolderPath + fileName;
                FileStream stream;
                LookAndFeelSettings settings;
                BinaryFormatter formatter;

                settings = new LookAndFeelSettings();
                settings.SkinName = UserLookAndFeel.Default.SkinName;
                settings.Style = UserLookAndFeel.Default.Style;
                settings.UseWindowsXPTheme = UserLookAndFeel.Default.UseWindowsXPTheme;

                using (stream = new FileStream(fileName, FileMode.Create))
                {
                    formatter = new BinaryFormatter();
                    formatter.AssemblyFormat = System.Runtime.Serialization.Formatters.FormatterAssemblyStyle.Simple;
                    formatter.Serialize(stream, settings);
                }
            }
            catch (Exception ex)
            {
                Commons.Status(Commons.GetErrorCode("LFS", 1) + ex.Message);
            }
        }

        public static void Load(string fileName)
        {
            try
            {
                fileName = Commons.FolderPath + fileName;
                if (File.Exists(fileName))
                    using (FileStream stream = new FileStream(fileName, FileMode.Open))
                    {
                        BinaryFormatter formatter = new BinaryFormatter();
                        formatter.AssemblyFormat = System.Runtime.Serialization.Formatters.FormatterAssemblyStyle.Simple;
                        LookAndFeelSettings settings = formatter.Deserialize(stream) as LookAndFeelSettings;
                        if (settings != null)
                        {
                            UserLookAndFeel.Default.UseWindowsXPTheme = settings.UseWindowsXPTheme;
                            UserLookAndFeel.Default.Style = settings.Style;
                            UserLookAndFeel.Default.SkinName = settings.SkinName;
                        }
                    }
            }
            catch (Exception ex)
            {
                Commons.Status(Commons.GetErrorCode("LFS", 2) + ex.Message);
            }
        }
    }
}