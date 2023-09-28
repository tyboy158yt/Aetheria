using Aetheria.Projectiles;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Aetheria.Items
{
    public class Squidmelter : ModItem
    {
        public override void SetDefaults()
        {
            Item.damage = 128;
            Item.DamageType = DamageClass.Ranged;
            Item.width = 40;
            Item.height = 40;
            Item.useTime = 5;
            Item.useAnimation = 20;
            Item.useStyle = ItemUseStyleID.Shoot;
            Item.knockBack = 10;
            Item.value = 10000;
            Item.rare = ItemRarityID.Red;
            Item.UseSound = SoundID.Item11;
            Item.autoReuse = true;
            Item.shoot = 1;
            Item.useAmmo = AmmoID.Bullet;
            Item.shootSpeed = 12;
            Item.noMelee = true;
        }

        public override void AddRecipes()
        {
            Recipe recipe = CreateRecipe();
            recipe.AddIngredient(ItemID.LunarBar, 10);
            recipe.AddIngredient(ItemID.VortexBeater);
            recipe.AddIngredient(ItemID.OnyxBlaster);
            recipe.AddTile(TileID.LunarCraftingStation);
            recipe.Register();
        }
    }
}