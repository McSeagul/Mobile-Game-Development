using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class Level1 : MonoBehaviour
{
    public TextMeshProUGUI LvlAvailable;
    bool lvlOn = false;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
    
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.LeftShift) && Input.GetKeyDown(KeyCode.RightShift))
        {
            lvlOn = true;
        }
        if(Input.GetButtonDown("Fire2"))
        {
            Level();
        }
        if (PlayerPrefs.GetInt("PrevLvl") >= 1)
        {
            lvlOn = true;
        } else if (PlayerPrefs.GetInt("PrevLvl") == 0)
        {
            lvlOn = false;
        }
        if (lvlOn == false)
        {
            LvlAvailable.text = "Level Unavailable";
        }
        if (lvlOn == true)
        {
            LvlAvailable.text = "Press Y or click to begin the first level";
        }

    }
    public void Level()
    {
        if(lvlOn == true)
        {
            SceneManager.LoadScene("Level1");
        }
    }
}
