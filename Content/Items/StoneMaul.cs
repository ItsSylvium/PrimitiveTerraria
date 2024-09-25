using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace PrimT.Content.Items
{
    public class StoneMaul : ModItem
    {
        public override string Texture => "PrimT/Assets/Items/StoneMaul";
        public override string Name => "StoneMaul";
        public override void SetDefaults()
        {
            Item.damage = 3;
            Item.pick = 25;

            Item.knockBack = 4;
            Item.useTime = 32;
            Item.useAnimation = 32;
            Item.useTurn = true;

            Item.width = 32;
            Item.height = 28;
            Item.maxStack = 1;
            Item.useStyle = ItemUseStyleID.Swing;
        }
        public override bool CanUseItem(Player player)
        {
            return base.CanUseItem(player);
        }
        public override void AddRecipes()
        {
            CreateRecipe(1)
                .AddIngredient<PebbleItem>(4)
                .AddIngredient<StickItem>(2)
                .Register();
        }
    }
}
