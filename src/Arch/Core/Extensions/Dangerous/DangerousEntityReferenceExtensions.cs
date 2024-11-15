namespace Arch.Core.Extensions.Dangerous;

/// <summary>
///     The <see cref="DangerousEntityReferenceExtensions"/> class
///     contains several <see cref="EntityReference"/> related extension methods which give access to underlaying data structures that should only be modified when you exactly know what you are doing.
/// </summary>
public static class DangerousEntityReferenceExtensions
{
    /// <summary>
    ///     Creates an <see cref="EntityReference"/> struct and returns it.
    ///     Does not create an <see cref="EntityReference"/> in the world, just the plain struct.
    /// </summary>
    /// <param name="entity">The referenced <see cref="Entity"/>.</param>
    /// <param name="version">Its version.</param>
    ///
    /// <returns>The new <see cref="EntityReference"/>.</returns>
    public static EntityReference CreateEntityReferenceStruct(Entity entity, int version)
    {
        return new EntityReference(entity, version);
    }
}
