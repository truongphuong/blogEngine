using System;
using System.Xml;
using System.Collections.Generic;

namespace Kaltura
{
	public class KalturaMixEntry : KalturaPlayableEntry
	{
		#region Private Fields
		private bool? _HasRealThumbnail = false;
		private KalturaEditorType _EditorType = (KalturaEditorType)Int32.MinValue;
		private string _DataContent = null;
		#endregion

		#region Properties
		public bool? HasRealThumbnail
		{
			get { return _HasRealThumbnail; }
			set 
			{ 
				_HasRealThumbnail = value;
				OnPropertyChanged("HasRealThumbnail");
			}
		}
		public KalturaEditorType EditorType
		{
			get { return _EditorType; }
			set 
			{ 
				_EditorType = value;
				OnPropertyChanged("EditorType");
			}
		}
		public string DataContent
		{
			get { return _DataContent; }
			set 
			{ 
				_DataContent = value;
				OnPropertyChanged("DataContent");
			}
		}
		#endregion

		#region CTor
		public KalturaMixEntry()
		{
		}

		public KalturaMixEntry(XmlElement node) : base(node)
		{
			foreach (XmlElement propertyNode in node.ChildNodes)
			{
				string txt = propertyNode.InnerText;
				switch (propertyNode.Name)
				{
					case "hasRealThumbnail":
						this.HasRealThumbnail = ParseBool(txt);
						continue;
					case "editorType":
						this.EditorType = (KalturaEditorType)ParseEnum(typeof(KalturaEditorType), txt);
						continue;
					case "dataContent":
						this.DataContent = txt;
						continue;
				}
			}
		}
		#endregion

		#region Methods
		public override KalturaParams ToParams()
		{
			KalturaParams kparams = base.ToParams();
			kparams.AddBoolIfNotNull("hasRealThumbnail", this.HasRealThumbnail);
			kparams.AddEnumIfNotNull("editorType", this.EditorType);
			kparams.AddStringIfNotNull("dataContent", this.DataContent);
			return kparams;
		}
		#endregion
	}
}

