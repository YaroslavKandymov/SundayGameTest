using SundaygameTest.TaskTwo.Scripts.AnimatorController;
using UnityEngine;

namespace SundaygameTest.TaskTwo.Scripts.AnimationPlayers
{
    public class HumanoidAnimationPlayer : MonoBehaviour
    {
        [SerializeField] private Animator _animator;

        public void PlayIdleAnimation()
        {
            _animator.SetFloat(HumanoidAnimatorController.Params.Speed, 0);
        }
        
        public void PlayRunAnimation()
        {
            _animator.SetFloat(HumanoidAnimatorController.Params.Speed, 1);
        }
        
        public void PlayJumpAnimation()
        {
            _animator.SetTrigger(HumanoidAnimatorController.Params.Jump);
        }
        
        public void PlayShootAnimation()
        {
            _animator.SetTrigger(HumanoidAnimatorController.Params.Shoot);
        }
    }
}