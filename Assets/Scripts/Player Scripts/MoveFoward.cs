using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class MoveFoward : MonoBehaviour
{
    private Transform target;
    private HealthCalculate enemyCastle;
    public float health = 100;
    private EnemyMoveForward enemyMoveForward;
    private float distance = 2f;
    public bool playerCollision = false;
    public bool enemyCollision = false;

    void Start()
    {
        target = GameObject.FindGameObjectWithTag("EnemySpawner").transform;
        enemyCastle = GameObject.FindGameObjectWithTag("EnemyCastle").GetComponent<HealthCalculate>();
    }
    void Update()
    {
        if (health <= 0)
        {
            Destroy(this.gameObject);
        }

        if (!playerCollision && !enemyCollision)
        {
            transform.position = Vector2.MoveTowards(transform.position, target.position - new Vector3(1.7f, 0, 0), 1.1f * Time.deltaTime);
            if (Vector2.Distance(target.position, transform.position) <= distance)
            {
                AtkLoop();
            }
        }
        else if (playerCollision && (Vector2.Distance(target.position, transform.position) <= distance))
        {
            AtkLoop();
        }
        else if (enemyCollision)
        {
            AtkLoop();
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.transform.tag == "Player")
        {
            playerCollision = true;
            repeat();
        }
        else if (collision.transform.tag == "Enemy")
        {
            enemyMoveForward = collision.GetComponent<EnemyMoveForward>();
            enemyCollision = true;
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.transform.tag == "Player")
        {
            playerCollision = false;
        }
        else if (collision.transform.tag == "Enemy")
        {
            enemyCollision = false;
        }
    }
    public void takeDmg()
    {
        health -= 20 * Time.deltaTime;
    }
    void AtkLoop()
    {
        if (Vector2.Distance(target.position, transform.position) <= distance && !enemyCollision)
            enemyCastle.TakeDamage();
        else
            AtkEnemy();
    }
    void AtkEnemy()
    {
        if (GetComponent<BoxCollider2D>().isTrigger && enemyMoveForward)
        {
            enemyMoveForward.takeDmg();
        }
    }
    void repeat()
    {
        if (GetComponent<BoxCollider2D>().isTrigger && playerCollision)// && !enemyCollision)
            transform.position = Vector2.MoveTowards(transform.position, target.position - new Vector3(1.7f, 0, 0), 1.1f * Time.deltaTime);
    }
}