using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace CrystiliumMod.Items.Weapons
{
	public class NebulaStaff : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Nebula Crystal Staff");
			Tooltip.SetDefault("'You feel the power of the cosmos'");
			Item.staff[item.type] = true;
		}

		public override void SetDefaults()
		{
			item.damage = 88; //The damage
			item.magic = true; //Whether or not it is a magic weapon
			item.width = 54; //Item width
			item.height = 54; //Item height
			item.maxStack = 1; //How many of this item you can stack
			item.useTime = 25; //How long it takes for the item to be used
			item.useAnimation = 25; //How long the animation of the item takes
			item.knockBack = 7f; //How much knockback the item produces
			item.noMelee = true; //Whether the weapon should do melee damage or not
			item.useStyle = 5; //How the weapon is held, 5 is the gun hold style
			item.value = 120000; //How much the item is worth
			item.rare = 8; //The rarity of the item
			item.shoot = mod.ProjectileType<Projectiles.NebulaShard>(); //What the item shoots, retains an int value
			item.shootSpeed = 4f; //How fast the projectile fires
			item.mana = 14;
			item.channel = true;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.FragmentNebula, 10);
			recipe.AddIngredient(mod.ItemType<CrystiliumBar>(), 15);
			recipe.AddTile(TileID.LunarCraftingStation);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}