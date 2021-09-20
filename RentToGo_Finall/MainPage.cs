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

namespace RentToGo_Finall
{
    //[Activity(Label = "Property Activity")]
    //public class ChristchurchActivity : Activity
    //{
    //    ImageView imgCity;
    //    ListView StudentList;
    //    List<Property> myList = new List<Property>();
    //    protected override void OnCreate(Bundle savedInstanceState)
    //    {
    //        base.OnCreate(savedInstanceState);
    //        SetContentView(Resource.Layout.PropertyDetails);
    //        Xamarin.Essentials.Platform.Init(this, savedInstanceState);
    //        imgCity = FindViewById<ImageView>(Resource.Id.imageView1);
    //        imgCity.SetImageResource(Resource.Drawable.house1);

    //        StudentList = FindViewById<ListView>(Resource.Id.listView1);
    //        myList = DatabaseManager.GetStudentData();
    //        StudentList.Adapter = new DataAdapter(this, myList);


    //    }
    //}
    [Activity(Label = "MainPage")]
    public class MainPage : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Create your application here
            //SetContentView(Resource.Layout.AgentProfile);
        }
    }
}