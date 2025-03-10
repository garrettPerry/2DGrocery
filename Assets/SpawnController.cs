using NUnit.Framework;
using System;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class SpawnController : MonoBehaviour
{
    public List<GameObject> laneList = new List<GameObject>();

    void Start()
    {
        laneList.AddRange(GameObject.FindGameObjectsWithTag("Lane"));

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void SpawnCheckout(int type)
    {
        int firstOpenCheckout = findOpenCheckout();
        if (firstOpenCheckout == -1)
        {
            Debug.Log("full");
        }
        else
        {
            laneList[firstOpenCheckout].GetComponent<Lane>().SpawnCheckout(type);
        }
    }

    int findOpenCheckout()
    {
        for (int i = laneList.Count-1; i > -1; i--)
        {
            if (laneList[i].GetComponent<Lane>().isFull == false)
            {
                return i;
            }
        }
        return -1;
    }

    public void SpawnShopper(int itemNum)
    {
        int openLaneNumber = findOpenLane();
        if (openLaneNumber == -1)
        {
            Debug.Log("No available lanes");
        }
        else
        {
            laneList[openLaneNumber].GetComponent<Lane>().SpawnShopper(itemNum);
        }
    }

    int findOpenLane()
    {
        for (int i = laneList.Count - 1; i > -1; i--)
        {
            if (laneList[i].GetComponent<Lane>().hasShopper == false && laneList[i].GetComponent<Lane>().isFull == true)
            {
                return i;
            }
        }
        return -1;
    }

    
}