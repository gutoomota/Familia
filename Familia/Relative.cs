using System;

using Android.Content;
using Android.Content.Res;

namespace Familia
{
	public class Relative
	{
		public string Nome;
		public string Apelido;
		public int Foto;

		public Relative (Context context, string apelido, string nome, string foto)
		{
			Nome = nome;
			Apelido = apelido;
			// Get the Resources object from our context
			//Resources res = context.Resources;
			// Get the string resource, like above.
			//Foto = res.GetIdentifier("Icon", "drawable", context.PackageName);
			Foto = Resource.Drawable.Icon;
		}
	}
}

