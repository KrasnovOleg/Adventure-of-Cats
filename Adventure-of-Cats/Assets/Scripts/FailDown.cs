using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FailDown : MonoBehaviour // Движение и скорость движения
{
    [SerializeField] private float fallspeed = 4f;
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
