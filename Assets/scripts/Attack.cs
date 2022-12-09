using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Attack : MonoBehaviour
{
    public GameObject player;
    public int countdown = 0;
   
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Debug.DrawRay(player.transform.position, player.transform.right * 5f);
    }
    public void OnTouch()
    {
        if(Physics.Raycast(player.transform.position,player.transform.right, out var other,5f))
        {
            countdown = countdown + 1;
            if (countdown >= 2)
            {
                Debug.Log("AH");
                Destroy(other.transform.gameObject);
            }
        }
    }

}
