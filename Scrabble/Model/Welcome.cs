namespace Scrabble.Model
{
    public class Welcome
    {
        public static string NumOfPlayersInfo(int num)
        {
            return Scrabble2018.Locales.skin.Model_NumofPlayers, num;
            //This is a {0} players game. --> Number of players:{0}
        }
        public static string WelcomeText
        {
            get { return Scrabble2018.Locales.skin.Model_WelcomePlayers; }
        }

    }
}
