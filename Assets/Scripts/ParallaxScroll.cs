using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParallaxScroll : MonoBehaviour {

    public GameObject[] layers;

    public float speedParallax = 0.5f;
    int counter = 0;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        //Debug.Log("hallo");
        for (int i = 0; i < layers.Length; i++) {
            if (layers[i].transform.GetChild(layers[i].transform.childCount - 1).transform.position.x > 20 && i != 2) {
                layers[i].transform.GetChild(layers[i].transform.childCount - 1).transform.SetAsFirstSibling();
                layers[i].transform.GetChild(0).transform.localPosition = 
                    new Vector3(layers[i].transform.GetChild(1).transform.localPosition.x - (layers[i].transform.GetChild(2).transform.localPosition.x - layers[i].transform.GetChild(1).transform.localPosition.x), 
                    layers[i].transform.GetChild(1).transform.localPosition.y, layers[i].transform.GetChild(1).transform.localPosition.z);
            } else if (layers[i].transform.GetChild(layers[i].transform.childCount - 1).transform.position.x > 70 && i == 2){

                //layers[i].transform.GetChild(layers[i].transform.childCount - 1).transform.SetAsFirstSibling();
                layers[i].transform.position = new Vector3(-30,layers[i].transform.position.y, layers[i].transform.position.z);

            }
            layers[i].transform.Translate(new Vector3(speedParallax * (i*1.3f + 1f) / 2.0f, 0, 0) ); 
            //Debug.Log(layers[i].transform.position);
        }
	}
}
