using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FailDownIron : MonoBehaviour
{
    [SerializeField] public float fallspeed = 6f;

    void OnTriggerEnter2D(Collider2D collision)
    {
        Destroy(gameObject);
    }
    void Update()
    {
        if (transform.position.y < -5)// Удаление объекта
        {
            Destroy(gameObject);


        }

        transform.position -= new Vector3(0, fallspeed * Time.deltaTime, 0);
    }
}
