using System.Windows;

namespace TextAdventureGame.Sources.AI
{
    public class Narrator
    {
        APICaller apiCaller = new APICaller();
        public Narrator() { }
        public async Task<string> SendActionToAI(string action)
        {
            try
            {
                await apiCaller.APICall(action);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return "";
            }
            return apiCaller.GetResponse();
        }
    }
}
