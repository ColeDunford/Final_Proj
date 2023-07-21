using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Player2_Health : MonoBehaviour
{

    public Player1 Player1;
    public Image Healthbar2;
    public float Healthamount;
    public Animator Anim;
    public GameObject End1MenuGuI;



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
        Player1 = GameObject.FindWithTag("Player").GetComponentInChildren<Player1>();

    }
    // Update is called once per frame
    void Update()
    {


       
    }

    IEnumerator TakingDamage()
    {
        yield return new WaitForSeconds(0.3f);
        FindObjectOfType<Player2>().isTakingDamage = true;
        Anim.SetTrigger("Damage2");
        Anim.SetBool("IsTakingDamage", true);
        yield return new WaitForSeconds(0.3f);
        Anim.SetBool("IsTakingDamage", false);
        FindObjectOfType<Player2>().isTakingDamage = false;
    }

    public void takeDamage(float Damage)
    {
        Healthamount -= Damage;

        StartCoroutine(TakingDamage());
    
        Healthbar2.fillAmount = Healthamount / 100f;

        if (Healthamount <= 0)
        {
            if (Round_Manager.currentRound == 0)
            {
                Round_Manager.wonRound1 = "P1";
            }
            if (Round_Manager.currentRound == 1)
            {
                Round_Manager.wonRound2 = "P1";
            }
            if (Round_Manager.currentRound == 2)
            {
                Round_Manager.wonRound3 = "P1";
            }
         

            if (Round_Manager.currentRound == 1)
            {
              if (FindObjectOfType<Round_Manager>().p1_Won1.activeInHierarchy && FindObjectOfType<Round_Manager>().p1_Won2.activeInHierarchy)
                {
                        End1MenuGuI.SetActive(true);
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
