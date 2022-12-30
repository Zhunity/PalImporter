using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction
{
	/// <summary>
	/// ILLUSTRATION_INFO
	/// </summary>
    public partial class RILLUSTRATION_INFO : RMember //
    {

		/// <summary>
		/// System.String id
		/// </summary>
		protected RField r_id;
		public virtual RField Rid
		{
			get
			{
				if(r_id == null)
				{
					r_id = new(this, "id");
					r_id.SetBelong(this.instance);
				}
				return r_id;
			}
		}

		/// <summary>
		/// System.String name
		/// </summary>
		protected RField r_name;
		public virtual RField Rname
		{
			get
			{
				if(r_name == null)
				{
					r_name = new(this, "name");
					r_name.SetBelong(this.instance);
				}
				return r_name;
			}
		}

		/// <summary>
		/// System.String profilecg
		/// </summary>
		protected RField r_profilecg;
		public virtual RField Rprofilecg
		{
			get
			{
				if(r_profilecg == null)
				{
					r_profilecg = new(this, "profilecg");
					r_profilecg.SetBelong(this.instance);
				}
				return r_profilecg;
			}
		}

		/// <summary>
		/// System.String career
		/// </summary>
		protected RField r_career;
		public virtual RField Rcareer
		{
			get
			{
				if(r_career == null)
				{
					r_career = new(this, "career");
					r_career.SetBelong(this.instance);
				}
				return r_career;
			}
		}

		/// <summary>
		/// System.String descript
		/// </summary>
		protected RField r_descript;
		public virtual RField Rdescript
		{
			get
			{
				if(r_descript == null)
				{
					r_descript = new(this, "descript");
					r_descript.SetBelong(this.instance);
				}
				return r_descript;
			}
		}

		/// <summary>
		/// System.String information
		/// </summary>
		protected RField r_information;
		public virtual RField Rinformation
		{
			get
			{
				if(r_information == null)
				{
					r_information = new(this, "information");
					r_information.SetBelong(this.instance);
				}
				return r_information;
			}
		}

		/// <summary>
		/// System.Int32 level
		/// </summary>
		protected RField r_level;
		public virtual RField Rlevel
		{
			get
			{
				if(r_level == null)
				{
					r_level = new(this, "level");
					r_level.SetBelong(this.instance);
				}
				return r_level;
			}
		}

		/// <summary>
		/// System.Int32 item1
		/// </summary>
		protected RField r_item1;
		public virtual RField Ritem1
		{
			get
			{
				if(r_item1 == null)
				{
					r_item1 = new(this, "item1");
					r_item1.SetBelong(this.instance);
				}
				return r_item1;
			}
		}

		/// <summary>
		/// System.Int32 num1
		/// </summary>
		protected RField r_num1;
		public virtual RField Rnum1
		{
			get
			{
				if(r_num1 == null)
				{
					r_num1 = new(this, "num1");
					r_num1.SetBelong(this.instance);
				}
				return r_num1;
			}
		}

		/// <summary>
		/// System.Int32 power
		/// </summary>
		protected RField r_power;
		public virtual RField Rpower
		{
			get
			{
				if(r_power == null)
				{
					r_power = new(this, "power");
					r_power.SetBelong(this.instance);
				}
				return r_power;
			}
		}

		/// <summary>
		/// System.String petTypeName
		/// </summary>
		protected RField r_petTypeName;
		public virtual RField RpetTypeName
		{
			get
			{
				if(r_petTypeName == null)
				{
					r_petTypeName = new(this, "petTypeName");
					r_petTypeName.SetBelong(this.instance);
				}
				return r_petTypeName;
			}
		}

		/// <summary>
		/// System.Boolean bRecruit
		/// </summary>
		protected RField r_bRecruit;
		public virtual RField RbRecruit
		{
			get
			{
				if(r_bRecruit == null)
				{
					r_bRecruit = new(this, "bRecruit");
					r_bRecruit.SetBelong(this.instance);
				}
				return r_bRecruit;
			}
		}

		/// <summary>
		/// System.Boolean bPrompt
		/// </summary>
		protected RField r_bPrompt;
		public virtual RField RbPrompt
		{
			get
			{
				if(r_bPrompt == null)
				{
					r_bPrompt = new(this, "bPrompt");
					r_bPrompt.SetBelong(this.instance);
				}
				return r_bPrompt;
			}
		}

		/// <summary>
		/// System.Byte state
		/// </summary>
		protected RField r_state;
		public virtual RField Rstate
		{
			get
			{
				if(r_state == null)
				{
					r_state = new(this, "state");
					r_state.SetBelong(this.instance);
				}
				return r_state;
			}
		}

		/// <summary>
		/// System.Int32 challengeLvl
		/// </summary>
		protected RField r_challengeLvl;
		public virtual RField RchallengeLvl
		{
			get
			{
				if(r_challengeLvl == null)
				{
					r_challengeLvl = new(this, "challengeLvl");
					r_challengeLvl.SetBelong(this.instance);
				}
				return r_challengeLvl;
			}
		}

		/// <summary>
		/// System.Int32 GetFriendliness
		/// </summary>
		protected RField r_GetFriendliness;
		public virtual RField RGetFriendliness
		{
			get
			{
				if(r_GetFriendliness == null)
				{
					r_GetFriendliness = new(this, "GetFriendliness");
					r_GetFriendliness.SetBelong(this.instance);
				}
				return r_GetFriendliness;
			}
		}

		/// <summary>
		/// System.String challenge_desc
		/// </summary>
		protected RField r_challenge_desc;
		public virtual RField Rchallenge_desc
		{
			get
			{
				if(r_challenge_desc == null)
				{
					r_challenge_desc = new(this, "challenge_desc");
					r_challenge_desc.SetBelong(this.instance);
				}
				return r_challenge_desc;
			}
		}

		/// <summary>
		/// Boolean Equals(System.Object)
		/// </summary>
		protected RMethod r_REquals_Object;
		public virtual RMethod REquals_Object
		{
			get
			{
				if(r_REquals_Object == null)
				{
					r_REquals_Object = new(this, "Equals", 0, typeof(System.Object));
					r_REquals_Object.SetBelong(this.instance);
				}
				return r_REquals_Object;
			}
		}

		/// <summary>
		/// Void Finalize()
		/// </summary>
		protected RMethod r_RFinalize;
		public virtual RMethod RFinalize
		{
			get
			{
				if(r_RFinalize == null)
				{
					r_RFinalize = new(this, "Finalize", 0);
					r_RFinalize.SetBelong(this.instance);
				}
				return r_RFinalize;
			}
		}

		/// <summary>
		/// Int32 GetHashCode()
		/// </summary>
		protected RMethod r_RGetHashCode;
		public virtual RMethod RGetHashCode
		{
			get
			{
				if(r_RGetHashCode == null)
				{
					r_RGetHashCode = new(this, "GetHashCode", 0);
					r_RGetHashCode.SetBelong(this.instance);
				}
				return r_RGetHashCode;
			}
		}

		/// <summary>
		/// System.Type GetType()
		/// </summary>
		protected RMethod r_RGetType;
		public virtual RMethod RGetType
		{
			get
			{
				if(r_RGetType == null)
				{
					r_RGetType = new(this, "GetType", 0);
					r_RGetType.SetBelong(this.instance);
				}
				return r_RGetType;
			}
		}

		/// <summary>
		/// System.Object MemberwiseClone()
		/// </summary>
		protected RMethod r_RMemberwiseClone;
		public virtual RMethod RMemberwiseClone
		{
			get
			{
				if(r_RMemberwiseClone == null)
				{
					r_RMemberwiseClone = new(this, "MemberwiseClone", 0);
					r_RMemberwiseClone.SetBelong(this.instance);
				}
				return r_RMemberwiseClone;
			}
		}

		/// <summary>
		/// System.String ToString()
		/// </summary>
		protected RMethod r_RToString;
		public virtual RMethod RToString
		{
			get
			{
				if(r_RToString == null)
				{
					r_RToString = new(this, "ToString", 0);
					r_RToString.SetBelong(this.instance);
				}
				return r_RToString;
			}
		}


        public RILLUSTRATION_INFO() : base("ILLUSTRATION_INFO")
        {
        }

        public RILLUSTRATION_INFO(System.Object instance) : base("ILLUSTRATION_INFO")
		{
            SetInstance(instance);
		}

        public RILLUSTRATION_INFO(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RILLUSTRATION_INFO(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }

        public virtual System.Boolean Equals(System.Object  @obj)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@obj};
            var ___result = REquals_Object.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual void Finalize()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RFinalize.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Int32 GetHashCode()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetHashCode.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.Type GetType()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetType.Invoke(___genericsType, ___parameters);

            return (System.Type)___result;
        }


        public virtual System.Object MemberwiseClone()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMemberwiseClone.Invoke(___genericsType, ___parameters);

            return (System.Object)___result;
        }


        public virtual System.String ToString()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RToString.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


    }
}
