using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Aetheria.Projectiles;

namespace Aetheria.Items
{
    public class StarOfEden : ModItem
    {
        // The Display Name and Tooltip of this item can be edited in the Localization/en-US_Mods.Aetheria.hjson file.
        // Duly noted.

        public override void SetDefaults()
        {
            Item.damage = 100;
            Item.DamageType = DamageClass.Magic;
            Item.width = 40;
            Item.height = 40;
            Item.useTime = 20;
            Item.useAnimation = 20;
            Item.useStyle = ItemUseStyleID.Swing;
            Item.knockBack = 6;
            Item.value = 10000;
            Item.rare = ItemRarityID.Green;
            Item.UseSound = SoundID.Item1;
            Item.autoReuse = true;
            Item.shoot = ModContent.ProjectileType<EdenProjectile>();
            Item.shootSpeed = 12;
            Item.mana = 2;
            Item.noMelee = true;
        }

        public override void AddRecipes()
        {
            Recipe recipe = CreateRecipe();
            recipe.AddIngredient(ItemID.DirtBlock, 10);
            recipe.AddTile(TileID.WorkBenches);
            recipe.Register();
        }
    }
}