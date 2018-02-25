﻿namespace PlayerUnknown.Logic.Interfaces
{
    using System.Collections.Generic;

    using Newtonsoft.Json.Linq;

    using PlayerUnknown.Logic.Components.Inventories;

    public interface IInventory
    {
        /// <summary>
        /// Gets the items.
        /// </summary>
        List<IItem> Items
        {
            get;
        }

        /// <summary>
        /// Gets the equips.
        /// </summary>
        List<object> Equips
        {
            get;
        }

        /// <summary>
        /// Gets the currencies.
        /// </summary>
        List<ICurrency> Currencies
        {
            get;
        }

        /// <summary>
        /// Gets the history.
        /// </summary>
        List<object> History
        {
            get;
        }

        /// <summary>
        /// Adds the item.
        /// </summary>
        /// <param name="Item">The item.</param>
        void AddItem(Item Item);

        /// <summary>
        /// Removes the item.
        /// </summary>
        /// <param name="Item">The item.</param>
        void RemoveItem(Item Item, int Amount = 1);

        /// <summary>
        /// Equips the item.
        /// </summary>
        /// <param name="Item">The item.</param>
        void EquipItem(Item Item);

        /// <summary>
        /// Unequips the item.
        /// </summary>
        /// <param name="Item">The item.</param>
        void UnequipItem(Item Item);

        /// <summary>
        /// Determines whether the player has the item.
        /// </summary>
        /// <param name="Item">The item.</param>
        bool HasItem(Item Item);

        /// <summary>
        /// Loads the specified json.
        /// </summary>
        /// <param name="Json">The json.</param>
        void Load(JObject Json);

        /// <summary>
        /// Saves this instance into a json object.
        /// </summary>
        JObject Save();
    }
}