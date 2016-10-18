using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace Halloween4
{
	class MyListViewAdapter : BaseAdapter<Sound>
	{
		private List<Sound> mItems;
		private Context mContext;

		public MyListViewAdapter(Context context,List<Sound> items)
		{
			mItems = items;
			mContext = context;
		}
		public override int Count
		{
			get { return mItems.Count; }
			
		}
		public override long GetItemId(int position)
		{
			return position;
		}

		public override Sound this[int position]
		{
			get
			{
				return mItems[position];
			}
		}

		public override View GetView(int position, View convertView, ViewGroup parent)
		{
			View row = convertView;
			if (row ==null)
			{
				row = LayoutInflater.From(mContext).Inflate(Resource.Layout.listview_row, null, false);

			}

			TextView txtName = row.FindViewById<TextView>(Resource.Id.txtName);
			txtName.Text = mItems[position].Name;

			TextView txtLastName = row.FindViewById <TextView>(Resource.Id.txtDuration);
			txtLastName.Text = mItems[position].Duration;

			

			return row;
		}
	}
}