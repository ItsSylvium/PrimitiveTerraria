using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.IO;
using System.Threading;
using Terraria;
using Terraria.Audio;
using Terraria.DataStructures;
using Terraria.ID;
using Terraria.ModLoader;

namespace PrimT.Content.Proj
{
    public class Platinum_BattleAxe_Proj : ModProjectile
    {
        private enum AttackStages
        {
            BuildUp,
            Release,
        }
        private AttackStages Attack
        {
            get => (AttackStages)Projectile.ai[0];
            set => Projectile.ai[0] = (float)value;
        }
        private AttackStages Stage
        {
            get => (AttackStages)Projectile.localAI[0];
            set
            {
                Projectile.localAI[0] = (float)value;
                Timer = 0;
            }
        }
        private ref float Timer => ref Projectile.ai[2];

        public override string Texture => "PrimT/Assets/Items/Platinum_BattleAxe";

        public override void SetDefaults()
        {
            Projectile.width = 46;
            Projectile.height = 48;

            Projectile.timeLeft = 300;
            Projectile.penetrate = -1;
            Projectile.tileCollide = false;
            Projectile.usesLocalNPCImmunity = true;
            Projectile.friendly = true;
            Projectile.localNPCHitCooldown = -1;
            Projectile.ownerHitCheck = true;

            Projectile.DamageType = DamageClass.Melee;
        }

        public override void AI()
        {
            Main.player[Projectile.owner].itemAnimation = 2;
            Main.player[Projectile.owner].itemTime = 2;

            if (!Main.player[Projectile.owner].active || Main.player[Projectile.owner].dead || Main.player[Projectile.owner].noItems || Main.player[Projectile.owner].CCed)
            {
                Projectile.Kill();
                return;
            }

            switch ((AttackStages)Projectile.ai[0])
            {
                case AttackStages.BuildUp:
                    ProjBuildUp();
                    break;
                default: 
                    ProjRelease();
                    break;
            }
            Timer++;
        }
        private void ProjBuildUp()
        {
            if (Stage == AttackStages.BuildUp)
            {
                MathHelper.SmoothStep(0, 1.65f * (float)Math.PI, 12f);
                if (Timer > 12f)
                {
                    Attack = AttackStages.Release;
                }
            }
        }
        private void ProjRelease()
        {
            if (Stage == AttackStages.Release)
            {
                MathHelper.SmoothStep(0, 1.65f * (float)Math.PI, 12f);
                if (Timer > 12f)
                {
                    Projectile.Kill();
                }
            }
        }
    }
}
