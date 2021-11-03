using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private float maxDistance;
    [SerializeField] private float prepareTime;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            Vector3 clickWorldPosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            clickWorldPosition.z = transform.position.z;

            if (Vector3.Distance(transform.position, clickWorldPosition) > maxDistance)
                return;

            StartCoroutine(MoveToTheClickPoint(clickWorldPosition));
        }
    }

    IEnumerator MoveToTheClickPoint(Vector3 destination)
    {
        yield return new WaitForSeconds(prepareTime);

        transform.position = destination;
    }
}
