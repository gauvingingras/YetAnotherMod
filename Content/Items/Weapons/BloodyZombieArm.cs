using Terraria;
using Terraria.GameContent.ItemDropRules;
using Terraria.ID;
using Terraria.ModLoader;

namespace YetAnotherMod.Content.Items.Weapons
{
    public class BloodyZombieArm : ModItem {

        public override void SetDefaults() {
            Item.CloneDefaults(ItemID.ZombieArm);
            Item.width = 38;
            Item.height = 38;
            Item.damage = 22;
            Item.UseSound = SoundID.NPCHit18;
            Item.rare = ItemRarityID.Blue;
            Item.value = Item.sellPrice(silver: 20);
        }
    }

    public class BloodyZombieArmGlobalNPC : GlobalNPC {

        public override void ModifyNPCLoot(NPC npc, NPCLoot npcLoot) {
            switch (npc.type) {
                case NPCID.BloodZombie:
                    npcLoot.Add(ItemDropRule.Common(ModContent.ItemType<BloodyZombieArm>(), 100));
                    break;
            }
        }
    }
}
