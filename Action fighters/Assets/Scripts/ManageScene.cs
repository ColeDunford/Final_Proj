using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using static Unity.Burst.Intrinsics.X86.Avx;
using TMPro;
public class ManageScene : MonoBehaviour
{
    float currentTime = 0f;
    float StartingTime = 99f;
    GameObject player;
    public static bool isPaused = false;
    public GameObject pauseMenuGuI;


    [SerializeField] TextMeshProUGUI Countdown;

    private void Start()
    {
        currentTime = StartingTime;
    }

    private void Update()
    {

        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (isPaused)
            {
                Resume();
            }

            else
            {
                Pause();
            }



        }





        currentTime -= 1 * Time.deltaTime;
        Countdown.text = currentTime.ToString("0");

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

    public void Resume()
    {
        Debug.Log("test");
        pauseMenuGuI.SetActive(false);
        Time.timeScale = 1f;
        isPaused = false;
    }

    void Pause()
    {
        pauseMenuGuI.SetActive(true);
        Time.timeScale = 0f;
        isPaused = true;
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

    public void MainMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }

    public void sceneSelect()
    {
        SceneManager.LoadScene("Character select");

        if (gameObject.CompareTag("Music"))
        {
            gameObject.SetActive(false);
        }

    }
        

    public void Scene_Select()
    {
        Round_Manager.Reset();
        SceneManager.LoadScene("SampleScene");

    }


    public void ExitApplication()
    {
        Application.Quit();
    }







}