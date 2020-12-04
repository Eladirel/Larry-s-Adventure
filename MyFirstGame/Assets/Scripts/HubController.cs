using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HubController : MonoBehaviour
{
    private GameObject[] heartContainers;
    private Image[] heartFills;

    public Transform heartsParent;
    public GameObject heartContainerPrefab;
    private int aux_vidas;

    // Start is called before the first frame update
    void Start()
    {
        heartContainers = new GameObject[6];
        heartFills = new Image[6];
        aux_vidas = HealtManager.instanceHM.vidas;
        InstantiateHeartContainers();
        SetHeartContainers();
    }

    // Update is called once per frame
    void Update()
    {
       if (aux_vidas != HealtManager.instanceHM.vidas)
       {
           SetHeartContainers();
           aux_vidas = HealtManager.instanceHM.vidas;
       }
    }

    //Control de corazones
    void InstantiateHeartContainers()
    {
        for (int i = 0; i < 6; i++)
        {
            GameObject temp = Instantiate(heartContainerPrefab);
            temp.transform.SetParent(heartsParent, false);
            heartContainers[i] = temp;
            heartFills[i] = temp.transform.Find("HeartFill").GetComponent<Image>();
        }
    }

    void SetHeartContainers()
    {
        for (int i = 0; i < heartContainers.Length; i++)
        {
            if (i < HealtManager.instanceHM. vidas)
            {
                heartContainers[i].SetActive(true);
            }
            else
            {
                heartContainers[i].SetActive(false);
            }
        }
    }

}
