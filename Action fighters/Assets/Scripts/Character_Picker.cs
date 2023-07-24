using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character_Picker : MonoBehaviour
{
   
    public Map_Manager map_Manager;
    public GameObject[] Map;
    public GameObject[] fighters;
    public bool isPlayer1;
    //public bool IsMap;

    // Start is called before the first frame update
    void Start()
    {
        
        if (isPlayer1)
        {
            fighters[Character_Manager.SelectedCharacter].SetActive(true);
        }
        else
        {
            fighters[Character_Manager.SelectedCharacter2].SetActive(true);
        }


        
        
        

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
