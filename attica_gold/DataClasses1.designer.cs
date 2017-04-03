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

namespace attica_gold
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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="AtticagoldDB")]
	public partial class DataClasses1DataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void InserttblEmployee(tblEmployee instance);
    partial void UpdatetblEmployee(tblEmployee instance);
    partial void DeletetblEmployee(tblEmployee instance);
    #endregion
		
		public DataClasses1DataContext() : 
				base(global::System.Configuration.ConfigurationManager.ConnectionStrings["AtticagoldDB"].ConnectionString, mappingSource)
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
		
		public System.Data.Linq.Table<tblEmployee> tblEmployees
		{
			get
			{
				return this.GetTable<tblEmployee>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.tblEmployee")]
	public partial class tblEmployee : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _id;
		
		private System.Nullable<int> _employee_id;
		
		private string _first_name;
		
		private string _last_name;
		
		private string _gender;
		
		private string _mobile_number;
		
		private string _alter_mobile_number;
		
		private string _email;
		
		private string _street;
		
		private string _city;
		
		private string _state;
		
		private string _pin;
		
		private string _permanet_address;
		
		private string _employee_role;
		
		private System.Nullable<System.DateTime> _createdat;
		
		private System.Nullable<System.DateTime> _modifiedat;
		
		private System.Nullable<System.DateTime> _deletedat;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnidChanging(int value);
    partial void OnidChanged();
    partial void Onemployee_idChanging(System.Nullable<int> value);
    partial void Onemployee_idChanged();
    partial void Onfirst_nameChanging(string value);
    partial void Onfirst_nameChanged();
    partial void Onlast_nameChanging(string value);
    partial void Onlast_nameChanged();
    partial void OngenderChanging(string value);
    partial void OngenderChanged();
    partial void Onmobile_numberChanging(string value);
    partial void Onmobile_numberChanged();
    partial void Onalter_mobile_numberChanging(string value);
    partial void Onalter_mobile_numberChanged();
    partial void OnemailChanging(string value);
    partial void OnemailChanged();
    partial void OnstreetChanging(string value);
    partial void OnstreetChanged();
    partial void OncityChanging(string value);
    partial void OncityChanged();
    partial void OnstateChanging(string value);
    partial void OnstateChanged();
    partial void OnpinChanging(string value);
    partial void OnpinChanged();
    partial void Onpermanet_addressChanging(string value);
    partial void Onpermanet_addressChanged();
    partial void Onemployee_roleChanging(string value);
    partial void Onemployee_roleChanged();
    partial void OncreatedatChanging(System.Nullable<System.DateTime> value);
    partial void OncreatedatChanged();
    partial void OnmodifiedatChanging(System.Nullable<System.DateTime> value);
    partial void OnmodifiedatChanged();
    partial void OndeletedatChanging(System.Nullable<System.DateTime> value);
    partial void OndeletedatChanged();
    #endregion
		
		public tblEmployee()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_id", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int id
		{
			get
			{
				return this._id;
			}
			set
			{
				if ((this._id != value))
				{
					this.OnidChanging(value);
					this.SendPropertyChanging();
					this._id = value;
					this.SendPropertyChanged("id");
					this.OnidChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_employee_id", DbType="Int")]
		public System.Nullable<int> employee_id
		{
			get
			{
				return this._employee_id;
			}
			set
			{
				if ((this._employee_id != value))
				{
					this.Onemployee_idChanging(value);
					this.SendPropertyChanging();
					this._employee_id = value;
					this.SendPropertyChanged("employee_id");
					this.Onemployee_idChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_first_name", DbType="NVarChar(50)")]
		public string first_name
		{
			get
			{
				return this._first_name;
			}
			set
			{
				if ((this._first_name != value))
				{
					this.Onfirst_nameChanging(value);
					this.SendPropertyChanging();
					this._first_name = value;
					this.SendPropertyChanged("first_name");
					this.Onfirst_nameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_last_name", DbType="NVarChar(50)")]
		public string last_name
		{
			get
			{
				return this._last_name;
			}
			set
			{
				if ((this._last_name != value))
				{
					this.Onlast_nameChanging(value);
					this.SendPropertyChanging();
					this._last_name = value;
					this.SendPropertyChanged("last_name");
					this.Onlast_nameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_gender", DbType="NVarChar(50)")]
		public string gender
		{
			get
			{
				return this._gender;
			}
			set
			{
				if ((this._gender != value))
				{
					this.OngenderChanging(value);
					this.SendPropertyChanging();
					this._gender = value;
					this.SendPropertyChanged("gender");
					this.OngenderChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_mobile_number", DbType="VarChar(10)")]
		public string mobile_number
		{
			get
			{
				return this._mobile_number;
			}
			set
			{
				if ((this._mobile_number != value))
				{
					this.Onmobile_numberChanging(value);
					this.SendPropertyChanging();
					this._mobile_number = value;
					this.SendPropertyChanged("mobile_number");
					this.Onmobile_numberChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_alter_mobile_number", DbType="VarChar(10)")]
		public string alter_mobile_number
		{
			get
			{
				return this._alter_mobile_number;
			}
			set
			{
				if ((this._alter_mobile_number != value))
				{
					this.Onalter_mobile_numberChanging(value);
					this.SendPropertyChanging();
					this._alter_mobile_number = value;
					this.SendPropertyChanged("alter_mobile_number");
					this.Onalter_mobile_numberChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_email", DbType="NVarChar(50)")]
		public string email
		{
			get
			{
				return this._email;
			}
			set
			{
				if ((this._email != value))
				{
					this.OnemailChanging(value);
					this.SendPropertyChanging();
					this._email = value;
					this.SendPropertyChanged("email");
					this.OnemailChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_street", DbType="NVarChar(50)")]
		public string street
		{
			get
			{
				return this._street;
			}
			set
			{
				if ((this._street != value))
				{
					this.OnstreetChanging(value);
					this.SendPropertyChanging();
					this._street = value;
					this.SendPropertyChanged("street");
					this.OnstreetChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_city", DbType="NVarChar(50)")]
		public string city
		{
			get
			{
				return this._city;
			}
			set
			{
				if ((this._city != value))
				{
					this.OncityChanging(value);
					this.SendPropertyChanging();
					this._city = value;
					this.SendPropertyChanged("city");
					this.OncityChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_state", DbType="NVarChar(50)")]
		public string state
		{
			get
			{
				return this._state;
			}
			set
			{
				if ((this._state != value))
				{
					this.OnstateChanging(value);
					this.SendPropertyChanging();
					this._state = value;
					this.SendPropertyChanged("state");
					this.OnstateChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_pin", DbType="NVarChar(50)")]
		public string pin
		{
			get
			{
				return this._pin;
			}
			set
			{
				if ((this._pin != value))
				{
					this.OnpinChanging(value);
					this.SendPropertyChanging();
					this._pin = value;
					this.SendPropertyChanged("pin");
					this.OnpinChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_permanet_address", DbType="NVarChar(100)")]
		public string permanet_address
		{
			get
			{
				return this._permanet_address;
			}
			set
			{
				if ((this._permanet_address != value))
				{
					this.Onpermanet_addressChanging(value);
					this.SendPropertyChanging();
					this._permanet_address = value;
					this.SendPropertyChanged("permanet_address");
					this.Onpermanet_addressChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_employee_role", DbType="NVarChar(50)")]
		public string employee_role
		{
			get
			{
				return this._employee_role;
			}
			set
			{
				if ((this._employee_role != value))
				{
					this.Onemployee_roleChanging(value);
					this.SendPropertyChanging();
					this._employee_role = value;
					this.SendPropertyChanged("employee_role");
					this.Onemployee_roleChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_createdat", DbType="DateTime")]
		public System.Nullable<System.DateTime> createdat
		{
			get
			{
				return this._createdat;
			}
			set
			{
				if ((this._createdat != value))
				{
					this.OncreatedatChanging(value);
					this.SendPropertyChanging();
					this._createdat = value;
					this.SendPropertyChanged("createdat");
					this.OncreatedatChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_modifiedat", DbType="DateTime")]
		public System.Nullable<System.DateTime> modifiedat
		{
			get
			{
				return this._modifiedat;
			}
			set
			{
				if ((this._modifiedat != value))
				{
					this.OnmodifiedatChanging(value);
					this.SendPropertyChanging();
					this._modifiedat = value;
					this.SendPropertyChanged("modifiedat");
					this.OnmodifiedatChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_deletedat", DbType="DateTime")]
		public System.Nullable<System.DateTime> deletedat
		{
			get
			{
				return this._deletedat;
			}
			set
			{
				if ((this._deletedat != value))
				{
					this.OndeletedatChanging(value);
					this.SendPropertyChanging();
					this._deletedat = value;
					this.SendPropertyChanged("deletedat");
					this.OndeletedatChanged();
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
}
#pragma warning restore 1591
