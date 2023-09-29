using System;
using System.Text.RegularExpressions;

//class Program
//{
//    static void Main(string[] args)
//    {
//        System.Console.OutputEncoding = System.Text.Encoding.UTF8;
//        //string data1 = "Петро, ​​Андрій, Микола";
//        //string data2 = "Петро, ​​Андрій, Олександр";
//        //Regex myReg = new Regex("Микола"); // Створення регулярного виразу
//        //Console.WriteLine(myReg.IsMatch(data1)); // True
//        //Console.WriteLine(myReg.IsMatch(data2)); // False
//        //string data1 = "Петро, ​​Андрій, Микола" ;
//        //Regex myReg = new("Микола");
//        //Match match = myReg.Match(data1);
//        //Console.WriteLine(match.Value); // "Микола"
//        //Console.WriteLine(match.Index); // 15
//        //string data1 = "Петро, Микола, Андрій, Микола";
//        //Regex myReg = new Regex("Микола");
//        //data1 = myReg.Replace(data1, "Максим");
//        //Console.WriteLine(data1); // "Петро, ​​Максим, Андрій, Максим"
//        //Regex myReg = new Regex(", ");
//        //string[] names = myReg.Split(data1); // Масив імен
//        //foreach (string element in names)
//        //{
//        //    Console.WriteLine(element);
//        //}
//        //string data = "nikolay, sergey, oleg" ;
//        //Regex myRegIgnoreCase = new Regex(@"Sergey", RegexOptions.IgnoreCase);
//        //Regex myReg = new Regex(@"Sergey");
//        //Console.WriteLine(myRegIgnoreCase.IsMatch(data)); // True
//        //Console.WriteLine(myReg.IsMatch(data)); // False

//    }
//}

//class Program
//{
//    static string GetDomain(string url)
//    {
//        Regex re = new Regex("https://", RegexOptions.IgnoreCase);
//        url = re.Replace(url, ""); // Видаляємо частину http: //
//        Regex reWww = new Regex(@"www\\.", RegexOptions.IgnoreCase);
//        url = reWww.Replace(url, ""); // Видаляємо частину www.
//        int end = url.IndexOf("/");

//        if (end != -1)
//            url = url.Substring(0, end);
//        return url;
//    }
//    static void Main(string[] args)
//    {

//        string url1 = "https://krypton.com.ua/tutorial/csharp/";
//        string url2 = "https://krypton.com.ua/tutorial/ci-10-net-6/";
//        Console.WriteLine(GetDomain(url1)); // krypton.com.ua
//        Console.WriteLine(GetDomain(url2)); // krypton.com.ua
//    }
//}