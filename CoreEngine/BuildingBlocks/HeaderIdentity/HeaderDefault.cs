namespace CoreEngine.BuildingBlocks.HeaderIdentity
{
    /// <summary>
    /// Defined identity user in header from Api Gateway
    /// </summary>
    public static class HeaderDefault
    {
        public const string USER_ID_HEADER_NAME = "x-tpa-identity-uuid";
        public const string ORG_ID_HEADER_NAME = "x-tpa-org-id";
        public const string COMPANY_ID_HEADER_NAME = "x-tpa-company-id";
        public const string IS_ORG_MANAGER_HEADER_NAME = "x-tpa-org-manager";
        public const string X_CLIENT_IP = "x-client-ip";
        public const string X_FORWARDED_FOR = "x-forwarded-for";
    }
}