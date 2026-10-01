using UnityEngine;

public class Parralax : MonoBehaviour
{
    public float scrollAmount;
    public Vector3 cameraStartPos;
    public Vector3 startPos;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        startPos = transform.position;
        cameraStartPos = transform.parent.position;
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 cameraMotion = transform.parent.position - cameraStartPos;
        transform.position = startPos + scrollAmount * cameraMotion;
    }
}
