using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Data.SqlClient;
using WpfApp1.Querry;
using WpfApp1.Database;

namespace WpfApp1.Controller
{
    class ImportToCSV
    {
        DataToApp controller;
        public ImportToCSV()
        {
            controller = DataToApp.Instance;
        }
      
       public static void StartNewFile()
        {
            if (File.Exists("MyCSV.csv"))
                {
                List<string> InitialRow = new List<string>();
                InitialRow.Add("Login,");
                InitialRow.Add("Płeć,");
                InitialRow.Add("Wiek,");
                InitialRow.Add("R1,");
                InitialRow.Add("R2,");
                InitialRow.Add("R3,");
                InitialRow.Add("R4,");
                InitialRow.Add("R5,");
                InitialRow.Add("R6,");
                InitialRow.Add("R7,");
                InitialRow.Add("R8,");
                InitialRow.Add("R9,");
                InitialRow.Add("R10,");
                InitialRow.Add("Wariant,");
                InitialRow.Add("Płeć przeciwnika,");
                InitialRow.Add("W1,");
                InitialRow.Add("B1,");
                InitialRow.Add("P1,");
                InitialRow.Add("W2,");
                InitialRow.Add("B2,");
                InitialRow.Add("P2,");
                InitialRow.Add("W3,");
                InitialRow.Add("B3,");
                InitialRow.Add("P3,");
                InitialRow.Add("W4,");
                InitialRow.Add("B4,");
                InitialRow.Add("P4,");
                InitialRow.Add("W5,");
                InitialRow.Add("B5,");
                InitialRow.Add("P5,");
                InitialRow.Add("W6,");
                InitialRow.Add("B6,");
                InitialRow.Add("P6,");
                InitialRow.Add("W7,");
                InitialRow.Add("B7,");
                InitialRow.Add("P7,");
                InitialRow.Add("W8,");
                InitialRow.Add("B8,");
                InitialRow.Add("P8,");
                InitialRow.Add("W9,");
                InitialRow.Add("B9,");
                InitialRow.Add("P9,");
                InitialRow.Add("W10,");
                InitialRow.Add("B10,");
                InitialRow.Add("P10");

                string finalRow = "";
                foreach (string item in InitialRow)
                    finalRow += item;
                using (StreamWriter outputFile = new StreamWriter("MyCSV.csv"))
                    outputFile.WriteLine(finalRow);
            }

        }
        public  void fillFileWithData()
        {
            List<string> tab;
            tab = controller.getDataForCsvFile();
            File.Delete("MyCSCTestowy.csv");
            List<string> InitialRow = new List<string>();
            InitialRow.Add("Login,");
            InitialRow.Add("Płeć,");
            InitialRow.Add("Wiek,");
            InitialRow.Add("R1,");
            InitialRow.Add("R2,");
            InitialRow.Add("R3,");
            InitialRow.Add("R4,");
            InitialRow.Add("R5,");
            InitialRow.Add("R6,");
            InitialRow.Add("R7,");
            InitialRow.Add("R8,");
            InitialRow.Add("R9,");
            InitialRow.Add("R10,");
            InitialRow.Add("Wariant,");
            InitialRow.Add("Płeć przeciwnika,");
            InitialRow.Add("W1,");
            InitialRow.Add("B1,");
            InitialRow.Add("P1,");
            InitialRow.Add("W2,");
            InitialRow.Add("B2,");
            InitialRow.Add("P2,");
            InitialRow.Add("W3,");
            InitialRow.Add("B3,");
            InitialRow.Add("P3,");
            InitialRow.Add("W4,");
            InitialRow.Add("B4,");
            InitialRow.Add("P4,");
            InitialRow.Add("W5,");
            InitialRow.Add("B5,");
            InitialRow.Add("P5,");
            InitialRow.Add("W6,");
            InitialRow.Add("B6,");
            InitialRow.Add("P6,");
            InitialRow.Add("W7,");
            InitialRow.Add("B7,");
            InitialRow.Add("P7,");
            InitialRow.Add("W8,");
            InitialRow.Add("B8,");
            InitialRow.Add("P8,");
            InitialRow.Add("W9,");
            InitialRow.Add("B9,");
            InitialRow.Add("P9,");
            InitialRow.Add("W10,");
            InitialRow.Add("B10,");
            InitialRow.Add("P10");

            string finalRow = "";
            foreach (string item in InitialRow)
                finalRow += item;
            File.AppendAllText("MyCSCTestowy.csv", finalRow + "\n");
            foreach (string item in tab)
            {
                // using (StreamWriter outputFile = new StreamWriter("MyCSVtest.csv"))
                // outputFile.(item);
                
                File.AppendAllText("MyCSCTestowy.csv", item + "\n");
            }
               
        }

        public static int getNumberOfItemsInFile()
        {
            string[] fileText;
            fileText = File.ReadAllLines("MyCSV.csv");
            return fileText.Length;
        }
    }
}
