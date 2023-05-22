using UnityEngine;

public class GateController : MonoBehaviour
{
    [SerializeField] GameObject[] _gates;
    float sumHeight = 0;
    
    // Start is called before the first frame update
    void Start()
    {
        makeGate();
        Debug.Log("����Ʈ���� ȣ��Ǿ����ϴ�.");
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
        Debug.Log("����Ʈ Ȯ��");
        GameObject temp = Instantiate(_gates[rand]);
        float height = temp.GetComponent<GateData>().getGate();
        temp.transform.position += new Vector3(0, sumHeight + height, 0);
        sumHeight += height;
    }
}
