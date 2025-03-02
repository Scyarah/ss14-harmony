using Content.Shared.Clothing.EntitySystems;
using Robust.Shared.GameStates;
using Robust.Shared.Prototypes;

namespace Content.Shared._Harmony.Clothing.OuterClothing.Components;

/// <summary>
///     This component gives an item an action that will equip or un-equip some clothing e.g. hardsuits and hardsuit helmets.
/// </summary>
[Access(typeof(SharedChameleonClothingSystem))]
[RegisterComponent, NetworkedComponent, AutoGenerateComponentState]
public sealed partial class ChameleonAttachedHelmetComponent : Component
{
    /// <summary>
    ///     Default clothing entity prototype to spawn into the clothing container.
    /// </summary>
    [DataField(required: true), AutoNetworkedField]
    public EntProtoId ClothingPrototype = default!;
}
