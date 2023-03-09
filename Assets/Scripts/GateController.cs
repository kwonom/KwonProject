using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GateController : MonoBehaviour
{
    [SerializeField] GameObject _gate;
    [SerializeField] GameObject _sgate;
    [SerializeField] GameObject _tgate;
    [SerializeField] GameObject _fgate;
    [SerializeField] GameObject _figate;

    // Start is called before the first frame update
    void Start()
    {
        firstGate();
        secondGate();
        thirdGate();
        fourthGate();
        fifthGate();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void firstGate()
    {
        _gate.gameObject.SetActive(true);
        Vector3 gpos = new Vector3(_gate.transform.position.x, _gate.transform.position.y, _gate.transform.position.z);
        GameObject gate = Instantiate(_gate);
        gate.transform.position = gpos;
    }

    public void secondGate()
    {
        _sgate.gameObject.SetActive(true);
        Vector3 gpos = new Vector3(_sgate.transform.position.x, _sgate.transform.position.y, _sgate.transform.position.z);
        GameObject gate = Instantiate(_sgate);
        gate.transform.position = gpos;
    }

    public void thirdGate()
    {
        _tgate.gameObject.SetActive(true);
        Vector3 gpos = new Vector3(_tgate.transform.position.x, _tgate.transform.position.y, _tgate.transform.position.z);
        GameObject gate = Instantiate(_tgate);
        gate.transform.position = gpos;
    }

    public void fourthGate()
    {
        _fgate.gameObject.SetActive(true);
        Vector3 gpos = new Vector3(_fgate.transform.position.x, _fgate.transform.position.y, _fgate.transform.position.z);
        GameObject gate = Instantiate(_fgate);
        gate.transform.position = gpos;
    }

    public void fifthGate()
    {
        _figate.gameObject.SetActive(true);
        Vector3 gpos = new Vector3(_figate.transform.position.x, _figate.transform.position.y, _figate.transform.position.z);
        GameObject gate = Instantiate(_figate);
        gate.transform.position = gpos;
    }
}
