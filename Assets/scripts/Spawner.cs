using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
        public GameObject objetASpawner;
        public float tempsRespawn;
        public Transform parent;
        public float compteur;
        // Start is called before the first frame update
        void Start()
        {
            //var newObject = Instantiate(objetASpawner, new Vector2(Random.Range(-1, 1), Random.Range(-1, 1)), Quaternion.identity);
        }

        // Update is called once per frame
        void Update()
        {

            compteur -= Time.deltaTime;
            if (compteur <= 0)
            {
                var hauteur = Random.Range(-4, 1);
                GameObject clone = Instantiate(objetASpawner, parent.position, parent.rotation);
                clone.transform.position = new Vector2(clone.transform.position.x, hauteur);
                //clone.transform.position = Vector2.Lerp(clone.transform.position, parent.position,Time.deltaTime);
                clone.transform.position = clone.transform.position + new Vector3(1, 0, 0);
                compteur = tempsRespawn;
            }

        }
    }
