using System;
using System.Xml;
using System.Collections.Generic;

namespace Kaltura
{
	public class KalturaPlayableEntry : KalturaBaseEntry
	{
		#region Private Fields
		private int _Plays = Int32.MinValue;
		private int _Views = Int32.MinValue;
		private int _Width = Int32.MinValue;
		private int _Height = Int32.MinValue;
		private int _Duration = Int32.MinValue;
		private int _MsDuration = Int32.MinValue;
		private KalturaDurationType _DurationType = null;
		#endregion

		#region Properties
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
		public int Width
		{
			get { return _Width; }
			set 
			{ 
				_Width = value;
				OnPropertyChanged("Width");
			}
		}
		public int Height
		{
			get { return _Height; }
			set 
			{ 
				_Height = value;
				OnPropertyChanged("Height");
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
		public int MsDuration
		{
			get { return _MsDuration; }
			set 
			{ 
				_MsDuration = value;
				OnPropertyChanged("MsDuration");
			}
		}
		public KalturaDurationType DurationType
		{
			get { return _DurationType; }
			set 
			{ 
				_DurationType = value;
				OnPropertyChanged("DurationType");
			}
		}
		#endregion

		#region CTor
		public KalturaPlayableEntry()
		{
		}

		public KalturaPlayableEntry(XmlElement node) : base(node)
		{
			foreach (XmlElement propertyNode in node.ChildNodes)
			{
				string txt = propertyNode.InnerText;
				switch (propertyNode.Name)
				{
					case "plays":
						this.Plays = ParseInt(txt);
						continue;
					case "views":
						this.Views = ParseInt(txt);
						continue;
					case "width":
						this.Width = ParseInt(txt);
						continue;
					case "height":
						this.Height = ParseInt(txt);
						continue;
					case "duration":
						this.Duration = ParseInt(txt);
						continue;
					case "msDuration":
						this.MsDuration = ParseInt(txt);
						continue;
					case "durationType":
						this.DurationType = (KalturaDurationType)KalturaStringEnum.Parse(typeof(KalturaDurationType), txt);
						continue;
				}
			}
		}
		#endregion

		#region Methods
		public override KalturaParams ToParams()
		{
			KalturaParams kparams = base.ToParams();
			kparams.AddIntIfNotNull("plays", this.Plays);
			kparams.AddIntIfNotNull("views", this.Views);
			kparams.AddIntIfNotNull("width", this.Width);
			kparams.AddIntIfNotNull("height", this.Height);
			kparams.AddIntIfNotNull("duration", this.Duration);
			kparams.AddIntIfNotNull("msDuration", this.MsDuration);
			kparams.AddStringEnumIfNotNull("durationType", this.DurationType);
			return kparams;
		}
		#endregion
	}
}

