using System;

namespace parser
{
    class Program
    {
        static void Main(string[] args)
        {
            CSVParser parser = new CSVParser("/Users/gadelshinrr/Desktop/2kGit/2k/2021/2k/1semDB/parser/parser/src/file.csv");
            parser.run();
        }
    }
}