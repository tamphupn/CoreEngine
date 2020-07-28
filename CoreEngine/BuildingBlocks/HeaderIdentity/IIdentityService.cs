namespace CoreEngine.BuildingBlocks.HeaderIdentity
{
    public interface IIdentityService
    {
        long? GetUserIdentity();

        long? GetUserOrganizationId();

        long? GetUserUnitId();
    }
}