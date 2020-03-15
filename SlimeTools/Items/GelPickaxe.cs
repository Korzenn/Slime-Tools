using Terraria.ID;
using Terraria.ModLoader;

namespace SlimeTools.Items
{
    public class GelPickaxe : ModItem
    {
        public override void SetStaticDefaults()
        {
            // DisplayName.SetDefault("GelPickaxe"); // By default, capitalization in classnames will add spaces to the display name. You can customize the display name here by uncommenting this line.
            Tooltip.SetDefault("Hard to use with it's floppy-ish texture.");
        }

        public override void SetDefaults()
        {
            item.damage = 12;
            item.melee = true;
            item.width = 50;
            item.height = 50;
            item.useTime = 15;
            item.useAnimation = 15;
            item.pick = 65;
            
            item.useStyle = 1;
            item.knockBack = 6;
            item.value = 10000;
            item.rare = 3;
            item.UseSound = SoundID.Item56;
            item.autoReuse = true;
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.Gel, 200);
            recipe.AddTile(TileID.Solidifier);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}