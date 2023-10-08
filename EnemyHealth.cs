using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealth : MonoBehaviour
{
    public float enemyHealth = 100f;
    private Animator enemyanimator;

    void Start()
    {
        enemyanimator = GetComponent<Animator>();
    }
    public void DeductHealth(float deductHealth)
    {
        enemyHealth -= deductHealth;

        if (enemyHealth <= 0)
        {
            EnemyDead();
        }
    }
    void EnemyDead()
    {
        enemyanimator.SetBool("enemydead", true);
        Destroy(gameObject, 10f);
    }
}