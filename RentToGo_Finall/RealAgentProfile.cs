using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RentToGo_Finall
{
    [Activity(Label = "Agent_Activity")]
    public class RealAgentProfile : Activity
    {
        int Agent_Id;
        TextView txt_Agent_Name;
        TextView txt_Agent_Email;
        TextView txt_Agent_Mobile;

        Button btn_SMS;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Create your application here
            SetContentView(Resource.Layout.AgentProfile);

            txt_Agent_Name = FindViewById<TextView>(Resource.Id.agentname);
            txt_Agent_Email = FindViewById<TextView>(Resource.Id.agentemail);
            txt_Agent_Mobile = FindViewById<TextView>(Resource.Id.agentphn);
            btn_SMS = FindViewById<Button>(Resource.Id.agentsms);

            Agent_Id = Intent.GetIntExtra("AgentId", -1); //-1 is default 
            txt_Agent_Name.Text = Intent.GetStringExtra("Agent_Name");
            txt_Agent_Email.Text = Intent.GetStringExtra("Agent_Email");
            txt_Agent_Mobile.Text = Intent.GetStringExtra("Agent_Mobile");

            btn_SMS.Click += Btn_SMS_Click;
        }

        private void Btn_SMS_Click(object sender, EventArgs e)
        {
            var smsUri = Android.Net.Uri.Parse("smsto:8015275711");
            var smsIntent = new Intent(Intent.ActionSendto, smsUri);
            smsIntent.PutExtra("sms_body", "Hi, I am interested in the house at <ADDRESS>you have posted for rent. Could I please have more details?");
            StartActivity(smsIntent);
        }
    }
}