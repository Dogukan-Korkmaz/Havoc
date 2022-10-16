using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pedal : MonoBehaviour
{
    void Start()
    {
        
    }

    void Update()
    //Farenin pozisyon deðerlerini(x ve y, z deðerine ihtiyacýmýz yok) pedala transfer etme.
    //Ýþlem gerçek zamanla gerçekleþmeli bu yüzden update içinde.
    {
        Vector3 farePos = Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, 10f));
        transform.position = new Vector3(farePos.x, transform.position.y, transform.position.z);
    }


}
