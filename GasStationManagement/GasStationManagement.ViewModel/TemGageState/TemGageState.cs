using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;
using System.Collections.ObjectModel;
using GasStationManagement.Model.TemGageState;

namespace GasStationManagement.ViewModel.TemGageState
{
    public class TemGageState : ITemGageState, IDataErrorInfo, INotifyPropertyChanged
    {
        #region Constructor
       
        public TemGageState()
        {
            
        }
        #endregion

        #region Properties

        DataClassesTemGageStateDataContext DRN = new DataClassesTemGageStateDataContext(MSS.Library.Clasess.IniFilesSet.ReadFromXmlFiles("ConnectionDef"));
        public bool InsertEntity(List<TBL_TemGageState> ListObj, ref string msgRet)
        {
            try
            {
                foreach (TBL_TemGageState gh1 in ListObj)
                {
                    DRN.SP_TemGageStateInsert(gh1.TemGage_Id,gh1.TemGageSerialNo,gh1.TemGageStateRow,gh1.ChangeStateDate,
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

        public bool UpdateEntity(List<TBL_TemGageState> ListObj, ref string msgRet)
        {
            try
            {
                foreach (TBL_TemGageState gh1 in ListObj)
                {
                    DRN.SP_TemGageStateUpdate(gh1.TemGage_Id, gh1.TemGageSerialNo, gh1.TemGageStateRow, gh1.ChangeStateDate,
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

        public bool DeleteEntity(List<TBL_TemGageState> ListObj, ref string msgRet)
        {
            try
            {
                foreach (TBL_TemGageState gh1 in ListObj)
                {
                    DRN.SP_TemGageStateDelete(gh1.TemGage_Id, gh1.TemGageSerialNo, gh1.TemGageStateRow, ref msgRet);
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

        public List<VW_TemGageState> GetList(ref string msgRet)
        {
            try
            {
                return (from d in DRN.VW_TemGageStates select d).ToList();
            }
            catch (Exception ex)
            {
                msgRet = ex.Message;
            }
            return null;
        }

        public List<VW_TemGageState> GetListByID(int Id, ref string msgRet)
        {
            try
            {
                return (from d in DRN.VW_TemGageStates where d.TemGage_Id == Id select d).ToList();
            }
            catch (Exception ex)
            {
                msgRet = ex.Message;
            }
            return null;
        }

        public List<VW_TemGageState> GetListByFilter(List<MSS.Library.Clasess.FilterClass.QueryFilter.ExpressionBuilder.Filter> filter, ref string msgRet)
        {
            try
            {
                var deleg = MSS.Library.Clasess.FilterClass.QueryFilter.ExpressionBuilder.GetExpression<VW_TemGageState>(filter).Compile();
                var filteredCollection = (from d in DRN.VW_TemGageStates select d).Where(deleg);
                return filteredCollection.ToList();
            }
            catch (Exception ex)
            {
                msgRet = ex.Message;
            }
            return null;
        }

        public int CountAll(List<VW_TemGageState> ListObj)
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
