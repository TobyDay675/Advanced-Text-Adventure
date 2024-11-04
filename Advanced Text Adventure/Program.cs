using System.Diagnostics.Tracing;
using System.Text.Json;
using System.Text.Json.Serialization;
using static System.Net.Mime.MediaTypeNames;

namespace Advanced_Text_Adventure
{
    internal unsafe partial class Program
    {
        public enum Emotions { Neutral, Happy, Sad, Angry, Flustered, Distant, Infatuated }

        public static List<string> words;
        public static NPC currentNPC;

        static T ReadJson<T>(string filePath)
        {
            var options = new JsonSerializerOptions { WriteIndented = true, IncludeFields = true };
            using StreamReader reader = new(filePath);
            string json2 = reader.ReadToEnd();
            return JsonSerializer.Deserialize<T>(json2, options)!;
        }
        static void WriteJson<T>(T obj, string filePath)
        {
            var options2 = new JsonSerializerOptions { WriteIndented = true };
            string json = JsonSerializer.Serialize(obj, options2);
            using StreamWriter writer = new(filePath);
            writer.Write(json);
            writer.Flush();
        }

        static void Main(string[] args)
        {
            //"E:/VGD/1717222/Advanced Text Adventure/Advanced Text Adventure/.json"
            var title = ReadJson<string[]>("E:/VGD/1717222/Advanced Text Adventure/Advanced Text Adventure/Title.json");
            foreach (var line in title)
            {
                Console.WriteLine(line);
            }

            //var conversation = ReadJson<Conversation>("E:/VGD/1717222/Advanced Text Adventure/Advanced Text Adventure/test2.json");
            //Console.WriteLine(conversation.conversation[0].branches[0].responses[0]);
        
        static T PromptUser<T>()
        {
            try
            {
                string input = Console.ReadLine()!;
                return (T)Convert.ChangeType(input, typeof(T));
            }
            catch
            {
                return PromptUser<T>();
            }
        }

        static void WordArray(string input)
            {
                words = [.. input.ToLower().Split(' ')];

                try
                {
                    int index = Convert.ToInt32(input);
                    words.Add(currentNPC.reactions.ElementAt(index - 1).Key);
                }
                catch
                {
                    
                }

            }

        static void SearchForInterests()
        {
            foreach (var kvp in currentNPC.reactions)
            {
                 if (words.Contains(kvp.Key))
                 {
                    kvp.Value.Invoke(currentNPC);
                 }
                 
            }
        }
        static void InfatuatedCheck()
            {
                if (currentNPC.loveMeter == currentNPC.amountToSeduce)
                {
                    currentNPC.isSwooned = true;
                    currentNPC.emotion = Emotions.Infatuated;
                }
            }
        }

    }
}
