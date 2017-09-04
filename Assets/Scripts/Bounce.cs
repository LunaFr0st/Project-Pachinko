using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bounce : MonoBehaviour
{
    public float bounce;
    Rigidbody rigi;
    // Use this for initialization
    void Start()
    {
        rigi = GetComponent<Rigidbody>();
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.transform.tag == "Pin")
        {
            rigi.velocity = ((transform.position - collision.contacts[0].point) * bounce);
        }
    }
}
