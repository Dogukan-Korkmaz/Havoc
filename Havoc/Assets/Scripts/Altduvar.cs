using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Altduvar : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D diger)
    {
        if (diger.gameObject.name.Equals("top"))
        {
            SceneManager.LoadScene("OyunuKaybet");
        }
    }
}
