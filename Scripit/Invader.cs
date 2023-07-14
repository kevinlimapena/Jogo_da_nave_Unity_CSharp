
using UnityEngine;

public class Invader : MonoBehaviour
{
   public  Sprite [] animationsSprite;
   public float animatioTime;

   private SpriteRenderer _spriterender ;
   private int _animationframe;

   private void Awake() 
   {
      _spriterender = GetComponent<SpriteRenderer>(); 
   }   
    private void Start() 
    {
        InvokeRepeating(nameof(animcaoSprite), this.animatioTime,this.animatioTime   ) ;
    }
    
    private void animcaoSprite()
    {
      _animationframe++;
      if (_animationframe >= this.animationsSprite.Length ){
         _animationframe = 0 ; 
      }
      _spriterender.sprite = this.animationsSprite[_animationframe];
    }
}
