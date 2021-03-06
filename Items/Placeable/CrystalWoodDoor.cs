using Terraria.ID;
using Terraria.ModLoader;

namespace CrystiliumMod.Items.Placeable
{
	public class CrystalWoodDoor : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Crystal Wood Door");
		}

		public override void SetDefaults()
		{
			item.width = 14;
			item.height = 28;
			item.maxStack = 99;
			item.useTurn = true;
			item.autoReuse = true;
			item.useAnimation = 15;
			item.useTime = 10;
			item.useStyle = 1;
			item.consumable = true;
			item.value = 150;
			item.createTile = mod.TileType<Tiles.CrystalWoodDoorClosed>();
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.WoodenDoor);
			recipe.AddIngredient(mod.ItemType<CrystalWood>(), 10);
			recipe.AddTile(mod.TileType<Tiles.CrystalWoodWorkbench>());
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}