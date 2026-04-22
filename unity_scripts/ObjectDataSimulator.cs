using UnityEngine;

public class ObjectDataSimulator : MonoBehaviour
{
    void Update()
    {
        Vector3 pos = transform.position;
        Quaternion rot = transform.rotation;

        Debug.Log("Position: " + pos.ToString());
        Debug.Log("Rotation: " + rot.eulerAngles.ToString());
    }
}
