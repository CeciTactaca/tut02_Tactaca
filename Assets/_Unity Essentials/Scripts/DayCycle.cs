using UnityEngine;

public class DayCycle : MonoBehaviour
{
    [Header("Day Settings")]
    [Tooltip("Duration of a full day in seconds")]
    [SerializeField] private float dayDurationInSeconds = 120f;

    private float rotationSpeed;

    void Start()
    {
        // Calculate degrees per second based on full 360° rotation
        rotationSpeed = 360f / dayDurationInSeconds;
    }

    void Update()
    {
        // Rotate around the X-axis to simulate sun movement
        transform.Rotate(Vector3.right * rotationSpeed * Time.deltaTime);
    }
}
