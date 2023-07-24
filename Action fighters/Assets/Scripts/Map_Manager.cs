using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.TextCore.Text;

public class Map_Manager : MonoBehaviour
{
    public SpriteRenderer sr3;
    public static int SelectedMap = 0;
    public List<Sprite> Maps = new List<Sprite>();
    // Start is called before the first frame update


    public void NextOption()
    {
        SelectedMap = SelectedMap + 1;
        if (SelectedMap == Maps.Count)
        {
            SelectedMap = 0;
        }
        sr3.sprite = Maps[SelectedMap];
    }


    public void BackOption()
    {
        SelectedMap = SelectedMap - 1;
        if (SelectedMap < 0)
        {
            SelectedMap = Maps.Count - 1;
        }
        sr3.sprite = Maps[SelectedMap];
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
