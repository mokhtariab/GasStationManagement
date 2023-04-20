﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18408
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace GasStationManagement.Model.PressTransState
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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="GasStationManagement")]
	public partial class DataClassesPressTransStateDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void InsertTBL_PressTransState(TBL_PressTransState instance);
    partial void UpdateTBL_PressTransState(TBL_PressTransState instance);
    partial void DeleteTBL_PressTransState(TBL_PressTransState instance);
    #endregion
		
		public DataClassesPressTransStateDataContext() : 
				base(global::GasStationManagement.Model.Properties.Settings.Default.GasStationManagementConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public DataClassesPressTransStateDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataClassesPressTransStateDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataClassesPressTransStateDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataClassesPressTransStateDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<TBL_PressTransState> TBL_PressTransStates
		{
			get
			{
				return this.GetTable<TBL_PressTransState>();
			}
		}
		
		public System.Data.Linq.Table<VW_PressTransState> VW_PressTransStates
		{
			get
			{
				return this.GetTable<VW_PressTransState>();
			}
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.SP_PressTransStateDelete")]
		public int SP_PressTransStateDelete([global::System.Data.Linq.Mapping.ParameterAttribute(Name="PressTrans_Id", DbType="Int")] System.Nullable<int> pressTrans_Id, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="PressTransSerialNo", DbType="VarChar(20)")] string pressTransSerialNo, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="PressTransStateRow", DbType="Int")] System.Nullable<int> pressTransStateRow, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="VarChar(2000)")] ref string msgRet)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), pressTrans_Id, pressTransSerialNo, pressTransStateRow, msgRet);
			msgRet = ((string)(result.GetParameterValue(3)));
			return ((int)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.SP_PressTransStateInsert")]
		public int SP_PressTransStateInsert([global::System.Data.Linq.Mapping.ParameterAttribute(Name="PressTrans_Id", DbType="Int")] System.Nullable<int> pressTrans_Id, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="PressTransSerialNo", DbType="VarChar(20)")] string pressTransSerialNo, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="PressTransStateRow", DbType="Int")] System.Nullable<int> pressTransStateRow, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="ChangeStateDate", DbType="VarChar(10)")] string changeStateDate, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="EquipmentState_Id", DbType="SmallInt")] System.Nullable<short> equipmentState_Id, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="Store_Id", DbType="SmallInt")] System.Nullable<short> store_Id, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="WorkShop_Id", DbType="SmallInt")] System.Nullable<short> workShop_Id, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="Calibration_Id", DbType="SmallInt")] System.Nullable<short> calibration_Id, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="GasStation_Id", DbType="SmallInt")] System.Nullable<short> gasStation_Id, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="Description", DbType="VarChar(4000)")] string description, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="IsActive", DbType="Bit")] System.Nullable<bool> isActive, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="VarChar(1000)")] ref string msgRet)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), pressTrans_Id, pressTransSerialNo, pressTransStateRow, changeStateDate, equipmentState_Id, store_Id, workShop_Id, calibration_Id, gasStation_Id, description, isActive, msgRet);
			msgRet = ((string)(result.GetParameterValue(11)));
			return ((int)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.SP_PressTransStateUpdate")]
		public int SP_PressTransStateUpdate([global::System.Data.Linq.Mapping.ParameterAttribute(Name="PressTrans_Id", DbType="Int")] System.Nullable<int> pressTrans_Id, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="PressTransSerialNo", DbType="VarChar(20)")] string pressTransSerialNo, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="PressTransStateRow", DbType="Int")] System.Nullable<int> pressTransStateRow, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="ChangeStateDate", DbType="VarChar(10)")] string changeStateDate, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="EquipmentState_Id", DbType="SmallInt")] System.Nullable<short> equipmentState_Id, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="Store_Id", DbType="SmallInt")] System.Nullable<short> store_Id, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="WorkShop_Id", DbType="SmallInt")] System.Nullable<short> workShop_Id, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="Calibration_Id", DbType="SmallInt")] System.Nullable<short> calibration_Id, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="GasStation_Id", DbType="SmallInt")] System.Nullable<short> gasStation_Id, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="Description", DbType="VarChar(4000)")] string description, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="IsActive", DbType="Bit")] System.Nullable<bool> isActive, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="VarChar(1000)")] ref string msgRet)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), pressTrans_Id, pressTransSerialNo, pressTransStateRow, changeStateDate, equipmentState_Id, store_Id, workShop_Id, calibration_Id, gasStation_Id, description, isActive, msgRet);
			msgRet = ((string)(result.GetParameterValue(11)));
			return ((int)(result.ReturnValue));
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.TBL_PressTransState")]
	public partial class TBL_PressTransState : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _PressTrans_Id;
		
		private string _PressTransSerialNo;
		
		private int _PressTransStateRow;
		
		private string _ChangeStateDate;
		
		private short _EquipmentState_Id;
		
		private System.Nullable<short> _Store_Id;
		
		private System.Nullable<short> _WorkShop_Id;
		
		private System.Nullable<short> _Calibration_Id;
		
		private System.Nullable<short> _GasStation_Id;
		
		private string _Description;
		
		private bool _IsActive;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnPressTrans_IdChanging(int value);
    partial void OnPressTrans_IdChanged();
    partial void OnPressTransSerialNoChanging(string value);
    partial void OnPressTransSerialNoChanged();
    partial void OnPressTransStateRowChanging(int value);
    partial void OnPressTransStateRowChanged();
    partial void OnChangeStateDateChanging(string value);
    partial void OnChangeStateDateChanged();
    partial void OnEquipmentState_IdChanging(short value);
    partial void OnEquipmentState_IdChanged();
    partial void OnStore_IdChanging(System.Nullable<short> value);
    partial void OnStore_IdChanged();
    partial void OnWorkShop_IdChanging(System.Nullable<short> value);
    partial void OnWorkShop_IdChanged();
    partial void OnCalibration_IdChanging(System.Nullable<short> value);
    partial void OnCalibration_IdChanged();
    partial void OnGasStation_IdChanging(System.Nullable<short> value);
    partial void OnGasStation_IdChanged();
    partial void OnDescriptionChanging(string value);
    partial void OnDescriptionChanged();
    partial void OnIsActiveChanging(bool value);
    partial void OnIsActiveChanged();
    #endregion
		
		public TBL_PressTransState()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_PressTrans_Id", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int PressTrans_Id
		{
			get
			{
				return this._PressTrans_Id;
			}
			set
			{
				if ((this._PressTrans_Id != value))
				{
					this.OnPressTrans_IdChanging(value);
					this.SendPropertyChanging();
					this._PressTrans_Id = value;
					this.SendPropertyChanged("PressTrans_Id");
					this.OnPressTrans_IdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_PressTransSerialNo", DbType="VarChar(20) NOT NULL", CanBeNull=false, IsPrimaryKey=true)]
		public string PressTransSerialNo
		{
			get
			{
				return this._PressTransSerialNo;
			}
			set
			{
				if ((this._PressTransSerialNo != value))
				{
					this.OnPressTransSerialNoChanging(value);
					this.SendPropertyChanging();
					this._PressTransSerialNo = value;
					this.SendPropertyChanged("PressTransSerialNo");
					this.OnPressTransSerialNoChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_PressTransStateRow", DbType="Int NOT NULL", IsPrimaryKey=true)]
		public int PressTransStateRow
		{
			get
			{
				return this._PressTransStateRow;
			}
			set
			{
				if ((this._PressTransStateRow != value))
				{
					this.OnPressTransStateRowChanging(value);
					this.SendPropertyChanging();
					this._PressTransStateRow = value;
					this.SendPropertyChanged("PressTransStateRow");
					this.OnPressTransStateRowChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ChangeStateDate", DbType="VarChar(10) NOT NULL", CanBeNull=false)]
		public string ChangeStateDate
		{
			get
			{
				return this._ChangeStateDate;
			}
			set
			{
				if ((this._ChangeStateDate != value))
				{
					this.OnChangeStateDateChanging(value);
					this.SendPropertyChanging();
					this._ChangeStateDate = value;
					this.SendPropertyChanged("ChangeStateDate");
					this.OnChangeStateDateChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_EquipmentState_Id", DbType="SmallInt NOT NULL")]
		public short EquipmentState_Id
		{
			get
			{
				return this._EquipmentState_Id;
			}
			set
			{
				if ((this._EquipmentState_Id != value))
				{
					this.OnEquipmentState_IdChanging(value);
					this.SendPropertyChanging();
					this._EquipmentState_Id = value;
					this.SendPropertyChanged("EquipmentState_Id");
					this.OnEquipmentState_IdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Store_Id", DbType="SmallInt")]
		public System.Nullable<short> Store_Id
		{
			get
			{
				return this._Store_Id;
			}
			set
			{
				if ((this._Store_Id != value))
				{
					this.OnStore_IdChanging(value);
					this.SendPropertyChanging();
					this._Store_Id = value;
					this.SendPropertyChanged("Store_Id");
					this.OnStore_IdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_WorkShop_Id", DbType="SmallInt")]
		public System.Nullable<short> WorkShop_Id
		{
			get
			{
				return this._WorkShop_Id;
			}
			set
			{
				if ((this._WorkShop_Id != value))
				{
					this.OnWorkShop_IdChanging(value);
					this.SendPropertyChanging();
					this._WorkShop_Id = value;
					this.SendPropertyChanged("WorkShop_Id");
					this.OnWorkShop_IdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Calibration_Id", DbType="SmallInt")]
		public System.Nullable<short> Calibration_Id
		{
			get
			{
				return this._Calibration_Id;
			}
			set
			{
				if ((this._Calibration_Id != value))
				{
					this.OnCalibration_IdChanging(value);
					this.SendPropertyChanging();
					this._Calibration_Id = value;
					this.SendPropertyChanged("Calibration_Id");
					this.OnCalibration_IdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_GasStation_Id", DbType="SmallInt")]
		public System.Nullable<short> GasStation_Id
		{
			get
			{
				return this._GasStation_Id;
			}
			set
			{
				if ((this._GasStation_Id != value))
				{
					this.OnGasStation_IdChanging(value);
					this.SendPropertyChanging();
					this._GasStation_Id = value;
					this.SendPropertyChanged("GasStation_Id");
					this.OnGasStation_IdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Description", DbType="VarChar(4000)")]
		public string Description
		{
			get
			{
				return this._Description;
			}
			set
			{
				if ((this._Description != value))
				{
					this.OnDescriptionChanging(value);
					this.SendPropertyChanging();
					this._Description = value;
					this.SendPropertyChanged("Description");
					this.OnDescriptionChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_IsActive", DbType="Bit NOT NULL")]
		public bool IsActive
		{
			get
			{
				return this._IsActive;
			}
			set
			{
				if ((this._IsActive != value))
				{
					this.OnIsActiveChanging(value);
					this.SendPropertyChanging();
					this._IsActive = value;
					this.SendPropertyChanged("IsActive");
					this.OnIsActiveChanged();
				}
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.VW_PressTransState")]
	public partial class VW_PressTransState
	{
		
		private int _PressTrans_Id;
		
		private string _PressTransSerialNo;
		
		private int _PressTransStateRow;
		
		private string _ChangeStateDate;
		
		private short _EquipmentState_Id;
		
		private string _EquipmentStateName;
		
		private short _Store_Id;
		
		private string _StoreName;
		
		private short _WorkShop_Id;
		
		private string _WorkShopName;
		
		private short _Calibration_Id;
		
		private string _CalibrationName;
		
		private int _GasStation_Id;
		
		private string _GasStationCode;
		
		private string _GasStationName;
		
		private string _Description;
		
		private bool _IsActive;
		
		private string _Model;
		
		private string _Brand;
		
		private bool _HMIState;
		
		private int _PMax;
		
		private int _CalibrationDuration;
		
		public VW_PressTransState()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_PressTrans_Id", DbType="Int NOT NULL")]
		public int PressTrans_Id
		{
			get
			{
				return this._PressTrans_Id;
			}
			set
			{
				if ((this._PressTrans_Id != value))
				{
					this._PressTrans_Id = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_PressTransSerialNo", DbType="VarChar(20) NOT NULL", CanBeNull=false)]
		public string PressTransSerialNo
		{
			get
			{
				return this._PressTransSerialNo;
			}
			set
			{
				if ((this._PressTransSerialNo != value))
				{
					this._PressTransSerialNo = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_PressTransStateRow", DbType="Int NOT NULL")]
		public int PressTransStateRow
		{
			get
			{
				return this._PressTransStateRow;
			}
			set
			{
				if ((this._PressTransStateRow != value))
				{
					this._PressTransStateRow = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ChangeStateDate", DbType="VarChar(10) NOT NULL", CanBeNull=false)]
		public string ChangeStateDate
		{
			get
			{
				return this._ChangeStateDate;
			}
			set
			{
				if ((this._ChangeStateDate != value))
				{
					this._ChangeStateDate = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_EquipmentState_Id", DbType="SmallInt NOT NULL")]
		public short EquipmentState_Id
		{
			get
			{
				return this._EquipmentState_Id;
			}
			set
			{
				if ((this._EquipmentState_Id != value))
				{
					this._EquipmentState_Id = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_EquipmentStateName", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string EquipmentStateName
		{
			get
			{
				return this._EquipmentStateName;
			}
			set
			{
				if ((this._EquipmentStateName != value))
				{
					this._EquipmentStateName = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Store_Id", DbType="SmallInt NOT NULL")]
		public short Store_Id
		{
			get
			{
				return this._Store_Id;
			}
			set
			{
				if ((this._Store_Id != value))
				{
					this._Store_Id = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_StoreName", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string StoreName
		{
			get
			{
				return this._StoreName;
			}
			set
			{
				if ((this._StoreName != value))
				{
					this._StoreName = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_WorkShop_Id", DbType="SmallInt NOT NULL")]
		public short WorkShop_Id
		{
			get
			{
				return this._WorkShop_Id;
			}
			set
			{
				if ((this._WorkShop_Id != value))
				{
					this._WorkShop_Id = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_WorkShopName", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string WorkShopName
		{
			get
			{
				return this._WorkShopName;
			}
			set
			{
				if ((this._WorkShopName != value))
				{
					this._WorkShopName = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Calibration_Id", DbType="SmallInt NOT NULL")]
		public short Calibration_Id
		{
			get
			{
				return this._Calibration_Id;
			}
			set
			{
				if ((this._Calibration_Id != value))
				{
					this._Calibration_Id = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CalibrationName", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string CalibrationName
		{
			get
			{
				return this._CalibrationName;
			}
			set
			{
				if ((this._CalibrationName != value))
				{
					this._CalibrationName = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_GasStation_Id", DbType="Int NOT NULL")]
		public int GasStation_Id
		{
			get
			{
				return this._GasStation_Id;
			}
			set
			{
				if ((this._GasStation_Id != value))
				{
					this._GasStation_Id = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_GasStationCode", DbType="VarChar(20) NOT NULL", CanBeNull=false)]
		public string GasStationCode
		{
			get
			{
				return this._GasStationCode;
			}
			set
			{
				if ((this._GasStationCode != value))
				{
					this._GasStationCode = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_GasStationName", DbType="VarChar(100) NOT NULL", CanBeNull=false)]
		public string GasStationName
		{
			get
			{
				return this._GasStationName;
			}
			set
			{
				if ((this._GasStationName != value))
				{
					this._GasStationName = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Description", DbType="VarChar(4000)")]
		public string Description
		{
			get
			{
				return this._Description;
			}
			set
			{
				if ((this._Description != value))
				{
					this._Description = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_IsActive", DbType="Bit NOT NULL")]
		public bool IsActive
		{
			get
			{
				return this._IsActive;
			}
			set
			{
				if ((this._IsActive != value))
				{
					this._IsActive = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Model", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string Model
		{
			get
			{
				return this._Model;
			}
			set
			{
				if ((this._Model != value))
				{
					this._Model = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Brand", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string Brand
		{
			get
			{
				return this._Brand;
			}
			set
			{
				if ((this._Brand != value))
				{
					this._Brand = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_HMIState", DbType="Bit NOT NULL")]
		public bool HMIState
		{
			get
			{
				return this._HMIState;
			}
			set
			{
				if ((this._HMIState != value))
				{
					this._HMIState = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_PMax", DbType="Int NOT NULL")]
		public int PMax
		{
			get
			{
				return this._PMax;
			}
			set
			{
				if ((this._PMax != value))
				{
					this._PMax = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CalibrationDuration", DbType="Int NOT NULL")]
		public int CalibrationDuration
		{
			get
			{
				return this._CalibrationDuration;
			}
			set
			{
				if ((this._CalibrationDuration != value))
				{
					this._CalibrationDuration = value;
				}
			}
		}
	}
}
#pragma warning restore 1591