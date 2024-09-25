using Terraria.ID;
using Terraria.ModLoader;
using PrimT.Content.Proj;

namespace PrimT.Content.Items;

public class PebbleItem : ModItem
{
    public override string Texture => "PrimT/Assets/Items/PebbleItem";
    public override string Name => "Pebble";
    public override void SetDefaults()
    {

        Item.width = 16;
        Item.height = 14;
        Item.maxStack = 99;

        Item.noMelee = true;
        Item.damage = 3;
        Item.DamageType = DamageClass.Throwing;
        Item.shoot = ModContent.ProjectileType<Pebble_Proj>();
        Item.shootSpeed = 8.5f;

        Item.consumable = true;

        Item.useTime = 16;
        Item.useAnimation = 16;
        Item.useStyle = ItemUseStyleID.Swing;
    }
}
