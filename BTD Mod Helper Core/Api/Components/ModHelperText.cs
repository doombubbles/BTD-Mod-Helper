﻿using System;
using MelonLoader;
using TMPro;
using UnityEngine;

namespace BTD_Mod_Helper.Api.Components
{
    /// <summary>
    /// ModHelperComponent for a background panel
    /// </summary>
    [RegisterTypeInIl2Cpp(false)]
    public class ModHelperText : ModHelperComponent
    {
        /// <summary>
        /// Default BTD6 font
        /// </summary>
        public static TMP_FontAsset luckiestGuy;
        
        /// <summary>
        /// The component that handles the Text rendering
        /// </summary>
        public NK_TextMeshProUGUI Text { get; private set; }
        
        
        /// <inheritdoc />
        public ModHelperText(IntPtr ptr) : base(ptr)
        {
        }

        /// <summary>
        /// Creates a new ModHelperText
        /// </summary>
        /// <param name="rect">The position (offset of child center from parent center) and size</param>
        /// <param name="text">The text to display</param>
        /// <param name="fontSize">Size of font</param>
        /// <param name="align">Alignment of text</param>
        /// <param name="objectName">The Unity name of the object</param>
        /// <returns>The created ModHelperText</returns>
        public static ModHelperText Create(Rect rect, string text, float fontSize = 42, TextAlignmentOptions align = TextAlignmentOptions.Center, 
            string objectName = "ModHelperText")
        {
            var modHelperText = ModHelperComponent.Create<ModHelperText>(rect, objectName);

            var textMesh = modHelperText.Text = modHelperText.AddComponent<NK_TextMeshProUGUI>();

            textMesh.SetText(text);
            textMesh.alignment = align;
            textMesh.fontSize = fontSize;
            textMesh.font = luckiestGuy;
            textMesh.overflowMode = TextOverflowModes.Ellipsis;
            
            return modHelperText;
        }
    }
}