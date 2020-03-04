using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class MenuButton : MonoBehaviour
{
    public GameObject highscoreboard;
    public GameObject Mainmenu;

    public string Name;
    public GameObject Inputfield;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void StartGame()
    {
        SceneManager.LoadScene(1);
        Time.timeScale = 1f;

    }

    public void SaveName()
    {
        name = Inputfield.GetComponent<TextMeshProUGUI>().text;
        PlayerPrefs.SetString("name", name);
    }

    public void ShowLeaderboard()
    {
        highscoreboard.SetActive(true);
        Mainmenu.SetActive(false);
    }

    public void BacktoMain()
    {
        highscoreboard.SetActive(false);
        Mainmenu.SetActive(true);
    }

    public void Exit()
    {
        Application.Quit();
    }
}
