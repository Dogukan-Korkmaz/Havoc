using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pedal : MonoBehaviour
{
    void Start()
    {
        
    }

    void Update()
    //Farenin pozisyon de�erlerini(x ve y, z de�erine ihtiyac�m�z yok) pedala transfer etme.
    //��lem ger�ek zamanla ger�ekle�meli bu y�zden update i�inde.
    {
        Vector3 farePos = Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, 10f));
        transform.position = new Vector3(farePos.x, transform.position.y, transform.position.z);
    }


}
