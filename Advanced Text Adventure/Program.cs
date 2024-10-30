using System.Diagnostics.Tracing;

namespace Advanced_Text_Adventure
{
    internal unsafe partial class Program
    {
        public enum Emotions { Neutral, Happy, Sad, Angry, Flustered, Distant, Infatuated }

        public static List<string> words;
        public static NPC currentNPC;
        static void Main(string[] args)
        {
            currentNPC = practiceManequin;
            Console.WriteLine("Welcome to the test\n");
            Console.WriteLine("In front of you is a test manequin\n");
            Console.WriteLine("What do you want to say to the manequin [type the number of the response you want to make]\n");
            Console.WriteLine("[1] your mom, [2] Cotton knives yuh");
            string input = PromptUser<string>();
            WordArray(input);
            SearchForInterests();
            Console.WriteLine($"Here is how that affected the manequin: Love Meter: {currentNPC.loveMeter}, Emotion: {currentNPC.emotion}");
        
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
                if (currentNPC.loveMeter == 100)
                {
                    currentNPC.isSwooned = true;
                    currentNPC.emotion = Emotions.Infatuated;
                }
            }
        }

    }
}
