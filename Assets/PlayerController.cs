using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    Rigidbody rigidbody;
    float horizontal;
    float vertical;
    public float speed = 10f;

    // 로딩
    void Awake()
    {
        // <>는 제네릭 프로그래밍 의미, 컴포넌트마다 타입이 다르므로 사용
        // 불러올 컴포넌트 입력
        rigidbody = GetComponent<Rigidbody>(); 
    }

    // 초기 값 설정
    void Start()
    {
        rigidbody.velocity = new Vector3(1, 0, 0);
    }

    // Update is called once per frame
    void Update()
    {
        horizontal = Input.GetAxis("Horizontal");
        vertical = Input.GetAxis("Vertical");
        rigidbody.velocity = new Vector3(horizontal, rigidbody.velocity.y, vertical);
    }
}
