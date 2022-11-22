namespace Scrabble.Model
{
    public class Welcome
    {
        public static string NumOfPlayersInfo(int num)
        {
            return "This is a " + num + " players game...";
            //return Scrabble2018.Locales.skin.Model_NumofPlayers, num;
            //Need to ask David how to correctly insert this placeholder
        }
        public static string WelcomeText
        {
            get { return Scrabble2018.Locales.skin.Model_WelcomePlayers; }
        }

    }
}
