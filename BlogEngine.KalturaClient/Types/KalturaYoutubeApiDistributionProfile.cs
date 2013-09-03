using System;
using System.Xml;
using System.Collections.Generic;

namespace Kaltura
{
	public class KalturaYoutubeApiDistributionProfile : KalturaDistributionProfile
	{
		#region Private Fields
		private string _Username = null;
		private string _Password = null;
		private string _DefaultCategory = null;
		private string _AllowComments = null;
		private string _AllowEmbedding = null;
		private string _AllowRatings = null;
		private string _AllowResponses = null;
		private int _MetadataProfileId = Int32.MinValue;
		#endregion

		#region Properties
		public string Username
		{
			get { return _Username; }
			set 
			{ 
				_Username = value;
				OnPropertyChanged("Username");
			}
		}
		public string Password
		{
			get { return _Password; }
			set 
			{ 
				_Password = value;
				OnPropertyChanged("Password");
			}
		}
		public string DefaultCategory
		{
			get { return _DefaultCategory; }
			set 
			{ 
				_DefaultCategory = value;
				OnPropertyChanged("DefaultCategory");
			}
		}
		public string AllowComments
		{
			get { return _AllowComments; }
			set 
			{ 
				_AllowComments = value;
				OnPropertyChanged("AllowComments");
			}
		}
		public string AllowEmbedding
		{
			get { return _AllowEmbedding; }
			set 
			{ 
				_AllowEmbedding = value;
				OnPropertyChanged("AllowEmbedding");
			}
		}
		public string AllowRatings
		{
			get { return _AllowRatings; }
			set 
			{ 
				_AllowRatings = value;
				OnPropertyChanged("AllowRatings");
			}
		}
		public string AllowResponses
		{
			get { return _AllowResponses; }
			set 
			{ 
				_AllowResponses = value;
				OnPropertyChanged("AllowResponses");
			}
		}
		public int MetadataProfileId
		{
			get { return _MetadataProfileId; }
			set 
			{ 
				_MetadataProfileId = value;
				OnPropertyChanged("MetadataProfileId");
			}
		}
		#endregion

		#region CTor
		public KalturaYoutubeApiDistributionProfile()
		{
		}

		public KalturaYoutubeApiDistributionProfile(XmlElement node) : base(node)
		{
			foreach (XmlElement propertyNode in node.ChildNodes)
			{
				string txt = propertyNode.InnerText;
				switch (propertyNode.Name)
				{
					case "username":
						this.Username = txt;
						continue;
					case "password":
						this.Password = txt;
						continue;
					case "defaultCategory":
						this.DefaultCategory = txt;
						continue;
					case "allowComments":
						this.AllowComments = txt;
						continue;
					case "allowEmbedding":
						this.AllowEmbedding = txt;
						continue;
					case "allowRatings":
						this.AllowRatings = txt;
						continue;
					case "allowResponses":
						this.AllowResponses = txt;
						continue;
					case "metadataProfileId":
						this.MetadataProfileId = ParseInt(txt);
						continue;
				}
			}
		}
		#endregion

		#region Methods
		public override KalturaParams ToParams()
		{
			KalturaParams kparams = base.ToParams();
			kparams.AddStringIfNotNull("username", this.Username);
			kparams.AddStringIfNotNull("password", this.Password);
			kparams.AddStringIfNotNull("defaultCategory", this.DefaultCategory);
			kparams.AddStringIfNotNull("allowComments", this.AllowComments);
			kparams.AddStringIfNotNull("allowEmbedding", this.AllowEmbedding);
			kparams.AddStringIfNotNull("allowRatings", this.AllowRatings);
			kparams.AddStringIfNotNull("allowResponses", this.AllowResponses);
			kparams.AddIntIfNotNull("metadataProfileId", this.MetadataProfileId);
			return kparams;
		}
		#endregion
	}
}

