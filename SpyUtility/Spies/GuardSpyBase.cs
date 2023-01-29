﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using PlayerRoles;
using PluginAPI.Core.Items;
using Respawning;
using UnityEngine;

namespace SpyUtilityNW.Spies
{
    public class GuardSpyBase : SpyBase
    {
        
        /// <summary>
        /// Default ammo for spy
        /// </summary>
        [Description("Default items for spy")]
        public override List<ItemType> SpyStartingItems { get; set; } = new()
        {
            ItemType.ArmorCombat,
            ItemType.Radio,
            ItemType.GrenadeHE,
            ItemType.Medkit,
            ItemType.Adrenaline,
            ItemType.GunCrossvec,
            ItemType.KeycardNTFOfficer,
        };

        /// <summary>
        /// Default ammo for spy
        /// </summary>
        [Description("Default ammo for spy")]
        public override Dictionary<ItemType, ushort> SpyStartingAmmo { get; set; } = new()
        {
            {ItemType.Ammo9x19, 40},
        };

        /// <summary>
        /// Override spawn position
        /// </summary>
        [Description("Override spy spawn position (Vector3). I DO NOT RECOMMEND.")]
        public override List<float> SpawnPosition { get; set; } = new()
        {
            0f,
            0f,
            0f
        };
        
        /// <summary>
        /// Spies fake role, role that is used in change appearance
        /// </summary>
        [Description("The fake role the spy will be, aka, what they will look like until exposed")]
        public override RoleTypeId SpyFakeRole { get; set; } = RoleTypeId.FacilityGuard;
        
        /// <summary>
        /// Spies real role, role that is shown when revealed.
        /// </summary>
        [Description("The real role the spy will be, aka, what they will look like after exposed")]
        public override RoleTypeId SpyRealRole { get; set; } = RoleTypeId.ChaosRifleman;

        public override SpawnableTeamType SpawnTeamType { get; set; } = SpawnableTeamType.NineTailedFox;
    }
}