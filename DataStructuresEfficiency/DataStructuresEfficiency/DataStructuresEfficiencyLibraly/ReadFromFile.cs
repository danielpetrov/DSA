namespace DataStructuresEfficiencyLibraly
{
    using System.IO;
    public static class ReadFromFile
    {
        private const string FilePath = @"..\..\students.txt";

        private static string[] lines = File.ReadAllLines(FilePath);

        public static string[] Lines
        {
            get
            {
                return lines;
            }

            private set
            {
                lines = value;
            }
        }
    }
}
