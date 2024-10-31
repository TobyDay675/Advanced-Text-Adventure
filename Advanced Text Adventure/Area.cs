using System.Text.Json.Serialization;

namespace Advanced_Text_Adventure
{
    internal unsafe partial class Program
    {
        [Serializable]
        public struct Area
        {
            [JsonInclude]
            string name;
            [JsonInclude]
            public Event thing;
        }
    }
}
