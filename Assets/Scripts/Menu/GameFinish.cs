using System.Collections;
using System.Collections.Generic;
using System.Threading;
using TMPro;
using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameFinish : MonoBehaviour
{

    private HealthCalculate castle;
    private HealthCalculate enemyCastle;
    public TextMeshProUGUI victorious;
    public TextMeshProUGUI defeated;

    // Start is called before the first frame update
    void Start()
    {
        castle = GameObject.FindGameObjectWithTag("Castle").GetComponent<HealthCalculate>();
        enemyCastle = GameObject.FindGameObjectWithTag("EnemyCastle").GetComponent<HealthCalculate>();
    }

    // Update is called once per frame
    void Update()
    {
        if (castle.currentHealth <= 0)
        {
            defeated.enabled = true;
            StartCoroutine(Delay());
        }
        else if(enemyCastle.currentHealth <= 0)
        {
            victorious.enabled = true;
            StartCoroutine(Delay()); 
        }
    }
    IEnumerator Delay()
    {
        Time.timeScale = 0f;
        yield return new WaitForSecondsRealtime(5);
        LoadMenu();
    }
    public void LoadMenu()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("Scenes/Menu");
    }
}
