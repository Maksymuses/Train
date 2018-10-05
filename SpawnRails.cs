using System.Collections;
using UnityEngine;

public class SpawnRails_new : MonoBehaviour {

    public GameObject rail;
    public GameObject rail2;
    public GameObject rail3;
    public GameObject RailUp;
    public GameObject RailDown;
    private int randomNumber;
    private int cycleTrigger = 1;

    void Start()
    {
        StartCoroutine(Spawn());
    }

    IEnumerator Spawn()
    {
        while (true)
        {
            randomNumber = Random.Range(0, 3);
            switch (randomNumber)
            {
                case 1:
                    Instantiate(RailUp, new Vector2(6.2f, -3.669f), Quaternion.identity);
                    Instantiate(rail3, new Vector2(6.2f, -2.796f), Quaternion.identity);
                    Instantiate(rail, new Vector2(6.2f, -4.547f), Quaternion.identity);
                    while (cycleTrigger == 1)
                    {
                        yield return new WaitForSeconds(2.28f);
                        randomNumber = Random.Range(0, 3);
                        if (randomNumber == 2)
                        {
                            Instantiate(RailDown, new Vector2(6.2f, -3.669f), Quaternion.identity);
                            Instantiate(rail3, new Vector2(6.2f, -2.796f), Quaternion.identity);
                            Instantiate(rail, new Vector2(6.2f, -4.547f), Quaternion.identity);
                            cycleTrigger = 0;
                        }
                        if (randomNumber != 2)
                        {
                            Instantiate(rail, new Vector2(6.2f, -4.547f), Quaternion.identity);
                            Instantiate(rail2, new Vector2(6.2f, -2.796f), Quaternion.identity);
                        }
                    }
                    break;
                default:
                    Instantiate(rail, new Vector2(6.2f, -4.547f), Quaternion.identity);
                    Instantiate(rail2, new Vector2(6.2f, -2.796f), Quaternion.identity);
                    break;
            }
            cycleTrigger = 1;
            yield return new WaitForSeconds(2.28f);
        }
    }
}
