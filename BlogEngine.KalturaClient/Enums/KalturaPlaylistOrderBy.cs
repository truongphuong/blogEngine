namespace Kaltura
{
	public sealed class KalturaPlaylistOrderBy : KalturaStringEnum
	{
		public static readonly KalturaPlaylistOrderBy NAME_ASC = new KalturaPlaylistOrderBy("+name");
		public static readonly KalturaPlaylistOrderBy NAME_DESC = new KalturaPlaylistOrderBy("-name");
		public static readonly KalturaPlaylistOrderBy MODERATION_COUNT_ASC = new KalturaPlaylistOrderBy("+moderationCount");
		public static readonly KalturaPlaylistOrderBy MODERATION_COUNT_DESC = new KalturaPlaylistOrderBy("-moderationCount");
		public static readonly KalturaPlaylistOrderBy CREATED_AT_ASC = new KalturaPlaylistOrderBy("+createdAt");
		public static readonly KalturaPlaylistOrderBy CREATED_AT_DESC = new KalturaPlaylistOrderBy("-createdAt");
		public static readonly KalturaPlaylistOrderBy UPDATED_AT_ASC = new KalturaPlaylistOrderBy("+updatedAt");
		public static readonly KalturaPlaylistOrderBy UPDATED_AT_DESC = new KalturaPlaylistOrderBy("-updatedAt");
		public static readonly KalturaPlaylistOrderBy RANK_ASC = new KalturaPlaylistOrderBy("+rank");
		public static readonly KalturaPlaylistOrderBy RANK_DESC = new KalturaPlaylistOrderBy("-rank");
		public static readonly KalturaPlaylistOrderBy START_DATE_ASC = new KalturaPlaylistOrderBy("+startDate");
		public static readonly KalturaPlaylistOrderBy START_DATE_DESC = new KalturaPlaylistOrderBy("-startDate");
		public static readonly KalturaPlaylistOrderBy END_DATE_ASC = new KalturaPlaylistOrderBy("+endDate");
		public static readonly KalturaPlaylistOrderBy END_DATE_DESC = new KalturaPlaylistOrderBy("-endDate");
		public static readonly KalturaPlaylistOrderBy PARTNER_SORT_VALUE_ASC = new KalturaPlaylistOrderBy("+partnerSortValue");
		public static readonly KalturaPlaylistOrderBy PARTNER_SORT_VALUE_DESC = new KalturaPlaylistOrderBy("-partnerSortValue");

		private KalturaPlaylistOrderBy(string name) : base(name) { }
	}
}
