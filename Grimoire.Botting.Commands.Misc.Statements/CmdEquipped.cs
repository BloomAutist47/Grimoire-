﻿using Grimoire.Game;
using Grimoire.Game.Data;
using System.Threading.Tasks;

namespace Grimoire.Botting.Commands.Misc.Statements
{
    public class CmdEquipped : StatementCommand, IBotCommand
    {
        public CmdEquipped()
        {
            Tag = "Item";
            Text = "Is equipped";
        }

        public Task Execute(IBotEngine instance)
        {
            if (!(Player.Inventory.Items.Find((InventoryItem x) => x.Name == Value1) ?? new InventoryItem()).IsEquipped)
            {
                instance.Index++;
            }
            return Task.FromResult<object>(null);
        }

        public override string ToString()
        {
            return "Item is equipped: " + Value1;
        }
    }
}