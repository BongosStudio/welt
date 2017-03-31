﻿#region Copyright
// COPYRIGHT 2016 JUSTIN COX (CONJI)
#endregion

using Welt.Forge;
using Welt.Models;

namespace Welt.Entities
{
    public class PlayerEntity : LivingEntity
    {
        public override EntityClass EntityClass => EntityClass.Player;

        public PlayerEntity()
        {
            Inventory = new InventoryContainer();
        }
    }
}