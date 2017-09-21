using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Pachinko;


namespace Pachinko
{
   

    public class BallLauncher : MonoBehaviour
    {
        public float ammo = 100f;
        private Rigidbody cloneRB;
        public GameObject ballPrefabs;
        public Transform spawnPoint;

        // Use this for initialization
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {

        }
        public void Launch()
        {
            GUIManager gui = GetComponent<GUIManager>();
            ballPrefabs.transform.position = spawnPoint.position;
            if (ammo > 0)
            {
                
                //Instantiate(ballPrefabs, spawnPointer);
                GameObject clone = Instantiate(ballPrefabs, spawnPoint.transform) as GameObject;
                cloneRB = clone.GetComponent<Rigidbody>();
                cloneRB.AddForce(transform.forward * (gui.powerScale * gui.shotPower), ForceMode.Impulse);
                ammo--;
            }
        }
    }
}
