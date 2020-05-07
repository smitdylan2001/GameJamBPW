using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public int Points;
    float mousePos;
    public int poppetje;

    public GameObject explode;
    public GameObject magnetic;
    public GameObject floaty;
    public GameObject build;
    GameObject currentSelected;

    // Start is called before the first frame update
    void Start()
    {
        Points = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            
            Vector3 worldPosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            mousePos = worldPosition.x;
            SpawnIt(poppetje);
        }
    }

    void SpawnIt(int spawnThis)
    {
        if (spawnThis == 1)
        {
            currentSelected = explode;
        }
        if (spawnThis == 0)
        {
            currentSelected = build;
        }
        if (spawnThis == 2)
        {
            currentSelected = magnetic;
        }
        if (spawnThis == 3)
        {
            currentSelected = floaty;
        }
        if (spawnThis == 4)
        {
            currentSelected = build;
        }
        Instantiate(currentSelected, new Vector2(mousePos, 15), Quaternion.identity);

    }
}
