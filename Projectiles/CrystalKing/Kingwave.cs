using Terraria.ID;
using Terraria.ModLoader;

namespace CrystiliumMod.Projectiles.CrystalKing
{
	public class Kingwave : ModProjectile
	{
		public override void SetDefaults()
		{
			projectile.penetrate = 600;
			projectile.hostile = true;
			projectile.damage = 15;
			projectile.width = 80;
			projectile.height = 48;
			projectile.friendly = false;
			projectile.light = 2;
			projectile.aiStyle = 1;
			aiType = ProjectileID.Bullet;
		}
	}
}