using PrimT.Content.Items;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using Terraria;
using Terraria.Audio;
using Terraria.GameContent;
using Terraria.ID;
using Terraria.ModLoader;
using PrimT.Content.Proj;

namespace PrimT.Content.Proj
{
	public class PebbleProj : ModProjectile
	{
		public override string Texture => "PrimT/Assets/Proj/PebbleProj";
		public override void SetDefaults() {
			Projectile.width = 12;
			Projectile.height = 12;

            AIType = 2;

			Projectile.friendly = true;
			Projectile.DamageType = DamageClass.Throwing;
			Projectile.ignoreWater = false;
            Projectile.tileCollide = true;
            Projectile.timeLeft = 240; // Each update timeLeft is decreased by 1. Once timeLeft hits 0, the Projectile will naturally despawn. (60 ticks = 1 second)
        }
        public override void OnKill(int timeLeft)
        {
            SoundEngine.PlaySound(SoundID.Item10, Projectile.position); //sound.playsound, the sound, at projectile location
			for (int i = 0; i < 10; i++)
			{
				Dust.NewDust(Projectile.Center, Projectile.width, Projectile.height, DustID.Stone);
			}
		}
    }
}
