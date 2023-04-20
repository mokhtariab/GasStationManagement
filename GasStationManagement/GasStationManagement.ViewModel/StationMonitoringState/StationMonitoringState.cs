using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;
using System.Collections.ObjectModel;
using GasStationManagement.Model.StationMonitoringState;

namespace GasStationManagement.ViewModel.StationMonitoringState
{
    public class StationMonitoringState : IStationMonitoringState, IDataErrorInfo, INotifyPropertyChanged
    {
        #region Constructor
       
        public StationMonitoringState()
        {
            
        }
        #endregion

        #region Properties

        DataClassesStationMonitoringStateDataContext DRN = new DataClassesStationMonitoringStateDataContext(MSS.Library.Clasess.IniFilesSet.ReadFromXmlFiles("ConnectionDef"));
        public bool InsertEntity(List<TBL_StationMonitoringState> ListObj, ref string msgRet, ref int? id)
        {
            try
            {
                foreach (TBL_StationMonitoringState gh1 in ListObj)
                {
                    DRN.SP_StationMonitoringStateInsert(
                        ref id,
                        gh1.GasStation_Id,
                        gh1.StationLinkType_Id,
                        gh1.MonitoringSysState_Id,
                        gh1.MonitoringSysExeDate,
                        gh1.Suppliers_Id,
                        gh1.ChangeStateDate,
                        gh1.Description,
                        gh1.IsActive,
                        ref msgRet
                        );
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

        public bool UpdateEntity(List<TBL_StationMonitoringState> ListObj, ref string msgRet)
        {
            try
            {
                foreach (TBL_StationMonitoringState gh1 in ListObj)
                {
                    DRN.SP_StationMonitoringStateUpdate(
                        gh1.Id,
                        gh1.GasStation_Id,
                        gh1.StationLinkType_Id,
                        gh1.MonitoringSysState_Id,
                        gh1.MonitoringSysExeDate,
                        gh1.Suppliers_Id,
                        gh1.ChangeStateDate,
                        gh1.Description,
                        gh1.IsActive,
                        ref msgRet
                        );
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

        public bool DeleteEntity(List<TBL_StationMonitoringState> ListObj, ref string msgRet)
        {
            try
            {
                foreach (TBL_StationMonitoringState gh1 in ListObj)
                {
                    DRN.SP_StationMonitoringStateDelete(
                        gh1.Id, 
                        ref msgRet
                        );
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

        public List<VW_StationMonitoringState> GetList(ref string msgRet)
        {
            try
            {
                return (from d in DRN.VW_StationMonitoringStates select d).ToList();
            }
            catch (Exception ex)
            {
                msgRet = ex.Message;
            }
            return null;
        }

        public List<VW_StationMonitoringState> GetListByID(int Id, ref string msgRet)
        {
            try
            {
                return (from d in DRN.VW_StationMonitoringStates where d.Id == Id select d).ToList();
            }
            catch (Exception ex)
            {
                msgRet = ex.Message;
            }
            return null;
        }

        public List<VW_StationMonitoringState> GetListByFilter(List<MSS.Library.Clasess.FilterClass.QueryFilter.ExpressionBuilder.Filter> filter, ref string msgRet)
        {
            try
            {
                var deleg = MSS.Library.Clasess.FilterClass.QueryFilter.ExpressionBuilder.GetExpression<VW_StationMonitoringState>(filter).Compile();
                var filteredCollection = (from d in DRN.VW_StationMonitoringStates select d).Where(deleg);
                return filteredCollection.ToList();
            }
            catch (Exception ex)
            {
                msgRet = ex.Message;
            }
            return null;
        }

        public int CountAll(List<VW_StationMonitoringState> ListObj)
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
