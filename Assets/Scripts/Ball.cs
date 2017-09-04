using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Pachniko
{
    public class Ball : MonoBehaviour
    {
        public int scoreCounter;
        public GameObject ballPrefab;
        public Text scoreDisplayCounter;
        public GameObject spawnPoint;
        public GameObject clone;
        public int bonusBall = 30;

        // Use this for initialization
        void Start()
        {
            scoreCounter = 0;
        }

        // Update is called once per frame
        void Update()
        {
            scoreDisplayCounter.text = "Ball Bounces: " + scoreCounter + " / 10";
            if (scoreCounter > bonusBall)
            {
                scoreCounter = 0;
            }
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
                print("Score Increased to: " + scoreCounter);
            }
        }
        void newBall()
        {
            
            
            if (scoreCounter == bonusBall)
            {
                clone = Instantiate(ballPrefab, spawnPoint.transform.position, Quaternion.identity);
                scoreCounter = 0;
            }
        }
    }
}


