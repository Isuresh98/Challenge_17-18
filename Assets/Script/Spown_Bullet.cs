using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spown_Bullet : MonoBehaviour
{
    [SerializeField] GameObject _bulatPrefabs;
    [SerializeField] GameObject[] _spownPoint;

    [SerializeField] float min, max;
    int randomIndex;

    // Start is called before the first frame update
    void Start()
    {
        Invoke("Instansiate", Random.Range(min, max));
    }

    // Update is called once per frame
    void Update()
    {
        randomIndex = Random.Range(0, _spownPoint.Length);
    }

    private void Instansiate()
    {
        Instantiate(_bulatPrefabs, _spownPoint[randomIndex].transform.position, _spownPoint[randomIndex].transform.rotation);
        Invoke("Instansiate", Random.Range(min, max));
        GameObject Bulat = GameObject.FindWithTag("Bulat");
        if(Bulat != null)
        {
            Destroy(Bulat, 3f);
        }
    }

}
