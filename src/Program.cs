using System.Diagnostics;

namespace Final_Grade_Calculator
{
    internal static class Program
    {
        static List<ClassCalculator> list = new List<ClassCalculator>();
        //Creates a static List of ClassCalculator objects

        private static void addClassDataToFile(ClassCalculator x)
        {
            StreamWriter writer = new StreamWriter("ClassData.txt", true);
            //Creates a new writer to the ClassData.txt document that is appending
            using (writer)
            {
                writer.WriteLine(x.GetName().Replace(' ', '_'));
                //Writes the name of the new class
                for (int y = 0; y < x.GetCount(); y++)
                {
                    writer.Write(x.GetCatagory(y).Replace(' ', '_') + ' ');
                    writer.WriteLine(x.GetPercent(y));
                    //Writes the name of the catagory and the percent of the catagory
                }
                writer.WriteLine();
                writer.Close();
            }
        }

        private static void removeClassDataFromFile(ClassCalculator x)
        {
            string tempFile = Path.GetTempFileName();
            //Creates a tempFile

            using (StreamReader reader = new StreamReader("ClassData.txt"))
            using (StreamWriter writer = new StreamWriter(tempFile))
                //Creates a reader for the ClassData and a Writer for the temp file
            {
                string line;
                bool rewrite = true;

                while ((line = reader.ReadLine()) != null)
                {
                    //Iterates though each line in the file
                    if (line == x.GetName().Replace(' ', '_'))
                    {
                        rewrite = false;
                        //If the current line matchs the name of the class to be removed set rewrite to false
                    }
                    if (rewrite)
                    {
                        writer.WriteLine(line);
                        //if rewrite is true then rewrite the line in the ClassData.txt document into the Temp File
                    }
                    if (line == "")
                    {
                        rewrite = true;
                        //if the line is empty set rewrite to true
                    }
                }
            }
            File.Delete("ClassData.txt");
            File.Move(tempFile, "ClassData.txt");
            //Replaces the ClassData file with the temp file
        }

        private static void readClassDataFromFile()
        {
            StreamReader reader = new StreamReader("ClassData.txt");
            using (reader)
            {
                string line;
                ClassCalculator x = new ClassCalculator("error");
                //Initilzes ClassCalculator x
                while ((line = reader.ReadLine()) != null)
                {
                    if ((line.Split(' ').Length == 1) && (line != ""))
                    {
                        x = new ClassCalculator(line.Replace('_', ' '));
                        //If the line is only 1 word but not empty then make x a new ClassCalculator
                    }
                    else if ((line.Split(' ').Length == 2) && (x.GetName() != "error"))
                    {
                        string[] temp = line.Split(' ');
                        x.AddCatagory(temp[0].Replace('_', ' '), Double.Parse(temp[1]));
                        //If they is 2 words in the line then adds a catogry in x with given information
                    }
                    else if (line == "")
                    {
                        list.Add(x);
                        //If line is empty add x to the list
                    }
                    else
                    {
                        throw new Exception();
                    }
                }
            }
        }

        public static void AddToList(ClassCalculator x)
        {
            list.Add(x);
            addClassDataToFile(x);
            //Adds x to list and calls the addClassDataToFile method
        }

        public static void RemoveFromList(ClassCalculator x)
        {
            list.Remove(x);
            removeClassDataFromFile(x);
            //Removes x from the list and calls the RemoveClassDataToFile method
        }

        public static List <ClassCalculator> GetList()
        {
            return list;
        }
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            readClassDataFromFile();
            ApplicationConfiguration.Initialize();
            Application.Run(new MainMenuForm());
            //Calls the readClassDataFromFile method and initilize Application
        }
    }
}