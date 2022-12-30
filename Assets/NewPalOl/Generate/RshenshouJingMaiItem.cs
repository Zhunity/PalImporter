using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction
{
	/// <summary>
	/// shenshouJingMaiItem
	/// </summary>
    public partial class RshenshouJingMaiItem : RMember //
    {

		/// <summary>
		/// System.Int32 accurate
		/// </summary>
		protected RField r_accurate;
		public virtual RField Raccurate
		{
			get
			{
				if(r_accurate == null)
				{
					r_accurate = new(this, "accurate");
					r_accurate.SetBelong(this.instance);
				}
				return r_accurate;
			}
		}

		/// <summary>
		/// System.Int32 arm
		/// </summary>
		protected RField r_arm;
		public virtual RField Rarm
		{
			get
			{
				if(r_arm == null)
				{
					r_arm = new(this, "arm");
					r_arm.SetBelong(this.instance);
				}
				return r_arm;
			}
		}

		/// <summary>
		/// System.Int32 atk
		/// </summary>
		protected RField r_atk;
		public virtual RField Ratk
		{
			get
			{
				if(r_atk == null)
				{
					r_atk = new(this, "atk");
					r_atk.SetBelong(this.instance);
				}
				return r_atk;
			}
		}

		/// <summary>
		/// System.Int32 block
		/// </summary>
		protected RField r_block;
		public virtual RField Rblock
		{
			get
			{
				if(r_block == null)
				{
					r_block = new(this, "block");
					r_block.SetBelong(this.instance);
				}
				return r_block;
			}
		}

		/// <summary>
		/// System.Int32 critical
		/// </summary>
		protected RField r_critical;
		public virtual RField Rcritical
		{
			get
			{
				if(r_critical == null)
				{
					r_critical = new(this, "critical");
					r_critical.SetBelong(this.instance);
				}
				return r_critical;
			}
		}

		/// <summary>
		/// System.Int32 dodge
		/// </summary>
		protected RField r_dodge;
		public virtual RField Rdodge
		{
			get
			{
				if(r_dodge == null)
				{
					r_dodge = new(this, "dodge");
					r_dodge.SetBelong(this.instance);
				}
				return r_dodge;
			}
		}

		/// <summary>
		/// System.Int32 hp
		/// </summary>
		protected RField r_hp;
		public virtual RField Rhp
		{
			get
			{
				if(r_hp == null)
				{
					r_hp = new(this, "hp");
					r_hp.SetBelong(this.instance);
				}
				return r_hp;
			}
		}

		/// <summary>
		/// System.Int32 id
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
		/// System.Int32 need_point
		/// </summary>
		protected RField r_need_point;
		public virtual RField Rneed_point
		{
			get
			{
				if(r_need_point == null)
				{
					r_need_point = new(this, "need_point");
					r_need_point.SetBelong(this.instance);
				}
				return r_need_point;
			}
		}

		/// <summary>
		/// System.Int32 tough
		/// </summary>
		protected RField r_tough;
		public virtual RField Rtough
		{
			get
			{
				if(r_tough == null)
				{
					r_tough = new(this, "tough");
					r_tough.SetBelong(this.instance);
				}
				return r_tough;
			}
		}

		/// <summary>
		/// System.Int32 wreck
		/// </summary>
		protected RField r_wreck;
		public virtual RField Rwreck
		{
			get
			{
				if(r_wreck == null)
				{
					r_wreck = new(this, "wreck");
					r_wreck.SetBelong(this.instance);
				}
				return r_wreck;
			}
		}

		/// <summary>
		/// System.String description
		/// </summary>
		protected RField r_description;
		public virtual RField Rdescription
		{
			get
			{
				if(r_description == null)
				{
					r_description = new(this, "description");
					r_description.SetBelong(this.instance);
				}
				return r_description;
			}
		}

		/// <summary>
		/// Int32 GetProperty(System.String)
		/// </summary>
		protected RMethod r_RGetProperty_String;
		public virtual RMethod RGetProperty_String
		{
			get
			{
				if(r_RGetProperty_String == null)
				{
					r_RGetProperty_String = new(this, "GetProperty", 0, typeof(System.String));
					r_RGetProperty_String.SetBelong(this.instance);
				}
				return r_RGetProperty_String;
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


        public RshenshouJingMaiItem() : base("shenshouJingMaiItem")
        {
        }

        public RshenshouJingMaiItem(System.Object instance) : base("shenshouJingMaiItem")
		{
            SetInstance(instance);
		}

        public RshenshouJingMaiItem(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RshenshouJingMaiItem(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }

        public virtual System.Int32 GetProperty(System.String  @propName)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@propName};
            var ___result = RGetProperty_String.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
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
