using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;
using System.Collections.ObjectModel;
using GasStationManagement.Model.CounterState;

namespace GasStationManagement.ViewModel.CounterState
{
    public class CounterState : ICounterState, IDataErrorInfo, INotifyPropertyChanged
    {
        #region Constructor
       
        public CounterState()
        {
            
        }
        #endregion

        #region Properties

        DataClassesCounterStateDataContext DRN = new DataClassesCounterStateDataContext(MSS.Library.Clasess.IniFilesSet.ReadFromXmlFiles("ConnectionDef"));
        public bool InsertEntity(List<TBL_CounterState> ListObj, ref string msgRet)
        {
            try
            {
                foreach (TBL_CounterState gh1 in ListObj)
                {
                    DRN.SP_CounterStateInsert(
                        gh1.Counter_Id,
                        gh1.CounterSerialNo,
                        gh1.ChangeStateDate,
                        gh1.EquipmentState_Id,
                        gh1.Store_Id,
                        gh1.WorkShop_Id,
                        gh1.Calibration_Id,
                        gh1.GasStation_Id,
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

        public bool UpdateEntity(List<TBL_CounterState> ListObj, ref string msgRet)
        {
            try
            {
                foreach (TBL_CounterState gh1 in ListObj)
                {
                    DRN.SP_CounterStateUpdate(
                        gh1.Counter_Id, 
                        gh1.CounterSerialNo, 
                        gh1.CounterStateRow, 
                        gh1.ChangeStateDate,
                        gh1.EquipmentState_Id, 
                        gh1.Store_Id, 
                        gh1.WorkShop_Id, 
                        gh1.Calibration_Id, 
                        gh1.GasStation_Id,
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

        public bool DeleteEntity(List<TBL_CounterState> ListObj, ref string msgRet)
        {
            try
            {
                foreach (TBL_CounterState gh1 in ListObj)
                {
                    DRN.SP_CounterStateDelete(gh1.Counter_Id, gh1.CounterSerialNo, gh1.CounterStateRow, ref msgRet);
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

        public List<VW_CounterState> GetList(ref string msgRet)
        {
            try
            {
                return (from d in DRN.VW_CounterStates select d).ToList();
            }
            catch (Exception ex)
            {
                msgRet = ex.Message;
            }
            return null;
        }

        public List<VW_CounterState> GetListByID(int Id, ref string msgRet)
        {
            try
            {
                return (from d in DRN.VW_CounterStates where d.Counter_Id == Id select d).ToList();
            }
            catch (Exception ex)
            {
                msgRet = ex.Message;
            }
            return null;
        }

        public List<VW_CounterState> GetListByFilter(List<MSS.Library.Clasess.FilterClass.QueryFilter.ExpressionBuilder.Filter> filter, ref string msgRet)
        {
            try
            {
                var deleg = MSS.Library.Clasess.FilterClass.QueryFilter.ExpressionBuilder.GetExpression<VW_CounterState>(filter).Compile();
                var filteredCollection = (from d in DRN.VW_CounterStates select d).Where(deleg);
                return filteredCollection.ToList();
            }
            catch (Exception ex)
            {
                msgRet = ex.Message;
            }
            return null;
        }

        public int CountAll(List<VW_CounterState> ListObj)
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
