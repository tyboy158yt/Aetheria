using Aetheria.Projectiles;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Aetheria.Items
{
    public class CokeNuke : ModItem
    {
        public override void SetDefaults()
        {
            Item.damage = 70;
            Item.DamageType = DamageClass.Ranged;
            Item.width = 40;
            Item.height = 40;
            Item.useTime = 10;
            Item.useAnimation = 20;
            Item.useStyle = ItemUseStyleID.Shoot;
            Item.knockBack = 10;
            Item.value = 10000;
            Item.rare = ItemRarityID.Red;
            Item.UseSound = SoundID.Item5;
            Item.autoReuse = true;
            Item.shoot = ProjectileID.MiniNukeRocketI;
            Item.useAmmo = AmmoID.Rocket;
            Item.shootSpeed = 12;
            Item.noMelee = true;
        }

        public override void AddRecipes()
        {
            Recipe recipe = CreateRecipe();
            recipe.AddIngredient(ItemID.LunarBar, 10);
            recipe.AddIngredient(ItemID.FireworksLauncher);
            recipe.AddIngredient(ItemID.Celeb2);
            recipe.AddTile(TileID.LunarCraftingStation);
            recipe.Register();
        }
    }
}