using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Pachniko;

public class GUIManager : MonoBehaviour
{
    public float scrW;
    public float scrH;
    public GameObject ballPrefabs;
    public GameObject spawnPointer;
    public float powerScale = 1f;
    public Texture powerTexture;
    private Rigidbody cloneRB;
    public float shotPower = 100f;
    public float ammo = 100f;
    // Use this for initialization
    void Start()
    {
        scrW = Screen.width / 9;
        scrH = Screen.height / 16;

    }
    // Update is called once per frame
    void Update()
    {

        //powerScale += Mathf.PingPong(0, 4);
        if (powerScale >= 1)
        {
            powerScale += 2.5f * Time.deltaTime;
        }

        if (powerScale >= 4)
        {
            powerScale = 1;
        }
        if (powerScale <= 1)
        {
            powerScale = 1;

        }



    }

    void OnGUI()
    {
        Ball spawnBall = GetComponent<Ball>();
        if (ammo > 0)
        {
            if (GUI.Button(new Rect(0.5f * scrW, 14 * scrH, scrW, scrH), "Launch Ball!"))
            {
                //Instantiate(ballPrefabs, spawnPointer);
                GameObject clone = Instantiate(ballPrefabs, spawnPointer.transform) as GameObject;
                cloneRB = clone.GetComponent<Rigidbody>();
                cloneRB.AddForce(spawnPointer.transform.forward * (powerScale * shotPower), ForceMode.Impulse);
                ammo--;
            }
            // GUI.Box(new Rect(scrW, scrH, scrW, scrH), "POWER");
            GUI.Box(new Rect(0.25f * scrW, scrH, 0.25f * scrW, 4 * scrH), "POWER");
            GUI.Box(new Rect(0.25f * scrW, 5 * scrH, 0.25f * scrW, -powerScale * scrH), powerTexture);
        }
    }
}
