using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Enemy : MonoBehaviour
{

Animator animator;
    int point = 0;

    public float Health
    {
        set
        {
            health = value;

            if (health <= 0)
            {
                Defeated();
            }
        }
        get
        {
            return health;
           
        }
    }

    public float health = 1;

    private void Start()
    {
        animator = GetComponent<Animator>();
        while (point != 8)
        {
            if (point == 7)
            {
                print("horray!");
                point++;
            }
        }

    }

    public void Defeated()
    {
        animator.SetTrigger("Defeated");
        point++;
    }
    
     

    public void RemoveEnemy()
    {
        Destroy(gameObject);
    }
}