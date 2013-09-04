namespace Kaltura
{
	public sealed class KalturaAuditTrailOrderBy : KalturaStringEnum
	{
		public static readonly KalturaAuditTrailOrderBy CREATED_AT_ASC = new KalturaAuditTrailOrderBy("+createdAt");
		public static readonly KalturaAuditTrailOrderBy CREATED_AT_DESC = new KalturaAuditTrailOrderBy("-createdAt");
		public static readonly KalturaAuditTrailOrderBy PARSED_AT_ASC = new KalturaAuditTrailOrderBy("+parsedAt");
		public static readonly KalturaAuditTrailOrderBy PARSED_AT_DESC = new KalturaAuditTrailOrderBy("-parsedAt");

		private KalturaAuditTrailOrderBy(string name) : base(name) { }
	}
}
