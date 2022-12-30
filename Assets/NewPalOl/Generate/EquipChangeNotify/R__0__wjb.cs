using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction
{public partial class REquipChangeNotify
{
	
	/// <summary>
	/// EquipChangeNotify+#wjb
	/// </summary>
    public partial class R__0__wjb : RMember //
    {

		/// <summary>
		/// System.Int32 #a
		/// </summary>
		protected RField r___0__a;
		public virtual RField R__0__a
		{
			get
			{
				if(r___0__a == null)
				{
					r___0__a = new(this, "#a");
					r___0__a.SetBelong(this.instance);
				}
				return r___0__a;
			}
		}

		/// <summary>
		/// System.Int32 #b
		/// </summary>
		protected RField r___0__b;
		public virtual RField R__0__b
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
		/// System.Int32 #d
		/// </summary>
		protected RField r___0__d;
		public virtual RField R__0__d
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
		/// System.Int32 #f
		/// </summary>
		protected RField r___0__f;
		public virtual RField R__0__f
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
		/// System.Int32 #g
		/// </summary>
		protected RField r___0__g;
		public virtual RField R__0__g
		{
			get
			{
				if(r___0__g == null)
				{
					r___0__g = new(this, "#g");
					r___0__g.SetBelong(this.instance);
				}
				return r___0__g;
			}
		}

		/// <summary>
		/// System.Int32 #h
		/// </summary>
		protected RField r___0__h;
		public virtual RField R__0__h
		{
			get
			{
				if(r___0__h == null)
				{
					r___0__h = new(this, "#h");
					r___0__h.SetBelong(this.instance);
				}
				return r___0__h;
			}
		}

		/// <summary>
		/// System.Int32 #i
		/// </summary>
		protected RField r___0__i;
		public virtual RField R__0__i
		{
			get
			{
				if(r___0__i == null)
				{
					r___0__i = new(this, "#i");
					r___0__i.SetBelong(this.instance);
				}
				return r___0__i;
			}
		}

		/// <summary>
		/// System.Int32 #j
		/// </summary>
		protected RField r___0__j;
		public virtual RField R__0__j
		{
			get
			{
				if(r___0__j == null)
				{
					r___0__j = new(this, "#j");
					r___0__j.SetBelong(this.instance);
				}
				return r___0__j;
			}
		}

		/// <summary>
		/// Void #tjb(GameDefineType.ID)
		/// </summary>
		protected RMethod r_R__0__tjb_ID;
		public virtual RMethod R__0__tjb_ID
		{
			get
			{
				if(r_R__0__tjb_ID == null)
				{
					r_R__0__tjb_ID = new(this, "#tjb", 0, typeof(GameDefineType.ID));
					r_R__0__tjb_ID.SetBelong(this.instance);
				}
				return r_R__0__tjb_ID;
			}
		}

		/// <summary>
		/// Int32 #Od(ShowType)
		/// </summary>
		protected RMethod r_R__0__Od_ShowType;
		public virtual RMethod R__0__Od_ShowType
		{
			get
			{
				if(r_R__0__Od_ShowType == null)
				{
					r_R__0__Od_ShowType = new(this, "#Od", 0,  ReleactionUtils.GetType("EquipChangeNotify+ShowType"));
					r_R__0__Od_ShowType.SetBelong(this.instance);
				}
				return r_R__0__Od_ShowType;
			}
		}

		/// <summary>
		/// System.String #ujb(ShowType, Int32)
		/// </summary>
		protected static RMethod r_R__0__ujb_ShowType_Int32;
		public static RMethod R__0__ujb_ShowType_Int32
		{
			get
			{
				if(r_R__0__ujb_ShowType_Int32 == null)
				{
					r_R__0__ujb_ShowType_Int32 = new( ReleactionUtils.GetType("EquipChangeNotify+#wjb"), "#ujb", 0,  ReleactionUtils.GetType("EquipChangeNotify+ShowType"), typeof(System.Int32));
					r_R__0__ujb_ShowType_Int32.SetBelong(null);
				}
				return r_R__0__ujb_ShowType_Int32;
			}
		}

		/// <summary>
		/// System.String #vjb(ShowType)
		/// </summary>
		protected static RMethod r_R__0__vjb_ShowType;
		public static RMethod R__0__vjb_ShowType
		{
			get
			{
				if(r_R__0__vjb_ShowType == null)
				{
					r_R__0__vjb_ShowType = new( ReleactionUtils.GetType("EquipChangeNotify+#wjb"), "#vjb", 0,  ReleactionUtils.GetType("EquipChangeNotify+ShowType"));
					r_R__0__vjb_ShowType.SetBelong(null);
				}
				return r_R__0__vjb_ShowType;
			}
		}

		/// <summary>
		/// #wjb op_Subtraction(#wjb, #wjb)
		/// </summary>
		protected static RMethod r_Rop_Subtraction___0__wjb___0__wjb;
		public static RMethod Rop_Subtraction___0__wjb___0__wjb
		{
			get
			{
				if(r_Rop_Subtraction___0__wjb___0__wjb == null)
				{
					r_Rop_Subtraction___0__wjb___0__wjb = new( ReleactionUtils.GetType("EquipChangeNotify+#wjb"), "op_Subtraction", 0,  ReleactionUtils.GetType("EquipChangeNotify+#wjb"),  ReleactionUtils.GetType("EquipChangeNotify+#wjb"));
					r_Rop_Subtraction___0__wjb___0__wjb.SetBelong(null);
				}
				return r_Rop_Subtraction___0__wjb___0__wjb;
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


        public R__0__wjb() : base("EquipChangeNotify+#wjb")
        {
        }

        public R__0__wjb(System.Object instance) : base("EquipChangeNotify+#wjb")
		{
            SetInstance(instance);
		}

        public R__0__wjb(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public R__0__wjb(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }

        public virtual void __0__tjb(GameDefineType.ID  @heroID)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@heroID};
            var ___result = R__0__tjb_ID.Invoke(___genericsType, ___parameters);

            
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
}