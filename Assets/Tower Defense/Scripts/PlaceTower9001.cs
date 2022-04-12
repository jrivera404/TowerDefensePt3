using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaceTower9001 : MonoBehaviour
{
    public GameObject Tower;
    public Purse purse;

    public GameObject World;

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(new Vector3(Input.mousePosition.x, Input.mousePosition.y, Camera.main.transform.position.z));
            RaycastHit hit;

            if (Physics.Raycast(ray, out hit))
                if (hit.transform.tag == "TowerSpot" && purse.getCoinCount() >= 20)
                {
                    purse.purchaseTower();
                    hit.transform.gameObject.SetActive(false);
                    PlaceTower(hit.transform.position);
                }
                else if (hit.transform.tag == "TowerSpot" && purse.getCoinCount() < 20)
                {
                    Debug.Log("Need 20 gold to buy tower.");
                }
        }

    }

    void PlaceTower(Vector3 position)
    {
        Instantiate(Tower, position, Quaternion.identity, World.transform);
    }
}