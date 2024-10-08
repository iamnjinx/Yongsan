using UnityEngine;

public class floorMarkAlpha : MonoBehaviour
{
    private Material material;
    private Color baseColor;
    private float elapsedTime;
    public float period = 3.0f;

    void Start()
    {
        // ������Ʈ�� ���͸��� ��������
        material = GetComponent<Renderer>().material;

        // �ʱ� �÷� �� ���� (���͸����� BaseMap ���� ��������)
        baseColor = material.color;

        // �ʱ� ���� ���� 255�� ����
        baseColor.a = 3/4f; // ���� ���� 1�� ���� (0~1 �������� ���)
        material.color = baseColor;
    }

    void Update()
    {
        // 3�� �ֱ�� ���� ���� ��ȭ�ϵ��� ����
  
        elapsedTime += Time.deltaTime;
        float t = Mathf.PingPong(elapsedTime / period, 1.0f);

        // ���� �� ��� (255���� 100���� �پ��� �ٽ� 255�� ����)
        baseColor.a = Mathf.Lerp(50f / 200f, 3/4f, t);

        // ���͸����� BaseMap ���� �� ������Ʈ
        material.color = baseColor;
    }
}
