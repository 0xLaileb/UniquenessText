using System;
using System.IO;
using System.Threading;

namespace Uniqueness_Text
{
    class Program
    {
        static string file_text = "";
        static void CWL(string text) => Console.WriteLine(text);
        static void CW(string text) => Console.Write(text);

        static void Main(string[] args)
        {
            try
            {
                Console.ForegroundColor = ConsoleColor.White;
                CWL("====================================================");
                CWL("Uniqueness Text [PLUS] | версия: 0.0.0.1");
                CWL("====================================================");
                Thread.Sleep(300);

                Console.ForegroundColor = ConsoleColor.Green;
                CWL("1. Загружаю файл..");
                file_text = File.ReadAllText(args[0]);
                Thread.Sleep(300);
                CWL("2. Сканирую..");
                if (file_text.Length < 1 || file_text == "")
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    CWL("[ Ошибка: текст файла слишком мал! ]");
                    Console.ReadKey();
                    Environment.Exit(0);
                }
                Thread.Sleep(300);
                CWL("3. Запускаю методы..");
                Thread.Sleep(300);
                CWL("====================================================");
                CWL("(когда полоска дойдет до конца - тогда готово)");

                new Thread(Start).Start();
            }
            catch (Exception er)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                CWL("Ошибка: \n" + er.ToString());
                Console.ReadKey();
                Environment.Exit(0);
            }
        }

        static void Start()
        {
            try
            {
                Console.ForegroundColor = ConsoleColor.Blue;
                CW("||||||||");
                Thread.Sleep(10);
                file_text = Synonyms_Text(file_text);
                CW("|||||||||");
                Thread.Sleep(10);
                CW("||||||||||");
                Thread.Sleep(10);
                file_text = Replace_Text(file_text);
                CW("||||||||||||");
                Thread.Sleep(10);
                file_text = Add_Byte_File(file_text);
                CW("|||||||||||||");

                Thread.Sleep(10);
                Finish(file_text);
                CW("||||||||||");
            }
            catch (Exception er)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                CWL("Ошибка: \n" + er.ToString());
                Console.ReadKey();
                Environment.Exit(0);
            }
        }

        static string Synonyms_Text(string text_new)
        {
            string[] words =
            {
                "тот",
                "быть",
                "весь",
                "сказать",
                "этот",
                "мочь",
                "только",
                "свое",
                "уже",
                "для",
                "говорить",
                "знать",
                "рука",
                "стать",
                "большой",
                "другой",
                "ничто",
                "потом",
                "очень",
                "хотеть",
                "видеть",
                "идти",
                "друг",
                "сейчас",
                "можно",
                "здесь",
                "думать",
                "спросить",
                "ведь",
                "хороший",
                "каждый",
                "новый",
                "должный",
                "смотреть",
                "почему",
                "потому",
                "просто",
                "сидеть",
                "понять",
                "иметь",
                "конечный",
                "делать",
                "вдруг",
                "взять",
                "сделать",
                "перед",
                "нужный",
                "понимать",
                "работа",
                "земля",
                "конец",
                "несколько",
                "последний",
                "давать",
                "более",
                "хотя",
                "всегда",
                "второй",
                "куда",
                "пойти",
                "ребенок",
                "увидеть",
                "отец",
                "женщина",
                "машина",
                "случай",
                "сразу",
                "совсем",
                "почти",
                "много",
                "снова",
                "между",
                "опять",
                "посмотреть",
                "главный",
                "однако"
            };
            string[] synonyms =
            {
                "этот",
                "являться",
                "полный",
                "отметить",
                "данный",
                "уметь",
                "только лишь",
                "собственное",
                "ранее",
                "с целью",
                "заявлять",
                "понимать",
                "кисть",
                "быть",
                "огромный",
                "иной",
                "ничего",
                "затем",
                "весьма",
                "желать",
                "наблюдать",
                "следовать",
                "товарищ",
                "в настоящее время",
                "возможно",
                "тут",
                "мыслить",
                "задать вопрос",
                "так как",
                "неплохой",
                "любой",
                "новейший",
                "соответствующий",
                "посмотреть",
                "по какой причине",
                "вследствие того",
                "попросту",
                "находиться",
                "осознать",
                "обладать",
                "окончательный",
                "выполнять",
                "внезапно",
                "брать",
                "совершить",
                "пред",
                "необходимый",
                "осознавать",
                "деятельность",
                "территория",
                "окончание",
                "ряд",
                "завершающий",
                "предоставлять",
                "наиболее",
                "несмотря на то",
                "постоянно",
                "2-ой",
                "гораздо",
                "отправиться",
                "дошкольник",
                "заметить",
                "папа",
                "девушка",
                "автомобиль",
                "вариант",
                "мгновенно",
                "совершенно",
                "практически",
                "большое количество",
                "вновь",
                "среди",
                "вновь",
                "взглянуть",
                "основной",
                "но"
            };

            bool[] check = new bool[words.Length];

            try
            {
                for (int i = 0; i < words.Length; i++)
                {
                    Thread.Sleep(1);
                    if (text_new.Contains(words[i]) && check[i] == false)
                    {
                        text_new = text_new.Replace(words[i], synonyms[i]);
                        check[i] = true;
                    }
                }
                
                for (int i = 0; i < synonyms.Length; i++)
                {
                    Thread.Sleep(1);
                    if (text_new.Contains(synonyms[i]) && check[i] == false)
                    {
                        text_new = text_new.Replace(synonyms[i], words[i]);
                        check[i] = true;
                    }
                }

                return text_new;
            }
            catch (Exception er)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                CWL("Ошибка: \n" + er.ToString());
                Console.ReadKey();
                Environment.Exit(0);
                return "";
            }
        }

        static string Replace_Text(string text_new)
        {
            string[] old_simvols =
            {
                "К", "Е", "Н", "З", "Х", "ь", "В", "А", "Р", "О", "С", "й",
                 
                "у", "е", "х", "а", "р", "о", "э", "с", "м", "т",

                ",", ".", "'", "-", ":", "\"", "~", ";", "^"
            };
            string[] new_simvols =
            {
                "K", "E", "H", "3", "X", "ь", "B", "A", "P", "O", "C", "ӥ",

                "y", "e", "x", "a", "p", "o", "з", "c", "ʍ", "т",

                "，", "․", "ˈ", "‒", "∶", "̎", "⁓", ";", "⌃"
            };

            try
            {
                for (int i = 0; i < old_simvols.Length; i++)
                {
                    Thread.Sleep(1);
                    if (text_new.Contains(old_simvols[i]))
                    {
                        text_new = text_new.Replace(old_simvols[i], new_simvols[i]);
                    }
                }

                return text_new;
            }
            catch (Exception er)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                CWL("Ошибка: \n" + er.ToString());
                Console.ReadKey();
                Environment.Exit(0);
                return "";
            }
        }

        static string Add_Byte_File(string text_new)
        {
            try
            {
                Thread.Sleep(1);
                for (int i = 0; i < new Random().Next(10, 40); i++)
                    text_new = text_new + "​";

                return text_new;
            }
            catch (Exception er)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                CWL("Ошибка: \n" + er.ToString());
                Console.ReadKey();
                Environment.Exit(0);
                return "";
            }
        }

        static void Finish(string text_new)
        {
            try
            {
                Console.ForegroundColor = ConsoleColor.Green;
                CWL("\n====================================================");
                Thread.Sleep(300);

                string name_files_finish = $"result_{DateTime.Now.ToString("HH-mm-ss")}_{DateTime.Now.ToString("dd.MM.yyyy")}.txt";

                if (File.Exists(name_files_finish))
                    File.Delete(name_files_finish);

                Thread.Sleep(300);
                File.WriteAllText(name_files_finish, text_new);
                CWL($"РЕЗУЛЬТАТ В ФАЙЛЕ -> {name_files_finish}");
                CWL("====================================================");
                CWL("ПРОЧИТАЙТЕ ВЕСЬ ГОТОВЫЙ ТЕКСТ! ПРОВЕРЬТЕ НА РЕЧЬ!");
                Console.ReadKey();
            }
            catch (Exception er)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                CWL("Ошибка: \n" + er.ToString());
                Console.ReadKey();
                Environment.Exit(0);
            }
        }
    }
}
