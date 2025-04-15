using System.Collections;
using System.Numerics;
using Unity.Mathematics;
using UnityEngine;

public class PipeSpawner : MonoBehaviour
{

    [SerializeField] private GameObject pipesPrefab;
    [SerializeField] private float pipeSpawnTime = 1.5f;


    void Start()
    {
        StartCoroutine(SpawnPipe());
    }
    private IEnumerator SpawnPipe()
    {
        while (true)
        {
            Instantiate(pipesPrefab, new UnityEngine.Vector3(12f, UnityEngine.Random.Range(-2, 6), 0), quaternion.identity);

            yield return new WaitForSeconds(pipeSpawnTime);
        }
    }

}
