using UnityEngine;

public class PipeMovement : MonoBehaviour
{

    [SerializeField] private float pipeSpeed = 3f;

    void Start()
    {
        Destroy(gameObject, 10f);
    }

    void Update()
    {
        transform.position += Vector3.left * pipeSpeed * Time.deltaTime;
    }
}
