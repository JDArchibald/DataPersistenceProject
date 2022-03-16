using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour
{
    public TextMeshProUGUI nameInput;
    public Button startButton;
    public Button saveButton;
    public Button loadButton;
    public Button quitButton;

    public void StartGame()
    {
        DataManager.instance.playerName = nameInput.text;
        SceneManager.LoadScene("main");
    }
    public void SaveGame()
    {
        //not implemented
    }
    public void LoadGame()
    {
        //doesn't need to be implemented
    }
    public void QuitGame()
    {
        Application.Quit();
        EditorApplication.ExitPlaymode();
    }
}
