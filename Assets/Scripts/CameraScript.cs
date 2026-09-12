using UnityEngine;

public class CameraScript : MonoBehaviour
{
    public Transform target;
    public Vector3 offset;

    private void Update()
    {
        transform.position = target.position + target.TransformDirection(offset);
        transform.rotation = Quaternion.LookRotation((target.position- transform.position), target.forward);

        //transform.LookAt(target2);

        //transform.position = target.position;
        //transform.rotation = target.rotation;

    }
}
