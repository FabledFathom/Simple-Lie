using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NpcBehavior : MonoBehaviour
{
    private BoxCollider2D bc;

    public bool wantsApple;
    public bool wantsGlove;
    public bool wantsMirror;
    public bool wantsComb;

    // Start is called before the first frame update
    void Awake()
    {
        bc = gameObject.GetComponent<BoxCollider2D>();
    }

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter2D(Collider2D col){
        Debug.Log(col.gameObject.tag);
    }
}
