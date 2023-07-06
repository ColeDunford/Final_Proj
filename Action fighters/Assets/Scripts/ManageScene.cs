using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ManageScene : MonoBehaviour
{
    float currentTime = 0f;
    float StartingTime = 99f;

    [SerializeField] Text Countdown;

    private void Start()
    {
        currentTime = StartingTime;
    }

    private void Update()
    {
        currentTime -= 1 * Time.deltaTime;
        Countdown.text = currentTime.ToString ("0");

        if (currentTime <= 30)
        {
            Countdown.color = Color.yellow;
        }

        if (currentTime <= 10)
        {
            Countdown.color = Color.red;
        }

        if (currentTime <= 0)
        {
            currentTime = 0;
            SceneManager.LoadScene("SampleScene");
        }


    }

    void Awake()
    {
        GameObject[] objs = GameObject.FindGameObjectsWithTag("music");

        if (objs.Length > 1)
        {
            Destroy(this.gameObject);
        }

        DontDestroyOnLoad(this.gameObject);
    }

    public void SceneSelect()
    {
        SceneManager.LoadScene("Main_Menu2");
    }

    public void sceneSelect()
    {
        SceneManager.LoadScene("Character select");
    }

    public void Scene_Select()
    {
        SceneManager.LoadScene("SampleScene");
    }


    public void ExitApplication()
    {
        Application.Quit();
    }







}