using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseScript : MonoBehaviour
{
    public static PauseScript ShareInstance;
    public static bool isNotPause = true;
    
    void Awake()
    {
        ShareInstance = this;
    }


    public void PauseGame()
    {
        Time.timeScale = 0f;
       
       
    }

   public void ResumeGame()
    {
        Time.timeScale = 1f;
       
       
    }
}
