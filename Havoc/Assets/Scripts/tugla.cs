using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tugla : MonoBehaviour
{
    public static int toplamTuglaSayisi;
    public Sprite[] tuglaSprite;
    private int maxCarpmaSayisi;
    private int carpmaSayisi;
    private Puan puanScripti;
    void Start()
    {
        maxCarpmaSayisi = tuglaSprite.Length + 1;
        toplamTuglaSayisi++;
        puanScripti = GameObject.FindObjectOfType<Puan>().GetComponent<Puan>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D diger)
    {
        if (diger.gameObject.name.Equals("top"))
        {
            puanScripti.PuanArtir();
            carpmaSayisi++;
            if (carpmaSayisi >= maxCarpmaSayisi)
            {
                toplamTuglaSayisi--;
                Debug.Log(toplamTuglaSayisi);
                if (toplamTuglaSayisi <=0)
                {
                    GameObject.FindObjectOfType<OyunKontrol>().GetComponent<OyunKontrol>().BirSonrakiSahne();
                }
                Destroy(this.gameObject);
            }
            else
            {
                GetComponent<SpriteRenderer>().sprite = tuglaSprite[carpmaSayisi - 1];
            }
        }
    }
}
