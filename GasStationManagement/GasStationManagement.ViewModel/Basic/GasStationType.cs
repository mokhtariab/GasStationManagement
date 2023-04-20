﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;
using System.Collections.ObjectModel;
using GasStationManagement.Model.Basic.IClass;
using GasStationManagement.Model.Basic.DataAccess;

namespace GasStationManagement.ViewModel.Basic
{
    public class GasStationType : IGasStationType, IDataErrorInfo, INotifyPropertyChanged
    {
        #region Constructor
       
        public GasStationType()
        {
            
        }
        #endregion

        #region Properties

        DataClassesBaseDataContext DRN = new DataClassesBaseDataContext(MSS.Library.Clasess.IniFilesSet.ReadFromXmlFiles("ConnectionDef"));
        public bool InsertEntity(List<TBL_GasStationType> ListObj, ref string msgRet)
        {
            try
            {
                foreach (TBL_GasStationType gh1 in ListObj)
                {
                    DRN.SP_GasStationTypeInsert(gh1.Id, gh1.Name, gh1.IsActive, ref msgRet);
                }
                DRN.SubmitChanges();
                return true;
            }
            catch (Exception ex)
            {
                msgRet = ex.Message;
            }
            
            return false;
        }

        public bool UpdateEntity(List<TBL_GasStationType> ListObj, ref string msgRet)
        {
            try
            {
                foreach (TBL_GasStationType gh1 in ListObj)
                {
                    DRN.SP_GasStationTypeUpdate(gh1.Id, gh1.Name, gh1.IsActive, ref msgRet);
                }
                DRN.SubmitChanges();
                return true;
            }
            catch (Exception ex)
            {
                msgRet = ex.Message;
            }

            return false;
        }

        public bool DeleteEntity(List<TBL_GasStationType> ListObj, ref string msgRet)
        {
            try
            {
                foreach (TBL_GasStationType gh1 in ListObj)
                {
                    DRN.SP_GasStationTypeDelete(gh1.Id, ref msgRet);
                }
                DRN.SubmitChanges();
                return true;
            }
            catch (Exception ex)
            {
                msgRet = ex.Message;
            }
            return false;
        }

        public List<TBL_GasStationType> GetList(ref string msgRet)
        {
            try
            {
                return (from d in DRN.TBL_GasStationTypes select d).ToList();
            }
            catch (Exception ex)
            {
                msgRet = ex.Message;
            }
            return null;
        }

        public List<TBL_GasStationType> GetListByID(int Id, ref string msgRet)
        {
            try
            {
                return (from d in DRN.TBL_GasStationTypes where d.Id == Id select d).ToList();
            }
            catch (Exception ex)
            {
                msgRet = ex.Message;
            }
            return null;
        }

        public List<TBL_GasStationType> GetListByFilter(List<MSS.Library.Clasess.FilterClass.QueryFilter.ExpressionBuilder.Filter> filter, ref string msgRet)
        {
            try
            {
                var deleg = MSS.Library.Clasess.FilterClass.QueryFilter.ExpressionBuilder.GetExpression<TBL_GasStationType>(filter).Compile();
                var filteredCollection = (from d in DRN.TBL_GasStationTypes select d).Where(deleg);
                return filteredCollection.ToList();
            }
            catch (Exception ex)
            {
                msgRet = ex.Message;
            }
            return null;
        }

        public int CountAll(List<TBL_GasStationType> ListObj)
        {
            return ListObj.Count();
        }
        #endregion

        #region IDataErrorInfo

        public string Error
        {
            get { throw new NotImplementedException(); }
        }

        public string this[string columnName]
        {
            get { throw new NotImplementedException(); }
        }

        #endregion

        #region INotifyPropertyChanged
        [field: NonSerialized]
        public event PropertyChangedEventHandler PropertyChanged;

        protected void RaisePropertyChanged(string propertyName)
        {
            var handler = PropertyChanged;
            if (handler != null)
            {
                handler(this, new PropertyChangedEventArgs(propertyName));
            }
        }
        #endregion
        
    }
}
