using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PDmove : MonoBehaviour
{
    GameObject player;
    float offset;

    private void Start()
    {
        Camera camera = FindObjectOfType<Camera>();
        camera.transform.position = new Vector3(1.4f, 0, -10);
    }

    // Update is called once per frame
    void Update()
    {
        if (player != null)
        {
            gameObject.transform.position = new Vector2(player.transform.position.x - Mathf.Abs(offset), 0);
        }
        else
        {
            if(FindObjectOfType<MoveRight>() != null)
            {
                player = FindObjectOfType<MoveRight>().gameObject;
                offset = gameObject.transform.position.x - player.transform.position.x;
            }
        }
    }
}
        
