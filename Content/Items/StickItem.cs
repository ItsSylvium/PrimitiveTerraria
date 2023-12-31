using Terraria.ID;
using Terraria.ModLoader;

namespace PrimT.Content.Items;

public class StickItem : ModItem
{
    public override string Texture => "PrimT/Assets/Items/StickItem";
    public override string Name => "Stick";
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
    }
}