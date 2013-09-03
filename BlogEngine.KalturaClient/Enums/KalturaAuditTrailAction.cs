namespace Kaltura
{
	public sealed class KalturaAuditTrailAction : KalturaStringEnum
	{
		public static readonly KalturaAuditTrailAction CREATED = new KalturaAuditTrailAction("CREATED");
		public static readonly KalturaAuditTrailAction COPIED = new KalturaAuditTrailAction("COPIED");
		public static readonly KalturaAuditTrailAction CHANGED = new KalturaAuditTrailAction("CHANGED");
		public static readonly KalturaAuditTrailAction DELETED = new KalturaAuditTrailAction("DELETED");
		public static readonly KalturaAuditTrailAction VIEWED = new KalturaAuditTrailAction("VIEWED");
		public static readonly KalturaAuditTrailAction CONTENT_VIEWED = new KalturaAuditTrailAction("CONTENT_VIEWED");
		public static readonly KalturaAuditTrailAction FILE_SYNC_CREATED = new KalturaAuditTrailAction("FILE_SYNC_CREATED");
		public static readonly KalturaAuditTrailAction RELATION_ADDED = new KalturaAuditTrailAction("RELATION_ADDED");
		public static readonly KalturaAuditTrailAction RELATION_REMOVED = new KalturaAuditTrailAction("RELATION_REMOVED");

		private KalturaAuditTrailAction(string name) : base(name) { }
	}
}
