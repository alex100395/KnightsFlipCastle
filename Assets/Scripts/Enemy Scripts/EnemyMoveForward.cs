using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMoveForward : MonoBehaviour
{
    private Transform target;
    private MoveFoward moveForward;
    private HealthCalculate castle;
    private CoinGen CoinsGen;
    private float distance = 2f;
    public float health = 100;
    public bool enemyCollision = false;
    public bool playerCollision = false;

    void Start()
    {
        target = GameObject.FindGameObjectWithTag("PlayerSpawner").transform;
        castle = GameObject.FindGameObjectWithTag("Castle").GetComponent<HealthCalculate>();
        CoinsGen = GameObject.FindGameObjectWithTag("coins").GetComponent<CoinGen>();

    }
    void Update()
    {
        if (health <= 0)
        {
            Destroy(this.gameObject);
            CoinsGen.Coins += 20;
        }

        if (!enemyCollision && !playerCollision)
        {
            transform.position = Vector2.MoveTowards(transform.position, target.position - new Vector3(-1.7f, 0, 0), 1.1f * Time.deltaTime);
            if (Vector2.Distance(target.position, transform.position) <= distance)
            {
                AtkLoop();
            }
        }
        else if (enemyCollision && (Vector2.Distance(target.position, transform.position) <= distance))
        {
            AtkLoop();
        }
        else if(playerCollision)
        {
            AtkLoop();
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.transform.tag == "Enemy")
        {
            enemyCollision = true;
            repeat();
        }
        else if (collision.transform.tag == "Player")
        {
            moveForward = collision.GetComponent<MoveFoward>();
            playerCollision = true;
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.transform.tag == "Enemy")
        {
            enemyCollision = false;
        }
        else if (collision.transform.tag == "Player")
        {
            playerCollision = false;
            
        }
    }

    public void takeDmg()
    {
        health -= 20 * Time.deltaTime;
    }
    void AtkLoop()
    {
        if (Vector2.Distance(target.position, transform.position) <= distance && !playerCollision)
            castle.TakeDamage();
        else
            AtkPlayer();
    }
    void AtkPlayer()
    {
        if (GetComponent<BoxCollider2D>().isTrigger && moveForward)
        {
            moveForward.takeDmg();
        }
    }
    void repeat()
    {
        if (GetComponent<BoxCollider2D>().isTrigger && !playerCollision)// && enemyCollision)
            transform.position = Vector2.MoveTowards(transform.position, target.position - new Vector3(-1.7f, 0, 0), 1.1f * Time.deltaTime);
    }
}
