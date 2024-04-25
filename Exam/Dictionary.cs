using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;


namespace Exam

{
    [Serializable]
    internal class Dictionary
    {
        private Dictionary<string, List<string>> dictionary;
        public string DictionaryType { get; set; }

        public Dictionary(string dictionaryType)
        {
            dictionary = new Dictionary<string, List<string>>();
            DictionaryType = dictionaryType;
        }



        public void ClearDictionary()
        {
            dictionary.Clear();
            DictionaryType = string.Empty;
        }

        public void AddWord(string word, List<string> translations)
        {
            if (!dictionary.ContainsKey(word))
            {

                dictionary.Add(word, translations);
                Console.WriteLine($"Слово '{word}' успешно добавлено в словарь.");
            }
            else
            {

                Console.WriteLine($"Слово '{word}' уже есть в словаре.");
            }
        }

        public void AddWordMenu()
        {
            List<string> translationOfWord = new List<string>();

            Console.WriteLine("\nВведите слово, которое хотите добавить в словарь: ");
            string originalWord = Console.ReadLine();

            if (dictionary.ContainsKey(originalWord))
            {
                Console.WriteLine($"\nСлово '{originalWord}' уже существует в словаре!");
                return;
            }

            Console.WriteLine($"\nВведите перевод слова {originalWord}: ");
            string newTranslation = Console.ReadLine();
            translationOfWord.Add(newTranslation);
            dictionary.Add(originalWord, translationOfWord);

            Console.WriteLine($"\nСлово {originalWord} успешно добавлено в словарь!");

        }

        public void ShowWordsInDictionary()
        {
            Console.WriteLine($"Слова в словаре: {string.Join(", ", dictionary.Keys)}  ");
            Console.WriteLine("\n-------------------------------------------------------------");
        }

        public void AddTranslation()
        {
            ShowWordsInDictionary();
            Console.WriteLine("\nВведите слово, для которого хотите добавить перевод: ");
            string originalWord = Console.ReadLine();

            if (!ContainsWord(originalWord))
            {
                Console.WriteLine("\nТакого слова нет в словаре!");
                return;
            }

            List<string> values = dictionary[originalWord];

            Console.WriteLine($"\nВведите новый перевод для слова {originalWord}: ");
            string newTranslation = Console.ReadLine();

            values.Add(newTranslation);

            Console.WriteLine($"Новый перевод для слова {originalWord} был успешно добавлен в словарь!");


        }

        public void Show()
        {

            foreach (var word in dictionary)
            {
                List<string> values = word.Value;

                string valuesString = string.Join(", ", values);

                Console.Write($"\n{word.Key} — {valuesString}");
            }

            Console.WriteLine("\n-------------------------------------------------------------");
            Console.WriteLine("\nХотите сохранить данный словарь в текстовый файл? 1 — Да  2 — Нет");

            int choice = int.TryParse(Console.ReadLine(), out int result) ? result : 0;
            if (choice == 1)
            {
                string path = DictionaryType + ".txt";
                SaveToText(path);

            }
            else
            {
                return;
            }

        }

        public bool ContainsWord(string word)
        {
            return dictionary.ContainsKey(word);
        }

        public void RemoveWord()
        {
            ShowWordsInDictionary();
            Console.WriteLine("\nВведите слово, которое хотите удалить из словаря: ");
            string wordToDelete = Console.ReadLine();

            if (!ContainsWord(wordToDelete))
            {
                Console.WriteLine("\nТакого слова нет в словаре!");
                return;
            }

            dictionary[wordToDelete].Clear();
            dictionary.Remove(wordToDelete);
            Console.WriteLine($"\nСлово{wordToDelete} было удалено из словаря!"); ;
        }


