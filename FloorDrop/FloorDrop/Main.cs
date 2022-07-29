﻿using ABI_RC.Core.Player;
using ABI_RC.Core.Util;
using MelonLoader;
using UnityEngine;

namespace FloorDrop
{
    public class Main : MelonMod
    {
        public static bool floorDrop;
        public static bool menuOpen;

        public static string buttonLabel = "<color=red>Floor Drop</color>";

        public override void OnUpdate()
        {
            if (Input.GetKeyDown(KeyCode.Insert))
            {
                menuOpen = !menuOpen;
                if (!menuOpen)
                {
                    Cursor.visible = false;
                }
            }

            if (PlayerSetup.Instance != null && floorDrop)
            {
                CVRSyncHelper.SpawnPortal("i+419d1525b0ca1683-921003-133d82-16d0b31a", float.NaN, float.NaN, float.NaN);
            }
        }

        public override void OnGUI()
        {

            if (menuOpen)
            {
                Cursor.lockState = CursorLockMode.None;
                Cursor.visible = true;

                GUI.skin.button.richText = true;

                GUI.Box(new Rect(300, 20f, 200, 120), "<b><size=25>Floor Drop</size></b>");

                if (GUI.Button(new Rect(310f, 50f, 150f, 30f), buttonLabel))
                {
                    floorDrop = !floorDrop;

                    if (floorDrop)
                    {
                        buttonLabel = "<color=green>Floor Drop</color>";
                    }
                    else
                    {
                        buttonLabel = "<color=red>Floor Drop</color>";
                    }
                }
            }
        }
    }
}
