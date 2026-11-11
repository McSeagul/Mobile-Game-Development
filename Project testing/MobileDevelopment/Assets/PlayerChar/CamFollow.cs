using UnityEngine;

public class CamFollow : MonoBehaviour
{
    //Assisted with use from https://gamedev.stackexchange.com/questions/210612/how-to-make-camera-follow-player-on-y-axis-only

    public Transform FollowTarget;
    //set player as followtarget.


    [Header("Camera Smooth Settings")]
    public float offsetY = 0f;
    public float smoothDampTime = 0.2f;
    float velocity;

    //ensures the character has already began its movement before camera moves
    void LateUpdate()
    {
        var pos = transform.position;

        float targetHeight = Mathf.Max(pos.y, FollowTarget.position.y + offsetY);

        pos.y = Mathf.SmoothDamp(pos.y, targetHeight, ref velocity, smoothDampTime);

        transform.position = pos;

        
    }
}
