using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MusicVolume : MonoBehaviour
{
    AudioSource audioS;
    bool down = false;
    bool up = true;
    public bool ded = false;
    // Start is called before the first frame update
    void Start()
    {
        audioS = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {

        if(up && SceneManager.GetActiveScene().buildIndex == 0)
        {
            StartCoroutine(VolumeDown());
            up = false;
            down = true;
        }

        if(ded && !down && SceneManager.GetActiveScene().buildIndex ==1)
        {
            StartCoroutine(VolumeDown());
            down = true;
            up = false;
        }

        if(!ded && down && SceneManager.GetActiveScene().buildIndex == 1)
        {
            StartCoroutine(VolumeUp());
            down = false;
            up = true;
        }
    }
    IEnumerator VolumeDown()
    {
        while (audioS.volume > 0.010f)
        {
            audioS.volume -= 0.001f;
            yield return new WaitForSeconds(0.1f);
        }
    }

    IEnumerator VolumeUp()
    {
        while(audioS.volume < 0.02f)
        {
            audioS.volume += 0.001f;
            yield return new WaitForSeconds(0.1f);
        }
    }
}
