using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CoinGen : MonoBehaviour
{
    public float Coins = 30;
    public Text text;
    // Start is called before the first frame update
    void Start()
    {
        text = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        Coins += 1 * Time.deltaTime;
        text.text = Coins.ToString("f0");
    }
    public void broke()
    {
        text.color = Color.red;
        StartCoroutine(ColorDelay());
    }
    IEnumerator ColorDelay()
    {
        yield return new WaitForSeconds(2f);
        text.color = Color.yellow;
    }
}
