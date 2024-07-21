using UnityEngine;

public class EnemyAttack : MonoBehaviour
{
    //public GameObject enemyPrefab;
    public float speed = 2f;
    GameObject playertarget;
    // Start is called before the first frame update
    void Start()
    {
        playertarget = GameObject.FindWithTag("Player");
        /*for (int i = 0; i < 2; i++)
        {
            SpawnEnemy();
        }*/
    }
   /* void SpawnEnemy()
    {
        Vector3 randomPosition = new Vector3(UnityEngine.Random.Range(-16f, 16f), 1f, UnityEngine.Random.Range(-19f, 19f));
        Instantiate(enemyPrefab, randomPosition, Quaternion.identity);
    }*/

    // Update is called once per frame
    void Update()
    {
        var Step = speed * Time.deltaTime;
        transform.position = Vector3.MoveTowards(transform.position, playertarget.transform.position, Step);
    }
}
