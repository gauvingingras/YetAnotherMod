using Terraria;
using Terraria.GameContent.ItemDropRules;
using Terraria.ID;
using Terraria.ModLoader;

namespace YetAnotherMod.Content.Items.Weapons
{
    public class FrozenZombieArm : ModItem {

        public override void SetDefaults() {
            Item.CloneDefaults(ItemID.ZombieArm);
            Item.width = 34;
            Item.height = 34;
            Item.damage = 17;
        }
    }

    public class FrozenZombieArmGlobalNPC : GlobalNPC {

        public override void ModifyNPCLoot(NPC npc, NPCLoot npcLoot) {
            switch (npc.type) {
                case NPCID.ArmedZombieEskimo:
                case NPCID.ZombieEskimo:
                    npcLoot.RemoveWhere(x => x is CommonDrop drop && drop.itemId == ItemID.ZombieArm);
                    npcLoot.Add(ItemDropRule.Common(ModContent.ItemType<FrozenZombieArm>(), 250));
                    break;
            }
        }
    }
}
