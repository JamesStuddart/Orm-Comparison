﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace OrmComparison.LinqToSql
{
	using System.Data.Linq;
	using System.Data.Linq.Mapping;
	using System.Data;
	using System.Collections.Generic;
	using System.Reflection;
	using System.Linq;
	using System.Linq.Expressions;
	using System.ComponentModel;
	using System;
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="ORMTest")]
	public partial class DataClasses1DataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    #endregion
		
		public DataClasses1DataContext() : 
				base(global::OrmComparison.Properties.Settings.Default.ORMTestConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public DataClasses1DataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataClasses1DataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataClasses1DataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataClasses1DataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.ExecuteNonQuery")]
		public int ExecuteNonQuery([global::System.Data.Linq.Mapping.ParameterAttribute(Name="OutputData", DbType="Int")] ref System.Nullable<int> outputData, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="IntData", DbType="Int")] System.Nullable<int> intData, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="GuidData", DbType="UniqueIdentifier")] System.Nullable<System.Guid> guidData, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="StringData", DbType="NVarChar(50)")] string stringData, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="BoolData", DbType="Bit")] System.Nullable<bool> boolData, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="DateData", DbType="DateTime")] System.Nullable<System.DateTime> dateData)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), outputData, intData, guidData, stringData, boolData, dateData);
			outputData = ((System.Nullable<int>)(result.GetParameterValue(0)));
			return ((int)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.GetSingleRecord")]
		public ISingleResult<GetSingleRecordResult> GetSingleRecord([global::System.Data.Linq.Mapping.ParameterAttribute(Name="IntData", DbType="Int")] System.Nullable<int> intData)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), intData);
			return ((ISingleResult<GetSingleRecordResult>)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.GetAllRecords")]
		public ISingleResult<GetAllRecordsResult> GetAllRecords()
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())));
			return ((ISingleResult<GetAllRecordsResult>)(result.ReturnValue));
		}
	}
	
	public partial class GetSingleRecordResult
	{
		
		private int _IntData;
		
		private System.Guid _GuidData;
		
		private string _StringData;
		
		private bool _BoolData;
		
		private System.DateTime _DateData;
		
		public GetSingleRecordResult()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_IntData", DbType="Int NOT NULL")]
		public int IntData
		{
			get
			{
				return this._IntData;
			}
			set
			{
				if ((this._IntData != value))
				{
					this._IntData = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_GuidData", DbType="UniqueIdentifier NOT NULL")]
		public System.Guid GuidData
		{
			get
			{
				return this._GuidData;
			}
			set
			{
				if ((this._GuidData != value))
				{
					this._GuidData = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_StringData", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string StringData
		{
			get
			{
				return this._StringData;
			}
			set
			{
				if ((this._StringData != value))
				{
					this._StringData = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_BoolData", DbType="Bit NOT NULL")]
		public bool BoolData
		{
			get
			{
				return this._BoolData;
			}
			set
			{
				if ((this._BoolData != value))
				{
					this._BoolData = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_DateData", DbType="DateTime NOT NULL")]
		public System.DateTime DateData
		{
			get
			{
				return this._DateData;
			}
			set
			{
				if ((this._DateData != value))
				{
					this._DateData = value;
				}
			}
		}
	}
	
	public partial class GetAllRecordsResult
	{
		
		private int _IntData;
		
		private System.Guid _GuidData;
		
		private string _StringData;
		
		private bool _BoolData;
		
		private System.DateTime _DateData;
		
		public GetAllRecordsResult()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_IntData", DbType="Int NOT NULL")]
		public int IntData
		{
			get
			{
				return this._IntData;
			}
			set
			{
				if ((this._IntData != value))
				{
					this._IntData = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_GuidData", DbType="UniqueIdentifier NOT NULL")]
		public System.Guid GuidData
		{
			get
			{
				return this._GuidData;
			}
			set
			{
				if ((this._GuidData != value))
				{
					this._GuidData = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_StringData", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string StringData
		{
			get
			{
				return this._StringData;
			}
			set
			{
				if ((this._StringData != value))
				{
					this._StringData = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_BoolData", DbType="Bit NOT NULL")]
		public bool BoolData
		{
			get
			{
				return this._BoolData;
			}
			set
			{
				if ((this._BoolData != value))
				{
					this._BoolData = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_DateData", DbType="DateTime NOT NULL")]
		public System.DateTime DateData
		{
			get
			{
				return this._DateData;
			}
			set
			{
				if ((this._DateData != value))
				{
					this._DateData = value;
				}
			}
		}
	}
}
#pragma warning restore 1591