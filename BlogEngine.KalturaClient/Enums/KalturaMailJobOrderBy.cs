namespace Kaltura
{
	public sealed class KalturaMailJobOrderBy : KalturaStringEnum
	{
		public static readonly KalturaMailJobOrderBy CREATED_AT_ASC = new KalturaMailJobOrderBy("+createdAt");
		public static readonly KalturaMailJobOrderBy CREATED_AT_DESC = new KalturaMailJobOrderBy("-createdAt");
		public static readonly KalturaMailJobOrderBy UPDATED_AT_ASC = new KalturaMailJobOrderBy("+updatedAt");
		public static readonly KalturaMailJobOrderBy UPDATED_AT_DESC = new KalturaMailJobOrderBy("-updatedAt");
		public static readonly KalturaMailJobOrderBy PROCESSOR_EXPIRATION_ASC = new KalturaMailJobOrderBy("+processorExpiration");
		public static readonly KalturaMailJobOrderBy PROCESSOR_EXPIRATION_DESC = new KalturaMailJobOrderBy("-processorExpiration");
		public static readonly KalturaMailJobOrderBy EXECUTION_ATTEMPTS_ASC = new KalturaMailJobOrderBy("+executionAttempts");
		public static readonly KalturaMailJobOrderBy EXECUTION_ATTEMPTS_DESC = new KalturaMailJobOrderBy("-executionAttempts");
		public static readonly KalturaMailJobOrderBy LOCK_VERSION_ASC = new KalturaMailJobOrderBy("+lockVersion");
		public static readonly KalturaMailJobOrderBy LOCK_VERSION_DESC = new KalturaMailJobOrderBy("-lockVersion");

		private KalturaMailJobOrderBy(string name) : base(name) { }
	}
}
