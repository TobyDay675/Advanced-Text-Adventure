using System.Text.Json.Serialization;

namespace Advanced_Text_Adventure
{
    internal unsafe partial class Program
    {
        [Serializable]
        public struct Event
        {
            [JsonInclude]
            public Action eventThatHappens;
        }

    }
}
