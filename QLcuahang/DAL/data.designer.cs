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

namespace DAL
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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="QL_BANMAYLANH")]
	public partial class dataDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void InsertLoaiNV(LoaiNV instance);
    partial void UpdateLoaiNV(LoaiNV instance);
    partial void DeleteLoaiNV(LoaiNV instance);
    partial void InsertPhanQuyen(PhanQuyen instance);
    partial void UpdatePhanQuyen(PhanQuyen instance);
    partial void DeletePhanQuyen(PhanQuyen instance);
    partial void InsertNhanVien(NhanVien instance);
    partial void UpdateNhanVien(NhanVien instance);
    partial void DeleteNhanVien(NhanVien instance);
    partial void InsertNguoiDung(NguoiDung instance);
    partial void UpdateNguoiDung(NguoiDung instance);
    partial void DeleteNguoiDung(NguoiDung instance);
    partial void InsertManHinh(ManHinh instance);
    partial void UpdateManHinh(ManHinh instance);
    partial void DeleteManHinh(ManHinh instance);
    #endregion
		
		public dataDataContext() : 
				base(global::DAL.Properties.Settings.Default.QL_BANMAYLANHConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public dataDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public dataDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public dataDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public dataDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<LoaiNV> LoaiNVs
		{
			get
			{
				return this.GetTable<LoaiNV>();
			}
		}
		
		public System.Data.Linq.Table<PhanQuyen> PhanQuyens
		{
			get
			{
				return this.GetTable<PhanQuyen>();
			}
		}
		
		public System.Data.Linq.Table<NhanVien> NhanViens
		{
			get
			{
				return this.GetTable<NhanVien>();
			}
		}
		
		public System.Data.Linq.Table<NguoiDung> NguoiDungs
		{
			get
			{
				return this.GetTable<NguoiDung>();
			}
		}
		
		public System.Data.Linq.Table<ManHinh> ManHinhs
		{
			get
			{
				return this.GetTable<ManHinh>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.LoaiNV")]
	public partial class LoaiNV : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _Id;
		
		private string _TenLoaiNV;
		
		private EntitySet<PhanQuyen> _PhanQuyens;
		
		private EntitySet<NhanVien> _NhanViens;
		
		private EntitySet<NguoiDung> _NguoiDungs;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIdChanging(int value);
    partial void OnIdChanged();
    partial void OnTenLoaiNVChanging(string value);
    partial void OnTenLoaiNVChanged();
    #endregion
		
		public LoaiNV()
		{
			this._PhanQuyens = new EntitySet<PhanQuyen>(new Action<PhanQuyen>(this.attach_PhanQuyens), new Action<PhanQuyen>(this.detach_PhanQuyens));
			this._NhanViens = new EntitySet<NhanVien>(new Action<NhanVien>(this.attach_NhanViens), new Action<NhanVien>(this.detach_NhanViens));
			this._NguoiDungs = new EntitySet<NguoiDung>(new Action<NguoiDung>(this.attach_NguoiDungs), new Action<NguoiDung>(this.detach_NguoiDungs));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Id", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int Id
		{
			get
			{
				return this._Id;
			}
			set
			{
				if ((this._Id != value))
				{
					this.OnIdChanging(value);
					this.SendPropertyChanging();
					this._Id = value;
					this.SendPropertyChanged("Id");
					this.OnIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TenLoaiNV", DbType="NVarChar(100) NOT NULL", CanBeNull=false)]
		public string TenLoaiNV
		{
			get
			{
				return this._TenLoaiNV;
			}
			set
			{
				if ((this._TenLoaiNV != value))
				{
					this.OnTenLoaiNVChanging(value);
					this.SendPropertyChanging();
					this._TenLoaiNV = value;
					this.SendPropertyChanged("TenLoaiNV");
					this.OnTenLoaiNVChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="LoaiNV_PhanQuyen", Storage="_PhanQuyens", ThisKey="Id", OtherKey="IdLoaiNV")]
		public EntitySet<PhanQuyen> PhanQuyens
		{
			get
			{
				return this._PhanQuyens;
			}
			set
			{
				this._PhanQuyens.Assign(value);
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="LoaiNV_NhanVien", Storage="_NhanViens", ThisKey="Id", OtherKey="IdLoaiNV")]
		public EntitySet<NhanVien> NhanViens
		{
			get
			{
				return this._NhanViens;
			}
			set
			{
				this._NhanViens.Assign(value);
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="LoaiNV_NguoiDung", Storage="_NguoiDungs", ThisKey="Id", OtherKey="IdLoaiNV")]
		public EntitySet<NguoiDung> NguoiDungs
		{
			get
			{
				return this._NguoiDungs;
			}
			set
			{
				this._NguoiDungs.Assign(value);
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
		
		private void attach_PhanQuyens(PhanQuyen entity)
		{
			this.SendPropertyChanging();
			entity.LoaiNV = this;
		}
		
		private void detach_PhanQuyens(PhanQuyen entity)
		{
			this.SendPropertyChanging();
			entity.LoaiNV = null;
		}
		
		private void attach_NhanViens(NhanVien entity)
		{
			this.SendPropertyChanging();
			entity.LoaiNV = this;
		}
		
		private void detach_NhanViens(NhanVien entity)
		{
			this.SendPropertyChanging();
			entity.LoaiNV = null;
		}
		
		private void attach_NguoiDungs(NguoiDung entity)
		{
			this.SendPropertyChanging();
			entity.LoaiNV = this;
		}
		
		private void detach_NguoiDungs(NguoiDung entity)
		{
			this.SendPropertyChanging();
			entity.LoaiNV = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.PhanQuyen")]
	public partial class PhanQuyen : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _Id;
		
		private int _IdLoaiNV;
		
		private int _IdManHinh;
		
		private bool _CoQuyen;
		
		private EntityRef<LoaiNV> _LoaiNV;
		
		private EntityRef<ManHinh> _ManHinh;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIdChanging(int value);
    partial void OnIdChanged();
    partial void OnIdLoaiNVChanging(int value);
    partial void OnIdLoaiNVChanged();
    partial void OnIdManHinhChanging(int value);
    partial void OnIdManHinhChanged();
    partial void OnCoQuyenChanging(bool value);
    partial void OnCoQuyenChanged();
    #endregion
		
		public PhanQuyen()
		{
			this._LoaiNV = default(EntityRef<LoaiNV>);
			this._ManHinh = default(EntityRef<ManHinh>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Id", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int Id
		{
			get
			{
				return this._Id;
			}
			set
			{
				if ((this._Id != value))
				{
					this.OnIdChanging(value);
					this.SendPropertyChanging();
					this._Id = value;
					this.SendPropertyChanged("Id");
					this.OnIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_IdLoaiNV", DbType="Int NOT NULL")]
		public int IdLoaiNV
		{
			get
			{
				return this._IdLoaiNV;
			}
			set
			{
				if ((this._IdLoaiNV != value))
				{
					if (this._LoaiNV.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnIdLoaiNVChanging(value);
					this.SendPropertyChanging();
					this._IdLoaiNV = value;
					this.SendPropertyChanged("IdLoaiNV");
					this.OnIdLoaiNVChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_IdManHinh", DbType="Int NOT NULL")]
		public int IdManHinh
		{
			get
			{
				return this._IdManHinh;
			}
			set
			{
				if ((this._IdManHinh != value))
				{
					if (this._ManHinh.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnIdManHinhChanging(value);
					this.SendPropertyChanging();
					this._IdManHinh = value;
					this.SendPropertyChanged("IdManHinh");
					this.OnIdManHinhChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CoQuyen", DbType="Bit NOT NULL")]
		public bool CoQuyen
		{
			get
			{
				return this._CoQuyen;
			}
			set
			{
				if ((this._CoQuyen != value))
				{
					this.OnCoQuyenChanging(value);
					this.SendPropertyChanging();
					this._CoQuyen = value;
					this.SendPropertyChanged("CoQuyen");
					this.OnCoQuyenChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="LoaiNV_PhanQuyen", Storage="_LoaiNV", ThisKey="IdLoaiNV", OtherKey="Id", IsForeignKey=true)]
		public LoaiNV LoaiNV
		{
			get
			{
				return this._LoaiNV.Entity;
			}
			set
			{
				LoaiNV previousValue = this._LoaiNV.Entity;
				if (((previousValue != value) 
							|| (this._LoaiNV.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._LoaiNV.Entity = null;
						previousValue.PhanQuyens.Remove(this);
					}
					this._LoaiNV.Entity = value;
					if ((value != null))
					{
						value.PhanQuyens.Add(this);
						this._IdLoaiNV = value.Id;
					}
					else
					{
						this._IdLoaiNV = default(int);
					}
					this.SendPropertyChanged("LoaiNV");
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="ManHinh_PhanQuyen", Storage="_ManHinh", ThisKey="IdManHinh", OtherKey="Id", IsForeignKey=true)]
		public ManHinh ManHinh
		{
			get
			{
				return this._ManHinh.Entity;
			}
			set
			{
				ManHinh previousValue = this._ManHinh.Entity;
				if (((previousValue != value) 
							|| (this._ManHinh.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._ManHinh.Entity = null;
						previousValue.PhanQuyens.Remove(this);
					}
					this._ManHinh.Entity = value;
					if ((value != null))
					{
						value.PhanQuyens.Add(this);
						this._IdManHinh = value.Id;
					}
					else
					{
						this._IdManHinh = default(int);
					}
					this.SendPropertyChanged("ManHinh");
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.NhanVien")]
	public partial class NhanVien : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _IdNV;
		
		private string _TenNV;
		
		private string _TenDN;
		
		private string _MatKhau;
		
		private string _SDTNV;
		
		private int _IdLoaiNV;
		
		private EntitySet<NguoiDung> _NguoiDungs;
		
		private EntityRef<LoaiNV> _LoaiNV;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIdNVChanging(int value);
    partial void OnIdNVChanged();
    partial void OnTenNVChanging(string value);
    partial void OnTenNVChanged();
    partial void OnTenDNChanging(string value);
    partial void OnTenDNChanged();
    partial void OnMatKhauChanging(string value);
    partial void OnMatKhauChanged();
    partial void OnSDTNVChanging(string value);
    partial void OnSDTNVChanged();
    partial void OnIdLoaiNVChanging(int value);
    partial void OnIdLoaiNVChanged();
    #endregion
		
		public NhanVien()
		{
			this._NguoiDungs = new EntitySet<NguoiDung>(new Action<NguoiDung>(this.attach_NguoiDungs), new Action<NguoiDung>(this.detach_NguoiDungs));
			this._LoaiNV = default(EntityRef<LoaiNV>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_IdNV", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int IdNV
		{
			get
			{
				return this._IdNV;
			}
			set
			{
				if ((this._IdNV != value))
				{
					this.OnIdNVChanging(value);
					this.SendPropertyChanging();
					this._IdNV = value;
					this.SendPropertyChanged("IdNV");
					this.OnIdNVChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TenNV", DbType="NVarChar(100) NOT NULL", CanBeNull=false)]
		public string TenNV
		{
			get
			{
				return this._TenNV;
			}
			set
			{
				if ((this._TenNV != value))
				{
					this.OnTenNVChanging(value);
					this.SendPropertyChanging();
					this._TenNV = value;
					this.SendPropertyChanged("TenNV");
					this.OnTenNVChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TenDN", DbType="NVarChar(100) NOT NULL", CanBeNull=false)]
		public string TenDN
		{
			get
			{
				return this._TenDN;
			}
			set
			{
				if ((this._TenDN != value))
				{
					this.OnTenDNChanging(value);
					this.SendPropertyChanging();
					this._TenDN = value;
					this.SendPropertyChanged("TenDN");
					this.OnTenDNChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MatKhau", DbType="NVarChar(20) NOT NULL", CanBeNull=false)]
		public string MatKhau
		{
			get
			{
				return this._MatKhau;
			}
			set
			{
				if ((this._MatKhau != value))
				{
					this.OnMatKhauChanging(value);
					this.SendPropertyChanging();
					this._MatKhau = value;
					this.SendPropertyChanged("MatKhau");
					this.OnMatKhauChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_SDTNV", DbType="VarChar(12) NOT NULL", CanBeNull=false)]
		public string SDTNV
		{
			get
			{
				return this._SDTNV;
			}
			set
			{
				if ((this._SDTNV != value))
				{
					this.OnSDTNVChanging(value);
					this.SendPropertyChanging();
					this._SDTNV = value;
					this.SendPropertyChanged("SDTNV");
					this.OnSDTNVChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_IdLoaiNV", DbType="Int NOT NULL")]
		public int IdLoaiNV
		{
			get
			{
				return this._IdLoaiNV;
			}
			set
			{
				if ((this._IdLoaiNV != value))
				{
					if (this._LoaiNV.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnIdLoaiNVChanging(value);
					this.SendPropertyChanging();
					this._IdLoaiNV = value;
					this.SendPropertyChanged("IdLoaiNV");
					this.OnIdLoaiNVChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="NhanVien_NguoiDung", Storage="_NguoiDungs", ThisKey="IdNV", OtherKey="IdNV")]
		public EntitySet<NguoiDung> NguoiDungs
		{
			get
			{
				return this._NguoiDungs;
			}
			set
			{
				this._NguoiDungs.Assign(value);
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="LoaiNV_NhanVien", Storage="_LoaiNV", ThisKey="IdLoaiNV", OtherKey="Id", IsForeignKey=true)]
		public LoaiNV LoaiNV
		{
			get
			{
				return this._LoaiNV.Entity;
			}
			set
			{
				LoaiNV previousValue = this._LoaiNV.Entity;
				if (((previousValue != value) 
							|| (this._LoaiNV.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._LoaiNV.Entity = null;
						previousValue.NhanViens.Remove(this);
					}
					this._LoaiNV.Entity = value;
					if ((value != null))
					{
						value.NhanViens.Add(this);
						this._IdLoaiNV = value.Id;
					}
					else
					{
						this._IdLoaiNV = default(int);
					}
					this.SendPropertyChanged("LoaiNV");
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
		
		private void attach_NguoiDungs(NguoiDung entity)
		{
			this.SendPropertyChanging();
			entity.NhanVien = this;
		}
		
		private void detach_NguoiDungs(NguoiDung entity)
		{
			this.SendPropertyChanging();
			entity.NhanVien = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.NguoiDung")]
	public partial class NguoiDung : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _id;
		
		private int _IdNV;
		
		private int _IdLoaiNV;
		
		private string _ghichu;
		
		private EntityRef<LoaiNV> _LoaiNV;
		
		private EntityRef<NhanVien> _NhanVien;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnidChanging(int value);
    partial void OnidChanged();
    partial void OnIdNVChanging(int value);
    partial void OnIdNVChanged();
    partial void OnIdLoaiNVChanging(int value);
    partial void OnIdLoaiNVChanged();
    partial void OnghichuChanging(string value);
    partial void OnghichuChanged();
    #endregion
		
		public NguoiDung()
		{
			this._LoaiNV = default(EntityRef<LoaiNV>);
			this._NhanVien = default(EntityRef<NhanVien>);
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_IdNV", DbType="Int NOT NULL")]
		public int IdNV
		{
			get
			{
				return this._IdNV;
			}
			set
			{
				if ((this._IdNV != value))
				{
					if (this._NhanVien.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnIdNVChanging(value);
					this.SendPropertyChanging();
					this._IdNV = value;
					this.SendPropertyChanged("IdNV");
					this.OnIdNVChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_IdLoaiNV", DbType="Int NOT NULL")]
		public int IdLoaiNV
		{
			get
			{
				return this._IdLoaiNV;
			}
			set
			{
				if ((this._IdLoaiNV != value))
				{
					if (this._LoaiNV.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnIdLoaiNVChanging(value);
					this.SendPropertyChanging();
					this._IdLoaiNV = value;
					this.SendPropertyChanged("IdLoaiNV");
					this.OnIdLoaiNVChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ghichu", DbType="NVarChar(100)")]
		public string ghichu
		{
			get
			{
				return this._ghichu;
			}
			set
			{
				if ((this._ghichu != value))
				{
					this.OnghichuChanging(value);
					this.SendPropertyChanging();
					this._ghichu = value;
					this.SendPropertyChanged("ghichu");
					this.OnghichuChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="LoaiNV_NguoiDung", Storage="_LoaiNV", ThisKey="IdLoaiNV", OtherKey="Id", IsForeignKey=true)]
		public LoaiNV LoaiNV
		{
			get
			{
				return this._LoaiNV.Entity;
			}
			set
			{
				LoaiNV previousValue = this._LoaiNV.Entity;
				if (((previousValue != value) 
							|| (this._LoaiNV.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._LoaiNV.Entity = null;
						previousValue.NguoiDungs.Remove(this);
					}
					this._LoaiNV.Entity = value;
					if ((value != null))
					{
						value.NguoiDungs.Add(this);
						this._IdLoaiNV = value.Id;
					}
					else
					{
						this._IdLoaiNV = default(int);
					}
					this.SendPropertyChanged("LoaiNV");
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="NhanVien_NguoiDung", Storage="_NhanVien", ThisKey="IdNV", OtherKey="IdNV", IsForeignKey=true)]
		public NhanVien NhanVien
		{
			get
			{
				return this._NhanVien.Entity;
			}
			set
			{
				NhanVien previousValue = this._NhanVien.Entity;
				if (((previousValue != value) 
							|| (this._NhanVien.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._NhanVien.Entity = null;
						previousValue.NguoiDungs.Remove(this);
					}
					this._NhanVien.Entity = value;
					if ((value != null))
					{
						value.NguoiDungs.Add(this);
						this._IdNV = value.IdNV;
					}
					else
					{
						this._IdNV = default(int);
					}
					this.SendPropertyChanged("NhanVien");
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.ManHinh")]
	public partial class ManHinh : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _Id;
		
		private string _TenMH;
		
		private EntitySet<PhanQuyen> _PhanQuyens;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIdChanging(int value);
    partial void OnIdChanged();
    partial void OnTenMHChanging(string value);
    partial void OnTenMHChanged();
    #endregion
		
		public ManHinh()
		{
			this._PhanQuyens = new EntitySet<PhanQuyen>(new Action<PhanQuyen>(this.attach_PhanQuyens), new Action<PhanQuyen>(this.detach_PhanQuyens));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Id", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int Id
		{
			get
			{
				return this._Id;
			}
			set
			{
				if ((this._Id != value))
				{
					this.OnIdChanging(value);
					this.SendPropertyChanging();
					this._Id = value;
					this.SendPropertyChanged("Id");
					this.OnIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TenMH", DbType="NVarChar(100) NOT NULL", CanBeNull=false)]
		public string TenMH
		{
			get
			{
				return this._TenMH;
			}
			set
			{
				if ((this._TenMH != value))
				{
					this.OnTenMHChanging(value);
					this.SendPropertyChanging();
					this._TenMH = value;
					this.SendPropertyChanged("TenMH");
					this.OnTenMHChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="ManHinh_PhanQuyen", Storage="_PhanQuyens", ThisKey="Id", OtherKey="IdManHinh")]
		public EntitySet<PhanQuyen> PhanQuyens
		{
			get
			{
				return this._PhanQuyens;
			}
			set
			{
				this._PhanQuyens.Assign(value);
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
		
		private void attach_PhanQuyens(PhanQuyen entity)
		{
			this.SendPropertyChanging();
			entity.ManHinh = this;
		}
		
		private void detach_PhanQuyens(PhanQuyen entity)
		{
			this.SendPropertyChanging();
			entity.ManHinh = null;
		}
	}
}
#pragma warning restore 1591