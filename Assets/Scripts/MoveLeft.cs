using UnityEngine;

public class MoveLeft : MonoBehaviour
{
    private float speed = 30;

    private PlayerController controller;

    private void Start()
    {
        controller = GameObject.Find("Player").GetComponent<PlayerController>();
    }

    void Update()
    {
        if (!controller.GameOver)
        {
            transform.Translate(Vector3.left * Time.deltaTime * speed);
        }
    }
}