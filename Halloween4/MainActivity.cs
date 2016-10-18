using System;
using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;
using System.Collections.Generic;

namespace Halloween4
{
	[Activity(Label = "Halloween4", MainLauncher = true, Icon = "@drawable/icon")]
	public class MainActivity : Activity
	{
		
		private List<Sound> mItems;
		private ListView mListView;


		protected override void OnCreate(Bundle bundle)
		{
			base.OnCreate(bundle);

			// Set our view from the "main" layout resource
			SetContentView(Resource.Layout.Main);
			mListView = FindViewById<ListView>(Resource.Id.myListView);

			

			mItems = new List<Sound>();


			mItems.Add(new Halloween4.Sound() { Name = "Creaking Doors", Duration = "6s" });
			mItems.Add(new Halloween4.Sound() { Name = "Howling", Duration = "7s" });
			mItems.Add(new Halloween4.Sound() { Name = "Adams Family", Duration = "2 min" });
			MyListViewAdapter adapter = new MyListViewAdapter(this, mItems);
			mListView.Adapter = adapter;


			mListView.ItemClick += MListView_ItemClick;




		}
		//used to do soemthing with an itemd lick in our list view
		private void MListView_ItemClick(object sender, AdapterView.ItemClickEventArgs e)
		{
			Console.WriteLine(mItems[e.Position].Name);
			
		}
	}
}

