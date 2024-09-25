using Microsoft.Xna.Framework;
using System.Collections.Generic;
using Terraria;
using Terraria.GameContent.ObjectInteractions;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.ObjectData;

namespace PrimT.Content.Tiles;

public class StickTile : ModTile
{
    public override string Texture => "PrimT/Assets/WorldGene/StickTile";
    public override void SetStaticDefaults()
    {
        Main.tileFrameImportant[Type] = true;
        Main.tileNoFail[Type] = true;
        Main.tileObsidianKill[Type] = true;

        DustType = DustID.Stone;

        TileObjectData.newTile.CopyFrom(TileObjectData.Style1x1);
        TileObjectData.newTile.StyleHorizontal = true;
        TileObjectData.newTile.DrawYOffset = 2;
        TileObjectData.addTile(Type);

        RegisterItemDrop(ModContent.ItemType<Items.StickItem>());
        AddMapEntry(new Color(123, 123, 123));
    }
    public override bool RightClick(int i, int j)
    {
        WorldGen.KillTile(i, j);
        return true;
    }

    public override bool HasSmartInteract(int i, int j, SmartInteractScanSettings settings){
        return true;}

    public override void MouseOver(int i, int j)
    {
        Player player = Main.LocalPlayer;

        player.cursorItemIconEnabled = true;
        player.cursorItemIconID = ModContent.ItemType<Items.StickItem>();

        player.noThrow = 2;
    }
}