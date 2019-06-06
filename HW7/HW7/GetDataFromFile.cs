using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Printing;

namespace HW7
{
    class GetDataFromFile
    {
        public static void GetCountriesFromFile()
        {
            string Path = @"D:\AutomationCourses\HW6\EC.txt"; //default
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.FileName = "EC";
            dlg.DefaultExt = ".txt";
            dlg.Filter = "Text documents (.txt)|*.txt";
            if (dlg.ShowDialog() != DialogResult.Cancel) Path = dlg.FileName;
            try
            {
                Console.WriteLine("Reading Countries:\n");
                int i = 1;
                using (StreamReader sr = new StreamReader(Path, System.Text.Encoding.Default))
                {
                    string LineFromFile;
                    while ((LineFromFile = sr.ReadLine()) != null)
                    {
                        Console.WriteLine($"{i}. {LineFromFile}");
                        Globals.countries.Add(i, new Country(LineFromFile));
                        i++;
                    }
                }
                Globals.countCountry = i;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
