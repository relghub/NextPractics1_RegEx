using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace NextPractics1_RegEx
{
    internal class Program
    {
        protected static string Replacement(string inputString, List<string> valuesToReplace, string replaceValue)
        {
            string regexValues = string.Join("|", valuesToReplace);
            return Regex.Replace(inputString, regexValues, replaceValue);
        }
        static void Task1()
        {
            System.Console.InputEncoding = System.Text.Encoding.Unicode;
            System.Console.OutputEncoding = System.Text.Encoding.Unicode;
            Console.WriteLine("Введіть логін: ");
            string? inputLogin = Console.ReadLine();
            Regex loginLimits = new(@"^(\D)(\w){1,9}$");
            switch (loginLimits.IsMatch(inputLogin))
            {
                case false:
                    Console.WriteLine("На жаль, ваш логін порушує правила сервісу.");
                    break;
                case true:
                    Console.WriteLine("Ласкаво просимо на нашому порталі!");
                    break;

            }

        }
        static void Task2()
        {
            System.Console.InputEncoding = System.Text.Encoding.Unicode;
            System.Console.OutputEncoding = System.Text.Encoding.Unicode;
            Console.WriteLine("Введіть довільний текст: ");
            string? inputText = Console.ReadLine();
            string? processingText = inputText;
            string outputText = "";
            List<string> patternsToReplaceUpper = new() {
                                            "Будь-ласка",
                                            "Будьласка",
                                            "Буд ласка",
                                            "Будь аска",
                                            "Будь лска",
                                            "Будь лака",
                                            "Будь ласа",
                                            "Будь ласк"
                                            };
            List<string> patternsToReplaceLower = new() {
                                            "будь-ласка",
                                            "будьласка",
                                            "буд ласка",
                                            "будь аска",
                                            "будь лска",
                                            "будь лака",
                                            "будь ласа",
                                            "будь ласк"
                                            };
            processingText = Replacement(processingText, patternsToReplaceLower, "будь ласка");
            processingText = Replacement(processingText, patternsToReplaceUpper, "Будь ласка");
            outputText = processingText;
            Console.WriteLine("Відредагований текст: {0}", outputText);
        }
        static void Main(string[] args)
        {
            Task1();
            Task2();
        }
    }
}
