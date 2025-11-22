using Terraria;
using Terraria.GameContent.ItemDropRules;
using Terraria.ID;
using Terraria.Localization;
using Terraria.ModLoader;

namespace YetAnotherMod.Content.Items.Accessories
{
    public class MagnifyingGlass : ModItem {

        public static readonly int CritBonus = 5;

        public override LocalizedText Tooltip => base.Tooltip.WithFormatArgs(CritBonus);

        public override void SetDefaults() {
            Item.width = 24;
            Item.height = 24;
            Item.accessory = true;
            Item.rare = ItemRarityID.Blue;
            Item.value = Item.sellPrice(silver: 20);
        }

        public override void UpdateAccessory(Player player, bool hideVisual) {
            player.GetCritChance(DamageClass.Generic) += CritBonus;
        }
    }

    public class MagnifyingGlassGlobalNPC : GlobalNPC {
        public override void ModifyNPCLoot(NPC npc, NPCLoot npcLoot) {
            switch (npc.type) {
                case NPCID.DemonEye:
                case NPCID.DemonEye2:
                case NPCID.DemonEyeOwl:
                case NPCID.DemonEyeSpaceship:
                    npcLoot.Add(ItemDropRule.Common(ModContent.ItemType<MagnifyingGlass>(), 20));
                    break;
            }
        }
    }
}
