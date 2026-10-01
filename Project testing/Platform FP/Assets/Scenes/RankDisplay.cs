using UnityEngine;
using TMPro;
public class RankDisplay : MonoBehaviour
{
    public TextMeshProUGUI Tutorial;
    public TextMeshProUGUI Level1;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(PlayerPrefs.GetInt("RankHS1") == 1)
        {
            Tutorial.text = "Rank : S";
        } 
        if(PlayerPrefs.GetInt("RankHS1") == 2)
        {
            Tutorial.text = "Rank : A";
        } 
        if(PlayerPrefs.GetInt("RankHS1") == 3)
        {
            Tutorial.text = "Rank : B";
        }
        if (PlayerPrefs.GetInt("RankHS1") == 4)
        {
            Tutorial.text = "Rank : C";
        }
        if (PlayerPrefs.GetInt("RankHS2") == 1)
        {
            Level1.text = "Rank : S";
        } 
        if(PlayerPrefs.GetInt("RankHS2") == 2)
        {
            Level1.text = "Rank : A";
        } 
        if(PlayerPrefs.GetInt("RankHS2") == 3)
        {
            Level1.text = "Rank : B";
        }
        if (PlayerPrefs.GetInt("RankHS2") == 4)
        {
            Level1.text = "Rank : C";
        }
    }
}
