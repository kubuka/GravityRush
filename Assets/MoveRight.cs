using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.PlayerLoop;

public class MoveRight : MonoBehaviour
{
    public float speed = 1;
    public GameObject bloodSplash;
    [SerializeField] GameObject loseScreen;
    scoreboard sb;
    MusicVolume mv;
    AudioSource audioS;
    AudioClip clip;

    private void Start()
    {
        audioS = GetComponent<AudioSource>();
        clip = audioS.clip;
        mv = FindObjectOfType<MusicVolume>();
        speed = 1;
        sb = FindObjectOfType<scoreboard>();
        loseScreen = GameObject.Find("LSparent").transform.GetChild(0).gameObject;
    }

    // Update is called once per frame
    private void FixedUpdate()
    {
        transform.Translate(new Vector2(1, 0)* speed * Time.fixedDeltaTime);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "Kolce")
        {
            sb.isDed = true;
            mv.ded = true;
            FindObjectOfType<PDmove>().GetComponent<AudioSource>().PlayOneShot(clip, 0.2f);
            FindObjectOfType<Skrol>().canMove = false;
            loseScreen.SetActive(true);
            sb.DisplayHighScore();
            var blood = Instantiate(bloodSplash, new Vector3(transform.position.x,transform.position.y,
                -2),Quaternion.identity);
            blood.GetComponent<ParticleSystem>().Play();
            Destroy(gameObject);
        }
    }

    private void Update()
    {
        if(FindObjectOfType<MusicVolume>() != null)
        {
            mv = FindObjectOfType<MusicVolume>();
        }
    }
}
