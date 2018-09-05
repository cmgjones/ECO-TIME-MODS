namespace Eco.Mods.TechTree
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using Eco.Gameplay.Blocks;
    using Eco.Gameplay.Components;
    using Eco.Gameplay.Components.Auth;
    using Eco.Gameplay.DynamicValues;
    using Eco.Gameplay.Economy;
    using Eco.Gameplay.Housing;
    using Eco.Gameplay.Interactions;
    using Eco.Gameplay.Items;
    using Eco.Gameplay.Minimap;
    using Eco.Gameplay.Objects;
    using Eco.Gameplay.Players;
    using Eco.Gameplay.Property;
    using Eco.Gameplay.Skills;
    using Eco.Gameplay.Systems.TextLinks;
    using Eco.Gameplay.Pipes.LiquidComponents;
    using Eco.Gameplay.Pipes.Gases;
    using Eco.Gameplay.Systems.Tooltip;
    using Eco.Shared;
    using Eco.Shared.Math;
    using Eco.Shared.Localization;
    using Eco.Shared.Serialization;
    using Eco.Shared.Utils;
    using Eco.Shared.View;
    using Eco.Shared.Items;
    using Eco.Gameplay.Pipes;
    using Eco.World.Blocks;

    [Serialized]
    [RequireComponent(typeof(PropertyAuthComponent))]

    public partial class DiscordSignObject :
        WorldObject,
        IRepresentsItem
    {
        public override string FriendlyName { get { return "DiscordSign"; } }

        public virtual Type RepresentedItemType { get { return typeof(DiscordSignItem); } }


        protected override void Initialize()
        {
          


        }

        public override void Destroy()
        {
            base.Destroy();
        }

    }

    [Serialized]
    public partial class DiscordSignItem :
        WorldObjectItem<DiscordSignObject>
    {
        public override string FriendlyName { get { return "DiscordSign"; } }
        public override string Description  { get { return  "A Wonderfull sign"; } }

        static DiscordSignItem()
        {

        }


    }


    public partial class DiscordSignRecipe : Recipe
    {
        public DiscordSignRecipe()
        {
            this.Products = new CraftingElement[]
            {
                new CraftingElement<DiscordSignItem>(),
            };

            this.Ingredients = new CraftingElement[]
            {
                new CraftingElement<LogItem>(10),
            };
            this.CraftMinutes = new ConstantValue(2);
            this.Initialize("DiscordSign", typeof(DiscordSignRecipe));
            CraftingComponent.AddRecipe(typeof(WorkbenchObject), this);
        }
    }
}
