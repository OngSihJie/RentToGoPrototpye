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
    [Activity(Label = "PropertyDetails")]
    public class PropertyDetails : Activity
    {
        int PropertyId;
        TextView PropertyName, PropertyAddress, PropertyRoom, PropertyBath, PropertyRent;
        ImageView House;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.PropertyDetails);
            PropertyName = FindViewById<TextView>(Resource.Id.housename);
            PropertyAddress = FindViewById<TextView>(Resource.Id.houseaddress);
            PropertyRoom = FindViewById<TextView>(Resource.Id.houserooms);
            PropertyBath = FindViewById<TextView>(Resource.Id.housebath);
            PropertyRent = FindViewById<TextView>(Resource.Id.houserent);
            House = FindViewById<ImageView>(Resource.Drawable.house1);
            // Create your application here



            PropertyId = Intent.GetIntExtra("PropertyId", -1); //-1 is defa
            PropertyName.Text = Intent.GetStringExtra("PropertyName");
            PropertyAddress.Text = Intent.GetStringExtra("PropertyAddress");
            PropertyRoom.Text = Intent.GetStringExtra("PropertyRoom");
            PropertyBath.Text = Intent.GetStringExtra("PropertyBath");
            PropertyRent.Text = Intent.GetStringExtra("PropertyRent");



            if (PropertyName.Text == "Majestic & Magnificent")
            {
                House.SetImageResource(Resource.Drawable.house1);
            }
            else if (PropertyName.Text == "Remura Townhouse")
            {
                House.SetImageResource(Resource.Drawable.house2);
            }
            else if (PropertyName.Text == "Simply Beautiful")
            {
                House.SetImageResource(Resource.Drawable.house3);
            }
        }
    }
}