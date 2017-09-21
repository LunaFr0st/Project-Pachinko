using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Pachinko
{
    public class Ball : MonoBehaviour
    {
      
        public GameObject ballPrefab;

        public float scoreCounter;
        GameObject clone;
        public int bonusBall = 30;

        void Start()
        {
            //scoreCounter = 0;
        }
        void Update()
        {
          

            

        }
        void FixedUpdate()
        {
            //newBall();
        }
        void OnCollisionEnter(Collision other)
        {
            if (other.gameObject.tag == "Pin")
            {
               
            }



        }
    }
}


