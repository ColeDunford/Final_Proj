using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class Player1_Health : MonoBehaviour
{

    public Player2 player2;
    public Image Healthbar;
    public float Healthamount;
    public Animator Anim;
    public GameObject End2MenuGuI;



    // Start is called before the first frame update
    void Start()
    {

    }

    public void Home()
    {
        SceneManager.LoadScene("MainMenu");
    }

    public void Characterselect()
    {
        SceneManager.LoadScene("Character select");
    }


    private void Awake()
    {
        Time.timeScale = 1f;
        player2 = FindObjectOfType<Player2>();

    }
    // Update is called once per frame
    void Update()
    {



    }

    IEnumerator TakingDamage2()
    {
        yield return new WaitForSeconds(0.3f);
        FindObjectOfType<Player1>().isTakingDamage1 = true;
        Anim.SetTrigger("Damage");
        Anim.SetBool("isTakingDamage1", true);
        yield return new WaitForSeconds(0.3f);
        Anim.SetBool("isTakingDamage1", false);
        FindObjectOfType<Player1>().isTakingDamage1 = false;
    }

    public void takeDamage(float Damage)
    {
        Healthamount -= Damage;

        StartCoroutine(TakingDamage2());

        Healthbar.fillAmount = Healthamount / 100f;

        if (Healthamount <= 0)
        {
            if (Round_Manager.currentRound == 0)
            {
                Round_Manager.wonRound1 = "P2";
            }
            if (Round_Manager.currentRound == 1)
            {
                Round_Manager.wonRound2 = "P2";

                if (FindObjectOfType<Round_Manager>().p2_Won1.activeInHierarchy && FindObjectOfType<Round_Manager>().p2_Won2.activeInHierarchy)
                {
                    End2MenuGuI.SetActive(true);
                    Time.timeScale = 0f;
                }
            }
            if (Round_Manager.currentRound == 2)
            {
                Round_Manager.wonRound3 = "P2";
            }

            if (Round_Manager.currentRound == 2)
            {
                if (FindObjectOfType<Round_Manager>().p2_Won1.activeInHierarchy && FindObjectOfType<Round_Manager>().p2_Won2.activeInHierarchy)
                {
                    End2MenuGuI.SetActive(true);
                    Time.timeScale = 0f;
                }
            }
            else
            {
                Round_Manager.currentRound += 1;
                SceneManager.LoadScene(SceneManager.GetActiveScene().name);
            }
           

        }
    }
}
