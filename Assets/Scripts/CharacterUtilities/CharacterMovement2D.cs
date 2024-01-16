using UnityEngine;
using UnityEngine.EventSystems;

namespace CharacterUtilities
{
    public class CharacterMovement2D : MonoBehaviour
    {
        //Character Data Features
        [SerializeField, Range(1,10)]private float speed = 5.0f;
        [SerializeField, Range(1,10)]private float jumpForce = 5.0f;
        private Rigidbody2D _rigidbody2D;
        private bool _isGrounded = false;

        private bool _isInDungeon = false; // When in dungeon, player can jump and cannot move up and down
        //Input Methods
        public void Move(float horizontal, float forward)
        {
            if (_isInDungeon)
            {
                transform.Translate(horizontal * speed * Time.deltaTime, 0, 0);
            }
            else
            {
                Vector2 movement = new Vector2(horizontal, forward);
                movement.Normalize();
                transform.Translate(movement * speed * Time.deltaTime);
            }
        }
        public void Jump()
        {
            if (_isGrounded)
            {
                _isGrounded = false;
                _rigidbody2D.AddForce(new Vector2(0, jumpForce), ForceMode2D.Impulse);
            }
        }
        //Event Methods
        private void OnCollisionEnter2D(Collision2D collision)
        {
            if (collision.gameObject.CompareTag($"Ground"))
            {
                _isGrounded = true;
            }
        }
        //coyote time
        private void OnCollisionExit2D(Collision2D collision)
        {
            if (collision.gameObject.CompareTag($"Ground"))
            {
                //start coyote time
                Invoke(nameof(SetGroundedFalse), 0.1f);
            }
        }
        private void SetGroundedFalse()
        {
            _isGrounded = false;
        }

        public void Initialize(CharacterData characterData)
        {
            speed = characterData.GetSpeed;
            jumpForce = characterData.GetJumpForce;
            _rigidbody2D = gameObject.AddComponent<Rigidbody2D>();
            //Restrict rotation
            _rigidbody2D.constraints = RigidbodyConstraints2D.FreezeRotation;
            //Look for the level Type and set the isInDungeon bool
            GameObject LevelTypeObj = GameObject.Find("LevelType");
            //If the level type is dungeon, set isInDungeon to true
            if (LevelTypeObj != null)
            {
                if (LevelTypeObj.GetComponent<LevelType>().IsDungeon)
                {
                    _isInDungeon = true;
                    _rigidbody2D.gravityScale = 1;
                }else
                {
                    _isInDungeon = false;
                    _rigidbody2D.gravityScale = 0;
                }
            }//every other level type is not a dungeon
            
            //set up the collider
            gameObject.AddComponent<CircleCollider2D>();
            gameObject.GetComponent<CircleCollider2D>().radius = 0.5f;
            
        }
    }
}