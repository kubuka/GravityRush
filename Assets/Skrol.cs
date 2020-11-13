using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Skrol : MonoBehaviour
{
    [SerializeField] float speed = 1;
    Renderer render;
    Camera camera;
    public bool canMove = false;
    Vector2 offset;
    float elapsedTime;
   public  float startTime;
    // Start is called before the first frame update
    void Start()
    {
        camera = Camera.main;
        render = gameObject.GetComponent<MeshRenderer>();
        render.material.mainTextureOffset = Vector2.zero;
        offset = Vector2.zero;
        elapsedTime -= startTime;

        if(SceneManager.GetActiveScene().buildIndex == 0)
        {
            gameObject.transform.position = new Vector2(camera.transform.position.x, camera.transform.position.y);
        }
    }

    // Update is called once per frame
    void Update()
    {
        elapsedTime = Time.time - startTime;
        if (canMove)
        {         
            offset = new Vector2((elapsedTime) * speed, 0);
            render.material.mainTextureOffset = offset;
        }       
    }
}