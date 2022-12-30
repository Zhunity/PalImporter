using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.R__0__u
{
	/// <summary>
	/// #u.#8Rc
	/// </summary>
    public partial class R__0__8Rc : RMember //
    {

		/// <summary>
		/// System.Int32 #a
		/// </summary>
		protected static RField r___0__a;
		public static RField R__0__a
		{
			get
			{
				if(r___0__a == null)
				{
					r___0__a = new( ReleactionUtils.GetType("#u.#8Rc"), "#a");
					r___0__a.SetBelong(null);
				}
				return r___0__a;
			}
		}

		/// <summary>
		/// GameDefineType.ID #b
		/// </summary>
		protected RGameDefineType.RID r___0__b;
		public virtual RGameDefineType.RID R__0__b
		{
			get
			{
				if(r___0__b == null)
				{
					r___0__b = new(this, "#b");
					r___0__b.SetBelong(this.instance);
				}
				return r___0__b;
			}
		}

		/// <summary>
		/// System.Int32 #c
		/// </summary>
		protected RField r___0__c;
		public virtual RField R__0__c
		{
			get
			{
				if(r___0__c == null)
				{
					r___0__c = new(this, "#c");
					r___0__c.SetBelong(this.instance);
				}
				return r___0__c;
			}
		}

		/// <summary>
		/// GameDefineType.ID #d
		/// </summary>
		protected RGameDefineType.RID r___0__d;
		public virtual RGameDefineType.RID R__0__d
		{
			get
			{
				if(r___0__d == null)
				{
					r___0__d = new(this, "#d");
					r___0__d.SetBelong(this.instance);
				}
				return r___0__d;
			}
		}

		/// <summary>
		/// System.Int32 #e
		/// </summary>
		protected RField r___0__e;
		public virtual RField R__0__e
		{
			get
			{
				if(r___0__e == null)
				{
					r___0__e = new(this, "#e");
					r___0__e.SetBelong(this.instance);
				}
				return r___0__e;
			}
		}

		/// <summary>
		/// SpiritItemConfig #f
		/// </summary>
		protected RSpiritItemConfig r___0__f;
		public virtual RSpiritItemConfig R__0__f
		{
			get
			{
				if(r___0__f == null)
				{
					r___0__f = new(this, "#f");
					r___0__f.SetBelong(this.instance);
				}
				return r___0__f;
			}
		}

		/// <summary>
		/// Void #dA(GameDefineType.ID, SpiritItemConfig, Int32, GameDefineType.ID, Int32)
		/// </summary>
		protected RMethod r_R__0__dA_ID_SpiritItemConfig_Int32_ID_Int32;
		public virtual RMethod R__0__dA_ID_SpiritItemConfig_Int32_ID_Int32
		{
			get
			{
				if(r_R__0__dA_ID_SpiritItemConfig_Int32_ID_Int32 == null)
				{
					r_R__0__dA_ID_SpiritItemConfig_Int32_ID_Int32 = new(this, "#dA", 0, typeof(GameDefineType.ID), typeof(SpiritItemConfig), typeof(System.Int32), typeof(GameDefineType.ID), typeof(System.Int32));
					r_R__0__dA_ID_SpiritItemConfig_Int32_ID_Int32.SetBelong(this.instance);
				}
				return r_R__0__dA_ID_SpiritItemConfig_Int32_ID_Int32;
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

		/// <summary>
		/// System.String #0gb()
		/// </summary>
		protected RMethod r_R__0__0gb;
		public virtual RMethod R__0__0gb
		{
			get
			{
				if(r_R__0__0gb == null)
				{
					r_R__0__0gb = new(this, "#0gb", 0);
					r_R__0__0gb.SetBelong(this.instance);
				}
				return r_R__0__0gb;
			}
		}

		/// <summary>
		/// System.String #1gb()
		/// </summary>
		protected RMethod r_R__0__1gb;
		public virtual RMethod R__0__1gb
		{
			get
			{
				if(r_R__0__1gb == null)
				{
					r_R__0__1gb = new(this, "#1gb", 0);
					r_R__0__1gb.SetBelong(this.instance);
				}
				return r_R__0__1gb;
			}
		}

		/// <summary>
		/// Int32 GetCurrExp()
		/// </summary>
		protected RMethod r_RGetCurrExp;
		public virtual RMethod RGetCurrExp
		{
			get
			{
				if(r_RGetCurrExp == null)
				{
					r_RGetCurrExp = new(this, "GetCurrExp", 0);
					r_RGetCurrExp.SetBelong(this.instance);
				}
				return r_RGetCurrExp;
			}
		}

		/// <summary>
		/// Int32 #3gb()
		/// </summary>
		protected RMethod r_R__0__3gb;
		public virtual RMethod R__0__3gb
		{
			get
			{
				if(r_R__0__3gb == null)
				{
					r_R__0__3gb = new(this, "#3gb", 0);
					r_R__0__3gb.SetBelong(this.instance);
				}
				return r_R__0__3gb;
			}
		}

		/// <summary>
		/// System.String #4gb()
		/// </summary>
		protected RMethod r_R__0__4gb;
		public virtual RMethod R__0__4gb
		{
			get
			{
				if(r_R__0__4gb == null)
				{
					r_R__0__4gb = new(this, "#4gb", 0);
					r_R__0__4gb.SetBelong(this.instance);
				}
				return r_R__0__4gb;
			}
		}

		/// <summary>
		/// System.String #5gb()
		/// </summary>
		protected RMethod r_R__0__5gb;
		public virtual RMethod R__0__5gb
		{
			get
			{
				if(r_R__0__5gb == null)
				{
					r_R__0__5gb = new(this, "#5gb", 0);
					r_R__0__5gb.SetBelong(this.instance);
				}
				return r_R__0__5gb;
			}
		}

		/// <summary>
		/// System.String #6gb()
		/// </summary>
		protected RMethod r_R__0__6gb;
		public virtual RMethod R__0__6gb
		{
			get
			{
				if(r_R__0__6gb == null)
				{
					r_R__0__6gb = new(this, "#6gb", 0);
					r_R__0__6gb.SetBelong(this.instance);
				}
				return r_R__0__6gb;
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


        public R__0__8Rc() : base("#u.#8Rc")
        {
        }

        public R__0__8Rc(System.Object instance) : base("#u.#8Rc")
		{
            SetInstance(instance);
		}

        public R__0__8Rc(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public R__0__8Rc(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }

        public virtual void __0__dA(GameDefineType.ID  @instID, SpiritItemConfig  @typeCfg, System.Int32  @inlevel, GameDefineType.ID  @inPlace, System.Int32  @inIndex)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@instID, @typeCfg, @inlevel, @inPlace, @inIndex};
            var ___result = R__0__dA_ID_SpiritItemConfig_Int32_ID_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.String ToString()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RToString.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public virtual System.String __0__0gb()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = R__0__0gb.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public virtual System.String __0__1gb()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = R__0__1gb.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public virtual System.Int32 GetCurrExp()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetCurrExp.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.Int32 __0__3gb()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = R__0__3gb.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.String __0__4gb()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = R__0__4gb.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public virtual System.String __0__5gb()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = R__0__5gb.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public virtual System.String __0__6gb()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = R__0__6gb.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
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


    }
}
