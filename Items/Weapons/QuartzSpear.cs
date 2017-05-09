using System;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace CrystiliumMod.Items.Weapons
{
    public class QuartzSpear : ModItem
    {
        public override void SetDefaults()
        {
            item.name = "Quartz Spear";
            item.damage = 25;
            item.toolTip = "'Object class - Keter'";
            item.melee = true;
            item.width = 38;
            item.height = 38;
            item.scale = 1.1f;
            item.maxStack = 1;
            item.useTime = 30;
            item.useAnimation = 30;
            item.knockBack = 4f;
            item.UseSound = SoundID.Item1;
            item.noMelee = true;
            item.noUseGraphic = true;
            item.useTurn = true;
            item.useStyle = 5;
            item.value = 100000;
            item.rare = 7;
            item.shoot = mod.ProjectileType("QuartzSpearProj");  //put your Spear projectile name
            item.shootSpeed = 5f;
        }
    }
}