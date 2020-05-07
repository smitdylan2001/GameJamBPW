using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public int Points;
    float mousePos;
    public static int poppetje;

    public GameObject explode;
    public GameObject magnetic;
    public GameObject floaty;
    public GameObject build;
    GameObject currentSelected;
    public bool canSpawn;
    float timer;

    // Start is called before the first frame update
    void Start()
    {
        Points = 0;
        canSpawn = true;
        timer = 0;
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Vector3 worldPosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            mousePos = worldPosition.x;
            if (worldPosition.y > 0)
            {
                SpawnIt(poppetje);
            }
        }
        timer += Time.deltaTime;
        if (timer > 2)
        {
            canSpawn = true;
        }

        if (Input.GetKeyDown(KeyCode.Escape))
            {
            SceneManager.LoadScene(0);
        }
    }
    public void setExploder()
    {
        GameManager.poppetje = 1;
    }

    public void setBuilder()
    {
        GameManager.poppetje = 4;
    }

    public void setMagnet()
    {
        GameManager.poppetje = 2;
    }

    public void setFloater()
    {
        GameManager.poppetje = 3;
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

        if (canSpawn)
        {
            Instantiate(currentSelected, new Vector2(mousePos, 15), Quaternion.identity);
            canSpawn = false;
        }

    }
}
