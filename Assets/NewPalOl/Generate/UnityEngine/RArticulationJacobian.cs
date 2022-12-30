using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.RUnityEngine
{
	/// <summary>
	/// UnityEngine.ArticulationJacobian
	/// </summary>
    public partial class RArticulationJacobian : RMember //
    {

		/// <summary>
		/// System.Int32 rowsCount
		/// </summary>
		protected RField r_rowsCount;
		public virtual RField RrowsCount
		{
			get
			{
				if(r_rowsCount == null)
				{
					r_rowsCount = new(this, "rowsCount");
					r_rowsCount.SetBelong(this.instance);
				}
				return r_rowsCount;
			}
		}

		/// <summary>
		/// System.Int32 colsCount
		/// </summary>
		protected RField r_colsCount;
		public virtual RField RcolsCount
		{
			get
			{
				if(r_colsCount == null)
				{
					r_colsCount = new(this, "colsCount");
					r_colsCount.SetBelong(this.instance);
				}
				return r_colsCount;
			}
		}

		/// <summary>
		/// System.Collections.Generic.List`1[System.Single] matrixData
		/// </summary>
		protected RSystem.RCollections.RGeneric.RList<RField> r_matrixData;
		public virtual RSystem.RCollections.RGeneric.RList<RField> RmatrixData
		{
			get
			{
				if(r_matrixData == null)
				{
					r_matrixData = new(this, "matrixData");
					r_matrixData.SetBelong(this.instance);
				}
				return r_matrixData;
			}
		}

		/// <summary>
		/// Single Item [Int32, Int32]
		/// </summary>
		protected RProperty r_Item_Int32_Int32;
		public virtual RProperty RItem_Int32_Int32
		{
			get
			{
				if(r_Item_Int32_Int32 == null)
				{
					r_Item_Int32_Int32 = new(this, "Item", -1, typeof(System.Int32), typeof(System.Int32));
					r_Item_Int32_Int32.SetBelong(this.instance);
				}
				return r_Item_Int32_Int32;
			}
		}

		/// <summary>
		/// Int32 rows
		/// </summary>
		protected RProperty r_rows;
		public virtual RProperty Rrows
		{
			get
			{
				if(r_rows == null)
				{
					r_rows = new(this, "rows", -1);
					r_rows.SetBelong(this.instance);
				}
				return r_rows;
			}
		}

		/// <summary>
		/// Int32 columns
		/// </summary>
		protected RProperty r_columns;
		public virtual RProperty Rcolumns
		{
			get
			{
				if(r_columns == null)
				{
					r_columns = new(this, "columns", -1);
					r_columns.SetBelong(this.instance);
				}
				return r_columns;
			}
		}

		/// <summary>
		/// System.Collections.Generic.List`1[System.Single] elements
		/// </summary>
		protected RSystem.RCollections.RGeneric.RList<RProperty> r_elements;
		public virtual RSystem.RCollections.RGeneric.RList<RProperty> Relements
		{
			get
			{
				if(r_elements == null)
				{
					r_elements = new(this, "elements", -1);
					r_elements.SetBelong(this.instance);
				}
				return r_elements;
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


        public RArticulationJacobian() : base("UnityEngine.ArticulationJacobian")
        {
        }

        public RArticulationJacobian(System.Object instance) : base("UnityEngine.ArticulationJacobian")
		{
            SetInstance(instance);
		}

        public RArticulationJacobian(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RArticulationJacobian(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }

        public virtual System.Boolean Equals(System.Object  @obj)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@obj};
            var ___result = REquals_Object.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Int32 GetHashCode()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetHashCode.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.String ToString()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RToString.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public virtual void Finalize()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RFinalize.Invoke(___genericsType, ___parameters);

            
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
