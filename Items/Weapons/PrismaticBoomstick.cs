using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace CrystiliumMod.Items.Weapons
{
	public class PrismaticBoomstick : ModItem
	{
		public override void SetDefaults()
		{
			item.name = "Prismatic Boomstick";
			item.damage = 47;
			item.ranged = true;
			item.width = 40;
			item.height = 20;
			item.toolTip = "Launches rainbow beams";
			item.useTime = 32;
			item.useAnimation = 32;
			item.useStyle = 5;
			item.noMelee = true; //so the item's animation doesn't do damage
			item.knockBack = 4;
			item.value = 100000;
			item.rare = 7;
			item.UseSound = SoundID.Item11;
			item.autoReuse = true;
			item.shoot = mod.ProjectileType<Projectiles.PrismSlug>(); //idk why but all the guns in the vanilla source have this
			item.shootSpeed = 8f;
		}

		public override bool Shoot(Player player, ref Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage, ref float knockBack)
		{
			for (int I = 0; I < 3; I++)
			{
				Projectile.NewProjectile(position.X - 8, position.Y + 8, speedX + ((float)Main.rand.Next(-200, 200) / 100), speedY + ((float)Main.rand.Next(-200, 200) / 100), type, damage, knockBack, player.whoAmI, 0f, 0f);
			}
			return false;
		}
	}
}