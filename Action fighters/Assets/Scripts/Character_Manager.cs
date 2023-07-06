using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using UnityEngine.SceneManagement;

public class Character_Manager : MonoBehaviour
{
    public SpriteRenderer sr;
    public SpriteRenderer sr2;
    public List<Sprite> Characters = new List<Sprite>();
    public List<Sprite> Characters2 = new List<Sprite>();
    public int SelectedCharacter = 0;
    public int SelectedCharacter2 = 0;
    public GameObject PlayerCharacter;
    [SerializeField] private GameObject Venessa1;
    public GameObject activeGameObject;


    public void Start()
    {
        DontDestroyOnLoad(this.gameObject);
    }

    public void NextOption()
    {
        SelectedCharacter = SelectedCharacter + 1;
        if (SelectedCharacter == Characters.Count)
        {
            SelectedCharacter = 0;
        }
        sr.sprite = Characters[SelectedCharacter];
    }


    public void BackOption()
    {
        SelectedCharacter = SelectedCharacter - 1;
        if (SelectedCharacter < 0)
        {
            SelectedCharacter = Characters.Count - 1;
        }
        sr.sprite = Characters[SelectedCharacter];
    }

    public void NextOption2()
    {
        SelectedCharacter2  = SelectedCharacter2 + 1;
        if (SelectedCharacter2 == Characters2.Count)
        {
            SelectedCharacter2 = 0;
        }
        sr2.sprite = Characters2[SelectedCharacter2];
    }


    public void BackOption2()
    {
        SelectedCharacter2 = SelectedCharacter2 - 1;
        if (SelectedCharacter2 < 0)
        {
            SelectedCharacter2 = Characters2.Count - 1;
        }
        sr2.sprite = Characters2[SelectedCharacter2];
    }

    public void PlayGame()
    {
        SceneManager.LoadScene("SampleScene");

    }
}


