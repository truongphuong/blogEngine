using System;
using System.Xml;
using System.Collections.Generic;

namespace Kaltura
{
	public class KalturaAssetParamsOutput : KalturaAssetParams
	{
		#region Private Fields
		private int _AssetParamsId = Int32.MinValue;
		private string _AssetParamsVersion = null;
		private string _AssetId = null;
		private string _AssetVersion = null;
		private int _ReadyBehavior = Int32.MinValue;
		private KalturaContainerFormat _Format = null;
		#endregion

		#region Properties
		public int AssetParamsId
		{
			get { return _AssetParamsId; }
			set 
			{ 
				_AssetParamsId = value;
				OnPropertyChanged("AssetParamsId");
			}
		}
		public string AssetParamsVersion
		{
			get { return _AssetParamsVersion; }
			set 
			{ 
				_AssetParamsVersion = value;
				OnPropertyChanged("AssetParamsVersion");
			}
		}
		public string AssetId
		{
			get { return _AssetId; }
			set 
			{ 
				_AssetId = value;
				OnPropertyChanged("AssetId");
			}
		}
		public string AssetVersion
		{
			get { return _AssetVersion; }
			set 
			{ 
				_AssetVersion = value;
				OnPropertyChanged("AssetVersion");
			}
		}
		public int ReadyBehavior
		{
			get { return _ReadyBehavior; }
			set 
			{ 
				_ReadyBehavior = value;
				OnPropertyChanged("ReadyBehavior");
			}
		}
		public KalturaContainerFormat Format
		{
			get { return _Format; }
			set 
			{ 
				_Format = value;
				OnPropertyChanged("Format");
			}
		}
		#endregion

		#region CTor
		public KalturaAssetParamsOutput()
		{
		}

		public KalturaAssetParamsOutput(XmlElement node) : base(node)
		{
			foreach (XmlElement propertyNode in node.ChildNodes)
			{
				string txt = propertyNode.InnerText;
				switch (propertyNode.Name)
				{
					case "assetParamsId":
						this.AssetParamsId = ParseInt(txt);
						continue;
					case "assetParamsVersion":
						this.AssetParamsVersion = txt;
						continue;
					case "assetId":
						this.AssetId = txt;
						continue;
					case "assetVersion":
						this.AssetVersion = txt;
						continue;
					case "readyBehavior":
						this.ReadyBehavior = ParseInt(txt);
						continue;
					case "format":
						this.Format = (KalturaContainerFormat)KalturaStringEnum.Parse(typeof(KalturaContainerFormat), txt);
						continue;
				}
			}
		}
		#endregion

		#region Methods
		public override KalturaParams ToParams()
		{
			KalturaParams kparams = base.ToParams();
			kparams.AddIntIfNotNull("assetParamsId", this.AssetParamsId);
			kparams.AddStringIfNotNull("assetParamsVersion", this.AssetParamsVersion);
			kparams.AddStringIfNotNull("assetId", this.AssetId);
			kparams.AddStringIfNotNull("assetVersion", this.AssetVersion);
			kparams.AddIntIfNotNull("readyBehavior", this.ReadyBehavior);
			kparams.AddStringEnumIfNotNull("format", this.Format);
			return kparams;
		}
		#endregion
	}
}

