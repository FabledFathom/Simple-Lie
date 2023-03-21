using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemBehavior : MonoBehaviour
{
     private BoxCollider2D bc;
     private SpriteRenderer sr;
    // Start is called before the first frame update
    void Awake()
    {
        bc = gameObject.GetComponent<BoxCollider2D>();
        sr = gameObject.GetComponent<SpriteRenderer>();
    }

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    void OnTriggerEnter2D(Collider2D col){
        if(this.gameObject.name == "Mirror"){
            col.gameObject.GetComponent<PlayerMovement>().hasMirror=true;
            sr.sprite = null;
        }
         if(this.gameObject.name == "Comb"){
            col.gameObject.GetComponent<PlayerMovement>().hasComb=true;
            sr.sprite = null;
        }
         if(this.gameObject.name == "Apple"){
            col.gameObject.GetComponent<PlayerMovement>().hasApple=true;
            sr.sprite = null;
        }
         if(this.gameObject.name == "Glove"){
            col.gameObject.GetComponent<PlayerMovement>().hasGlove=true;
            sr.sprite = null;
        }
    }
}
