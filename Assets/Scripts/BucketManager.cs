using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class BucketManager : MonoBehaviour {
    public GameObject minBucket;
    public GameObject midBucket;
    public GameObject maxBucket;
    public float minPoints = 50;
    public float midPoints = 100;
    public float maxPoints = 150;
    public float bucketScore;
    // Use this for initialization
    void Start()
    {
        bucketScore = 0;
    }
    void OnCollisionEnter(Collision other)
    {
        if (minBucket)
        {
            if (other.gameObject.tag == "Ball")
            {
                Destroy(other.gameObject);
                bucketScore = bucketScore + minPoints;
            }
        }
        if (midBucket)
        {
            if (other.gameObject.tag == "Ball")
            {
                Destroy(other.gameObject);
                bucketScore = bucketScore + midPoints;
            }
        }
        if (maxBucket)
        {
            if (other.gameObject.tag == "Ball")
            {
                Destroy(other.gameObject);
                bucketScore = bucketScore + maxPoints;
            }
        }
    }
}