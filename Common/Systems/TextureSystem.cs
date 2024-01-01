using PrimT.Common.Systems.GenPasses;
using System.Collections.Generic;
using Terraria;
using Terraria.IO;
using Terraria.ModLoader;
using Terraria.WorldBuilding;

namespace PrimT.Common.Systems
{
    public class TextureSystem : ModSystem
    {
        public override void PostSetupContent()
        {

        }
    }
}


        /*TextureAssets.Whatever[type] = ModContent.Request<Texture2D>(path) 
         in probably ModSystem PostSetupContent, then 
        TextureAssets.Whatever[type] = ModContent.Request<Texture2D>($"Terraria/Images/Whatever_{type}") 
        in Unload*/
