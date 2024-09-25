using Microsoft.Xna.Framework;
using PrimT.Content.Proj;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace PrimT.Content.Items
{
    public class Platinum_BattleAxe : ModItem
    {
        public override string Texture => "PrimT/Assets/Items/Platinum_BattleAxe";

        public override void SetDefaults()
        {
            Item.damage = 3;
            Item.axe = 5;
            Item.DamageType = DamageClass.Melee;
            Item.shoot = ModContent.ProjectileType<Platinum_BattleAxe_Proj>();

            Item.knockBack = 4;
            Item.useTime = 30;
            Item.useAnimation = 30;
            Item.useTurn = true;

            Item.width = 28;
            Item.height = 28;
            Item.maxStack = 1;
            Item.useStyle = ItemUseStyleID.Shoot;
            Item.noUseGraphic = true;
            Item.noMelee = true;
        }
        public override bool MeleePrefix()
        {
            return true;
        }
    }
}
