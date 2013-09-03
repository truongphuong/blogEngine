namespace Kaltura
{
	public sealed class KalturaPartnerOrderBy : KalturaStringEnum
	{
		public static readonly KalturaPartnerOrderBy ID_ASC = new KalturaPartnerOrderBy("+id");
		public static readonly KalturaPartnerOrderBy ID_DESC = new KalturaPartnerOrderBy("-id");
		public static readonly KalturaPartnerOrderBy NAME_ASC = new KalturaPartnerOrderBy("+name");
		public static readonly KalturaPartnerOrderBy NAME_DESC = new KalturaPartnerOrderBy("-name");
		public static readonly KalturaPartnerOrderBy WEBSITE_ASC = new KalturaPartnerOrderBy("+website");
		public static readonly KalturaPartnerOrderBy WEBSITE_DESC = new KalturaPartnerOrderBy("-website");
		public static readonly KalturaPartnerOrderBy CREATED_AT_ASC = new KalturaPartnerOrderBy("+createdAt");
		public static readonly KalturaPartnerOrderBy CREATED_AT_DESC = new KalturaPartnerOrderBy("-createdAt");
		public static readonly KalturaPartnerOrderBy ADMIN_NAME_ASC = new KalturaPartnerOrderBy("+adminName");
		public static readonly KalturaPartnerOrderBy ADMIN_NAME_DESC = new KalturaPartnerOrderBy("-adminName");
		public static readonly KalturaPartnerOrderBy ADMIN_EMAIL_ASC = new KalturaPartnerOrderBy("+adminEmail");
		public static readonly KalturaPartnerOrderBy ADMIN_EMAIL_DESC = new KalturaPartnerOrderBy("-adminEmail");
		public static readonly KalturaPartnerOrderBy STATUS_ASC = new KalturaPartnerOrderBy("+status");
		public static readonly KalturaPartnerOrderBy STATUS_DESC = new KalturaPartnerOrderBy("-status");

		private KalturaPartnerOrderBy(string name) : base(name) { }
	}
}
