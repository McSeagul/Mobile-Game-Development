using UnityEngine;
using TMPro;

public class LevelTimeCarryover : MonoBehaviour
{
    public TextMeshProUGUI LvlTime;
    public TextMeshProUGUI HighscoreText;
    public TextMeshProUGUI B;
    public TextMeshProUGUI A;
    public TextMeshProUGUI S;
    public TextMeshProUGUI RankTxt;
    public TextMeshProUGUI levelName;
    public int RankLevel;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
       

        
        B.text = "Time to beat :" + PlayerPrefs.GetFloat("BRank");
        A.text = "Time to beat :" + PlayerPrefs.GetFloat("ARank");
        S.text = "Time to beat :" + PlayerPrefs.GetFloat("SRank") + "" +
            " And all coins collected";
        if (PlayerPrefs.GetFloat("Time") < PlayerPrefs.GetFloat("BRank") && PlayerPrefs.GetFloat("Time") < PlayerPrefs.GetFloat("ARank") && PlayerPrefs.GetFloat("Time") <= PlayerPrefs.GetFloat("SRank"))
        {
            if (PlayerPrefs.GetFloat("Score") == PlayerPrefs.GetInt("CoinsNeeded"))
            {
                RankTxt.text = "Rank : S";
                RankLevel = 1;
            }
            else
            {
                RankTxt.text = "Rank : A";
                RankLevel = 2;
            }
            
        }
        else if (PlayerPrefs.GetFloat("Time") <= PlayerPrefs.GetFloat("BRank") && PlayerPrefs.GetFloat("Time") > PlayerPrefs.GetFloat("ARank") && PlayerPrefs.GetFloat("Time") > PlayerPrefs.GetFloat("SRank") && PlayerPrefs.GetInt("CoinsNeeded") >= PlayerPrefs.GetFloat("Score"))
        {
            RankTxt.text = "Rank : B";
            RankLevel = 3;
        }
        else if (PlayerPrefs.GetFloat("Time") > PlayerPrefs.GetFloat("BRank") && PlayerPrefs.GetFloat("Time") > PlayerPrefs.GetFloat("ARank") && PlayerPrefs.GetFloat("Time") > PlayerPrefs.GetFloat("SRank") && PlayerPrefs.GetInt("CoinsNeeded") >= PlayerPrefs.GetFloat("Score"))
        {
            RankTxt.text = "Rank : C";
            RankLevel = 4;
        }
        if (PlayerPrefs.GetInt("PrevLvl") == 1)
        {
            levelName.text = "Tutorial";
        }
        else if (PlayerPrefs.GetInt("PrevLvl") == 2)
        {
            levelName.text = "Level 1";
        }
        else
        {

        }
        LvlTime.text = "Time : " + PlayerPrefs.GetFloat("Time").ToString("F1");
        if (PlayerPrefs.GetInt("PrevLvl") == 2)
        {
            if (PlayerPrefs.GetFloat("Time") < PlayerPrefs.GetFloat("Lvl2Hs"))
            {
                PlayerPrefs.SetFloat("Lvl2Hs", PlayerPrefs.GetFloat("Time"));
                HighscoreText.gameObject.SetActive(true);
            }
            else
            {
                HighscoreText.gameObject.SetActive(false);
            }

            if (PlayerPrefs.GetInt("RankHS2") == 0 || RankLevel <= PlayerPrefs.GetInt("RankHS2"))
            {
                PlayerPrefs.SetInt("RankHS2", RankLevel);
            } else
            {

            }
        }
        if (PlayerPrefs.GetInt("PrevLvl") == 1)
        {
            if (PlayerPrefs.GetFloat("Time") < PlayerPrefs.GetFloat("Lvl1Hs"))
            {
                PlayerPrefs.SetFloat("Lvl1Hs", PlayerPrefs.GetFloat("Time"));
                HighscoreText.gameObject.SetActive(true);
            }
            else
            {
                HighscoreText.gameObject.SetActive(false);
            }

            if (PlayerPrefs.GetInt("RankHS1") == 0 || RankLevel <= PlayerPrefs.GetInt("RankHS1"))
            {
                PlayerPrefs.SetInt("RankHS1", RankLevel);
            } else
            {

            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
