using UnityEngine;

public class MouseFollow : MonoBehaviour
{
    private void Start()
    {
    }

    private void Update()
    {
        Vector3 point = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        transform.position = new Vector3(point.x, point.y, transform.position.z);
    }
}
