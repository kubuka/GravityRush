using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    GameObject player;
    public float offSet = 0.55f;

    // Start is called before the first frame update
    void Start()
    {
      //  player = FindObjectOfType<MoveRight>().gameObject;
    }

    // Update is called once per frame
    void Update()
    {
        if(player != null)
        {
            gameObject.transform.position = new Vector3(player.transform.position.x +1, 0, -10);
        }
        else
        {
            if(FindObjectOfType<MoveRight>() != null)
            {
                player = FindObjectOfType<MoveRight>().gameObject;
            }
        }      
    }
}
