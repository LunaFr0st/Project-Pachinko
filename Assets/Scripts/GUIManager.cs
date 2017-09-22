﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


namespace Pachinko
{
    public class GUIManager : MonoBehaviour
    {
        public GUIStyle gameStyle;
        public GUIStyle ballStyle;
        public GUIStyle scaleStyle;
        public GUIStyle boxStyle;
        public Font font;

        private float scrW;
        private float scrH;
        private int screenW;
        private int screenH;
        [Range(0,1)]
        public float hue, saturation, value;

        public float powerScale = 1f;
        public Texture powerTexture;
        private Rigidbody cloneRB;
        public float shotPower = 100f;

        // Use this for initialization
        void Start()
        {
            scrW = Screen.width / 16;
            scrH = Screen.height / 9;

            screenW = Screen.width / 16;
            screenH = Screen.height / 9;

        }
        // Update is called once per frame
        void Update()
        {

            //powerScale += Mathf.PingPong(0, 4);
            if (powerScale >= 1)
            {
                powerScale += 1.5f * Time.deltaTime;
            }

            if (powerScale >= 4)
            {
                powerScale = 1;
            }
            if (powerScale <= 1)
            {
                powerScale = 1;

            }
            
        }

        void OnGUI()
        {
            gameStyle.font = font;
            gameStyle.fontSize = ((Screen.width / 9) + (Screen.height / 16)) / 2;
            gameStyle.normal.textColor = Color.HSVToRGB(hue,saturation,value);

            ballStyle.font = font;
            ballStyle.fontSize = ((Screen.width / 9) + (Screen.height / 16)) / 4;
            ballStyle.normal.textColor = Color.HSVToRGB(hue, saturation, value);


            BallLauncher b = GetComponent<BallLauncher>();
            GUI.Box(new Rect(2.9f*scrH,25.65f*scrW,2*scrH,1f*scrW), "  Balls Left: " + b.ammo, ballStyle);
            if (GUI.Button(new Rect(scrW, 8f * scrH, 6.85f*scrW, 0.6f*scrH), " Launch", gameStyle))
            {
                b.Launch();
            }
            // GUI.Box(new Rect(scrW, scrH, scrW, scrH), "POWER");
            GUI.Box(new Rect(0.25f * scrW, 2.75f * scrH, 1f * scrW, 4 * scrH), "POWER",boxStyle);
            GUI.Box(new Rect(0.5f * scrW, 6.75f * scrH, 0.5f * scrW, -powerScale * scrH), "",scaleStyle);
        }
    }
}

