using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.RUnityEngine.RNetworking
{
	/// <summary>
	/// UnityEngine.Networking.UnityWebRequest
	/// </summary>
    public partial class RUnityWebRequest : RMember //
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
		/// UnityEngine.Networking.DownloadHandler m_DownloadHandler
		/// </summary>
		protected RUnityEngine.RNetworking.RDownloadHandler r_m_DownloadHandler;
		public virtual RUnityEngine.RNetworking.RDownloadHandler Rm_DownloadHandler
		{
			get
			{
				if(r_m_DownloadHandler == null)
				{
					r_m_DownloadHandler = new(this, "m_DownloadHandler");
					r_m_DownloadHandler.SetBelong(this.instance);
				}
				return r_m_DownloadHandler;
			}
		}

		/// <summary>
		/// UnityEngine.Networking.UploadHandler m_UploadHandler
		/// </summary>
		protected RUnityEngine.RNetworking.RUploadHandler r_m_UploadHandler;
		public virtual RUnityEngine.RNetworking.RUploadHandler Rm_UploadHandler
		{
			get
			{
				if(r_m_UploadHandler == null)
				{
					r_m_UploadHandler = new(this, "m_UploadHandler");
					r_m_UploadHandler.SetBelong(this.instance);
				}
				return r_m_UploadHandler;
			}
		}

		/// <summary>
		/// UnityEngine.Networking.CertificateHandler m_CertificateHandler
		/// </summary>
		protected RUnityEngine.RNetworking.RCertificateHandler r_m_CertificateHandler;
		public virtual RUnityEngine.RNetworking.RCertificateHandler Rm_CertificateHandler
		{
			get
			{
				if(r_m_CertificateHandler == null)
				{
					r_m_CertificateHandler = new(this, "m_CertificateHandler");
					r_m_CertificateHandler.SetBelong(this.instance);
				}
				return r_m_CertificateHandler;
			}
		}

		/// <summary>
		/// System.Uri m_Uri
		/// </summary>
		protected RSystem.RUri r_m_Uri;
		public virtual RSystem.RUri Rm_Uri
		{
			get
			{
				if(r_m_Uri == null)
				{
					r_m_Uri = new(this, "m_Uri");
					r_m_Uri.SetBelong(this.instance);
				}
				return r_m_Uri;
			}
		}

		/// <summary>
		/// System.String kHttpVerbGET
		/// </summary>
		protected static RField r_kHttpVerbGET;
		public static RField RkHttpVerbGET
		{
			get
			{
				if(r_kHttpVerbGET == null)
				{
					r_kHttpVerbGET = new(typeof(UnityEngine.Networking.UnityWebRequest), "kHttpVerbGET");
					r_kHttpVerbGET.SetBelong(null);
				}
				return r_kHttpVerbGET;
			}
		}

		/// <summary>
		/// System.String kHttpVerbHEAD
		/// </summary>
		protected static RField r_kHttpVerbHEAD;
		public static RField RkHttpVerbHEAD
		{
			get
			{
				if(r_kHttpVerbHEAD == null)
				{
					r_kHttpVerbHEAD = new(typeof(UnityEngine.Networking.UnityWebRequest), "kHttpVerbHEAD");
					r_kHttpVerbHEAD.SetBelong(null);
				}
				return r_kHttpVerbHEAD;
			}
		}

		/// <summary>
		/// System.String kHttpVerbPOST
		/// </summary>
		protected static RField r_kHttpVerbPOST;
		public static RField RkHttpVerbPOST
		{
			get
			{
				if(r_kHttpVerbPOST == null)
				{
					r_kHttpVerbPOST = new(typeof(UnityEngine.Networking.UnityWebRequest), "kHttpVerbPOST");
					r_kHttpVerbPOST.SetBelong(null);
				}
				return r_kHttpVerbPOST;
			}
		}

		/// <summary>
		/// System.String kHttpVerbPUT
		/// </summary>
		protected static RField r_kHttpVerbPUT;
		public static RField RkHttpVerbPUT
		{
			get
			{
				if(r_kHttpVerbPUT == null)
				{
					r_kHttpVerbPUT = new(typeof(UnityEngine.Networking.UnityWebRequest), "kHttpVerbPUT");
					r_kHttpVerbPUT.SetBelong(null);
				}
				return r_kHttpVerbPUT;
			}
		}

		/// <summary>
		/// System.String kHttpVerbCREATE
		/// </summary>
		protected static RField r_kHttpVerbCREATE;
		public static RField RkHttpVerbCREATE
		{
			get
			{
				if(r_kHttpVerbCREATE == null)
				{
					r_kHttpVerbCREATE = new(typeof(UnityEngine.Networking.UnityWebRequest), "kHttpVerbCREATE");
					r_kHttpVerbCREATE.SetBelong(null);
				}
				return r_kHttpVerbCREATE;
			}
		}

		/// <summary>
		/// System.String kHttpVerbDELETE
		/// </summary>
		protected static RField r_kHttpVerbDELETE;
		public static RField RkHttpVerbDELETE
		{
			get
			{
				if(r_kHttpVerbDELETE == null)
				{
					r_kHttpVerbDELETE = new(typeof(UnityEngine.Networking.UnityWebRequest), "kHttpVerbDELETE");
					r_kHttpVerbDELETE.SetBelong(null);
				}
				return r_kHttpVerbDELETE;
			}
		}

		/// <summary>
		/// System.Boolean <disposeCertificateHandlerOnDispose>k__BackingField
		/// </summary>
		protected RField r___2__disposeCertificateHandlerOnDispose__4__k__BackingField;
		public virtual RField R__2__disposeCertificateHandlerOnDispose__4__k__BackingField
		{
			get
			{
				if(r___2__disposeCertificateHandlerOnDispose__4__k__BackingField == null)
				{
					r___2__disposeCertificateHandlerOnDispose__4__k__BackingField = new(this, "<disposeCertificateHandlerOnDispose>k__BackingField");
					r___2__disposeCertificateHandlerOnDispose__4__k__BackingField.SetBelong(this.instance);
				}
				return r___2__disposeCertificateHandlerOnDispose__4__k__BackingField;
			}
		}

		/// <summary>
		/// System.Boolean <disposeDownloadHandlerOnDispose>k__BackingField
		/// </summary>
		protected RField r___2__disposeDownloadHandlerOnDispose__4__k__BackingField;
		public virtual RField R__2__disposeDownloadHandlerOnDispose__4__k__BackingField
		{
			get
			{
				if(r___2__disposeDownloadHandlerOnDispose__4__k__BackingField == null)
				{
					r___2__disposeDownloadHandlerOnDispose__4__k__BackingField = new(this, "<disposeDownloadHandlerOnDispose>k__BackingField");
					r___2__disposeDownloadHandlerOnDispose__4__k__BackingField.SetBelong(this.instance);
				}
				return r___2__disposeDownloadHandlerOnDispose__4__k__BackingField;
			}
		}

		/// <summary>
		/// System.Boolean <disposeUploadHandlerOnDispose>k__BackingField
		/// </summary>
		protected RField r___2__disposeUploadHandlerOnDispose__4__k__BackingField;
		public virtual RField R__2__disposeUploadHandlerOnDispose__4__k__BackingField
		{
			get
			{
				if(r___2__disposeUploadHandlerOnDispose__4__k__BackingField == null)
				{
					r___2__disposeUploadHandlerOnDispose__4__k__BackingField = new(this, "<disposeUploadHandlerOnDispose>k__BackingField");
					r___2__disposeUploadHandlerOnDispose__4__k__BackingField.SetBelong(this.instance);
				}
				return r___2__disposeUploadHandlerOnDispose__4__k__BackingField;
			}
		}

		/// <summary>
		/// Boolean disposeCertificateHandlerOnDispose
		/// </summary>
		protected RProperty r_disposeCertificateHandlerOnDispose;
		public virtual RProperty RdisposeCertificateHandlerOnDispose
		{
			get
			{
				if(r_disposeCertificateHandlerOnDispose == null)
				{
					r_disposeCertificateHandlerOnDispose = new(this, "disposeCertificateHandlerOnDispose", -1);
					r_disposeCertificateHandlerOnDispose.SetBelong(this.instance);
				}
				return r_disposeCertificateHandlerOnDispose;
			}
		}

		/// <summary>
		/// Boolean disposeDownloadHandlerOnDispose
		/// </summary>
		protected RProperty r_disposeDownloadHandlerOnDispose;
		public virtual RProperty RdisposeDownloadHandlerOnDispose
		{
			get
			{
				if(r_disposeDownloadHandlerOnDispose == null)
				{
					r_disposeDownloadHandlerOnDispose = new(this, "disposeDownloadHandlerOnDispose", -1);
					r_disposeDownloadHandlerOnDispose.SetBelong(this.instance);
				}
				return r_disposeDownloadHandlerOnDispose;
			}
		}

		/// <summary>
		/// Boolean disposeUploadHandlerOnDispose
		/// </summary>
		protected RProperty r_disposeUploadHandlerOnDispose;
		public virtual RProperty RdisposeUploadHandlerOnDispose
		{
			get
			{
				if(r_disposeUploadHandlerOnDispose == null)
				{
					r_disposeUploadHandlerOnDispose = new(this, "disposeUploadHandlerOnDispose", -1);
					r_disposeUploadHandlerOnDispose.SetBelong(this.instance);
				}
				return r_disposeUploadHandlerOnDispose;
			}
		}

		/// <summary>
		/// System.String method
		/// </summary>
		protected RProperty r_method;
		public virtual RProperty Rmethod
		{
			get
			{
				if(r_method == null)
				{
					r_method = new(this, "method", -1);
					r_method.SetBelong(this.instance);
				}
				return r_method;
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
		/// Boolean use100Continue
		/// </summary>
		protected RProperty r_use100Continue;
		public virtual RProperty Ruse100Continue
		{
			get
			{
				if(r_use100Continue == null)
				{
					r_use100Continue = new(this, "use100Continue", -1);
					r_use100Continue.SetBelong(this.instance);
				}
				return r_use100Continue;
			}
		}

		/// <summary>
		/// Boolean useHttpContinue
		/// </summary>
		protected RProperty r_useHttpContinue;
		public virtual RProperty RuseHttpContinue
		{
			get
			{
				if(r_useHttpContinue == null)
				{
					r_useHttpContinue = new(this, "useHttpContinue", -1);
					r_useHttpContinue.SetBelong(this.instance);
				}
				return r_useHttpContinue;
			}
		}

		/// <summary>
		/// System.String url
		/// </summary>
		protected RProperty r_url;
		public virtual RProperty Rurl
		{
			get
			{
				if(r_url == null)
				{
					r_url = new(this, "url", -1);
					r_url.SetBelong(this.instance);
				}
				return r_url;
			}
		}

		/// <summary>
		/// System.Uri uri
		/// </summary>
		protected RSystem.RUri r_uri;
		public virtual RSystem.RUri Ruri
		{
			get
			{
				if(r_uri == null)
				{
					r_uri = new(this, "uri", -1);
					r_uri.SetBelong(this.instance);
				}
				return r_uri;
			}
		}

		/// <summary>
		/// Int64 responseCode
		/// </summary>
		protected RProperty r_responseCode;
		public virtual RProperty RresponseCode
		{
			get
			{
				if(r_responseCode == null)
				{
					r_responseCode = new(this, "responseCode", -1);
					r_responseCode.SetBelong(this.instance);
				}
				return r_responseCode;
			}
		}

		/// <summary>
		/// Single uploadProgress
		/// </summary>
		protected RProperty r_uploadProgress;
		public virtual RProperty RuploadProgress
		{
			get
			{
				if(r_uploadProgress == null)
				{
					r_uploadProgress = new(this, "uploadProgress", -1);
					r_uploadProgress.SetBelong(this.instance);
				}
				return r_uploadProgress;
			}
		}

		/// <summary>
		/// Boolean isModifiable
		/// </summary>
		protected RProperty r_isModifiable;
		public virtual RProperty RisModifiable
		{
			get
			{
				if(r_isModifiable == null)
				{
					r_isModifiable = new(this, "isModifiable", -1);
					r_isModifiable.SetBelong(this.instance);
				}
				return r_isModifiable;
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
		/// Boolean isNetworkError
		/// </summary>
		protected RProperty r_isNetworkError;
		public virtual RProperty RisNetworkError
		{
			get
			{
				if(r_isNetworkError == null)
				{
					r_isNetworkError = new(this, "isNetworkError", -1);
					r_isNetworkError.SetBelong(this.instance);
				}
				return r_isNetworkError;
			}
		}

		/// <summary>
		/// Boolean isHttpError
		/// </summary>
		protected RProperty r_isHttpError;
		public virtual RProperty RisHttpError
		{
			get
			{
				if(r_isHttpError == null)
				{
					r_isHttpError = new(this, "isHttpError", -1);
					r_isHttpError.SetBelong(this.instance);
				}
				return r_isHttpError;
			}
		}

		/// <summary>
		/// Result result
		/// </summary>
		protected RProperty r_result;
		public virtual RProperty Rresult
		{
			get
			{
				if(r_result == null)
				{
					r_result = new(this, "result", -1);
					r_result.SetBelong(this.instance);
				}
				return r_result;
			}
		}

		/// <summary>
		/// Single downloadProgress
		/// </summary>
		protected RProperty r_downloadProgress;
		public virtual RProperty RdownloadProgress
		{
			get
			{
				if(r_downloadProgress == null)
				{
					r_downloadProgress = new(this, "downloadProgress", -1);
					r_downloadProgress.SetBelong(this.instance);
				}
				return r_downloadProgress;
			}
		}

		/// <summary>
		/// UInt64 uploadedBytes
		/// </summary>
		protected RProperty r_uploadedBytes;
		public virtual RProperty RuploadedBytes
		{
			get
			{
				if(r_uploadedBytes == null)
				{
					r_uploadedBytes = new(this, "uploadedBytes", -1);
					r_uploadedBytes.SetBelong(this.instance);
				}
				return r_uploadedBytes;
			}
		}

		/// <summary>
		/// UInt64 downloadedBytes
		/// </summary>
		protected RProperty r_downloadedBytes;
		public virtual RProperty RdownloadedBytes
		{
			get
			{
				if(r_downloadedBytes == null)
				{
					r_downloadedBytes = new(this, "downloadedBytes", -1);
					r_downloadedBytes.SetBelong(this.instance);
				}
				return r_downloadedBytes;
			}
		}

		/// <summary>
		/// Int32 redirectLimit
		/// </summary>
		protected RProperty r_redirectLimit;
		public virtual RProperty RredirectLimit
		{
			get
			{
				if(r_redirectLimit == null)
				{
					r_redirectLimit = new(this, "redirectLimit", -1);
					r_redirectLimit.SetBelong(this.instance);
				}
				return r_redirectLimit;
			}
		}

		/// <summary>
		/// Boolean chunkedTransfer
		/// </summary>
		protected RProperty r_chunkedTransfer;
		public virtual RProperty RchunkedTransfer
		{
			get
			{
				if(r_chunkedTransfer == null)
				{
					r_chunkedTransfer = new(this, "chunkedTransfer", -1);
					r_chunkedTransfer.SetBelong(this.instance);
				}
				return r_chunkedTransfer;
			}
		}

		/// <summary>
		/// UnityEngine.Networking.UploadHandler uploadHandler
		/// </summary>
		protected RUnityEngine.RNetworking.RUploadHandler r_uploadHandler;
		public virtual RUnityEngine.RNetworking.RUploadHandler RuploadHandler
		{
			get
			{
				if(r_uploadHandler == null)
				{
					r_uploadHandler = new(this, "uploadHandler", -1);
					r_uploadHandler.SetBelong(this.instance);
				}
				return r_uploadHandler;
			}
		}

		/// <summary>
		/// UnityEngine.Networking.DownloadHandler downloadHandler
		/// </summary>
		protected RUnityEngine.RNetworking.RDownloadHandler r_downloadHandler;
		public virtual RUnityEngine.RNetworking.RDownloadHandler RdownloadHandler
		{
			get
			{
				if(r_downloadHandler == null)
				{
					r_downloadHandler = new(this, "downloadHandler", -1);
					r_downloadHandler.SetBelong(this.instance);
				}
				return r_downloadHandler;
			}
		}

		/// <summary>
		/// UnityEngine.Networking.CertificateHandler certificateHandler
		/// </summary>
		protected RUnityEngine.RNetworking.RCertificateHandler r_certificateHandler;
		public virtual RUnityEngine.RNetworking.RCertificateHandler RcertificateHandler
		{
			get
			{
				if(r_certificateHandler == null)
				{
					r_certificateHandler = new(this, "certificateHandler", -1);
					r_certificateHandler.SetBelong(this.instance);
				}
				return r_certificateHandler;
			}
		}

		/// <summary>
		/// Int32 timeout
		/// </summary>
		protected RProperty r_timeout;
		public virtual RProperty Rtimeout
		{
			get
			{
				if(r_timeout == null)
				{
					r_timeout = new(this, "timeout", -1);
					r_timeout.SetBelong(this.instance);
				}
				return r_timeout;
			}
		}

		/// <summary>
		/// Boolean suppressErrorsToConsole
		/// </summary>
		protected RProperty r_suppressErrorsToConsole;
		public virtual RProperty RsuppressErrorsToConsole
		{
			get
			{
				if(r_suppressErrorsToConsole == null)
				{
					r_suppressErrorsToConsole = new(this, "suppressErrorsToConsole", -1);
					r_suppressErrorsToConsole.SetBelong(this.instance);
				}
				return r_suppressErrorsToConsole;
			}
		}

		/// <summary>
		/// Boolean isError
		/// </summary>
		protected RProperty r_isError;
		public virtual RProperty RisError
		{
			get
			{
				if(r_isError == null)
				{
					r_isError = new(this, "isError", -1);
					r_isError.SetBelong(this.instance);
				}
				return r_isError;
			}
		}

		/// <summary>
		/// System.String GetWebErrorString(UnityWebRequestError)
		/// </summary>
		protected static RMethod r_RGetWebErrorString_UnityWebRequestError;
		public static RMethod RGetWebErrorString_UnityWebRequestError
		{
			get
			{
				if(r_RGetWebErrorString_UnityWebRequestError == null)
				{
					r_RGetWebErrorString_UnityWebRequestError = new(typeof(UnityEngine.Networking.UnityWebRequest), "GetWebErrorString", 0,  ReleactionUtils.GetType("UnityEngine.Networking.UnityWebRequest+UnityWebRequestError"));
					r_RGetWebErrorString_UnityWebRequestError.SetBelong(null);
				}
				return r_RGetWebErrorString_UnityWebRequestError;
			}
		}

		/// <summary>
		/// System.String GetHTTPStatusString(Int64)
		/// </summary>
		protected static RMethod r_RGetHTTPStatusString_Int64;
		public static RMethod RGetHTTPStatusString_Int64
		{
			get
			{
				if(r_RGetHTTPStatusString_Int64 == null)
				{
					r_RGetHTTPStatusString_Int64 = new(typeof(UnityEngine.Networking.UnityWebRequest), "GetHTTPStatusString", 0, typeof(System.Int64));
					r_RGetHTTPStatusString_Int64.SetBelong(null);
				}
				return r_RGetHTTPStatusString_Int64;
			}
		}

		/// <summary>
		/// Void ClearCookieCache()
		/// </summary>
		protected static RMethod r_RClearCookieCache;
		public static RMethod RClearCookieCache
		{
			get
			{
				if(r_RClearCookieCache == null)
				{
					r_RClearCookieCache = new(typeof(UnityEngine.Networking.UnityWebRequest), "ClearCookieCache", 0);
					r_RClearCookieCache.SetBelong(null);
				}
				return r_RClearCookieCache;
			}
		}

		/// <summary>
		/// Void ClearCookieCache(System.Uri)
		/// </summary>
		protected static RMethod r_RClearCookieCache_Uri;
		public static RMethod RClearCookieCache_Uri
		{
			get
			{
				if(r_RClearCookieCache_Uri == null)
				{
					r_RClearCookieCache_Uri = new(typeof(UnityEngine.Networking.UnityWebRequest), "ClearCookieCache", 0, typeof(System.Uri));
					r_RClearCookieCache_Uri.SetBelong(null);
				}
				return r_RClearCookieCache_Uri;
			}
		}

		/// <summary>
		/// Void ClearCookieCache(System.String, System.String)
		/// </summary>
		protected static RMethod r_RClearCookieCache_String_String;
		public static RMethod RClearCookieCache_String_String
		{
			get
			{
				if(r_RClearCookieCache_String_String == null)
				{
					r_RClearCookieCache_String_String = new(typeof(UnityEngine.Networking.UnityWebRequest), "ClearCookieCache", 0, typeof(System.String), typeof(System.String));
					r_RClearCookieCache_String_String.SetBelong(null);
				}
				return r_RClearCookieCache_String_String;
			}
		}

		/// <summary>
		/// IntPtr Create()
		/// </summary>
		protected static RMethod r_RCreate;
		public static RMethod RCreate
		{
			get
			{
				if(r_RCreate == null)
				{
					r_RCreate = new(typeof(UnityEngine.Networking.UnityWebRequest), "Create", 0);
					r_RCreate.SetBelong(null);
				}
				return r_RCreate;
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
		/// Void InternalDestroy()
		/// </summary>
		protected RMethod r_RInternalDestroy;
		public virtual RMethod RInternalDestroy
		{
			get
			{
				if(r_RInternalDestroy == null)
				{
					r_RInternalDestroy = new(this, "InternalDestroy", 0);
					r_RInternalDestroy.SetBelong(this.instance);
				}
				return r_RInternalDestroy;
			}
		}

		/// <summary>
		/// Void InternalSetDefaults()
		/// </summary>
		protected RMethod r_RInternalSetDefaults;
		public virtual RMethod RInternalSetDefaults
		{
			get
			{
				if(r_RInternalSetDefaults == null)
				{
					r_RInternalSetDefaults = new(this, "InternalSetDefaults", 0);
					r_RInternalSetDefaults.SetBelong(this.instance);
				}
				return r_RInternalSetDefaults;
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
		/// Void DisposeHandlers()
		/// </summary>
		protected RMethod r_RDisposeHandlers;
		public virtual RMethod RDisposeHandlers
		{
			get
			{
				if(r_RDisposeHandlers == null)
				{
					r_RDisposeHandlers = new(this, "DisposeHandlers", 0);
					r_RDisposeHandlers.SetBelong(this.instance);
				}
				return r_RDisposeHandlers;
			}
		}

		/// <summary>
		/// UnityEngine.Networking.UnityWebRequestAsyncOperation BeginWebRequest()
		/// </summary>
		protected RMethod r_RBeginWebRequest;
		public virtual RMethod RBeginWebRequest
		{
			get
			{
				if(r_RBeginWebRequest == null)
				{
					r_RBeginWebRequest = new(this, "BeginWebRequest", 0);
					r_RBeginWebRequest.SetBelong(this.instance);
				}
				return r_RBeginWebRequest;
			}
		}

		/// <summary>
		/// UnityEngine.AsyncOperation Send()
		/// </summary>
		protected RMethod r_RSend;
		public virtual RMethod RSend
		{
			get
			{
				if(r_RSend == null)
				{
					r_RSend = new(this, "Send", 0);
					r_RSend.SetBelong(this.instance);
				}
				return r_RSend;
			}
		}

		/// <summary>
		/// UnityEngine.Networking.UnityWebRequestAsyncOperation SendWebRequest()
		/// </summary>
		protected RMethod r_RSendWebRequest;
		public virtual RMethod RSendWebRequest
		{
			get
			{
				if(r_RSendWebRequest == null)
				{
					r_RSendWebRequest = new(this, "SendWebRequest", 0);
					r_RSendWebRequest.SetBelong(this.instance);
				}
				return r_RSendWebRequest;
			}
		}

		/// <summary>
		/// Void Abort()
		/// </summary>
		protected RMethod r_RAbort;
		public virtual RMethod RAbort
		{
			get
			{
				if(r_RAbort == null)
				{
					r_RAbort = new(this, "Abort", 0);
					r_RAbort.SetBelong(this.instance);
				}
				return r_RAbort;
			}
		}

		/// <summary>
		/// UnityWebRequestError SetMethod(UnityWebRequestMethod)
		/// </summary>
		protected RMethod r_RSetMethod_UnityWebRequestMethod;
		public virtual RMethod RSetMethod_UnityWebRequestMethod
		{
			get
			{
				if(r_RSetMethod_UnityWebRequestMethod == null)
				{
					r_RSetMethod_UnityWebRequestMethod = new(this, "SetMethod", 0,  ReleactionUtils.GetType("UnityEngine.Networking.UnityWebRequest+UnityWebRequestMethod"));
					r_RSetMethod_UnityWebRequestMethod.SetBelong(this.instance);
				}
				return r_RSetMethod_UnityWebRequestMethod;
			}
		}

		/// <summary>
		/// Void InternalSetMethod(UnityWebRequestMethod)
		/// </summary>
		protected RMethod r_RInternalSetMethod_UnityWebRequestMethod;
		public virtual RMethod RInternalSetMethod_UnityWebRequestMethod
		{
			get
			{
				if(r_RInternalSetMethod_UnityWebRequestMethod == null)
				{
					r_RInternalSetMethod_UnityWebRequestMethod = new(this, "InternalSetMethod", 0,  ReleactionUtils.GetType("UnityEngine.Networking.UnityWebRequest+UnityWebRequestMethod"));
					r_RInternalSetMethod_UnityWebRequestMethod.SetBelong(this.instance);
				}
				return r_RInternalSetMethod_UnityWebRequestMethod;
			}
		}

		/// <summary>
		/// UnityWebRequestError SetCustomMethod(System.String)
		/// </summary>
		protected RMethod r_RSetCustomMethod_String;
		public virtual RMethod RSetCustomMethod_String
		{
			get
			{
				if(r_RSetCustomMethod_String == null)
				{
					r_RSetCustomMethod_String = new(this, "SetCustomMethod", 0, typeof(System.String));
					r_RSetCustomMethod_String.SetBelong(this.instance);
				}
				return r_RSetCustomMethod_String;
			}
		}

		/// <summary>
		/// Void InternalSetCustomMethod(System.String)
		/// </summary>
		protected RMethod r_RInternalSetCustomMethod_String;
		public virtual RMethod RInternalSetCustomMethod_String
		{
			get
			{
				if(r_RInternalSetCustomMethod_String == null)
				{
					r_RInternalSetCustomMethod_String = new(this, "InternalSetCustomMethod", 0, typeof(System.String));
					r_RInternalSetCustomMethod_String.SetBelong(this.instance);
				}
				return r_RInternalSetCustomMethod_String;
			}
		}

		/// <summary>
		/// UnityWebRequestMethod GetMethod()
		/// </summary>
		protected RMethod r_RGetMethod;
		public virtual RMethod RGetMethod
		{
			get
			{
				if(r_RGetMethod == null)
				{
					r_RGetMethod = new(this, "GetMethod", 0);
					r_RGetMethod.SetBelong(this.instance);
				}
				return r_RGetMethod;
			}
		}

		/// <summary>
		/// System.String GetCustomMethod()
		/// </summary>
		protected RMethod r_RGetCustomMethod;
		public virtual RMethod RGetCustomMethod
		{
			get
			{
				if(r_RGetCustomMethod == null)
				{
					r_RGetCustomMethod = new(this, "GetCustomMethod", 0);
					r_RGetCustomMethod.SetBelong(this.instance);
				}
				return r_RGetCustomMethod;
			}
		}

		/// <summary>
		/// UnityWebRequestError GetError()
		/// </summary>
		protected RMethod r_RGetError;
		public virtual RMethod RGetError
		{
			get
			{
				if(r_RGetError == null)
				{
					r_RGetError = new(this, "GetError", 0);
					r_RGetError.SetBelong(this.instance);
				}
				return r_RGetError;
			}
		}

		/// <summary>
		/// System.String GetUrl()
		/// </summary>
		protected RMethod r_RGetUrl;
		public virtual RMethod RGetUrl
		{
			get
			{
				if(r_RGetUrl == null)
				{
					r_RGetUrl = new(this, "GetUrl", 0);
					r_RGetUrl.SetBelong(this.instance);
				}
				return r_RGetUrl;
			}
		}

		/// <summary>
		/// UnityWebRequestError SetUrl(System.String)
		/// </summary>
		protected RMethod r_RSetUrl_String;
		public virtual RMethod RSetUrl_String
		{
			get
			{
				if(r_RSetUrl_String == null)
				{
					r_RSetUrl_String = new(this, "SetUrl", 0, typeof(System.String));
					r_RSetUrl_String.SetBelong(this.instance);
				}
				return r_RSetUrl_String;
			}
		}

		/// <summary>
		/// Void InternalSetUrl(System.String)
		/// </summary>
		protected RMethod r_RInternalSetUrl_String;
		public virtual RMethod RInternalSetUrl_String
		{
			get
			{
				if(r_RInternalSetUrl_String == null)
				{
					r_RInternalSetUrl_String = new(this, "InternalSetUrl", 0, typeof(System.String));
					r_RInternalSetUrl_String.SetBelong(this.instance);
				}
				return r_RInternalSetUrl_String;
			}
		}

		/// <summary>
		/// Single GetUploadProgress()
		/// </summary>
		protected RMethod r_RGetUploadProgress;
		public virtual RMethod RGetUploadProgress
		{
			get
			{
				if(r_RGetUploadProgress == null)
				{
					r_RGetUploadProgress = new(this, "GetUploadProgress", 0);
					r_RGetUploadProgress.SetBelong(this.instance);
				}
				return r_RGetUploadProgress;
			}
		}

		/// <summary>
		/// Boolean IsExecuting()
		/// </summary>
		protected RMethod r_RIsExecuting;
		public virtual RMethod RIsExecuting
		{
			get
			{
				if(r_RIsExecuting == null)
				{
					r_RIsExecuting = new(this, "IsExecuting", 0);
					r_RIsExecuting.SetBelong(this.instance);
				}
				return r_RIsExecuting;
			}
		}

		/// <summary>
		/// Single GetDownloadProgress()
		/// </summary>
		protected RMethod r_RGetDownloadProgress;
		public virtual RMethod RGetDownloadProgress
		{
			get
			{
				if(r_RGetDownloadProgress == null)
				{
					r_RGetDownloadProgress = new(this, "GetDownloadProgress", 0);
					r_RGetDownloadProgress.SetBelong(this.instance);
				}
				return r_RGetDownloadProgress;
			}
		}

		/// <summary>
		/// Int32 GetRedirectLimit()
		/// </summary>
		protected RMethod r_RGetRedirectLimit;
		public virtual RMethod RGetRedirectLimit
		{
			get
			{
				if(r_RGetRedirectLimit == null)
				{
					r_RGetRedirectLimit = new(this, "GetRedirectLimit", 0);
					r_RGetRedirectLimit.SetBelong(this.instance);
				}
				return r_RGetRedirectLimit;
			}
		}

		/// <summary>
		/// Void SetRedirectLimitFromScripting(Int32)
		/// </summary>
		protected RMethod r_RSetRedirectLimitFromScripting_Int32;
		public virtual RMethod RSetRedirectLimitFromScripting_Int32
		{
			get
			{
				if(r_RSetRedirectLimitFromScripting_Int32 == null)
				{
					r_RSetRedirectLimitFromScripting_Int32 = new(this, "SetRedirectLimitFromScripting", 0, typeof(System.Int32));
					r_RSetRedirectLimitFromScripting_Int32.SetBelong(this.instance);
				}
				return r_RSetRedirectLimitFromScripting_Int32;
			}
		}

		/// <summary>
		/// Boolean GetChunked()
		/// </summary>
		protected RMethod r_RGetChunked;
		public virtual RMethod RGetChunked
		{
			get
			{
				if(r_RGetChunked == null)
				{
					r_RGetChunked = new(this, "GetChunked", 0);
					r_RGetChunked.SetBelong(this.instance);
				}
				return r_RGetChunked;
			}
		}

		/// <summary>
		/// UnityWebRequestError SetChunked(Boolean)
		/// </summary>
		protected RMethod r_RSetChunked_Boolean;
		public virtual RMethod RSetChunked_Boolean
		{
			get
			{
				if(r_RSetChunked_Boolean == null)
				{
					r_RSetChunked_Boolean = new(this, "SetChunked", 0, typeof(System.Boolean));
					r_RSetChunked_Boolean.SetBelong(this.instance);
				}
				return r_RSetChunked_Boolean;
			}
		}

		/// <summary>
		/// System.String GetRequestHeader(System.String)
		/// </summary>
		protected RMethod r_RGetRequestHeader_String;
		public virtual RMethod RGetRequestHeader_String
		{
			get
			{
				if(r_RGetRequestHeader_String == null)
				{
					r_RGetRequestHeader_String = new(this, "GetRequestHeader", 0, typeof(System.String));
					r_RGetRequestHeader_String.SetBelong(this.instance);
				}
				return r_RGetRequestHeader_String;
			}
		}

		/// <summary>
		/// UnityWebRequestError InternalSetRequestHeader(System.String, System.String)
		/// </summary>
		protected RMethod r_RInternalSetRequestHeader_String_String;
		public virtual RMethod RInternalSetRequestHeader_String_String
		{
			get
			{
				if(r_RInternalSetRequestHeader_String_String == null)
				{
					r_RInternalSetRequestHeader_String_String = new(this, "InternalSetRequestHeader", 0, typeof(System.String), typeof(System.String));
					r_RInternalSetRequestHeader_String_String.SetBelong(this.instance);
				}
				return r_RInternalSetRequestHeader_String_String;
			}
		}

		/// <summary>
		/// Void SetRequestHeader(System.String, System.String)
		/// </summary>
		protected RMethod r_RSetRequestHeader_String_String;
		public virtual RMethod RSetRequestHeader_String_String
		{
			get
			{
				if(r_RSetRequestHeader_String_String == null)
				{
					r_RSetRequestHeader_String_String = new(this, "SetRequestHeader", 0, typeof(System.String), typeof(System.String));
					r_RSetRequestHeader_String_String.SetBelong(this.instance);
				}
				return r_RSetRequestHeader_String_String;
			}
		}

		/// <summary>
		/// System.String GetResponseHeader(System.String)
		/// </summary>
		protected RMethod r_RGetResponseHeader_String;
		public virtual RMethod RGetResponseHeader_String
		{
			get
			{
				if(r_RGetResponseHeader_String == null)
				{
					r_RGetResponseHeader_String = new(this, "GetResponseHeader", 0, typeof(System.String));
					r_RGetResponseHeader_String.SetBelong(this.instance);
				}
				return r_RGetResponseHeader_String;
			}
		}

		/// <summary>
		/// System.String[] GetResponseHeaderKeys()
		/// </summary>
		protected RMethod r_RGetResponseHeaderKeys;
		public virtual RMethod RGetResponseHeaderKeys
		{
			get
			{
				if(r_RGetResponseHeaderKeys == null)
				{
					r_RGetResponseHeaderKeys = new(this, "GetResponseHeaderKeys", 0);
					r_RGetResponseHeaderKeys.SetBelong(this.instance);
				}
				return r_RGetResponseHeaderKeys;
			}
		}

		/// <summary>
		/// System.Collections.Generic.Dictionary`2[System.String,System.String] GetResponseHeaders()
		/// </summary>
		protected RMethod r_RGetResponseHeaders;
		public virtual RMethod RGetResponseHeaders
		{
			get
			{
				if(r_RGetResponseHeaders == null)
				{
					r_RGetResponseHeaders = new(this, "GetResponseHeaders", 0);
					r_RGetResponseHeaders.SetBelong(this.instance);
				}
				return r_RGetResponseHeaders;
			}
		}

		/// <summary>
		/// UnityWebRequestError SetUploadHandler(UnityEngine.Networking.UploadHandler)
		/// </summary>
		protected RMethod r_RSetUploadHandler_UploadHandler;
		public virtual RMethod RSetUploadHandler_UploadHandler
		{
			get
			{
				if(r_RSetUploadHandler_UploadHandler == null)
				{
					r_RSetUploadHandler_UploadHandler = new(this, "SetUploadHandler", 0, typeof(UnityEngine.Networking.UploadHandler));
					r_RSetUploadHandler_UploadHandler.SetBelong(this.instance);
				}
				return r_RSetUploadHandler_UploadHandler;
			}
		}

		/// <summary>
		/// UnityWebRequestError SetDownloadHandler(UnityEngine.Networking.DownloadHandler)
		/// </summary>
		protected RMethod r_RSetDownloadHandler_DownloadHandler;
		public virtual RMethod RSetDownloadHandler_DownloadHandler
		{
			get
			{
				if(r_RSetDownloadHandler_DownloadHandler == null)
				{
					r_RSetDownloadHandler_DownloadHandler = new(this, "SetDownloadHandler", 0, typeof(UnityEngine.Networking.DownloadHandler));
					r_RSetDownloadHandler_DownloadHandler.SetBelong(this.instance);
				}
				return r_RSetDownloadHandler_DownloadHandler;
			}
		}

		/// <summary>
		/// UnityWebRequestError SetCertificateHandler(UnityEngine.Networking.CertificateHandler)
		/// </summary>
		protected RMethod r_RSetCertificateHandler_CertificateHandler;
		public virtual RMethod RSetCertificateHandler_CertificateHandler
		{
			get
			{
				if(r_RSetCertificateHandler_CertificateHandler == null)
				{
					r_RSetCertificateHandler_CertificateHandler = new(this, "SetCertificateHandler", 0, typeof(UnityEngine.Networking.CertificateHandler));
					r_RSetCertificateHandler_CertificateHandler.SetBelong(this.instance);
				}
				return r_RSetCertificateHandler_CertificateHandler;
			}
		}

		/// <summary>
		/// Int32 GetTimeoutMsec()
		/// </summary>
		protected RMethod r_RGetTimeoutMsec;
		public virtual RMethod RGetTimeoutMsec
		{
			get
			{
				if(r_RGetTimeoutMsec == null)
				{
					r_RGetTimeoutMsec = new(this, "GetTimeoutMsec", 0);
					r_RGetTimeoutMsec.SetBelong(this.instance);
				}
				return r_RGetTimeoutMsec;
			}
		}

		/// <summary>
		/// UnityWebRequestError SetTimeoutMsec(Int32)
		/// </summary>
		protected RMethod r_RSetTimeoutMsec_Int32;
		public virtual RMethod RSetTimeoutMsec_Int32
		{
			get
			{
				if(r_RSetTimeoutMsec_Int32 == null)
				{
					r_RSetTimeoutMsec_Int32 = new(this, "SetTimeoutMsec", 0, typeof(System.Int32));
					r_RSetTimeoutMsec_Int32.SetBelong(this.instance);
				}
				return r_RSetTimeoutMsec_Int32;
			}
		}

		/// <summary>
		/// Boolean GetSuppressErrorsToConsole()
		/// </summary>
		protected RMethod r_RGetSuppressErrorsToConsole;
		public virtual RMethod RGetSuppressErrorsToConsole
		{
			get
			{
				if(r_RGetSuppressErrorsToConsole == null)
				{
					r_RGetSuppressErrorsToConsole = new(this, "GetSuppressErrorsToConsole", 0);
					r_RGetSuppressErrorsToConsole.SetBelong(this.instance);
				}
				return r_RGetSuppressErrorsToConsole;
			}
		}

		/// <summary>
		/// UnityWebRequestError SetSuppressErrorsToConsole(Boolean)
		/// </summary>
		protected RMethod r_RSetSuppressErrorsToConsole_Boolean;
		public virtual RMethod RSetSuppressErrorsToConsole_Boolean
		{
			get
			{
				if(r_RSetSuppressErrorsToConsole_Boolean == null)
				{
					r_RSetSuppressErrorsToConsole_Boolean = new(this, "SetSuppressErrorsToConsole", 0, typeof(System.Boolean));
					r_RSetSuppressErrorsToConsole_Boolean.SetBelong(this.instance);
				}
				return r_RSetSuppressErrorsToConsole_Boolean;
			}
		}

		/// <summary>
		/// UnityEngine.Networking.UnityWebRequest Get(System.String)
		/// </summary>
		protected static RMethod r_RGet_String;
		public static RMethod RGet_String
		{
			get
			{
				if(r_RGet_String == null)
				{
					r_RGet_String = new(typeof(UnityEngine.Networking.UnityWebRequest), "Get", 0, typeof(System.String));
					r_RGet_String.SetBelong(null);
				}
				return r_RGet_String;
			}
		}

		/// <summary>
		/// UnityEngine.Networking.UnityWebRequest Get(System.Uri)
		/// </summary>
		protected static RMethod r_RGet_Uri;
		public static RMethod RGet_Uri
		{
			get
			{
				if(r_RGet_Uri == null)
				{
					r_RGet_Uri = new(typeof(UnityEngine.Networking.UnityWebRequest), "Get", 0, typeof(System.Uri));
					r_RGet_Uri.SetBelong(null);
				}
				return r_RGet_Uri;
			}
		}

		/// <summary>
		/// UnityEngine.Networking.UnityWebRequest Delete(System.String)
		/// </summary>
		protected static RMethod r_RDelete_String;
		public static RMethod RDelete_String
		{
			get
			{
				if(r_RDelete_String == null)
				{
					r_RDelete_String = new(typeof(UnityEngine.Networking.UnityWebRequest), "Delete", 0, typeof(System.String));
					r_RDelete_String.SetBelong(null);
				}
				return r_RDelete_String;
			}
		}

		/// <summary>
		/// UnityEngine.Networking.UnityWebRequest Delete(System.Uri)
		/// </summary>
		protected static RMethod r_RDelete_Uri;
		public static RMethod RDelete_Uri
		{
			get
			{
				if(r_RDelete_Uri == null)
				{
					r_RDelete_Uri = new(typeof(UnityEngine.Networking.UnityWebRequest), "Delete", 0, typeof(System.Uri));
					r_RDelete_Uri.SetBelong(null);
				}
				return r_RDelete_Uri;
			}
		}

		/// <summary>
		/// UnityEngine.Networking.UnityWebRequest Head(System.String)
		/// </summary>
		protected static RMethod r_RHead_String;
		public static RMethod RHead_String
		{
			get
			{
				if(r_RHead_String == null)
				{
					r_RHead_String = new(typeof(UnityEngine.Networking.UnityWebRequest), "Head", 0, typeof(System.String));
					r_RHead_String.SetBelong(null);
				}
				return r_RHead_String;
			}
		}

		/// <summary>
		/// UnityEngine.Networking.UnityWebRequest Head(System.Uri)
		/// </summary>
		protected static RMethod r_RHead_Uri;
		public static RMethod RHead_Uri
		{
			get
			{
				if(r_RHead_Uri == null)
				{
					r_RHead_Uri = new(typeof(UnityEngine.Networking.UnityWebRequest), "Head", 0, typeof(System.Uri));
					r_RHead_Uri.SetBelong(null);
				}
				return r_RHead_Uri;
			}
		}

		/// <summary>
		/// UnityEngine.Networking.UnityWebRequest GetTexture(System.String)
		/// </summary>
		protected static RMethod r_RGetTexture_String;
		public static RMethod RGetTexture_String
		{
			get
			{
				if(r_RGetTexture_String == null)
				{
					r_RGetTexture_String = new(typeof(UnityEngine.Networking.UnityWebRequest), "GetTexture", 0, typeof(System.String));
					r_RGetTexture_String.SetBelong(null);
				}
				return r_RGetTexture_String;
			}
		}

		/// <summary>
		/// UnityEngine.Networking.UnityWebRequest GetTexture(System.String, Boolean)
		/// </summary>
		protected static RMethod r_RGetTexture_String_Boolean;
		public static RMethod RGetTexture_String_Boolean
		{
			get
			{
				if(r_RGetTexture_String_Boolean == null)
				{
					r_RGetTexture_String_Boolean = new(typeof(UnityEngine.Networking.UnityWebRequest), "GetTexture", 0, typeof(System.String), typeof(System.Boolean));
					r_RGetTexture_String_Boolean.SetBelong(null);
				}
				return r_RGetTexture_String_Boolean;
			}
		}

		/// <summary>
		/// UnityEngine.Networking.UnityWebRequest GetAudioClip(System.String, UnityEngine.AudioType)
		/// </summary>
		protected static RMethod r_RGetAudioClip_String_AudioType;
		public static RMethod RGetAudioClip_String_AudioType
		{
			get
			{
				if(r_RGetAudioClip_String_AudioType == null)
				{
					r_RGetAudioClip_String_AudioType = new(typeof(UnityEngine.Networking.UnityWebRequest), "GetAudioClip", 0, typeof(System.String), typeof(UnityEngine.AudioType));
					r_RGetAudioClip_String_AudioType.SetBelong(null);
				}
				return r_RGetAudioClip_String_AudioType;
			}
		}

		/// <summary>
		/// UnityEngine.Networking.UnityWebRequest GetAssetBundle(System.String)
		/// </summary>
		protected static RMethod r_RGetAssetBundle_String;
		public static RMethod RGetAssetBundle_String
		{
			get
			{
				if(r_RGetAssetBundle_String == null)
				{
					r_RGetAssetBundle_String = new(typeof(UnityEngine.Networking.UnityWebRequest), "GetAssetBundle", 0, typeof(System.String));
					r_RGetAssetBundle_String.SetBelong(null);
				}
				return r_RGetAssetBundle_String;
			}
		}

		/// <summary>
		/// UnityEngine.Networking.UnityWebRequest GetAssetBundle(System.String, UInt32)
		/// </summary>
		protected static RMethod r_RGetAssetBundle_String_UInt32;
		public static RMethod RGetAssetBundle_String_UInt32
		{
			get
			{
				if(r_RGetAssetBundle_String_UInt32 == null)
				{
					r_RGetAssetBundle_String_UInt32 = new(typeof(UnityEngine.Networking.UnityWebRequest), "GetAssetBundle", 0, typeof(System.String), typeof(System.UInt32));
					r_RGetAssetBundle_String_UInt32.SetBelong(null);
				}
				return r_RGetAssetBundle_String_UInt32;
			}
		}

		/// <summary>
		/// UnityEngine.Networking.UnityWebRequest GetAssetBundle(System.String, UInt32, UInt32)
		/// </summary>
		protected static RMethod r_RGetAssetBundle_String_UInt32_UInt32;
		public static RMethod RGetAssetBundle_String_UInt32_UInt32
		{
			get
			{
				if(r_RGetAssetBundle_String_UInt32_UInt32 == null)
				{
					r_RGetAssetBundle_String_UInt32_UInt32 = new(typeof(UnityEngine.Networking.UnityWebRequest), "GetAssetBundle", 0, typeof(System.String), typeof(System.UInt32), typeof(System.UInt32));
					r_RGetAssetBundle_String_UInt32_UInt32.SetBelong(null);
				}
				return r_RGetAssetBundle_String_UInt32_UInt32;
			}
		}

		/// <summary>
		/// UnityEngine.Networking.UnityWebRequest GetAssetBundle(System.String, UnityEngine.Hash128, UInt32)
		/// </summary>
		protected static RMethod r_RGetAssetBundle_String_Hash128_UInt32;
		public static RMethod RGetAssetBundle_String_Hash128_UInt32
		{
			get
			{
				if(r_RGetAssetBundle_String_Hash128_UInt32 == null)
				{
					r_RGetAssetBundle_String_Hash128_UInt32 = new(typeof(UnityEngine.Networking.UnityWebRequest), "GetAssetBundle", 0, typeof(System.String), typeof(UnityEngine.Hash128), typeof(System.UInt32));
					r_RGetAssetBundle_String_Hash128_UInt32.SetBelong(null);
				}
				return r_RGetAssetBundle_String_Hash128_UInt32;
			}
		}

		/// <summary>
		/// UnityEngine.Networking.UnityWebRequest GetAssetBundle(System.String, UnityEngine.CachedAssetBundle, UInt32)
		/// </summary>
		protected static RMethod r_RGetAssetBundle_String_CachedAssetBundle_UInt32;
		public static RMethod RGetAssetBundle_String_CachedAssetBundle_UInt32
		{
			get
			{
				if(r_RGetAssetBundle_String_CachedAssetBundle_UInt32 == null)
				{
					r_RGetAssetBundle_String_CachedAssetBundle_UInt32 = new(typeof(UnityEngine.Networking.UnityWebRequest), "GetAssetBundle", 0, typeof(System.String), typeof(UnityEngine.CachedAssetBundle), typeof(System.UInt32));
					r_RGetAssetBundle_String_CachedAssetBundle_UInt32.SetBelong(null);
				}
				return r_RGetAssetBundle_String_CachedAssetBundle_UInt32;
			}
		}

		/// <summary>
		/// UnityEngine.Networking.UnityWebRequest Put(System.String, Byte[])
		/// </summary>
		protected static RMethod r_RPut_String_ByteArray;
		public static RMethod RPut_String_ByteArray
		{
			get
			{
				if(r_RPut_String_ByteArray == null)
				{
					r_RPut_String_ByteArray = new(typeof(UnityEngine.Networking.UnityWebRequest), "Put", 0, typeof(System.String), typeof(System.Byte).MakeArrayType());
					r_RPut_String_ByteArray.SetBelong(null);
				}
				return r_RPut_String_ByteArray;
			}
		}

		/// <summary>
		/// UnityEngine.Networking.UnityWebRequest Put(System.Uri, Byte[])
		/// </summary>
		protected static RMethod r_RPut_Uri_ByteArray;
		public static RMethod RPut_Uri_ByteArray
		{
			get
			{
				if(r_RPut_Uri_ByteArray == null)
				{
					r_RPut_Uri_ByteArray = new(typeof(UnityEngine.Networking.UnityWebRequest), "Put", 0, typeof(System.Uri), typeof(System.Byte).MakeArrayType());
					r_RPut_Uri_ByteArray.SetBelong(null);
				}
				return r_RPut_Uri_ByteArray;
			}
		}

		/// <summary>
		/// UnityEngine.Networking.UnityWebRequest Put(System.String, System.String)
		/// </summary>
		protected static RMethod r_RPut_String_String;
		public static RMethod RPut_String_String
		{
			get
			{
				if(r_RPut_String_String == null)
				{
					r_RPut_String_String = new(typeof(UnityEngine.Networking.UnityWebRequest), "Put", 0, typeof(System.String), typeof(System.String));
					r_RPut_String_String.SetBelong(null);
				}
				return r_RPut_String_String;
			}
		}

		/// <summary>
		/// UnityEngine.Networking.UnityWebRequest Put(System.Uri, System.String)
		/// </summary>
		protected static RMethod r_RPut_Uri_String;
		public static RMethod RPut_Uri_String
		{
			get
			{
				if(r_RPut_Uri_String == null)
				{
					r_RPut_Uri_String = new(typeof(UnityEngine.Networking.UnityWebRequest), "Put", 0, typeof(System.Uri), typeof(System.String));
					r_RPut_Uri_String.SetBelong(null);
				}
				return r_RPut_Uri_String;
			}
		}

		/// <summary>
		/// UnityEngine.Networking.UnityWebRequest Post(System.String, System.String)
		/// </summary>
		protected static RMethod r_RPost_String_String;
		public static RMethod RPost_String_String
		{
			get
			{
				if(r_RPost_String_String == null)
				{
					r_RPost_String_String = new(typeof(UnityEngine.Networking.UnityWebRequest), "Post", 0, typeof(System.String), typeof(System.String));
					r_RPost_String_String.SetBelong(null);
				}
				return r_RPost_String_String;
			}
		}

		/// <summary>
		/// UnityEngine.Networking.UnityWebRequest Post(System.Uri, System.String)
		/// </summary>
		protected static RMethod r_RPost_Uri_String;
		public static RMethod RPost_Uri_String
		{
			get
			{
				if(r_RPost_Uri_String == null)
				{
					r_RPost_Uri_String = new(typeof(UnityEngine.Networking.UnityWebRequest), "Post", 0, typeof(System.Uri), typeof(System.String));
					r_RPost_Uri_String.SetBelong(null);
				}
				return r_RPost_Uri_String;
			}
		}

		/// <summary>
		/// UnityEngine.Networking.UnityWebRequest PostWwwForm(System.String, System.String)
		/// </summary>
		protected static RMethod r_RPostWwwForm_String_String;
		public static RMethod RPostWwwForm_String_String
		{
			get
			{
				if(r_RPostWwwForm_String_String == null)
				{
					r_RPostWwwForm_String_String = new(typeof(UnityEngine.Networking.UnityWebRequest), "PostWwwForm", 0, typeof(System.String), typeof(System.String));
					r_RPostWwwForm_String_String.SetBelong(null);
				}
				return r_RPostWwwForm_String_String;
			}
		}

		/// <summary>
		/// UnityEngine.Networking.UnityWebRequest PostWwwForm(System.Uri, System.String)
		/// </summary>
		protected static RMethod r_RPostWwwForm_Uri_String;
		public static RMethod RPostWwwForm_Uri_String
		{
			get
			{
				if(r_RPostWwwForm_Uri_String == null)
				{
					r_RPostWwwForm_Uri_String = new(typeof(UnityEngine.Networking.UnityWebRequest), "PostWwwForm", 0, typeof(System.Uri), typeof(System.String));
					r_RPostWwwForm_Uri_String.SetBelong(null);
				}
				return r_RPostWwwForm_Uri_String;
			}
		}

		/// <summary>
		/// Void SetupPostWwwForm(UnityEngine.Networking.UnityWebRequest, System.String)
		/// </summary>
		protected static RMethod r_RSetupPostWwwForm_UnityWebRequest_String;
		public static RMethod RSetupPostWwwForm_UnityWebRequest_String
		{
			get
			{
				if(r_RSetupPostWwwForm_UnityWebRequest_String == null)
				{
					r_RSetupPostWwwForm_UnityWebRequest_String = new(typeof(UnityEngine.Networking.UnityWebRequest), "SetupPostWwwForm", 0, typeof(UnityEngine.Networking.UnityWebRequest), typeof(System.String));
					r_RSetupPostWwwForm_UnityWebRequest_String.SetBelong(null);
				}
				return r_RSetupPostWwwForm_UnityWebRequest_String;
			}
		}

		/// <summary>
		/// UnityEngine.Networking.UnityWebRequest Post(System.String, System.String, System.String)
		/// </summary>
		protected static RMethod r_RPost_String_String_String;
		public static RMethod RPost_String_String_String
		{
			get
			{
				if(r_RPost_String_String_String == null)
				{
					r_RPost_String_String_String = new(typeof(UnityEngine.Networking.UnityWebRequest), "Post", 0, typeof(System.String), typeof(System.String), typeof(System.String));
					r_RPost_String_String_String.SetBelong(null);
				}
				return r_RPost_String_String_String;
			}
		}

		/// <summary>
		/// UnityEngine.Networking.UnityWebRequest Post(System.Uri, System.String, System.String)
		/// </summary>
		protected static RMethod r_RPost_Uri_String_String;
		public static RMethod RPost_Uri_String_String
		{
			get
			{
				if(r_RPost_Uri_String_String == null)
				{
					r_RPost_Uri_String_String = new(typeof(UnityEngine.Networking.UnityWebRequest), "Post", 0, typeof(System.Uri), typeof(System.String), typeof(System.String));
					r_RPost_Uri_String_String.SetBelong(null);
				}
				return r_RPost_Uri_String_String;
			}
		}

		/// <summary>
		/// Void SetupPost(UnityEngine.Networking.UnityWebRequest, System.String, System.String)
		/// </summary>
		protected static RMethod r_RSetupPost_UnityWebRequest_String_String;
		public static RMethod RSetupPost_UnityWebRequest_String_String
		{
			get
			{
				if(r_RSetupPost_UnityWebRequest_String_String == null)
				{
					r_RSetupPost_UnityWebRequest_String_String = new(typeof(UnityEngine.Networking.UnityWebRequest), "SetupPost", 0, typeof(UnityEngine.Networking.UnityWebRequest), typeof(System.String), typeof(System.String));
					r_RSetupPost_UnityWebRequest_String_String.SetBelong(null);
				}
				return r_RSetupPost_UnityWebRequest_String_String;
			}
		}

		/// <summary>
		/// UnityEngine.Networking.UnityWebRequest Post(System.String, UnityEngine.WWWForm)
		/// </summary>
		protected static RMethod r_RPost_String_WWWForm;
		public static RMethod RPost_String_WWWForm
		{
			get
			{
				if(r_RPost_String_WWWForm == null)
				{
					r_RPost_String_WWWForm = new(typeof(UnityEngine.Networking.UnityWebRequest), "Post", 0, typeof(System.String), typeof(UnityEngine.WWWForm));
					r_RPost_String_WWWForm.SetBelong(null);
				}
				return r_RPost_String_WWWForm;
			}
		}

		/// <summary>
		/// UnityEngine.Networking.UnityWebRequest Post(System.Uri, UnityEngine.WWWForm)
		/// </summary>
		protected static RMethod r_RPost_Uri_WWWForm;
		public static RMethod RPost_Uri_WWWForm
		{
			get
			{
				if(r_RPost_Uri_WWWForm == null)
				{
					r_RPost_Uri_WWWForm = new(typeof(UnityEngine.Networking.UnityWebRequest), "Post", 0, typeof(System.Uri), typeof(UnityEngine.WWWForm));
					r_RPost_Uri_WWWForm.SetBelong(null);
				}
				return r_RPost_Uri_WWWForm;
			}
		}

		/// <summary>
		/// Void SetupPost(UnityEngine.Networking.UnityWebRequest, UnityEngine.WWWForm)
		/// </summary>
		protected static RMethod r_RSetupPost_UnityWebRequest_WWWForm;
		public static RMethod RSetupPost_UnityWebRequest_WWWForm
		{
			get
			{
				if(r_RSetupPost_UnityWebRequest_WWWForm == null)
				{
					r_RSetupPost_UnityWebRequest_WWWForm = new(typeof(UnityEngine.Networking.UnityWebRequest), "SetupPost", 0, typeof(UnityEngine.Networking.UnityWebRequest), typeof(UnityEngine.WWWForm));
					r_RSetupPost_UnityWebRequest_WWWForm.SetBelong(null);
				}
				return r_RSetupPost_UnityWebRequest_WWWForm;
			}
		}

		/// <summary>
		/// UnityEngine.Networking.UnityWebRequest Post(System.String, System.Collections.Generic.List`1[UnityEngine.Networking.IMultipartFormSection])
		/// </summary>
		protected static RMethod r_RPost_String_List_d_IMultipartFormSection_p_;
		public static RMethod RPost_String_List_d_IMultipartFormSection_p_
		{
			get
			{
				if(r_RPost_String_List_d_IMultipartFormSection_p_ == null)
				{
					r_RPost_String_List_d_IMultipartFormSection_p_ = new(typeof(UnityEngine.Networking.UnityWebRequest), "Post", 0, typeof(System.String), typeof(System.Collections.Generic.List<>).MakeGenericType(typeof(UnityEngine.Networking.IMultipartFormSection)));
					r_RPost_String_List_d_IMultipartFormSection_p_.SetBelong(null);
				}
				return r_RPost_String_List_d_IMultipartFormSection_p_;
			}
		}

		/// <summary>
		/// UnityEngine.Networking.UnityWebRequest Post(System.Uri, System.Collections.Generic.List`1[UnityEngine.Networking.IMultipartFormSection])
		/// </summary>
		protected static RMethod r_RPost_Uri_List_d_IMultipartFormSection_p_;
		public static RMethod RPost_Uri_List_d_IMultipartFormSection_p_
		{
			get
			{
				if(r_RPost_Uri_List_d_IMultipartFormSection_p_ == null)
				{
					r_RPost_Uri_List_d_IMultipartFormSection_p_ = new(typeof(UnityEngine.Networking.UnityWebRequest), "Post", 0, typeof(System.Uri), typeof(System.Collections.Generic.List<>).MakeGenericType(typeof(UnityEngine.Networking.IMultipartFormSection)));
					r_RPost_Uri_List_d_IMultipartFormSection_p_.SetBelong(null);
				}
				return r_RPost_Uri_List_d_IMultipartFormSection_p_;
			}
		}

		/// <summary>
		/// UnityEngine.Networking.UnityWebRequest Post(System.String, System.Collections.Generic.List`1[UnityEngine.Networking.IMultipartFormSection], Byte[])
		/// </summary>
		protected static RMethod r_RPost_String_List_d_IMultipartFormSection_p__ByteArray;
		public static RMethod RPost_String_List_d_IMultipartFormSection_p__ByteArray
		{
			get
			{
				if(r_RPost_String_List_d_IMultipartFormSection_p__ByteArray == null)
				{
					r_RPost_String_List_d_IMultipartFormSection_p__ByteArray = new(typeof(UnityEngine.Networking.UnityWebRequest), "Post", 0, typeof(System.String), typeof(System.Collections.Generic.List<>).MakeGenericType(typeof(UnityEngine.Networking.IMultipartFormSection)), typeof(System.Byte).MakeArrayType());
					r_RPost_String_List_d_IMultipartFormSection_p__ByteArray.SetBelong(null);
				}
				return r_RPost_String_List_d_IMultipartFormSection_p__ByteArray;
			}
		}

		/// <summary>
		/// UnityEngine.Networking.UnityWebRequest Post(System.Uri, System.Collections.Generic.List`1[UnityEngine.Networking.IMultipartFormSection], Byte[])
		/// </summary>
		protected static RMethod r_RPost_Uri_List_d_IMultipartFormSection_p__ByteArray;
		public static RMethod RPost_Uri_List_d_IMultipartFormSection_p__ByteArray
		{
			get
			{
				if(r_RPost_Uri_List_d_IMultipartFormSection_p__ByteArray == null)
				{
					r_RPost_Uri_List_d_IMultipartFormSection_p__ByteArray = new(typeof(UnityEngine.Networking.UnityWebRequest), "Post", 0, typeof(System.Uri), typeof(System.Collections.Generic.List<>).MakeGenericType(typeof(UnityEngine.Networking.IMultipartFormSection)), typeof(System.Byte).MakeArrayType());
					r_RPost_Uri_List_d_IMultipartFormSection_p__ByteArray.SetBelong(null);
				}
				return r_RPost_Uri_List_d_IMultipartFormSection_p__ByteArray;
			}
		}

		/// <summary>
		/// Void SetupPost(UnityEngine.Networking.UnityWebRequest, System.Collections.Generic.List`1[UnityEngine.Networking.IMultipartFormSection], Byte[])
		/// </summary>
		protected static RMethod r_RSetupPost_UnityWebRequest_List_d_IMultipartFormSection_p__ByteArray;
		public static RMethod RSetupPost_UnityWebRequest_List_d_IMultipartFormSection_p__ByteArray
		{
			get
			{
				if(r_RSetupPost_UnityWebRequest_List_d_IMultipartFormSection_p__ByteArray == null)
				{
					r_RSetupPost_UnityWebRequest_List_d_IMultipartFormSection_p__ByteArray = new(typeof(UnityEngine.Networking.UnityWebRequest), "SetupPost", 0, typeof(UnityEngine.Networking.UnityWebRequest), typeof(System.Collections.Generic.List<>).MakeGenericType(typeof(UnityEngine.Networking.IMultipartFormSection)), typeof(System.Byte).MakeArrayType());
					r_RSetupPost_UnityWebRequest_List_d_IMultipartFormSection_p__ByteArray.SetBelong(null);
				}
				return r_RSetupPost_UnityWebRequest_List_d_IMultipartFormSection_p__ByteArray;
			}
		}

		/// <summary>
		/// UnityEngine.Networking.UnityWebRequest Post(System.String, System.Collections.Generic.Dictionary`2[System.String,System.String])
		/// </summary>
		protected static RMethod r_RPost_String_Dictionary_d_String_String_p_;
		public static RMethod RPost_String_Dictionary_d_String_String_p_
		{
			get
			{
				if(r_RPost_String_Dictionary_d_String_String_p_ == null)
				{
					r_RPost_String_Dictionary_d_String_String_p_ = new(typeof(UnityEngine.Networking.UnityWebRequest), "Post", 0, typeof(System.String), typeof(System.Collections.Generic.Dictionary<, >).MakeGenericType(typeof(System.String), typeof(System.String)));
					r_RPost_String_Dictionary_d_String_String_p_.SetBelong(null);
				}
				return r_RPost_String_Dictionary_d_String_String_p_;
			}
		}

		/// <summary>
		/// UnityEngine.Networking.UnityWebRequest Post(System.Uri, System.Collections.Generic.Dictionary`2[System.String,System.String])
		/// </summary>
		protected static RMethod r_RPost_Uri_Dictionary_d_String_String_p_;
		public static RMethod RPost_Uri_Dictionary_d_String_String_p_
		{
			get
			{
				if(r_RPost_Uri_Dictionary_d_String_String_p_ == null)
				{
					r_RPost_Uri_Dictionary_d_String_String_p_ = new(typeof(UnityEngine.Networking.UnityWebRequest), "Post", 0, typeof(System.Uri), typeof(System.Collections.Generic.Dictionary<, >).MakeGenericType(typeof(System.String), typeof(System.String)));
					r_RPost_Uri_Dictionary_d_String_String_p_.SetBelong(null);
				}
				return r_RPost_Uri_Dictionary_d_String_String_p_;
			}
		}

		/// <summary>
		/// Void SetupPost(UnityEngine.Networking.UnityWebRequest, System.Collections.Generic.Dictionary`2[System.String,System.String])
		/// </summary>
		protected static RMethod r_RSetupPost_UnityWebRequest_Dictionary_d_String_String_p_;
		public static RMethod RSetupPost_UnityWebRequest_Dictionary_d_String_String_p_
		{
			get
			{
				if(r_RSetupPost_UnityWebRequest_Dictionary_d_String_String_p_ == null)
				{
					r_RSetupPost_UnityWebRequest_Dictionary_d_String_String_p_ = new(typeof(UnityEngine.Networking.UnityWebRequest), "SetupPost", 0, typeof(UnityEngine.Networking.UnityWebRequest), typeof(System.Collections.Generic.Dictionary<, >).MakeGenericType(typeof(System.String), typeof(System.String)));
					r_RSetupPost_UnityWebRequest_Dictionary_d_String_String_p_.SetBelong(null);
				}
				return r_RSetupPost_UnityWebRequest_Dictionary_d_String_String_p_;
			}
		}

		/// <summary>
		/// System.String EscapeURL(System.String)
		/// </summary>
		protected static RMethod r_REscapeURL_String;
		public static RMethod REscapeURL_String
		{
			get
			{
				if(r_REscapeURL_String == null)
				{
					r_REscapeURL_String = new(typeof(UnityEngine.Networking.UnityWebRequest), "EscapeURL", 0, typeof(System.String));
					r_REscapeURL_String.SetBelong(null);
				}
				return r_REscapeURL_String;
			}
		}

		/// <summary>
		/// System.String EscapeURL(System.String, System.Text.Encoding)
		/// </summary>
		protected static RMethod r_REscapeURL_String_Encoding;
		public static RMethod REscapeURL_String_Encoding
		{
			get
			{
				if(r_REscapeURL_String_Encoding == null)
				{
					r_REscapeURL_String_Encoding = new(typeof(UnityEngine.Networking.UnityWebRequest), "EscapeURL", 0, typeof(System.String), typeof(System.Text.Encoding));
					r_REscapeURL_String_Encoding.SetBelong(null);
				}
				return r_REscapeURL_String_Encoding;
			}
		}

		/// <summary>
		/// System.String UnEscapeURL(System.String)
		/// </summary>
		protected static RMethod r_RUnEscapeURL_String;
		public static RMethod RUnEscapeURL_String
		{
			get
			{
				if(r_RUnEscapeURL_String == null)
				{
					r_RUnEscapeURL_String = new(typeof(UnityEngine.Networking.UnityWebRequest), "UnEscapeURL", 0, typeof(System.String));
					r_RUnEscapeURL_String.SetBelong(null);
				}
				return r_RUnEscapeURL_String;
			}
		}

		/// <summary>
		/// System.String UnEscapeURL(System.String, System.Text.Encoding)
		/// </summary>
		protected static RMethod r_RUnEscapeURL_String_Encoding;
		public static RMethod RUnEscapeURL_String_Encoding
		{
			get
			{
				if(r_RUnEscapeURL_String_Encoding == null)
				{
					r_RUnEscapeURL_String_Encoding = new(typeof(UnityEngine.Networking.UnityWebRequest), "UnEscapeURL", 0, typeof(System.String), typeof(System.Text.Encoding));
					r_RUnEscapeURL_String_Encoding.SetBelong(null);
				}
				return r_RUnEscapeURL_String_Encoding;
			}
		}

		/// <summary>
		/// Byte[] SerializeFormSections(System.Collections.Generic.List`1[UnityEngine.Networking.IMultipartFormSection], Byte[])
		/// </summary>
		protected static RMethod r_RSerializeFormSections_List_d_IMultipartFormSection_p__ByteArray;
		public static RMethod RSerializeFormSections_List_d_IMultipartFormSection_p__ByteArray
		{
			get
			{
				if(r_RSerializeFormSections_List_d_IMultipartFormSection_p__ByteArray == null)
				{
					r_RSerializeFormSections_List_d_IMultipartFormSection_p__ByteArray = new(typeof(UnityEngine.Networking.UnityWebRequest), "SerializeFormSections", 0, typeof(System.Collections.Generic.List<>).MakeGenericType(typeof(UnityEngine.Networking.IMultipartFormSection)), typeof(System.Byte).MakeArrayType());
					r_RSerializeFormSections_List_d_IMultipartFormSection_p__ByteArray.SetBelong(null);
				}
				return r_RSerializeFormSections_List_d_IMultipartFormSection_p__ByteArray;
			}
		}

		/// <summary>
		/// Byte[] GenerateBoundary()
		/// </summary>
		protected static RMethod r_RGenerateBoundary;
		public static RMethod RGenerateBoundary
		{
			get
			{
				if(r_RGenerateBoundary == null)
				{
					r_RGenerateBoundary = new(typeof(UnityEngine.Networking.UnityWebRequest), "GenerateBoundary", 0);
					r_RGenerateBoundary.SetBelong(null);
				}
				return r_RGenerateBoundary;
			}
		}

		/// <summary>
		/// Byte[] SerializeSimpleForm(System.Collections.Generic.Dictionary`2[System.String,System.String])
		/// </summary>
		protected static RMethod r_RSerializeSimpleForm_Dictionary_d_String_String_p_;
		public static RMethod RSerializeSimpleForm_Dictionary_d_String_String_p_
		{
			get
			{
				if(r_RSerializeSimpleForm_Dictionary_d_String_String_p_ == null)
				{
					r_RSerializeSimpleForm_Dictionary_d_String_String_p_ = new(typeof(UnityEngine.Networking.UnityWebRequest), "SerializeSimpleForm", 0, typeof(System.Collections.Generic.Dictionary<, >).MakeGenericType(typeof(System.String), typeof(System.String)));
					r_RSerializeSimpleForm_Dictionary_d_String_String_p_.SetBelong(null);
				}
				return r_RSerializeSimpleForm_Dictionary_d_String_String_p_;
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


        public RUnityWebRequest() : base("UnityEngine.Networking.UnityWebRequest")
        {
        }

        public RUnityWebRequest(System.Object instance) : base("UnityEngine.Networking.UnityWebRequest")
		{
            SetInstance(instance);
		}

        public RUnityWebRequest(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RUnityWebRequest(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }


        public static System.String GetHTTPStatusString(System.Int64  @responseCode)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@responseCode};
            var ___result = RGetHTTPStatusString_Int64.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public static void ClearCookieCache()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RClearCookieCache.Invoke(___genericsType, ___parameters);

            
        }


        public static void ClearCookieCache(System.Uri  @uri)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@uri};
            var ___result = RClearCookieCache_Uri.Invoke(___genericsType, ___parameters);

            
        }


        public static void ClearCookieCache(System.String  @domain, System.String  @path)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@domain, @path};
            var ___result = RClearCookieCache_String_String.Invoke(___genericsType, ___parameters);

            
        }


        public static System.IntPtr Create()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RCreate.Invoke(___genericsType, ___parameters);

            return (System.IntPtr)___result;
        }


        public virtual void Release()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RRelease.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void InternalDestroy()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RInternalDestroy.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void InternalSetDefaults()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RInternalSetDefaults.Invoke(___genericsType, ___parameters);

            
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


        public virtual void DisposeHandlers()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RDisposeHandlers.Invoke(___genericsType, ___parameters);

            
        }


        public virtual UnityEngine.Networking.UnityWebRequestAsyncOperation BeginWebRequest()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RBeginWebRequest.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Networking.UnityWebRequestAsyncOperation)___result;
        }


        public virtual UnityEngine.AsyncOperation Send()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RSend.Invoke(___genericsType, ___parameters);

            return (UnityEngine.AsyncOperation)___result;
        }


        public virtual UnityEngine.Networking.UnityWebRequestAsyncOperation SendWebRequest()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RSendWebRequest.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Networking.UnityWebRequestAsyncOperation)___result;
        }


        public virtual void Abort()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RAbort.Invoke(___genericsType, ___parameters);

            
        }




        public virtual System.Object SetCustomMethod(System.String  @customMethodName)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@customMethodName};
            var ___result = RSetCustomMethod_String.Invoke(___genericsType, ___parameters);

            return (System.Object)___result;
        }


        public virtual void InternalSetCustomMethod(System.String  @customMethodName)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@customMethodName};
            var ___result = RInternalSetCustomMethod_String.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Object GetMethod()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetMethod.Invoke(___genericsType, ___parameters);

            return (System.Object)___result;
        }


        public virtual System.String GetCustomMethod()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetCustomMethod.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public virtual System.Object GetError()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetError.Invoke(___genericsType, ___parameters);

            return (System.Object)___result;
        }


        public virtual System.String GetUrl()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetUrl.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public virtual System.Object SetUrl(System.String  @url)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@url};
            var ___result = RSetUrl_String.Invoke(___genericsType, ___parameters);

            return (System.Object)___result;
        }


        public virtual void InternalSetUrl(System.String  @url)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@url};
            var ___result = RInternalSetUrl_String.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Single GetUploadProgress()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetUploadProgress.Invoke(___genericsType, ___parameters);

            return (System.Single)___result;
        }


        public virtual System.Boolean IsExecuting()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RIsExecuting.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Single GetDownloadProgress()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetDownloadProgress.Invoke(___genericsType, ___parameters);

            return (System.Single)___result;
        }


        public virtual System.Int32 GetRedirectLimit()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetRedirectLimit.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual void SetRedirectLimitFromScripting(System.Int32  @limit)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@limit};
            var ___result = RSetRedirectLimitFromScripting_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Boolean GetChunked()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetChunked.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Object SetChunked(System.Boolean  @chunked)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@chunked};
            var ___result = RSetChunked_Boolean.Invoke(___genericsType, ___parameters);

            return (System.Object)___result;
        }


        public virtual System.String GetRequestHeader(System.String  @name)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name};
            var ___result = RGetRequestHeader_String.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public virtual System.Object InternalSetRequestHeader(System.String  @name, System.String  @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name, @value};
            var ___result = RInternalSetRequestHeader_String_String.Invoke(___genericsType, ___parameters);

            return (System.Object)___result;
        }


        public virtual void SetRequestHeader(System.String  @name, System.String  @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name, @value};
            var ___result = RSetRequestHeader_String_String.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.String GetResponseHeader(System.String  @name)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name};
            var ___result = RGetResponseHeader_String.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public virtual System.String[] GetResponseHeaderKeys()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetResponseHeaderKeys.Invoke(___genericsType, ___parameters);

            return (System.String[])___result;
        }


        public virtual System.Collections.Generic.Dictionary<System.String, System.String> GetResponseHeaders()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetResponseHeaders.Invoke(___genericsType, ___parameters);

            return (System.Collections.Generic.Dictionary<System.String, System.String>)___result;
        }


        public virtual System.Object SetUploadHandler(UnityEngine.Networking.UploadHandler  @uh)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@uh};
            var ___result = RSetUploadHandler_UploadHandler.Invoke(___genericsType, ___parameters);

            return (System.Object)___result;
        }


        public virtual System.Object SetDownloadHandler(UnityEngine.Networking.DownloadHandler  @dh)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@dh};
            var ___result = RSetDownloadHandler_DownloadHandler.Invoke(___genericsType, ___parameters);

            return (System.Object)___result;
        }


        public virtual System.Object SetCertificateHandler(UnityEngine.Networking.CertificateHandler  @ch)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@ch};
            var ___result = RSetCertificateHandler_CertificateHandler.Invoke(___genericsType, ___parameters);

            return (System.Object)___result;
        }


        public virtual System.Int32 GetTimeoutMsec()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetTimeoutMsec.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.Object SetTimeoutMsec(System.Int32  @timeout)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@timeout};
            var ___result = RSetTimeoutMsec_Int32.Invoke(___genericsType, ___parameters);

            return (System.Object)___result;
        }


        public virtual System.Boolean GetSuppressErrorsToConsole()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetSuppressErrorsToConsole.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Object SetSuppressErrorsToConsole(System.Boolean  @suppress)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@suppress};
            var ___result = RSetSuppressErrorsToConsole_Boolean.Invoke(___genericsType, ___parameters);

            return (System.Object)___result;
        }


        public static UnityEngine.Networking.UnityWebRequest Get(System.String  @uri)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@uri};
            var ___result = RGet_String.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Networking.UnityWebRequest)___result;
        }


        public static UnityEngine.Networking.UnityWebRequest Get(System.Uri  @uri)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@uri};
            var ___result = RGet_Uri.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Networking.UnityWebRequest)___result;
        }


        public static UnityEngine.Networking.UnityWebRequest Delete(System.String  @uri)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@uri};
            var ___result = RDelete_String.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Networking.UnityWebRequest)___result;
        }


        public static UnityEngine.Networking.UnityWebRequest Delete(System.Uri  @uri)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@uri};
            var ___result = RDelete_Uri.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Networking.UnityWebRequest)___result;
        }


        public static UnityEngine.Networking.UnityWebRequest Head(System.String  @uri)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@uri};
            var ___result = RHead_String.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Networking.UnityWebRequest)___result;
        }


        public static UnityEngine.Networking.UnityWebRequest Head(System.Uri  @uri)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@uri};
            var ___result = RHead_Uri.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Networking.UnityWebRequest)___result;
        }


        public static UnityEngine.Networking.UnityWebRequest GetTexture(System.String  @uri)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@uri};
            var ___result = RGetTexture_String.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Networking.UnityWebRequest)___result;
        }


        public static UnityEngine.Networking.UnityWebRequest GetTexture(System.String  @uri, System.Boolean  @nonReadable)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@uri, @nonReadable};
            var ___result = RGetTexture_String_Boolean.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Networking.UnityWebRequest)___result;
        }


        public static UnityEngine.Networking.UnityWebRequest GetAudioClip(System.String  @uri, UnityEngine.AudioType  @audioType)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@uri, @audioType};
            var ___result = RGetAudioClip_String_AudioType.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Networking.UnityWebRequest)___result;
        }


        public static UnityEngine.Networking.UnityWebRequest GetAssetBundle(System.String  @uri)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@uri};
            var ___result = RGetAssetBundle_String.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Networking.UnityWebRequest)___result;
        }


        public static UnityEngine.Networking.UnityWebRequest GetAssetBundle(System.String  @uri, System.UInt32  @crc)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@uri, @crc};
            var ___result = RGetAssetBundle_String_UInt32.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Networking.UnityWebRequest)___result;
        }


        public static UnityEngine.Networking.UnityWebRequest GetAssetBundle(System.String  @uri, System.UInt32  @version, System.UInt32  @crc)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@uri, @version, @crc};
            var ___result = RGetAssetBundle_String_UInt32_UInt32.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Networking.UnityWebRequest)___result;
        }


        public static UnityEngine.Networking.UnityWebRequest GetAssetBundle(System.String  @uri, UnityEngine.Hash128  @hash, System.UInt32  @crc)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@uri, @hash, @crc};
            var ___result = RGetAssetBundle_String_Hash128_UInt32.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Networking.UnityWebRequest)___result;
        }


        public static UnityEngine.Networking.UnityWebRequest GetAssetBundle(System.String  @uri, UnityEngine.CachedAssetBundle  @cachedAssetBundle, System.UInt32  @crc)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@uri, @cachedAssetBundle, @crc};
            var ___result = RGetAssetBundle_String_CachedAssetBundle_UInt32.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Networking.UnityWebRequest)___result;
        }


        public static UnityEngine.Networking.UnityWebRequest Put(System.String  @uri, System.Byte[]  @bodyData)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@uri, @bodyData};
            var ___result = RPut_String_ByteArray.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Networking.UnityWebRequest)___result;
        }


        public static UnityEngine.Networking.UnityWebRequest Put(System.Uri  @uri, System.Byte[]  @bodyData)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@uri, @bodyData};
            var ___result = RPut_Uri_ByteArray.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Networking.UnityWebRequest)___result;
        }


        public static UnityEngine.Networking.UnityWebRequest Put(System.String  @uri, System.String  @bodyData)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@uri, @bodyData};
            var ___result = RPut_String_String.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Networking.UnityWebRequest)___result;
        }


        public static UnityEngine.Networking.UnityWebRequest Put(System.Uri  @uri, System.String  @bodyData)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@uri, @bodyData};
            var ___result = RPut_Uri_String.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Networking.UnityWebRequest)___result;
        }


        public static UnityEngine.Networking.UnityWebRequest Post(System.String  @uri, System.String  @postData)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@uri, @postData};
            var ___result = RPost_String_String.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Networking.UnityWebRequest)___result;
        }


        public static UnityEngine.Networking.UnityWebRequest Post(System.Uri  @uri, System.String  @postData)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@uri, @postData};
            var ___result = RPost_Uri_String.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Networking.UnityWebRequest)___result;
        }


        public static UnityEngine.Networking.UnityWebRequest PostWwwForm(System.String  @uri, System.String  @form)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@uri, @form};
            var ___result = RPostWwwForm_String_String.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Networking.UnityWebRequest)___result;
        }


        public static UnityEngine.Networking.UnityWebRequest PostWwwForm(System.Uri  @uri, System.String  @form)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@uri, @form};
            var ___result = RPostWwwForm_Uri_String.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Networking.UnityWebRequest)___result;
        }


        public static void SetupPostWwwForm(UnityEngine.Networking.UnityWebRequest  @request, System.String  @postData)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@request, @postData};
            var ___result = RSetupPostWwwForm_UnityWebRequest_String.Invoke(___genericsType, ___parameters);

            
        }


        public static UnityEngine.Networking.UnityWebRequest Post(System.String  @uri, System.String  @postData, System.String  @contentType)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@uri, @postData, @contentType};
            var ___result = RPost_String_String_String.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Networking.UnityWebRequest)___result;
        }


        public static UnityEngine.Networking.UnityWebRequest Post(System.Uri  @uri, System.String  @postData, System.String  @contentType)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@uri, @postData, @contentType};
            var ___result = RPost_Uri_String_String.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Networking.UnityWebRequest)___result;
        }


        public static void SetupPost(UnityEngine.Networking.UnityWebRequest  @request, System.String  @postData, System.String  @contentType)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@request, @postData, @contentType};
            var ___result = RSetupPost_UnityWebRequest_String_String.Invoke(___genericsType, ___parameters);

            
        }


        public static UnityEngine.Networking.UnityWebRequest Post(System.String  @uri, UnityEngine.WWWForm  @formData)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@uri, @formData};
            var ___result = RPost_String_WWWForm.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Networking.UnityWebRequest)___result;
        }


        public static UnityEngine.Networking.UnityWebRequest Post(System.Uri  @uri, UnityEngine.WWWForm  @formData)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@uri, @formData};
            var ___result = RPost_Uri_WWWForm.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Networking.UnityWebRequest)___result;
        }


        public static void SetupPost(UnityEngine.Networking.UnityWebRequest  @request, UnityEngine.WWWForm  @formData)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@request, @formData};
            var ___result = RSetupPost_UnityWebRequest_WWWForm.Invoke(___genericsType, ___parameters);

            
        }


        public static UnityEngine.Networking.UnityWebRequest Post(System.String  @uri, System.Collections.Generic.List<UnityEngine.Networking.IMultipartFormSection>  @multipartFormSections)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@uri, @multipartFormSections};
            var ___result = RPost_String_List_d_IMultipartFormSection_p_.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Networking.UnityWebRequest)___result;
        }


        public static UnityEngine.Networking.UnityWebRequest Post(System.Uri  @uri, System.Collections.Generic.List<UnityEngine.Networking.IMultipartFormSection>  @multipartFormSections)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@uri, @multipartFormSections};
            var ___result = RPost_Uri_List_d_IMultipartFormSection_p_.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Networking.UnityWebRequest)___result;
        }


        public static UnityEngine.Networking.UnityWebRequest Post(System.String  @uri, System.Collections.Generic.List<UnityEngine.Networking.IMultipartFormSection>  @multipartFormSections, System.Byte[]  @boundary)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@uri, @multipartFormSections, @boundary};
            var ___result = RPost_String_List_d_IMultipartFormSection_p__ByteArray.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Networking.UnityWebRequest)___result;
        }


        public static UnityEngine.Networking.UnityWebRequest Post(System.Uri  @uri, System.Collections.Generic.List<UnityEngine.Networking.IMultipartFormSection>  @multipartFormSections, System.Byte[]  @boundary)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@uri, @multipartFormSections, @boundary};
            var ___result = RPost_Uri_List_d_IMultipartFormSection_p__ByteArray.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Networking.UnityWebRequest)___result;
        }


        public static void SetupPost(UnityEngine.Networking.UnityWebRequest  @request, System.Collections.Generic.List<UnityEngine.Networking.IMultipartFormSection>  @multipartFormSections, System.Byte[]  @boundary)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@request, @multipartFormSections, @boundary};
            var ___result = RSetupPost_UnityWebRequest_List_d_IMultipartFormSection_p__ByteArray.Invoke(___genericsType, ___parameters);

            
        }


        public static UnityEngine.Networking.UnityWebRequest Post(System.String  @uri, System.Collections.Generic.Dictionary<System.String, System.String>  @formFields)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@uri, @formFields};
            var ___result = RPost_String_Dictionary_d_String_String_p_.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Networking.UnityWebRequest)___result;
        }


        public static UnityEngine.Networking.UnityWebRequest Post(System.Uri  @uri, System.Collections.Generic.Dictionary<System.String, System.String>  @formFields)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@uri, @formFields};
            var ___result = RPost_Uri_Dictionary_d_String_String_p_.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Networking.UnityWebRequest)___result;
        }


        public static void SetupPost(UnityEngine.Networking.UnityWebRequest  @request, System.Collections.Generic.Dictionary<System.String, System.String>  @formFields)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@request, @formFields};
            var ___result = RSetupPost_UnityWebRequest_Dictionary_d_String_String_p_.Invoke(___genericsType, ___parameters);

            
        }


        public static System.String EscapeURL(System.String  @s)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@s};
            var ___result = REscapeURL_String.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public static System.String EscapeURL(System.String  @s, System.Text.Encoding  @e)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@s, @e};
            var ___result = REscapeURL_String_Encoding.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public static System.String UnEscapeURL(System.String  @s)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@s};
            var ___result = RUnEscapeURL_String.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public static System.String UnEscapeURL(System.String  @s, System.Text.Encoding  @e)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@s, @e};
            var ___result = RUnEscapeURL_String_Encoding.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public static System.Byte[] SerializeFormSections(System.Collections.Generic.List<UnityEngine.Networking.IMultipartFormSection>  @multipartFormSections, System.Byte[]  @boundary)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@multipartFormSections, @boundary};
            var ___result = RSerializeFormSections_List_d_IMultipartFormSection_p__ByteArray.Invoke(___genericsType, ___parameters);

            return (System.Byte[])___result;
        }


        public static System.Byte[] GenerateBoundary()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGenerateBoundary.Invoke(___genericsType, ___parameters);

            return (System.Byte[])___result;
        }


        public static System.Byte[] SerializeSimpleForm(System.Collections.Generic.Dictionary<System.String, System.String>  @formFields)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@formFields};
            var ___result = RSerializeSimpleForm_Dictionary_d_String_String_p_.Invoke(___genericsType, ___parameters);

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
