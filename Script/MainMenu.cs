using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    //Load Scene
    public void Easy()
    {
        SceneManager.LoadScene("Easy");
    }
    public void Medium()
    {
        SceneManager.LoadScene("Medium");
    }
    public void Hard()
    {
        SceneManager.LoadScene("Hard");
    }
    //Quit Game
    public void Quit()
    {
        Application.Quit();
        Debug.Log("The Player has Quit the game");
    }
    
}