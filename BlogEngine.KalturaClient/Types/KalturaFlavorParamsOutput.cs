using System;
using System.Xml;
using System.Collections.Generic;

namespace Kaltura
{
	public class KalturaFlavorParamsOutput : KalturaFlavorParams
	{
		#region Private Fields
		private int _FlavorParamsId = Int32.MinValue;
		private string _CommandLinesStr = null;
		private string _FlavorParamsVersion = null;
		private string _FlavorAssetId = null;
		private string _FlavorAssetVersion = null;
		private int _ReadyBehavior = Int32.MinValue;
		#endregion

		#region Properties
		public int FlavorParamsId
		{
			get { return _FlavorParamsId; }
			set 
			{ 
				_FlavorParamsId = value;
				OnPropertyChanged("FlavorParamsId");
			}
		}
		public string CommandLinesStr
		{
			get { return _CommandLinesStr; }
			set 
			{ 
				_CommandLinesStr = value;
				OnPropertyChanged("CommandLinesStr");
			}
		}
		public string FlavorParamsVersion
		{
			get { return _FlavorParamsVersion; }
			set 
			{ 
				_FlavorParamsVersion = value;
				OnPropertyChanged("FlavorParamsVersion");
			}
		}
		public string FlavorAssetId
		{
			get { return _FlavorAssetId; }
			set 
			{ 
				_FlavorAssetId = value;
				OnPropertyChanged("FlavorAssetId");
			}
		}
		public string FlavorAssetVersion
		{
			get { return _FlavorAssetVersion; }
			set 
			{ 
				_FlavorAssetVersion = value;
				OnPropertyChanged("FlavorAssetVersion");
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
		#endregion

		#region CTor
		public KalturaFlavorParamsOutput()
		{
		}

		public KalturaFlavorParamsOutput(XmlElement node) : base(node)
		{
			foreach (XmlElement propertyNode in node.ChildNodes)
			{
				string txt = propertyNode.InnerText;
				switch (propertyNode.Name)
				{
					case "flavorParamsId":
						this.FlavorParamsId = ParseInt(txt);
						continue;
					case "commandLinesStr":
						this.CommandLinesStr = txt;
						continue;
					case "flavorParamsVersion":
						this.FlavorParamsVersion = txt;
						continue;
					case "flavorAssetId":
						this.FlavorAssetId = txt;
						continue;
					case "flavorAssetVersion":
						this.FlavorAssetVersion = txt;
						continue;
					case "readyBehavior":
						this.ReadyBehavior = ParseInt(txt);
						continue;
				}
			}
		}
		#endregion

		#region Methods
		public override KalturaParams ToParams()
		{
			KalturaParams kparams = base.ToParams();
			kparams.AddIntIfNotNull("flavorParamsId", this.FlavorParamsId);
			kparams.AddStringIfNotNull("commandLinesStr", this.CommandLinesStr);
			kparams.AddStringIfNotNull("flavorParamsVersion", this.FlavorParamsVersion);
			kparams.AddStringIfNotNull("flavorAssetId", this.FlavorAssetId);
			kparams.AddStringIfNotNull("flavorAssetVersion", this.FlavorAssetVersion);
			kparams.AddIntIfNotNull("readyBehavior", this.ReadyBehavior);
			return kparams;
		}
		#endregion
	}
}

