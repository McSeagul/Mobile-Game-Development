using UnityEngine;
using TMPro;
using System.Collections;

public class CollectableSystem : MonoBehaviour
{
    public bool gameRunning;
    public float score;
    public float currentTime;
    public TextMeshProUGUI Scoretext;
    void Start()
    {
        gameRunning = true;
        score = 0;
        StartCoroutine(ScoreSys());
    }
    void Update()
    {
        Scoretext.text = "Coins = " + score;

    }
    IEnumerator ScoreSys()
    {
        while(gameRunning == true)
        {
            yield return new WaitForSeconds(0.1f);
            currentTime += 0.1f;
        }
    }

}
