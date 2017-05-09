using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ModLoader;
using Terraria.ID;
using System;
using System.Collections.Generic;


namespace CrystiliumMod.Items
{
	public class CrystalPotion : ModItem
	{
		public override void SetDefaults()
		{
			item.name = "Crystal Potion";
			item.UseSound = SoundID.Item3;
            item.useStyle = 2;
            item.useTurn = true;
            item.useAnimation = 17;
            item.useTime = 17;
            item.maxStack = 30;
            item.consumable = true;
            item.toolTip = "Makes shards of crystals damage nearby enemies.";
            item.value = 3000;
            item.rare = 0;
            item.buffType = mod.BuffType("CrystalLeak");
            item.buffTime = 10000;
            return;
		}
		public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(null, "CrystalBottleWater", 1);
            recipe.AddIngredient(null, "ShinyGemstone", 1);
            recipe.AddIngredient(ItemID.Moonglow, 1);
			recipe.AddIngredient(ItemID.Diamond, 1);
            recipe.AddTile(TileID.Bottles);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
	}
}