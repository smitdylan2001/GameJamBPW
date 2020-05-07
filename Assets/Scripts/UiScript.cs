using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UiScript : MonoBehaviour
{

    //public class manager;
    // Start is called before the first frame update
    void Start()
    {
        
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
}
