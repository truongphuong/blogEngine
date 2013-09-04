namespace Kaltura
{
	public sealed class KalturaEntryDistributionOrderBy : KalturaStringEnum
	{
		public static readonly KalturaEntryDistributionOrderBy CREATED_AT_ASC = new KalturaEntryDistributionOrderBy("+createdAt");
		public static readonly KalturaEntryDistributionOrderBy CREATED_AT_DESC = new KalturaEntryDistributionOrderBy("-createdAt");
		public static readonly KalturaEntryDistributionOrderBy UPDATED_AT_ASC = new KalturaEntryDistributionOrderBy("+updatedAt");
		public static readonly KalturaEntryDistributionOrderBy UPDATED_AT_DESC = new KalturaEntryDistributionOrderBy("-updatedAt");
		public static readonly KalturaEntryDistributionOrderBy SUBMITTED_AT_ASC = new KalturaEntryDistributionOrderBy("+submittedAt");
		public static readonly KalturaEntryDistributionOrderBy SUBMITTED_AT_DESC = new KalturaEntryDistributionOrderBy("-submittedAt");
		public static readonly KalturaEntryDistributionOrderBy SUNRISE_ASC = new KalturaEntryDistributionOrderBy("+sunrise");
		public static readonly KalturaEntryDistributionOrderBy SUNRISE_DESC = new KalturaEntryDistributionOrderBy("-sunrise");
		public static readonly KalturaEntryDistributionOrderBy SUNSET_ASC = new KalturaEntryDistributionOrderBy("+sunset");
		public static readonly KalturaEntryDistributionOrderBy SUNSET_DESC = new KalturaEntryDistributionOrderBy("-sunset");

		private KalturaEntryDistributionOrderBy(string name) : base(name) { }
	}
}
