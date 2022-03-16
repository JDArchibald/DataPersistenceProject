using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour
{
    public TMP_InputField nameInput;
    public TextMeshProUGUI nameInputPlaceHolder;
    public Button startButton;
    public Button quitButton;
    private void Awake()
    {
        nameInputPlaceHolder.text = DataManager.instance.scoreObject.playerName;
    }
    public void StartGame()
    {
        string currentName = nameInput.text;
        Debug.Log(string.IsNullOrEmpty(currentName));
        DataManager.instance.playerName = (currentName == string.Empty ? "Player " + Random.Range(0, 100) : currentName);
        SceneManager.LoadScene("main");
    }
    public void QuitGame()
    {
        Application.Quit();
        EditorApplication.ExitPlaymode();
    }
}
