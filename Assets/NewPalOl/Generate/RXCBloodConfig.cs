using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction
{
	/// <summary>
	/// XCBloodConfig
	/// </summary>
    public partial class RXCBloodConfig : RMember //
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
		/// System.String iconurl
		/// </summary>
		protected RField r_iconurl;
		public virtual RField Riconurl
		{
			get
			{
				if(r_iconurl == null)
				{
					r_iconurl = new(this, "iconurl");
					r_iconurl.SetBelong(this.instance);
				}
				return r_iconurl;
			}
		}

		/// <summary>
		/// System.String skillname
		/// </summary>
		protected RField r_skillname;
		public virtual RField Rskillname
		{
			get
			{
				if(r_skillname == null)
				{
					r_skillname = new(this, "skillname");
					r_skillname.SetBelong(this.instance);
				}
				return r_skillname;
			}
		}

		/// <summary>
		/// System.String normaldes
		/// </summary>
		protected RField r_normaldes;
		public virtual RField Rnormaldes
		{
			get
			{
				if(r_normaldes == null)
				{
					r_normaldes = new(this, "normaldes");
					r_normaldes.SetBelong(this.instance);
				}
				return r_normaldes;
			}
		}

		/// <summary>
		/// System.String simpledes
		/// </summary>
		protected RField r_simpledes;
		public virtual RField Rsimpledes
		{
			get
			{
				if(r_simpledes == null)
				{
					r_simpledes = new(this, "simpledes");
					r_simpledes.SetBelong(this.instance);
				}
				return r_simpledes;
			}
		}

		/// <summary>
		/// System.String probability
		/// </summary>
		protected RField r_probability;
		public virtual RField Rprobability
		{
			get
			{
				if(r_probability == null)
				{
					r_probability = new(this, "probability");
					r_probability.SetBelong(this.instance);
				}
				return r_probability;
			}
		}

		/// <summary>
		/// System.String quantity
		/// </summary>
		protected RField r_quantity;
		public virtual RField Rquantity
		{
			get
			{
				if(r_quantity == null)
				{
					r_quantity = new(this, "quantity");
					r_quantity.SetBelong(this.instance);
				}
				return r_quantity;
			}
		}

		/// <summary>
		/// System.String tipsdes
		/// </summary>
		protected RField r_tipsdes;
		public virtual RField Rtipsdes
		{
			get
			{
				if(r_tipsdes == null)
				{
					r_tipsdes = new(this, "tipsdes");
					r_tipsdes.SetBelong(this.instance);
				}
				return r_tipsdes;
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


        public RXCBloodConfig() : base("XCBloodConfig")
        {
        }

        public RXCBloodConfig(System.Object instance) : base("XCBloodConfig")
		{
            SetInstance(instance);
		}

        public RXCBloodConfig(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RXCBloodConfig(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
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
