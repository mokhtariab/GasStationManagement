using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;
using System.Collections.ObjectModel;
using GasStationManagement.Model.StationMonitoringStateParameters;

namespace GasStationManagement.ViewModel.StationMonitoringStateParameters
{
    public class StationMonitoringStateParameters : IStationMonitoringStateParameters, IDataErrorInfo, INotifyPropertyChanged
    {
        #region Constructor
       
        public StationMonitoringStateParameters()
        {
            
        }
        #endregion

        #region Properties

        DataClassesStationMonitoringStateParametersDataContext DRN = new DataClassesStationMonitoringStateParametersDataContext(MSS.Library.Clasess.IniFilesSet.ReadFromXmlFiles("ConnectionDef"));
        public bool InsertEntity(List<TBL_StationMonitoringStateParameter> ListObj, ref string msgRet)
        {
            int? id = 0;
            try
            {
                foreach (TBL_StationMonitoringStateParameter gh1 in ListObj)
                {
                    DRN.SP_StationMonitoringStateParametersInsert(
                        ref id,
                        gh1.StationMonitoringState_Id,
                        gh1.Parameters_Id,
                        gh1.Description,
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

        public bool UpdateEntity(List<TBL_StationMonitoringStateParameter> ListObj, ref string msgRet)
        {
            try
            {
                foreach (TBL_StationMonitoringStateParameter gh1 in ListObj)
                {
                    DRN.SP_StationMonitoringStateParametersUpdate(
                        gh1.Id,
                        gh1.StationMonitoringState_Id,
                        gh1.Parameters_Id,
                        gh1.Description,
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

        public bool DeleteEntity(List<TBL_StationMonitoringStateParameter> ListObj, ref string msgRet)
        {
            try
            {
                foreach (TBL_StationMonitoringStateParameter gh1 in ListObj)
                {
                    DRN.SP_StationMonitoringStateParametersDelete(
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

        public List<VW_StationMonitoringStateParameter> GetList(ref string msgRet)
        {
            try
            {
                return (from d in DRN.VW_StationMonitoringStateParameters select d).ToList();
            }
            catch (Exception ex)
            {
                msgRet = ex.Message;
            }
            return null;
        }

        public List<VW_StationMonitoringStateParameter> GetListByID(int Id, ref string msgRet)
        {
            try
            {
                return (from d in DRN.VW_StationMonitoringStateParameters where d.Id == Id select d).ToList();
            }
            catch (Exception ex)
            {
                msgRet = ex.Message;
            }
            return null;
        }

        public List<VW_StationMonitoringStateParameter> GetListByFilter(List<MSS.Library.Clasess.FilterClass.QueryFilter.ExpressionBuilder.Filter> filter, ref string msgRet)
        {
            try
            {
                var deleg = MSS.Library.Clasess.FilterClass.QueryFilter.ExpressionBuilder.GetExpression<VW_StationMonitoringStateParameter>(filter).Compile();
                var filteredCollection = (from d in DRN.VW_StationMonitoringStateParameters select d).Where(deleg);
                return filteredCollection.ToList();
            }
            catch (Exception ex)
            {
                msgRet = ex.Message;
            }
            return null;
        }

        public int CountAll(List<VW_StationMonitoringStateParameter> ListObj)
        {
            return ListObj.Count();
        }


        public bool DeleteWithStationMonitoringState(int StationMonitoringState_Id, ref string msgRet)
        {
            try
            {
                    DRN.SP_StationMonitoringStateParametersDeleteWithSMSId(
                        StationMonitoringState_Id,
                        ref msgRet
                        );
                DRN.SubmitChanges();
                return true;
            }
            catch (Exception ex)
            {
                msgRet = ex.Message;
            }
            return false;
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
