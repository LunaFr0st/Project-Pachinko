using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class MeshFlip : MonoBehaviour
{

    void Start()
    {
        Mesh mesh = GetComponent<MeshFilter>().mesh;
        mesh.triangles = mesh.triangles.Reverse().ToArray();
    }
    void OnTriggerExit(Collider col)
    {
        Destroy(col.gameObject);
    }
}
