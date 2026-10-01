using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelComplete : MonoBehaviour
{
    public CollectableSystem CollectableSystem;
    public int Level;
    public float B;
    public float A;
    public float S;
    public int coins;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.CompareTag("Player"))
        {
            PlayerPrefs.SetInt("PrevLvl", Level);
            PlayerPrefs.SetFloat("Time", CollectableSystem.currentTime);
            PlayerPrefs.SetFloat("Score", CollectableSystem.score);
            PlayerPrefs.SetFloat("BRank", B);
            PlayerPrefs.SetFloat("ARank", A);
            PlayerPrefs.SetFloat("SRank", S);
            PlayerPrefs.SetInt("CoinsNeeded", coins);
            SceneManager.LoadScene("levelComplete");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
