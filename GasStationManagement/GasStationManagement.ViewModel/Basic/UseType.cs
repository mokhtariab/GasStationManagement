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
    public class UseType : IUseType, IDataErrorInfo, INotifyPropertyChanged
    {
        #region Constructor
       
        public UseType()
        {
            
        }
        #endregion

        #region Properties

        DataClassesBaseDataContext DRN = new DataClassesBaseDataContext(MSS.Library.Clasess.IniFilesSet.ReadFromXmlFiles("ConnectionDef"));
        public bool InsertEntity(List<TBL_UseType> ListObj, ref string msgRet)
        {
            try
            {
                foreach (TBL_UseType gh1 in ListObj)
                {
                    DRN.SP_UseTypeInsert(gh1.Id,gh1.Name, gh1.IsActive,ref msgRet);
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

        public bool UpdateEntity(List<TBL_UseType> ListObj, ref string msgRet)
        {
            try
            {
                foreach (TBL_UseType gh1 in ListObj)
                {
                    DRN.SP_UseTypeUpdate(gh1.Id, gh1.Name, gh1.IsActive, ref msgRet);
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

        public bool DeleteEntity(List<TBL_UseType> ListObj, ref string msgRet)
        {
            try
            {
                foreach (TBL_UseType gh1 in ListObj)
                {
                    DRN.SP_UseTypeDelete(gh1.Id,ref msgRet);
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

        public List<TBL_UseType> GetList(ref string msgRet)
        {
            try
            {
                return (from d in DRN.TBL_UseTypes select d).ToList();
            }
            catch (Exception ex)
            {
                msgRet = ex.Message;
            }
            return null;
        }

        public List<TBL_UseType> GetListByID(int Id, ref string msgRet)
        {
            try
            {
                return (from d in DRN.TBL_UseTypes where d.Id == Id select d).ToList();
            }
            catch (Exception ex)
            {
                msgRet = ex.Message;
            }
            return null;
        }

        public List<TBL_UseType> GetListByFilter(List<MSS.Library.Clasess.FilterClass.QueryFilter.ExpressionBuilder.Filter> filter, ref string msgRet)
        {
            try
            {
                var deleg = MSS.Library.Clasess.FilterClass.QueryFilter.ExpressionBuilder.GetExpression<TBL_UseType>(filter).Compile();
                var filteredCollection = (from d in DRN.TBL_UseTypes select d).Where(deleg);
                return filteredCollection.ToList();
            }
            catch (Exception ex)
            {
                msgRet = ex.Message;
            }
            return null;
        }

        public int CountAll(List<TBL_UseType> ListObj)
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