using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Top : MonoBehaviour
{
    private GameObject pedal;//Oyunun ba�lay�p ba�lamad���n� kontrol etmek i�in.<1>
    private bool oyunBasladi = false;
    void Start()
    {
        //Pedal adl� c# scripti hangi objeye ba�l�ysa oynu bul.
        pedal = GameObject.FindObjectOfType<Pedal>().gameObject;
    }
    void Update()
    {
        if (!oyunBasladi)//<2>
        {
            transform.position = new Vector3(pedal.transform.position.x, transform.position.y, transform.position.z);
        }
        
        if (Input.GetMouseButtonDown(0))
        {
            oyunBasladi = true;//<3>
            GetComponent<Rigidbody2D>().velocity = new Vector2(1f, 11f);//Oyun ba�lad���nda topa k���k bir kuvvet laz�m.
        }
    }
}
