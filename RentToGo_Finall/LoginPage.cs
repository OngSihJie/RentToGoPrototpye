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
    [Activity(Label = "LoginPage", MainLauncher = true) ]
    public class LoginPage : Activity
    {
        EditText username, password;
        Button btnlogin, btnregister;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.LoginPage);

            // Create your application here
            username = FindViewById<EditText>(Resource.Id.lgnusername);
            password = FindViewById<EditText>(Resource.Id.lgnpassword);
            btnlogin = FindViewById<Button>(Resource.Id.btnlogin);
           btnlogin.Click += OnLgnClick;
            btnregister = FindViewById<Button>(Resource.Id.btnregister);
            btnregister.Click += OnButtonClick;
        }
       public void OnLgnClick(object sender, EventArgs e)
        {
            var mainpage = new Intent(this, typeof(MainPage));

            StartActivity(mainpage);
            //var agentprofile = new Intent(this, typeof(AgentProfile));

            //StartActivity(agentprofile);

        }
        public void OnButtonClick(object sender, EventArgs e)
        {
            var registerpage = new Intent(this, typeof(Registration));

            StartActivity(registerpage);

        }
    }
}
