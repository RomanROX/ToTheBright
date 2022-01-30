using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ButtonManager : MonoBehaviour
{
    public bool gameIsPaused = false;
    public GameObject pauseMenu;


    public void Start()
    {
        //gameIsPaused = false;
        //pauseMenu.SetActive(false);
        //Time.timeScale = 1;
    }
    // HOME BUTTON
    public void Home()
    {
        SceneManager.LoadScene("MainMenu");
    }
    // EXIT BUTTON
    public void Exit()
    {
        Application.Quit();
    }
    // PAUSE INPUT
    //private void Update()
    //{
    //   if (Input.GetKey(KeyCode.Escape))
    //    {
    //        if (gameIsPaused == false)
    //        {
    //            Time.timeScale = 0;
    //            pauseMenu.SetActive(true);
    //        }
    //        else if (gameIsPaused == true)
    //        {
    //            pauseMenu.SetActive(false);
    //        }
    //    }
    //}
    //// UNPAUSE BUTTON
    //public void Unpause()
    //{
    //    pauseMenu.SetActive(false);
    //    Time.timeScale = 1;
    //}
    // OPTIONS BUTTON
    public void Options()
    {
        SceneManager.LoadScene("OptionsScene");
    }
}
