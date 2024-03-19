using UnityEngine;

public class redMen2 : MonoBehaviour
{
    public Transform RedMen; // Assuming the spotlight is attached to this GameObject
    public Light spotLight;

    private float amplitude = 0.5f;
    private float frequency = 1.0f;
    private float time = 0.0f;

    void Update()
    {
        MoveRedMen();
    }

    void MoveRedMen()
    {
        time += Time.deltaTime;
        Vector3 newPosition = RedMen.position;
        newPosition.x = amplitude - Mathf.Cos(1 * Mathf.PI * frequency * time);
        RedMen.position = newPosition;

        // Update spotlight position to follow RedMen
        newPosition.y = 2;
        spotLight.transform.position = newPosition;
    }
}
