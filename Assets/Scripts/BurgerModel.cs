using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BurgerModel : MonoBehaviour
{
    public GameObject breadBPrefab;
    public GameObject breadPrefab;
    public GameObject steakPrefab;
    public GameObject saladePrefab;
    public GameObject cheesePrefab;
    private float position = -3f;
    private float test = 0f;
    public List<int> burger1 = new List<int>();
    public List<int> burger2 = new List<int>();
    public List<int> burger3 = new List<int>();
    public List<int> burger4 = new List<int>();
    public List<int> burger5 = new List<int>();
    public List<int> burger6 = new List<int>();
    public List<int> burger7 = new List<int>();
    public List<int> burger8 = new List<int>();
    public List<int> model;
    public List<GameObject> modelGameObjects = new List<GameObject>();


    void RandomNumber()
    {
        int randomNumber = Random.Range(1, 9);
        Debug.Log(randomNumber);

        if(randomNumber == 1)
        {
            model = burger1;
        }
        else if(randomNumber == 2)
        {
            model = burger2;
        }
        else if (randomNumber == 3)
        {
            model = burger3;
        }
        else if (randomNumber == 4)
        {
            model = burger4;
        }
        else if (randomNumber == 5)
        {
            model = burger5;
        }
        else if (randomNumber == 6)
        {
            model = burger6;
        }
        else if (randomNumber == 7)
        {
            model = burger7;
        }
        else if (randomNumber == 8)
        {
            model = burger8;
        }


        foreach (int ingredient in model)
        {
            if (ingredient == 1)
            {

                GameObject bread = Instantiate(breadPrefab, transform.position, transform.rotation);
                bread.transform.position = new Vector3(-5, position, test);
                modelGameObjects.Add(bread);
                position = position+0.5f;
                test--;
                Debug.Log("bread");

            }
            if (ingredient == 5)
            {

                GameObject breadB = Instantiate(breadBPrefab, transform.position, transform.rotation);
                breadB.transform.position = new Vector3(-5, position, test);
                modelGameObjects.Add(breadB);
                position = position + 0.5f;
                test--;
                Debug.Log("breadB");

            }
            else if(ingredient == 2)
            {
                GameObject steak = Instantiate(steakPrefab, transform.position, transform.rotation);
                steak.transform.position = new Vector3(-5, position, test);
                modelGameObjects.Add(steak);
                position = position + 0.5f;
                test--;
                Debug.Log("steak");

            }
            else if (ingredient == 3)
            {
                GameObject salade = Instantiate(saladePrefab, transform.position, transform.rotation);
                salade.transform.position = new Vector3(-5, position, test);
                modelGameObjects.Add(salade);
                position = position + 0.5f;
                test--;
                Debug.Log("salade");

            }
            else if (ingredient == 4)
            {
                GameObject cheese = Instantiate(cheesePrefab, transform.position, transform.rotation);
                cheese.transform.position = new Vector3(-5, position, test);
                modelGameObjects.Add(cheese);
                position = position + 0.5f;
                test--;
                Debug.Log("cheese");

            }
            
            Debug.Log("finish create ingredients");

        }
    }

    public void ResetModel()
    {
        foreach (GameObject obj in modelGameObjects)
        {
            Destroy(obj);
            position = -3f;
            test = 0f;
        }
        Debug.Log("object destroyed");
        Debug.Log("start randomNumber");
        RandomNumber();
        Debug.Log("finish randomNumber");
    }

    // Start is called before the first frame update
    void Start()
    {
        burger1.Add(5);
        burger1.Add(2);
        burger1.Add(3);
        burger1.Add(4);
        burger1.Add(1);

        burger2.Add(5);
        burger2.Add(2);
        burger2.Add(4);
        burger2.Add(2);
        burger2.Add(4);
        burger2.Add(3);
        burger2.Add(1);

        burger3.Add(5);
        burger3.Add(2);
        burger3.Add(2);
        burger3.Add(2);
        burger3.Add(3);
        burger3.Add(4);
        burger3.Add(1);

        burger4.Add(5);
        burger4.Add(3);
        burger4.Add(3);
        burger4.Add(2);
        burger4.Add(3);
        burger4.Add(2);
        burger4.Add(4);
        burger4.Add(1);

        burger5.Add(5);
        burger5.Add(4);
        burger5.Add(4);
        burger5.Add(4);
        burger5.Add(3);
        burger5.Add(4);
        burger5.Add(1);

        burger6.Add(5);
        burger6.Add(4);
        burger6.Add(3);
        burger6.Add(2);
        burger6.Add(1);

        burger7.Add(5);
        burger7.Add(2);
        burger7.Add(4);
        burger7.Add(3);
        burger7.Add(1);

        burger8.Add(5);
        burger8.Add(2);
        burger8.Add(4);
        burger8.Add(5);
        burger8.Add(3);
        burger8.Add(2);
        burger8.Add(1);

        RandomNumber();
    }

    // Update is called once per frame
    void Update()
    {

    }
}
