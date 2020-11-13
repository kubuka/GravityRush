using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RunScript : MonoBehaviour
{
    private Rigidbody2D runScript;
    MoveRight mR;
    
    float czasFazy = 5f;
    float startTime;
   public  float elapsedTime;


    
    // Start is called before the first frame update
    void Start()      
    {
        startTime = Time.time;
        elapsedTime -= startTime;
    }

    // Update is called once per frame
    void Update()
    {
        elapsedTime = Time.time - startTime;
        if (mR == null)
        {
            if(FindObjectOfType<MoveRight>() != null)
            {
                mR = FindObjectOfType<MoveRight>();
            }
        }
        if (elapsedTime > czasFazy && mR != null)
        {
            czasFazy += 20f;
            mR.speed += 0.3f;
        }
    }
}
