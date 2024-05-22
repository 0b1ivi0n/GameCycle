using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube : MonoBehaviour
{
    private Renderer render;

    private Vector3 direction;
    [SerializeField]
    private float speed;

    private void Awake()
    {
        render = GetComponent<Renderer>();
        direction = new Vector3(0.1f, 0, 0.1f);
    }

    private void Update()
    {
        transform.position += direction * speed * Time.deltaTime;
    }

    private void OnMouseEnter()
    { 
        Color randomColor = new Color(
                  Random.Range(0f, 1f),
                  Random.Range(0f, 1f),
                  Random.Range(0f, 1f)
              );

        render.material.color = randomColor;
    }

    private void OnMouseDown()
    {
        Destroy(gameObject);
    }
}
