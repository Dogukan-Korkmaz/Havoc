using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Top : MonoBehaviour
{
    private GameObject pedal;//Oyunun baþlayýp baþlamadýðýný kontrol etmek için.<1>
    private bool oyunBasladi = false;
    void Start()
    {
        //Pedal adlý c# scripti hangi objeye baðlýysa oynu bul.
        pedal = GameObject.FindObjectOfType<Pedal>().gameObject;
    }
    void Update()
    {
        if (!oyunBasladi)//<2>
        {
            transform.position = new Vector3(pedal.transform.position.x, transform.position.y, transform.position.z);
        }
        
        if (Input.GetMouseButtonDown(0) && !oyunBasladi)
        {
            oyunBasladi = true;//<3>
            GetComponent<Rigidbody2D>().velocity = new Vector2(1f, 11f);//Oyun baþladýðýnda topa küçük bir kuvvet lazým.
        }
    }
}
