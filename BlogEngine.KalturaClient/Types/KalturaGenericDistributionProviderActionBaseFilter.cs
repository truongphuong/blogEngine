using System;
using System.Xml;
using System.Collections.Generic;

namespace Kaltura
{
	public class KalturaGenericDistributionProviderActionBaseFilter : KalturaFilter
	{
		#region Private Fields
		private int _IdEqual = Int32.MinValue;
		private string _IdIn = null;
		private int _CreatedAtGreaterThanOrEqual = Int32.MinValue;
		private int _CreatedAtLessThanOrEqual = Int32.MinValue;
		private int _UpdatedAtGreaterThanOrEqual = Int32.MinValue;
		private int _UpdatedAtLessThanOrEqual = Int32.MinValue;
		private int _GenericDistributionProviderIdEqual = Int32.MinValue;
		private string _GenericDistributionProviderIdIn = null;
		private KalturaDistributionAction _ActionEqual = (KalturaDistributionAction)Int32.MinValue;
		private string _ActionIn = null;
		#endregion

		#region Properties
		public int IdEqual
		{
			get { return _IdEqual; }
			set 
			{ 
				_IdEqual = value;
				OnPropertyChanged("IdEqual");
			}
		}
		public string IdIn
		{
			get { return _IdIn; }
			set 
			{ 
				_IdIn = value;
				OnPropertyChanged("IdIn");
			}
		}
		public int CreatedAtGreaterThanOrEqual
		{
			get { return _CreatedAtGreaterThanOrEqual; }
			set 
			{ 
				_CreatedAtGreaterThanOrEqual = value;
				OnPropertyChanged("CreatedAtGreaterThanOrEqual");
			}
		}
		public int CreatedAtLessThanOrEqual
		{
			get { return _CreatedAtLessThanOrEqual; }
			set 
			{ 
				_CreatedAtLessThanOrEqual = value;
				OnPropertyChanged("CreatedAtLessThanOrEqual");
			}
		}
		public int UpdatedAtGreaterThanOrEqual
		{
			get { return _UpdatedAtGreaterThanOrEqual; }
			set 
			{ 
				_UpdatedAtGreaterThanOrEqual = value;
				OnPropertyChanged("UpdatedAtGreaterThanOrEqual");
			}
		}
		public int UpdatedAtLessThanOrEqual
		{
			get { return _UpdatedAtLessThanOrEqual; }
			set 
			{ 
				_UpdatedAtLessThanOrEqual = value;
				OnPropertyChanged("UpdatedAtLessThanOrEqual");
			}
		}
		public int GenericDistributionProviderIdEqual
		{
			get { return _GenericDistributionProviderIdEqual; }
			set 
			{ 
				_GenericDistributionProviderIdEqual = value;
				OnPropertyChanged("GenericDistributionProviderIdEqual");
			}
		}
		public string GenericDistributionProviderIdIn
		{
			get { return _GenericDistributionProviderIdIn; }
			set 
			{ 
				_GenericDistributionProviderIdIn = value;
				OnPropertyChanged("GenericDistributionProviderIdIn");
			}
		}
		public KalturaDistributionAction ActionEqual
		{
			get { return _ActionEqual; }
			set 
			{ 
				_ActionEqual = value;
				OnPropertyChanged("ActionEqual");
			}
		}
		public string ActionIn
		{
			get { return _ActionIn; }
			set 
			{ 
				_ActionIn = value;
				OnPropertyChanged("ActionIn");
			}
		}
		#endregion

		#region CTor
		public KalturaGenericDistributionProviderActionBaseFilter()
		{
		}

		public KalturaGenericDistributionProviderActionBaseFilter(XmlElement node) : base(node)
		{
			foreach (XmlElement propertyNode in node.ChildNodes)
			{
				string txt = propertyNode.InnerText;
				switch (propertyNode.Name)
				{
					case "idEqual":
						this.IdEqual = ParseInt(txt);
						continue;
					case "idIn":
						this.IdIn = txt;
						continue;
					case "createdAtGreaterThanOrEqual":
						this.CreatedAtGreaterThanOrEqual = ParseInt(txt);
						continue;
					case "createdAtLessThanOrEqual":
						this.CreatedAtLessThanOrEqual = ParseInt(txt);
						continue;
					case "updatedAtGreaterThanOrEqual":
						this.UpdatedAtGreaterThanOrEqual = ParseInt(txt);
						continue;
					case "updatedAtLessThanOrEqual":
						this.UpdatedAtLessThanOrEqual = ParseInt(txt);
						continue;
					case "genericDistributionProviderIdEqual":
						this.GenericDistributionProviderIdEqual = ParseInt(txt);
						continue;
					case "genericDistributionProviderIdIn":
						this.GenericDistributionProviderIdIn = txt;
						continue;
					case "actionEqual":
						this.ActionEqual = (KalturaDistributionAction)ParseEnum(typeof(KalturaDistributionAction), txt);
						continue;
					case "actionIn":
						this.ActionIn = txt;
						continue;
				}
			}
		}
		#endregion

		#region Methods
		public override KalturaParams ToParams()
		{
			KalturaParams kparams = base.ToParams();
			kparams.AddIntIfNotNull("idEqual", this.IdEqual);
			kparams.AddStringIfNotNull("idIn", this.IdIn);
			kparams.AddIntIfNotNull("createdAtGreaterThanOrEqual", this.CreatedAtGreaterThanOrEqual);
			kparams.AddIntIfNotNull("createdAtLessThanOrEqual", this.CreatedAtLessThanOrEqual);
			kparams.AddIntIfNotNull("updatedAtGreaterThanOrEqual", this.UpdatedAtGreaterThanOrEqual);
			kparams.AddIntIfNotNull("updatedAtLessThanOrEqual", this.UpdatedAtLessThanOrEqual);
			kparams.AddIntIfNotNull("genericDistributionProviderIdEqual", this.GenericDistributionProviderIdEqual);
			kparams.AddStringIfNotNull("genericDistributionProviderIdIn", this.GenericDistributionProviderIdIn);
			kparams.AddEnumIfNotNull("actionEqual", this.ActionEqual);
			kparams.AddStringIfNotNull("actionIn", this.ActionIn);
			return kparams;
		}
		#endregion
	}
}

