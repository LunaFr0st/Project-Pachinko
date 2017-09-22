using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Pachinko;


namespace Pachinko
{
   

    public class BallLauncher : MonoBehaviour
    {
        public int ammo = 100;
        private Rigidbody cloneRB;
        public GameObject ballPrefabs;
        public Transform spawnPoint;

        void Update()
        {
            if(ammo > 999)
            {
                ammo = 999;
            }
            if(ammo <= 0)
            {
                ammo = 0;
                
            }
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
