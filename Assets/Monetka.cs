using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Monetka : MonoBehaviour
{
    scoreboard sb;
    AudioSource audioS;
    // Start is called before the first frame update
    void Start()
    {
        sb = FindObjectOfType<scoreboard>();
        audioS = GetComponent<AudioSource>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "Player")
        {
            Debug.Log("gram");
            AudioClip clip = audioS.clip;
            sb.AddMonetka();
            FindObjectOfType<PDmove>().GetComponent<AudioSource>().PlayOneShot(clip,0.05f);
            Destroy(gameObject);
        }
    }
}
