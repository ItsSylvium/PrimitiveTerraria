using System.Collections.Generic;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;


namespace PrimT.Common.Player
{
    public class StartingInventory : ModPlayer
    {
        public override void ModifyStartingInventory(IReadOnlyDictionary<string, List<Item>> itemsByMod, bool mediumCoreDeath)
        {
            itemsByMod["Terraria"].RemoveAll(item => item.type == ItemID.CopperAxe);
            itemsByMod["Terraria"].RemoveAll(item => item.type == ItemID.CopperPickaxe);
            itemsByMod["Terraria"].RemoveAll(item => item.type == ItemID.CopperShortsword);
        }
    }
}
