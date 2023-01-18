using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class buton : MonoBehaviour
{
    public void DigerSahne()
    {
        tugla.toplamTuglaSayisi = 0;
        GameObject.FindObjectOfType<Puan>().GetComponent<Puan>().PuanSifirla();
        SceneManager.LoadScene("Bolum1");
    }
}
