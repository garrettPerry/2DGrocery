using System.Collections;
using UnityEngine;

public class ShopperController : MonoBehaviour
{
    public GameObject Shopper;
    public GameObject item1;
        public GameObject itemOutline1;
    public GameObject item2;
        public GameObject itemOutline2;
    public GameObject item3;
        public GameObject itemOutline3;
    public GameObject item4;
        public GameObject itemOutline4;
    public GameObject item5;
        public GameObject itemOutline5;
    public GameObject item6;
        public GameObject itemOutline6;
    public GameObject item7;
        public GameObject itemOutline7;
    public GameObject item8;
        public GameObject itemOutline8;
    public GameObject item9;
        public GameObject itemOutline9;

    GameObject[] itemList = new GameObject[9];
    GameObject[] outlineList = new GameObject[9];

    void Start()
    {
    }

    public void createItems(int numItems)
    {
        for (int i = 0; i < numItems; i++)
        {
            Color temp = itemList[i].GetComponent<SpriteRenderer>().color;
            temp.a = 1;
            itemList[i].GetComponent<SpriteRenderer>().color = temp;
            outlineList[i].GetComponent<SpriteRenderer>().color = Color.black;
        }
    }
    public void InstantiateItems()
    {
        itemList[0] = item1;
        itemList[1] = item2;
        itemList[2] = item3;
        itemList[3] = item4;
        itemList[4] = item5;
        itemList[5] = item6;
        itemList[6] = item7;
        itemList[7] = item8;
        itemList[8] = item9;

        outlineList[0] = itemOutline1;
        outlineList[1] = itemOutline2;
        outlineList[2] = itemOutline3;
        outlineList[3] = itemOutline4;
        outlineList[4] = itemOutline5;
        outlineList[5] = itemOutline6;
        outlineList[6] = itemOutline7;
        outlineList[7] = itemOutline8;
        outlineList[8] = itemOutline9;        

        for (int i = 0; i < itemList.Length; i++) {
            Color original = itemList[i].GetComponent<SpriteRenderer>().color;
            original.a = 0;
            itemList[i].GetComponent<SpriteRenderer>().color = original;
            outlineList[i].GetComponent<SpriteRenderer>().color = Color.clear;
        }
    }
}
