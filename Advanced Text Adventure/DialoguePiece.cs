﻿using System.Text.Json.Serialization;

namespace Advanced_Text_Adventure
{
    internal unsafe partial class Program
    {
        [Serializable]
        public struct DialoguePiece
        {
            [JsonInclude]
            public string message;
            [JsonInclude]
            public string[] responses;
        }

    }
}
