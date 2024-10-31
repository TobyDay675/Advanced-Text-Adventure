using System.Text.Json.Serialization;

namespace Advanced_Text_Adventure
{
    internal unsafe partial class Program
    {
        [Serializable]
        public struct ConversationLinkedList<T>
        {
            [JsonInclude]
            public T DialoguePiece;
            [JsonInclude]
            public List<T> branches;
        }
        [Serializable]
        public struct Conversation
        {
            [JsonInclude]
            public List<ConversationLinkedList<DialoguePiece>> conversation;
        }

    }
}
