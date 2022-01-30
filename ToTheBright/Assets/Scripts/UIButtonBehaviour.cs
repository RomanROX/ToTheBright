using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class UIButtonBehaviour : MonoBehaviour
{
    public void ReturnToMainMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }
    public void RetryLevel()
    {
        SceneManager.LoadScene(GameManager.instance.LastLevelPlayed);
    }
    public void StartGame()
    {
        SceneManager.LoadScene("Level01");
        
        GameManager.instance.LastLevelPlayed = SceneManager.GetActiveScene().ToString();
        GameManager.instance.GetComponent<ItemCollector>().itemNum=0;
        GameManager.instance.itemCounter = 0;
        GameManager.instance.GetComponent<ItemCollector>().CheckAndUpdate();
        GameManager.instance.UpdateCounter();
        GameManager.instance.gameUI.SetActive(true);
    }
    public void QuitGame()
    {
        Application.Quit();
        Debug.Log("quit");
    }
}
