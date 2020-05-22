﻿using System;
using Items.Inventory;
using UnityEngine;

namespace Entities.NPCs.JuiceMachine
{
    public class PotionDispensingSpawner : MonoBehaviour
    {
        public int currentJuiceTypeIndex;

        public CraftingInventory playerCraftingItems;
        public CraftingInventory juiceMachineCraftingItems;

        public void TakeCraftingItems()
        {
            while (playerCraftingItems.Items.Count > 0)
            {
                juiceMachineCraftingItems.Add(playerCraftingItems.Items[0]);
                playerCraftingItems.Remove(playerCraftingItems.Items[0]);
            }
        }

        public void RotateJuiceTypes()
        {
            throw new NotImplementedException();
        }

        public void DispenceJuice()
        {
            CraftingItemReference item = juiceMachineCraftingItems.Items[0];
            item.Item.Spawn(transform);
            juiceMachineCraftingItems.Items.RemoveAt(0);
        }

    }
}