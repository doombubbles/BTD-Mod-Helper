﻿using Assets.Scripts.Simulation;

namespace BTD_Mod_Helper.Patches.Sim;

[HarmonyPatch(typeof(Simulation), nameof(Simulation.RemoveCash))]
internal class Simulation_RemoveCash
{
    [HarmonyPostfix]
    internal static void Postfix(double c, Simulation.CashType from, int cashIndex, Simulation.CashSource source)
    {
        ModHelper.PerformHook(mod => mod.OnCashRemoved(c, from, cashIndex, source));
    }
}