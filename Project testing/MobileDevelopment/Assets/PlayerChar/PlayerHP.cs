
using UnityEngine;
using TMPro;


public class PlayerHP : MonoBehaviour
{
    [Header("Health txt")]
    public TextMeshProUGUI hitPointDisplay;

    [Header("Health logic")]
    public int hitPoints = 3;
    public bool endState = false;

    void Start()
    {
        hitPoints = 3;
        hitPointUpdate();
    }
    private void hitPointUpdate()
    {
        hitPointDisplay.text = "HP: " + hitPoints;
    }
    void Update()
    {
        hitPointUpdate(); //Update HP display per frame.

        if (hitPoints == 0)
        {
            endState = true;
        }
    }
}
