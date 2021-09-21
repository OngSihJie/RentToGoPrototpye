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
    [Activity(Label = "MainPage")]
    public class MainPage : Activity
    {
        TextView txtAgentname;
        TextView txtAgentEmail;
        TextView txtAgentPhone;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Create your application here
            SetContentView(Resource.Layout.AgentProfile);
            txtAgentname = FindViewById<TextView>(Resource.Id.agentname);
            txtAgentEmail = FindViewById<TextView>(Resource.Id.agentemail);
            txtAgentPhone = FindViewById<TextView>(Resource.Id.agentphn);


            txtAgentname.Text = Intent.GetStringExtra("AgentName");
            txtAgentEmail.Text = Intent.GetStringExtra("AgentEmail");
            txtAgentPhone.Text = Intent.GetStringExtra("AgentPhone");
        }
    }
}