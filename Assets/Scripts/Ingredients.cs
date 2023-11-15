using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Keybind : MonoBehaviour
{
    public Transform fallingPoint;
    public GameObject breadPrefab;
    public GameObject steakPrefab;
    public GameObject saladePrefab;
    public GameObject cheesePrefab;
    public List ingr;
    private int layer = -3;
    public List<GameObject> allGameObjects = new List<GameObject>();



    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyDown(KeyCode.Q))
        {
            ingr.ingredients.Add(1);
            layer++;
            GameObject bread = Instantiate(breadPrefab, transform.position, transform.rotation);
            bread.transform.position = new Vector3(0, layer, 0);
            allGameObjects.Add(bread);
        }
        else if (Input.GetKeyDown(KeyCode.W))
        {
            ingr.ingredients.Add(2);
            layer++;
            GameObject steak = Instantiate(steakPrefab, transform.position, transform.rotation);
            steak.transform.position = new Vector3(0, layer, 0);
            allGameObjects.Add(steak);
        }
        else if (Input.GetKeyDown(KeyCode.E))
        {
            ingr.ingredients.Add(3);
            layer++;
            GameObject salade = Instantiate(saladePrefab, transform.position, transform.rotation);
            salade.transform.position = new Vector3(0, layer, 0);
            allGameObjects.Add(salade);
        }
        else if (Input.GetKeyDown(KeyCode.R))
        {
            ingr.ingredients.Add(4);
            layer++;
            GameObject cheese = Instantiate(cheesePrefab, transform.position, transform.rotation);
            cheese.transform.position = new Vector3(0, layer, 0);
            allGameObjects.Add(cheese);
        }
        else if (Input.GetKeyDown(KeyCode.Backspace))
        {
            foreach (GameObject obj in allGameObjects)
            {
                Destroy(obj, 3F);
                layer = -3;
            }

            ingr.ingredients.Clear();
        }
        else if (Input.GetKeyDown(KeyCode.Return))
        {

        }
    }
}
