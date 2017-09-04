using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Pachniko;

public class GUIManager : MonoBehaviour
{
    public float scrW;
    public float scrH;
    public GameObject ballPrefabs;
    public Transform spawnPointer;
    public float powerScale = 1f;
    public Texture powerTexture;

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
        if (powerScale >= 0)
        {
            powerScale += 2.5f * Time.deltaTime;
        }
        
        if (powerScale >= 4)
        {
            powerScale = 0;
        }
        if (powerScale <= 0)
        {
            powerScale = 0;

        }
        


    }

    void OnGUI()
    {
        Ball spawnBall = GetComponent<Ball>();
        if (GUI.Button(new Rect(0.5f * scrW, 14 * scrH, scrW, scrH), "Launch Ball!"))
        {
            Instantiate(ballPrefabs, spawnPointer);
        }
        // GUI.Box(new Rect(scrW, scrH, scrW, scrH), "POWER");
        GUI.Box(new Rect(0.25f * scrW, scrH, 0.25f * scrW, 4 * scrH), "POWER");
        GUI.Box(new Rect(0.25f * scrW, 5 * scrH, 0.25f * scrW, -powerScale * scrH), powerTexture);
    }

}
