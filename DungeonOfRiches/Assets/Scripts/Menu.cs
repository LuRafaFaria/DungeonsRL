using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    public GameObject[] OptionGroups = new GameObject[1];
    public int ControlScheme; //0 = WASD 1 = Mouse
    // Start is called before the first frame update
    void Start()
    {
        OptionGroups[2].GetComponentInChildren<Toggle>().isOn = System.Convert.ToBoolean(PlayerPrefs.GetInt("Scheme", 1));
    }
    // Update is called once per frame
    void Update()
    {
        
    }
    public void NewGame() 
    {
        PlayerPrefs.Save();
        SceneManager.LoadScene(1);
    }
    public void OptionsOpen(int group)
    {
        OptionGroups[group].SetActive(true);
    }
    public void OptionsClose(int group)
    {
        OptionGroups[group].SetActive(false);
    }
    public void ExitGame()
    {
        PlayerPrefs.Save();
        Application.Quit();
    }
    
    public void ChangeControlScheme()
    {
        if (OptionGroups[2].activeSelf)
        {
            if (PlayerPrefs.GetInt("Scheme", 0) == 0)
            {
                print("1");
                PlayerPrefs.SetInt("Scheme", 1);
            }
            else
            {
                print("0");
                PlayerPrefs.SetInt("Scheme", 0);
            }
        }
        
    }
}
