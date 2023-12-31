﻿namespace QuasarFramework.Definitions
{
    public abstract class QuasarItem : ModItem
    {
        /// <summary>
        /// A newly configurable book of tooltips for tooltip manipulation. <para></para>
        /// See documentation for proper usage.
        /// </summary>
        public TooltipBook tooltipBook;

        /// <summary>
        /// The current page of your tooltip book being displayed.
        /// </summary>
        public int tooltipBookIndex;

        public Asset<Texture2D> itemTypeIcon;

        public virtual void EditTooltipBook(TooltipBook tooltipBook) { }

        public override void ModifyTooltips(List<TooltipLine> tooltips)
        {
            EditTooltipBook(tooltipBook);

            foreach (TooltipLine line in tooltipBook.bookPages[tooltipBookIndex].pageLines) //for each tooltip line in our book AT our page index.
                tooltips.Add(line); //add to the current visible tooltips.

            base.ModifyTooltips(tooltips);
        }

        public override void SetDefaults()
        {

            base.SetDefaults();
        }

        public override void SaveData(TagCompound tag)
        {
            base.SaveData(tag);
        }

        public override void LoadData(TagCompound tag)
        {
            base.LoadData(tag);
        }

        #region SEALS / DEPRECATION

        /// <summary> Deprecated. Reforging removed as of v1.0 </summary>
        public sealed override bool AllowPrefix(int pre) => false;

        /// <summary> Deprecated. Reforging removed as of v1.0 </summary>
        public sealed override bool CanReforge() => false;

        /// <summary> Deprecated. Research removed as of v1.0 </summary>
        public sealed override bool CanResearch() => false;

        /// <summary> Deprecated. NPCs reworked into Vendors as of v1.0 </summary>
        public sealed override bool IsQuestFish() => false;

        /// <summary> Deprecated. Reforging removed as of v1.0 </summary>
        public sealed override bool MagicPrefix() => false;

        /// <summary> Deprecated. Reforging removed as of v1.0 </summary>
        public sealed override bool MeleePrefix() => false;

        /// <summary> Deprecated. Reforging removed as of v1.0 </summary>
        public sealed override bool RangedPrefix() => false;

        /// <summary> Deprecated. Reforging removed as of v1.0 </summary>
        public sealed override bool WeaponPrefix() => false;

        /// <summary> Deprecated. Wings removed as of v1.0 </summary>
        public sealed override bool WingUpdate(Player player, bool inUse) => false;

        /// <summary> Deprecated. NPCs reworked into Vendors as of v1.0 </summary>
        public sealed override void AnglerQuestChat(ref string description, ref string catchLocation) { return; }

        /// <summary> Deprecated. Extractinator removed as of v1.0 </summary>
        public sealed override void ExtractinatorUse(int extractinatorBlockType, ref int resultType, ref int resultStack) { return; }

        /// <summary> Deprecated. Melee reworked as of v1.0 </summary>
        public sealed override void MeleeEffects(Player player, Rectangle hitbox) { return; }

        /// <summary> Deprecated. Research removed as of v1.0 </summary>
        public sealed override void OnResearched(bool fullyResearched) { return; }

        /// <summary> Deprecated. Reforging removed as of v1.0 </summary> 
        public sealed override void PreReforge() { return; }

        /// <summary> Deprecated. Wings removed as of v1.0 </summary>
        public sealed override void VerticalWingSpeeds(Player player, ref float ascentWhenFalling, ref float ascentWhenRising, ref float maxCanAscendMultiplier, ref float maxAscentMultiplier, ref float constantAscend) { return; }

        #endregion
    }
}