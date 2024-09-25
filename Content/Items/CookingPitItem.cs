using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace PrimT.Content.Items;

public class CookingPitItem : ModItem
{
    public override string Texture => "PrimT/Assets/Items/CookingPitItem";
    public override string Name => "CookingPit";
    public override void SetDefaults()
    {
        Item.width = 16;
        Item.height = 16;
        Item.maxStack = 99;

        Item.useTime = 18;
        Item.useAnimation = 18;
        Item.useStyle = ItemUseStyleID.Swing;

        Item.createTile = ModContent.TileType<Content.Tiles.CookingPitTile>();
        Item.consumable = true;
    }
    public override void AddRecipes()
    {
        CreateRecipe(1)
            .AddIngredient<StickItem>(5)
            .AddIngredient<PebbleItem>(6)
            .AddIngredient(ItemID.Gel, 3)
            .Register();
    }
}