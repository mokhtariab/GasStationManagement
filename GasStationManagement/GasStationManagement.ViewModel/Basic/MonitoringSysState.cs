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
    public class MonitoringSysState : IMonitoringSysState, IDataErrorInfo, INotifyPropertyChanged
    {
        #region Constructor
       
        public MonitoringSysState()
        {
            
        }
        #endregion

        #region Properties

        DataClassesBaseDataContext DRN = new DataClassesBaseDataContext(MSS.Library.Clasess.IniFilesSet.ReadFromXmlFiles("ConnectionDef"));
        public bool InsertEntity(List<TBL_MonitoringSysState> ListObj, ref string msgRet)
        {
            try
            {
                foreach (TBL_MonitoringSysState gh1 in ListObj)
                {
                    DRN.SP_MonitoringSysStateInsert(gh1.Id, gh1.Name, gh1.IsActive, ref msgRet);
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

        public bool UpdateEntity(List<TBL_MonitoringSysState> ListObj, ref string msgRet)
        {
            try
            {
                foreach (TBL_MonitoringSysState gh1 in ListObj)
                {
                    DRN.SP_MonitoringSysStateUpdate(gh1.Id, gh1.Name, gh1.IsActive, ref msgRet);
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

        public bool DeleteEntity(List<TBL_MonitoringSysState> ListObj, ref string msgRet)
        {
            try
            {
                foreach (TBL_MonitoringSysState gh1 in ListObj)
                {
                    DRN.SP_MonitoringSysStateDelete(gh1.Id,  ref msgRet);
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

        public List<TBL_MonitoringSysState> GetList(ref string msgRet)
        {
            try
            {
                return (from d in DRN.TBL_MonitoringSysStates select d).ToList();
            }
            catch (Exception ex)
            {
                msgRet = ex.Message;
            }
            return null;
        }

        public List<TBL_MonitoringSysState> GetListByID(int Id, ref string msgRet)
        {
            try
            {
                return (from d in DRN.TBL_MonitoringSysStates where d.Id == Id select d).ToList();
            }
            catch (Exception ex)
            {
                msgRet = ex.Message;
            }
            return null;
        }

        public List<TBL_MonitoringSysState> GetListByFilter(List<MSS.Library.Clasess.FilterClass.QueryFilter.ExpressionBuilder.Filter> filter, ref string msgRet)
        {
            try
            {
                var deleg = MSS.Library.Clasess.FilterClass.QueryFilter.ExpressionBuilder.GetExpression<TBL_MonitoringSysState>(filter).Compile();
                var filteredCollection = (from d in DRN.TBL_MonitoringSysStates select d).Where(deleg);
                return filteredCollection.ToList();
            }
            catch (Exception ex)
            {
                msgRet = ex.Message;
            }
            return null;
        }

        public int CountAll(List<TBL_MonitoringSysState> ListObj)
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
