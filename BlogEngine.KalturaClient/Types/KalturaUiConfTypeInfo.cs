using System;
using System.Xml;
using System.Collections.Generic;

namespace Kaltura
{
	public class KalturaUiConfTypeInfo : KalturaObjectBase
	{
		#region Private Fields
		private KalturaUiConfObjType _Type = (KalturaUiConfObjType)Int32.MinValue;
		private IList<KalturaString> _Versions;
		private string _Directory = null;
		private string _Filename = null;
		#endregion

		#region Properties
		public KalturaUiConfObjType Type
		{
			get { return _Type; }
			set 
			{ 
				_Type = value;
				OnPropertyChanged("Type");
			}
		}
		public IList<KalturaString> Versions
		{
			get { return _Versions; }
			set 
			{ 
				_Versions = value;
				OnPropertyChanged("Versions");
			}
		}
		public string Directory
		{
			get { return _Directory; }
			set 
			{ 
				_Directory = value;
				OnPropertyChanged("Directory");
			}
		}
		public string Filename
		{
			get { return _Filename; }
			set 
			{ 
				_Filename = value;
				OnPropertyChanged("Filename");
			}
		}
		#endregion

		#region CTor
		public KalturaUiConfTypeInfo()
		{
		}

		public KalturaUiConfTypeInfo(XmlElement node)
		{
			foreach (XmlElement propertyNode in node.ChildNodes)
			{
				string txt = propertyNode.InnerText;
				switch (propertyNode.Name)
				{
					case "type":
						this.Type = (KalturaUiConfObjType)ParseEnum(typeof(KalturaUiConfObjType), txt);
						continue;
					case "versions":
						this.Versions = new List<KalturaString>();
						foreach(XmlElement arrayNode in propertyNode.ChildNodes)
						{
							this.Versions.Add((KalturaString)KalturaObjectFactory.Create(arrayNode));
						}
						continue;
					case "directory":
						this.Directory = txt;
						continue;
					case "filename":
						this.Filename = txt;
						continue;
				}
			}
		}
		#endregion

		#region Methods
		public override KalturaParams ToParams()
		{
			KalturaParams kparams = base.ToParams();
			kparams.AddEnumIfNotNull("type", this.Type);
			if (this.Versions != null)
			{
				if (this.Versions.Count == 0)
				{
					kparams.Add("versions:-", "");
				}
				else
				{
					int i = 0;
					foreach (KalturaString item in this.Versions)
					{
						kparams.Add("versions:" + i + ":objectType", item.GetType().Name);
						kparams.Add("versions:" + i, item.ToParams());
						i++;
					}
				}
			}
			kparams.AddStringIfNotNull("directory", this.Directory);
			kparams.AddStringIfNotNull("filename", this.Filename);
			return kparams;
		}
		#endregion
	}
}

