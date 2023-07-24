using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MapPicker : MonoBehaviour
{
   
    public GameObject[] Map;
    // Start is called before the first frame update
    void Start()
    {
        foreach(GameObject map in Map)
        {
            map.SetActive(false);
        }

        Map[Map_Manager.SelectedMap].SetActive(true);
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
