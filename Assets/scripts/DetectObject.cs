using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectObject : MonoBehaviour
{

    private GameObject currentTouchedObject;

    void Update()
    {
        if (Input.touchCount > 0)
        {
            
            var tempVector = new Vector3(Input.touches[0].position.x, Input.touches[0].position.y, Camera.main.nearClipPlane);//On recupere la position du doigt
                                                                                                                      
            var tempRay = Camera.main.ScreenPointToRay(tempVector); // On Converti la position du doigt en rayon qui va vers l'avant dans le mondedu jeu
            
            RaycastHit tempHit; //On cr?e un ensemble d'info de raycast 
            
            Physics.Raycast(tempRay.origin, tempRay.direction, out tempHit); //on lance le raycast et on lui dit de remplire les infos avec ce qu'il touche
            
            currentTouchedObject = tempHit.collider.gameObject; //On recupere le game object touch? depuis les infos

            var componentMoveOfGameObject = gameObject.GetComponent<Move>(); //On recupere le component move de l'objet
            /*Debug.Log(currentTouchedObject.GetComponent<Transform>());
            Debug.Log(currentTouchedObject.GetComponent<Move>());
            Debug.Log(currentTouchedObject.GetComponent<SpriteRendrer>());*/
            //var componentAttackOfGameObject = gameObject.GetComponent<Attack>();
            if ( componentMoveOfGameObject != null ) //Si le component move Existe
                
            {
                Debug.Log("Ca marche");
                //Alors on fait des trucs 
                componentMoveOfGameObject.OnTouch();

                
            }
            /*if (componentAttackOfGameObject != null) 
            {
                componentAttackOfGameObject.OnTouch();
                Debug.Log("BBBBBBBBBBBBBBBBBBH");
            }*/

            /*
            var componentOfGameObject = gameObject.GetComponent<MonComponent>(); //On recupere le component move de l'objet
            if (componentOfGameObject != null) //Si le component move Existe
            {
                //Alors on fait des trucs 
                componentOfGameObject.MaFonction();
            }
            */

        }

        else
            
        {
            /// //////////////////////////////
            if (currentTouchedObject != null)
            {
                Debug.Log("BANANAAAAAAAAAAAAAAA8");
                var componentMoveOfGameObject = gameObject.GetComponent<Move>(); //On recupere le component move de l'objet
                Debug.Log("BANANAAAAAAAAAAAAAAA9");
                if (componentMoveOfGameObject != null)

                {
                    Debug.Log("BANANAAAAAAAAAAAAAAA10");
                    componentMoveOfGameObject.TouchUp();
                }
                else{
                    Debug.Log("BANANAAAAAAAAAAAAAAA11");
                    currentTouchedObject = null;
                }
            }

        }
    }
}
