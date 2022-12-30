using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.RSystem.RXml.RSchema
{
	/// <summary>
	/// System.Xml.Schema.SchemaNames
	/// </summary>
    public partial class RSchemaNames : RMember //
    {

		/// <summary>
		/// System.Xml.XmlNameTable nameTable
		/// </summary>
		protected RSystem.RXml.RXmlNameTable r_nameTable;
		public virtual RSystem.RXml.RXmlNameTable RnameTable
		{
			get
			{
				if(r_nameTable == null)
				{
					r_nameTable = new(this, "nameTable");
					r_nameTable.SetBelong(this.instance);
				}
				return r_nameTable;
			}
		}

		/// <summary>
		/// System.String NsDataType
		/// </summary>
		protected RField r_NsDataType;
		public virtual RField RNsDataType
		{
			get
			{
				if(r_NsDataType == null)
				{
					r_NsDataType = new(this, "NsDataType");
					r_NsDataType.SetBelong(this.instance);
				}
				return r_NsDataType;
			}
		}

		/// <summary>
		/// System.String NsDataTypeAlias
		/// </summary>
		protected RField r_NsDataTypeAlias;
		public virtual RField RNsDataTypeAlias
		{
			get
			{
				if(r_NsDataTypeAlias == null)
				{
					r_NsDataTypeAlias = new(this, "NsDataTypeAlias");
					r_NsDataTypeAlias.SetBelong(this.instance);
				}
				return r_NsDataTypeAlias;
			}
		}

		/// <summary>
		/// System.String NsDataTypeOld
		/// </summary>
		protected RField r_NsDataTypeOld;
		public virtual RField RNsDataTypeOld
		{
			get
			{
				if(r_NsDataTypeOld == null)
				{
					r_NsDataTypeOld = new(this, "NsDataTypeOld");
					r_NsDataTypeOld.SetBelong(this.instance);
				}
				return r_NsDataTypeOld;
			}
		}

		/// <summary>
		/// System.String NsXml
		/// </summary>
		protected RField r_NsXml;
		public virtual RField RNsXml
		{
			get
			{
				if(r_NsXml == null)
				{
					r_NsXml = new(this, "NsXml");
					r_NsXml.SetBelong(this.instance);
				}
				return r_NsXml;
			}
		}

		/// <summary>
		/// System.String NsXmlNs
		/// </summary>
		protected RField r_NsXmlNs;
		public virtual RField RNsXmlNs
		{
			get
			{
				if(r_NsXmlNs == null)
				{
					r_NsXmlNs = new(this, "NsXmlNs");
					r_NsXmlNs.SetBelong(this.instance);
				}
				return r_NsXmlNs;
			}
		}

		/// <summary>
		/// System.String NsXdr
		/// </summary>
		protected RField r_NsXdr;
		public virtual RField RNsXdr
		{
			get
			{
				if(r_NsXdr == null)
				{
					r_NsXdr = new(this, "NsXdr");
					r_NsXdr.SetBelong(this.instance);
				}
				return r_NsXdr;
			}
		}

		/// <summary>
		/// System.String NsXdrAlias
		/// </summary>
		protected RField r_NsXdrAlias;
		public virtual RField RNsXdrAlias
		{
			get
			{
				if(r_NsXdrAlias == null)
				{
					r_NsXdrAlias = new(this, "NsXdrAlias");
					r_NsXdrAlias.SetBelong(this.instance);
				}
				return r_NsXdrAlias;
			}
		}

		/// <summary>
		/// System.String NsXs
		/// </summary>
		protected RField r_NsXs;
		public virtual RField RNsXs
		{
			get
			{
				if(r_NsXs == null)
				{
					r_NsXs = new(this, "NsXs");
					r_NsXs.SetBelong(this.instance);
				}
				return r_NsXs;
			}
		}

		/// <summary>
		/// System.String NsXsi
		/// </summary>
		protected RField r_NsXsi;
		public virtual RField RNsXsi
		{
			get
			{
				if(r_NsXsi == null)
				{
					r_NsXsi = new(this, "NsXsi");
					r_NsXsi.SetBelong(this.instance);
				}
				return r_NsXsi;
			}
		}

		/// <summary>
		/// System.String XsiType
		/// </summary>
		protected RField r_XsiType;
		public virtual RField RXsiType
		{
			get
			{
				if(r_XsiType == null)
				{
					r_XsiType = new(this, "XsiType");
					r_XsiType.SetBelong(this.instance);
				}
				return r_XsiType;
			}
		}

		/// <summary>
		/// System.String XsiNil
		/// </summary>
		protected RField r_XsiNil;
		public virtual RField RXsiNil
		{
			get
			{
				if(r_XsiNil == null)
				{
					r_XsiNil = new(this, "XsiNil");
					r_XsiNil.SetBelong(this.instance);
				}
				return r_XsiNil;
			}
		}

		/// <summary>
		/// System.String XsiSchemaLocation
		/// </summary>
		protected RField r_XsiSchemaLocation;
		public virtual RField RXsiSchemaLocation
		{
			get
			{
				if(r_XsiSchemaLocation == null)
				{
					r_XsiSchemaLocation = new(this, "XsiSchemaLocation");
					r_XsiSchemaLocation.SetBelong(this.instance);
				}
				return r_XsiSchemaLocation;
			}
		}

		/// <summary>
		/// System.String XsiNoNamespaceSchemaLocation
		/// </summary>
		protected RField r_XsiNoNamespaceSchemaLocation;
		public virtual RField RXsiNoNamespaceSchemaLocation
		{
			get
			{
				if(r_XsiNoNamespaceSchemaLocation == null)
				{
					r_XsiNoNamespaceSchemaLocation = new(this, "XsiNoNamespaceSchemaLocation");
					r_XsiNoNamespaceSchemaLocation.SetBelong(this.instance);
				}
				return r_XsiNoNamespaceSchemaLocation;
			}
		}

		/// <summary>
		/// System.String XsdSchema
		/// </summary>
		protected RField r_XsdSchema;
		public virtual RField RXsdSchema
		{
			get
			{
				if(r_XsdSchema == null)
				{
					r_XsdSchema = new(this, "XsdSchema");
					r_XsdSchema.SetBelong(this.instance);
				}
				return r_XsdSchema;
			}
		}

		/// <summary>
		/// System.String XdrSchema
		/// </summary>
		protected RField r_XdrSchema;
		public virtual RField RXdrSchema
		{
			get
			{
				if(r_XdrSchema == null)
				{
					r_XdrSchema = new(this, "XdrSchema");
					r_XdrSchema.SetBelong(this.instance);
				}
				return r_XdrSchema;
			}
		}

		/// <summary>
		/// System.Xml.XmlQualifiedName QnPCData
		/// </summary>
		protected RSystem.RXml.RXmlQualifiedName r_QnPCData;
		public virtual RSystem.RXml.RXmlQualifiedName RQnPCData
		{
			get
			{
				if(r_QnPCData == null)
				{
					r_QnPCData = new(this, "QnPCData");
					r_QnPCData.SetBelong(this.instance);
				}
				return r_QnPCData;
			}
		}

		/// <summary>
		/// System.Xml.XmlQualifiedName QnXml
		/// </summary>
		protected RSystem.RXml.RXmlQualifiedName r_QnXml;
		public virtual RSystem.RXml.RXmlQualifiedName RQnXml
		{
			get
			{
				if(r_QnXml == null)
				{
					r_QnXml = new(this, "QnXml");
					r_QnXml.SetBelong(this.instance);
				}
				return r_QnXml;
			}
		}

		/// <summary>
		/// System.Xml.XmlQualifiedName QnXmlNs
		/// </summary>
		protected RSystem.RXml.RXmlQualifiedName r_QnXmlNs;
		public virtual RSystem.RXml.RXmlQualifiedName RQnXmlNs
		{
			get
			{
				if(r_QnXmlNs == null)
				{
					r_QnXmlNs = new(this, "QnXmlNs");
					r_QnXmlNs.SetBelong(this.instance);
				}
				return r_QnXmlNs;
			}
		}

		/// <summary>
		/// System.Xml.XmlQualifiedName QnDtDt
		/// </summary>
		protected RSystem.RXml.RXmlQualifiedName r_QnDtDt;
		public virtual RSystem.RXml.RXmlQualifiedName RQnDtDt
		{
			get
			{
				if(r_QnDtDt == null)
				{
					r_QnDtDt = new(this, "QnDtDt");
					r_QnDtDt.SetBelong(this.instance);
				}
				return r_QnDtDt;
			}
		}

		/// <summary>
		/// System.Xml.XmlQualifiedName QnXmlLang
		/// </summary>
		protected RSystem.RXml.RXmlQualifiedName r_QnXmlLang;
		public virtual RSystem.RXml.RXmlQualifiedName RQnXmlLang
		{
			get
			{
				if(r_QnXmlLang == null)
				{
					r_QnXmlLang = new(this, "QnXmlLang");
					r_QnXmlLang.SetBelong(this.instance);
				}
				return r_QnXmlLang;
			}
		}

		/// <summary>
		/// System.Xml.XmlQualifiedName QnName
		/// </summary>
		protected RSystem.RXml.RXmlQualifiedName r_QnName;
		public virtual RSystem.RXml.RXmlQualifiedName RQnName
		{
			get
			{
				if(r_QnName == null)
				{
					r_QnName = new(this, "QnName");
					r_QnName.SetBelong(this.instance);
				}
				return r_QnName;
			}
		}

		/// <summary>
		/// System.Xml.XmlQualifiedName QnType
		/// </summary>
		protected RSystem.RXml.RXmlQualifiedName r_QnType;
		public virtual RSystem.RXml.RXmlQualifiedName RQnType
		{
			get
			{
				if(r_QnType == null)
				{
					r_QnType = new(this, "QnType");
					r_QnType.SetBelong(this.instance);
				}
				return r_QnType;
			}
		}

		/// <summary>
		/// System.Xml.XmlQualifiedName QnMaxOccurs
		/// </summary>
		protected RSystem.RXml.RXmlQualifiedName r_QnMaxOccurs;
		public virtual RSystem.RXml.RXmlQualifiedName RQnMaxOccurs
		{
			get
			{
				if(r_QnMaxOccurs == null)
				{
					r_QnMaxOccurs = new(this, "QnMaxOccurs");
					r_QnMaxOccurs.SetBelong(this.instance);
				}
				return r_QnMaxOccurs;
			}
		}

		/// <summary>
		/// System.Xml.XmlQualifiedName QnMinOccurs
		/// </summary>
		protected RSystem.RXml.RXmlQualifiedName r_QnMinOccurs;
		public virtual RSystem.RXml.RXmlQualifiedName RQnMinOccurs
		{
			get
			{
				if(r_QnMinOccurs == null)
				{
					r_QnMinOccurs = new(this, "QnMinOccurs");
					r_QnMinOccurs.SetBelong(this.instance);
				}
				return r_QnMinOccurs;
			}
		}

		/// <summary>
		/// System.Xml.XmlQualifiedName QnInfinite
		/// </summary>
		protected RSystem.RXml.RXmlQualifiedName r_QnInfinite;
		public virtual RSystem.RXml.RXmlQualifiedName RQnInfinite
		{
			get
			{
				if(r_QnInfinite == null)
				{
					r_QnInfinite = new(this, "QnInfinite");
					r_QnInfinite.SetBelong(this.instance);
				}
				return r_QnInfinite;
			}
		}

		/// <summary>
		/// System.Xml.XmlQualifiedName QnModel
		/// </summary>
		protected RSystem.RXml.RXmlQualifiedName r_QnModel;
		public virtual RSystem.RXml.RXmlQualifiedName RQnModel
		{
			get
			{
				if(r_QnModel == null)
				{
					r_QnModel = new(this, "QnModel");
					r_QnModel.SetBelong(this.instance);
				}
				return r_QnModel;
			}
		}

		/// <summary>
		/// System.Xml.XmlQualifiedName QnOpen
		/// </summary>
		protected RSystem.RXml.RXmlQualifiedName r_QnOpen;
		public virtual RSystem.RXml.RXmlQualifiedName RQnOpen
		{
			get
			{
				if(r_QnOpen == null)
				{
					r_QnOpen = new(this, "QnOpen");
					r_QnOpen.SetBelong(this.instance);
				}
				return r_QnOpen;
			}
		}

		/// <summary>
		/// System.Xml.XmlQualifiedName QnClosed
		/// </summary>
		protected RSystem.RXml.RXmlQualifiedName r_QnClosed;
		public virtual RSystem.RXml.RXmlQualifiedName RQnClosed
		{
			get
			{
				if(r_QnClosed == null)
				{
					r_QnClosed = new(this, "QnClosed");
					r_QnClosed.SetBelong(this.instance);
				}
				return r_QnClosed;
			}
		}

		/// <summary>
		/// System.Xml.XmlQualifiedName QnContent
		/// </summary>
		protected RSystem.RXml.RXmlQualifiedName r_QnContent;
		public virtual RSystem.RXml.RXmlQualifiedName RQnContent
		{
			get
			{
				if(r_QnContent == null)
				{
					r_QnContent = new(this, "QnContent");
					r_QnContent.SetBelong(this.instance);
				}
				return r_QnContent;
			}
		}

		/// <summary>
		/// System.Xml.XmlQualifiedName QnMixed
		/// </summary>
		protected RSystem.RXml.RXmlQualifiedName r_QnMixed;
		public virtual RSystem.RXml.RXmlQualifiedName RQnMixed
		{
			get
			{
				if(r_QnMixed == null)
				{
					r_QnMixed = new(this, "QnMixed");
					r_QnMixed.SetBelong(this.instance);
				}
				return r_QnMixed;
			}
		}

		/// <summary>
		/// System.Xml.XmlQualifiedName QnEmpty
		/// </summary>
		protected RSystem.RXml.RXmlQualifiedName r_QnEmpty;
		public virtual RSystem.RXml.RXmlQualifiedName RQnEmpty
		{
			get
			{
				if(r_QnEmpty == null)
				{
					r_QnEmpty = new(this, "QnEmpty");
					r_QnEmpty.SetBelong(this.instance);
				}
				return r_QnEmpty;
			}
		}

		/// <summary>
		/// System.Xml.XmlQualifiedName QnEltOnly
		/// </summary>
		protected RSystem.RXml.RXmlQualifiedName r_QnEltOnly;
		public virtual RSystem.RXml.RXmlQualifiedName RQnEltOnly
		{
			get
			{
				if(r_QnEltOnly == null)
				{
					r_QnEltOnly = new(this, "QnEltOnly");
					r_QnEltOnly.SetBelong(this.instance);
				}
				return r_QnEltOnly;
			}
		}

		/// <summary>
		/// System.Xml.XmlQualifiedName QnTextOnly
		/// </summary>
		protected RSystem.RXml.RXmlQualifiedName r_QnTextOnly;
		public virtual RSystem.RXml.RXmlQualifiedName RQnTextOnly
		{
			get
			{
				if(r_QnTextOnly == null)
				{
					r_QnTextOnly = new(this, "QnTextOnly");
					r_QnTextOnly.SetBelong(this.instance);
				}
				return r_QnTextOnly;
			}
		}

		/// <summary>
		/// System.Xml.XmlQualifiedName QnOrder
		/// </summary>
		protected RSystem.RXml.RXmlQualifiedName r_QnOrder;
		public virtual RSystem.RXml.RXmlQualifiedName RQnOrder
		{
			get
			{
				if(r_QnOrder == null)
				{
					r_QnOrder = new(this, "QnOrder");
					r_QnOrder.SetBelong(this.instance);
				}
				return r_QnOrder;
			}
		}

		/// <summary>
		/// System.Xml.XmlQualifiedName QnSeq
		/// </summary>
		protected RSystem.RXml.RXmlQualifiedName r_QnSeq;
		public virtual RSystem.RXml.RXmlQualifiedName RQnSeq
		{
			get
			{
				if(r_QnSeq == null)
				{
					r_QnSeq = new(this, "QnSeq");
					r_QnSeq.SetBelong(this.instance);
				}
				return r_QnSeq;
			}
		}

		/// <summary>
		/// System.Xml.XmlQualifiedName QnOne
		/// </summary>
		protected RSystem.RXml.RXmlQualifiedName r_QnOne;
		public virtual RSystem.RXml.RXmlQualifiedName RQnOne
		{
			get
			{
				if(r_QnOne == null)
				{
					r_QnOne = new(this, "QnOne");
					r_QnOne.SetBelong(this.instance);
				}
				return r_QnOne;
			}
		}

		/// <summary>
		/// System.Xml.XmlQualifiedName QnMany
		/// </summary>
		protected RSystem.RXml.RXmlQualifiedName r_QnMany;
		public virtual RSystem.RXml.RXmlQualifiedName RQnMany
		{
			get
			{
				if(r_QnMany == null)
				{
					r_QnMany = new(this, "QnMany");
					r_QnMany.SetBelong(this.instance);
				}
				return r_QnMany;
			}
		}

		/// <summary>
		/// System.Xml.XmlQualifiedName QnRequired
		/// </summary>
		protected RSystem.RXml.RXmlQualifiedName r_QnRequired;
		public virtual RSystem.RXml.RXmlQualifiedName RQnRequired
		{
			get
			{
				if(r_QnRequired == null)
				{
					r_QnRequired = new(this, "QnRequired");
					r_QnRequired.SetBelong(this.instance);
				}
				return r_QnRequired;
			}
		}

		/// <summary>
		/// System.Xml.XmlQualifiedName QnYes
		/// </summary>
		protected RSystem.RXml.RXmlQualifiedName r_QnYes;
		public virtual RSystem.RXml.RXmlQualifiedName RQnYes
		{
			get
			{
				if(r_QnYes == null)
				{
					r_QnYes = new(this, "QnYes");
					r_QnYes.SetBelong(this.instance);
				}
				return r_QnYes;
			}
		}

		/// <summary>
		/// System.Xml.XmlQualifiedName QnNo
		/// </summary>
		protected RSystem.RXml.RXmlQualifiedName r_QnNo;
		public virtual RSystem.RXml.RXmlQualifiedName RQnNo
		{
			get
			{
				if(r_QnNo == null)
				{
					r_QnNo = new(this, "QnNo");
					r_QnNo.SetBelong(this.instance);
				}
				return r_QnNo;
			}
		}

		/// <summary>
		/// System.Xml.XmlQualifiedName QnString
		/// </summary>
		protected RSystem.RXml.RXmlQualifiedName r_QnString;
		public virtual RSystem.RXml.RXmlQualifiedName RQnString
		{
			get
			{
				if(r_QnString == null)
				{
					r_QnString = new(this, "QnString");
					r_QnString.SetBelong(this.instance);
				}
				return r_QnString;
			}
		}

		/// <summary>
		/// System.Xml.XmlQualifiedName QnID
		/// </summary>
		protected RSystem.RXml.RXmlQualifiedName r_QnID;
		public virtual RSystem.RXml.RXmlQualifiedName RQnID
		{
			get
			{
				if(r_QnID == null)
				{
					r_QnID = new(this, "QnID");
					r_QnID.SetBelong(this.instance);
				}
				return r_QnID;
			}
		}

		/// <summary>
		/// System.Xml.XmlQualifiedName QnIDRef
		/// </summary>
		protected RSystem.RXml.RXmlQualifiedName r_QnIDRef;
		public virtual RSystem.RXml.RXmlQualifiedName RQnIDRef
		{
			get
			{
				if(r_QnIDRef == null)
				{
					r_QnIDRef = new(this, "QnIDRef");
					r_QnIDRef.SetBelong(this.instance);
				}
				return r_QnIDRef;
			}
		}

		/// <summary>
		/// System.Xml.XmlQualifiedName QnIDRefs
		/// </summary>
		protected RSystem.RXml.RXmlQualifiedName r_QnIDRefs;
		public virtual RSystem.RXml.RXmlQualifiedName RQnIDRefs
		{
			get
			{
				if(r_QnIDRefs == null)
				{
					r_QnIDRefs = new(this, "QnIDRefs");
					r_QnIDRefs.SetBelong(this.instance);
				}
				return r_QnIDRefs;
			}
		}

		/// <summary>
		/// System.Xml.XmlQualifiedName QnEntity
		/// </summary>
		protected RSystem.RXml.RXmlQualifiedName r_QnEntity;
		public virtual RSystem.RXml.RXmlQualifiedName RQnEntity
		{
			get
			{
				if(r_QnEntity == null)
				{
					r_QnEntity = new(this, "QnEntity");
					r_QnEntity.SetBelong(this.instance);
				}
				return r_QnEntity;
			}
		}

		/// <summary>
		/// System.Xml.XmlQualifiedName QnEntities
		/// </summary>
		protected RSystem.RXml.RXmlQualifiedName r_QnEntities;
		public virtual RSystem.RXml.RXmlQualifiedName RQnEntities
		{
			get
			{
				if(r_QnEntities == null)
				{
					r_QnEntities = new(this, "QnEntities");
					r_QnEntities.SetBelong(this.instance);
				}
				return r_QnEntities;
			}
		}

		/// <summary>
		/// System.Xml.XmlQualifiedName QnNmToken
		/// </summary>
		protected RSystem.RXml.RXmlQualifiedName r_QnNmToken;
		public virtual RSystem.RXml.RXmlQualifiedName RQnNmToken
		{
			get
			{
				if(r_QnNmToken == null)
				{
					r_QnNmToken = new(this, "QnNmToken");
					r_QnNmToken.SetBelong(this.instance);
				}
				return r_QnNmToken;
			}
		}

		/// <summary>
		/// System.Xml.XmlQualifiedName QnNmTokens
		/// </summary>
		protected RSystem.RXml.RXmlQualifiedName r_QnNmTokens;
		public virtual RSystem.RXml.RXmlQualifiedName RQnNmTokens
		{
			get
			{
				if(r_QnNmTokens == null)
				{
					r_QnNmTokens = new(this, "QnNmTokens");
					r_QnNmTokens.SetBelong(this.instance);
				}
				return r_QnNmTokens;
			}
		}

		/// <summary>
		/// System.Xml.XmlQualifiedName QnEnumeration
		/// </summary>
		protected RSystem.RXml.RXmlQualifiedName r_QnEnumeration;
		public virtual RSystem.RXml.RXmlQualifiedName RQnEnumeration
		{
			get
			{
				if(r_QnEnumeration == null)
				{
					r_QnEnumeration = new(this, "QnEnumeration");
					r_QnEnumeration.SetBelong(this.instance);
				}
				return r_QnEnumeration;
			}
		}

		/// <summary>
		/// System.Xml.XmlQualifiedName QnDefault
		/// </summary>
		protected RSystem.RXml.RXmlQualifiedName r_QnDefault;
		public virtual RSystem.RXml.RXmlQualifiedName RQnDefault
		{
			get
			{
				if(r_QnDefault == null)
				{
					r_QnDefault = new(this, "QnDefault");
					r_QnDefault.SetBelong(this.instance);
				}
				return r_QnDefault;
			}
		}

		/// <summary>
		/// System.Xml.XmlQualifiedName QnXdrSchema
		/// </summary>
		protected RSystem.RXml.RXmlQualifiedName r_QnXdrSchema;
		public virtual RSystem.RXml.RXmlQualifiedName RQnXdrSchema
		{
			get
			{
				if(r_QnXdrSchema == null)
				{
					r_QnXdrSchema = new(this, "QnXdrSchema");
					r_QnXdrSchema.SetBelong(this.instance);
				}
				return r_QnXdrSchema;
			}
		}

		/// <summary>
		/// System.Xml.XmlQualifiedName QnXdrElementType
		/// </summary>
		protected RSystem.RXml.RXmlQualifiedName r_QnXdrElementType;
		public virtual RSystem.RXml.RXmlQualifiedName RQnXdrElementType
		{
			get
			{
				if(r_QnXdrElementType == null)
				{
					r_QnXdrElementType = new(this, "QnXdrElementType");
					r_QnXdrElementType.SetBelong(this.instance);
				}
				return r_QnXdrElementType;
			}
		}

		/// <summary>
		/// System.Xml.XmlQualifiedName QnXdrElement
		/// </summary>
		protected RSystem.RXml.RXmlQualifiedName r_QnXdrElement;
		public virtual RSystem.RXml.RXmlQualifiedName RQnXdrElement
		{
			get
			{
				if(r_QnXdrElement == null)
				{
					r_QnXdrElement = new(this, "QnXdrElement");
					r_QnXdrElement.SetBelong(this.instance);
				}
				return r_QnXdrElement;
			}
		}

		/// <summary>
		/// System.Xml.XmlQualifiedName QnXdrGroup
		/// </summary>
		protected RSystem.RXml.RXmlQualifiedName r_QnXdrGroup;
		public virtual RSystem.RXml.RXmlQualifiedName RQnXdrGroup
		{
			get
			{
				if(r_QnXdrGroup == null)
				{
					r_QnXdrGroup = new(this, "QnXdrGroup");
					r_QnXdrGroup.SetBelong(this.instance);
				}
				return r_QnXdrGroup;
			}
		}

		/// <summary>
		/// System.Xml.XmlQualifiedName QnXdrAttributeType
		/// </summary>
		protected RSystem.RXml.RXmlQualifiedName r_QnXdrAttributeType;
		public virtual RSystem.RXml.RXmlQualifiedName RQnXdrAttributeType
		{
			get
			{
				if(r_QnXdrAttributeType == null)
				{
					r_QnXdrAttributeType = new(this, "QnXdrAttributeType");
					r_QnXdrAttributeType.SetBelong(this.instance);
				}
				return r_QnXdrAttributeType;
			}
		}

		/// <summary>
		/// System.Xml.XmlQualifiedName QnXdrAttribute
		/// </summary>
		protected RSystem.RXml.RXmlQualifiedName r_QnXdrAttribute;
		public virtual RSystem.RXml.RXmlQualifiedName RQnXdrAttribute
		{
			get
			{
				if(r_QnXdrAttribute == null)
				{
					r_QnXdrAttribute = new(this, "QnXdrAttribute");
					r_QnXdrAttribute.SetBelong(this.instance);
				}
				return r_QnXdrAttribute;
			}
		}

		/// <summary>
		/// System.Xml.XmlQualifiedName QnXdrDataType
		/// </summary>
		protected RSystem.RXml.RXmlQualifiedName r_QnXdrDataType;
		public virtual RSystem.RXml.RXmlQualifiedName RQnXdrDataType
		{
			get
			{
				if(r_QnXdrDataType == null)
				{
					r_QnXdrDataType = new(this, "QnXdrDataType");
					r_QnXdrDataType.SetBelong(this.instance);
				}
				return r_QnXdrDataType;
			}
		}

		/// <summary>
		/// System.Xml.XmlQualifiedName QnXdrDescription
		/// </summary>
		protected RSystem.RXml.RXmlQualifiedName r_QnXdrDescription;
		public virtual RSystem.RXml.RXmlQualifiedName RQnXdrDescription
		{
			get
			{
				if(r_QnXdrDescription == null)
				{
					r_QnXdrDescription = new(this, "QnXdrDescription");
					r_QnXdrDescription.SetBelong(this.instance);
				}
				return r_QnXdrDescription;
			}
		}

		/// <summary>
		/// System.Xml.XmlQualifiedName QnXdrExtends
		/// </summary>
		protected RSystem.RXml.RXmlQualifiedName r_QnXdrExtends;
		public virtual RSystem.RXml.RXmlQualifiedName RQnXdrExtends
		{
			get
			{
				if(r_QnXdrExtends == null)
				{
					r_QnXdrExtends = new(this, "QnXdrExtends");
					r_QnXdrExtends.SetBelong(this.instance);
				}
				return r_QnXdrExtends;
			}
		}

		/// <summary>
		/// System.Xml.XmlQualifiedName QnXdrAliasSchema
		/// </summary>
		protected RSystem.RXml.RXmlQualifiedName r_QnXdrAliasSchema;
		public virtual RSystem.RXml.RXmlQualifiedName RQnXdrAliasSchema
		{
			get
			{
				if(r_QnXdrAliasSchema == null)
				{
					r_QnXdrAliasSchema = new(this, "QnXdrAliasSchema");
					r_QnXdrAliasSchema.SetBelong(this.instance);
				}
				return r_QnXdrAliasSchema;
			}
		}

		/// <summary>
		/// System.Xml.XmlQualifiedName QnDtType
		/// </summary>
		protected RSystem.RXml.RXmlQualifiedName r_QnDtType;
		public virtual RSystem.RXml.RXmlQualifiedName RQnDtType
		{
			get
			{
				if(r_QnDtType == null)
				{
					r_QnDtType = new(this, "QnDtType");
					r_QnDtType.SetBelong(this.instance);
				}
				return r_QnDtType;
			}
		}

		/// <summary>
		/// System.Xml.XmlQualifiedName QnDtValues
		/// </summary>
		protected RSystem.RXml.RXmlQualifiedName r_QnDtValues;
		public virtual RSystem.RXml.RXmlQualifiedName RQnDtValues
		{
			get
			{
				if(r_QnDtValues == null)
				{
					r_QnDtValues = new(this, "QnDtValues");
					r_QnDtValues.SetBelong(this.instance);
				}
				return r_QnDtValues;
			}
		}

		/// <summary>
		/// System.Xml.XmlQualifiedName QnDtMaxLength
		/// </summary>
		protected RSystem.RXml.RXmlQualifiedName r_QnDtMaxLength;
		public virtual RSystem.RXml.RXmlQualifiedName RQnDtMaxLength
		{
			get
			{
				if(r_QnDtMaxLength == null)
				{
					r_QnDtMaxLength = new(this, "QnDtMaxLength");
					r_QnDtMaxLength.SetBelong(this.instance);
				}
				return r_QnDtMaxLength;
			}
		}

		/// <summary>
		/// System.Xml.XmlQualifiedName QnDtMinLength
		/// </summary>
		protected RSystem.RXml.RXmlQualifiedName r_QnDtMinLength;
		public virtual RSystem.RXml.RXmlQualifiedName RQnDtMinLength
		{
			get
			{
				if(r_QnDtMinLength == null)
				{
					r_QnDtMinLength = new(this, "QnDtMinLength");
					r_QnDtMinLength.SetBelong(this.instance);
				}
				return r_QnDtMinLength;
			}
		}

		/// <summary>
		/// System.Xml.XmlQualifiedName QnDtMax
		/// </summary>
		protected RSystem.RXml.RXmlQualifiedName r_QnDtMax;
		public virtual RSystem.RXml.RXmlQualifiedName RQnDtMax
		{
			get
			{
				if(r_QnDtMax == null)
				{
					r_QnDtMax = new(this, "QnDtMax");
					r_QnDtMax.SetBelong(this.instance);
				}
				return r_QnDtMax;
			}
		}

		/// <summary>
		/// System.Xml.XmlQualifiedName QnDtMin
		/// </summary>
		protected RSystem.RXml.RXmlQualifiedName r_QnDtMin;
		public virtual RSystem.RXml.RXmlQualifiedName RQnDtMin
		{
			get
			{
				if(r_QnDtMin == null)
				{
					r_QnDtMin = new(this, "QnDtMin");
					r_QnDtMin.SetBelong(this.instance);
				}
				return r_QnDtMin;
			}
		}

		/// <summary>
		/// System.Xml.XmlQualifiedName QnDtMinExclusive
		/// </summary>
		protected RSystem.RXml.RXmlQualifiedName r_QnDtMinExclusive;
		public virtual RSystem.RXml.RXmlQualifiedName RQnDtMinExclusive
		{
			get
			{
				if(r_QnDtMinExclusive == null)
				{
					r_QnDtMinExclusive = new(this, "QnDtMinExclusive");
					r_QnDtMinExclusive.SetBelong(this.instance);
				}
				return r_QnDtMinExclusive;
			}
		}

		/// <summary>
		/// System.Xml.XmlQualifiedName QnDtMaxExclusive
		/// </summary>
		protected RSystem.RXml.RXmlQualifiedName r_QnDtMaxExclusive;
		public virtual RSystem.RXml.RXmlQualifiedName RQnDtMaxExclusive
		{
			get
			{
				if(r_QnDtMaxExclusive == null)
				{
					r_QnDtMaxExclusive = new(this, "QnDtMaxExclusive");
					r_QnDtMaxExclusive.SetBelong(this.instance);
				}
				return r_QnDtMaxExclusive;
			}
		}

		/// <summary>
		/// System.Xml.XmlQualifiedName QnTargetNamespace
		/// </summary>
		protected RSystem.RXml.RXmlQualifiedName r_QnTargetNamespace;
		public virtual RSystem.RXml.RXmlQualifiedName RQnTargetNamespace
		{
			get
			{
				if(r_QnTargetNamespace == null)
				{
					r_QnTargetNamespace = new(this, "QnTargetNamespace");
					r_QnTargetNamespace.SetBelong(this.instance);
				}
				return r_QnTargetNamespace;
			}
		}

		/// <summary>
		/// System.Xml.XmlQualifiedName QnVersion
		/// </summary>
		protected RSystem.RXml.RXmlQualifiedName r_QnVersion;
		public virtual RSystem.RXml.RXmlQualifiedName RQnVersion
		{
			get
			{
				if(r_QnVersion == null)
				{
					r_QnVersion = new(this, "QnVersion");
					r_QnVersion.SetBelong(this.instance);
				}
				return r_QnVersion;
			}
		}

		/// <summary>
		/// System.Xml.XmlQualifiedName QnFinalDefault
		/// </summary>
		protected RSystem.RXml.RXmlQualifiedName r_QnFinalDefault;
		public virtual RSystem.RXml.RXmlQualifiedName RQnFinalDefault
		{
			get
			{
				if(r_QnFinalDefault == null)
				{
					r_QnFinalDefault = new(this, "QnFinalDefault");
					r_QnFinalDefault.SetBelong(this.instance);
				}
				return r_QnFinalDefault;
			}
		}

		/// <summary>
		/// System.Xml.XmlQualifiedName QnBlockDefault
		/// </summary>
		protected RSystem.RXml.RXmlQualifiedName r_QnBlockDefault;
		public virtual RSystem.RXml.RXmlQualifiedName RQnBlockDefault
		{
			get
			{
				if(r_QnBlockDefault == null)
				{
					r_QnBlockDefault = new(this, "QnBlockDefault");
					r_QnBlockDefault.SetBelong(this.instance);
				}
				return r_QnBlockDefault;
			}
		}

		/// <summary>
		/// System.Xml.XmlQualifiedName QnFixed
		/// </summary>
		protected RSystem.RXml.RXmlQualifiedName r_QnFixed;
		public virtual RSystem.RXml.RXmlQualifiedName RQnFixed
		{
			get
			{
				if(r_QnFixed == null)
				{
					r_QnFixed = new(this, "QnFixed");
					r_QnFixed.SetBelong(this.instance);
				}
				return r_QnFixed;
			}
		}

		/// <summary>
		/// System.Xml.XmlQualifiedName QnAbstract
		/// </summary>
		protected RSystem.RXml.RXmlQualifiedName r_QnAbstract;
		public virtual RSystem.RXml.RXmlQualifiedName RQnAbstract
		{
			get
			{
				if(r_QnAbstract == null)
				{
					r_QnAbstract = new(this, "QnAbstract");
					r_QnAbstract.SetBelong(this.instance);
				}
				return r_QnAbstract;
			}
		}

		/// <summary>
		/// System.Xml.XmlQualifiedName QnBlock
		/// </summary>
		protected RSystem.RXml.RXmlQualifiedName r_QnBlock;
		public virtual RSystem.RXml.RXmlQualifiedName RQnBlock
		{
			get
			{
				if(r_QnBlock == null)
				{
					r_QnBlock = new(this, "QnBlock");
					r_QnBlock.SetBelong(this.instance);
				}
				return r_QnBlock;
			}
		}

		/// <summary>
		/// System.Xml.XmlQualifiedName QnSubstitutionGroup
		/// </summary>
		protected RSystem.RXml.RXmlQualifiedName r_QnSubstitutionGroup;
		public virtual RSystem.RXml.RXmlQualifiedName RQnSubstitutionGroup
		{
			get
			{
				if(r_QnSubstitutionGroup == null)
				{
					r_QnSubstitutionGroup = new(this, "QnSubstitutionGroup");
					r_QnSubstitutionGroup.SetBelong(this.instance);
				}
				return r_QnSubstitutionGroup;
			}
		}

		/// <summary>
		/// System.Xml.XmlQualifiedName QnFinal
		/// </summary>
		protected RSystem.RXml.RXmlQualifiedName r_QnFinal;
		public virtual RSystem.RXml.RXmlQualifiedName RQnFinal
		{
			get
			{
				if(r_QnFinal == null)
				{
					r_QnFinal = new(this, "QnFinal");
					r_QnFinal.SetBelong(this.instance);
				}
				return r_QnFinal;
			}
		}

		/// <summary>
		/// System.Xml.XmlQualifiedName QnNillable
		/// </summary>
		protected RSystem.RXml.RXmlQualifiedName r_QnNillable;
		public virtual RSystem.RXml.RXmlQualifiedName RQnNillable
		{
			get
			{
				if(r_QnNillable == null)
				{
					r_QnNillable = new(this, "QnNillable");
					r_QnNillable.SetBelong(this.instance);
				}
				return r_QnNillable;
			}
		}

		/// <summary>
		/// System.Xml.XmlQualifiedName QnRef
		/// </summary>
		protected RSystem.RXml.RXmlQualifiedName r_QnRef;
		public virtual RSystem.RXml.RXmlQualifiedName RQnRef
		{
			get
			{
				if(r_QnRef == null)
				{
					r_QnRef = new(this, "QnRef");
					r_QnRef.SetBelong(this.instance);
				}
				return r_QnRef;
			}
		}

		/// <summary>
		/// System.Xml.XmlQualifiedName QnBase
		/// </summary>
		protected RSystem.RXml.RXmlQualifiedName r_QnBase;
		public virtual RSystem.RXml.RXmlQualifiedName RQnBase
		{
			get
			{
				if(r_QnBase == null)
				{
					r_QnBase = new(this, "QnBase");
					r_QnBase.SetBelong(this.instance);
				}
				return r_QnBase;
			}
		}

		/// <summary>
		/// System.Xml.XmlQualifiedName QnDerivedBy
		/// </summary>
		protected RSystem.RXml.RXmlQualifiedName r_QnDerivedBy;
		public virtual RSystem.RXml.RXmlQualifiedName RQnDerivedBy
		{
			get
			{
				if(r_QnDerivedBy == null)
				{
					r_QnDerivedBy = new(this, "QnDerivedBy");
					r_QnDerivedBy.SetBelong(this.instance);
				}
				return r_QnDerivedBy;
			}
		}

		/// <summary>
		/// System.Xml.XmlQualifiedName QnNamespace
		/// </summary>
		protected RSystem.RXml.RXmlQualifiedName r_QnNamespace;
		public virtual RSystem.RXml.RXmlQualifiedName RQnNamespace
		{
			get
			{
				if(r_QnNamespace == null)
				{
					r_QnNamespace = new(this, "QnNamespace");
					r_QnNamespace.SetBelong(this.instance);
				}
				return r_QnNamespace;
			}
		}

		/// <summary>
		/// System.Xml.XmlQualifiedName QnProcessContents
		/// </summary>
		protected RSystem.RXml.RXmlQualifiedName r_QnProcessContents;
		public virtual RSystem.RXml.RXmlQualifiedName RQnProcessContents
		{
			get
			{
				if(r_QnProcessContents == null)
				{
					r_QnProcessContents = new(this, "QnProcessContents");
					r_QnProcessContents.SetBelong(this.instance);
				}
				return r_QnProcessContents;
			}
		}

		/// <summary>
		/// System.Xml.XmlQualifiedName QnRefer
		/// </summary>
		protected RSystem.RXml.RXmlQualifiedName r_QnRefer;
		public virtual RSystem.RXml.RXmlQualifiedName RQnRefer
		{
			get
			{
				if(r_QnRefer == null)
				{
					r_QnRefer = new(this, "QnRefer");
					r_QnRefer.SetBelong(this.instance);
				}
				return r_QnRefer;
			}
		}

		/// <summary>
		/// System.Xml.XmlQualifiedName QnPublic
		/// </summary>
		protected RSystem.RXml.RXmlQualifiedName r_QnPublic;
		public virtual RSystem.RXml.RXmlQualifiedName RQnPublic
		{
			get
			{
				if(r_QnPublic == null)
				{
					r_QnPublic = new(this, "QnPublic");
					r_QnPublic.SetBelong(this.instance);
				}
				return r_QnPublic;
			}
		}

		/// <summary>
		/// System.Xml.XmlQualifiedName QnSystem
		/// </summary>
		protected RSystem.RXml.RXmlQualifiedName r_QnSystem;
		public virtual RSystem.RXml.RXmlQualifiedName RQnSystem
		{
			get
			{
				if(r_QnSystem == null)
				{
					r_QnSystem = new(this, "QnSystem");
					r_QnSystem.SetBelong(this.instance);
				}
				return r_QnSystem;
			}
		}

		/// <summary>
		/// System.Xml.XmlQualifiedName QnSchemaLocation
		/// </summary>
		protected RSystem.RXml.RXmlQualifiedName r_QnSchemaLocation;
		public virtual RSystem.RXml.RXmlQualifiedName RQnSchemaLocation
		{
			get
			{
				if(r_QnSchemaLocation == null)
				{
					r_QnSchemaLocation = new(this, "QnSchemaLocation");
					r_QnSchemaLocation.SetBelong(this.instance);
				}
				return r_QnSchemaLocation;
			}
		}

		/// <summary>
		/// System.Xml.XmlQualifiedName QnValue
		/// </summary>
		protected RSystem.RXml.RXmlQualifiedName r_QnValue;
		public virtual RSystem.RXml.RXmlQualifiedName RQnValue
		{
			get
			{
				if(r_QnValue == null)
				{
					r_QnValue = new(this, "QnValue");
					r_QnValue.SetBelong(this.instance);
				}
				return r_QnValue;
			}
		}

		/// <summary>
		/// System.Xml.XmlQualifiedName QnUse
		/// </summary>
		protected RSystem.RXml.RXmlQualifiedName r_QnUse;
		public virtual RSystem.RXml.RXmlQualifiedName RQnUse
		{
			get
			{
				if(r_QnUse == null)
				{
					r_QnUse = new(this, "QnUse");
					r_QnUse.SetBelong(this.instance);
				}
				return r_QnUse;
			}
		}

		/// <summary>
		/// System.Xml.XmlQualifiedName QnForm
		/// </summary>
		protected RSystem.RXml.RXmlQualifiedName r_QnForm;
		public virtual RSystem.RXml.RXmlQualifiedName RQnForm
		{
			get
			{
				if(r_QnForm == null)
				{
					r_QnForm = new(this, "QnForm");
					r_QnForm.SetBelong(this.instance);
				}
				return r_QnForm;
			}
		}

		/// <summary>
		/// System.Xml.XmlQualifiedName QnElementFormDefault
		/// </summary>
		protected RSystem.RXml.RXmlQualifiedName r_QnElementFormDefault;
		public virtual RSystem.RXml.RXmlQualifiedName RQnElementFormDefault
		{
			get
			{
				if(r_QnElementFormDefault == null)
				{
					r_QnElementFormDefault = new(this, "QnElementFormDefault");
					r_QnElementFormDefault.SetBelong(this.instance);
				}
				return r_QnElementFormDefault;
			}
		}

		/// <summary>
		/// System.Xml.XmlQualifiedName QnAttributeFormDefault
		/// </summary>
		protected RSystem.RXml.RXmlQualifiedName r_QnAttributeFormDefault;
		public virtual RSystem.RXml.RXmlQualifiedName RQnAttributeFormDefault
		{
			get
			{
				if(r_QnAttributeFormDefault == null)
				{
					r_QnAttributeFormDefault = new(this, "QnAttributeFormDefault");
					r_QnAttributeFormDefault.SetBelong(this.instance);
				}
				return r_QnAttributeFormDefault;
			}
		}

		/// <summary>
		/// System.Xml.XmlQualifiedName QnItemType
		/// </summary>
		protected RSystem.RXml.RXmlQualifiedName r_QnItemType;
		public virtual RSystem.RXml.RXmlQualifiedName RQnItemType
		{
			get
			{
				if(r_QnItemType == null)
				{
					r_QnItemType = new(this, "QnItemType");
					r_QnItemType.SetBelong(this.instance);
				}
				return r_QnItemType;
			}
		}

		/// <summary>
		/// System.Xml.XmlQualifiedName QnMemberTypes
		/// </summary>
		protected RSystem.RXml.RXmlQualifiedName r_QnMemberTypes;
		public virtual RSystem.RXml.RXmlQualifiedName RQnMemberTypes
		{
			get
			{
				if(r_QnMemberTypes == null)
				{
					r_QnMemberTypes = new(this, "QnMemberTypes");
					r_QnMemberTypes.SetBelong(this.instance);
				}
				return r_QnMemberTypes;
			}
		}

		/// <summary>
		/// System.Xml.XmlQualifiedName QnXPath
		/// </summary>
		protected RSystem.RXml.RXmlQualifiedName r_QnXPath;
		public virtual RSystem.RXml.RXmlQualifiedName RQnXPath
		{
			get
			{
				if(r_QnXPath == null)
				{
					r_QnXPath = new(this, "QnXPath");
					r_QnXPath.SetBelong(this.instance);
				}
				return r_QnXPath;
			}
		}

		/// <summary>
		/// System.Xml.XmlQualifiedName QnXsdSchema
		/// </summary>
		protected RSystem.RXml.RXmlQualifiedName r_QnXsdSchema;
		public virtual RSystem.RXml.RXmlQualifiedName RQnXsdSchema
		{
			get
			{
				if(r_QnXsdSchema == null)
				{
					r_QnXsdSchema = new(this, "QnXsdSchema");
					r_QnXsdSchema.SetBelong(this.instance);
				}
				return r_QnXsdSchema;
			}
		}

		/// <summary>
		/// System.Xml.XmlQualifiedName QnXsdAnnotation
		/// </summary>
		protected RSystem.RXml.RXmlQualifiedName r_QnXsdAnnotation;
		public virtual RSystem.RXml.RXmlQualifiedName RQnXsdAnnotation
		{
			get
			{
				if(r_QnXsdAnnotation == null)
				{
					r_QnXsdAnnotation = new(this, "QnXsdAnnotation");
					r_QnXsdAnnotation.SetBelong(this.instance);
				}
				return r_QnXsdAnnotation;
			}
		}

		/// <summary>
		/// System.Xml.XmlQualifiedName QnXsdInclude
		/// </summary>
		protected RSystem.RXml.RXmlQualifiedName r_QnXsdInclude;
		public virtual RSystem.RXml.RXmlQualifiedName RQnXsdInclude
		{
			get
			{
				if(r_QnXsdInclude == null)
				{
					r_QnXsdInclude = new(this, "QnXsdInclude");
					r_QnXsdInclude.SetBelong(this.instance);
				}
				return r_QnXsdInclude;
			}
		}

		/// <summary>
		/// System.Xml.XmlQualifiedName QnXsdImport
		/// </summary>
		protected RSystem.RXml.RXmlQualifiedName r_QnXsdImport;
		public virtual RSystem.RXml.RXmlQualifiedName RQnXsdImport
		{
			get
			{
				if(r_QnXsdImport == null)
				{
					r_QnXsdImport = new(this, "QnXsdImport");
					r_QnXsdImport.SetBelong(this.instance);
				}
				return r_QnXsdImport;
			}
		}

		/// <summary>
		/// System.Xml.XmlQualifiedName QnXsdElement
		/// </summary>
		protected RSystem.RXml.RXmlQualifiedName r_QnXsdElement;
		public virtual RSystem.RXml.RXmlQualifiedName RQnXsdElement
		{
			get
			{
				if(r_QnXsdElement == null)
				{
					r_QnXsdElement = new(this, "QnXsdElement");
					r_QnXsdElement.SetBelong(this.instance);
				}
				return r_QnXsdElement;
			}
		}

		/// <summary>
		/// System.Xml.XmlQualifiedName QnXsdAttribute
		/// </summary>
		protected RSystem.RXml.RXmlQualifiedName r_QnXsdAttribute;
		public virtual RSystem.RXml.RXmlQualifiedName RQnXsdAttribute
		{
			get
			{
				if(r_QnXsdAttribute == null)
				{
					r_QnXsdAttribute = new(this, "QnXsdAttribute");
					r_QnXsdAttribute.SetBelong(this.instance);
				}
				return r_QnXsdAttribute;
			}
		}

		/// <summary>
		/// System.Xml.XmlQualifiedName QnXsdAttributeGroup
		/// </summary>
		protected RSystem.RXml.RXmlQualifiedName r_QnXsdAttributeGroup;
		public virtual RSystem.RXml.RXmlQualifiedName RQnXsdAttributeGroup
		{
			get
			{
				if(r_QnXsdAttributeGroup == null)
				{
					r_QnXsdAttributeGroup = new(this, "QnXsdAttributeGroup");
					r_QnXsdAttributeGroup.SetBelong(this.instance);
				}
				return r_QnXsdAttributeGroup;
			}
		}

		/// <summary>
		/// System.Xml.XmlQualifiedName QnXsdAnyAttribute
		/// </summary>
		protected RSystem.RXml.RXmlQualifiedName r_QnXsdAnyAttribute;
		public virtual RSystem.RXml.RXmlQualifiedName RQnXsdAnyAttribute
		{
			get
			{
				if(r_QnXsdAnyAttribute == null)
				{
					r_QnXsdAnyAttribute = new(this, "QnXsdAnyAttribute");
					r_QnXsdAnyAttribute.SetBelong(this.instance);
				}
				return r_QnXsdAnyAttribute;
			}
		}

		/// <summary>
		/// System.Xml.XmlQualifiedName QnXsdGroup
		/// </summary>
		protected RSystem.RXml.RXmlQualifiedName r_QnXsdGroup;
		public virtual RSystem.RXml.RXmlQualifiedName RQnXsdGroup
		{
			get
			{
				if(r_QnXsdGroup == null)
				{
					r_QnXsdGroup = new(this, "QnXsdGroup");
					r_QnXsdGroup.SetBelong(this.instance);
				}
				return r_QnXsdGroup;
			}
		}

		/// <summary>
		/// System.Xml.XmlQualifiedName QnXsdAll
		/// </summary>
		protected RSystem.RXml.RXmlQualifiedName r_QnXsdAll;
		public virtual RSystem.RXml.RXmlQualifiedName RQnXsdAll
		{
			get
			{
				if(r_QnXsdAll == null)
				{
					r_QnXsdAll = new(this, "QnXsdAll");
					r_QnXsdAll.SetBelong(this.instance);
				}
				return r_QnXsdAll;
			}
		}

		/// <summary>
		/// System.Xml.XmlQualifiedName QnXsdChoice
		/// </summary>
		protected RSystem.RXml.RXmlQualifiedName r_QnXsdChoice;
		public virtual RSystem.RXml.RXmlQualifiedName RQnXsdChoice
		{
			get
			{
				if(r_QnXsdChoice == null)
				{
					r_QnXsdChoice = new(this, "QnXsdChoice");
					r_QnXsdChoice.SetBelong(this.instance);
				}
				return r_QnXsdChoice;
			}
		}

		/// <summary>
		/// System.Xml.XmlQualifiedName QnXsdSequence
		/// </summary>
		protected RSystem.RXml.RXmlQualifiedName r_QnXsdSequence;
		public virtual RSystem.RXml.RXmlQualifiedName RQnXsdSequence
		{
			get
			{
				if(r_QnXsdSequence == null)
				{
					r_QnXsdSequence = new(this, "QnXsdSequence");
					r_QnXsdSequence.SetBelong(this.instance);
				}
				return r_QnXsdSequence;
			}
		}

		/// <summary>
		/// System.Xml.XmlQualifiedName QnXsdAny
		/// </summary>
		protected RSystem.RXml.RXmlQualifiedName r_QnXsdAny;
		public virtual RSystem.RXml.RXmlQualifiedName RQnXsdAny
		{
			get
			{
				if(r_QnXsdAny == null)
				{
					r_QnXsdAny = new(this, "QnXsdAny");
					r_QnXsdAny.SetBelong(this.instance);
				}
				return r_QnXsdAny;
			}
		}

		/// <summary>
		/// System.Xml.XmlQualifiedName QnXsdNotation
		/// </summary>
		protected RSystem.RXml.RXmlQualifiedName r_QnXsdNotation;
		public virtual RSystem.RXml.RXmlQualifiedName RQnXsdNotation
		{
			get
			{
				if(r_QnXsdNotation == null)
				{
					r_QnXsdNotation = new(this, "QnXsdNotation");
					r_QnXsdNotation.SetBelong(this.instance);
				}
				return r_QnXsdNotation;
			}
		}

		/// <summary>
		/// System.Xml.XmlQualifiedName QnXsdSimpleType
		/// </summary>
		protected RSystem.RXml.RXmlQualifiedName r_QnXsdSimpleType;
		public virtual RSystem.RXml.RXmlQualifiedName RQnXsdSimpleType
		{
			get
			{
				if(r_QnXsdSimpleType == null)
				{
					r_QnXsdSimpleType = new(this, "QnXsdSimpleType");
					r_QnXsdSimpleType.SetBelong(this.instance);
				}
				return r_QnXsdSimpleType;
			}
		}

		/// <summary>
		/// System.Xml.XmlQualifiedName QnXsdComplexType
		/// </summary>
		protected RSystem.RXml.RXmlQualifiedName r_QnXsdComplexType;
		public virtual RSystem.RXml.RXmlQualifiedName RQnXsdComplexType
		{
			get
			{
				if(r_QnXsdComplexType == null)
				{
					r_QnXsdComplexType = new(this, "QnXsdComplexType");
					r_QnXsdComplexType.SetBelong(this.instance);
				}
				return r_QnXsdComplexType;
			}
		}

		/// <summary>
		/// System.Xml.XmlQualifiedName QnXsdUnique
		/// </summary>
		protected RSystem.RXml.RXmlQualifiedName r_QnXsdUnique;
		public virtual RSystem.RXml.RXmlQualifiedName RQnXsdUnique
		{
			get
			{
				if(r_QnXsdUnique == null)
				{
					r_QnXsdUnique = new(this, "QnXsdUnique");
					r_QnXsdUnique.SetBelong(this.instance);
				}
				return r_QnXsdUnique;
			}
		}

		/// <summary>
		/// System.Xml.XmlQualifiedName QnXsdKey
		/// </summary>
		protected RSystem.RXml.RXmlQualifiedName r_QnXsdKey;
		public virtual RSystem.RXml.RXmlQualifiedName RQnXsdKey
		{
			get
			{
				if(r_QnXsdKey == null)
				{
					r_QnXsdKey = new(this, "QnXsdKey");
					r_QnXsdKey.SetBelong(this.instance);
				}
				return r_QnXsdKey;
			}
		}

		/// <summary>
		/// System.Xml.XmlQualifiedName QnXsdKeyRef
		/// </summary>
		protected RSystem.RXml.RXmlQualifiedName r_QnXsdKeyRef;
		public virtual RSystem.RXml.RXmlQualifiedName RQnXsdKeyRef
		{
			get
			{
				if(r_QnXsdKeyRef == null)
				{
					r_QnXsdKeyRef = new(this, "QnXsdKeyRef");
					r_QnXsdKeyRef.SetBelong(this.instance);
				}
				return r_QnXsdKeyRef;
			}
		}

		/// <summary>
		/// System.Xml.XmlQualifiedName QnXsdSelector
		/// </summary>
		protected RSystem.RXml.RXmlQualifiedName r_QnXsdSelector;
		public virtual RSystem.RXml.RXmlQualifiedName RQnXsdSelector
		{
			get
			{
				if(r_QnXsdSelector == null)
				{
					r_QnXsdSelector = new(this, "QnXsdSelector");
					r_QnXsdSelector.SetBelong(this.instance);
				}
				return r_QnXsdSelector;
			}
		}

		/// <summary>
		/// System.Xml.XmlQualifiedName QnXsdField
		/// </summary>
		protected RSystem.RXml.RXmlQualifiedName r_QnXsdField;
		public virtual RSystem.RXml.RXmlQualifiedName RQnXsdField
		{
			get
			{
				if(r_QnXsdField == null)
				{
					r_QnXsdField = new(this, "QnXsdField");
					r_QnXsdField.SetBelong(this.instance);
				}
				return r_QnXsdField;
			}
		}

		/// <summary>
		/// System.Xml.XmlQualifiedName QnXsdMinExclusive
		/// </summary>
		protected RSystem.RXml.RXmlQualifiedName r_QnXsdMinExclusive;
		public virtual RSystem.RXml.RXmlQualifiedName RQnXsdMinExclusive
		{
			get
			{
				if(r_QnXsdMinExclusive == null)
				{
					r_QnXsdMinExclusive = new(this, "QnXsdMinExclusive");
					r_QnXsdMinExclusive.SetBelong(this.instance);
				}
				return r_QnXsdMinExclusive;
			}
		}

		/// <summary>
		/// System.Xml.XmlQualifiedName QnXsdMinInclusive
		/// </summary>
		protected RSystem.RXml.RXmlQualifiedName r_QnXsdMinInclusive;
		public virtual RSystem.RXml.RXmlQualifiedName RQnXsdMinInclusive
		{
			get
			{
				if(r_QnXsdMinInclusive == null)
				{
					r_QnXsdMinInclusive = new(this, "QnXsdMinInclusive");
					r_QnXsdMinInclusive.SetBelong(this.instance);
				}
				return r_QnXsdMinInclusive;
			}
		}

		/// <summary>
		/// System.Xml.XmlQualifiedName QnXsdMaxInclusive
		/// </summary>
		protected RSystem.RXml.RXmlQualifiedName r_QnXsdMaxInclusive;
		public virtual RSystem.RXml.RXmlQualifiedName RQnXsdMaxInclusive
		{
			get
			{
				if(r_QnXsdMaxInclusive == null)
				{
					r_QnXsdMaxInclusive = new(this, "QnXsdMaxInclusive");
					r_QnXsdMaxInclusive.SetBelong(this.instance);
				}
				return r_QnXsdMaxInclusive;
			}
		}

		/// <summary>
		/// System.Xml.XmlQualifiedName QnXsdMaxExclusive
		/// </summary>
		protected RSystem.RXml.RXmlQualifiedName r_QnXsdMaxExclusive;
		public virtual RSystem.RXml.RXmlQualifiedName RQnXsdMaxExclusive
		{
			get
			{
				if(r_QnXsdMaxExclusive == null)
				{
					r_QnXsdMaxExclusive = new(this, "QnXsdMaxExclusive");
					r_QnXsdMaxExclusive.SetBelong(this.instance);
				}
				return r_QnXsdMaxExclusive;
			}
		}

		/// <summary>
		/// System.Xml.XmlQualifiedName QnXsdTotalDigits
		/// </summary>
		protected RSystem.RXml.RXmlQualifiedName r_QnXsdTotalDigits;
		public virtual RSystem.RXml.RXmlQualifiedName RQnXsdTotalDigits
		{
			get
			{
				if(r_QnXsdTotalDigits == null)
				{
					r_QnXsdTotalDigits = new(this, "QnXsdTotalDigits");
					r_QnXsdTotalDigits.SetBelong(this.instance);
				}
				return r_QnXsdTotalDigits;
			}
		}

		/// <summary>
		/// System.Xml.XmlQualifiedName QnXsdFractionDigits
		/// </summary>
		protected RSystem.RXml.RXmlQualifiedName r_QnXsdFractionDigits;
		public virtual RSystem.RXml.RXmlQualifiedName RQnXsdFractionDigits
		{
			get
			{
				if(r_QnXsdFractionDigits == null)
				{
					r_QnXsdFractionDigits = new(this, "QnXsdFractionDigits");
					r_QnXsdFractionDigits.SetBelong(this.instance);
				}
				return r_QnXsdFractionDigits;
			}
		}

		/// <summary>
		/// System.Xml.XmlQualifiedName QnXsdLength
		/// </summary>
		protected RSystem.RXml.RXmlQualifiedName r_QnXsdLength;
		public virtual RSystem.RXml.RXmlQualifiedName RQnXsdLength
		{
			get
			{
				if(r_QnXsdLength == null)
				{
					r_QnXsdLength = new(this, "QnXsdLength");
					r_QnXsdLength.SetBelong(this.instance);
				}
				return r_QnXsdLength;
			}
		}

		/// <summary>
		/// System.Xml.XmlQualifiedName QnXsdMinLength
		/// </summary>
		protected RSystem.RXml.RXmlQualifiedName r_QnXsdMinLength;
		public virtual RSystem.RXml.RXmlQualifiedName RQnXsdMinLength
		{
			get
			{
				if(r_QnXsdMinLength == null)
				{
					r_QnXsdMinLength = new(this, "QnXsdMinLength");
					r_QnXsdMinLength.SetBelong(this.instance);
				}
				return r_QnXsdMinLength;
			}
		}

		/// <summary>
		/// System.Xml.XmlQualifiedName QnXsdMaxLength
		/// </summary>
		protected RSystem.RXml.RXmlQualifiedName r_QnXsdMaxLength;
		public virtual RSystem.RXml.RXmlQualifiedName RQnXsdMaxLength
		{
			get
			{
				if(r_QnXsdMaxLength == null)
				{
					r_QnXsdMaxLength = new(this, "QnXsdMaxLength");
					r_QnXsdMaxLength.SetBelong(this.instance);
				}
				return r_QnXsdMaxLength;
			}
		}

		/// <summary>
		/// System.Xml.XmlQualifiedName QnXsdEnumeration
		/// </summary>
		protected RSystem.RXml.RXmlQualifiedName r_QnXsdEnumeration;
		public virtual RSystem.RXml.RXmlQualifiedName RQnXsdEnumeration
		{
			get
			{
				if(r_QnXsdEnumeration == null)
				{
					r_QnXsdEnumeration = new(this, "QnXsdEnumeration");
					r_QnXsdEnumeration.SetBelong(this.instance);
				}
				return r_QnXsdEnumeration;
			}
		}

		/// <summary>
		/// System.Xml.XmlQualifiedName QnXsdPattern
		/// </summary>
		protected RSystem.RXml.RXmlQualifiedName r_QnXsdPattern;
		public virtual RSystem.RXml.RXmlQualifiedName RQnXsdPattern
		{
			get
			{
				if(r_QnXsdPattern == null)
				{
					r_QnXsdPattern = new(this, "QnXsdPattern");
					r_QnXsdPattern.SetBelong(this.instance);
				}
				return r_QnXsdPattern;
			}
		}

		/// <summary>
		/// System.Xml.XmlQualifiedName QnXsdDocumentation
		/// </summary>
		protected RSystem.RXml.RXmlQualifiedName r_QnXsdDocumentation;
		public virtual RSystem.RXml.RXmlQualifiedName RQnXsdDocumentation
		{
			get
			{
				if(r_QnXsdDocumentation == null)
				{
					r_QnXsdDocumentation = new(this, "QnXsdDocumentation");
					r_QnXsdDocumentation.SetBelong(this.instance);
				}
				return r_QnXsdDocumentation;
			}
		}

		/// <summary>
		/// System.Xml.XmlQualifiedName QnXsdAppinfo
		/// </summary>
		protected RSystem.RXml.RXmlQualifiedName r_QnXsdAppinfo;
		public virtual RSystem.RXml.RXmlQualifiedName RQnXsdAppinfo
		{
			get
			{
				if(r_QnXsdAppinfo == null)
				{
					r_QnXsdAppinfo = new(this, "QnXsdAppinfo");
					r_QnXsdAppinfo.SetBelong(this.instance);
				}
				return r_QnXsdAppinfo;
			}
		}

		/// <summary>
		/// System.Xml.XmlQualifiedName QnSource
		/// </summary>
		protected RSystem.RXml.RXmlQualifiedName r_QnSource;
		public virtual RSystem.RXml.RXmlQualifiedName RQnSource
		{
			get
			{
				if(r_QnSource == null)
				{
					r_QnSource = new(this, "QnSource");
					r_QnSource.SetBelong(this.instance);
				}
				return r_QnSource;
			}
		}

		/// <summary>
		/// System.Xml.XmlQualifiedName QnXsdComplexContent
		/// </summary>
		protected RSystem.RXml.RXmlQualifiedName r_QnXsdComplexContent;
		public virtual RSystem.RXml.RXmlQualifiedName RQnXsdComplexContent
		{
			get
			{
				if(r_QnXsdComplexContent == null)
				{
					r_QnXsdComplexContent = new(this, "QnXsdComplexContent");
					r_QnXsdComplexContent.SetBelong(this.instance);
				}
				return r_QnXsdComplexContent;
			}
		}

		/// <summary>
		/// System.Xml.XmlQualifiedName QnXsdSimpleContent
		/// </summary>
		protected RSystem.RXml.RXmlQualifiedName r_QnXsdSimpleContent;
		public virtual RSystem.RXml.RXmlQualifiedName RQnXsdSimpleContent
		{
			get
			{
				if(r_QnXsdSimpleContent == null)
				{
					r_QnXsdSimpleContent = new(this, "QnXsdSimpleContent");
					r_QnXsdSimpleContent.SetBelong(this.instance);
				}
				return r_QnXsdSimpleContent;
			}
		}

		/// <summary>
		/// System.Xml.XmlQualifiedName QnXsdRestriction
		/// </summary>
		protected RSystem.RXml.RXmlQualifiedName r_QnXsdRestriction;
		public virtual RSystem.RXml.RXmlQualifiedName RQnXsdRestriction
		{
			get
			{
				if(r_QnXsdRestriction == null)
				{
					r_QnXsdRestriction = new(this, "QnXsdRestriction");
					r_QnXsdRestriction.SetBelong(this.instance);
				}
				return r_QnXsdRestriction;
			}
		}

		/// <summary>
		/// System.Xml.XmlQualifiedName QnXsdExtension
		/// </summary>
		protected RSystem.RXml.RXmlQualifiedName r_QnXsdExtension;
		public virtual RSystem.RXml.RXmlQualifiedName RQnXsdExtension
		{
			get
			{
				if(r_QnXsdExtension == null)
				{
					r_QnXsdExtension = new(this, "QnXsdExtension");
					r_QnXsdExtension.SetBelong(this.instance);
				}
				return r_QnXsdExtension;
			}
		}

		/// <summary>
		/// System.Xml.XmlQualifiedName QnXsdUnion
		/// </summary>
		protected RSystem.RXml.RXmlQualifiedName r_QnXsdUnion;
		public virtual RSystem.RXml.RXmlQualifiedName RQnXsdUnion
		{
			get
			{
				if(r_QnXsdUnion == null)
				{
					r_QnXsdUnion = new(this, "QnXsdUnion");
					r_QnXsdUnion.SetBelong(this.instance);
				}
				return r_QnXsdUnion;
			}
		}

		/// <summary>
		/// System.Xml.XmlQualifiedName QnXsdList
		/// </summary>
		protected RSystem.RXml.RXmlQualifiedName r_QnXsdList;
		public virtual RSystem.RXml.RXmlQualifiedName RQnXsdList
		{
			get
			{
				if(r_QnXsdList == null)
				{
					r_QnXsdList = new(this, "QnXsdList");
					r_QnXsdList.SetBelong(this.instance);
				}
				return r_QnXsdList;
			}
		}

		/// <summary>
		/// System.Xml.XmlQualifiedName QnXsdWhiteSpace
		/// </summary>
		protected RSystem.RXml.RXmlQualifiedName r_QnXsdWhiteSpace;
		public virtual RSystem.RXml.RXmlQualifiedName RQnXsdWhiteSpace
		{
			get
			{
				if(r_QnXsdWhiteSpace == null)
				{
					r_QnXsdWhiteSpace = new(this, "QnXsdWhiteSpace");
					r_QnXsdWhiteSpace.SetBelong(this.instance);
				}
				return r_QnXsdWhiteSpace;
			}
		}

		/// <summary>
		/// System.Xml.XmlQualifiedName QnXsdRedefine
		/// </summary>
		protected RSystem.RXml.RXmlQualifiedName r_QnXsdRedefine;
		public virtual RSystem.RXml.RXmlQualifiedName RQnXsdRedefine
		{
			get
			{
				if(r_QnXsdRedefine == null)
				{
					r_QnXsdRedefine = new(this, "QnXsdRedefine");
					r_QnXsdRedefine.SetBelong(this.instance);
				}
				return r_QnXsdRedefine;
			}
		}

		/// <summary>
		/// System.Xml.XmlQualifiedName QnXsdAnyType
		/// </summary>
		protected RSystem.RXml.RXmlQualifiedName r_QnXsdAnyType;
		public virtual RSystem.RXml.RXmlQualifiedName RQnXsdAnyType
		{
			get
			{
				if(r_QnXsdAnyType == null)
				{
					r_QnXsdAnyType = new(this, "QnXsdAnyType");
					r_QnXsdAnyType.SetBelong(this.instance);
				}
				return r_QnXsdAnyType;
			}
		}

		/// <summary>
		/// System.Xml.XmlQualifiedName[] TokenToQName
		/// </summary>
		protected RFieldArray<RSystem.RXml.RXmlQualifiedName> r_TokenToQName;
		public virtual RFieldArray<RSystem.RXml.RXmlQualifiedName> RTokenToQName
		{
			get
			{
				if(r_TokenToQName == null)
				{
					r_TokenToQName = new(this, "TokenToQName");
					r_TokenToQName.SetBelong(this.instance);
				}
				return r_TokenToQName;
			}
		}

		/// <summary>
		/// System.Xml.XmlNameTable NameTable
		/// </summary>
		protected RSystem.RXml.RXmlNameTable r_NameTable;
		public virtual RSystem.RXml.RXmlNameTable RNameTable
		{
			get
			{
				if(r_NameTable == null)
				{
					r_NameTable = new(this, "NameTable", -1);
					r_NameTable.SetBelong(this.instance);
				}
				return r_NameTable;
			}
		}

		/// <summary>
		/// Void CreateTokenToQNameTable()
		/// </summary>
		protected RMethod r_RCreateTokenToQNameTable;
		public virtual RMethod RCreateTokenToQNameTable
		{
			get
			{
				if(r_RCreateTokenToQNameTable == null)
				{
					r_RCreateTokenToQNameTable = new(this, "CreateTokenToQNameTable", 0);
					r_RCreateTokenToQNameTable.SetBelong(this.instance);
				}
				return r_RCreateTokenToQNameTable;
			}
		}

		/// <summary>
		/// System.Xml.Schema.SchemaType SchemaTypeFromRoot(System.String, System.String)
		/// </summary>
		protected RMethod r_RSchemaTypeFromRoot_String_String;
		public virtual RMethod RSchemaTypeFromRoot_String_String
		{
			get
			{
				if(r_RSchemaTypeFromRoot_String_String == null)
				{
					r_RSchemaTypeFromRoot_String_String = new(this, "SchemaTypeFromRoot", 0, typeof(System.String), typeof(System.String));
					r_RSchemaTypeFromRoot_String_String.SetBelong(this.instance);
				}
				return r_RSchemaTypeFromRoot_String_String;
			}
		}

		/// <summary>
		/// Boolean IsXSDRoot(System.String, System.String)
		/// </summary>
		protected RMethod r_RIsXSDRoot_String_String;
		public virtual RMethod RIsXSDRoot_String_String
		{
			get
			{
				if(r_RIsXSDRoot_String_String == null)
				{
					r_RIsXSDRoot_String_String = new(this, "IsXSDRoot", 0, typeof(System.String), typeof(System.String));
					r_RIsXSDRoot_String_String.SetBelong(this.instance);
				}
				return r_RIsXSDRoot_String_String;
			}
		}

		/// <summary>
		/// Boolean IsXDRRoot(System.String, System.String)
		/// </summary>
		protected RMethod r_RIsXDRRoot_String_String;
		public virtual RMethod RIsXDRRoot_String_String
		{
			get
			{
				if(r_RIsXDRRoot_String_String == null)
				{
					r_RIsXDRRoot_String_String = new(this, "IsXDRRoot", 0, typeof(System.String), typeof(System.String));
					r_RIsXDRRoot_String_String.SetBelong(this.instance);
				}
				return r_RIsXDRRoot_String_String;
			}
		}

		/// <summary>
		/// System.Xml.XmlQualifiedName GetName(Token)
		/// </summary>
		protected RMethod r_RGetName_Token;
		public virtual RMethod RGetName_Token
		{
			get
			{
				if(r_RGetName_Token == null)
				{
					r_RGetName_Token = new(this, "GetName", 0,  ReleactionUtils.GetType("System.Xml.Schema.SchemaNames+Token"));
					r_RGetName_Token.SetBelong(this.instance);
				}
				return r_RGetName_Token;
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


        public RSchemaNames() : base("System.Xml.Schema.SchemaNames")
        {
        }

        public RSchemaNames(System.Object instance) : base("System.Xml.Schema.SchemaNames")
		{
            SetInstance(instance);
		}

        public RSchemaNames(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RSchemaNames(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }

        public virtual void CreateTokenToQNameTable()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RCreateTokenToQNameTable.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Object SchemaTypeFromRoot(System.String  @localName, System.String  @ns)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@localName, @ns};
            var ___result = RSchemaTypeFromRoot_String_String.Invoke(___genericsType, ___parameters);

            return (System.Object)___result;
        }


        public virtual System.Boolean IsXSDRoot(System.String  @localName, System.String  @ns)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@localName, @ns};
            var ___result = RIsXSDRoot_String_String.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean IsXDRRoot(System.String  @localName, System.String  @ns)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@localName, @ns};
            var ___result = RIsXDRRoot_String_String.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
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
