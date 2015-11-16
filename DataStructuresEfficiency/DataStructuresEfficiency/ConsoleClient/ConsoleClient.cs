namespace ConsoleClient
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using DataStructuresEfficiencyLibraly;
    using DataStructuresEfficiencyLibraly.Students;
    using Wintellect.PowerCollections;
    using DataStructuresEfficiencyLibraly.Company;
    public class ConsoleClient
    {
        public static void Main()
        {
            //var coursesAndStudents = BuildCoursesAndStudents();
            //PrintCoursesAndStudents(coursesAndStudents);

            const decimal StartSearchPrice = 6.05m;
            const decimal EndSearchPrice = 7.05m;
            var allArticlesOrderedByTheirPrices = BuildCompany();

            var firstTwentyInRange = allArticlesOrderedByTheirPrices.
               Range(StartSearchPrice, true, EndSearchPrice, true).
               Take(20).
               ToList();

            foreach (var item in firstTwentyInRange)
            {
                Console.WriteLine(item);
            }
        }

        
        public static OrderedMultiDictionary<decimal, Article> BuildCompany()
        {
            OrderedMultiDictionary<decimal, Article> allArticlesOrderedByTheirPrices = new OrderedMultiDictionary<decimal, Article>(false);

            const int NumberOfArticles = 100000;
            
        for (int i = 0; i < NumberOfArticles; i++)
            {
                var newRandomArticle = new Article(
                                               RandomGenerator.GetRandomBarcode(13),
                                               RandomGenerator.GetRandomStringWithRandomLength(5, 10),
                                               RandomGenerator.GetRandomStringWithRandomLength(10, 15),
                                               RandomGenerator.GetRandomDecimalBetween(5, 15));

                allArticlesOrderedByTheirPrices[newRandomArticle.Price].Add(newRandomArticle);

            }

            return allArticlesOrderedByTheirPrices;
        }
        public static void PrintCoursesAndStudents(SortedDictionary<string, List<Student>> coursesAndStudents)
        {
            foreach (var course in coursesAndStudents)
            {
                Console.WriteLine("{0}: {1}", course.Key, string.Join(", ", course.Value));
            }
        }

        public static SortedDictionary<string, List<Student>> BuildCoursesAndStudents()
        {
            SortedDictionary<string, List<Student>> coursesAndStudents = new SortedDictionary<string, List<Student>>();

            var textLines = ReadFromFile.Lines;

            string studentFirstName = "";
            string studentLastName = "";
            string courseName = "";

            foreach (var line in textLines)
            {
                var currentLine = line.Split(new char[] { '|' }, StringSplitOptions.RemoveEmptyEntries);


                studentFirstName = currentLine[0].Trim();
                studentLastName = currentLine[1].Trim();
                courseName = currentLine[2].Trim();

                if (!coursesAndStudents.ContainsKey(courseName))
                {
                    coursesAndStudents.Add(courseName, new List<Student> { new Student(studentFirstName, studentLastName) });
                }
                else
                {
                    coursesAndStudents[courseName].Add(new Student(studentFirstName, studentLastName));
                }
            }

            return coursesAndStudents;
        }
    }
}
