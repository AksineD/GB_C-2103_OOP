// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ParseFile.cs" company="">
//   
// </copyright>
// <summary>
//   The parse file.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace ReverseString
{
    #region

    using System.Reflection;

    #endregion

    /// <summary>
    /// The parse file.
    /// </summary>
    public class ParseFile
    {
        /// <summary>
        /// Gets the assembly directory.
        /// </summary>
        public static string AssemblyDirectory
        {
            get
            {
                var codeBase = Assembly.GetExecutingAssembly().CodeBase;
                var uri = new UriBuilder(codeBase);
                var path = Uri.UnescapeDataString(uri.Path);
                return Path.GetDirectoryName(path);
            }
        }

        /// <summary>
        /// The print data.
        /// </summary>
        /// <param name="fileName">
        /// The file name.
        /// </param>
        public void PrintData(string fileName)
        {
            var lines = this.ReadFile(fileName);

            foreach (var line in lines) Console.WriteLine(line);
        }

        /// <summary>
        /// The print data.
        /// </summary>
        /// <param name="strings">
        /// The strings.
        /// </param>
        public void PrintData(string[] strings)
        {
            foreach (var line in strings) Console.WriteLine(line);
        }

        /// <summary>
        /// The read file.
        /// </summary>
        /// <param name="fileName">
        /// The file name.
        /// </param>
        /// <returns>
        /// The <see cref="string[]"/>.
        /// </returns>
        public string[] ReadFile(string fileName)
        {
            var fullPath = $"{AssemblyDirectory}\\{fileName}";

            var lines = File.ReadAllLines(fullPath);
            return lines;
        }

        /// <summary>
        /// The save data.
        /// </summary>
        /// <param name="fileName">
        /// The file name.
        /// </param>
        /// <param name="data">
        /// The data.
        /// </param>
        public void SaveData(string fileName, string[] data)
        {
            var fullPath = $"{AssemblyDirectory}\\{fileName}";
            File.WriteAllLines(fullPath, data);
        }

        /// <summary>
        /// The search mail.
        /// </summary>
        /// <param name="s">
        /// The s.
        /// </param>
        public void SearchMail(ref string s)
        {
            s = s.Split('&', StringSplitOptions.RemoveEmptyEntries | StringSplitOptions.TrimEntries)
                .LastOrDefault(s => s.Contains('@'));
        }
    }
}