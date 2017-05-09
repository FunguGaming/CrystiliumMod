using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace CrystiliumMod.Items.Accessories
{
	public class AmberRing : ModItem
	{
		public override void SetDefaults()
		{
			item.name = "Amber Ring";
			item.width = 40;
			item.height = 40;
			item.toolTip = "Slightly increases life regen";
			item.value = Item.sellPrice(0, 1, 0, 0);
			item.rare = 2;
			item.accessory = true;
		}

		public override void UpdateAccessory(Player player, bool hideVisual)
		{
			player.lifeRegen += 6;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(3380, 4);
			recipe.AddIngredient(ItemID.Amber, 3);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}