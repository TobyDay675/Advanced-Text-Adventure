namespace Advanced_Text_Adventure
{
    internal unsafe partial class Program
    {
        [Serializable]
        public struct Conversation
        {
            LinkedList<DialoguePiece> dialogueBranches;
        }

    }
}
