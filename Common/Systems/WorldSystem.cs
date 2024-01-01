using PrimT.Common.Systems.GenPasses;
using System.Collections.Generic;
using Terraria;
using Terraria.IO;
using Terraria.ModLoader;
using Terraria.WorldBuilding;

namespace PrimT.Common.Systems
{
	public class WorldSystem : ModSystem
    {
        public override void ModifyWorldGenTasks(List<GenPass> tasks, ref double totalWeight)
        {
            // Add a GenPass immediately after the "Piles" pass. ExampleOreSystem explains this approach in more detail.
            int FlowersIndex = tasks.FindIndex(genpass => genpass.Name.Equals("Flowers"));

            if (FlowersIndex != -1)
            {
                tasks.Insert(FlowersIndex + 1, new PebbleStickGenPass("PebbleAndStickPiles", 100f));
            }
        }
    }
}
