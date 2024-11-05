using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseEnemy : MonoBehaviour
{
    public float health = 100f;
    public float speed = 3f;
    public float attackDamage = 0f;

    protected float timer = 0f;

    [SerializeField] protected float attackInterval = 1f;

    protected PlayerRPG player;

    // Start is called before the first frame update
    protected virtual void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerRPG>();
    }

    // Update is called once per frame
    protected virtual void Update()
    {
        if (Vector3.Distance(this.transform.position, player.transform.position) < 10)
        {
            timer += Time.deltaTime;

            if (timer >= attackInterval)
            {
                Attack();
                timer = 0f;
            }
        }
      

    }

    protected virtual void Attack()
    {
        player.TakeDamage(attackDamage);
    }

    public virtual void Move()
    {
        
    }

    public virtual void TakeDamage(float damage)
    {
        health -= damage;

        if(health <= 0f)
        {
            Destroy(this.gameObject);
        }
    }
}