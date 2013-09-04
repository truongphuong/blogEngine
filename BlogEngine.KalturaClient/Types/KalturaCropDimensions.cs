using System;
using System.Xml;
using System.Collections.Generic;

namespace Kaltura
{
	public class KalturaCropDimensions : KalturaObjectBase
	{
		#region Private Fields
		private int _Left = Int32.MinValue;
		private int _Top = Int32.MinValue;
		private int _Width = Int32.MinValue;
		private int _Height = Int32.MinValue;
		#endregion

		#region Properties
		public int Left
		{
			get { return _Left; }
			set 
			{ 
				_Left = value;
				OnPropertyChanged("Left");
			}
		}
		public int Top
		{
			get { return _Top; }
			set 
			{ 
				_Top = value;
				OnPropertyChanged("Top");
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
		#endregion

		#region CTor
		public KalturaCropDimensions()
		{
		}

		public KalturaCropDimensions(XmlElement node)
		{
			foreach (XmlElement propertyNode in node.ChildNodes)
			{
				string txt = propertyNode.InnerText;
				switch (propertyNode.Name)
				{
					case "left":
						this.Left = ParseInt(txt);
						continue;
					case "top":
						this.Top = ParseInt(txt);
						continue;
					case "width":
						this.Width = ParseInt(txt);
						continue;
					case "height":
						this.Height = ParseInt(txt);
						continue;
				}
			}
		}
		#endregion

		#region Methods
		public override KalturaParams ToParams()
		{
			KalturaParams kparams = base.ToParams();
			kparams.AddIntIfNotNull("left", this.Left);
			kparams.AddIntIfNotNull("top", this.Top);
			kparams.AddIntIfNotNull("width", this.Width);
			kparams.AddIntIfNotNull("height", this.Height);
			return kparams;
		}
		#endregion
	}
}

