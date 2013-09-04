using System;
using System.Xml;
using System.Collections.Generic;

namespace Kaltura
{
	public class KalturaControlPanelCommandBaseFilter : KalturaFilter
	{
		#region Private Fields
		private int _IdEqual = Int32.MinValue;
		private string _IdIn = null;
		private int _CreatedAtGreaterThanOrEqual = Int32.MinValue;
		private int _CreatedAtLessThanOrEqual = Int32.MinValue;
		private int _CreatedByIdEqual = Int32.MinValue;
		private KalturaControlPanelCommandType _TypeEqual = (KalturaControlPanelCommandType)Int32.MinValue;
		private string _TypeIn = null;
		private KalturaControlPanelCommandTargetType _TargetTypeEqual = (KalturaControlPanelCommandTargetType)Int32.MinValue;
		private string _TargetTypeIn = null;
		private KalturaControlPanelCommandStatus _StatusEqual = (KalturaControlPanelCommandStatus)Int32.MinValue;
		private string _StatusIn = null;
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
		public int CreatedByIdEqual
		{
			get { return _CreatedByIdEqual; }
			set 
			{ 
				_CreatedByIdEqual = value;
				OnPropertyChanged("CreatedByIdEqual");
			}
		}
		public KalturaControlPanelCommandType TypeEqual
		{
			get { return _TypeEqual; }
			set 
			{ 
				_TypeEqual = value;
				OnPropertyChanged("TypeEqual");
			}
		}
		public string TypeIn
		{
			get { return _TypeIn; }
			set 
			{ 
				_TypeIn = value;
				OnPropertyChanged("TypeIn");
			}
		}
		public KalturaControlPanelCommandTargetType TargetTypeEqual
		{
			get { return _TargetTypeEqual; }
			set 
			{ 
				_TargetTypeEqual = value;
				OnPropertyChanged("TargetTypeEqual");
			}
		}
		public string TargetTypeIn
		{
			get { return _TargetTypeIn; }
			set 
			{ 
				_TargetTypeIn = value;
				OnPropertyChanged("TargetTypeIn");
			}
		}
		public KalturaControlPanelCommandStatus StatusEqual
		{
			get { return _StatusEqual; }
			set 
			{ 
				_StatusEqual = value;
				OnPropertyChanged("StatusEqual");
			}
		}
		public string StatusIn
		{
			get { return _StatusIn; }
			set 
			{ 
				_StatusIn = value;
				OnPropertyChanged("StatusIn");
			}
		}
		#endregion

		#region CTor
		public KalturaControlPanelCommandBaseFilter()
		{
		}

		public KalturaControlPanelCommandBaseFilter(XmlElement node) : base(node)
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
					case "createdByIdEqual":
						this.CreatedByIdEqual = ParseInt(txt);
						continue;
					case "typeEqual":
						this.TypeEqual = (KalturaControlPanelCommandType)ParseEnum(typeof(KalturaControlPanelCommandType), txt);
						continue;
					case "typeIn":
						this.TypeIn = txt;
						continue;
					case "targetTypeEqual":
						this.TargetTypeEqual = (KalturaControlPanelCommandTargetType)ParseEnum(typeof(KalturaControlPanelCommandTargetType), txt);
						continue;
					case "targetTypeIn":
						this.TargetTypeIn = txt;
						continue;
					case "statusEqual":
						this.StatusEqual = (KalturaControlPanelCommandStatus)ParseEnum(typeof(KalturaControlPanelCommandStatus), txt);
						continue;
					case "statusIn":
						this.StatusIn = txt;
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
			kparams.AddIntIfNotNull("createdByIdEqual", this.CreatedByIdEqual);
			kparams.AddEnumIfNotNull("typeEqual", this.TypeEqual);
			kparams.AddStringIfNotNull("typeIn", this.TypeIn);
			kparams.AddEnumIfNotNull("targetTypeEqual", this.TargetTypeEqual);
			kparams.AddStringIfNotNull("targetTypeIn", this.TargetTypeIn);
			kparams.AddEnumIfNotNull("statusEqual", this.StatusEqual);
			kparams.AddStringIfNotNull("statusIn", this.StatusIn);
			return kparams;
		}
		#endregion
	}
}

