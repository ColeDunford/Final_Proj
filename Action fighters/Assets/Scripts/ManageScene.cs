using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ManageScene : MonoBehaviour
{
    public void Start()
    {
       
    }

    public void SceneSelect()
    {
        SceneManager.LoadScene("Main_Menu2");
    }

    public void sceneSelect()
    {
        SceneManager.LoadScene("Character select");
    }


    public void ExitApplication()
    {
        Application.Quit();
    }
}