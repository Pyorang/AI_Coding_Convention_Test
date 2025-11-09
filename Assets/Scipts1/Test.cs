using UnityEngine;

public class Test : MonoBehaviour
{
    private int speed = 3;
    public int t = 445;

    void Update()
    {
        transform.position += movePosition();
        Debug.Log("dfdaf" + speed + t);
    }

    private Vector3 movePosition()
    {
        return Vector3.up * Time.deltaTime * speed /t;
    }
}
