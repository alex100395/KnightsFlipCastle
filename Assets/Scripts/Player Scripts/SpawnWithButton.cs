using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SpawnWithButton : MonoBehaviour
{
    public List<Button> Buttons;
    public List<GameObject> Troopers;
    public int temp;
    public CoinGen CoinsGen;
    bool isRunning = false;

    public void Trooper1()
    {
        if (!isRunning && CoinsGen.Coins >= 10)
        {
            StartCoroutine(SpawnTimer(0, 1.5f));
            CoinsGen.Coins -= 10;
        }
        else if (CoinsGen.Coins < 10)
        {
            CoinsGen.broke();//change color coins to red
        }
    }
    public void Trooper2()
    {
        if (!isRunning && CoinsGen.Coins >= 15)
        {
            StartCoroutine(SpawnTimer(1, 2));
            CoinsGen.Coins -= 15;
        }
        else if (CoinsGen.Coins < 15)
        {
            CoinsGen.broke();//change color coins to red
        }
    }
    public void Trooper3()
    {
        if (!isRunning && CoinsGen.Coins >= 20)
        {
            StartCoroutine(SpawnTimer(2, 4));
            CoinsGen.Coins -= 20;
        }
        else if (CoinsGen.Coins < 20)
        {
            CoinsGen.broke();//change color coins to red
        }
    }
    public void Trooper4()
    {
        if (!isRunning && CoinsGen.Coins >= 30)
        {
            StartCoroutine(SpawnTimer(3, 3.5f));
            CoinsGen.Coins -= 30;
        }
        else if (CoinsGen.Coins < 30)
        {
            CoinsGen.broke();//change color coins to red
        }
    }
    public void Trooper5()
    {
        if (!isRunning && CoinsGen.Coins >= 20)
        {
            StartCoroutine(SpawnTimer(4, 2));
            CoinsGen.Coins -= 20;
        }
        else if (CoinsGen.Coins < 20)
        {
            CoinsGen.broke();//change color coins to red
        }
    }
    public void Trooper6()
    {
        if (!isRunning && CoinsGen.Coins >= 15)
        {
            StartCoroutine(SpawnTimer(5, 2));
            CoinsGen.Coins -= 15;
        }
        else if (CoinsGen.Coins < 15)
        {
            CoinsGen.broke();//change color coins to red
        }
    }
    public void Trooper7()
    {
        if (!isRunning && CoinsGen.Coins >= 25)
        {
            StartCoroutine(SpawnTimer(6, 2));
            CoinsGen.Coins -= 25;
        }
        else if (CoinsGen.Coins < 25)
        {
            CoinsGen.broke();//change color coins to red
        }
    }
    public void Trooper8()
    {
        if (!isRunning && CoinsGen.Coins >= 20)
        {
            StartCoroutine(SpawnTimer(7, 2));
            CoinsGen.Coins -= 20;
        }
        else if (CoinsGen.Coins < 20)
        {
            CoinsGen.broke();//change color coins to red
        }
    }
    public void Trooper9()
    {
        if (!isRunning && CoinsGen.Coins >= 60)
        {
            StartCoroutine(SpawnTimer(8, 4));
            CoinsGen.Coins -= 60;
        }
        else if (CoinsGen.Coins < 60)
        {
            CoinsGen.broke();//change color coins to red
        }
    }
    public void Trooper10()
    {
        if (!isRunning && CoinsGen.Coins >= 20)
        {
            StartCoroutine(SpawnTimer(9, 2));
            CoinsGen.Coins -= 20;
        }
        else if (CoinsGen.Coins < 20)
        {
            CoinsGen.broke();//change color coins to red
        }
    }
    public void Trooper11()
    {
        if (!isRunning && CoinsGen.Coins >= 50)
        {
            StartCoroutine(SpawnTimer(10, 2.5f));
            CoinsGen.Coins -= 50;
        }
        else if (CoinsGen.Coins < 50)
        {
            CoinsGen.broke();//change color coins to red
        }
    }
    public void Trooper12()
    {
        if (!isRunning && CoinsGen.Coins >= 70)
        {
            StartCoroutine(SpawnTimer(11, 4));
            CoinsGen.Coins -= 70;
        }
        else if (CoinsGen.Coins < 70)
        {
            CoinsGen.broke();//change color coins to red
        }
    }
    public void Trooper13()
    {
        if (!isRunning && CoinsGen.Coins >= 60)
        {
            StartCoroutine(SpawnTimer(12, 3.5f));
            CoinsGen.Coins -= 60;
        }
        else if (CoinsGen.Coins < 60)
        {
            CoinsGen.broke();//change color coins to red
        }
    }
    public void Trooper14()
    {
        if (!isRunning && CoinsGen.Coins >= 85)
        {
            StartCoroutine(SpawnTimer(13, 5));
            CoinsGen.Coins -= 85;
        }
        else if (CoinsGen.Coins < 85)
        {
            CoinsGen.broke();//change color coins to red
        }
    }
    public void Trooper15()
    {
        if (!isRunning && CoinsGen.Coins >= 120)
        {
            StartCoroutine(SpawnTimer(14, 7));
            CoinsGen.Coins -= 120;
        }
        else if (CoinsGen.Coins < 120)
        {
            CoinsGen.broke();//change color coins to red
        }
    }

    public void spawner(int temp)
    {
        Instantiate(Troopers[temp], transform.position, Quaternion.Euler(0, 180, 0));
    }
    IEnumerator SpawnTimer(int num, float time)
    {
        isRunning = true;
        yield return new WaitForSeconds(time);
        spawner(num);
        isRunning = false;
    }
   
}