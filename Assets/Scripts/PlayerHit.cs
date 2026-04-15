using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHit : MonoBehaviour
{
    private Rigidbody rb;
    private Move moveScript;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
        moveScript = GetComponent<Move>();
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Obstacle"))
        {
            ChangeColor(collision.gameObject, Color.black);
            GameOver();
            //Transform transform = collision.gameObject.GetComponent<Transform>();
            //transform.localScale = new Vector3(1, 1, 1);
        }
    }

    private void ChangeColor(GameObject gameObject, Color color)
    {
        MeshRenderer meshRenderer = gameObject.GetComponent<MeshRenderer>();
        Material material = meshRenderer.material;
        material.color = color;
    }

    private bool GameOver()
    {
        rb.constraints = RigidbodyConstraints.None;
        rb.useGravity = true;
        moveScript.enabled = false;
        return true;
    }
}
