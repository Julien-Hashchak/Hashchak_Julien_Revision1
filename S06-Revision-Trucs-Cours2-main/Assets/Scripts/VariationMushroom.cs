using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VariationMushroom : MonoBehaviour
{

    [SerializeField] float _distanceMaximale;

    // Start is called before the first frame update
    void Start()
    {
        valeur = Random.value(0f,1f);
        Vector3 nouvellePosition = Vector3.zero;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
