using System;
using System.Xml;
using System.Collections.Generic;

namespace Kaltura
{
	public class KalturaDistributionFieldConfig : KalturaObjectBase
	{
		#region Private Fields
		private string _FieldName = null;
		private string _UserFriendlyFieldName = null;
		private string _EntryMrssXslt = null;
		private KalturaDistributionFieldRequiredStatus _IsRequired = (KalturaDistributionFieldRequiredStatus)Int32.MinValue;
		private bool? _UpdateOnChange = false;
		private IList<KalturaString> _UpdateParams;
		private bool? _IsDefault = false;
		#endregion

		#region Properties
		public string FieldName
		{
			get { return _FieldName; }
			set 
			{ 
				_FieldName = value;
				OnPropertyChanged("FieldName");
			}
		}
		public string UserFriendlyFieldName
		{
			get { return _UserFriendlyFieldName; }
			set 
			{ 
				_UserFriendlyFieldName = value;
				OnPropertyChanged("UserFriendlyFieldName");
			}
		}
		public string EntryMrssXslt
		{
			get { return _EntryMrssXslt; }
			set 
			{ 
				_EntryMrssXslt = value;
				OnPropertyChanged("EntryMrssXslt");
			}
		}
		public KalturaDistributionFieldRequiredStatus IsRequired
		{
			get { return _IsRequired; }
			set 
			{ 
				_IsRequired = value;
				OnPropertyChanged("IsRequired");
			}
		}
		public bool? UpdateOnChange
		{
			get { return _UpdateOnChange; }
			set 
			{ 
				_UpdateOnChange = value;
				OnPropertyChanged("UpdateOnChange");
			}
		}
		public IList<KalturaString> UpdateParams
		{
			get { return _UpdateParams; }
			set 
			{ 
				_UpdateParams = value;
				OnPropertyChanged("UpdateParams");
			}
		}
		public bool? IsDefault
		{
			get { return _IsDefault; }
			set 
			{ 
				_IsDefault = value;
				OnPropertyChanged("IsDefault");
			}
		}
		#endregion

		#region CTor
		public KalturaDistributionFieldConfig()
		{
		}

		public KalturaDistributionFieldConfig(XmlElement node)
		{
			foreach (XmlElement propertyNode in node.ChildNodes)
			{
				string txt = propertyNode.InnerText;
				switch (propertyNode.Name)
				{
					case "fieldName":
						this.FieldName = txt;
						continue;
					case "userFriendlyFieldName":
						this.UserFriendlyFieldName = txt;
						continue;
					case "entryMrssXslt":
						this.EntryMrssXslt = txt;
						continue;
					case "isRequired":
						this.IsRequired = (KalturaDistributionFieldRequiredStatus)ParseEnum(typeof(KalturaDistributionFieldRequiredStatus), txt);
						continue;
					case "updateOnChange":
						this.UpdateOnChange = ParseBool(txt);
						continue;
					case "updateParams":
						this.UpdateParams = new List<KalturaString>();
						foreach(XmlElement arrayNode in propertyNode.ChildNodes)
						{
							this.UpdateParams.Add((KalturaString)KalturaObjectFactory.Create(arrayNode));
						}
						continue;
					case "isDefault":
						this.IsDefault = ParseBool(txt);
						continue;
				}
			}
		}
		#endregion

		#region Methods
		public override KalturaParams ToParams()
		{
			KalturaParams kparams = base.ToParams();
			kparams.AddStringIfNotNull("fieldName", this.FieldName);
			kparams.AddStringIfNotNull("userFriendlyFieldName", this.UserFriendlyFieldName);
			kparams.AddStringIfNotNull("entryMrssXslt", this.EntryMrssXslt);
			kparams.AddEnumIfNotNull("isRequired", this.IsRequired);
			kparams.AddBoolIfNotNull("updateOnChange", this.UpdateOnChange);
			if (this.UpdateParams != null)
			{
				if (this.UpdateParams.Count == 0)
				{
					kparams.Add("updateParams:-", "");
				}
				else
				{
					int i = 0;
					foreach (KalturaString item in this.UpdateParams)
					{
						kparams.Add("updateParams:" + i + ":objectType", item.GetType().Name);
						kparams.Add("updateParams:" + i, item.ToParams());
						i++;
					}
				}
			}
			kparams.AddBoolIfNotNull("isDefault", this.IsDefault);
			return kparams;
		}
		#endregion
	}
}

