using UnityEngine;

public class Platform : MonoBehaviour
{
    public GameObject[] obstacles; // ��ֹ� ������Ʈ��
    private bool stepped = false; // �÷��̾� ĳ���Ͱ� ��Ҵ°�

    // ������Ʈ�� Ȱ��ȭ�� ������ �Ź� ����Ǵ� �޼���
    private void OnEnable()
    {
        // ������ �����ϴ� ó��
    }

    void OnCollisionEnter2D()
    {
        // �÷��̾� ĳ���Ͱ� �ڽ��� ����� �� ������ �߰��ϴ� ó��
    }
}
