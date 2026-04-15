using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    [SerializeField] float playerSpeed;
    public GameObject player;

    // Start is called before the first frame update
    void Start()
    {
        Welcome();
    }

    // Update is called once per frame
    void Update()
    {
        MovePlayer();
    }

    void Welcome()
    {
        Debug.Log("Welcome!");
        Debug.Log("Move the player with wasd");
    }

    void MovePlayer()
    {
        float valueX = Input.GetAxis("Horizontal") * playerSpeed * Time.deltaTime;
        float valueY = 0f;
        float valueZ = Input.GetAxis("Vertical") * playerSpeed * Time.deltaTime;
        player.transform.Translate(valueX, valueY, valueZ);
    }
}
