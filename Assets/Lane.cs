using JetBrains.Annotations;
using UnityEngine;

public class Lane : MonoBehaviour
{
    public GameObject bigCheckoutPrefab;
    public GameObject smallCheckoutPrefab;
    public GameObject selfCheckoutPrefab;
    public GameObject shopper;
    public GameObject parent;
    public bool isFull;
    public bool hasShopper;
    public int type;
    public int LaneNumber;

    
    GameObject checkoutInstance;
    GameObject shopperInstance;
    Vector3 checkoutPosition;
    Vector3 selfCheckoutPosition;
    Vector3 shopperPosition;


    void Start()
    {
        checkoutPosition = new Vector3(parent.transform.position.x + .7f, parent.transform.position.y-1.8f, 0);
        selfCheckoutPosition = new Vector3(parent.transform.position.x + .7f, parent.transform.position.y - 1.2f, 0);
        shopperPosition = new Vector3(parent.transform.position.x + .3f, parent.transform.position.y - .6f, 0);
        
    }
    public void SpawnCheckout(int type)
    {
        switch (type) {
            case 0: checkoutInstance = Instantiate(bigCheckoutPrefab);  
                    break;
            case 1: checkoutInstance = Instantiate(smallCheckoutPrefab);  
                    break;
            case 2: checkoutInstance = Instantiate(selfCheckoutPrefab);  
                    break;
        }
        if (type == 2)
        {
            checkoutInstance.transform.position = selfCheckoutPosition;
        }
        else {
            checkoutInstance.transform.position = checkoutPosition;
        }
        isFull = true;
    }

    public void SpawnShopper(int itemNum)
    {
        shopperInstance = Instantiate(shopper);
        shopperInstance.transform.position = shopperPosition;
        shopperInstance.GetComponent<ShopperController>().InstantiateItems();
        shopperInstance.GetComponent<ShopperController>().createItems(itemNum);
        hasShopper = true;
    }
}
