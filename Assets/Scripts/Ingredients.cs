using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Keybind : MonoBehaviour
{
    public Transform fallingPoint;
    public GameObject breadBPrefab;
    public GameObject breadPrefab;
    public GameObject steakPrefab;
    public GameObject saladePrefab;
    public GameObject cheesePrefab;
    public List ingr;
    public BurgerModel burgerModel;
    private float layer = -3f;
    private float zIndex = 0f;
    private bool similarity = true;
    public List<GameObject> allGameObjects = new List<GameObject>();


    void ResetIngredients()
    {
        Debug.Log("start resetModel");
        burgerModel.ResetModel();
        Debug.Log("finish resetModel");

        foreach (GameObject obj in allGameObjects)
        {
            Destroy(obj);
            layer = -3f;
            zIndex = 0f;
        }
        Debug.Log("added ingredients destroyed");


        ingr.ingredients.Clear();
        Debug.Log("list cleared");

    }

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
            zIndex--;
            layer = layer+0.5f;
            GameObject bread = Instantiate(breadPrefab, transform.position, transform.rotation);
            bread.transform.position = new Vector3(0, layer, zIndex);
            allGameObjects.Add(bread);
        }
        else if (Input.GetKeyDown(KeyCode.T))
        {
            ingr.ingredients.Add(5);
            zIndex--;
            layer = layer + 0.5f;
            GameObject breadB = Instantiate(breadBPrefab, transform.position, transform.rotation);
            breadB.transform.position = new Vector3(0, layer, zIndex);
            allGameObjects.Add(breadB);
        }
        else if (Input.GetKeyDown(KeyCode.W))
        {
            ingr.ingredients.Add(2);
            zIndex--;
            layer = layer + 0.5f;
            GameObject steak = Instantiate(steakPrefab, transform.position, transform.rotation);
            steak.transform.position = new Vector3(0, layer, zIndex);
            allGameObjects.Add(steak);
        }
        else if (Input.GetKeyDown(KeyCode.E))
        {
            ingr.ingredients.Add(3);
            zIndex--;
            layer = layer + 0.5f;
            GameObject salade = Instantiate(saladePrefab, transform.position, transform.rotation);
            salade.transform.position = new Vector3(0, layer, zIndex);
            allGameObjects.Add(salade);
        }
        else if (Input.GetKeyDown(KeyCode.R))
        {
            ingr.ingredients.Add(4);
            zIndex--;
            layer = layer + 0.5f;
            GameObject cheese = Instantiate(cheesePrefab, transform.position, transform.rotation);
            cheese.transform.position = new Vector3(0, layer, zIndex);
            allGameObjects.Add(cheese);
        }
        else if (Input.GetKeyDown(KeyCode.Backspace))
        {
            foreach (GameObject obj in allGameObjects)
            {
                Destroy(obj, 3F);
                layer = -3f;
                zIndex = 0f;
            }

            ingr.ingredients.Clear();
        }
        else if (Input.GetKeyDown(KeyCode.Return))
        {


            if(burgerModel.model.Count != ingr.ingredients.Count)
            {

                Debug.Log("different");
                ResetIngredients();

            }
            else
            {


                for (int i = 0; i < burgerModel.model.Count; i++)
                {


                    if (burgerModel.model[i] != ingr.ingredients[i])
                    {
                        similarity = false;
                        ResetIngredients();
                        break;
                    }
                    else
                    {
                        similarity = true;

                    }
                }

                if(similarity == true)
                {
                    Debug.Log("pass");
                    ResetIngredients();

                }
                else
                {
                    Debug.Log("fuck");
                    ResetIngredients();

                }
            }
        }
    }
}
