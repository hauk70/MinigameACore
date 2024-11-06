using UnityEngine;

public class Boot : MonoBehaviour
{
    [SerializeField] private GameObject _p1;
    [SerializeField] private GameObject _p2;

    private GameObject[] obj = new GameObject[2];
    
    // Start is called before the first frame update
    void Start()
    {
        obj[0] = Instantiate(_p1, transform);
        obj[1] = Instantiate(_p2, transform);
        obj[1].transform.position = new Vector3(0, 2, 0);
    }

    // Update is called once per frame
    void Update()
    {
        for (int i = 0; i < obj.Length; i++)
        {
            obj[i].transform.Rotate(0, 10 * Time.deltaTime, 0);
        }
    }
}
