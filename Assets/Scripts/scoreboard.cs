using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class scoreboard : MonoBehaviour
{
    float currentTime = 0f;
    float startingTime = 0f;
    public bool isDed = false;
    int highscore;
    GameObject loseScreen;

    [SerializeField] TextMeshProUGUI countdownText;

    // Start is called before the first frame update
    void Start()
    {
        loseScreen = GameObject.Find("LSparent").transform.GetChild(0).gameObject;
        currentTime = startingTime;
        highscore = PlayerPrefs.GetInt("highscore", highscore);
    }

    // Update is called once per frame
    void Update()
    {
        if (!isDed && FindObjectOfType<MoveRight>() != null)
        {
            currentTime += 1 * Time.deltaTime;
            countdownText.text = currentTime.ToString("0");

            if(highscore <= currentTime)
            {
                PlayerPrefs.SetInt("highscore", Mathf.FloorToInt(currentTime));
            }

            if (currentTime <= 0)
            {
                currentTime = 0;
            }
        }
        
    }

    public void AddMonetka()
    {
        currentTime += 1;
    }

    public void DisplayHighScore()
    {
        loseScreen.transform.GetChild(4).GetComponent<TextMeshProUGUI>().text
            = PlayerPrefs.GetInt("highscore").ToString();
    }
}
