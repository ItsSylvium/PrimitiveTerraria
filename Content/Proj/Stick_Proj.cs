using Microsoft.Xna.Framework;
using System;
using Terraria;
using Terraria.Audio;
using Terraria.ID;
using Terraria.ModLoader;

namespace PrimT.Content.Proj
{
	public class Stick_Proj : ModProjectile
	{
		public override string Texture => "PrimT/Assets/Proj/Stick_Proj";
		public override void SetDefaults()
		{
			Projectile.width = 20;
			Projectile.height = 10;

			AIType = 0;

			Projectile.damage = 3;
			Projectile.friendly = true;
			Projectile.DamageType = DamageClass.Throwing;
			Projectile.ignoreWater = false;
			Projectile.tileCollide = true;
			Projectile.timeLeft = 240; // Each update timeLeft is decreased by 1. Once timeLeft hits 0, the Projectile will naturally despawn. (60 ticks = 1 second)
		}
        public override void AI()
        {
			float yModifierSlow = MathHelper.Lerp(0.03f, 0.10f, Math.Abs(Main.WindForVisuals));
			float yModifierFast = MathHelper.Lerp(0.05f, 1f, Math.Abs(Main.WindForVisuals));
			float projDirection = Projectile.direction;

			Projectile.ai[0] += 1f;

			if (Projectile.ai[0] <= 15f)
			{
				Projectile.velocity.Y += yModifierSlow;

				if (projDirection == 1 ) { Projectile.rotation += 0.15f; }
				else { Projectile.rotation -= 0.15f; }
			}
			else
			{
				Projectile.velocity.Y += yModifierFast;

                if (projDirection == 1) { Projectile.rotation += 0.35f; }
                else { Projectile.rotation -= 0.35f; }
            }
        }
		public override void OnKill(int timeLeft)
        {
            SoundEngine.PlaySound(SoundID.Item10, Projectile.position); //sound.playsound, the sound, at projectile location
			for (int i = 0; i < 3; i++)
			{
				Dust.NewDust(Projectile.Center, Projectile.width, Projectile.height, DustID.WoodFurniture);
			}
		}
    }
}
