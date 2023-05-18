using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Button : MonoBehaviour
{
    [SerializeField] private int _numberScene;

    [SerializeField] private GameObject Panel;
    
    public void Play()
    {
        SceneManager.LoadScene(_numberScene);
    }
    public void SettingsOpen()
    {
        Panel.SetActive(true);
    }
    public void SettingsExit()
    {
        Panel.SetActive(true);
    }
    public void ExitGame()
    {
        Application.Quit();
    }


}
