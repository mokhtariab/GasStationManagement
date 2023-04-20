using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;
using System.Collections.ObjectModel;
using GasStationManagement.Model.PressTransState;

namespace GasStationManagement.ViewModel.PressTransState
{
    public class PressTransState : IPressTransState, IDataErrorInfo, INotifyPropertyChanged
    {
        #region Constructor
       
        public PressTransState()
        {
            
        }
        #endregion

        #region Properties

        DataClassesPressTransStateDataContext DRN = new DataClassesPressTransStateDataContext(MSS.Library.Clasess.IniFilesSet.ReadFromXmlFiles("ConnectionDef"));
        public bool InsertEntity(List<TBL_PressTransState> ListObj, ref string msgRet)
        {
            try
            {
                foreach (TBL_PressTransState gh1 in ListObj)
                {
                    DRN.SP_PressTransStateInsert(gh1.PressTrans_Id,gh1.PressTransSerialNo,gh1.PressTransStateRow,gh1.ChangeStateDate,
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

        public bool UpdateEntity(List<TBL_PressTransState> ListObj, ref string msgRet)
        {
            try
            {
                foreach (TBL_PressTransState gh1 in ListObj)
                {
                    DRN.SP_PressTransStateUpdate(gh1.PressTrans_Id, gh1.PressTransSerialNo, gh1.PressTransStateRow, gh1.ChangeStateDate,
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

        public bool DeleteEntity(List<TBL_PressTransState> ListObj, ref string msgRet)
        {
            try
            {
                foreach (TBL_PressTransState gh1 in ListObj)
                {
                    DRN.SP_PressTransStateDelete(gh1.PressTrans_Id, gh1.PressTransSerialNo, gh1.PressTransStateRow, ref msgRet);
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

        public List<VW_PressTransState> GetList(ref string msgRet)
        {
            try
            {
                return (from d in DRN.VW_PressTransStates select d).ToList();
            }
            catch (Exception ex)
            {
                msgRet = ex.Message;
            }
            return null;
        }

        public List<VW_PressTransState> GetListByID(int Id, ref string msgRet)
        {
            try
            {
                return (from d in DRN.VW_PressTransStates where d.PressTrans_Id == Id select d).ToList();
            }
            catch (Exception ex)
            {
                msgRet = ex.Message;
            }
            return null;
        }

        public List<VW_PressTransState> GetListByFilter(List<MSS.Library.Clasess.FilterClass.QueryFilter.ExpressionBuilder.Filter> filter, ref string msgRet)
        {
            try
            {
                var deleg = MSS.Library.Clasess.FilterClass.QueryFilter.ExpressionBuilder.GetExpression<VW_PressTransState>(filter).Compile();
                var filteredCollection = (from d in DRN.VW_PressTransStates select d).Where(deleg);
                return filteredCollection.ToList();
            }
            catch (Exception ex)
            {
                msgRet = ex.Message;
            }
            return null;
        }

        public int CountAll(List<VW_PressTransState> ListObj)
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
