using UnityEngine;

public class level_generator : MonoBehaviour
{
    public GameObject Level_1;
    public GameObject Level_2;
    public GameObject Level_3;

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            int next_obstacle = Random.Range(1, 3);

            if (next_obstacle == 1)
            {
                Instantiate(Level_1, new Vector3 ( 0, 0, 48), Quaternion.identity);
            }
            
            if (next_obstacle == 2)
            {
                Instantiate(Level_2, new Vector3 ( 0, 0, 48), Quaternion.identity);
            }

            if (next_obstacle == 3)
            {
                Instantiate(Level_3, new Vector3 ( 0, 0, 48), Quaternion.identity);
            }
        }
    }
}
