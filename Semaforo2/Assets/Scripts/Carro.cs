using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Carro : MonoBehaviour
{
    public GameObject IndicadorSemaforo;
    public GameObject IndicadorSemaforo2;
    public GameObject Audi;
    public GameObject Patana;
    public GameObject Police;
    public GameObject Taxi;

    // Start is called before the first frame update
    void Start()
    {
        IndicadorSemaforo = GameObject.Find("Semaforo1");
        IndicadorSemaforo2 = GameObject.Find("Semaforo2");

        if (this.name.Equals("Taxi")) //Este
        {
            transform.position = new Vector2(-10.9f, -1f);
            
        }
        if (this.name.Equals("Police")) //Oeste
        {
            transform.position = new Vector2(11.41f, 0.8f);
        }
        if (this.name.Equals("Audi")) //Norte
        {
            transform.position = new Vector2(0f, -6.38f);
        }

        if (this.name.Equals("Patana")) //Sur
        {
            transform.position = new Vector2(-1.5f, 7.02f);
        }

    }

    // Update is called once per frame
    void Update()
    {

        if (IndicadorSemaforo.GetComponent<Semaforo>().BoolVerde)
        {
            if (this.name.Equals("Audi")) //Norte
            {
                transform.Translate(Vector3.up * Time.deltaTime * 4);
                transform.Translate(Vector3.up * Time.deltaTime, Space.World);

                Audi.GetComponent<BoxCollider2D>().isTrigger = true;
                if (IndicadorSemaforo.GetComponent<Semaforo>().BoolAmarilla)
                {
                    Audi.GetComponent<BoxCollider2D>().isTrigger = false;
                }


            }
            
            if (this.name.Equals("Patana")) //Sur
            {
                transform.Translate(Vector3.down * Time.deltaTime* 4);
                transform.Translate(Vector3.down * Time.deltaTime, Space.World);

                Patana.GetComponent<BoxCollider2D>().isTrigger = true;
                if (IndicadorSemaforo.GetComponent<Semaforo>().BoolAmarilla)
                {
                    Patana.GetComponent<BoxCollider2D>().isTrigger = false;
                }
            }
        }

        if (IndicadorSemaforo2.GetComponent<Semaforo2>().BoolVerde2)
        {
            if (this.name.Equals("Police")) //Oeste
            {
                transform.Translate(Vector3.left * Time.deltaTime * 4);
                transform.Translate(Vector3.left * Time.deltaTime, Space.World);

                Police.GetComponent<BoxCollider2D>().isTrigger = true;
                if (IndicadorSemaforo2.GetComponent<Semaforo2>().BoolAmarilla2)
                {
                    Police.GetComponent<BoxCollider2D>().isTrigger = false;
                }

            }

            if (this.name.Equals("Taxi")) //Este
            {
                transform.Translate(Vector3.right * Time.deltaTime * 4);
                transform.Translate(Vector3.right * Time.deltaTime, Space.World);

                Taxi.GetComponent<BoxCollider2D>().isTrigger = true;
                if (IndicadorSemaforo2.GetComponent<Semaforo2>().BoolAmarilla2)
                {
                    Taxi.GetComponent<BoxCollider2D>().isTrigger = false;
                }
                
            }
        }

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "Destroyer")
        {
            Destroy(this.gameObject);
        }
    }
}
