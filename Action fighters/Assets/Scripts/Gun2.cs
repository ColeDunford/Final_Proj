using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gun2 : MonoBehaviour
{
    public GameObject PlasmaPrefab;
    public Transform firePoint;
    public GameObject FireballPrefab;
    private float attackDelay;
    [SerializeField][Range(-5.0f, 5.0f)] float timeBetweenAttacks = 1;

    // Update is called once per frame

    private void Update()
    {
        if (attackDelay > 0f) attackDelay -= Time.deltaTime;


        if (Input.GetKey(KeyCode.DownArrow) && attackDelay <= 0.1f)
        {
            Shoot();
            attackDelay = timeBetweenAttacks;
        }
    }

    void Shoot()
    {
        Instantiate(FireballPrefab, firePoint.position, firePoint.rotation);
    }

}
