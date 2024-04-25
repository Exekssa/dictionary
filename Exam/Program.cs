using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Exam
{
    internal class Program
    {
        static void Main(string[] args)
        {

#if flase
            //Dictionary engRuDictionary = new Dictionary("Англо-русский");

            //engRuDictionary.AddWord("apple", new List<string> { "яблоко", "яблоня", "яблочный" });
            //engRuDictionary.AddWord("banana", new List<string> { "банан", "банановый", "банановое дерево" });
            //engRuDictionary.AddWord("car", new List<string> { "автомобиль", "машина", "автомобильный" });
            //engRuDictionary.AddWord("house", new List<string> { "дом", "жилище", "здание" });
            //engRuDictionary.AddWord("cat", new List<string> { "кошка", "кот", "кошачий" });
            //engRuDictionary.AddWord("dog", new List<string> { "собака", "пес", "собачий" });
            //engRuDictionary.AddWord("book", new List<string> { "книга", "книжка", "тетрадь" });
            //engRuDictionary.AddWord("computer", new List<string> { "компьютер", "пк", "электронный мозг" });
            //engRuDictionary.AddWord("tree", new List<string> { "дерево", "деревце", "древо" });
            //engRuDictionary.AddWord("pen", new List<string> { "ручка", "письменные принадлежности", "стилос" });
            //engRuDictionary.AddWord("table", new List<string> { "стол", "таблица", "переговоры" });
            //engRuDictionary.AddWord("chair", new List<string> { "стул", "кресло", "сиденье" });
            //engRuDictionary.AddWord("phone", new List<string> { "телефон", "мобильник", "сотовый" });
            //engRuDictionary.AddWord("water", new List<string> { "вода", "жидкость", "акватория" });
            //engRuDictionary.AddWord("sky", new List<string> { "небо", "воздух", "атмосфера" });
            //engRuDictionary.AddWord("sun", new List<string> { "солнце", "сияние", "солнечный" });
            //engRuDictionary.AddWord("moon", new List<string> { "луна", "спутник", "лунный" });
            //engRuDictionary.AddWord("star", new List<string> { "звезда", "звездочка", "звездный" });
            //engRuDictionary.AddWord("flower", new List<string> { "цветок", "блум", "растение" });
            //engRuDictionary.AddWord("road", new List<string> { "дорога", "путь", "трасса" });
            //engRuDictionary.AddWord("river", new List<string> { "река", "поток", "ручей" });
            //engRuDictionary.AddWord("mountain", new List<string> { "гора", "хребет", "высокогорье" });
            //engRuDictionary.AddWord("cloud", new List<string> { "облако", "туча", "облачный" });
            //engRuDictionary.AddWord("rain", new List<string> { "дождь", "ливень", "проливной дождь" });
            //engRuDictionary.AddWord("snow", new List<string> { "снег", "пушистый снег", "снежок" });


            //Dictionary engFrDictionary = new Dictionary("Англо-французский");

            //engFrDictionary.AddWord("apple", new List<string> { "pomme", "pommier", "pommeux" });
            //engFrDictionary.AddWord("banana", new List<string> { "banane", "bananier", "bananier" });
            //engFrDictionary.AddWord("car", new List<string> { "voiture", "automobile", "voiturier" });
            //engFrDictionary.AddWord("house", new List<string> { "maison", "habitation", "bâtiment" });
            //engFrDictionary.AddWord("cat", new List<string> { "chat", "félin", "chatoyant" });
            //engFrDictionary.AddWord("dog", new List<string> { "chien", "canin", "chien" });
            //engFrDictionary.AddWord("book", new List<string> { "livre", "ouvrage", "carnet" });
            //engFrDictionary.AddWord("computer", new List<string> { "ordinateur", "informatique", "calculateur" });
            //engFrDictionary.AddWord("tree", new List<string> { "arbre", "arboré", "végétal" });
            //engFrDictionary.AddWord("pen", new List<string> { "stylo", "plume", "crayon" });
            //engFrDictionary.AddWord("table", new List<string> { "table", "tableau", "tablier" });
            //engFrDictionary.AddWord("chair", new List<string> { "chaise", "siège", "fauteuil" });
            //engFrDictionary.AddWord("phone", new List<string> { "téléphone", "portable", "cellulaire" });
            //engFrDictionary.AddWord("water", new List<string> { "eau", "liquide", "aquatique" });
            //engFrDictionary.AddWord("sky", new List<string> { "ciel", "atmosphère", "aérien" });
            //engFrDictionary.AddWord("sun", new List<string> { "soleil", "rayonnement", "solaire" });
            //engFrDictionary.AddWord("moon", new List<string> { "lune", "satellite", "lunaire" });
            //engFrDictionary.AddWord("star", new List<string> { "étoile", "astre", "stellaire" });
            //engFrDictionary.AddWord("flower", new List<string> { "fleur", "floral", "botanique" });
            //engFrDictionary.AddWord("road", new List<string> { "route", "chemin", "routier" });
            //engFrDictionary.AddWord("river", new List<string> { "rivière", "cours d'eau", "ruisseau" });
            //engFrDictionary.AddWord("mountain", new List<string> { "montagne", "massif", "montagnard" });
            //engFrDictionary.AddWord("cloud", new List<string> { "nuage", "cumulus", "nuageux" });
            //engFrDictionary.AddWord("rain", new List<string> { "pluie", "averse", "pluvieux" });
            //engFrDictionary.AddWord("snow", new List<string> { "neige", "poudreuse", "neigeux" });


            //Dictionary rusDeDictionary = new Dictionary("Русско-немецкий");

            //rusDeDictionary.AddWord("программа", new List<string> { "Programm", "Anwendung", "Software" });
            //rusDeDictionary.AddWord("школа", new List<string> { "Schule", "Bildungseinrichtung", "Lehranstalt" });
            //rusDeDictionary.AddWord("кот", new List<string> { "Kater", "Katze", "Katzenartig" });
            //rusDeDictionary.AddWord("вода", new List<string> { "Wasser", "Flüssigkeit", "Nass" });
            //rusDeDictionary.AddWord("дождь", new List<string> { "Regen", "Niederschlag", "Regnerisch" });
            //rusDeDictionary.AddWord("дерево", new List<string> { "Baum", "Holz", "Forst" });
            //rusDeDictionary.AddWord("компьютерная игра", new List<string> { "Computerspiel", "Videospiel", "Spiel" });
            //rusDeDictionary.AddWord("музыка", new List<string> { "Musik", "Ton", "Klang" });
            //rusDeDictionary.AddWord("красивый", new List<string> { "schön", "hübsch", "attraktiv" });
            //rusDeDictionary.AddWord("радость", new List<string> { "Freude", "Glück", "Vergnügen" });
            //rusDeDictionary.AddWord("телефонный звонок", new List<string> { "Telefonanruf", "Anruf", "Gespräch" });
            //rusDeDictionary.AddWord("родитель", new List<string> { "Elternteil", "Eltern", "Vater/Mutter" });
            //rusDeDictionary.AddWord("путешествие", new List<string> { "Reise", "Fahrt", "Ausflug" });
            //rusDeDictionary.AddWord("еда", new List<string> { "Essen", "Nahrung", "Speise" });
            //rusDeDictionary.AddWord("пить", new List<string> { "trinken", "saufen", "Konsumieren" });
            //rusDeDictionary.AddWord("спать", new List<string> { "schlafen", "ruhen", "schlummern" });
            //rusDeDictionary.AddWord("работа", new List<string> { "Arbeit", "Beruf", "Beschäftigung" });
            //rusDeDictionary.AddWord("игра", new List<string> { "Spiel", "Partie", "Wettkampf" });
            //rusDeDictionary.AddWord("новость", new List<string> { "Nachricht", "Neuigkeit", "Meldung" });
            //rusDeDictionary.AddWord("книжный магазин", new List<string> { "Buchhandlung", "Buchladen", "Bücherei" });

#endif

            List<Dictionary> allDictionaries = LoadListOfDictionariesFromBin("dictionaries.bin");

            if (allDictionaries == null)
            {
                allDictionaries = new List<Dictionary>();
            }
            //allDictionaries.Add(engRuDictionary);
            //allDictionaries.Add(engFrDictionary);
            //allDictionaries.Add(rusDeDictionary);


            int selectedMenuItem = 0;
            int count = 0;

            string[] menuPoints = { "Выбрать словарь","Создать словарь","Посмотреть все слова", "Добавить слово или перевод", "Заменить слово или перевод", "Удалить слово или перевод",
            "Искать перевод", "Выход из меню" };

            while (true)
            {
                Console.Clear();
                Console.WriteLine("Выберите пункт меню:");

                for (int i = 0; i < 8; i++)
                {
                    if (i == selectedMenuItem)
                    {
                        Console.BackgroundColor = ConsoleColor.Blue;
                        Console.ForegroundColor = ConsoleColor.White;
                    }

                    Console.WriteLine($"{i + 1}. {menuPoints[i]}");

                    Console.ResetColor();
                }

                ConsoleKeyInfo key = Console.ReadKey();
                Console.WriteLine();

                switch (key.Key)
                {
                    case ConsoleKey.UpArrow:
                        selectedMenuItem = (selectedMenuItem - 1 + 8) % 8;
                        break;

                    case ConsoleKey.DownArrow:
                        selectedMenuItem = (selectedMenuItem + 1) % 8;
                        break;

                    case ConsoleKey.Enter:
                        Console.WriteLine($"Вы выбрали Пункт {selectedMenuItem + 1}: {menuPoints[selectedMenuItem]}.\n");
                        Console.Clear();
                        PerformAction(selectedMenuItem, allDictionaries, ref count);
                        break;


                    case ConsoleKey.Escape:
                        Console.WriteLine("Выход из программы.");
                        return;
                }

            }

        }

        static void PerformAction(int selectedMenuItem, List<Dictionary> allDictionaries, ref int count)
        {


            switch (selectedMenuItem)
            {
                case 0:

                    Console.WriteLine("Выберите цифру, отвечающую за нужный словарь. Доступные словари: ");
                    for (int i = 0; i < allDictionaries.Count; i++)
                    {
                        Console.WriteLine($"{i + 1}) {allDictionaries[i].DictionaryType}");
                    }

                    string input = Console.ReadLine();
                    int choice;
                    if (int.TryParse(input, out choice))
                    {
                        if (choice >= 1 && choice <= allDictionaries.Count)
                        {
                            count = choice - 1;
                            Console.WriteLine($"Вы выбрали {allDictionaries[count].DictionaryType} словарь. Теперь вы работаете с ним.");
                        }
                        else
                        {
                            Console.WriteLine("Данного варианта не существует!");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Вы ввели некорректное значение!");
                    }

                    break;


                case 1:
                    Console.WriteLine("\nВведите тип словаря (например, «Англо-русский» или «Русско-английский»): ");
                    string dictionaryType = Console.ReadLine();
                    Dictionary tempDictionary = new Dictionary(dictionaryType);

                    allDictionaries.Add(tempDictionary);
                    Console.WriteLine($"Вы успешно добавили {tempDictionary.DictionaryType} словарь в базу словарей.");

                    Console.WriteLine("\nВы хотите выбрать данный словарь для текущей работы? 1 — Да  2 — Нет");
                    choice = int.TryParse(Console.ReadLine(), out int result) ? result : 0;

                    if (choice == 1)
                    {
                        count = allDictionaries.Count - 1;

                    }
                    else
                    {
                        Console.WriteLine("Тогда в дальнейшем будет использоваться словарь по умолчанию.");
                    }

                    break;

                case 2:
                    Console.WriteLine($"Текущий словарь: {allDictionaries[count].DictionaryType}");
                    Console.WriteLine("-------------------------------------------------------------");
                    allDictionaries[count].Show();
                    Console.WriteLine();
                    break;

                case 3:
                    Console.WriteLine($"Текущий словарь: {allDictionaries[count].DictionaryType}");
                    Console.WriteLine("-------------------------------------------------------------");
                    Console.WriteLine("Что вы хотите сделать? 1 — Добавить слово  2 — Добавить перевод");
                    choice = int.TryParse(Console.ReadLine(), out result) ? result : 0;
                    if (choice == 1)
                    {
                        allDictionaries[count].AddWordMenu();


                    }
                    else if (choice == 2)
                    {
                        allDictionaries[count].AddTranslation();
                    }

                    break;

                case 4:
                    Console.WriteLine($"Текущий словарь: {allDictionaries[count].DictionaryType}");
                    Console.WriteLine("-------------------------------------------------------------");
                    Console.WriteLine("Что вы хотите сделать? 1 — Изменить слово  2 — Изменить перевод слова");

                    choice = int.TryParse(Console.ReadLine(), out result) ? result : 0;
                    if (choice == 1)
                    {
                        allDictionaries[count].ChangeWord();

                    }
                    else if (choice == 2)
                    {
                        allDictionaries[count].ChangeTranslation();
                    }

                    break;

                case 5:
                    Console.WriteLine($"Текущий словарь: {allDictionaries[count].DictionaryType}");
                    Console.WriteLine("-------------------------------------------------------------");
                    Console.WriteLine("Что вы хотите сделать? 1 — Удалить слово  2 — Удалить перевод слова");

                    choice = int.TryParse(Console.ReadLine(), out result) ? result : 0;
                    if (choice == 1)
                    {
                        allDictionaries[count].RemoveWord();

                    }
                    else if (choice == 2)
                    {
                        allDictionaries[count].RemoveTranslation();
                    }

                    break;

                case 6:
                    Console.WriteLine($"Текущий словарь: {allDictionaries[count].DictionaryType}");
                    Console.WriteLine("-------------------------------------------------------------");
                    allDictionaries[count].FindWord();
                    break;

                case 7:
                    SaveListOfDictionariesToBin(allDictionaries, "dictionaries.bin");
                    Environment.Exit(0);
                    break;

                default:
                    Console.WriteLine("Некорректный выбор. Попробуйте снова.");
                    break;
            }

            Console.WriteLine("\nНажмите любую клавишу для продолжения...");
            Console.ReadKey();
            Console.Clear();
        }


        public static void SaveListOfDictionariesToBin(List<Dictionary> dictionaries, string path)
        {
            try
            {
                using (FileStream fs = new FileStream(path, FileMode.Create))
                {
                    BinaryFormatter bf = new BinaryFormatter();
                    bf.Serialize(fs, dictionaries);
                    Console.WriteLine("Список словарей успешно сохранен в файле.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Произошла ошибка при сохранении списка словарей: {ex.Message}");
            }
        }


        public static List<Dictionary> LoadListOfDictionariesFromBin(string path)
        {
            List<Dictionary> dictionaries = new List<Dictionary>();

            try
            {
                using (FileStream fs = new FileStream(path, FileMode.Open))
                {
                    BinaryFormatter bf = new BinaryFormatter();
                    dictionaries = (List<Dictionary>)bf.Deserialize(fs);
                    Console.WriteLine("Список словарей успешно загружен из файла.");
                }
            }
            catch (FileNotFoundException)
            {
                Console.WriteLine("Файл не найден.");
            }
            catch (SerializationException)
            {
                Console.WriteLine("Ошибка десериализации. Возможно, файл поврежден или имеет неверный формат.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Произошла ошибка: {ex.Message}");
            }

            return dictionaries;
        }

    }
}