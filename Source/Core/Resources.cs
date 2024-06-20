﻿using HarmonyLib;
using RimWorld;
using UnityEngine;
using Verse;

namespace BetterPawnControl
{
    [StaticConstructorOnStartup]
    public static class Resources
    {
        public enum Type { work, restrict, assign, animal, mech, weapons, robots };

        [DefOf]
        public static class Hotkeys
        {
            public static KeyBindingDef BetterPawnControlEmergency;
        }

        [StaticConstructorOnStartup]
        public static class Textures
        {
            public static readonly Texture2D Settings = ContentFinder<Texture2D>.Get("UI/Buttons/Settings");
            public static readonly Texture2D EmergencyOn = ContentFinder<Texture2D>.Get("UI/Buttons/EmergencyOn");
            public static readonly Texture2D EmergencyOff = ContentFinder<Texture2D>.Get("UI/Buttons/EmergencyOff");
            public static readonly Texture2D[] medcareGraphics = AccessTools.Field(typeof(MedicalCareUtility), "careTextures").GetValue(null) as Texture2D[];
        }
    }
}
