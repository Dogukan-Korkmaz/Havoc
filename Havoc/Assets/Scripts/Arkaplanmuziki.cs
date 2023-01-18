using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Arkaplanmuziki : MonoBehaviour
{
    static bool SahnedeMüzikVar;
    // Start is called before the first frame update
    void Start()
    {
        if (!SahnedeMüzikVar)
        {
            GameObject.DontDestroyOnLoad(this.gameObject);
            SahnedeMüzikVar = true;
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
