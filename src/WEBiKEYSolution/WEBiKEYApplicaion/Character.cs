//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WEBiKEY.Application
{
    using System;
    using System.Collections.Generic;
    
    public partial class Character
    {
        public Character()
        {
            this.CharacterStates = new HashSet<CharacterState>();
            this.DisablingCharacterStates = new HashSet<CharacterState>();
        }
    
        public int CharacterID { get; set; }
        public string CharacterCode { get; set; }
        public string CharacterDescription { get; set; }
        public int CategoryID { get; set; }
        public byte[] Image { get; set; }
    
        public virtual CharacterCategory CharacterCategory { get; set; }
        public virtual ICollection<CharacterState> CharacterStates { get; set; }
        public virtual ICollection<CharacterState> DisablingCharacterStates { get; set; }
    }
}
