using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character_Picker : MonoBehaviour
{
    public Character_Manager character_Manager;
    public Map_Manager map_Manager;
    public GameObject[] Map;
    public GameObject[] fighters;
    public bool isPlayer1;
    //public bool IsMap;

    // Start is called before the first frame update
    void Start()
    {
        character_Manager = GameObject.FindWithTag("Character_Manager").GetComponent<Character_Manager>();
        if (isPlayer1)
        {
            fighters[character_Manager.SelectedCharacter].SetActive(true);
        }
        else
        {
            fighters[character_Manager.SelectedCharacter2].SetActive(true);
        }


        map_Manager = GameObject.FindWithTag("Map_Manager").GetComponent<Map_Manager>();
        //if(IsMap)
        //{
            Map[map_Manager.SelectedMap].SetActive(true);
        //}
        
        

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
