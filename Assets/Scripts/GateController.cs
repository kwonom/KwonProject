using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GateController : MonoBehaviour
{
    [SerializeField] GameObject[] _gates;
    float sumHeight = 0;
    
    // Start is called before the first frame update
    void Start()
    {
        makeGate();
    }

    public void makeGate()
    {
        for (int i = 0; i < _gates.Length; i++)
        {
            _gates[i].gameObject.SetActive(true);

            GameObject temp = Instantiate(_gates[i]);
            float height = temp.GetComponent<GateData>().getGate();
            temp.transform.position += new Vector3(0, sumHeight + height, 0);
            sumHeight += height;
        }
    }

    public void SpawnGate()
    {
        int rand = Random.Range(0, _gates.Length);
        Debug.Log("게이트 확인");
        GameObject temp = Instantiate(_gates[rand]);
        float height = temp.GetComponent<GateData>().getGate();
        temp.transform.position += new Vector3(0, sumHeight + height, 0);
        sumHeight += height;
    }
}
