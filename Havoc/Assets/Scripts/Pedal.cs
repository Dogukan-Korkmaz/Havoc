using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pedal : MonoBehaviour
{
    public AudioClip sesEfekti;
    void Start()
    {
        
    }

    void Update()
    //Farenin pozisyon de�erlerini(x ve y, z de�erine ihtiyac�m�z yok) pedala transfer etme.
    //��lem ger�ek zamanla ger�ekle�meli bu y�zden update i�inde.
    {
        Vector3 farePos = Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, 10f));
        transform.position = new Vector3(Mathf.Clamp(farePos.x,-6.4f,6.4f), transform.position.y, transform.position.z);
    }
    void OnCollisionEnter2D(Collision2D diger)
    {
        AudioSource.PlayClipAtPoint(sesEfekti, transform.position);
    }


}
