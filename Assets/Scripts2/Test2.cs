using UnityEngine;
using UnityEngine.Rendering;

public class Test2 : MonoBehaviour
{
    private int speed2 = 3;
    public int ten = 19;

    void Update()
    {
        transform.position += movePosition();
    }

    private Vector3 movePosition()
    {
        return Vector3.up * Time.deltaTime * speed2 /ten;
    }
}
