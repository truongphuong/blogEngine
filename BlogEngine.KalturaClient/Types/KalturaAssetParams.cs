using System;
using System.Xml;
using System.Collections.Generic;

namespace Kaltura
{
	public class KalturaAssetParams : KalturaObjectBase
	{
		#region Private Fields
		private int _Id = Int32.MinValue;
		private int _PartnerId = Int32.MinValue;
		private string _Name = null;
		private string _SystemName = null;
		private string _Description = null;
		private int _CreatedAt = Int32.MinValue;
		private KalturaNullableBoolean _IsSystemDefault = (KalturaNullableBoolean)Int32.MinValue;
		private string _Tags = null;
		private IList<KalturaString> _RequiredPermissions;
		#endregion

		#region Properties
		public int Id
		{
			get { return _Id; }
			set 
			{ 
				_Id = value;
				OnPropertyChanged("Id");
			}
		}
		public int PartnerId
		{
			get { return _PartnerId; }
			set 
			{ 
				_PartnerId = value;
				OnPropertyChanged("PartnerId");
			}
		}
		public string Name
		{
			get { return _Name; }
			set 
			{ 
				_Name = value;
				OnPropertyChanged("Name");
			}
		}
		public string SystemName
		{
			get { return _SystemName; }
			set 
			{ 
				_SystemName = value;
				OnPropertyChanged("SystemName");
			}
		}
		public string Description
		{
			get { return _Description; }
			set 
			{ 
				_Description = value;
				OnPropertyChanged("Description");
			}
		}
		public int CreatedAt
		{
			get { return _CreatedAt; }
			set 
			{ 
				_CreatedAt = value;
				OnPropertyChanged("CreatedAt");
			}
		}
		public KalturaNullableBoolean IsSystemDefault
		{
			get { return _IsSystemDefault; }
			set 
			{ 
				_IsSystemDefault = value;
				OnPropertyChanged("IsSystemDefault");
			}
		}
		public string Tags
		{
			get { return _Tags; }
			set 
			{ 
				_Tags = value;
				OnPropertyChanged("Tags");
			}
		}
		public IList<KalturaString> RequiredPermissions
		{
			get { return _RequiredPermissions; }
			set 
			{ 
				_RequiredPermissions = value;
				OnPropertyChanged("RequiredPermissions");
			}
		}
		#endregion

		#region CTor
		public KalturaAssetParams()
		{
		}

		public KalturaAssetParams(XmlElement node)
		{
			foreach (XmlElement propertyNode in node.ChildNodes)
			{
				string txt = propertyNode.InnerText;
				switch (propertyNode.Name)
				{
					case "id":
						this.Id = ParseInt(txt);
						continue;
					case "partnerId":
						this.PartnerId = ParseInt(txt);
						continue;
					case "name":
						this.Name = txt;
						continue;
					case "systemName":
						this.SystemName = txt;
						continue;
					case "description":
						this.Description = txt;
						continue;
					case "createdAt":
						this.CreatedAt = ParseInt(txt);
						continue;
					case "isSystemDefault":
						this.IsSystemDefault = (KalturaNullableBoolean)ParseEnum(typeof(KalturaNullableBoolean), txt);
						continue;
					case "tags":
						this.Tags = txt;
						continue;
					case "requiredPermissions":
						this.RequiredPermissions = new List<KalturaString>();
						foreach(XmlElement arrayNode in propertyNode.ChildNodes)
						{
							this.RequiredPermissions.Add((KalturaString)KalturaObjectFactory.Create(arrayNode));
						}
						continue;
				}
			}
		}
		#endregion

		#region Methods
		public override KalturaParams ToParams()
		{
			KalturaParams kparams = base.ToParams();
			kparams.AddIntIfNotNull("id", this.Id);
			kparams.AddIntIfNotNull("partnerId", this.PartnerId);
			kparams.AddStringIfNotNull("name", this.Name);
			kparams.AddStringIfNotNull("systemName", this.SystemName);
			kparams.AddStringIfNotNull("description", this.Description);
			kparams.AddIntIfNotNull("createdAt", this.CreatedAt);
			kparams.AddEnumIfNotNull("isSystemDefault", this.IsSystemDefault);
			kparams.AddStringIfNotNull("tags", this.Tags);
			if (this.RequiredPermissions != null)
			{
				if (this.RequiredPermissions.Count == 0)
				{
					kparams.Add("requiredPermissions:-", "");
				}
				else
				{
					int i = 0;
					foreach (KalturaString item in this.RequiredPermissions)
					{
						kparams.Add("requiredPermissions:" + i + ":objectType", item.GetType().Name);
						kparams.Add("requiredPermissions:" + i, item.ToParams());
						i++;
					}
				}
			}
			return kparams;
		}
		#endregion
	}
}

