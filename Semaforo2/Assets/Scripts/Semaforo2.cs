using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Threading;
using TMPro;

public class Semaforo2 : MonoBehaviour
{
    public GameObject Rojo;
    public GameObject Verde;
    public GameObject Amarillo;
    public bool BoolVerde2;
    public bool BoolAmarilla2;


    public void Start()
    {
        StartCoroutine(SemaforoCambio());

    }

    IEnumerator SemaforoCambio()
    {
        while (true)
        {
            LuzRoja1();
            yield return new WaitForSeconds(1);
            LuzVerde1();
            yield return new WaitForSeconds(1);
            LuzAmarilla1();
            yield return new WaitForSeconds(1);


        }
    }

    void LuzVerde1()
    {
        Verde.SetActive(true);
        Rojo.SetActive(false);
        Amarillo.SetActive(false);
        BoolVerde2 = true;
        BoolAmarilla2 = false;
    }

    void LuzRoja1()
    {
        Verde.SetActive(false);
        Rojo.SetActive(true);
        Amarillo.SetActive(false);
        BoolVerde2 = false;
        BoolAmarilla2 = false;
    }

    void LuzAmarilla1()
    {
        Verde.SetActive(false);
        Rojo.SetActive(false);
        Amarillo.SetActive(true);
        BoolVerde2 = true;
        BoolAmarilla2 = true;
    }
}