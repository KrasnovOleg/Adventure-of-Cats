using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Food_Scale : MonoBehaviour
{
    [SerializeField] public Image Food_scale_start;

    [SerializeField] private Sprite[] spriteMassive;

    float Cat_Size = 0f;
   public int Count = 1;

    void OnTriggerEnter2D(Collider2D collision)
    {

        gameObject.transform.localScale = new Vector3(0.24f+ Cat_Size, 0.24f, 0.24f);


        if (collision.gameObject.tag == "Fich")
        {

            Count++;
            Cat_Size += 0.002f;
        }
        if (collision.gameObject.tag == "Iron")
        {
            if(Count>=5)
            {
            Count -=5;
            }
            else
            {
                Count = 0;
            }
            if(Cat_Size>0)
            {
                Cat_Size -= 0.01f;
            }
            else
            {
                Cat_Size = 0;
            }

        }
            Food_scale_start.sprite = spriteMassive[Count];

    }
    
    
}
