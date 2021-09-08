using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    public void MoveBack()
    {
        transform.Translate(Vector3.back * 0.75f);
    }
}
