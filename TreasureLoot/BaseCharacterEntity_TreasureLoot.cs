namespace MultiplayerARPG
{
    public abstract partial class BaseCharacterEntity : DamageableEntity, ICharacterData
    {
        [Category("LootBag Settings")]
        public bool isLootable = false;
    }
}