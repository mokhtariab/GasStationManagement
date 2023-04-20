using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;
using System.Collections.ObjectModel;
using GasStationManagement.Model.MonitoringState;

namespace GasStationManagement.ViewModel.MonitoringState
{
    public class MonitoringState : IMonitoringState, IDataErrorInfo, INotifyPropertyChanged
    {
        #region Constructor
       
        public MonitoringState()
        {
            
        }
        #endregion

        #region Properties

        DataClassesMonitoringStateDataContext DRN = new DataClassesMonitoringStateDataContext(MSS.Library.Clasess.IniFilesSet.ReadFromXmlFiles("ConnectionDef"));
        public bool InsertEntity(List<TBL_MonitoringState> ListObj, ref string msgRet)
        {
            try
            {
                foreach (TBL_MonitoringState gh1 in ListObj)
                {
                    DRN.SP_MonitoringStateInsert(gh1.Monitoring_Id,gh1.MonitoringSerialNo,gh1.MonitoringStateRow,gh1.ChangeStateDate,
                        gh1.EquipmentState_Id,gh1.Store_Id,gh1.WorkShop_Id,gh1.Calibration_Id,gh1.GasStation_Id,
                        gh1.Description,gh1.IsActive,ref msgRet);
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

        public bool UpdateEntity(List<TBL_MonitoringState> ListObj, ref string msgRet)
        {
            try
            {
                foreach (TBL_MonitoringState gh1 in ListObj)
                {
                    DRN.SP_MonitoringStateUpdate(gh1.Monitoring_Id, gh1.MonitoringSerialNo, gh1.MonitoringStateRow, gh1.ChangeStateDate,
                        gh1.EquipmentState_Id, gh1.Store_Id, gh1.WorkShop_Id, gh1.Calibration_Id, gh1.GasStation_Id,
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

        public bool DeleteEntity(List<TBL_MonitoringState> ListObj, ref string msgRet)
        {
            try
            {
                foreach (TBL_MonitoringState gh1 in ListObj)
                {
                    DRN.SP_MonitoringStateDelete(gh1.Monitoring_Id,ref msgRet);
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

        public List<TBL_MonitoringState> GetList(ref string msgRet)
        {
            try
            {
                return (from d in DRN.TBL_MonitoringStates select d).ToList();
            }
            catch (Exception ex)
            {
                msgRet = ex.Message;
            }
            return null;
        }

        public List<TBL_MonitoringState> GetListByID(int Id, ref string msgRet)
        {
            try
            {
                return (from d in DRN.TBL_MonitoringStates where d.Monitoring_Id == Id select d).ToList();
            }
            catch (Exception ex)
            {
                msgRet = ex.Message;
            }
            return null;
        }

        public List<TBL_MonitoringState> GetListByFilter(List<MSS.Library.Clasess.FilterClass.QueryFilter.ExpressionBuilder.Filter> filter, ref string msgRet)
        {
            try
            {
                var deleg = MSS.Library.Clasess.FilterClass.QueryFilter.ExpressionBuilder.GetExpression<TBL_MonitoringState>(filter).Compile();
                var filteredCollection = (from d in DRN.TBL_MonitoringStates select d).Where(deleg);
                return filteredCollection.ToList();
            }
            catch (Exception ex)
            {
                msgRet = ex.Message;
            }
            return null;
        }

        public int CountAll(List<TBL_MonitoringState> ListObj)
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
