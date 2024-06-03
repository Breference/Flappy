using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    public Vector3 _startPosition;
    private float _tapForce = 200;
    private Rigidbody2D _rigidbody;
    public float _speed;
    public float _rotationSpeed = 10;
    public float _maxRotationZ = 1488;
    public float _minRotationZ = -45;
    private Quaternion _minRotation;
    private Quaternion _maxRotation;



    // Start is called before the first frame update
    private void Start()
    {
        _rigidbody = GetComponent<Rigidbody2D>();
        transform.position = _startPosition;
        _rigidbody.velocity = Vector2.zero;
        _maxRotation = Quaternion.Euler(0, 0, _maxRotationZ);
        _minRotation = Quaternion.Euler(0, 0, _minRotationZ);

    }

    // Update is called once per frame
   private void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            _rigidbody.velocity = new Vector2(_speed, 0);
            transform.rotation = _maxRotation;
            _rigidbody.AddForce(Vector3.up * _tapForce , ForceMode2D.Force);
        }
        transform.rotation = Quaternion.Lerp(transform.rotation, _minRotation, _rotationSpeed * Time.deltaTime);
   
    }
}
 