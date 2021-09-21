using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using RentToGo_Finall.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Android.Telephony;

namespace RentToGo_Finall
{
    [Activity(Label = "AgentProfile")]
    public class AgentProfile : Activity
    {
        //Button agentoffice;
        ListView AgentListView;
        List<Agent> AgentList = new List<Agent>();
        Button btn_agentsms;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            Xamarin.Essentials.Platform.Init(this, savedInstanceState);
            // Create your application here
            SetContentView(Resource.Layout.activity_main);

            AgentListView = FindViewById<ListView>(Resource.Id.listView1);
            AgentList = DetailsManager.GetAgentData();
            AgentListView.Adapter = new AgentAdapter(this, AgentList);
            AgentListView.ItemClick += AgentListView_ItemClick;
            //SetContentView(Resource.Layout.AgentProfile);
            //btn_agentsms = FindViewById<Button>(Resource.Id.agentsms);
            //btn_agentsms.Click += (sender, e) => {
            //    var smsUri = Android.Net.Uri.Parse("smsto:8015275711");
            //    var smsIntent = new Intent(Intent.ActionSendto, smsUri);
            //    smsIntent.PutExtra("sms_body", "Hi, I am interested in the house at <ADDRESS>you have posted for rent. Could I please have more details?");
            //    StartActivity(smsIntent);
            //};
        }

        private void AgentListView_ItemClick(object sender, AdapterView.ItemClickEventArgs e)
        {
            var Agent_Item = AgentList[e.Position];

            var Agent_item = new Intent(this, typeof(RealAgentProfile));
            Agent_item.PutExtra("Agent_Name", Agent_Item.AgentName);
            Agent_item.PutExtra("Agent_Email", Agent_Item.AgentEmail);
            Agent_item.PutExtra("Agent_Mobile", Agent_Item.AgentPhnNumber);
            Agent_item.PutExtra("AgentId", Agent_Item.Id);
            //Toast.MakeText(this, Tutor_Item.Id.ToString(), ToastLength.Long).Show();
            StartActivity(Agent_item);
        }


        //private void Btn_agentsms_Click(object sender, EventArgs e)
        //{
        //    StartActivity(typeof(SMS));
        //}
    }
}