using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enter : MonoBehaviour {

public GameObject ctext;

    private void OnTriggerEnter()
    {
        ctext.SetActive(true);
    }

    

}
