using Terraria;
using Terraria.ID;
using Terraria.Localization;
using Terraria.ModLoader;

namespace YetAnotherMod.Content.Items.Accessories
{
    public class GolemGlass : ModItem {

        public static readonly int CritBonus = 15;

        public override LocalizedText Tooltip => base.Tooltip.WithFormatArgs(CritBonus);

        public override void SetDefaults() {
            Item.width = 28;
            Item.height = 28;
            Item.accessory = true;
            Item.rare = ItemRarityID.Lime;
            Item.value = Item.sellPrice(gold: 5);
        }

        public override void UpdateAccessory(Player player, bool hideVisual) {
            player.GetCritChance(DamageClass.Generic) += CritBonus;
        }

        public override void AddRecipes() {
            CreateRecipe()
                .AddIngredient<MagnifyingGlass>()
                .AddIngredient(ItemID.EyeoftheGolem)
                .AddTile(TileID.TinkerersWorkbench)
                .Register();
        }
    }
}
