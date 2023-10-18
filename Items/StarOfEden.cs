using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Aetheria.Projectiles;

namespace Aetheria.Items
{
    public class StarOfEden : ModItem
    {
        public override void SetDefaults()
        {
            Item.damage = 130;
            Item.DamageType = DamageClass.Magic;
            Item.width = 40;
            Item.height = 40;
            Item.useTime = 20;
            Item.useAnimation = 20;
            Item.useStyle = ItemUseStyleID.Swing;
            Item.knockBack = 6;
            Item.value = 10000;
            Item.rare = ItemRarityID.Red;
            Item.UseSound = SoundID.Item8;
            Item.autoReuse = true;
            Item.shoot = ModContent.ProjectileType<EdenProjectile>();
            Item.shootSpeed = 12;
            Item.mana = 2;
            Item.noMelee = true;
        }

        public override void AddRecipes()
        {
            Recipe recipe = CreateRecipe();
            recipe.AddIngredient(ItemID.SkyFracture);
            recipe.AddIngredient(ItemID.NebulaArcanum);
            recipe.AddIngredient(ItemID.NebulaBlaze);
            recipe.AddIngredient(ItemID.LunarBar, 10);
            recipe.AddTile(TileID.LunarCraftingStation);
            recipe.Register();
        }
    }
}