using TMPro;
using UnityEngine;


public class PlayerHP : MonoBehaviour
{

    public TextMeshProUGUI hitPointDisplay;

    public int hitPoints = 3;
    public bool endState = false;

    private void healthUpdate()
    {
        hitPointDisplay.text = "HP: " + hitPoints;
    }
    void Update()
    {
        if(hitPoints == 0)
        {
            endState = true;
        }
    }
}
