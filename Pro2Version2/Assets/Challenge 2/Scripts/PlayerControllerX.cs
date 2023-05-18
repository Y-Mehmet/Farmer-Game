using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PlayerControllerX : MonoBehaviour
{
    public GameObject dogPrefab;
    Coroutine test;
    bool isFalse=false;
    void Start()
    {
     
    }
    // Update is called once per frame
    void Update()
    {
        // On spacebar press, send dog
        if (Input.GetKeyDown(KeyCode.Space))
        {
        
        if(isFalse==false)
        {
            DogInstantiate();
            isFalse=true;
            StartCoroutine(TestCorouate());
        }
        
           
        }
    }
    void DogInstantiate(){
        Instantiate(dogPrefab, transform.position, dogPrefab.transform.rotation);
    }

    
        IEnumerator TestCorouate(){
             
     
        
     yield return new WaitForSeconds(2f);
     isFalse=false;


    }
    
}