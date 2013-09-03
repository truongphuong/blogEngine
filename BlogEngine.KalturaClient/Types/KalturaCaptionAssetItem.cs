using System;
using System.Xml;
using System.Collections.Generic;

namespace Kaltura
{
	public class KalturaCaptionAssetItem : KalturaObjectBase
	{
		#region Private Fields
		private KalturaCaptionAsset _Asset;
		private KalturaBaseEntry _Entry;
		private int _StartTime = Int32.MinValue;
		private int _EndTime = Int32.MinValue;
		private string _Content = null;
		#endregion

		#region Properties
		public KalturaCaptionAsset Asset
		{
			get { return _Asset; }
			set 
			{ 
				_Asset = value;
				OnPropertyChanged("Asset");
			}
		}
		public KalturaBaseEntry Entry
		{
			get { return _Entry; }
			set 
			{ 
				_Entry = value;
				OnPropertyChanged("Entry");
			}
		}
		public int StartTime
		{
			get { return _StartTime; }
			set 
			{ 
				_StartTime = value;
				OnPropertyChanged("StartTime");
			}
		}
		public int EndTime
		{
			get { return _EndTime; }
			set 
			{ 
				_EndTime = value;
				OnPropertyChanged("EndTime");
			}
		}
		public string Content
		{
			get { return _Content; }
			set 
			{ 
				_Content = value;
				OnPropertyChanged("Content");
			}
		}
		#endregion

		#region CTor
		public KalturaCaptionAssetItem()
		{
		}

		public KalturaCaptionAssetItem(XmlElement node)
		{
			foreach (XmlElement propertyNode in node.ChildNodes)
			{
				string txt = propertyNode.InnerText;
				switch (propertyNode.Name)
				{
					case "asset":
						this.Asset = (KalturaCaptionAsset)KalturaObjectFactory.Create(propertyNode);
						continue;
					case "entry":
						this.Entry = (KalturaBaseEntry)KalturaObjectFactory.Create(propertyNode);
						continue;
					case "startTime":
						this.StartTime = ParseInt(txt);
						continue;
					case "endTime":
						this.EndTime = ParseInt(txt);
						continue;
					case "content":
						this.Content = txt;
						continue;
				}
			}
		}
		#endregion

		#region Methods
		public override KalturaParams ToParams()
		{
			KalturaParams kparams = base.ToParams();
			if (this.Asset != null)
				kparams.Add("asset", this.Asset.ToParams());
			if (this.Entry != null)
				kparams.Add("entry", this.Entry.ToParams());
			kparams.AddIntIfNotNull("startTime", this.StartTime);
			kparams.AddIntIfNotNull("endTime", this.EndTime);
			kparams.AddStringIfNotNull("content", this.Content);
			return kparams;
		}
		#endregion
	}
}

