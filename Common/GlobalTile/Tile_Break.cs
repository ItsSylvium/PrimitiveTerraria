using Microsoft.Xna.Framework;
using System;
using System.IO;
using System.Security.AccessControl;
using Terraria;
using Terraria.GameContent.Bestiary;
using Terraria.GameContent.UI;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.ModLoader.IO;
using Terraria.ModLoader.Utilities;


namespace PrimT.Common.Player
{
    public class Tile_Break : GlobalTile
    {
        public override void KillTile(int i, int j, int type, ref bool fail, ref bool effectOnly, ref bool noItem)
        {
            Vector2 tileCordinates = new(i, j);
            var closestPlayer = Terraria.Player.FindClosest(tileCordinates.ToWorldCoordinates(), 1, 1);
            Terraria.Player player = Main.player[closestPlayer];

            if (type == TileID.Iron && player.HeldItem.pick <= 26) { fail = true; }
            if (type == TileID.Lead && player.HeldItem.pick <= 26) { fail = true; }

            if (type == TileID.Silver && player.HeldItem.pick <= 36) { fail = true; }
            if (type == TileID.Tungsten && player.HeldItem.pick <= 36) { fail = true; }

            if (type == TileID.Gold && player.HeldItem.pick <= 44) { fail = true; }
            if (type == TileID.Platinum && player.HeldItem.pick <= 44) { fail = true; }
        }
    }
}
