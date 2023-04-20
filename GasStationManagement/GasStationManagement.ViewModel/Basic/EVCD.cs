using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;
using System.Collections.ObjectModel;
using GasStationManagement.Model.Basic.IClass;
using GasStationManagement.Model.Basic.DataAccess;

namespace GasStationManagement.ViewModel.Basic
{
    public class EVCD : IEVCD, IDataErrorInfo, INotifyPropertyChanged
    {
        #region Constructor
       
        public EVCD()
        {
            
        }
        #endregion

        #region Properties

        DataClassesBaseDataContext DRN = new DataClassesBaseDataContext(MSS.Library.Clasess.IniFilesSet.ReadFromXmlFiles("ConnectionDef"));
        public bool InsertEntity(List<TBL_EVCD> ListObj, ref string msgRet)
        {
            try
            {
                foreach (TBL_EVCD gh1 in ListObj)
                {
                    DRN.SP_EVCDInsert(gh1.Id, gh1.Model, gh1.Brand, gh1.PMin, gh1.PMax, gh1.CalibrationDuration, 
                        gh1.Description, gh1.IsActive, ref msgRet);
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

        public bool UpdateEntity(List<TBL_EVCD> ListObj, ref string msgRet)
        {
            try
            {
                foreach (TBL_EVCD gh1 in ListObj)
                {
                    DRN.SP_EVCDUpdate(gh1.Id, gh1.Model, gh1.Brand, gh1.PMin, gh1.PMax, gh1.CalibrationDuration,
                        gh1.Description, gh1.IsActive, ref msgRet);
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

        public bool DeleteEntity(List<TBL_EVCD> ListObj, ref string msgRet)
        {
            try
            {
                foreach (TBL_EVCD gh1 in ListObj)
                {
                    DRN.SP_EVCDDelete(gh1.Id,ref msgRet);
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

        public List<TBL_EVCD> GetList(ref string msgRet)
        {
            try
            {
                return (from d in DRN.TBL_EVCDs select d).ToList();
            }
            catch (Exception ex)
            {
                msgRet = ex.Message;
            }
            return null;
        }

        public List<TBL_EVCD> GetListByID(int Id, ref string msgRet)
        {
            try
            {
                return (from d in DRN.TBL_EVCDs where d.Id == Id select d).ToList();
            }
            catch (Exception ex)
            {
                msgRet = ex.Message;
            }
            return null;
        }

        public List<TBL_EVCD> GetListByFilter(List<MSS.Library.Clasess.FilterClass.QueryFilter.ExpressionBuilder.Filter> filter, ref string msgRet)
        {
            try
            {
                var deleg = MSS.Library.Clasess.FilterClass.QueryFilter.ExpressionBuilder.GetExpression<TBL_EVCD>(filter).Compile();
                var filteredCollection = (from d in DRN.TBL_EVCDs select d).Where(deleg);
                return filteredCollection.ToList();
            }
            catch (Exception ex)
            {
                msgRet = ex.Message;
            }
            return null;
        }

        public int CountAll(List<TBL_EVCD> ListObj)
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
