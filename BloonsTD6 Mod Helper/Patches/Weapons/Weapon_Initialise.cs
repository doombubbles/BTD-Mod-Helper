﻿using Assets.Scripts.Models;
using Assets.Scripts.Simulation.Objects;
using Assets.Scripts.Simulation.Towers.Weapons;

namespace BTD_Mod_Helper.Patches.Weapons;

[HarmonyPatch(typeof(Weapon), nameof(Weapon.Initialise))]
internal class Weapon_Initialise
{
    [HarmonyPostfix]
    internal static void Postfix(Weapon __instance, Entity target, Model modelToUse)
    {
        ModHelper.PerformHook(mod => mod.OnWeaponCreated(__instance, target, modelToUse));
        ModHelper.PerformHook(mod => mod.OnWeaponModelChanged(__instance, modelToUse));
    }
}