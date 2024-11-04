using System.Runtime.CompilerServices;
using System.Text.Json.Serialization;

namespace Advanced_Text_Adventure
{
    internal unsafe partial class Program
    {
        public static NPC practiceManequin = new NPC("Practice Manequin", 0, 2, 0, Emotions.Neutral, 
        new()
        {
            ["cotton"] = (npc) =>
            {
                npc.loveMeter += (npc.loveMeterIncrease - npc.seduceAbility);
                npc.emotion = Emotions.Happy;
            },
            ["knives"] = (npc) =>
            {
                npc.seduceAbility += 1;
                npc.emotion = Emotions.Sad;
            },
            ["boring"] = (npc) =>
            {
                npc.loveMeter -= 5;
                npc.emotion = Emotions.Angry;
            },
            ["anime"] = (npc) =>
            {
                npc.loveMeter -= npc.loveMeterIncrease + 10;
                npc.emotion = Emotions.Flustered;
            },
            ["garbage"] = (npc) =>
            {
                npc.loveMeter = 0;
                npc.seduceAbility = 100;
                npc.emotion = Emotions.Distant;
            }
        }, 20);

        [Serializable]
        public class NPC
        {
            [JsonInclude]
            public string name;
            [JsonInclude]
            public int loveMeter;
            [JsonInclude]
            public int loveMeterIncrease;
            [JsonInclude]
            public int seduceAbility;
            [JsonInclude]
            public bool isSwooned;
            [JsonInclude]
            public Emotions emotion;
            public Dictionary<string, Action<NPC>> reactions;
            [JsonInclude]
            public int amountToSeduce;

            public NPC (string name, int loveMeter, int loveMeterIncrease, int seduceAbility, Emotions emotion, Dictionary<string, Action<NPC>> reactions, int amountToSeduce)
            {
                this.name = name;
                this.loveMeter = loveMeter;
                this.loveMeterIncrease = loveMeterIncrease;
                this.seduceAbility = seduceAbility;
                this.isSwooned = false;
                this.emotion = emotion;
                this.reactions = reactions;
                this.amountToSeduce = amountToSeduce;
            }
        }
    }
}
