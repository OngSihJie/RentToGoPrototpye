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
    class AgentAdapter : BaseAdapter<Agent>
    {
        private readonly Activity context;
        private readonly List<Agent> agentdetail;
        public AgentAdapter(Activity context, List<Agent> agentdetail)
        {
            this.context = context;
            this.agentdetail = agentdetail;
        }
        public override Agent this[int position]
        {
            get { return agentdetail[position]; }
        }

        public override int Count
        {
            get
            {
                return agentdetail.Count;
            }
        }

        public override long GetItemId(int position)
        {
            return position;
        }

        public override View GetView(int position, View convertView, ViewGroup parent)
        {
            var item = agentdetail[position];
            var view = convertView;
            if (view == null) // no view to re-use, create new
                view = context.LayoutInflater.Inflate(Resource.Layout.AgentProfile, null);
            view.FindViewById<TextView>(Resource.Id.agentname).Text = item.AgentName;
            view.FindViewById<TextView>(Resource.Id.agentemail).Text = item.AgentEmail;
            view.FindViewById<TextView>(Resource.Id.agentphn).Text = item.AgentPhnNumber.ToString();
            return view;
        }



    }
}