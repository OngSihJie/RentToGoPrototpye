using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Newtonsoft.Json;
using RentToGo_Finall.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;

namespace RentToGo_Finall
{
    class AgentDataManager
    {
        public static List<Agent> GetAgentData()
        {
            var httpClient = new HttpClient();
            var response = httpClient.GetStringAsync("http://10.0.2.2:53917/api/Agents");
            var Agent_Obj = JsonConvert.DeserializeObject<List<Agent>>(response.Result);
            return Agent_Obj.ToList();
        }
    }
}