using System.Runtime.CompilerServices;

namespace Advanced_Text_Adventure
{
    internal partial class Program
    {
        public static NPC practiceManequin = new NPC("Practice Manequin", 0, 2, 0, Emotions.Neutral, 
        new()
        {
            ["Cotton"] = () =>
            {
                practiceManequin.loveMeter += (practiceManequin.loveMeterIncrease - practiceManequin.seduceAbility);
                practiceManequin.emotion = Emotions.Happy;
            },
            ["Knives"] = () =>
            {
                practiceManequin.seduceAbility += 1;
                practiceManequin.emotion = Emotions.Sad;
            },
            ["Boring"] = () =>
            {
                practiceManequin.loveMeter -= 5;
                practiceManequin.emotion = Emotions.Angry;
            },
            ["Anime"] = () =>
            {
                practiceManequin.loveMeter -= practiceManequin.loveMeterIncrease;
                practiceManequin.emotion = Emotions.Flustered;
            },

        });
        public struct NPC
        { 
            public string name;
            public int loveMeter;
            public int loveMeterIncrease;
            public int seduceAbility;
            public bool isSwooned;
            public Emotions emotion;
            public Dictionary<string, Action> interestTrigger;

            public NPC (string name, int loveMeter, int loveMeterIncrease, int seduceAbility,  Emotions emotion, Dictionary<string, Action> interestTrigger)
            {
                this.name = name;
                this.loveMeter = loveMeter;
                this.loveMeterIncrease = loveMeterIncrease;
                this.seduceAbility = seduceAbility;
                this.isSwooned = false;
                this.emotion = emotion;
                this.interestTrigger = interestTrigger;
            }
            public static Action infatuate;
            public void InfatuatedCheck()
            {
                if (this.loveMeter == 100)
                {
                    this.isSwooned = true;
                }
            }

        }
    }
}
