using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class InGameMenu : MonoBehaviour
{
    public bool GamePaused;
    public GameObject PauseMenu;
    // Start is called before the first frame update
    void Start()
    {
        GamePaused = false;
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape) && !GamePaused)
        {
            Pause();
        }
        else if (Input.GetKeyDown(KeyCode.Escape) && GamePaused)
        {
            Unpause();
        }

    }
    public void Pause()
    {
        PauseMenu.SetActive(true);
        Time.timeScale = 0f;
        GamePaused = true;
    }
    public void Unpause()
    {
        PauseMenu.SetActive(false);
        Time.timeScale = 1f;
        GamePaused = false;
    }
    public void ExitScene()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene(0);
    }
}
