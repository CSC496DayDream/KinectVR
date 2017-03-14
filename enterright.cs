using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rightenter : MonoBehaviour
{

    public GameObject rtext;

    private void OnTriggerEnter()
    {
        rtext.SetActive(true);
    }



}
