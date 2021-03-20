
using UnityEngine;

public class TutorialScript : MonoBehaviour
{

    public Transform targetTransform;
    public float speeddOfMissile = 1.5f;

    private void Update()
    {
        //rotaion
        Vector2 tempDir = targetTransform.position - transform.position; //direction vector is calculated 

        float newAngle = Vector2.SignedAngle(Vector2.up, tempDir); //angle between direction vector and +ve y axis is calculated

        transform.rotation = Quaternion.Euler(0f, 0f, newAngle); //angle is given to missile so that it points towards the target 



        //move
        transform.Translate(Vector2.up * Time.deltaTime * speeddOfMissile);//we move the missile in the direction in which the missile is looking




        //please  kill me 


    }

}
