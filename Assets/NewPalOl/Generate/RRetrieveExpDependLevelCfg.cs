using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction
{
	/// <summary>
	/// RetrieveExpDependLevelCfg
	/// </summary>
    public partial class RRetrieveExpDependLevelCfg : RMember //
    {

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
		/// System.Int32 escortExp1
		/// </summary>
		protected RField r_escortExp1;
		public virtual RField RescortExp1
		{
			get
			{
				if(r_escortExp1 == null)
				{
					r_escortExp1 = new(this, "escortExp1");
					r_escortExp1.SetBelong(this.instance);
				}
				return r_escortExp1;
			}
		}

		/// <summary>
		/// System.Int32 escortExp2
		/// </summary>
		protected RField r_escortExp2;
		public virtual RField RescortExp2
		{
			get
			{
				if(r_escortExp2 == null)
				{
					r_escortExp2 = new(this, "escortExp2");
					r_escortExp2.SetBelong(this.instance);
				}
				return r_escortExp2;
			}
		}

		/// <summary>
		/// System.Int32 escortExp3
		/// </summary>
		protected RField r_escortExp3;
		public virtual RField RescortExp3
		{
			get
			{
				if(r_escortExp3 == null)
				{
					r_escortExp3 = new(this, "escortExp3");
					r_escortExp3.SetBelong(this.instance);
				}
				return r_escortExp3;
			}
		}

		/// <summary>
		/// System.Int32 escortExp4
		/// </summary>
		protected RField r_escortExp4;
		public virtual RField RescortExp4
		{
			get
			{
				if(r_escortExp4 == null)
				{
					r_escortExp4 = new(this, "escortExp4");
					r_escortExp4.SetBelong(this.instance);
				}
				return r_escortExp4;
			}
		}

		/// <summary>
		/// System.Int32 rouleauExp1
		/// </summary>
		protected RField r_rouleauExp1;
		public virtual RField RrouleauExp1
		{
			get
			{
				if(r_rouleauExp1 == null)
				{
					r_rouleauExp1 = new(this, "rouleauExp1");
					r_rouleauExp1.SetBelong(this.instance);
				}
				return r_rouleauExp1;
			}
		}

		/// <summary>
		/// System.Int32 rouleauExp2
		/// </summary>
		protected RField r_rouleauExp2;
		public virtual RField RrouleauExp2
		{
			get
			{
				if(r_rouleauExp2 == null)
				{
					r_rouleauExp2 = new(this, "rouleauExp2");
					r_rouleauExp2.SetBelong(this.instance);
				}
				return r_rouleauExp2;
			}
		}

		/// <summary>
		/// System.Int32 rouleauExp3
		/// </summary>
		protected RField r_rouleauExp3;
		public virtual RField RrouleauExp3
		{
			get
			{
				if(r_rouleauExp3 == null)
				{
					r_rouleauExp3 = new(this, "rouleauExp3");
					r_rouleauExp3.SetBelong(this.instance);
				}
				return r_rouleauExp3;
			}
		}

		/// <summary>
		/// System.Int32 rouleauExp4
		/// </summary>
		protected RField r_rouleauExp4;
		public virtual RField RrouleauExp4
		{
			get
			{
				if(r_rouleauExp4 == null)
				{
					r_rouleauExp4 = new(this, "rouleauExp4");
					r_rouleauExp4.SetBelong(this.instance);
				}
				return r_rouleauExp4;
			}
		}

		/// <summary>
		/// System.Int32 worldExp
		/// </summary>
		protected RField r_worldExp;
		public virtual RField RworldExp
		{
			get
			{
				if(r_worldExp == null)
				{
					r_worldExp = new(this, "worldExp");
					r_worldExp.SetBelong(this.instance);
				}
				return r_worldExp;
			}
		}

		/// <summary>
		/// System.Int32 worldGoldEx
		/// </summary>
		protected RField r_worldGoldEx;
		public virtual RField RworldGoldEx
		{
			get
			{
				if(r_worldGoldEx == null)
				{
					r_worldGoldEx = new(this, "worldGoldEx");
					r_worldGoldEx.SetBelong(this.instance);
				}
				return r_worldGoldEx;
			}
		}

		/// <summary>
		/// Int32 GetEscortValue(Int32)
		/// </summary>
		protected RMethod r_RGetEscortValue_Int32;
		public virtual RMethod RGetEscortValue_Int32
		{
			get
			{
				if(r_RGetEscortValue_Int32 == null)
				{
					r_RGetEscortValue_Int32 = new(this, "GetEscortValue", 0, typeof(System.Int32));
					r_RGetEscortValue_Int32.SetBelong(this.instance);
				}
				return r_RGetEscortValue_Int32;
			}
		}

		/// <summary>
		/// Int32 GetRouleauValue(Int32)
		/// </summary>
		protected RMethod r_RGetRouleauValue_Int32;
		public virtual RMethod RGetRouleauValue_Int32
		{
			get
			{
				if(r_RGetRouleauValue_Int32 == null)
				{
					r_RGetRouleauValue_Int32 = new(this, "GetRouleauValue", 0, typeof(System.Int32));
					r_RGetRouleauValue_Int32.SetBelong(this.instance);
				}
				return r_RGetRouleauValue_Int32;
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


        public RRetrieveExpDependLevelCfg() : base("RetrieveExpDependLevelCfg")
        {
        }

        public RRetrieveExpDependLevelCfg(System.Object instance) : base("RetrieveExpDependLevelCfg")
		{
            SetInstance(instance);
		}

        public RRetrieveExpDependLevelCfg(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RRetrieveExpDependLevelCfg(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }

        public virtual System.Int32 GetEscortValue(System.Int32  @index)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@index};
            var ___result = RGetEscortValue_Int32.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.Int32 GetRouleauValue(System.Int32  @index)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@index};
            var ___result = RGetRouleauValue_Int32.Invoke(___genericsType, ___parameters);

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
