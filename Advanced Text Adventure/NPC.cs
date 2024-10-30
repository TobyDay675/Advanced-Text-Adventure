using System.Runtime.CompilerServices;

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
                npc.loveMeter -= npc.loveMeterIncrease;
                npc.emotion = Emotions.Flustered;
            },
            ["garbage"] = (npc) =>
            {
                npc.loveMeter = 0;
                npc.seduceAbility = 100;
                npc.emotion = Emotions.Distant;
            }
        });
        public class NPC
        { 
            public string name;
            public int loveMeter;
            public int loveMeterIncrease;
            public int seduceAbility;
            public bool isSwooned;
            public Emotions emotion;
            public Dictionary<string, Action<NPC>> reactions;
            public Conversation[] conversations;

            public NPC (string name, int loveMeter, int loveMeterIncrease, int seduceAbility,  Emotions emotion, Dictionary<string, Action<NPC>> reactions, Conversation[] conversations)
            {
                this.name = name;
                this.loveMeter = loveMeter;
                this.loveMeterIncrease = loveMeterIncrease;
                this.seduceAbility = seduceAbility;
                this.isSwooned = false;
                this.emotion = emotion;
                this.reactions = reactions;
                this.conversations = conversations;
            }
        }
    }
}
