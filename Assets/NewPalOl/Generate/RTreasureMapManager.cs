using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction
{
	/// <summary>
	/// TreasureMapManager
	/// </summary>
    public partial class RTreasureMapManager : RMember //
    {

		/// <summary>
		/// Void Initial()
		/// </summary>
		protected RMethod r_RInitial;
		public virtual RMethod RInitial
		{
			get
			{
				if(r_RInitial == null)
				{
					r_RInitial = new(this, "Initial", 0);
					r_RInitial.SetBelong(this.instance);
				}
				return r_RInitial;
			}
		}

		/// <summary>
		/// Void OnTreasureBox(System.Object, #Pfb.#Isb)
		/// </summary>
		protected RMethod r_ROnTreasureBox_Object___0__Isb;
		public virtual RMethod ROnTreasureBox_Object___0__Isb
		{
			get
			{
				if(r_ROnTreasureBox_Object___0__Isb == null)
				{
					r_ROnTreasureBox_Object___0__Isb = new(this, "OnTreasureBox", 0, typeof(System.Object),  ReleactionUtils.GetType("#Pfb.#Isb"));
					r_ROnTreasureBox_Object___0__Isb.SetBelong(this.instance);
				}
				return r_ROnTreasureBox_Object___0__Isb;
			}
		}

		/// <summary>
		/// Void SendOpenTreasure(GameDefineType.ID)
		/// </summary>
		protected RMethod r_RSendOpenTreasure_ID;
		public virtual RMethod RSendOpenTreasure_ID
		{
			get
			{
				if(r_RSendOpenTreasure_ID == null)
				{
					r_RSendOpenTreasure_ID = new(this, "SendOpenTreasure", 0, typeof(GameDefineType.ID));
					r_RSendOpenTreasure_ID.SetBelong(this.instance);
				}
				return r_RSendOpenTreasure_ID;
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


        public RTreasureMapManager() : base("TreasureMapManager")
        {
        }

        public RTreasureMapManager(System.Object instance) : base("TreasureMapManager")
		{
            SetInstance(instance);
		}

        public RTreasureMapManager(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RTreasureMapManager(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }

        public virtual void Initial()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RInitial.Invoke(___genericsType, ___parameters);

            
        }



        public virtual void SendOpenTreasure(GameDefineType.ID  @id)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@id};
            var ___result = RSendOpenTreasure_ID.Invoke(___genericsType, ___parameters);

            
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
