using System;
using System.IO;
using System.Text;

public class DicCheak
{
	static void Main()
    {
        // fnameに作った辞書の名前をいれて！！
        string fname = "dic_bug.txt";


        var dicList = new List<string>();
        StreamReader sr = new StreamReader(fname, Encoding.GetEncoding("UTF-8"));

        string text = sr.ReadToEnd();

        dicList.Add(text.Substring(0, text.IndexOf(',')));

        sr.Close();
    }
}
