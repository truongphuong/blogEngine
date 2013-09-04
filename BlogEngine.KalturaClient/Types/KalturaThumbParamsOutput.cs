using System;
using System.Xml;
using System.Collections.Generic;

namespace Kaltura
{
	public class KalturaThumbParamsOutput : KalturaThumbParams
	{
		#region Private Fields
		private int _ThumbParamsId = Int32.MinValue;
		private string _ThumbParamsVersion = null;
		private string _ThumbAssetId = null;
		private string _ThumbAssetVersion = null;
		#endregion

		#region Properties
		public int ThumbParamsId
		{
			get { return _ThumbParamsId; }
			set 
			{ 
				_ThumbParamsId = value;
				OnPropertyChanged("ThumbParamsId");
			}
		}
		public string ThumbParamsVersion
		{
			get { return _ThumbParamsVersion; }
			set 
			{ 
				_ThumbParamsVersion = value;
				OnPropertyChanged("ThumbParamsVersion");
			}
		}
		public string ThumbAssetId
		{
			get { return _ThumbAssetId; }
			set 
			{ 
				_ThumbAssetId = value;
				OnPropertyChanged("ThumbAssetId");
			}
		}
		public string ThumbAssetVersion
		{
			get { return _ThumbAssetVersion; }
			set 
			{ 
				_ThumbAssetVersion = value;
				OnPropertyChanged("ThumbAssetVersion");
			}
		}
		#endregion

		#region CTor
		public KalturaThumbParamsOutput()
		{
		}

		public KalturaThumbParamsOutput(XmlElement node) : base(node)
		{
			foreach (XmlElement propertyNode in node.ChildNodes)
			{
				string txt = propertyNode.InnerText;
				switch (propertyNode.Name)
				{
					case "thumbParamsId":
						this.ThumbParamsId = ParseInt(txt);
						continue;
					case "thumbParamsVersion":
						this.ThumbParamsVersion = txt;
						continue;
					case "thumbAssetId":
						this.ThumbAssetId = txt;
						continue;
					case "thumbAssetVersion":
						this.ThumbAssetVersion = txt;
						continue;
				}
			}
		}
		#endregion

		#region Methods
		public override KalturaParams ToParams()
		{
			KalturaParams kparams = base.ToParams();
			kparams.AddIntIfNotNull("thumbParamsId", this.ThumbParamsId);
			kparams.AddStringIfNotNull("thumbParamsVersion", this.ThumbParamsVersion);
			kparams.AddStringIfNotNull("thumbAssetId", this.ThumbAssetId);
			kparams.AddStringIfNotNull("thumbAssetVersion", this.ThumbAssetVersion);
			return kparams;
		}
		#endregion
	}
}

