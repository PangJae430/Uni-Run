
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

// ���ӿ��� ���¸� ǥ���ϰ�, ���� ������ UI�� �����ϴ� ���� �Ŵ���
// ������ �� �ϳ��� ���� �Ŵ����� ������ �� ����
public class GameManager : MonoBehaviour
{
    public static GameManager instance; // �̱����� �Ҵ��� ���� ����

    public bool isGameover = false; // ���ӿ��� ����
    public Text scoreText; // ������ ����� UI �ؽ�Ʈ
    public GameObject gameoverUI; // ���ӿ��� �� Ȱ��ȭ�� UI ���� ������Ʈ

    private int score = 0; // ���� ����

    // ���� ���۰� ���ÿ� �̱����� ����
    void Awake()
    {
        // �̱��� ���� instance�� ����ִ°�?
        if(instance==null)
        {
            // instance�� ��� �ִٸ�(null) �װ��� �ڱ� �ڽ��� �Ҵ�
            instance = this;
        }
        else
        {
            // instance�� �̹� �ٸ� GameManager ������Ʈ�� �Ҵ�Ǿ� �ִ� ���
            // �̱��� ������Ʈ�� �ϳ��� �����ؾ� �ϹǷ� �ڽ��� ���� ������Ʈ�� �ı�
            Debug.LogWarning("���� �ΰ� �̻��� ������ �����մϴ�.");
            Destroy(gameObject);
        }
    }

    void Update()
    {
        // ���ӿ��� ���¿��� ������ ������� �� �ְ� �ϴ� ó��
        if(isGameover&&Input.GetMouseButtonDown(0))
        {
            // ���ӿ��� ���¿��� ���콺 ���ʹ�ư�� Ŭ���ϸ� ���� �� �����
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }

    }

    // ������ �����ϴ� �޼���
    public void AddScore(int newScore)
    {
        if(!isGameover)
        {
            //������ ����
            score += newScore;
            scoreText.text = "Score : " + score;
        }
    }     
    
    // �÷��̾� ��� �� ���ӿ����� �����ϴ� �޼���
    public void OnPlayerDead()
    {
        isGameover = true;
        gameoverUI.SetActive(true);
    }
}
