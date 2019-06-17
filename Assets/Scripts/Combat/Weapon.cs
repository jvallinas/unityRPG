using UnityEngine;

namespace RPG.Combat
{
    
    [CreateAssetMenu(fileName = "Weapon", menuName = "Weapons/Make a new weapon", order = 0)]
    public class Weapon : ScriptableObject 
    {
        [SerializeField] public AnimatorOverrideController animatorOverride = null;
        [SerializeField] GameObject equippedPrefab = null;

        [SerializeField] float weaponDamage = 5f;
        [SerializeField] float weaponRange = 2f;
        [SerializeField] bool isRightHanded = true;

        public void Spawn(Transform rightHand, Transform leftHand, Animator animator){
            if (equippedPrefab != null){

                Transform handTransform;
                if (isRightHanded) handTransform = rightHand;
                else handTransform = leftHand;
                Instantiate(equippedPrefab, handTransform);
            }
            if (animatorOverride != null) {
                animator.runtimeAnimatorController = animatorOverride;
            }
        }

        public float GetDamage(){
            return weaponDamage;
        }
        public float GetRange()
        {
            return weaponRange;
        }
    }
}