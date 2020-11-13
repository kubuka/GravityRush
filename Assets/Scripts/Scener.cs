using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Scener : MonoBehaviour
{
    [SerializeField] public GameObject loseScreen;
	RunScript rs;
	Animator anim;
	[SerializeField] GameObject blackScreen;
	MusicVolume mv;


    private void Start()
    {
		rs = FindObjectOfType<RunScript>();
		anim = GetComponent<Animator>();
		mv = FindObjectOfType<MusicVolume>();
		mv.ded = false;
	}

    private void OnEnable()
    {
		Application.targetFrameRate = 60;
    }
    public void Death()
	{
		loseScreen.SetActive(true);
	}

	public void Retry()
	{
		SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
		//rs.elapsedTime = 0;
	}

	public void LoadRetry()
    {
		anim.SetTrigger("FadeInR");
    }

	public void Menu()
	{
		SceneManager.LoadScene("Menu");
	}

	public void LoadMenu()
    {
		anim.SetTrigger("FadeInM");
    }

	public void StartGame()
	{
		blackScreen.SetActive(true);
		anim.SetTrigger("FadeIn");
		//rs.elapsedTime = 0;
	}

	public void LoadGameScene()
    {
		
		SceneManager.LoadScene(1);
	}

	public void Quit()
    {
		Application.Quit();
    }

	public void inActiveBS()
    {
		blackScreen.SetActive(false);
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
			Application.Quit();
        }
    }
}
