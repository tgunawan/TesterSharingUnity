using UnityEngine;

public class CameraScript : MonoBehaviour
{
    public Transform target;
    public Transform target2;
    public Vector3 offset;

    private void Update()
    {
        //transform.position = target2.TransformDirection(offset);
        //transform.rotation = Quaternion.LookRotation((target.position- transform.position), target.forward);

        //transform.LookAt(target2);

        transform.position = target.position;
        transform.rotation = target2.rotation;

    }
}