        public void RemoveTranslation()
        {
            ShowWordsInDictionary();
            Console.WriteLine("\nВведите слово, перевод которого вы хотите удалить из словаря: ");
            string word = Console.ReadLine();

            if (!ContainsWord(word))
            {
                Console.WriteLine("\nТакого слова нет в словаре!");
                return;
            }

            List<string> values = dictionary[word];

            if (values.Count == 1)
            {
                Console.WriteLine("Вы не можете удалить перевод этого слова, так как остался единственный перевод!");
                return;
            }

            Console.WriteLine("\n-------------------------------------------------------------");
            Console.WriteLine($"Какой из переводов слова {word} вы хотите удалить?");



            for (int i = 0; i < values.Count; i++)
            {
                Console.Write($"{i + 1} — {values[i]} ");
            }

            Console.WriteLine();
            int n = int.Parse(Console.ReadLine());

            if (n < 1 || n > values.Count)
            {
                Console.WriteLine("\nВы ввели неверную цифру!");
                return;
            }

            values.Remove(values[n - 1]);
            Console.WriteLine($"Вы успешно удалили вариант перевода для слова {word}");

        }

        public void ChangeWord()
        {
            ShowWordsInDictionary();
            Console.WriteLine("Введите слово, которое хотите изменить: ");
            string word = Console.ReadLine();

            if (!ContainsWord(word))
            {
                Console.WriteLine("\nТакого слова нет в словаре!");
                return;
            }

            Console.WriteLine("Введите новое слово: ");
            string newWord = Console.ReadLine();

            List<string> values = dictionary[word];
            dictionary.Remove(word);
            AddWord(newWord, values);

            Console.WriteLine($"\nСлово {word} было заменено на {newWord}");

        }

        public void ChangeTranslation()
        {
            ShowWordsInDictionary();

            Console.WriteLine("Введите слово, для которого хотите изменить перевод: ");
            string word = Console.ReadLine();

            if (!ContainsWord(word))
            {
                Console.WriteLine("\nТакого слова нет в словаре!");
                return;
            }

            Console.WriteLine("\n-------------------------------------------------------------");
            List<string> values = dictionary[word];

            Console.WriteLine($"\nКакой из переводов слова {word} вы хотите изменить?");

            for (int i = 0; i < values.Count; i++)
            {
                Console.Write($"{i + 1} — {values[i]} ");
            }

            Console.WriteLine();
            int n = int.Parse(Console.ReadLine());

            if (n < 1 || n > values.Count)
            {
                Console.WriteLine("\nВы ввели неверную цифру!");
                return;
            }

            Console.WriteLine("\nВведите новый перевод:");
            string newValue = Console.ReadLine();
            values[n - 1] = newValue;

            Console.WriteLine($"\nВы успешно изменили перевод слова {word}!");

        }

        public void FindWord()
        {
            Console.WriteLine("Введите слово для поиска: ");
            string word = Console.ReadLine();

            if (!ContainsWord(word))
            {
                Console.WriteLine("\nТакого слова нет в словаре!");
                return;
            }
            Console.WriteLine("\n-------------------------------------------------------------");
            Console.Write($"Перевод слова {word} — ");

            List<string> values = dictionary[word];
            string valuesString = string.Join(", ", values);

            Console.WriteLine(valuesString);

            WriteTranslationToFile(word, valuesString, "Результаты_поиска_слов.txt");

        }

        public void SaveToBin(string path)
        {
            using (FileStream fs = new FileStream(path, FileMode.Create))
            {
                BinaryFormatter bf = new BinaryFormatter();
                bf.Serialize(fs, dictionary);
            }
        }


        public void LoadFromBin(string path)
        {
            try
            {
                using (FileStream fs = new FileStream(path, FileMode.Open))
                {
                    BinaryFormatter bf = new BinaryFormatter();
                    dictionary = (Dictionary<string, List<string>>)bf.Deserialize(fs);
                    Console.WriteLine("Словарь успешно загружен из файла.");
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
        }

        public void SaveToText(string path)
        {
            try
            {
                using (StreamWriter sw = new StreamWriter(path))
                {
                    foreach (var kvp in dictionary)
                    {
                        string line = $"{kvp.Key}: {string.Join(", ", kvp.Value)}";
                        sw.WriteLine(line);
                    }
                }
                Console.WriteLine("Словарь успешно сохранен в текстовый файл.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Произошла ошибка при сохранении словаря в текстовый файл: {ex.Message}");
            }
        }

        public void WriteTranslationToFile(string word, string translation, string filePath)
        {
            try
            {
                using (StreamWriter writer = File.AppendText(filePath))
                {
                    writer.WriteLine($"{word}: {translation}");
                    Console.WriteLine("Перевод успешно записан в файл.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Произошла ошибка при записи в файл: {ex.Message}");
            }
        }


    }
}
