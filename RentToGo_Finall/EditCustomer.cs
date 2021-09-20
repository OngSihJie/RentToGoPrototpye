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
    [Activity(Label = "EditCustomer")]
    public class EditCustomer : Activity
    {
        //TextView CustUsername;
        TextView txt_Customer_Name;
        TextView txt_Customer_Address;
        TextView txt_Customer_Mobile;

        Button btn_Edit;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Create your application here
            SetContentView(Resource.Layout.EditCustomer);

            txt_Customer_Name = FindViewById<TextView>(Resource.Id.editcustname);
            txt_Customer_Mobile = FindViewById<TextView>(Resource.Id.editcustphn);
            txt_Customer_Address = FindViewById<TextView>(Resource.Id.editcustaddress);

            btn_Edit = FindViewById<Button>(Resource.Id.btnmakeedit);

            txt_Customer_Name.Text = Intent.GetStringExtra("CustName");
            txt_Customer_Mobile.Text = Intent.GetStringExtra("CustPhnNumber");
            //txt_Customer_Address.Text = Intent.GetStringExtra("CustAddress");
            //CustUsername.Text = Intent.GetStringExtra("CustUsername");//-1 is default

            btn_Edit.Click += Btn_Edit_Click;
        }

        private void Btn_Edit_Click(object sender, EventArgs e)
        {
            //if (txt_Customer_Name.Text != "" && txt_Customer_Mobile.Text != "" && txt_Customer_Address.Text != "")
            //{
            //    // Toast.MakeText(this, Student_Id.ToString(), ToastLength.Long).Show();
            //    DetailsManager.editcustomer(CustUsername.Text, txt_Customer_Name.Text, txt_Customer_Mobile.Text, txt_Customer_Address.Text);
            //    Toast.MakeText(this, "Customer data Updated", ToastLength.Long).Show();
            //    this.Finish();
            //    StartActivity(typeof(MainActivity));
            //}
            //else
            //{
            //    Toast.MakeText(this, "Please fill data in all fields", ToastLength.Long).Show();
            //}
        }
    }
}