﻿using QuasarFramework.Loaders;

namespace QuasarFramework.Definitions
{
    public abstract class Trait : ModType
    {
        public int ID { get; private set; }

        public string traitName;

        public string traitDescription;

        public virtual void SetDefaults() { }

        public virtual void UpdateTrait(QuasarPlayer player) { }

        public virtual void UpdateTrait(Weapon weapon) { }

        protected sealed override void Register()
        {
            ModTypeLookup<Trait>.Register(this);

            ID = TraitLoader.Add(this);
        }

        public sealed override void SetupContent()
        {
            SetDefaults();

            base.SetupContent();
        }
    }
}