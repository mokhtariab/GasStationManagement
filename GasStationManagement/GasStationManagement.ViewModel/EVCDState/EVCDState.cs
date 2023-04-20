using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;
using System.Collections.ObjectModel;
using GasStationManagement.Model.EVCDState;

namespace GasStationManagement.ViewModel.EVCDState
{
    public class EVCDState : IEVCDState, IDataErrorInfo, INotifyPropertyChanged
    {
        #region Constructor
       
        public EVCDState()
        {
            
        }
        #endregion

        #region Properties

        DataClassesEVCDStateDataContext DRN = new DataClassesEVCDStateDataContext(MSS.Library.Clasess.IniFilesSet.ReadFromXmlFiles("ConnectionDef"));
        public bool InsertEntity(List<TBL_EVCDState> ListObj, ref string msgRet)
        {
            try
            {
                foreach (TBL_EVCDState gh1 in ListObj)
                {
                    DRN.SP_EVCDStateInsert(gh1.EVCD_Id,gh1.EVCDSerialNo,gh1.EVCDStateRow,gh1.ChangeStateDate,
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

        public bool UpdateEntity(List<TBL_EVCDState> ListObj, ref string msgRet)
        {
            try
            {
                foreach (TBL_EVCDState gh1 in ListObj)
                {
                    DRN.SP_EVCDStateUpdate(gh1.EVCD_Id, gh1.EVCDSerialNo, gh1.EVCDStateRow, gh1.ChangeStateDate,
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

        public bool DeleteEntity(List<TBL_EVCDState> ListObj, ref string msgRet)
        {
            try
            {
                foreach (TBL_EVCDState gh1 in ListObj)
                {
                    DRN.SP_EVCDStateDelete(gh1.EVCD_Id, gh1.EVCDSerialNo, gh1.EVCDStateRow, ref msgRet);
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

        public List<VW_EVCDState> GetList(ref string msgRet)
        {
            try
            {
                return (from d in DRN.VW_EVCDStates select d).ToList();
            }
            catch (Exception ex)
            {
                msgRet = ex.Message;
            }
            return null;
        }

        public List<VW_EVCDState> GetListByID(int Id, ref string msgRet)
        {
            try
            {
                return (from d in DRN.VW_EVCDStates where d.EVCD_Id == Id select d).ToList();
            }
            catch (Exception ex)
            {
                msgRet = ex.Message;
            }
            return null;
        }

        public List<VW_EVCDState> GetListByFilter(List<MSS.Library.Clasess.FilterClass.QueryFilter.ExpressionBuilder.Filter> filter, ref string msgRet)
        {
            try
            {
                var deleg = MSS.Library.Clasess.FilterClass.QueryFilter.ExpressionBuilder.GetExpression<VW_EVCDState>(filter).Compile();
                var filteredCollection = (from d in DRN.VW_EVCDStates select d).Where(deleg);
                return filteredCollection.ToList();
            }
            catch (Exception ex)
            {
                msgRet = ex.Message;
            }
            return null;
        }

        public int CountAll(List<VW_EVCDState> ListObj)
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
