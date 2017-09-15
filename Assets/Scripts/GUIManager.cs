﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


namespace Pachinko
{
    public class GUIManager : MonoBehaviour
    {
        public GUIStyle gameStyle;
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
                powerScale += 2.5f * Time.deltaTime;
            }

            if (powerScale >= 4)
            {
                powerScale = 1;
            }
            if (powerScale <= 1)
            {
                powerScale = 1;

            }
            // scoreDisplayCounter.text = "Ball Bounces: " + scoreCounter + " / " + bonusBall;
            /**
            if (scoreCounter > bonusBall)
            {
                scoreCounter = 0;
            }
            /**/



        }

        void OnGUI()
        {
            gameStyle.font = font;
            gameStyle.fontSize = screenW / screenH;
            gameStyle.normal.textColor = Color.HSVToRGB(hue,saturation,value);



            if (GUI.Button(new Rect(0.75f * scrW, 14 * scrH, 4*scrW, 2*scrH), "Launch Ball!", gameStyle))
            {
                BallLauncher b = GetComponent<BallLauncher>();
                b.Launch();
            }
            // GUI.Box(new Rect(scrW, scrH, scrW, scrH), "POWER");
            GUI.Box(new Rect(0.25f * scrW, scrH, 0.25f * scrW, 4 * scrH), "POWER", gameStyle);
            GUI.Box(new Rect(0.25f * scrW, 5 * scrH, 0.25f * scrW, -powerScale * scrH), powerTexture);
        }
    }
}

