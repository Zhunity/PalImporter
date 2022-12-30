using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.RUnityEngine.RNetworking
{
	/// <summary>
	/// UnityEngine.Networking.DownloadHandler
	/// </summary>
    public partial class RDownloadHandler : RMember //
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
		/// Boolean isDone
		/// </summary>
		protected RProperty r_isDone;
		public virtual RProperty RisDone
		{
			get
			{
				if(r_isDone == null)
				{
					r_isDone = new(this, "isDone", -1);
					r_isDone.SetBelong(this.instance);
				}
				return r_isDone;
			}
		}

		/// <summary>
		/// System.String error
		/// </summary>
		protected RProperty r_error;
		public virtual RProperty Rerror
		{
			get
			{
				if(r_error == null)
				{
					r_error = new(this, "error", -1);
					r_error.SetBelong(this.instance);
				}
				return r_error;
			}
		}

		/// <summary>
		/// ReadOnly nativeData
		/// </summary>
		protected RProperty.RReadOnly r_nativeData;
		public virtual RProperty.RReadOnly RnativeData
		{
			get
			{
				if(r_nativeData == null)
				{
					r_nativeData = new(this, "nativeData", -1);
					r_nativeData.SetBelong(this.instance);
				}
				return r_nativeData;
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
		/// System.String text
		/// </summary>
		protected RProperty r_text;
		public virtual RProperty Rtext
		{
			get
			{
				if(r_text == null)
				{
					r_text = new(this, "text", -1);
					r_text.SetBelong(this.instance);
				}
				return r_text;
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
		/// Boolean IsDone()
		/// </summary>
		protected RMethod r_RIsDone;
		public virtual RMethod RIsDone
		{
			get
			{
				if(r_RIsDone == null)
				{
					r_RIsDone = new(this, "IsDone", 0);
					r_RIsDone.SetBelong(this.instance);
				}
				return r_RIsDone;
			}
		}

		/// <summary>
		/// System.String GetErrorMsg()
		/// </summary>
		protected RMethod r_RGetErrorMsg;
		public virtual RMethod RGetErrorMsg
		{
			get
			{
				if(r_RGetErrorMsg == null)
				{
					r_RGetErrorMsg = new(this, "GetErrorMsg", 0);
					r_RGetErrorMsg.SetBelong(this.instance);
				}
				return r_RGetErrorMsg;
			}
		}

		/// <summary>
		/// Unity.Collections.NativeArray`1[System.Byte] GetNativeData()
		/// </summary>
		protected RMethod r_RGetNativeData;
		public virtual RMethod RGetNativeData
		{
			get
			{
				if(r_RGetNativeData == null)
				{
					r_RGetNativeData = new(this, "GetNativeData", 0);
					r_RGetNativeData.SetBelong(this.instance);
				}
				return r_RGetNativeData;
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
		/// System.String GetText()
		/// </summary>
		protected RMethod r_RGetText;
		public virtual RMethod RGetText
		{
			get
			{
				if(r_RGetText == null)
				{
					r_RGetText = new(this, "GetText", 0);
					r_RGetText.SetBelong(this.instance);
				}
				return r_RGetText;
			}
		}

		/// <summary>
		/// System.Text.Encoding GetTextEncoder()
		/// </summary>
		protected RMethod r_RGetTextEncoder;
		public virtual RMethod RGetTextEncoder
		{
			get
			{
				if(r_RGetTextEncoder == null)
				{
					r_RGetTextEncoder = new(this, "GetTextEncoder", 0);
					r_RGetTextEncoder.SetBelong(this.instance);
				}
				return r_RGetTextEncoder;
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
		/// Boolean ReceiveData(Byte[], Int32)
		/// </summary>
		protected RMethod r_RReceiveData_ByteArray_Int32;
		public virtual RMethod RReceiveData_ByteArray_Int32
		{
			get
			{
				if(r_RReceiveData_ByteArray_Int32 == null)
				{
					r_RReceiveData_ByteArray_Int32 = new(this, "ReceiveData", 0, typeof(System.Byte).MakeArrayType(), typeof(System.Int32));
					r_RReceiveData_ByteArray_Int32.SetBelong(this.instance);
				}
				return r_RReceiveData_ByteArray_Int32;
			}
		}

		/// <summary>
		/// Void ReceiveContentLengthHeader(UInt64)
		/// </summary>
		protected RMethod r_RReceiveContentLengthHeader_UInt64;
		public virtual RMethod RReceiveContentLengthHeader_UInt64
		{
			get
			{
				if(r_RReceiveContentLengthHeader_UInt64 == null)
				{
					r_RReceiveContentLengthHeader_UInt64 = new(this, "ReceiveContentLengthHeader", 0, typeof(System.UInt64));
					r_RReceiveContentLengthHeader_UInt64.SetBelong(this.instance);
				}
				return r_RReceiveContentLengthHeader_UInt64;
			}
		}

		/// <summary>
		/// Void ReceiveContentLength(Int32)
		/// </summary>
		protected RMethod r_RReceiveContentLength_Int32;
		public virtual RMethod RReceiveContentLength_Int32
		{
			get
			{
				if(r_RReceiveContentLength_Int32 == null)
				{
					r_RReceiveContentLength_Int32 = new(this, "ReceiveContentLength", 0, typeof(System.Int32));
					r_RReceiveContentLength_Int32.SetBelong(this.instance);
				}
				return r_RReceiveContentLength_Int32;
			}
		}

		/// <summary>
		/// Void CompleteContent()
		/// </summary>
		protected RMethod r_RCompleteContent;
		public virtual RMethod RCompleteContent
		{
			get
			{
				if(r_RCompleteContent == null)
				{
					r_RCompleteContent = new(this, "CompleteContent", 0);
					r_RCompleteContent.SetBelong(this.instance);
				}
				return r_RCompleteContent;
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
		/// T GetCheckedDownloader[T](UnityEngine.Networking.UnityWebRequest)
		/// </summary>
		protected static RMethod r_RGetCheckedDownloader_GT_UnityWebRequest;
		public static RMethod RGetCheckedDownloader_GT_UnityWebRequest
		{
			get
			{
				if(r_RGetCheckedDownloader_GT_UnityWebRequest == null)
				{
					r_RGetCheckedDownloader_GT_UnityWebRequest = new(typeof(UnityEngine.Networking.DownloadHandler), "GetCheckedDownloader", 1, typeof(UnityEngine.Networking.UnityWebRequest));
					r_RGetCheckedDownloader_GT_UnityWebRequest.SetBelong(null);
				}
				return r_RGetCheckedDownloader_GT_UnityWebRequest;
			}
		}

		/// <summary>
		/// Byte* InternalGetByteArray(UnityEngine.Networking.DownloadHandler, Int32 ByRef)
		/// </summary>
		protected static RMethod r_RInternalGetByteArray_DownloadHandler_Out_Int32;
		public static RMethod RInternalGetByteArray_DownloadHandler_Out_Int32
		{
			get
			{
				if(r_RInternalGetByteArray_DownloadHandler_Out_Int32 == null)
				{
					r_RInternalGetByteArray_DownloadHandler_Out_Int32 = new(typeof(UnityEngine.Networking.DownloadHandler), "InternalGetByteArray", 0, typeof(UnityEngine.Networking.DownloadHandler), typeof(System.Int32).MakeByRefType());
					r_RInternalGetByteArray_DownloadHandler_Out_Int32.SetBelong(null);
				}
				return r_RInternalGetByteArray_DownloadHandler_Out_Int32;
			}
		}

		/// <summary>
		/// Byte[] InternalGetByteArray(UnityEngine.Networking.DownloadHandler)
		/// </summary>
		protected static RMethod r_RInternalGetByteArray_DownloadHandler;
		public static RMethod RInternalGetByteArray_DownloadHandler
		{
			get
			{
				if(r_RInternalGetByteArray_DownloadHandler == null)
				{
					r_RInternalGetByteArray_DownloadHandler = new(typeof(UnityEngine.Networking.DownloadHandler), "InternalGetByteArray", 0, typeof(UnityEngine.Networking.DownloadHandler));
					r_RInternalGetByteArray_DownloadHandler.SetBelong(null);
				}
				return r_RInternalGetByteArray_DownloadHandler;
			}
		}

		/// <summary>
		/// Unity.Collections.NativeArray`1[System.Byte] InternalGetNativeArray(UnityEngine.Networking.DownloadHandler, Unity.Collections.NativeArray`1[System.Byte] ByRef)
		/// </summary>
		protected static RMethod r_RInternalGetNativeArray_DownloadHandler_Ref_NativeArray_d_Byte_p_;
		public static RMethod RInternalGetNativeArray_DownloadHandler_Ref_NativeArray_d_Byte_p_
		{
			get
			{
				if(r_RInternalGetNativeArray_DownloadHandler_Ref_NativeArray_d_Byte_p_ == null)
				{
					r_RInternalGetNativeArray_DownloadHandler_Ref_NativeArray_d_Byte_p_ = new(typeof(UnityEngine.Networking.DownloadHandler), "InternalGetNativeArray", 0, typeof(UnityEngine.Networking.DownloadHandler), typeof(Unity.Collections.NativeArray<>).MakeGenericType(typeof(System.Byte)).MakeByRefType());
					r_RInternalGetNativeArray_DownloadHandler_Ref_NativeArray_d_Byte_p_.SetBelong(null);
				}
				return r_RInternalGetNativeArray_DownloadHandler_Ref_NativeArray_d_Byte_p_;
			}
		}

		/// <summary>
		/// Void DisposeNativeArray(Unity.Collections.NativeArray`1[System.Byte] ByRef)
		/// </summary>
		protected static RMethod r_RDisposeNativeArray_Ref_NativeArray_d_Byte_p_;
		public static RMethod RDisposeNativeArray_Ref_NativeArray_d_Byte_p_
		{
			get
			{
				if(r_RDisposeNativeArray_Ref_NativeArray_d_Byte_p_ == null)
				{
					r_RDisposeNativeArray_Ref_NativeArray_d_Byte_p_ = new(typeof(UnityEngine.Networking.DownloadHandler), "DisposeNativeArray", 0, typeof(Unity.Collections.NativeArray<>).MakeGenericType(typeof(System.Byte)).MakeByRefType());
					r_RDisposeNativeArray_Ref_NativeArray_d_Byte_p_.SetBelong(null);
				}
				return r_RDisposeNativeArray_Ref_NativeArray_d_Byte_p_;
			}
		}

		/// <summary>
		/// Void CreateNativeArrayForNativeData(Unity.Collections.NativeArray`1[System.Byte] ByRef, Byte*, Int32)
		/// </summary>
		protected static RMethod r_RCreateNativeArrayForNativeData_Ref_NativeArray_d_Byte_p__BytePointer_Int32;
		public static RMethod RCreateNativeArrayForNativeData_Ref_NativeArray_d_Byte_p__BytePointer_Int32
		{
			get
			{
				if(r_RCreateNativeArrayForNativeData_Ref_NativeArray_d_Byte_p__BytePointer_Int32 == null)
				{
					r_RCreateNativeArrayForNativeData_Ref_NativeArray_d_Byte_p__BytePointer_Int32 = new(typeof(UnityEngine.Networking.DownloadHandler), "CreateNativeArrayForNativeData", 0, typeof(Unity.Collections.NativeArray<>).MakeGenericType(typeof(System.Byte)).MakeByRefType(), typeof(System.Byte).MakePointerType(), typeof(System.Int32));
					r_RCreateNativeArrayForNativeData_Ref_NativeArray_d_Byte_p__BytePointer_Int32.SetBelong(null);
				}
				return r_RCreateNativeArrayForNativeData_Ref_NativeArray_d_Byte_p__BytePointer_Int32;
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


        public RDownloadHandler() : base("UnityEngine.Networking.DownloadHandler")
        {
        }

        public RDownloadHandler(System.Object instance) : base("UnityEngine.Networking.DownloadHandler")
		{
            SetInstance(instance);
		}

        public RDownloadHandler(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RDownloadHandler(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
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


        public virtual System.Boolean IsDone()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RIsDone.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.String GetErrorMsg()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetErrorMsg.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public virtual System.Object GetNativeData()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetNativeData.Invoke(___genericsType, ___parameters);

            return (System.Object)___result;
        }


        public virtual System.Byte[] GetData()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetData.Invoke(___genericsType, ___parameters);

            return (System.Byte[])___result;
        }


        public virtual System.String GetText()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetText.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public virtual System.Text.Encoding GetTextEncoder()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetTextEncoder.Invoke(___genericsType, ___parameters);

            return (System.Text.Encoding)___result;
        }


        public virtual System.String GetContentType()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetContentType.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public virtual System.Boolean ReceiveData(System.Byte[]  @data, System.Int32  @dataLength)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@data, @dataLength};
            var ___result = RReceiveData_ByteArray_Int32.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual void ReceiveContentLengthHeader(System.UInt64  @contentLength)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@contentLength};
            var ___result = RReceiveContentLengthHeader_UInt64.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void ReceiveContentLength(System.Int32  @contentLength)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@contentLength};
            var ___result = RReceiveContentLength_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void CompleteContent()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RCompleteContent.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Single GetProgress()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetProgress.Invoke(___genericsType, ___parameters);

            return (System.Single)___result;
        }


        public static T GetCheckedDownloader<T>(UnityEngine.Networking.UnityWebRequest  @www) where T : UnityEngine.Networking.DownloadHandler
        {

            var ___genericsType = new Type[] {typeof(T)};
            var ___parameters = new object[]{@www};
            var ___result = RGetCheckedDownloader_GT_UnityWebRequest.Invoke(___genericsType, ___parameters);

            return (T)___result;
        }



        public static System.Byte[] InternalGetByteArray(UnityEngine.Networking.DownloadHandler  @dh)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@dh};
            var ___result = RInternalGetByteArray_DownloadHandler.Invoke(___genericsType, ___parameters);

            return (System.Byte[])___result;
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
