using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GPSManager : MonoBehaviour
{
    IEnumerator Start()
    {
        // Turn on location services
        Input.location.Start();

        // Waiting for the location service to be ready
        while (Input.location.status == LocationServiceStatus.Initializing)
            yield return new WaitForSeconds(1);

        // If the location service is ready, obtain location information.
        if (Input.location.status == LocationServiceStatus.Running)
        {
            float latitude = Input.location.lastData.latitude;
            float longitude = Input.location.lastData.longitude;

            // Process the obtained location information here.
        }
    }

    void OnDisable()
    {
        // Turn off location services
        Input.location.Stop();
    }
}
