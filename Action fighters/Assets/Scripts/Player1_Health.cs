using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Player1_Health : MonoBehaviour
{
    //public GameObject Player2;
    public Player2 player2;
    public Image Healthbar;
    public float Healthamount;

    // Start is called before the first frame update
    void Start()
    {
       

    }


    private void Awake()
    {
       
    }
    // Update is called once per frame
    void Update()
    {
        player2 = GameObject.FindWithTag("Player2").GetComponentInChildren<Player2>();
    }

    public void takeDamage(float Damage)
    {
        Healthamount -= Damage;

        Healthbar.fillAmount = Healthamount / 100f;

        if (Healthamount <=0 )
        {
            SceneManager.LoadScene("SampleScene");


        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("MeleeATK2"))
        {
            Debug.Log("MINUS 20");
            takeDamage(20);
        }
    }
}
