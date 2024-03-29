using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseScript : MonoBehaviour
{
    public static bool GamePaused = false;

    public bool Sh = false;

    public GameObject PauseMenuUI;
    public GameObject OptionsMenu;
    //public GameObject DeadPanel2;

    //private AimScript PlayerScr;

    private void Awake()
    {
        //PlayerScr = GetComponent<AimScript>();
    }

    private void Start()
    {
        PauseMenuUI.SetActive(false);
    }
    void Update()
    {

        if (Input.GetKeyDown(KeyCode.P))
        {
            if (GamePaused)
            {

                Resume();
                
            }
            else
            {

                Pause();
                
            }
        }

    }

    public void Resume()
    {
        PauseMenuUI.SetActive(false);
        Time.timeScale = 1;
        GamePaused = false;

        Sh = false;

        FindObjectOfType<AudioManagerG>().Play2("Click");

        //PlayerScr.enabled = true;

    }

    void Pause()
    {
        PauseMenuUI.SetActive(true);
        Time.timeScale = 0;
        GamePaused = true;

        Sh = true;

        FindObjectOfType<AudioManagerG>().Play2("Click");

        //PlayerScr.enabled = false;

    }

    public void Menu()
    {

        Time.timeScale = 1;
        SceneManager.LoadScene("MainMenu");

        FindObjectOfType<AudioManagerG>().Play2("Click");

    }

    public void Options()
    {
        
        OptionsMenu.SetActive(true);

        FindObjectOfType<AudioManagerG>().Play2("Click");

    }

    public void Back()
    {
        OptionsMenu.SetActive(false);

        FindObjectOfType<AudioManagerG>().Play2("Click");
    }
}
