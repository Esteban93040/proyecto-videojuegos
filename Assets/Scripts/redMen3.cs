using UnityEngine;

public class redMen3 : MonoBehaviour
{
    public Transform RedMen03;

    private float amplitude = 1.0f;
    private float frequency = 1.0f;
    private float time = 0.0f;


    void Update()
    {
        MoveRedMen03();
    }

    void MoveRedMen03()
    {
        // Obtener la posición actual del objeto
        time += Time.deltaTime;
        Vector3 newPosition = RedMen03.position;
        newPosition.x = amplitude - Mathf.Cos(1 * Mathf.PI * frequency * time);
        RedMen03.position = newPosition;
    }

}