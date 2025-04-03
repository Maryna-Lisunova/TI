namespace MainLibrary
{
    public partial class Stream_encryption
    {
        public static string CreateKey(string key, int LFSR)
        {
            string result_key = "";
            for (int i = 0; i < key.Length; i++)
            {
                if (key[i] == '1' || key[i] == '0')
                {
                    result_key += key[i];
                }
            }

            if (result_key == "")
            {
                throw new Exception("В ключе нет подходящих символов. Измените ключ.");
            }
            else if (result_key.Length != LFSR)
            {
                throw new Exception($"В ключе неверное количество подходящих символов. Должно быть {LFSR} символов нуля или единицы. В данном ключе их {result_key.Length}. Измените ключ.");
            }

            return result_key;
        }        

        public class Menu_class
        {                       
            public static string ReadFromFile(string path)
            {
                string text = "";
                try
                {
                    StreamReader Reater = new StreamReader(path);
                    text = Reater.ReadToEnd();
                    Reater.Close();
                }
                catch (Exception e)
                {
                    throw new Exception("Произошла ошибка при чтении файла!");
                }
                return text;
            }

            public static void WriteToFile(string path, bool is_to_add, string text)
            {
                try
                {
                    StreamWriter Writer = new StreamWriter(path, is_to_add);
                    Writer.WriteLine(text);
                    Writer.Close();
                }
                catch (Exception e)
                {
                    throw new Exception("Произошла ошибка при записи в файл!");
                }
            }            
        }
    }
}
