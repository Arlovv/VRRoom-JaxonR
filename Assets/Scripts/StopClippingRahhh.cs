using UnityEngine;

public class StopClippingRahhh : MonoBehaviour
{
    private float yPosition = 1f;

    // Update is called once per frame
    void Update()
    {
        // Ensure Y position remains at 1
        transform.position = new Vector3(transform.position.x, yPosition, transform.position.z);
    }
}
