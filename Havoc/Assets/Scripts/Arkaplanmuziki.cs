using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Arkaplanmuziki : MonoBehaviour
{
    static bool SahnedeM�zikVar;
    // Start is called before the first frame update
    void Start()
    {
        if (!SahnedeM�zikVar)
        {
            GameObject.DontDestroyOnLoad(this.gameObject);
            SahnedeM�zikVar = true;
        }
        else
        {
            Destroy(gameObject);
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
