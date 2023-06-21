using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Player2_Health : MonoBehaviour
{
    //public GameObject Player2;
    public Player_Controller Player_Controller;
    public Image Healthbar2;
    public float Healthamount;

    // Start is called before the first frame update
    void Start()
    {
        Player_Controller  = GameObject.FindWithTag("Player").GetComponentInChildren<Player_Controller>();
    }


    private void Awake()
    {
       
    }
    // Update is called once per frame
    void Update()
    {


        // Damage
        if (Input.GetKeyDown(KeyCode.G))
        {
            takeDamage(20);
        }

    }

    public void takeDamage(float Damage)
    {
        Healthamount -= Damage;

        // player 2 health
        Healthbar2.fillAmount = Healthamount / 100f;

        if (Healthamount <= 0)
        {
            SceneManager.LoadScene("SampleScene");


        }
    }
}
