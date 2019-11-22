
using UnityEngine;
using System.Collections;

public class ikanim : MonoBehaviour 
{
  public float leftHandPositionWeight;
  public float leftHandRotationWeight;

  public float rightHandPositionWeight;
  public float rightHandRotationWeight;

  public Transform leftHandObj;
  public Transform rightHandObj;
  private Animator animator;

  void Start() {
    animator = GetComponent<Animator>();
  }
  void OnAnimatorIK(int layerIndex) {
    animator.SetIKPositionWeight(AvatarIKGoal.LeftHand, leftHandPositionWeight);
    animator.SetIKRotationWeight(AvatarIKGoal.LeftHand, leftHandRotationWeight);
    animator.SetIKPosition(AvatarIKGoal.LeftHand, leftHandObj.position);
    animator.SetIKRotation(AvatarIKGoal.LeftHand, leftHandObj.rotation);

    animator.SetIKPositionWeight(AvatarIKGoal.RightHand, rightHandPositionWeight);
    animator.SetIKRotationWeight(AvatarIKGoal.RightHand, rightHandRotationWeight);
    animator.SetIKPosition(AvatarIKGoal.RightHand, rightHandObj.position);
    animator.SetIKRotation(AvatarIKGoal.RightHand, rightHandObj.rotation);
  }
}