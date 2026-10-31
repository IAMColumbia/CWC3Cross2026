using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject obstaclePrefab;
    private Vector3 spawnPos = new Vector3(35, 0, 0);
    private float startDelay = 2;
    private float repeatRate = 2;
    private PlayerController controller;


    void Start()
    {
        InvokeRepeating("SpawnObstacle", startDelay, repeatRate);
        controller = GameObject.Find("Player").GetComponent<PlayerController>();
    }

    void Update()
    {

    }

    void SpawnObstacle()
    {
        if (!controller.GameOver)
        {
            Instantiate(obstaclePrefab, spawnPos, obstaclePrefab.transform.rotation);
        }

    }
}