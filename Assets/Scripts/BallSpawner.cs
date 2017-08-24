using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace LoopsArrays
{
    public class BallSpawner : MonoBehaviour
    {
        public GameObject[] spawnPrefabs;
        public float spawnRadius = 5f;
        public int spawnAmount = 10;
        public float printTime = 2f;
        public float amplitude = 6f;
        public float frequency = 6f;

        private float timer = 0;

        void OnDrawGizmos()
        {
            Gizmos.DrawWireSphere(transform.position, spawnRadius);
        }
        void Start()
        {
            SpawnObjectsWithSine();
        }

        void Update()
        {
            while (timer <= printTime)
            {
                timer += Time.deltaTime;
                print("Moses");
            }
        }
        void SpawnObjectsWithSine()
        {

            for (int i = 0; i < spawnAmount; i++)
            {
                int randomIndex = Random.Range(0, spawnPrefabs.Length);
                GameObject randomPrefab = spawnPrefabs[randomIndex];
                GameObject clone = Instantiate(randomPrefab);
                MeshRenderer rend = clone.GetComponent<MeshRenderer>();
                float r = Random.Range(0, 2);
                float g = Random.Range(0, 2);
                float b = Random.Range(0, 2);
                float a = 1;
                rend.material.color = new Color(r, b, g, a);
                float x = Mathf.Sin(i * frequency) * amplitude;
                float y = i;
                float z = Mathf.Cos(i * frequency) * amplitude;
                Vector3 randomPos = transform.position + new Vector3(x, y, z);
                clone.transform.position = randomPos;
            }
        }
    }
}