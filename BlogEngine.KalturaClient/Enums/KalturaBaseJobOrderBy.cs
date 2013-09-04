namespace Kaltura
{
	public sealed class KalturaBaseJobOrderBy : KalturaStringEnum
	{
		public static readonly KalturaBaseJobOrderBy CREATED_AT_ASC = new KalturaBaseJobOrderBy("+createdAt");
		public static readonly KalturaBaseJobOrderBy CREATED_AT_DESC = new KalturaBaseJobOrderBy("-createdAt");
		public static readonly KalturaBaseJobOrderBy UPDATED_AT_ASC = new KalturaBaseJobOrderBy("+updatedAt");
		public static readonly KalturaBaseJobOrderBy UPDATED_AT_DESC = new KalturaBaseJobOrderBy("-updatedAt");
		public static readonly KalturaBaseJobOrderBy PROCESSOR_EXPIRATION_ASC = new KalturaBaseJobOrderBy("+processorExpiration");
		public static readonly KalturaBaseJobOrderBy PROCESSOR_EXPIRATION_DESC = new KalturaBaseJobOrderBy("-processorExpiration");
		public static readonly KalturaBaseJobOrderBy EXECUTION_ATTEMPTS_ASC = new KalturaBaseJobOrderBy("+executionAttempts");
		public static readonly KalturaBaseJobOrderBy EXECUTION_ATTEMPTS_DESC = new KalturaBaseJobOrderBy("-executionAttempts");
		public static readonly KalturaBaseJobOrderBy LOCK_VERSION_ASC = new KalturaBaseJobOrderBy("+lockVersion");
		public static readonly KalturaBaseJobOrderBy LOCK_VERSION_DESC = new KalturaBaseJobOrderBy("-lockVersion");

		private KalturaBaseJobOrderBy(string name) : base(name) { }
	}
}
