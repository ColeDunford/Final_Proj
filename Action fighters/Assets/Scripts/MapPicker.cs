using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MapPicker : MonoBehaviour
{
    public Map_Manager map_Manager;
    public GameObject[] Map;
    // Start is called before the first frame update
    void Start()
    {
        map_Manager = GameObject.FindWithTag("Map_Manager").GetComponent<Map_Manager>();
        Map[map_Manager.SelectedMap].SetActive(true);
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
