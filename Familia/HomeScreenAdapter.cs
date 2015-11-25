using System;
using System.Runtime.Remoting.Contexts;
using System.Collections.Generic;

using Android.App;
using Android.Widget;
using Android.OS;
using Android.Views;

namespace Familia
{
	public class HomeScreenAdapter : BaseAdapter<Relative> {
		List<Relative> items;
		Activity context;
		public HomeScreenAdapter(Activity context, List<Relative> items)
			: base()
		{
			this.context = context;
			this.items = items;
		}
		public override long GetItemId(int position)
		{
			return position;
		}
		public override Relative this[int position]
		{
			get { return items[position]; }
		}
		public override int Count
		{
			get { return items.Count; }
		}
		public override View GetView(int position, View convertView, ViewGroup parent)
		{
			var item = items[position];
			View view = convertView;
			if (view == null) // no view to re-use, create new
				view = context.LayoutInflater.Inflate(Resource.Layout.ListItemRow, null);
			view.FindViewById<TextView>(Resource.Id.Apelido).Text = item.Apelido;
			view.FindViewById<TextView>(Resource.Id.Nome).Text = item.Nome;
			view.FindViewById<ImageView>(Resource.Id.Foto).SetImageResource(item.Foto);
			return view;
		}
	}
}

