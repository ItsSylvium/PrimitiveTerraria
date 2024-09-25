using Microsoft.Xna.Framework;
using Terraria;
using Terraria.DataStructures;
using Terraria.Enums;
using Terraria.GameContent;
using Terraria.GameContent.ObjectInteractions;
using Terraria.ID;
using Terraria.Localization;
using Terraria.ModLoader;
using Terraria.ObjectData;

namespace PrimT.Content.Tiles
{
    public class CookingPitTile : ModTile
    {
        public override string Texture => "PrimT/Assets/Tiles/CookingPitTile";
        public override void SetStaticDefaults()
        {
            Main.tileFrameImportant[Type] = true;
            Main.tileNoFail[Type] = true;
            Main.tileObsidianKill[Type] = true;
            Main.tileLavaDeath[Type] = true;
            Main.tileLighted[Type] = true;

            DustType = DustID.Stone;
            MineResist = 3f;
            //AdjTiles = new int[] { TileID.CookingPots };

            TileObjectData.newTile.CopyFrom(TileObjectData.Style3x2);
            TileObjectData.newTile.StyleHorizontal = true;
            TileObjectData.newTile.DrawYOffset = 2;
            TileObjectData.addTile(Type);

            RegisterItemDrop(ModContent.ItemType<Items.CookingPitItem>());
            AddMapEntry(new Color(144, 097, 064));
        }
        public override void ModifyLight(int i, int j, ref float r, ref float g, ref float b)
        {
            r = 1.0f;
            g = 0.5f;
            b = 0.1f;
        }
    }
}
