using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.RUnityEngine.RNetworking
{
	/// <summary>
	/// UnityEngine.Networking.UploadHandler
	/// </summary>
    public partial class RUploadHandler : RMember //
    {

		/// <summary>
		/// System.IntPtr m_Ptr
		/// </summary>
		protected RField r_m_Ptr;
		public virtual RField Rm_Ptr
		{
			get
			{
				if(r_m_Ptr == null)
				{
					r_m_Ptr = new(this, "m_Ptr");
					r_m_Ptr.SetBelong(this.instance);
				}
				return r_m_Ptr;
			}
		}

		/// <summary>
		/// Byte[] data
		/// </summary>
		protected RPropertyArray<RProperty> r_data;
		public virtual RPropertyArray<RProperty> Rdata
		{
			get
			{
				if(r_data == null)
				{
					r_data = new(this, "data", -1);
					r_data.SetBelong(this.instance);
				}
				return r_data;
			}
		}

		/// <summary>
		/// System.String contentType
		/// </summary>
		protected RProperty r_contentType;
		public virtual RProperty RcontentType
		{
			get
			{
				if(r_contentType == null)
				{
					r_contentType = new(this, "contentType", -1);
					r_contentType.SetBelong(this.instance);
				}
				return r_contentType;
			}
		}

		/// <summary>
		/// Single progress
		/// </summary>
		protected RProperty r_progress;
		public virtual RProperty Rprogress
		{
			get
			{
				if(r_progress == null)
				{
					r_progress = new(this, "progress", -1);
					r_progress.SetBelong(this.instance);
				}
				return r_progress;
			}
		}

		/// <summary>
		/// Void Release()
		/// </summary>
		protected RMethod r_RRelease;
		public virtual RMethod RRelease
		{
			get
			{
				if(r_RRelease == null)
				{
					r_RRelease = new(this, "Release", 0);
					r_RRelease.SetBelong(this.instance);
				}
				return r_RRelease;
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
		/// Void Dispose()
		/// </summary>
		protected RMethod r_RDispose;
		public virtual RMethod RDispose
		{
			get
			{
				if(r_RDispose == null)
				{
					r_RDispose = new(this, "Dispose", 0);
					r_RDispose.SetBelong(this.instance);
				}
				return r_RDispose;
			}
		}

		/// <summary>
		/// Byte[] GetData()
		/// </summary>
		protected RMethod r_RGetData;
		public virtual RMethod RGetData
		{
			get
			{
				if(r_RGetData == null)
				{
					r_RGetData = new(this, "GetData", 0);
					r_RGetData.SetBelong(this.instance);
				}
				return r_RGetData;
			}
		}

		/// <summary>
		/// System.String GetContentType()
		/// </summary>
		protected RMethod r_RGetContentType;
		public virtual RMethod RGetContentType
		{
			get
			{
				if(r_RGetContentType == null)
				{
					r_RGetContentType = new(this, "GetContentType", 0);
					r_RGetContentType.SetBelong(this.instance);
				}
				return r_RGetContentType;
			}
		}

		/// <summary>
		/// Void SetContentType(System.String)
		/// </summary>
		protected RMethod r_RSetContentType_String;
		public virtual RMethod RSetContentType_String
		{
			get
			{
				if(r_RSetContentType_String == null)
				{
					r_RSetContentType_String = new(this, "SetContentType", 0, typeof(System.String));
					r_RSetContentType_String.SetBelong(this.instance);
				}
				return r_RSetContentType_String;
			}
		}

		/// <summary>
		/// Single GetProgress()
		/// </summary>
		protected RMethod r_RGetProgress;
		public virtual RMethod RGetProgress
		{
			get
			{
				if(r_RGetProgress == null)
				{
					r_RGetProgress = new(this, "GetProgress", 0);
					r_RGetProgress.SetBelong(this.instance);
				}
				return r_RGetProgress;
			}
		}

		/// <summary>
		/// System.String InternalGetContentType()
		/// </summary>
		protected RMethod r_RInternalGetContentType;
		public virtual RMethod RInternalGetContentType
		{
			get
			{
				if(r_RInternalGetContentType == null)
				{
					r_RInternalGetContentType = new(this, "InternalGetContentType", 0);
					r_RInternalGetContentType.SetBelong(this.instance);
				}
				return r_RInternalGetContentType;
			}
		}

		/// <summary>
		/// Void InternalSetContentType(System.String)
		/// </summary>
		protected RMethod r_RInternalSetContentType_String;
		public virtual RMethod RInternalSetContentType_String
		{
			get
			{
				if(r_RInternalSetContentType_String == null)
				{
					r_RInternalSetContentType_String = new(this, "InternalSetContentType", 0, typeof(System.String));
					r_RInternalSetContentType_String.SetBelong(this.instance);
				}
				return r_RInternalSetContentType_String;
			}
		}

		/// <summary>
		/// Single InternalGetProgress()
		/// </summary>
		protected RMethod r_RInternalGetProgress;
		public virtual RMethod RInternalGetProgress
		{
			get
			{
				if(r_RInternalGetProgress == null)
				{
					r_RInternalGetProgress = new(this, "InternalGetProgress", 0);
					r_RInternalGetProgress.SetBelong(this.instance);
				}
				return r_RInternalGetProgress;
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


        public RUploadHandler() : base("UnityEngine.Networking.UploadHandler")
        {
        }

        public RUploadHandler(System.Object instance) : base("UnityEngine.Networking.UploadHandler")
		{
            SetInstance(instance);
		}

        public RUploadHandler(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RUploadHandler(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }

        public virtual void Release()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RRelease.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Finalize()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RFinalize.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Dispose()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RDispose.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Byte[] GetData()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetData.Invoke(___genericsType, ___parameters);

            return (System.Byte[])___result;
        }


        public virtual System.String GetContentType()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetContentType.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public virtual void SetContentType(System.String  @newContentType)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@newContentType};
            var ___result = RSetContentType_String.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Single GetProgress()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetProgress.Invoke(___genericsType, ___parameters);

            return (System.Single)___result;
        }


        public virtual System.String InternalGetContentType()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RInternalGetContentType.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public virtual void InternalSetContentType(System.String  @newContentType)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@newContentType};
            var ___result = RInternalSetContentType_String.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Single InternalGetProgress()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RInternalGetProgress.Invoke(___genericsType, ___parameters);

            return (System.Single)___result;
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
