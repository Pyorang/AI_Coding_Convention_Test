using UnityEngine;
using UnityEngine.Rendering;

public class Test2 : MonoBehaviour
{
    private int speed2 = 3;

    void Update()
    {
        transform.position += movePosition();
    }

    private Vector3 movePosition()
    {
        return Vector3.up * Time.deltaTime * speed2;
    }
}
