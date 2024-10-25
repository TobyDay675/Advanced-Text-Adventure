namespace Advanced_Text_Adventure
{
    internal partial class Program
    {
        public static NPC practiceManequin = new NPC("Practice Manequin", 0, 0, Emotions.Neutral, Interests.Cotton | Interests.Manequins);
        public class NPC
        { 
            public string name;
            public int loveMeter;
            public int seduceAbility;
            public bool isSwooned;
            public Emotions emotion;
            public Interests interests;

            public NPC (string name, int loveMeter, int seduceAbility,  Emotions emotion, Interests interests)
            {
                this.name = name;
                this.loveMeter = loveMeter;
                this.seduceAbility = seduceAbility;
                this.isSwooned = false;
                this.emotion = emotion;
                this.interests = interests;
            }

            public bool HasInterests(Interests interestsList)
            {
                return interests.HasFlag(interestsList);
            }
        }
    }
}
