using System;
using Microsoft.VisualBasic.FileIO;

namespace parser
{
    public class CSVParser
    { 
        private TextFieldParser parser;
        public CSVParser(string path)
        {
            parser = new TextFieldParser(path);
            
        }

        public void run()
        {
            parser.SetDelimiters(",");
            while (!parser.EndOfData)
            {
                //Process row
                string[] fields = parser.ReadFields();
                foreach (string field in fields)
                {
                    Console.WriteLine(field);
                }
            }
        }
    }
}