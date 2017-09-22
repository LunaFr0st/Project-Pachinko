using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
namespace Pachinko
{
    public class MainMenuManager : MonoBehaviour
    {
        public GUIStyle titleStyle;
        public GUIStyle menuStyle;
        public GUIStyle optionTitleStyle;
        public GUIStyle optionStyle;

        [Range(0, 1)]
        public float hue, saturation, value;
        [Header("Booleans")]
        public bool showOptions;

        private float scrW, scrH;

        void Start()
        {
            scrW = Screen.width / 9;
            scrH = Screen.height / 16;
        }

        void OnGUI()
        {
            // Title Styler
            titleStyle.fontSize = ((Screen.width/9) + (Screen.height / 16))/2;
            // Menu Styler
            // Options Menu title Styler
            // Options menu styler

            int spacer = 0;

            //GUI Elements
            if (!showOptions)
            {
                GUI.Box(new Rect(0, 0, 10 * scrW, 17 * scrH), "");
                GUI.Label(new Rect(0.25f * scrW, 2 * scrH, scrW, scrH), "Pachinko Madness", titleStyle);
                if (GUI.Button(new Rect(1.5f*scrW, 8*scrH, 6*scrW, 2*scrH), "Play"))
                {
                    print("Pressed");
                }
                spacer++;
                if (GUI.Button(new Rect(1.5f * scrW, (8 * scrH) + spacer * scrH, 6 * scrW, 2 * scrH), "Options"))
                {
                    print("Pressed");
                    showOptions = true;
                }
                spacer++;
                if (GUI.Button(new Rect(1.5f * scrW, (8 * scrH) + spacer*scrH, 6 * scrW, 2 * scrH), "Exit"))
                {
                    print("Pressed");
                    Application.Quit();
                }
            }
            if (showOptions)
            {
                GUI.Box(new Rect(0, 0, 10 * scrW, 17 * scrH), "");
            }
        }
    }
}

