using Aetheria.Projectiles;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Aetheria.Items
{
    public class FireStick : ModItem
    {
        public override void SetDefaults()
        {
            Item.damage = 50;
            Item.DamageType = DamageClass.Melee;
            Item.width = 40;
            Item.height = 40;
            Item.useTime = 10;
            Item.useAnimation = 20;
            Item.useStyle = ItemUseStyleID.Swing;
            Item.knockBack = 10;
            Item.value = 10000;
            Item.rare = ItemRarityID.Red;
            Item.UseSound = SoundID.Item1;
            Item.autoReuse = true;
            Item.noMelee = false;
        }

        public void OnHitNPC(NPC target, int damage, float knockback, bool crit)
        {
            target.AddBuff(BuffID.OnFire, 30 * 60);
            target.AddBuff(BuffID.Ichor, 30 * 60);
        }
    }
}
//HFR until method for making melee weapons deal debuffs found