using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Pachniko
{
    public class Ball : MonoBehaviour
    {
        public static int scoreCounter;
        public GameObject ballPrefab;
        public Text scoreDisplayCounter;
        public Transform spawnPoint;
        GameObject clone;
        public int bonusBall = 30;

        void Start()
        {
            scoreCounter = 0;
        }
        void Update()
        {
            scoreDisplayCounter.text = "Ball Bounces: " + scoreCounter + " / " + bonusBall;
            /**
            if (scoreCounter > bonusBall)
            {
                scoreCounter = 0;
            }
            /**/

            

        }
        void FixedUpdate()
        {
            newBall();
        }
        void OnCollisionEnter(Collision other)
        {
            if (other.gameObject.tag == "Pin")
            {
                scoreCounter++;
             //   print("Score Increased to: " + scoreCounter);
            }
        }
        void newBall()
        {
            if (scoreCounter >= bonusBall)
            {
                clone = Instantiate(ballPrefab, spawnPoint.position, Quaternion.identity) as GameObject;
                scoreCounter = 0;
            }
        }



    }
}


