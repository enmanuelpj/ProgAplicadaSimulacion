using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Threading;
using TMPro;

public class Semaforo : MonoBehaviour
{
    public GameObject Rojo;
    public GameObject Verde;
    public GameObject Amarillo;
    public bool BoolVerde;
    public bool BoolAmarilla;


    public void Start()
    {
        StartCoroutine(SemaforoCambio());

    }

    IEnumerator SemaforoCambio()
    {
        while(true)
        {
            LuzVerde1();
            yield return new WaitForSeconds(1);
            LuzAmarilla1();
            yield return new WaitForSeconds(1);
            LuzRoja1();
            yield return new WaitForSeconds(1);
        }
    }

    void LuzVerde1()
    {
        Verde.SetActive(true);
        Rojo.SetActive(false);
        Amarillo.SetActive(false);
        BoolVerde = true;
        BoolAmarilla = false;
    }

    void LuzRoja1()
    {
        Verde.SetActive(false);
        Rojo.SetActive(true);
        Amarillo.SetActive(false);
        BoolVerde = false;
        BoolAmarilla = false;
    }

    void LuzAmarilla1()
    {
        Verde.SetActive(false);
        Rojo.SetActive(false);
        Amarillo.SetActive(true);
        BoolVerde = true;
        BoolAmarilla = true;
    }
}
