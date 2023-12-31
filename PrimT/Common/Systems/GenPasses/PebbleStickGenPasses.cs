using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.WorldBuilding;
using PrimT.Content.Tiles;
using Terraria.IO;

namespace PrimT.Common.Systems.GenPasses
{
    internal class PebbleStickGenPass : GenPass
    {
        public PebbleStickGenPass(string name, float weight) : base(name, weight) { }

        protected override void ApplyPass(GenerationProgress progress, GameConfiguration configuration)
        {
            progress.Message = ("Putting down sticks and pebbles");


			int[] tileTypes = new int[] { ModContent.TileType<StickTile>(), ModContent.TileType<PebbleTile>()};

			// To not be annoying, we'll only spawn 15 Example Rubble near the spawn point.
			// This example uses the Try Until Success approach: https://github.com/tModLoader/tModLoader/wiki/World-Generation#try-until-success
			for (int k = 0; k < 15; k++)
			{
				bool success = false;
				int attempts = 0;

				while (!success)
				{
					attempts++;
					if (attempts > 1000)
					{
						break;
					}
					int x = WorldGen.genRand.Next(Main.maxTilesX / 2 - 40, Main.maxTilesX / 2 + 40);
					int y = WorldGen.genRand.Next((int)GenVars.worldSurfaceLow, (int)GenVars.worldSurfaceHigh);
					int tileType = WorldGen.genRand.Next(tileTypes);
					int placeStyle = WorldGen.genRand.Next(2); // Each of these tiles have 6 place styles
					if (Main.tile[x, y].TileType == tileType)
					{
						continue;
					}

					WorldGen.PlaceTile(x, y, tileType, mute: true, style: placeStyle);
					success = Main.tile[x, y].TileType == tileType;
				}
			}
		}
    }
}
