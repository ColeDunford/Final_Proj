using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadScene : MonoBehaviour
{
    public void _LoadScene()
    {
        Round_Manager.Reset();
        SceneManager.LoadScene("SampleScene");
    }
}
