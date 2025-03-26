using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PoolManager : MonoBehaviour
{

    public GameObject[] prefabs;

    List<GameObject>[] pools;

    private void Awake() 
    {
        pools = new List<GameObject>[prefabs.Length];

        for(int i = 0; i < pools.Length; i++) 
        {
            pools[i] = new List<GameObject>();
        }
    }
    public GameObject Get(int index)
    {
        GameObject select = null;

        for(int i = 0; i < pools[index].Count;i++)
        {
            if (!pools[index][i].activeSelf)
            {
                select = pools[index][i];
                select.SetActive(true);
                return select;
            }
        }

        select = Object.Instantiate(prefabs[index], transform);
        pools[index].Add(select);

        return select;
    }
}
