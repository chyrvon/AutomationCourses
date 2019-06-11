using System;
using System.IO;
using System.Text;

namespace HW7.Helper
{
    class SaveDataToFile
    {
        public static void SetCountriesToFile(DictionaryCountries dictionaryCountries)
        {
            if (File.Exists(Const.Path))
            {
                File.Delete(Const.Path);
                try
                {
                    Console.WriteLine("Writting Countries to File\n");
                    StringBuilder str = new StringBuilder();
                    using (StreamWriter sw = new StreamWriter(Const.Path, true, System.Text.Encoding.Default))
                    {
                        sw.Write($"Country\t\tIsTelenorSupported");
                        foreach (int k in dictionaryCountries.countries.Keys)
                        {
                            str.Append($"\r\n{dictionaryCountries.countries[k].Name}\t\t{dictionaryCountries.countries[k].IsTelenorSupported}");
                        }

                        Console.WriteLine(str.ToString());
                        sw.Write(str.ToString());
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }
        }
    }
}
