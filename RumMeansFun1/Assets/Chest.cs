using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chest : MonoBehaviour {

    public Sprite[] Sprites;
    public int currentSprite;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnCollisionEnter2D(Collision2D coll)
    {
        if (coll.gameObject.tag == "Player")
        {
            currentSprite++;
            currentSprite %= Sprites.Length;

            this.gameObject.GetComponent<SpriteRenderer>().sprite = Sprites[currentSprite];
        }
    }
}
