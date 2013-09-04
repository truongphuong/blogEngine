using System;
using System.Xml;
using System.Collections.Generic;

namespace Kaltura
{
	public class KalturaModerationFlag : KalturaObjectBase
	{
		#region Private Fields
		private int _Id = Int32.MinValue;
		private int _PartnerId = Int32.MinValue;
		private string _UserId = null;
		private KalturaModerationObjectType _ModerationObjectType = (KalturaModerationObjectType)Int32.MinValue;
		private string _FlaggedEntryId = null;
		private string _FlaggedUserId = null;
		private KalturaModerationFlagStatus _Status = (KalturaModerationFlagStatus)Int32.MinValue;
		private string _Comments = null;
		private KalturaModerationFlagType _FlagType = (KalturaModerationFlagType)Int32.MinValue;
		private int _CreatedAt = Int32.MinValue;
		private int _UpdatedAt = Int32.MinValue;
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
		public string UserId
		{
			get { return _UserId; }
			set 
			{ 
				_UserId = value;
				OnPropertyChanged("UserId");
			}
		}
		public KalturaModerationObjectType ModerationObjectType
		{
			get { return _ModerationObjectType; }
			set 
			{ 
				_ModerationObjectType = value;
				OnPropertyChanged("ModerationObjectType");
			}
		}
		public string FlaggedEntryId
		{
			get { return _FlaggedEntryId; }
			set 
			{ 
				_FlaggedEntryId = value;
				OnPropertyChanged("FlaggedEntryId");
			}
		}
		public string FlaggedUserId
		{
			get { return _FlaggedUserId; }
			set 
			{ 
				_FlaggedUserId = value;
				OnPropertyChanged("FlaggedUserId");
			}
		}
		public KalturaModerationFlagStatus Status
		{
			get { return _Status; }
			set 
			{ 
				_Status = value;
				OnPropertyChanged("Status");
			}
		}
		public string Comments
		{
			get { return _Comments; }
			set 
			{ 
				_Comments = value;
				OnPropertyChanged("Comments");
			}
		}
		public KalturaModerationFlagType FlagType
		{
			get { return _FlagType; }
			set 
			{ 
				_FlagType = value;
				OnPropertyChanged("FlagType");
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
		public int UpdatedAt
		{
			get { return _UpdatedAt; }
			set 
			{ 
				_UpdatedAt = value;
				OnPropertyChanged("UpdatedAt");
			}
		}
		#endregion

		#region CTor
		public KalturaModerationFlag()
		{
		}

		public KalturaModerationFlag(XmlElement node)
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
					case "userId":
						this.UserId = txt;
						continue;
					case "moderationObjectType":
						this.ModerationObjectType = (KalturaModerationObjectType)ParseEnum(typeof(KalturaModerationObjectType), txt);
						continue;
					case "flaggedEntryId":
						this.FlaggedEntryId = txt;
						continue;
					case "flaggedUserId":
						this.FlaggedUserId = txt;
						continue;
					case "status":
						this.Status = (KalturaModerationFlagStatus)ParseEnum(typeof(KalturaModerationFlagStatus), txt);
						continue;
					case "comments":
						this.Comments = txt;
						continue;
					case "flagType":
						this.FlagType = (KalturaModerationFlagType)ParseEnum(typeof(KalturaModerationFlagType), txt);
						continue;
					case "createdAt":
						this.CreatedAt = ParseInt(txt);
						continue;
					case "updatedAt":
						this.UpdatedAt = ParseInt(txt);
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
			kparams.AddStringIfNotNull("userId", this.UserId);
			kparams.AddEnumIfNotNull("moderationObjectType", this.ModerationObjectType);
			kparams.AddStringIfNotNull("flaggedEntryId", this.FlaggedEntryId);
			kparams.AddStringIfNotNull("flaggedUserId", this.FlaggedUserId);
			kparams.AddEnumIfNotNull("status", this.Status);
			kparams.AddStringIfNotNull("comments", this.Comments);
			kparams.AddEnumIfNotNull("flagType", this.FlagType);
			kparams.AddIntIfNotNull("createdAt", this.CreatedAt);
			kparams.AddIntIfNotNull("updatedAt", this.UpdatedAt);
			return kparams;
		}
		#endregion
	}
}

