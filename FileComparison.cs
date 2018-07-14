using System;
using System.IO;


namespace FileComparison
{
    class Program
    {
        static void Main(string[] args)
        {
            long txtSize;
            long wordSize;
            string txtFile = "Quote.txt";
            string wordFile = "Quote.doc";

            FileInfo txtInfo = new FileInfo(txtFile);
            FileInfo wordInfo = new FileInfo(wordFile);
            txtSize = txtInfo.Length; wordSize = wordInfo.Length;
            Console.WriteLine("File Size of " + txtFile + " is " + txtSize);
            Console.WriteLine("File Size of " + wordFile + " is " + wordSize);
            Console.WriteLine("Ratio word/Txt is " + (wordSize / txtSize));
        }
    }
}