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
            Ocean = 8,
            FirstPersonShooters = 16,
            WorkingOut = 32,
            Sports = 64,
            FastFood = 128,
            Pop = 256,
            SonicTheHedgehog = 512,

        }
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
    }
}
