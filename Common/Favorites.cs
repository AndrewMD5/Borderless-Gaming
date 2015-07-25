﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using Newtonsoft.Json;
using BorderlessGaming.Properties;
using BorderlessGaming.Utilities;
using System.Collections.ObjectModel;
using System.Linq;

namespace BorderlessGaming.Common
{
	public class Favorites : ObservableCollection<Favorites.Favorite>
	{
		private string path;

		public Favorites(string path)
		{
			this.path = path;
			this.CollectionChanged += OnCollectionChanged;
			Load();
		}

		public void OnCollectionChanged(object sender, EventArgs args)
		{
			Save();
		}

		public void Save()
		{
			try
			{
				string jsonDoc = JsonConvert.SerializeObject(this.ToList());

				File.WriteAllText(path, jsonDoc);
			}
			catch (Exception ex)
			{
				MessageBox.Show(string.Format(Resources.ErrorFavoritesSave, ex.Message), Resources.ErrorHeader,
					MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		public void Load()
		{
			if (File.Exists(path))
			{
				string jsonDoc = File.ReadAllText(path);

				try
				{
					var favs = new List<Favorite>(JsonConvert.DeserializeObject<List<Favorite>>(jsonDoc));
					foreach (var fav in favs)
						Add(fav);
				}
				catch
				{
					var favsStringList = new List<string>(JsonConvert.DeserializeObject<List<string>>(jsonDoc));

					foreach (string oldFav in favsStringList)
					{
						Favorite fav = new Favorite();
						fav.Kind = Favorite.FavoriteKinds.ByBinaryName;
						fav.SearchText = oldFav;
						Add(fav);
					}
				}
			}
			else
			{
				Save();
			}
		}

		public bool CanAdd(string item)
		{
			foreach (var fav in this)
				if (fav.SearchText == item)
					return false;
			return true;
		}

		public bool CanRemove(string item)
		{
			return !CanAdd(item);
		}
		
		public Favorite FromProcessDetails(ProcessDetails pd)
		{
			foreach (var fav in this)
			{
				if (fav.Matches(pd))
					return fav;
			}

			return new Favorite() { SearchText = pd.BinaryName };
		}

		public class Favorite
		{
			public FavoriteKinds Kind = FavoriteKinds.ByBinaryName;

			public enum FavoriteKinds : int
			{
				ByBinaryName = 0,
				ByTitleText = 1,
			}

			public SizeModes SizeMode = SizeModes.FullScreen;

			public enum SizeModes : int
			{
				FullScreen = 0,
				SpecificSize = 1,
				NoChange = 2,
			}

			public string SearchText = "";

			public int OffsetL = 0;
			public int OffsetT = 0;
			public int OffsetR = 0;
			public int OffsetB = 0;

			public bool ShouldMaximize = true;

			public int PositionX = 0;
			public int PositionY = 0;
			public int PositionW = 0;
			public int PositionH = 0;

			public bool RemoveMenus = false;
			public bool TopMost = false;
			public bool HideWindowsTaskbar = false;
			public bool HideMouseCursor = false;

			public override string ToString() // so that the ListView control knows how to display this object to the user
			{
				try
				{
					string extra_details = "";

					if (this.Kind == FavoriteKinds.ByBinaryName)
						extra_details += " [Process]";
					else if (this.Kind != FavoriteKinds.ByTitleText)
						extra_details += " [?]";

					extra_details += ((this.ShouldMaximize) ? " [Max]" : "");
					extra_details += ((this.SizeMode == SizeModes.NoChange) ? " [NoSize]" : "");
					extra_details += ((this.TopMost) ? " [Top]" : "");
					extra_details += ((this.RemoveMenus) ? " [NoMenu]" : "");
					extra_details += ((this.HideWindowsTaskbar) ? " [NoTaskbar]" : "");
					extra_details += ((this.HideMouseCursor) ? " [NoMouse]" : "");

					if (this.OffsetL != 0 || this.OffsetR != 0 || this.OffsetT != 0 || this.OffsetB != 0)
						extra_details += " [" + this.OffsetL.ToString() + "L," + this.OffsetR.ToString() + "R," +
							this.OffsetT.ToString() + "T," + this.OffsetB.ToString() + "B]";

					if (this.PositionX != 0 || this.PositionY != 0 || this.PositionW != 0 || this.PositionH != 0)
						extra_details += " [" + this.PositionX.ToString() + "x" + this.PositionY.ToString() + "-" +
							(this.PositionX + this.PositionW).ToString() + "x" + (this.PositionY + this.PositionH).ToString() + "]";

					return this.SearchText + extra_details;
				}
				catch { }

				return "<error>";
			}

			public bool Matches(ProcessDetails pd)
			{
				return (((Kind == FavoriteKinds.ByBinaryName) && (pd.BinaryName == SearchText)) ||
							((Kind == FavoriteKinds.ByTitleText) && (pd.WindowTitle == SearchText)));
			}
		}
	}
}