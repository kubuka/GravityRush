using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Singleton : MonoBehaviour
{
    Singleton instance;

    // Start is called before the first frame update
    void Awake()
    {
        if(FindObjectsOfType<Singleton>().Length > 1)
        {
            Destroy(gameObject);
        }
        instance = this;
        DontDestroyOnLoad(this.gameObject);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
