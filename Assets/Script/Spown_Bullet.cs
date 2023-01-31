using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spown_Bullet : MonoBehaviour
{
    [SerializeField] GameObject _bulatPrefabs;
    [SerializeField] GameObject[] _spowPoint;
    [SerializeField] float minInterval, maxInterval;
    int randomIndex;


    // Start is called before the first frame update
    void Start()
    {
        Invoke("InstantiateObject", Random.Range(minInterval, maxInterval));
    }

    // Update is called once per frame
    void Update()
    {
        randomIndex = Random.Range(0, _spowPoint.Length);

       
    }

    void InstantiateObject()
    {
        Instantiate(_bulatPrefabs, _spowPoint[randomIndex].transform.position, _spowPoint[randomIndex].transform.rotation);

        Invoke("InstantiateObject", Random.Range(minInterval, maxInterval));
        GameObject bulat = GameObject.FindWithTag("Bulat");
        if (bulat != null)
        {
            Destroy(bulat, 3f);
        }

    }
}
