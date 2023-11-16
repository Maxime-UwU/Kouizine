using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

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
    public Score score;
    private float layer = -3.5f;
    private float zIndex = 0f;
    private bool similarity = true;
    public List<GameObject> allGameObjects = new List<GameObject>();


    void Throw()
    {

        foreach (GameObject obj in allGameObjects)
        {
            if (obj != null)
            {
                obj.transform.DOMoveX(-15.0f, 0.3f);
                layer = -3.5f;
                zIndex = 0f;
                Destroy(obj, 0.5f);
            }
        }
        ingr.ingredients.Clear();

    }

    void Validate()
    {
        burgerModel.ResetModel();

        foreach (GameObject obj in allGameObjects)
        {
            if (obj != null)
            {
                obj.transform.DOMoveX(15.0f, 0.3f);
                layer = -3.5f;
                zIndex = 0f;
                Destroy(obj, 0.5f);
            }
        }
        ingr.ingredients.Clear();

    }



    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyDown(KeyCode.P))
        {
            ingr.ingredients.Add(1);
            zIndex--;
            layer = layer+0.5f;
            GameObject bread = Instantiate(breadPrefab, transform.position, transform.rotation);
            bread.transform.position = new Vector3(0, layer, zIndex);
            allGameObjects.Add(bread);
        }
        else if (Input.GetKeyDown(KeyCode.Q))
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
        else if (Input.GetKeyDown(KeyCode.O))
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
            Throw();
        }
        else if (Input.GetKeyDown(KeyCode.Return))
        {


            if(burgerModel.model.Count != ingr.ingredients.Count)
            {
                score.DecreaseScore(25);
                Validate();
            }
            else
            {


                for (int i = 0; i < burgerModel.model.Count; i++)
                {


                    if (burgerModel.model[i] != ingr.ingredients[i])
                    {
                        similarity = false;
                        score.DecreaseScore(25);
                        Validate();
                        break;
                    }
                    else
                    {
                        similarity = true;

                    }
                }

                if(similarity == true)
                {
                    score.IncreaseScore(50);
                    Validate();
                }
                else
                {
                    score.DecreaseScore(25);
                    Validate();
                }
            }
        }
    }
}
