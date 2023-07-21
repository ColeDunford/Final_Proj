using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Round_Manager : MonoBehaviour
{
    public static int currentRound;
    public TextMeshProUGUI RoundText;
    public static string wonRound1;
    public static string wonRound2;
    public static string wonRound3;
    public string[] roundResults;
    public GameObject p1_Won1, p1_Won2;
    public GameObject p2_Won1, p2_Won2;
    // Start is called before the first frame update
    public static void Reset()
    {
        currentRound = 0;
        wonRound1 = string.Empty;
        wonRound2 = string.Empty;
        wonRound3 = string.Empty;
    }


    // Update is called once per frame
    void Update()
    {

        RoundText.text = $"Round {currentRound}";

        //roundResults = [wonRound1, wonRound2, wonRound3];

        if (wonRound1.Contains("P1"))
        {
            p1_Won1.SetActive(true);
        }
        else
        {
            p1_Won1.SetActive(false);
        }

        if (wonRound1.Contains("P2"))
        {
            p2_Won1.SetActive(true);
        }
        else
        {
            p2_Won1.SetActive(false);
        }

        if (wonRound2.Contains("P1"))
        {
            p1_Won2.SetActive(true);
        }
        else
        {
            p1_Won2.SetActive(false);
        }

        if (wonRound2.Contains("P2"))
        {
            p2_Won2.SetActive(true);
        }
        else
        {
            p2_Won2.SetActive(false);
        }

        if (wonRound3.Contains("P1"))
        {
            if (!p1_Won2.activeInHierarchy) p1_Won2.SetActive(true);
            else if (!p1_Won1.activeInHierarchy) p1_Won1.SetActive(true);
        }
        else if (wonRound3.Contains("P2"))
        {
            if (!p2_Won2.activeInHierarchy) p2_Won2.SetActive(true);
            else if (!p2_Won1.activeInHierarchy) p2_Won1.SetActive(true);
        }
    }
}
