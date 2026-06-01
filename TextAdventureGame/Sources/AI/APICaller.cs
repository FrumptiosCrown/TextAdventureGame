using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using Google.GenAI;
using Google.GenAI.Types;
namespace TextAdventureGame.Sources.AI
{
    internal class APICaller
    {
        private string response;
        public APICaller() {}
        public async Task APICall(string content)
        {
            string apikey = System.Environment.GetEnvironmentVariable("GOOGLE_API_KEY");

            if (string.IsNullOrEmpty(apikey))
                throw new Exception("API KEY not found!");

            var client = new Client(apiKey:apikey);
            var AIresponse = await client.Models.GenerateContentAsync(
                model: "gemini-3.5-flash", content);
            response = AIresponse.Candidates[0].Content.Parts[0].Text;
        }
        public string GetResponse() 
        {
            if (string.IsNullOrEmpty(response))
                return "";
            return response;
        }
    }
}
