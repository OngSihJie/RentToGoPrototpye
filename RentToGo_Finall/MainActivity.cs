using Android.App;
using Android.OS;
using Android.Runtime;
using Android.Widget;
using AndroidX.AppCompat.App;
using System.Collections.Generic;
using RentToGo_Finall.Models;
using Android.Content;
using Android.Views;

namespace RentToGo_Finall
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme")]
    public class MainActivity : AppCompatActivity
    {
        ListView PropertyList;
        List<Property> mylist = new List<Property>();
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            Xamarin.Essentials.Platform.Init(this, savedInstanceState);
            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.activity_main);

            PropertyList = FindViewById<ListView>(Resource.Id.listView1);
            mylist = DetailsManager.GetPropertyData();
            PropertyList.Adapter = new DetailsAdapter(this, mylist);
            PropertyList.ItemClick += OnPropertyClick;

        }
        public void OnPropertyClick(object sender, AdapterView.ItemClickEventArgs e)
        {
            var Property_Item = mylist[e.Position];

            var View_Property = new Intent(this, typeof(PropertyDetails));
            View_Property.PutExtra("PropertyName", Property_Item.PropertyName);
            View_Property.PutExtra("PropertyRooms", Property_Item.PropertyRoom);
            View_Property.PutExtra("PropertyBaths", Property_Item.PropertyBath);
            View_Property.PutExtra("PropertyRent", Property_Item.PropertyRent);
            View_Property.PutExtra("PropertyAddress", Property_Item.PropertyAddress);

            StartActivity(View_Property);

        }
        public override bool OnCreateOptionsMenu(IMenu menu)
        {
            menu.Add("Customer Profile");
            return base.OnPrepareOptionsMenu(menu);
        }
        public override bool OnOptionsItemSelected(IMenuItem item)
        {
            var itemTitle = item.TitleFormatted.ToString();

            switch (itemTitle)
            {
                case "Add Student":
                    StartActivity(typeof(EditCustomer));
                    break;
            }
            return base.OnOptionsItemSelected(item);
        }
        public override void OnRequestPermissionsResult(int requestCode, string[] permissions, [GeneratedEnum] Android.Content.PM.Permission[] grantResults)
        {
            Xamarin.Essentials.Platform.OnRequestPermissionsResult(requestCode, permissions, grantResults);

            base.OnRequestPermissionsResult(requestCode, permissions, grantResults);
        }
    }
}