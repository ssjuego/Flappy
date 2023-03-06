using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuScript : MonoBehaviour
{
    public void LoadingSS()
    {
        SceneManager.LoadScene("SampleScene");
        
    }

    public void Endgame()
    {
        Debug.Log("Exit");
        Application.Quit();
    }
}
 