using UnityEngine;

public class CameraManager : MonoBehaviour
{
    public float leftLimit = 0.0f;      // ���� ��ũ�� ����
    public float rightLimit = 0.0f;     // ������ ��ũ�� ����
    public float topLimit = 0.0f;       // ���� ��ũ�� ����
    public float bottomLimit = 0.0f;    // �Ʒ��� ��ũ�� ����

    public bool isForceScrollX = false;     // X�� ���� ��ũ�� �÷���
    public float forceScrollSpeedX = 0.5f;  // 1�ʰ� ������ X�� �Ÿ�
    public bool isForceScrollY = false;     // Y�� ���� ��ũ�� �÷���
    public float forceScrollSpeedY = 0.5f;  // 1�ʰ� ������ Y�� �Ÿ�


    public GameObject subScreen;     // ���� ��ũ�� ������Ʈ

    private void Update()
    {
        // �÷��̾� ã�� (�±װ� "Player"�� ���� ������Ʈ)
        GameObject player = GameObject.FindGameObjectWithTag("Player");

        if (player != null)
        {
            // ī�޶� ��ǥ ����
            float x = player.transform.position.x;  // �÷��̾��� x ��ǥ�� ī�޶��� x ��ǥ�� ����
            float y = player.transform.position.y;  // �÷��̾��� y ��ǥ�� ī�޶��� y ��ǥ�� ����
            float z = transform.position.z; // ī�޶��� z ��ǥ�� �״�� ����

            // ���ι��� ����ȭ
            // �¿� ���� �̵� ���� ����        
            if (x < leftLimit)
            {
                x = leftLimit;
            }
            else if (x > rightLimit)
            {
                x = rightLimit;
            }

            if (isForceScrollX)
            {
                // ���� ��ũ�� ����
                x = transform.position.x + (forceScrollSpeedX * Time.deltaTime);
            }

            // ���ι��� ����ȭ
            // ���Ʒ� ���� �̵� ���� ����
            if (y < bottomLimit)
            {
                y = bottomLimit;
            }
            else if (y > topLimit)
            {
                y = topLimit;
            }

            // ���ι��� ����ȭ
            if (isForceScrollY)
            {
                // ���� ��ũ�� ����
                y = transform.position.y + (forceScrollSpeedY * Time.deltaTime);
            }

            // ī�޶� ��ġ�� Vector3 ����
            Vector3 v3 = new Vector3(x, y, z);
            transform.position = v3; // ī�޶� ��ġ ����

            // ���� ��ũ�� ��ũ��
            if (subScreen != null)
            {
                // ���� ��ũ�� ��ġ ����
                y = subScreen.transform.position.y;
                z = subScreen.transform.position.z;
                Vector3 v = new Vector3(x / 2.0f, y, z);    // ���� ��ũ���� ī�޶��� ���� �ӵ��� �̵�
                subScreen.transform.position = v; // ���� ��ũ�� ��ġ ����
            }
        }


    }
}
