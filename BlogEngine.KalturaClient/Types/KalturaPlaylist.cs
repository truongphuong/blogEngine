using System;
using System.Xml;
using System.Collections.Generic;

namespace Kaltura
{
	public class KalturaPlaylist : KalturaBaseEntry
	{
		#region Private Fields
		private string _PlaylistContent = null;
		private IList<KalturaMediaEntryFilterForPlaylist> _Filters;
		private int _TotalResults = Int32.MinValue;
		private KalturaPlaylistType _PlaylistType = (KalturaPlaylistType)Int32.MinValue;
		private int _Plays = Int32.MinValue;
		private int _Views = Int32.MinValue;
		private int _Duration = Int32.MinValue;
		#endregion

		#region Properties
		public string PlaylistContent
		{
			get { return _PlaylistContent; }
			set 
			{ 
				_PlaylistContent = value;
				OnPropertyChanged("PlaylistContent");
			}
		}
		public IList<KalturaMediaEntryFilterForPlaylist> Filters
		{
			get { return _Filters; }
			set 
			{ 
				_Filters = value;
				OnPropertyChanged("Filters");
			}
		}
		public int TotalResults
		{
			get { return _TotalResults; }
			set 
			{ 
				_TotalResults = value;
				OnPropertyChanged("TotalResults");
			}
		}
		public KalturaPlaylistType PlaylistType
		{
			get { return _PlaylistType; }
			set 
			{ 
				_PlaylistType = value;
				OnPropertyChanged("PlaylistType");
			}
		}
		public int Plays
		{
			get { return _Plays; }
			set 
			{ 
				_Plays = value;
				OnPropertyChanged("Plays");
			}
		}
		public int Views
		{
			get { return _Views; }
			set 
			{ 
				_Views = value;
				OnPropertyChanged("Views");
			}
		}
		public int Duration
		{
			get { return _Duration; }
			set 
			{ 
				_Duration = value;
				OnPropertyChanged("Duration");
			}
		}
		#endregion

		#region CTor
		public KalturaPlaylist()
		{
		}

		public KalturaPlaylist(XmlElement node) : base(node)
		{
			foreach (XmlElement propertyNode in node.ChildNodes)
			{
				string txt = propertyNode.InnerText;
				switch (propertyNode.Name)
				{
					case "playlistContent":
						this.PlaylistContent = txt;
						continue;
					case "filters":
						this.Filters = new List<KalturaMediaEntryFilterForPlaylist>();
						foreach(XmlElement arrayNode in propertyNode.ChildNodes)
						{
							this.Filters.Add((KalturaMediaEntryFilterForPlaylist)KalturaObjectFactory.Create(arrayNode));
						}
						continue;
					case "totalResults":
						this.TotalResults = ParseInt(txt);
						continue;
					case "playlistType":
						this.PlaylistType = (KalturaPlaylistType)ParseEnum(typeof(KalturaPlaylistType), txt);
						continue;
					case "plays":
						this.Plays = ParseInt(txt);
						continue;
					case "views":
						this.Views = ParseInt(txt);
						continue;
					case "duration":
						this.Duration = ParseInt(txt);
						continue;
				}
			}
		}
		#endregion

		#region Methods
		public override KalturaParams ToParams()
		{
			KalturaParams kparams = base.ToParams();
			kparams.AddStringIfNotNull("playlistContent", this.PlaylistContent);
			if (this.Filters != null)
			{
				if (this.Filters.Count == 0)
				{
					kparams.Add("filters:-", "");
				}
				else
				{
					int i = 0;
					foreach (KalturaMediaEntryFilterForPlaylist item in this.Filters)
					{
						kparams.Add("filters:" + i + ":objectType", item.GetType().Name);
						kparams.Add("filters:" + i, item.ToParams());
						i++;
					}
				}
			}
			kparams.AddIntIfNotNull("totalResults", this.TotalResults);
			kparams.AddEnumIfNotNull("playlistType", this.PlaylistType);
			kparams.AddIntIfNotNull("plays", this.Plays);
			kparams.AddIntIfNotNull("views", this.Views);
			kparams.AddIntIfNotNull("duration", this.Duration);
			return kparams;
		}
		#endregion
	}
}

