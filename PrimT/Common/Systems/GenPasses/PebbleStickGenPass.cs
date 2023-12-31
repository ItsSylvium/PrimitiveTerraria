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

            int maxToSpawn = (int)(Main.maxTilesX * Main.maxTilesY * 6E-05);
			for (int i = 0; i < maxToSpawn; i++)
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
					int x = WorldGen.genRand.Next(100, Main.maxTilesX - 100);
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
