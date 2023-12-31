using Terraria.ID;
using Terraria.ModLoader;

namespace PrimT.Content.Items;

public class PebbleItem : ModItem
{
    public override string Texture => "PrimT/Assets/Items/PebbleItem";
    public override string Name => "Pebble";
    public override void SetDefaults()
    {

        Item.DamageType = DamageClass.Throwing;
        Item.width = 16;
        Item.height = 14;
        Item.maxStack = 99;

        Item.damage = 3;
        Item.useTime = 20;
        Item.useAnimation = 20;
        Item.useStyle = ItemUseStyleID.Swing;

        Item.createTile = ModContent.TileType<Content.Tiles.PebbleTile>();
    }
}