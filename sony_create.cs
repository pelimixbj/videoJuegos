using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sony_create : MonoBehaviour
{
    public GameObject Sony;
    public float tiempoCreacion = 2f, RangoCreacion = 2f;
    void Start()
    {
        InvokeRepeating("Creando", 0.0f, tiempoCreacion);
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void Creando()
    {

        Vector3 SpawnPosition = new Vector3(0, 0, 0);
        SpawnPosition = this.transform.position + Random.onUnitSphere * RangoCreacion;
        SpawnPosition = new Vector3(SpawnPosition.x, SpawnPosition.y, 0);

        GameObject Sonys = Instantiate(Sony, SpawnPosition, Quaternion.identity);
    }
}