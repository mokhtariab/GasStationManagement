using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;
using System.Collections.ObjectModel;
using GasStationManagement.Model.PressGageState;

namespace GasStationManagement.ViewModel.PressGageState
{
    public class PressGageState : IPressGageState, IDataErrorInfo, INotifyPropertyChanged
    {
        #region Constructor
       
        public PressGageState()
        {
            
        }
        #endregion

        #region Properties

        DataClassesPressGageStateDataContext DRN = new DataClassesPressGageStateDataContext(MSS.Library.Clasess.IniFilesSet.ReadFromXmlFiles("ConnectionDef"));
        public bool InsertEntity(List<TBL_PressGageState> ListObj, ref string msgRet)
        {
            try
            {
                foreach (TBL_PressGageState gh1 in ListObj)
                {
                    DRN.SP_PressGageStateInsert(gh1.PressGage_Id,gh1.PressGageSerialNo,gh1.PressGageStateRow,gh1.ChangeStateDate,
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

        public bool UpdateEntity(List<TBL_PressGageState> ListObj, ref string msgRet)
        {
            try
            {
                foreach (TBL_PressGageState gh1 in ListObj)
                {
                    DRN.SP_PressGageStateUpdate(gh1.PressGage_Id, gh1.PressGageSerialNo, gh1.PressGageStateRow, gh1.ChangeStateDate,
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

        public bool DeleteEntity(List<TBL_PressGageState> ListObj, ref string msgRet)
        {
            try
            {
                foreach (TBL_PressGageState gh1 in ListObj)
                {
                    DRN.SP_PressGageStateDelete(gh1.PressGage_Id, gh1.PressGageSerialNo, gh1.PressGageStateRow, ref msgRet);
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

        public List<VW_PressGageState> GetList(ref string msgRet)
        {
            try
            {
                return (from d in DRN.VW_PressGageStates select d).ToList();
            }
            catch (Exception ex)
            {
                msgRet = ex.Message;
            }
            return null;
        }

        public List<VW_PressGageState> GetListByID(int Id, ref string msgRet)
        {
            try
            {
                return (from d in DRN.VW_PressGageStates where d.PressGage_Id == Id select d).ToList();
            }
            catch (Exception ex)
            {
                msgRet = ex.Message;
            }
            return null;
        }

        public List<VW_PressGageState> GetListByFilter(List<MSS.Library.Clasess.FilterClass.QueryFilter.ExpressionBuilder.Filter> filter, ref string msgRet)
        {
            try
            {
                var deleg = MSS.Library.Clasess.FilterClass.QueryFilter.ExpressionBuilder.GetExpression<VW_PressGageState>(filter).Compile();
                var filteredCollection = (from d in DRN.VW_PressGageStates select d).Where(deleg);
                return filteredCollection.ToList();
            }
            catch (Exception ex)
            {
                msgRet = ex.Message;
            }
            return null;
        }

        public int CountAll(List<VW_PressGageState> ListObj)
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
