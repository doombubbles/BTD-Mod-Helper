﻿using Assets.Scripts.Utils;

namespace BTD_Mod_Helper.Extensions;

/// <summary>
/// Extensions for SpriteReferences
/// </summary>
public static class SpriteReferenceExt
{
    /// <summary>
    /// Returns's the GUID of this SpriteReference
    /// </summary>
    /// <param name="spriteReference"></param>
    /// <returns></returns>
    public static string GetGUID(this SpriteReference spriteReference)
    {
#if BloonsTD6
        return spriteReference.GUID;
#elif BloonsAT
            return spriteReference.Guid;
#endif
    }
}