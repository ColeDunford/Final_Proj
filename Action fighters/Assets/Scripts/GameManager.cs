using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject SelectedMap;
    public GameObject Map;
    public GameObject SelectedCharacter;
    public GameObject Player;
    public GameObject SelectedCharacter2;
    public GameObject Player2;
    //public Character_Manager Character_Manager;


    // Start is called before the first frame update
    void Start()
    {
        DontDestroyOnLoad(this.gameObject);
    }


}
