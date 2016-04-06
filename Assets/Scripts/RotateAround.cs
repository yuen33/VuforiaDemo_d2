/*============================================================================== 
 * Copyright (c) 2012-2015 Qualcomm Connected Experiences, Inc. All Rights Reserved. 
 * ==============================================================================*/
using UnityEngine;

/// <summary>
/// A simple behaviour to rotate the game object this script is attached to
/// </summary>
public class RotateAround : MonoBehaviour
{
    #region MONOBEHAVIOUR_METHODS
    void Update () 
    {
        Transform parentTransform = transform.parent;
        transform.RotateAround(parentTransform.position, parentTransform.up, -60 * Time.deltaTime);
    }
    #endregion //MONOBEHAVIOUR_METHODS
}
