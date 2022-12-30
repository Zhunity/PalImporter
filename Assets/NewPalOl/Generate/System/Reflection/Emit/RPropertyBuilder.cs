using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.RSystem.RReflection.REmit
{
	/// <summary>
	/// System.Reflection.Emit.PropertyBuilder
	/// </summary>
    public partial class RPropertyBuilder : RMember //
    {

		/// <summary>
		/// System.Reflection.PropertyAttributes attrs
		/// </summary>
		protected RField r_attrs;
		public virtual RField Rattrs
		{
			get
			{
				if(r_attrs == null)
				{
					r_attrs = new(this, "attrs");
					r_attrs.SetBelong(this.instance);
				}
				return r_attrs;
			}
		}

		/// <summary>
		/// System.String name
		/// </summary>
		protected RField r_name;
		public virtual RField Rname
		{
			get
			{
				if(r_name == null)
				{
					r_name = new(this, "name");
					r_name.SetBelong(this.instance);
				}
				return r_name;
			}
		}

		/// <summary>
		/// System.Type type
		/// </summary>
		protected RSystem.RType r_type;
		public virtual RSystem.RType Rtype
		{
			get
			{
				if(r_type == null)
				{
					r_type = new(this, "type");
					r_type.SetBelong(this.instance);
				}
				return r_type;
			}
		}

		/// <summary>
		/// System.Type[] parameters
		/// </summary>
		protected RFieldArray<RSystem.RType> r_parameters;
		public virtual RFieldArray<RSystem.RType> Rparameters
		{
			get
			{
				if(r_parameters == null)
				{
					r_parameters = new(this, "parameters");
					r_parameters.SetBelong(this.instance);
				}
				return r_parameters;
			}
		}

		/// <summary>
		/// System.Reflection.Emit.CustomAttributeBuilder[] cattrs
		/// </summary>
		protected RFieldArray<RSystem.RReflection.REmit.RCustomAttributeBuilder> r_cattrs;
		public virtual RFieldArray<RSystem.RReflection.REmit.RCustomAttributeBuilder> Rcattrs
		{
			get
			{
				if(r_cattrs == null)
				{
					r_cattrs = new(this, "cattrs");
					r_cattrs.SetBelong(this.instance);
				}
				return r_cattrs;
			}
		}

		/// <summary>
		/// System.Object def_value
		/// </summary>
		protected RSystem.RObject r_def_value;
		public virtual RSystem.RObject Rdef_value
		{
			get
			{
				if(r_def_value == null)
				{
					r_def_value = new(this, "def_value");
					r_def_value.SetBelong(this.instance);
				}
				return r_def_value;
			}
		}

		/// <summary>
		/// System.Reflection.Emit.MethodBuilder set_method
		/// </summary>
		protected RSystem.RReflection.REmit.RMethodBuilder r_set_method;
		public virtual RSystem.RReflection.REmit.RMethodBuilder Rset_method
		{
			get
			{
				if(r_set_method == null)
				{
					r_set_method = new(this, "set_method");
					r_set_method.SetBelong(this.instance);
				}
				return r_set_method;
			}
		}

		/// <summary>
		/// System.Reflection.Emit.MethodBuilder get_method
		/// </summary>
		protected RSystem.RReflection.REmit.RMethodBuilder r_get_method;
		public virtual RSystem.RReflection.REmit.RMethodBuilder Rget_method
		{
			get
			{
				if(r_get_method == null)
				{
					r_get_method = new(this, "get_method");
					r_get_method.SetBelong(this.instance);
				}
				return r_get_method;
			}
		}

		/// <summary>
		/// System.Int32 table_idx
		/// </summary>
		protected RField r_table_idx;
		public virtual RField Rtable_idx
		{
			get
			{
				if(r_table_idx == null)
				{
					r_table_idx = new(this, "table_idx");
					r_table_idx.SetBelong(this.instance);
				}
				return r_table_idx;
			}
		}

		/// <summary>
		/// System.Reflection.Emit.TypeBuilder typeb
		/// </summary>
		protected RSystem.RReflection.REmit.RTypeBuilder r_typeb;
		public virtual RSystem.RReflection.REmit.RTypeBuilder Rtypeb
		{
			get
			{
				if(r_typeb == null)
				{
					r_typeb = new(this, "typeb");
					r_typeb.SetBelong(this.instance);
				}
				return r_typeb;
			}
		}

		/// <summary>
		/// System.Type[] returnModReq
		/// </summary>
		protected RFieldArray<RSystem.RType> r_returnModReq;
		public virtual RFieldArray<RSystem.RType> RreturnModReq
		{
			get
			{
				if(r_returnModReq == null)
				{
					r_returnModReq = new(this, "returnModReq");
					r_returnModReq.SetBelong(this.instance);
				}
				return r_returnModReq;
			}
		}

		/// <summary>
		/// System.Type[] returnModOpt
		/// </summary>
		protected RFieldArray<RSystem.RType> r_returnModOpt;
		public virtual RFieldArray<RSystem.RType> RreturnModOpt
		{
			get
			{
				if(r_returnModOpt == null)
				{
					r_returnModOpt = new(this, "returnModOpt");
					r_returnModOpt.SetBelong(this.instance);
				}
				return r_returnModOpt;
			}
		}

		/// <summary>
		/// System.Type[][] paramModReq
		/// </summary>
		protected RFieldArray<RFieldArray<RSystem.RType>> r_paramModReq;
		public virtual RFieldArray<RFieldArray<RSystem.RType>> RparamModReq
		{
			get
			{
				if(r_paramModReq == null)
				{
					r_paramModReq = new(this, "paramModReq");
					r_paramModReq.SetBelong(this.instance);
				}
				return r_paramModReq;
			}
		}

		/// <summary>
		/// System.Type[][] paramModOpt
		/// </summary>
		protected RFieldArray<RFieldArray<RSystem.RType>> r_paramModOpt;
		public virtual RFieldArray<RFieldArray<RSystem.RType>> RparamModOpt
		{
			get
			{
				if(r_paramModOpt == null)
				{
					r_paramModOpt = new(this, "paramModOpt");
					r_paramModOpt.SetBelong(this.instance);
				}
				return r_paramModOpt;
			}
		}

		/// <summary>
		/// System.Reflection.CallingConventions callingConvention
		/// </summary>
		protected RField r_callingConvention;
		public virtual RField RcallingConvention
		{
			get
			{
				if(r_callingConvention == null)
				{
					r_callingConvention = new(this, "callingConvention");
					r_callingConvention.SetBelong(this.instance);
				}
				return r_callingConvention;
			}
		}

		/// <summary>
		/// System.Reflection.PropertyAttributes Attributes
		/// </summary>
		protected RProperty r_Attributes;
		public virtual RProperty RAttributes
		{
			get
			{
				if(r_Attributes == null)
				{
					r_Attributes = new(this, "Attributes", -1);
					r_Attributes.SetBelong(this.instance);
				}
				return r_Attributes;
			}
		}

		/// <summary>
		/// Boolean CanRead
		/// </summary>
		protected RProperty r_CanRead;
		public virtual RProperty RCanRead
		{
			get
			{
				if(r_CanRead == null)
				{
					r_CanRead = new(this, "CanRead", -1);
					r_CanRead.SetBelong(this.instance);
				}
				return r_CanRead;
			}
		}

		/// <summary>
		/// Boolean CanWrite
		/// </summary>
		protected RProperty r_CanWrite;
		public virtual RProperty RCanWrite
		{
			get
			{
				if(r_CanWrite == null)
				{
					r_CanWrite = new(this, "CanWrite", -1);
					r_CanWrite.SetBelong(this.instance);
				}
				return r_CanWrite;
			}
		}

		/// <summary>
		/// System.Type DeclaringType
		/// </summary>
		protected RSystem.RType r_DeclaringType;
		public virtual RSystem.RType RDeclaringType
		{
			get
			{
				if(r_DeclaringType == null)
				{
					r_DeclaringType = new(this, "DeclaringType", -1);
					r_DeclaringType.SetBelong(this.instance);
				}
				return r_DeclaringType;
			}
		}

		/// <summary>
		/// System.String Name
		/// </summary>
		protected RProperty r_Name;
		public virtual RProperty RName
		{
			get
			{
				if(r_Name == null)
				{
					r_Name = new(this, "Name", -1);
					r_Name.SetBelong(this.instance);
				}
				return r_Name;
			}
		}

		/// <summary>
		/// System.Reflection.Emit.PropertyToken PropertyToken
		/// </summary>
		protected RSystem.RReflection.REmit.RPropertyToken r_PropertyToken;
		public virtual RSystem.RReflection.REmit.RPropertyToken RPropertyToken
		{
			get
			{
				if(r_PropertyToken == null)
				{
					r_PropertyToken = new(this, "PropertyToken", -1);
					r_PropertyToken.SetBelong(this.instance);
				}
				return r_PropertyToken;
			}
		}

		/// <summary>
		/// System.Type PropertyType
		/// </summary>
		protected RSystem.RType r_PropertyType;
		public virtual RSystem.RType RPropertyType
		{
			get
			{
				if(r_PropertyType == null)
				{
					r_PropertyType = new(this, "PropertyType", -1);
					r_PropertyType.SetBelong(this.instance);
				}
				return r_PropertyType;
			}
		}

		/// <summary>
		/// System.Type ReflectedType
		/// </summary>
		protected RSystem.RType r_ReflectedType;
		public virtual RSystem.RType ReflectedType
		{
			get
			{
				if(r_ReflectedType == null)
				{
					r_ReflectedType = new(this, "ReflectedType", -1);
					r_ReflectedType.SetBelong(this.instance);
				}
				return r_ReflectedType;
			}
		}

		/// <summary>
		/// System.Reflection.Module Module
		/// </summary>
		protected RSystem.RReflection.RModule r_Module;
		public virtual RSystem.RReflection.RModule RModule
		{
			get
			{
				if(r_Module == null)
				{
					r_Module = new(this, "Module", -1);
					r_Module.SetBelong(this.instance);
				}
				return r_Module;
			}
		}

		/// <summary>
		/// System.Reflection.MemberTypes MemberType
		/// </summary>
		protected RProperty r_MemberType;
		public virtual RProperty RMemberType
		{
			get
			{
				if(r_MemberType == null)
				{
					r_MemberType = new(this, "MemberType", -1);
					r_MemberType.SetBelong(this.instance);
				}
				return r_MemberType;
			}
		}

		/// <summary>
		/// Boolean IsSpecialName
		/// </summary>
		protected RProperty r_IsSpecialName;
		public virtual RProperty RIsSpecialName
		{
			get
			{
				if(r_IsSpecialName == null)
				{
					r_IsSpecialName = new(this, "IsSpecialName", -1);
					r_IsSpecialName.SetBelong(this.instance);
				}
				return r_IsSpecialName;
			}
		}

		/// <summary>
		/// System.Reflection.MethodInfo GetMethod
		/// </summary>
		protected RSystem.RReflection.RMethodInfo r_GetMethod;
		public virtual RSystem.RReflection.RMethodInfo RGetMethod
		{
			get
			{
				if(r_GetMethod == null)
				{
					r_GetMethod = new(this, "GetMethod", -1);
					r_GetMethod.SetBelong(this.instance);
				}
				return r_GetMethod;
			}
		}

		/// <summary>
		/// System.Reflection.MethodInfo SetMethod
		/// </summary>
		protected RSystem.RReflection.RMethodInfo r_SetMethod;
		public virtual RSystem.RReflection.RMethodInfo RSetMethod
		{
			get
			{
				if(r_SetMethod == null)
				{
					r_SetMethod = new(this, "SetMethod", -1);
					r_SetMethod.SetBelong(this.instance);
				}
				return r_SetMethod;
			}
		}

		/// <summary>
		/// System.Collections.Generic.IEnumerable`1[System.Reflection.CustomAttributeData] CustomAttributes
		/// </summary>
		protected RSystem.RCollections.RGeneric.RIEnumerable<RSystem.RReflection.RCustomAttributeData> r_CustomAttributes;
		public virtual RSystem.RCollections.RGeneric.RIEnumerable<RSystem.RReflection.RCustomAttributeData> RCustomAttributes
		{
			get
			{
				if(r_CustomAttributes == null)
				{
					r_CustomAttributes = new(this, "CustomAttributes", -1);
					r_CustomAttributes.SetBelong(this.instance);
				}
				return r_CustomAttributes;
			}
		}

		/// <summary>
		/// Int32 MetadataToken
		/// </summary>
		protected RProperty r_MetadataToken;
		public virtual RProperty RMetadataToken
		{
			get
			{
				if(r_MetadataToken == null)
				{
					r_MetadataToken = new(this, "MetadataToken", -1);
					r_MetadataToken.SetBelong(this.instance);
				}
				return r_MetadataToken;
			}
		}

		/// <summary>
		/// Void System.Runtime.InteropServices._PropertyBuilder.GetIDsOfNames(System.Guid ByRef, IntPtr, UInt32, UInt32, IntPtr)
		/// </summary>
		protected RMethod r_RSystem__1__Runtime__1__InteropServices__1___PropertyBuilder__1__GetIDsOfNames_In_Guid_IntPtr_UInt32_UInt32_IntPtr;
		public virtual RMethod RSystem__1__Runtime__1__InteropServices__1___PropertyBuilder__1__GetIDsOfNames_In_Guid_IntPtr_UInt32_UInt32_IntPtr
		{
			get
			{
				if(r_RSystem__1__Runtime__1__InteropServices__1___PropertyBuilder__1__GetIDsOfNames_In_Guid_IntPtr_UInt32_UInt32_IntPtr == null)
				{
					r_RSystem__1__Runtime__1__InteropServices__1___PropertyBuilder__1__GetIDsOfNames_In_Guid_IntPtr_UInt32_UInt32_IntPtr = new(this, "System.Runtime.InteropServices._PropertyBuilder.GetIDsOfNames", 0, typeof(System.Guid).MakeByRefType(), typeof(System.IntPtr), typeof(System.UInt32), typeof(System.UInt32), typeof(System.IntPtr));
					r_RSystem__1__Runtime__1__InteropServices__1___PropertyBuilder__1__GetIDsOfNames_In_Guid_IntPtr_UInt32_UInt32_IntPtr.SetBelong(this.instance);
				}
				return r_RSystem__1__Runtime__1__InteropServices__1___PropertyBuilder__1__GetIDsOfNames_In_Guid_IntPtr_UInt32_UInt32_IntPtr;
			}
		}

		/// <summary>
		/// Void System.Runtime.InteropServices._PropertyBuilder.GetTypeInfo(UInt32, UInt32, IntPtr)
		/// </summary>
		protected RMethod r_RSystem__1__Runtime__1__InteropServices__1___PropertyBuilder__1__GetTypeInfo_UInt32_UInt32_IntPtr;
		public virtual RMethod RSystem__1__Runtime__1__InteropServices__1___PropertyBuilder__1__GetTypeInfo_UInt32_UInt32_IntPtr
		{
			get
			{
				if(r_RSystem__1__Runtime__1__InteropServices__1___PropertyBuilder__1__GetTypeInfo_UInt32_UInt32_IntPtr == null)
				{
					r_RSystem__1__Runtime__1__InteropServices__1___PropertyBuilder__1__GetTypeInfo_UInt32_UInt32_IntPtr = new(this, "System.Runtime.InteropServices._PropertyBuilder.GetTypeInfo", 0, typeof(System.UInt32), typeof(System.UInt32), typeof(System.IntPtr));
					r_RSystem__1__Runtime__1__InteropServices__1___PropertyBuilder__1__GetTypeInfo_UInt32_UInt32_IntPtr.SetBelong(this.instance);
				}
				return r_RSystem__1__Runtime__1__InteropServices__1___PropertyBuilder__1__GetTypeInfo_UInt32_UInt32_IntPtr;
			}
		}

		/// <summary>
		/// Void System.Runtime.InteropServices._PropertyBuilder.GetTypeInfoCount(UInt32 ByRef)
		/// </summary>
		protected RMethod r_RSystem__1__Runtime__1__InteropServices__1___PropertyBuilder__1__GetTypeInfoCount_Out_UInt32;
		public virtual RMethod RSystem__1__Runtime__1__InteropServices__1___PropertyBuilder__1__GetTypeInfoCount_Out_UInt32
		{
			get
			{
				if(r_RSystem__1__Runtime__1__InteropServices__1___PropertyBuilder__1__GetTypeInfoCount_Out_UInt32 == null)
				{
					r_RSystem__1__Runtime__1__InteropServices__1___PropertyBuilder__1__GetTypeInfoCount_Out_UInt32 = new(this, "System.Runtime.InteropServices._PropertyBuilder.GetTypeInfoCount", 0, typeof(System.UInt32).MakeByRefType());
					r_RSystem__1__Runtime__1__InteropServices__1___PropertyBuilder__1__GetTypeInfoCount_Out_UInt32.SetBelong(this.instance);
				}
				return r_RSystem__1__Runtime__1__InteropServices__1___PropertyBuilder__1__GetTypeInfoCount_Out_UInt32;
			}
		}

		/// <summary>
		/// Void System.Runtime.InteropServices._PropertyBuilder.Invoke(UInt32, System.Guid ByRef, UInt32, Int16, IntPtr, IntPtr, IntPtr, IntPtr)
		/// </summary>
		protected RMethod r_RSystem__1__Runtime__1__InteropServices__1___PropertyBuilder__1__Invoke_UInt32_In_Guid_UInt32_Int16_IntPtr_IntPtr_IntPtr_IntPtr;
		public virtual RMethod RSystem__1__Runtime__1__InteropServices__1___PropertyBuilder__1__Invoke_UInt32_In_Guid_UInt32_Int16_IntPtr_IntPtr_IntPtr_IntPtr
		{
			get
			{
				if(r_RSystem__1__Runtime__1__InteropServices__1___PropertyBuilder__1__Invoke_UInt32_In_Guid_UInt32_Int16_IntPtr_IntPtr_IntPtr_IntPtr == null)
				{
					r_RSystem__1__Runtime__1__InteropServices__1___PropertyBuilder__1__Invoke_UInt32_In_Guid_UInt32_Int16_IntPtr_IntPtr_IntPtr_IntPtr = new(this, "System.Runtime.InteropServices._PropertyBuilder.Invoke", 0, typeof(System.UInt32), typeof(System.Guid).MakeByRefType(), typeof(System.UInt32), typeof(System.Int16), typeof(System.IntPtr), typeof(System.IntPtr), typeof(System.IntPtr), typeof(System.IntPtr));
					r_RSystem__1__Runtime__1__InteropServices__1___PropertyBuilder__1__Invoke_UInt32_In_Guid_UInt32_Int16_IntPtr_IntPtr_IntPtr_IntPtr.SetBelong(this.instance);
				}
				return r_RSystem__1__Runtime__1__InteropServices__1___PropertyBuilder__1__Invoke_UInt32_In_Guid_UInt32_Int16_IntPtr_IntPtr_IntPtr_IntPtr;
			}
		}

		/// <summary>
		/// Void AddOtherMethod(System.Reflection.Emit.MethodBuilder)
		/// </summary>
		protected RMethod r_RAddOtherMethod_MethodBuilder;
		public virtual RMethod RAddOtherMethod_MethodBuilder
		{
			get
			{
				if(r_RAddOtherMethod_MethodBuilder == null)
				{
					r_RAddOtherMethod_MethodBuilder = new(this, "AddOtherMethod", 0, typeof(System.Reflection.Emit.MethodBuilder));
					r_RAddOtherMethod_MethodBuilder.SetBelong(this.instance);
				}
				return r_RAddOtherMethod_MethodBuilder;
			}
		}

		/// <summary>
		/// System.Reflection.MethodInfo[] GetAccessors(Boolean)
		/// </summary>
		protected RMethod r_RGetAccessors_Boolean;
		public virtual RMethod RGetAccessors_Boolean
		{
			get
			{
				if(r_RGetAccessors_Boolean == null)
				{
					r_RGetAccessors_Boolean = new(this, "GetAccessors", 0, typeof(System.Boolean));
					r_RGetAccessors_Boolean.SetBelong(this.instance);
				}
				return r_RGetAccessors_Boolean;
			}
		}

		/// <summary>
		/// System.Object[] GetCustomAttributes(Boolean)
		/// </summary>
		protected RMethod r_RGetCustomAttributes_Boolean;
		public virtual RMethod RGetCustomAttributes_Boolean
		{
			get
			{
				if(r_RGetCustomAttributes_Boolean == null)
				{
					r_RGetCustomAttributes_Boolean = new(this, "GetCustomAttributes", 0, typeof(System.Boolean));
					r_RGetCustomAttributes_Boolean.SetBelong(this.instance);
				}
				return r_RGetCustomAttributes_Boolean;
			}
		}

		/// <summary>
		/// System.Object[] GetCustomAttributes(System.Type, Boolean)
		/// </summary>
		protected RMethod r_RGetCustomAttributes_Type_Boolean;
		public virtual RMethod RGetCustomAttributes_Type_Boolean
		{
			get
			{
				if(r_RGetCustomAttributes_Type_Boolean == null)
				{
					r_RGetCustomAttributes_Type_Boolean = new(this, "GetCustomAttributes", 0, typeof(System.Type), typeof(System.Boolean));
					r_RGetCustomAttributes_Type_Boolean.SetBelong(this.instance);
				}
				return r_RGetCustomAttributes_Type_Boolean;
			}
		}

		/// <summary>
		/// System.Reflection.MethodInfo GetGetMethod(Boolean)
		/// </summary>
		protected RMethod r_RGetGetMethod_Boolean;
		public virtual RMethod RGetGetMethod_Boolean
		{
			get
			{
				if(r_RGetGetMethod_Boolean == null)
				{
					r_RGetGetMethod_Boolean = new(this, "GetGetMethod", 0, typeof(System.Boolean));
					r_RGetGetMethod_Boolean.SetBelong(this.instance);
				}
				return r_RGetGetMethod_Boolean;
			}
		}

		/// <summary>
		/// System.Reflection.ParameterInfo[] GetIndexParameters()
		/// </summary>
		protected RMethod r_RGetIndexParameters;
		public virtual RMethod RGetIndexParameters
		{
			get
			{
				if(r_RGetIndexParameters == null)
				{
					r_RGetIndexParameters = new(this, "GetIndexParameters", 0);
					r_RGetIndexParameters.SetBelong(this.instance);
				}
				return r_RGetIndexParameters;
			}
		}

		/// <summary>
		/// System.Reflection.MethodInfo GetSetMethod(Boolean)
		/// </summary>
		protected RMethod r_RGetSetMethod_Boolean;
		public virtual RMethod RGetSetMethod_Boolean
		{
			get
			{
				if(r_RGetSetMethod_Boolean == null)
				{
					r_RGetSetMethod_Boolean = new(this, "GetSetMethod", 0, typeof(System.Boolean));
					r_RGetSetMethod_Boolean.SetBelong(this.instance);
				}
				return r_RGetSetMethod_Boolean;
			}
		}

		/// <summary>
		/// System.Object GetValue(System.Object, System.Object[])
		/// </summary>
		protected RMethod r_RGetValue_Object_ObjectArray;
		public virtual RMethod RGetValue_Object_ObjectArray
		{
			get
			{
				if(r_RGetValue_Object_ObjectArray == null)
				{
					r_RGetValue_Object_ObjectArray = new(this, "GetValue", 0, typeof(System.Object), typeof(System.Object).MakeArrayType());
					r_RGetValue_Object_ObjectArray.SetBelong(this.instance);
				}
				return r_RGetValue_Object_ObjectArray;
			}
		}

		/// <summary>
		/// System.Object GetValue(System.Object, System.Reflection.BindingFlags, System.Reflection.Binder, System.Object[], System.Globalization.CultureInfo)
		/// </summary>
		protected RMethod r_RGetValue_Object_BindingFlags_Binder_ObjectArray_CultureInfo;
		public virtual RMethod RGetValue_Object_BindingFlags_Binder_ObjectArray_CultureInfo
		{
			get
			{
				if(r_RGetValue_Object_BindingFlags_Binder_ObjectArray_CultureInfo == null)
				{
					r_RGetValue_Object_BindingFlags_Binder_ObjectArray_CultureInfo = new(this, "GetValue", 0, typeof(System.Object), typeof(System.Reflection.BindingFlags), typeof(System.Reflection.Binder), typeof(System.Object).MakeArrayType(), typeof(System.Globalization.CultureInfo));
					r_RGetValue_Object_BindingFlags_Binder_ObjectArray_CultureInfo.SetBelong(this.instance);
				}
				return r_RGetValue_Object_BindingFlags_Binder_ObjectArray_CultureInfo;
			}
		}

		/// <summary>
		/// Boolean IsDefined(System.Type, Boolean)
		/// </summary>
		protected RMethod r_RIsDefined_Type_Boolean;
		public virtual RMethod RIsDefined_Type_Boolean
		{
			get
			{
				if(r_RIsDefined_Type_Boolean == null)
				{
					r_RIsDefined_Type_Boolean = new(this, "IsDefined", 0, typeof(System.Type), typeof(System.Boolean));
					r_RIsDefined_Type_Boolean.SetBelong(this.instance);
				}
				return r_RIsDefined_Type_Boolean;
			}
		}

		/// <summary>
		/// Void SetConstant(System.Object)
		/// </summary>
		protected RMethod r_RSetConstant_Object;
		public virtual RMethod RSetConstant_Object
		{
			get
			{
				if(r_RSetConstant_Object == null)
				{
					r_RSetConstant_Object = new(this, "SetConstant", 0, typeof(System.Object));
					r_RSetConstant_Object.SetBelong(this.instance);
				}
				return r_RSetConstant_Object;
			}
		}

		/// <summary>
		/// Void SetCustomAttribute(System.Reflection.Emit.CustomAttributeBuilder)
		/// </summary>
		protected RMethod r_RSetCustomAttribute_CustomAttributeBuilder;
		public virtual RMethod RSetCustomAttribute_CustomAttributeBuilder
		{
			get
			{
				if(r_RSetCustomAttribute_CustomAttributeBuilder == null)
				{
					r_RSetCustomAttribute_CustomAttributeBuilder = new(this, "SetCustomAttribute", 0, typeof(System.Reflection.Emit.CustomAttributeBuilder));
					r_RSetCustomAttribute_CustomAttributeBuilder.SetBelong(this.instance);
				}
				return r_RSetCustomAttribute_CustomAttributeBuilder;
			}
		}

		/// <summary>
		/// Void SetCustomAttribute(System.Reflection.ConstructorInfo, Byte[])
		/// </summary>
		protected RMethod r_RSetCustomAttribute_ConstructorInfo_ByteArray;
		public virtual RMethod RSetCustomAttribute_ConstructorInfo_ByteArray
		{
			get
			{
				if(r_RSetCustomAttribute_ConstructorInfo_ByteArray == null)
				{
					r_RSetCustomAttribute_ConstructorInfo_ByteArray = new(this, "SetCustomAttribute", 0, typeof(System.Reflection.ConstructorInfo), typeof(System.Byte).MakeArrayType());
					r_RSetCustomAttribute_ConstructorInfo_ByteArray.SetBelong(this.instance);
				}
				return r_RSetCustomAttribute_ConstructorInfo_ByteArray;
			}
		}

		/// <summary>
		/// Void SetGetMethod(System.Reflection.Emit.MethodBuilder)
		/// </summary>
		protected RMethod r_RSetGetMethod_MethodBuilder;
		public virtual RMethod RSetGetMethod_MethodBuilder
		{
			get
			{
				if(r_RSetGetMethod_MethodBuilder == null)
				{
					r_RSetGetMethod_MethodBuilder = new(this, "SetGetMethod", 0, typeof(System.Reflection.Emit.MethodBuilder));
					r_RSetGetMethod_MethodBuilder.SetBelong(this.instance);
				}
				return r_RSetGetMethod_MethodBuilder;
			}
		}

		/// <summary>
		/// Void SetSetMethod(System.Reflection.Emit.MethodBuilder)
		/// </summary>
		protected RMethod r_RSetSetMethod_MethodBuilder;
		public virtual RMethod RSetSetMethod_MethodBuilder
		{
			get
			{
				if(r_RSetSetMethod_MethodBuilder == null)
				{
					r_RSetSetMethod_MethodBuilder = new(this, "SetSetMethod", 0, typeof(System.Reflection.Emit.MethodBuilder));
					r_RSetSetMethod_MethodBuilder.SetBelong(this.instance);
				}
				return r_RSetSetMethod_MethodBuilder;
			}
		}

		/// <summary>
		/// Void SetValue(System.Object, System.Object, System.Object[])
		/// </summary>
		protected RMethod r_RSetValue_Object_Object_ObjectArray;
		public virtual RMethod RSetValue_Object_Object_ObjectArray
		{
			get
			{
				if(r_RSetValue_Object_Object_ObjectArray == null)
				{
					r_RSetValue_Object_Object_ObjectArray = new(this, "SetValue", 0, typeof(System.Object), typeof(System.Object), typeof(System.Object).MakeArrayType());
					r_RSetValue_Object_Object_ObjectArray.SetBelong(this.instance);
				}
				return r_RSetValue_Object_Object_ObjectArray;
			}
		}

		/// <summary>
		/// Void SetValue(System.Object, System.Object, System.Reflection.BindingFlags, System.Reflection.Binder, System.Object[], System.Globalization.CultureInfo)
		/// </summary>
		protected RMethod r_RSetValue_Object_Object_BindingFlags_Binder_ObjectArray_CultureInfo;
		public virtual RMethod RSetValue_Object_Object_BindingFlags_Binder_ObjectArray_CultureInfo
		{
			get
			{
				if(r_RSetValue_Object_Object_BindingFlags_Binder_ObjectArray_CultureInfo == null)
				{
					r_RSetValue_Object_Object_BindingFlags_Binder_ObjectArray_CultureInfo = new(this, "SetValue", 0, typeof(System.Object), typeof(System.Object), typeof(System.Reflection.BindingFlags), typeof(System.Reflection.Binder), typeof(System.Object).MakeArrayType(), typeof(System.Globalization.CultureInfo));
					r_RSetValue_Object_Object_BindingFlags_Binder_ObjectArray_CultureInfo.SetBelong(this.instance);
				}
				return r_RSetValue_Object_Object_BindingFlags_Binder_ObjectArray_CultureInfo;
			}
		}

		/// <summary>
		/// System.Exception not_supported()
		/// </summary>
		protected RMethod r_Rnot_supported;
		public virtual RMethod Rnot_supported
		{
			get
			{
				if(r_Rnot_supported == null)
				{
					r_Rnot_supported = new(this, "not_supported", 0);
					r_Rnot_supported.SetBelong(this.instance);
				}
				return r_Rnot_supported;
			}
		}

		/// <summary>
		/// System.Reflection.MethodInfo[] GetAccessors()
		/// </summary>
		protected RMethod r_RGetAccessors;
		public virtual RMethod RGetAccessors
		{
			get
			{
				if(r_RGetAccessors == null)
				{
					r_RGetAccessors = new(this, "GetAccessors", 0);
					r_RGetAccessors.SetBelong(this.instance);
				}
				return r_RGetAccessors;
			}
		}

		/// <summary>
		/// System.Reflection.MethodInfo GetGetMethod()
		/// </summary>
		protected RMethod r_RGetGetMethod;
		public virtual RMethod RGetGetMethod
		{
			get
			{
				if(r_RGetGetMethod == null)
				{
					r_RGetGetMethod = new(this, "GetGetMethod", 0);
					r_RGetGetMethod.SetBelong(this.instance);
				}
				return r_RGetGetMethod;
			}
		}

		/// <summary>
		/// System.Reflection.MethodInfo GetSetMethod()
		/// </summary>
		protected RMethod r_RGetSetMethod;
		public virtual RMethod RGetSetMethod
		{
			get
			{
				if(r_RGetSetMethod == null)
				{
					r_RGetSetMethod = new(this, "GetSetMethod", 0);
					r_RGetSetMethod.SetBelong(this.instance);
				}
				return r_RGetSetMethod;
			}
		}

		/// <summary>
		/// System.Type[] GetOptionalCustomModifiers()
		/// </summary>
		protected RMethod r_RGetOptionalCustomModifiers;
		public virtual RMethod RGetOptionalCustomModifiers
		{
			get
			{
				if(r_RGetOptionalCustomModifiers == null)
				{
					r_RGetOptionalCustomModifiers = new(this, "GetOptionalCustomModifiers", 0);
					r_RGetOptionalCustomModifiers.SetBelong(this.instance);
				}
				return r_RGetOptionalCustomModifiers;
			}
		}

		/// <summary>
		/// System.Type[] GetRequiredCustomModifiers()
		/// </summary>
		protected RMethod r_RGetRequiredCustomModifiers;
		public virtual RMethod RGetRequiredCustomModifiers
		{
			get
			{
				if(r_RGetRequiredCustomModifiers == null)
				{
					r_RGetRequiredCustomModifiers = new(this, "GetRequiredCustomModifiers", 0);
					r_RGetRequiredCustomModifiers.SetBelong(this.instance);
				}
				return r_RGetRequiredCustomModifiers;
			}
		}

		/// <summary>
		/// System.Object GetValue(System.Object)
		/// </summary>
		protected RMethod r_RGetValue_Object;
		public virtual RMethod RGetValue_Object
		{
			get
			{
				if(r_RGetValue_Object == null)
				{
					r_RGetValue_Object = new(this, "GetValue", 0, typeof(System.Object));
					r_RGetValue_Object.SetBelong(this.instance);
				}
				return r_RGetValue_Object;
			}
		}

		/// <summary>
		/// System.Object GetConstantValue()
		/// </summary>
		protected RMethod r_RGetConstantValue;
		public virtual RMethod RGetConstantValue
		{
			get
			{
				if(r_RGetConstantValue == null)
				{
					r_RGetConstantValue = new(this, "GetConstantValue", 0);
					r_RGetConstantValue.SetBelong(this.instance);
				}
				return r_RGetConstantValue;
			}
		}

		/// <summary>
		/// System.Object GetRawConstantValue()
		/// </summary>
		protected RMethod r_RGetRawConstantValue;
		public virtual RMethod RGetRawConstantValue
		{
			get
			{
				if(r_RGetRawConstantValue == null)
				{
					r_RGetRawConstantValue = new(this, "GetRawConstantValue", 0);
					r_RGetRawConstantValue.SetBelong(this.instance);
				}
				return r_RGetRawConstantValue;
			}
		}

		/// <summary>
		/// Void SetValue(System.Object, System.Object)
		/// </summary>
		protected RMethod r_RSetValue_Object_Object;
		public virtual RMethod RSetValue_Object_Object
		{
			get
			{
				if(r_RSetValue_Object_Object == null)
				{
					r_RSetValue_Object_Object = new(this, "SetValue", 0, typeof(System.Object), typeof(System.Object));
					r_RSetValue_Object_Object.SetBelong(this.instance);
				}
				return r_RSetValue_Object_Object;
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
		/// Boolean HasSameMetadataDefinitionAs(System.Reflection.MemberInfo)
		/// </summary>
		protected RMethod r_RHasSameMetadataDefinitionAs_MemberInfo;
		public virtual RMethod RHasSameMetadataDefinitionAs_MemberInfo
		{
			get
			{
				if(r_RHasSameMetadataDefinitionAs_MemberInfo == null)
				{
					r_RHasSameMetadataDefinitionAs_MemberInfo = new(this, "HasSameMetadataDefinitionAs", 0, typeof(System.Reflection.MemberInfo));
					r_RHasSameMetadataDefinitionAs_MemberInfo.SetBelong(this.instance);
				}
				return r_RHasSameMetadataDefinitionAs_MemberInfo;
			}
		}

		/// <summary>
		/// System.Collections.Generic.IList`1[System.Reflection.CustomAttributeData] GetCustomAttributesData()
		/// </summary>
		protected RMethod r_RGetCustomAttributesData;
		public virtual RMethod RGetCustomAttributesData
		{
			get
			{
				if(r_RGetCustomAttributesData == null)
				{
					r_RGetCustomAttributesData = new(this, "GetCustomAttributesData", 0);
					r_RGetCustomAttributesData.SetBelong(this.instance);
				}
				return r_RGetCustomAttributesData;
			}
		}

		/// <summary>
		/// Boolean CacheEquals(System.Object)
		/// </summary>
		protected RMethod r_RCacheEquals_Object;
		public virtual RMethod RCacheEquals_Object
		{
			get
			{
				if(r_RCacheEquals_Object == null)
				{
					r_RCacheEquals_Object = new(this, "CacheEquals", 0, typeof(System.Object));
					r_RCacheEquals_Object.SetBelong(this.instance);
				}
				return r_RCacheEquals_Object;
			}
		}

		/// <summary>
		/// Boolean HasSameMetadataDefinitionAsCore[TOther](System.Reflection.MemberInfo)
		/// </summary>
		protected RMethod r_RHasSameMetadataDefinitionAsCore_GTOther_MemberInfo;
		public virtual RMethod RHasSameMetadataDefinitionAsCore_GTOther_MemberInfo
		{
			get
			{
				if(r_RHasSameMetadataDefinitionAsCore_GTOther_MemberInfo == null)
				{
					r_RHasSameMetadataDefinitionAsCore_GTOther_MemberInfo = new(this, "HasSameMetadataDefinitionAsCore", 1, typeof(System.Reflection.MemberInfo));
					r_RHasSameMetadataDefinitionAsCore_GTOther_MemberInfo.SetBelong(this.instance);
				}
				return r_RHasSameMetadataDefinitionAsCore_GTOther_MemberInfo;
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


        public RPropertyBuilder() : base("System.Reflection.Emit.PropertyBuilder")
        {
        }

        public RPropertyBuilder(System.Object instance) : base("System.Reflection.Emit.PropertyBuilder")
		{
            SetInstance(instance);
		}

        public RPropertyBuilder(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RPropertyBuilder(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }

        public virtual void System__1__Runtime__1__InteropServices__1___PropertyBuilder__1__GetIDsOfNames(in System.Guid  @riid, System.IntPtr  @rgszNames, System.UInt32  @cNames, System.UInt32  @lcid, System.IntPtr  @rgDispId)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@riid, @rgszNames, @cNames, @lcid, @rgDispId};
            var ___result = RSystem__1__Runtime__1__InteropServices__1___PropertyBuilder__1__GetIDsOfNames_In_Guid_IntPtr_UInt32_UInt32_IntPtr.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void System__1__Runtime__1__InteropServices__1___PropertyBuilder__1__GetTypeInfo(System.UInt32  @iTInfo, System.UInt32  @lcid, System.IntPtr  @ppTInfo)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@iTInfo, @lcid, @ppTInfo};
            var ___result = RSystem__1__Runtime__1__InteropServices__1___PropertyBuilder__1__GetTypeInfo_UInt32_UInt32_IntPtr.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void System__1__Runtime__1__InteropServices__1___PropertyBuilder__1__GetTypeInfoCount(out System.UInt32  @pcTInfo)
        {
			pcTInfo = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@pcTInfo};
            var ___result = RSystem__1__Runtime__1__InteropServices__1___PropertyBuilder__1__GetTypeInfoCount_Out_UInt32.Invoke(___genericsType, ___parameters);
			pcTInfo = (System.UInt32)___parameters[0];

            
        }


        public virtual void System__1__Runtime__1__InteropServices__1___PropertyBuilder__1__Invoke(System.UInt32  @dispIdMember, in System.Guid  @riid, System.UInt32  @lcid, System.Int16  @wFlags, System.IntPtr  @pDispParams, System.IntPtr  @pVarResult, System.IntPtr  @pExcepInfo, System.IntPtr  @puArgErr)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@dispIdMember, @riid, @lcid, @wFlags, @pDispParams, @pVarResult, @pExcepInfo, @puArgErr};
            var ___result = RSystem__1__Runtime__1__InteropServices__1___PropertyBuilder__1__Invoke_UInt32_In_Guid_UInt32_Int16_IntPtr_IntPtr_IntPtr_IntPtr.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void AddOtherMethod(System.Reflection.Emit.MethodBuilder  @mdBuilder)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@mdBuilder};
            var ___result = RAddOtherMethod_MethodBuilder.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Reflection.MethodInfo[] GetAccessors(System.Boolean  @nonPublic)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@nonPublic};
            var ___result = RGetAccessors_Boolean.Invoke(___genericsType, ___parameters);

            return (System.Reflection.MethodInfo[])___result;
        }


        public virtual System.Object[] GetCustomAttributes(System.Boolean  @inherit)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@inherit};
            var ___result = RGetCustomAttributes_Boolean.Invoke(___genericsType, ___parameters);

            return (System.Object[])___result;
        }


        public virtual System.Object[] GetCustomAttributes(System.Type  @attributeType, System.Boolean  @inherit)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@attributeType, @inherit};
            var ___result = RGetCustomAttributes_Type_Boolean.Invoke(___genericsType, ___parameters);

            return (System.Object[])___result;
        }


        public virtual System.Reflection.MethodInfo GetGetMethod(System.Boolean  @nonPublic)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@nonPublic};
            var ___result = RGetGetMethod_Boolean.Invoke(___genericsType, ___parameters);

            return (System.Reflection.MethodInfo)___result;
        }


        public virtual System.Reflection.ParameterInfo[] GetIndexParameters()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetIndexParameters.Invoke(___genericsType, ___parameters);

            return (System.Reflection.ParameterInfo[])___result;
        }


        public virtual System.Reflection.MethodInfo GetSetMethod(System.Boolean  @nonPublic)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@nonPublic};
            var ___result = RGetSetMethod_Boolean.Invoke(___genericsType, ___parameters);

            return (System.Reflection.MethodInfo)___result;
        }


        public virtual System.Object GetValue(System.Object  @obj, System.Object[]  @index)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@obj, @index};
            var ___result = RGetValue_Object_ObjectArray.Invoke(___genericsType, ___parameters);

            return (System.Object)___result;
        }


        public virtual System.Object GetValue(System.Object  @obj, System.Reflection.BindingFlags  @invokeAttr, System.Reflection.Binder  @binder, System.Object[]  @index, System.Globalization.CultureInfo  @culture)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@obj, @invokeAttr, @binder, @index, @culture};
            var ___result = RGetValue_Object_BindingFlags_Binder_ObjectArray_CultureInfo.Invoke(___genericsType, ___parameters);

            return (System.Object)___result;
        }


        public virtual System.Boolean IsDefined(System.Type  @attributeType, System.Boolean  @inherit)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@attributeType, @inherit};
            var ___result = RIsDefined_Type_Boolean.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual void SetConstant(System.Object  @defaultValue)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@defaultValue};
            var ___result = RSetConstant_Object.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetCustomAttribute(System.Reflection.Emit.CustomAttributeBuilder  @customBuilder)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@customBuilder};
            var ___result = RSetCustomAttribute_CustomAttributeBuilder.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetCustomAttribute(System.Reflection.ConstructorInfo  @con, System.Byte[]  @binaryAttribute)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@con, @binaryAttribute};
            var ___result = RSetCustomAttribute_ConstructorInfo_ByteArray.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetGetMethod(System.Reflection.Emit.MethodBuilder  @mdBuilder)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@mdBuilder};
            var ___result = RSetGetMethod_MethodBuilder.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetSetMethod(System.Reflection.Emit.MethodBuilder  @mdBuilder)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@mdBuilder};
            var ___result = RSetSetMethod_MethodBuilder.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetValue(System.Object  @obj, System.Object  @value, System.Object[]  @index)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@obj, @value, @index};
            var ___result = RSetValue_Object_Object_ObjectArray.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetValue(System.Object  @obj, System.Object  @value, System.Reflection.BindingFlags  @invokeAttr, System.Reflection.Binder  @binder, System.Object[]  @index, System.Globalization.CultureInfo  @culture)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@obj, @value, @invokeAttr, @binder, @index, @culture};
            var ___result = RSetValue_Object_Object_BindingFlags_Binder_ObjectArray_CultureInfo.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Exception not_supported()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = Rnot_supported.Invoke(___genericsType, ___parameters);

            return (System.Exception)___result;
        }


        public virtual System.Reflection.MethodInfo[] GetAccessors()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetAccessors.Invoke(___genericsType, ___parameters);

            return (System.Reflection.MethodInfo[])___result;
        }


        public virtual System.Reflection.MethodInfo GetGetMethod()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetGetMethod.Invoke(___genericsType, ___parameters);

            return (System.Reflection.MethodInfo)___result;
        }


        public virtual System.Reflection.MethodInfo GetSetMethod()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetSetMethod.Invoke(___genericsType, ___parameters);

            return (System.Reflection.MethodInfo)___result;
        }


        public virtual System.Type[] GetOptionalCustomModifiers()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetOptionalCustomModifiers.Invoke(___genericsType, ___parameters);

            return (System.Type[])___result;
        }


        public virtual System.Type[] GetRequiredCustomModifiers()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetRequiredCustomModifiers.Invoke(___genericsType, ___parameters);

            return (System.Type[])___result;
        }


        public virtual System.Object GetValue(System.Object  @obj)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@obj};
            var ___result = RGetValue_Object.Invoke(___genericsType, ___parameters);

            return (System.Object)___result;
        }


        public virtual System.Object GetConstantValue()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetConstantValue.Invoke(___genericsType, ___parameters);

            return (System.Object)___result;
        }


        public virtual System.Object GetRawConstantValue()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetRawConstantValue.Invoke(___genericsType, ___parameters);

            return (System.Object)___result;
        }


        public virtual void SetValue(System.Object  @obj, System.Object  @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@obj, @value};
            var ___result = RSetValue_Object_Object.Invoke(___genericsType, ___parameters);

            
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


        public virtual System.Boolean HasSameMetadataDefinitionAs(System.Reflection.MemberInfo  @other)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@other};
            var ___result = RHasSameMetadataDefinitionAs_MemberInfo.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Collections.Generic.IList<System.Reflection.CustomAttributeData> GetCustomAttributesData()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetCustomAttributesData.Invoke(___genericsType, ___parameters);

            return (System.Collections.Generic.IList<System.Reflection.CustomAttributeData>)___result;
        }


        public virtual System.Boolean CacheEquals(System.Object  @o)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@o};
            var ___result = RCacheEquals_Object.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean HasSameMetadataDefinitionAsCore<TOther>(System.Reflection.MemberInfo  @other) where TOther : System.Reflection.MemberInfo
        {

            var ___genericsType = new Type[] {typeof(TOther)};
            var ___parameters = new object[]{@other};
            var ___result = RHasSameMetadataDefinitionAsCore_GTOther_MemberInfo.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
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


        public virtual System.String ToString()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RToString.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


    }
}
