namespace Advanced_Text_Adventure
{
    internal partial class Program
    {
        [Flags]
        public enum Interests 
        { 
            Space = 1,
            Anime = 2,
            Science = 4,
            Dogs = 8,
            Cats = 16,
            Cotton = 32,
            Manequins = 64,
        }
        public enum Emotions { Neutral, Happy, Sad, Angry, Flustered, Distant, Infatuated}

       

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
    }
}
