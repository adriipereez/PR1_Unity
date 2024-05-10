using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GeneradorEnemigos : MonoBehaviour
{
    public GameObject prefabEnemic;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("GenerarEnemic", 2,1);
    }
    private void GenerarEnemic()
    {
        GameObject enemic = Instantiate(prefabEnemic);
        enemic.transform.position = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
