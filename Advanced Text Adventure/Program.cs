namespace Advanced_Text_Adventure
{
    internal partial class Program
    {
        public enum Emotions { Neutral, Happy, Sad, Angry, Flustered, Distant, Infatuated }

        static T PromptUser<T>()
        {
            try
            {
                string input = Console.ReadLine();
                return (T)Convert.ChangeType(input, typeof(T));
            }
            catch
            {
                return PromptUser<T>();
            }
        }

        static void Main(string[] args)
        {
        }

    }
}
