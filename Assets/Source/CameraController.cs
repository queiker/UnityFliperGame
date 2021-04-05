using UnityEngine;


public class CameraController:MonoBehaviour
{
    public Transform Player;
    public float Speed;
    public Vector3 Offset;

    private void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, Player.position + Offset, Speed * Time.deltaTime);
    }

}
