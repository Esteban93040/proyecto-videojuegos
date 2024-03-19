using UnityEngine;

public class main : MonoBehaviour
{
    public Transform RedMen01;

    private float amplitude = 1.0f;
    private float frequency = 2.0f;
    private float time = 0.0f;


    void Update()
    {
        MoveRedMen01();
    }

    void MoveRedMen01()
    {
        // Obtener la posición actual del objeto
        time += Time.deltaTime;
        Vector3 newPosition = RedMen01.position;
        newPosition.x +=Time.deltaTime * 0.8f;
        newPosition.y = amplitude - Mathf.Cos(1*Mathf.PI*frequency*time);
        RedMen01.position = newPosition;
    }

}
