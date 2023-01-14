using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tugla : MonoBehaviour
{
    public Sprite[] tuglaSprite;
    private int maxCarpmaSayisi;
    private int carpmaSayisi;
    void Start()
    {
        maxCarpmaSayisi = tuglaSprite.Length + 1 ;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D diger)
    {
        if (diger.gameObject.name.Equals("top"))
        {
            carpmaSayisi++;
            if (carpmaSayisi >= maxCarpmaSayisi)
            {
                Destroy(this.gameObject);
            }
            else
            {
                GetComponent<SpriteRenderer>().sprite = tuglaSprite[carpmaSayisi - 1];
            }
        }
    }
}
