using UnityEngine;

public class floorMarkAlpha : MonoBehaviour
{
    private Material material;
    private Color baseColor;
    private float elapsedTime;
    public float period = 3.0f;

    void Start()
    {
        // 오브젝트의 메터리얼 가져오기
        material = GetComponent<Renderer>().material;

        // 초기 컬러 값 저장 (메터리얼의 BaseMap 색상 가져오기)
        baseColor = material.color;

        // 초기 알파 값을 255로 설정
        baseColor.a = 1f; // 알파 값을 1로 설정 (0~1 범위에서 사용)
        material.color = baseColor;
    }

    void Update()
    {
        // 3초 주기로 알파 값이 변화하도록 설정
  
        elapsedTime += Time.deltaTime;
        float t = Mathf.PingPong(elapsedTime / period, 1.0f);

        // 알파 값 계산 (255에서 100으로 줄어들고 다시 255로 증가)
        baseColor.a = Mathf.Lerp(50f / 200f, 1f, t);

        // 메터리얼의 BaseMap 알파 값 업데이트
        material.color = baseColor;
    }
}
