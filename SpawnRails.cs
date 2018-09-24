using System.Collections;
using UnityEngine;

public class SpawnRails : MonoBehaviour {

    public GameObject rail;

	void Start () {
        StartCoroutine(Spawn());
	}

    IEnumerator Spawn()
    {
        while (true)
        {
            Instantiate(rail, new Vector2(6.2f, -4.547f), Quaternion.identity);
            yield return new WaitForSeconds(2.2f);
        }
    }
}
