using UnityEngine;
using UnityEngine.SceneManagement;  // ���� �����ϱ� ���� ���ӽ����̽�

public class ChangeScene : MonoBehaviour
{
    public string sceneName;        // �ҷ��� �� �̸�

    // �� �ҷ����� �Լ�
    public void Load()
    {
        SceneManager.LoadScene(sceneName); // sceneName�� ������ �� �ҷ�����
    }
}
