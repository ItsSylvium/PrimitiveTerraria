using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace PrimT.Content.Items
{
    public class SplitStoneAxe : ModItem
    {
        public override string Texture => "PrimT/Assets/Items/SplitStoneAxe";
        public override string Name => "Split Stone Axe";

        public override void SetDefaults()
        {
            Item.damage = 3;
            Item.axe = 20;
            Item.useTime = 30;
            Item.useAnimation = 30;
            Item.useTurn = true;

            Item.width = 28;
            Item.height = 28;
            Item.maxStack = 1;
            Item.useStyle = ItemUseStyleID.Swing;
        }

        public override void AddRecipes()
        {
            CreateRecipe(1)
                .AddIngredient<PebbleItem>(2)
                .AddIngredient<StickItem>(1)
                .Register();
        }
    }
}
