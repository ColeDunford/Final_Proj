using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class music : MonoBehaviour
{
    

    // Start is called before the first frame update
    void Start()
    {
        
    }

    void Awake()
    {
        music[] objs = FindObjectsOfType<music>();

        if (objs.Length > 1)
        {
            Destroy(this.gameObject);
        }

        DontDestroyOnLoad(this.gameObject);
       
    }

private void Update()
        {
            if (SceneManager.GetActiveScene().name == "Character select") this.GetComponent<AudioSource>().enabled = false;
            else if (SceneManager.GetActiveScene().name == "MainMenu") this.GetComponent<AudioSource>().enabled = true;
        }

   
}
