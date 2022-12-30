using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.RUnityEngine
{
	/// <summary>
	/// UnityEngine.WWWForm
	/// </summary>
    public partial class RWWWForm : RMember //
    {

		/// <summary>
		/// System.Collections.Generic.List`1[System.Byte[]] formData
		/// </summary>
		protected RSystem.RCollections.RGeneric.RList<RFieldArray<RField>> r_formData;
		public virtual RSystem.RCollections.RGeneric.RList<RFieldArray<RField>> RformData
		{
			get
			{
				if(r_formData == null)
				{
					r_formData = new(this, "formData");
					r_formData.SetBelong(this.instance);
				}
				return r_formData;
			}
		}

		/// <summary>
		/// System.Collections.Generic.List`1[System.String] fieldNames
		/// </summary>
		protected RSystem.RCollections.RGeneric.RList<RField> r_fieldNames;
		public virtual RSystem.RCollections.RGeneric.RList<RField> RfieldNames
		{
			get
			{
				if(r_fieldNames == null)
				{
					r_fieldNames = new(this, "fieldNames");
					r_fieldNames.SetBelong(this.instance);
				}
				return r_fieldNames;
			}
		}

		/// <summary>
		/// System.Collections.Generic.List`1[System.String] fileNames
		/// </summary>
		protected RSystem.RCollections.RGeneric.RList<RField> r_fileNames;
		public virtual RSystem.RCollections.RGeneric.RList<RField> RfileNames
		{
			get
			{
				if(r_fileNames == null)
				{
					r_fileNames = new(this, "fileNames");
					r_fileNames.SetBelong(this.instance);
				}
				return r_fileNames;
			}
		}

		/// <summary>
		/// System.Collections.Generic.List`1[System.String] types
		/// </summary>
		protected RSystem.RCollections.RGeneric.RList<RField> r_types;
		public virtual RSystem.RCollections.RGeneric.RList<RField> Rtypes
		{
			get
			{
				if(r_types == null)
				{
					r_types = new(this, "types");
					r_types.SetBelong(this.instance);
				}
				return r_types;
			}
		}

		/// <summary>
		/// System.Byte[] boundary
		/// </summary>
		protected RFieldArray<RField> r_boundary;
		public virtual RFieldArray<RField> Rboundary
		{
			get
			{
				if(r_boundary == null)
				{
					r_boundary = new(this, "boundary");
					r_boundary.SetBelong(this.instance);
				}
				return r_boundary;
			}
		}

		/// <summary>
		/// System.Boolean containsFiles
		/// </summary>
		protected RField r_containsFiles;
		public virtual RField RcontainsFiles
		{
			get
			{
				if(r_containsFiles == null)
				{
					r_containsFiles = new(this, "containsFiles");
					r_containsFiles.SetBelong(this.instance);
				}
				return r_containsFiles;
			}
		}

		/// <summary>
		/// System.Byte[] dDash
		/// </summary>
		protected static RFieldArray<RField> r_dDash;
		public static RFieldArray<RField> RdDash
		{
			get
			{
				if(r_dDash == null)
				{
					r_dDash = new(typeof(UnityEngine.WWWForm), "dDash");
					r_dDash.SetBelong(null);
				}
				return r_dDash;
			}
		}

		/// <summary>
		/// System.Byte[] crlf
		/// </summary>
		protected static RFieldArray<RField> r_crlf;
		public static RFieldArray<RField> Rcrlf
		{
			get
			{
				if(r_crlf == null)
				{
					r_crlf = new(typeof(UnityEngine.WWWForm), "crlf");
					r_crlf.SetBelong(null);
				}
				return r_crlf;
			}
		}

		/// <summary>
		/// System.Byte[] contentTypeHeader
		/// </summary>
		protected static RFieldArray<RField> r_contentTypeHeader;
		public static RFieldArray<RField> RcontentTypeHeader
		{
			get
			{
				if(r_contentTypeHeader == null)
				{
					r_contentTypeHeader = new(typeof(UnityEngine.WWWForm), "contentTypeHeader");
					r_contentTypeHeader.SetBelong(null);
				}
				return r_contentTypeHeader;
			}
		}

		/// <summary>
		/// System.Byte[] dispositionHeader
		/// </summary>
		protected static RFieldArray<RField> r_dispositionHeader;
		public static RFieldArray<RField> RdispositionHeader
		{
			get
			{
				if(r_dispositionHeader == null)
				{
					r_dispositionHeader = new(typeof(UnityEngine.WWWForm), "dispositionHeader");
					r_dispositionHeader.SetBelong(null);
				}
				return r_dispositionHeader;
			}
		}

		/// <summary>
		/// System.Byte[] endQuote
		/// </summary>
		protected static RFieldArray<RField> r_endQuote;
		public static RFieldArray<RField> RendQuote
		{
			get
			{
				if(r_endQuote == null)
				{
					r_endQuote = new(typeof(UnityEngine.WWWForm), "endQuote");
					r_endQuote.SetBelong(null);
				}
				return r_endQuote;
			}
		}

		/// <summary>
		/// System.Byte[] fileNameField
		/// </summary>
		protected static RFieldArray<RField> r_fileNameField;
		public static RFieldArray<RField> RfileNameField
		{
			get
			{
				if(r_fileNameField == null)
				{
					r_fileNameField = new(typeof(UnityEngine.WWWForm), "fileNameField");
					r_fileNameField.SetBelong(null);
				}
				return r_fileNameField;
			}
		}

		/// <summary>
		/// System.Byte[] ampersand
		/// </summary>
		protected static RFieldArray<RField> r_ampersand;
		public static RFieldArray<RField> Rampersand
		{
			get
			{
				if(r_ampersand == null)
				{
					r_ampersand = new(typeof(UnityEngine.WWWForm), "ampersand");
					r_ampersand.SetBelong(null);
				}
				return r_ampersand;
			}
		}

		/// <summary>
		/// System.Byte[] equal
		/// </summary>
		protected static RFieldArray<RField> r_equal;
		public static RFieldArray<RField> Requal
		{
			get
			{
				if(r_equal == null)
				{
					r_equal = new(typeof(UnityEngine.WWWForm), "equal");
					r_equal.SetBelong(null);
				}
				return r_equal;
			}
		}

		/// <summary>
		/// System.Text.Encoding DefaultEncoding
		/// </summary>
		protected static RSystem.RText.REncoding r_DefaultEncoding;
		public static RSystem.RText.REncoding RDefaultEncoding
		{
			get
			{
				if(r_DefaultEncoding == null)
				{
					r_DefaultEncoding = new(typeof(UnityEngine.WWWForm), "DefaultEncoding", -1);
					r_DefaultEncoding.SetBelong(null);
				}
				return r_DefaultEncoding;
			}
		}

		/// <summary>
		/// System.Collections.Generic.Dictionary`2[System.String,System.String] headers
		/// </summary>
		protected RSystem.RCollections.RGeneric.RDictionary<RProperty, RProperty> r_headers;
		public virtual RSystem.RCollections.RGeneric.RDictionary<RProperty, RProperty> Rheaders
		{
			get
			{
				if(r_headers == null)
				{
					r_headers = new(this, "headers", -1);
					r_headers.SetBelong(this.instance);
				}
				return r_headers;
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
		/// Void AddField(System.String, System.String)
		/// </summary>
		protected RMethod r_RAddField_String_String;
		public virtual RMethod RAddField_String_String
		{
			get
			{
				if(r_RAddField_String_String == null)
				{
					r_RAddField_String_String = new(this, "AddField", 0, typeof(System.String), typeof(System.String));
					r_RAddField_String_String.SetBelong(this.instance);
				}
				return r_RAddField_String_String;
			}
		}

		/// <summary>
		/// Void AddField(System.String, System.String, System.Text.Encoding)
		/// </summary>
		protected RMethod r_RAddField_String_String_Encoding;
		public virtual RMethod RAddField_String_String_Encoding
		{
			get
			{
				if(r_RAddField_String_String_Encoding == null)
				{
					r_RAddField_String_String_Encoding = new(this, "AddField", 0, typeof(System.String), typeof(System.String), typeof(System.Text.Encoding));
					r_RAddField_String_String_Encoding.SetBelong(this.instance);
				}
				return r_RAddField_String_String_Encoding;
			}
		}

		/// <summary>
		/// Void AddField(System.String, Int32)
		/// </summary>
		protected RMethod r_RAddField_String_Int32;
		public virtual RMethod RAddField_String_Int32
		{
			get
			{
				if(r_RAddField_String_Int32 == null)
				{
					r_RAddField_String_Int32 = new(this, "AddField", 0, typeof(System.String), typeof(System.Int32));
					r_RAddField_String_Int32.SetBelong(this.instance);
				}
				return r_RAddField_String_Int32;
			}
		}

		/// <summary>
		/// Void AddBinaryData(System.String, Byte[])
		/// </summary>
		protected RMethod r_RAddBinaryData_String_ByteArray;
		public virtual RMethod RAddBinaryData_String_ByteArray
		{
			get
			{
				if(r_RAddBinaryData_String_ByteArray == null)
				{
					r_RAddBinaryData_String_ByteArray = new(this, "AddBinaryData", 0, typeof(System.String), typeof(System.Byte).MakeArrayType());
					r_RAddBinaryData_String_ByteArray.SetBelong(this.instance);
				}
				return r_RAddBinaryData_String_ByteArray;
			}
		}

		/// <summary>
		/// Void AddBinaryData(System.String, Byte[], System.String)
		/// </summary>
		protected RMethod r_RAddBinaryData_String_ByteArray_String;
		public virtual RMethod RAddBinaryData_String_ByteArray_String
		{
			get
			{
				if(r_RAddBinaryData_String_ByteArray_String == null)
				{
					r_RAddBinaryData_String_ByteArray_String = new(this, "AddBinaryData", 0, typeof(System.String), typeof(System.Byte).MakeArrayType(), typeof(System.String));
					r_RAddBinaryData_String_ByteArray_String.SetBelong(this.instance);
				}
				return r_RAddBinaryData_String_ByteArray_String;
			}
		}

		/// <summary>
		/// Void AddBinaryData(System.String, Byte[], System.String, System.String)
		/// </summary>
		protected RMethod r_RAddBinaryData_String_ByteArray_String_String;
		public virtual RMethod RAddBinaryData_String_ByteArray_String_String
		{
			get
			{
				if(r_RAddBinaryData_String_ByteArray_String_String == null)
				{
					r_RAddBinaryData_String_ByteArray_String_String = new(this, "AddBinaryData", 0, typeof(System.String), typeof(System.Byte).MakeArrayType(), typeof(System.String), typeof(System.String));
					r_RAddBinaryData_String_ByteArray_String_String.SetBelong(this.instance);
				}
				return r_RAddBinaryData_String_ByteArray_String_String;
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


        public RWWWForm() : base("UnityEngine.WWWForm")
        {
        }

        public RWWWForm(System.Object instance) : base("UnityEngine.WWWForm")
		{
            SetInstance(instance);
		}

        public RWWWForm(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RWWWForm(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }

        public virtual void AddField(System.String  @fieldName, System.String  @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@fieldName, @value};
            var ___result = RAddField_String_String.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void AddField(System.String  @fieldName, System.String  @value, System.Text.Encoding  @e)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@fieldName, @value, @e};
            var ___result = RAddField_String_String_Encoding.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void AddField(System.String  @fieldName, System.Int32  @i)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@fieldName, @i};
            var ___result = RAddField_String_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void AddBinaryData(System.String  @fieldName, System.Byte[]  @contents)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@fieldName, @contents};
            var ___result = RAddBinaryData_String_ByteArray.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void AddBinaryData(System.String  @fieldName, System.Byte[]  @contents, System.String  @fileName)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@fieldName, @contents, @fileName};
            var ___result = RAddBinaryData_String_ByteArray_String.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void AddBinaryData(System.String  @fieldName, System.Byte[]  @contents, System.String  @fileName, System.String  @mimeType)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@fieldName, @contents, @fileName, @mimeType};
            var ___result = RAddBinaryData_String_ByteArray_String_String.Invoke(___genericsType, ___parameters);

            
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
