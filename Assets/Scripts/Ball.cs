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

        // Use this for initialization
        void Start()
        {
        }

        // Update is called once per frame
        void Update()
        {
            scoreDisplayCounter.text = "Ball Bounces: " + scoreCounter + " / 10";
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
            
            if (scoreCounter > 10)
            {
                scoreCounter = 0;
            }
            if (scoreCounter == 10)
            {
                clone = Instantiate(ballPrefab, spawnPoint.transform.position, Quaternion.identity);
                scoreCounter = 0;
            }
        }
    }
}


