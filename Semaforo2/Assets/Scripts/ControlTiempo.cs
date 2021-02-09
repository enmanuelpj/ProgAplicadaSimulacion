using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlTiempo : MonoBehaviour
{
    // Start is called before the first frame update
    public void Default()
    {
        Time.timeScale = 1;
    }

    public void Lento()
    {
        Time.timeScale = 0.3f;
    }

    public void Rapido()
    {
        Time.timeScale = 3;
    }


}
