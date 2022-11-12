using System.Collections;
using System.Collections.Generic;

using UnityEngine;

public class Spawn_Eail : MonoBehaviour
{
    public GameObject fish;
    public GameObject iron;

    void Start()//спавн предметов
    {
        StartCoroutine (Spawn());
    }
    IEnumerator Spawn()
    {


        while (true)
        {
            int value = Random.Range(1, 4);
            float speedspawn = Random.Range(0.4f, 0.8f);
            switch (value)
            {
                case 1:
                    Instantiate(fish, new Vector2(Random.Range(-2.5f, 2.5f), 7f), Quaternion.identity);

                    break;
                case 2:
                    Instantiate(iron, new Vector2(Random.Range(-2.5f, 2.5f), 7f), Quaternion.identity);

                    break;
                case 3:

                    Instantiate(fish, new Vector2(Random.Range(-2.5f, 2.5f), 7f), Quaternion.identity);


                    break;

            }

            yield return new WaitForSeconds(speedspawn);// Время задержки спавна
        }


    }
    


}
