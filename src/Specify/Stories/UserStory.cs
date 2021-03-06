namespace Specify.Stories
{
    public abstract class UserStory : Story
    {
        private const string I_want_prefix = "I want";
        private const string So_that_prefix = "So that";
        private const string As_a_prefix = "As a";

        public string AsA
        {
            get { return Narrative1; }
            set { Narrative1 = CleanseProperty(value, As_a_prefix); }
        }

        public string IWant
        {
            get { return Narrative2; }
            set { Narrative2 = CleanseProperty(value, I_want_prefix); }
        }

        public string SoThat
        {
            get { return Narrative3; }
            set { Narrative3 = CleanseProperty(value, So_that_prefix); }
        }
    }
}