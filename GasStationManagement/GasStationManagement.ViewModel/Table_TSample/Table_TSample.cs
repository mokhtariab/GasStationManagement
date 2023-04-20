using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;
using System.Collections.ObjectModel;
using GasStationManagement.Model.Table_TSample;
using System.Data;

namespace GasStationManagement.ViewModel.Table_TSample
{
    public class Table_TSample : ITable_TSample, IDataErrorInfo, INotifyPropertyChanged
    {
        #region Constructor
       
        public Table_TSample()
        {
            
        }
        #endregion

        #region Properties

        DataClassesTable_TSampleDataContext DRN = new DataClassesTable_TSampleDataContext(MSS.Library.Clasess.IniFilesSet.ReadFromXmlFiles("ConnectionDef"));
        

        public List<string> GetFieldList()
        {
            try
            {
                var propnames = GetPropertyNames(DRN.Table_TSamples);
                var columnName = from t in typeof(Model.Table_TSample.Table_TSample).GetFields() select t.Name;
                return propnames.ToList();
                //var columnName = new Model.Table_TSample.Table_TSample().Columns.Cast<DataColumn>().ElementAt(colindex).ColumnName;
                //return (from DataColumn 
                //            Model.Table_TSample.Table_TSample Table_TSamples .Cast<DataColumn>()
                //        where dc.AllowDBNull == true
                //        select dc.ColumnName ).ToList();
            }
            catch (Exception ex)
            {
                //msgRet = ex.Message;
            }
            return null;
        }

        static IEnumerable<string> GetPropertyNames<T>(IEnumerable<T> lst)
        {
            foreach (var pi in typeof(T).GetProperties())
            {
                yield return pi.Name;
            }
        }
        public bool InsertEntity(List<Model.Table_TSample.Table_TSample> ListObj, ref string msgRet)
        {
            try
            {
                foreach (Model.Table_TSample.Table_TSample gh1 in ListObj)
                {
                    DRN.SP_Table_TSampleInsert(
                        gh1.Id,
                        gh1.GasStationCode,
                        gh1.GasStationName,
                        gh1.time_Stamp,
                        gh1.strTimeStampShamsi,
                        gh1.bInvalid,
                        gh1.nStationID,
                        gh1.nProjectID,
                        gh1.fSysUpTime_Hour,
                        gh1.nSourceID_OfResetPAC,
                        gh1.bResetPAC_Pend,
                        gh1.fStationCapacity,
                        gh1.fTotalQb,
                        gh1.fTotalQm,
                        gh1.fInGasT,
                        gh1.fOutGasT,
                        gh1.fInGasP,
                        gh1.fOutGasP,
                        gh1.fAirT,
                        gh1.EK1_nVb,
                        gh1.EK1_nVbD,
                        gh1.EK1_nVm,
                        gh1.EK1_nVmD,
                        gh1.EK2_fP_Psi,
                        gh1.EK1_fT,
                        gh1.EK1_fC,
                        gh1.EK1_fQm,
                        gh1.EK1_fQb,
                        gh1.EK1_fTbX,
                        gh1.EK1_fPbX,
                        gh1.EK1_nBatRemain,
                        gh1.EK2_nVb,
                        gh1.EK2_nVbD,
                        gh1.EK2_nVm,
                        gh1.EK2_nVmD,
                        gh1.EK2_fP_Psi,
                        gh1.EK2_fT,
                        gh1.EK2_fC,
                        gh1.EK2_fQm,
                        gh1.EK2_fQb,
                        gh1.EK2_fTbX,
                        gh1.EK2_fPbX,
                        gh1.EK2_nBatRemain,
                        gh1.EK3_nVb,
                        gh1.EK3_nVbD,
                        gh1.EK3_nVm,
                        gh1.EK3_nVmD,
                        gh1.EK3_fP_Psi,
                        gh1.EK3_fT,
                        gh1.EK3_fC,
                        gh1.EK3_fQm,
                        gh1.EK3_fQb,
                        gh1.EK3_fTbX,
                        gh1.EK3_fPbX,
                        gh1.EK3_nBatRemain,
                        gh1.fInT_Ht1,
                        gh1.fOutT_Ht1,
                        gh1.bWaterLLA_Ht1,
                        gh1.fInT_Ht2,
                        gh1.fOutT_Ht2,
                        gh1.fWaterT_Ht2,
                        gh1.bWaterLLA_Ht2,
                        gh1.fWaterT_Ht1,
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

        public bool UpdateEntity(List<Model.Table_TSample.Table_TSample> ListObj, ref string msgRet)
        {
            try
            {
                foreach (Model.Table_TSample.Table_TSample gh1 in ListObj)
                {
                    DRN.SP_Table_TSampleUpdate(
                        gh1.Id,
                        gh1.GasStationCode,
                        gh1.GasStationName,
                        gh1.time_Stamp,
                        gh1.strTimeStampShamsi,
                        gh1.bInvalid,
                        gh1.nStationID,
                        gh1.nProjectID,
                        gh1.fSysUpTime_Hour,
                        gh1.nSourceID_OfResetPAC,
                        gh1.bResetPAC_Pend,
                        gh1.fStationCapacity,
                        gh1.fTotalQb,
                        gh1.fTotalQm,
                        gh1.fInGasT,
                        gh1.fOutGasT,
                        gh1.fInGasP,
                        gh1.fOutGasP,
                        gh1.fAirT,
                        gh1.EK1_nVb,
                        gh1.EK1_nVbD,
                        gh1.EK1_nVm,
                        gh1.EK1_nVmD,
                        gh1.EK2_fP_Psi,
                        gh1.EK1_fT,
                        gh1.EK1_fC,
                        gh1.EK1_fQm,
                        gh1.EK1_fQb,
                        gh1.EK1_fTbX,
                        gh1.EK1_fPbX,
                        gh1.EK1_nBatRemain,
                        gh1.EK2_nVb,
                        gh1.EK2_nVbD,
                        gh1.EK2_nVm,
                        gh1.EK2_nVmD,
                        gh1.EK2_fP_Psi,
                        gh1.EK2_fT,
                        gh1.EK2_fC,
                        gh1.EK2_fQm,
                        gh1.EK2_fQb,
                        gh1.EK2_fTbX,
                        gh1.EK2_fPbX,
                        gh1.EK2_nBatRemain,
                        gh1.EK3_nVb,
                        gh1.EK3_nVbD,
                        gh1.EK3_nVm,
                        gh1.EK3_nVmD,
                        gh1.EK3_fP_Psi,
                        gh1.EK3_fT,
                        gh1.EK3_fC,
                        gh1.EK3_fQm,
                        gh1.EK3_fQb,
                        gh1.EK3_fTbX,
                        gh1.EK3_fPbX,
                        gh1.EK3_nBatRemain,
                        gh1.fInT_Ht1,
                        gh1.fOutT_Ht1,
                        gh1.bWaterLLA_Ht1,
                        gh1.fInT_Ht2,
                        gh1.fOutT_Ht2,
                        gh1.fWaterT_Ht2,
                        gh1.bWaterLLA_Ht2,
                        gh1.fWaterT_Ht1,
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

        public bool DeleteEntity(List<Model.Table_TSample.Table_TSample> ListObj, ref string msgRet)
        {
            try
            {
                foreach (Model.Table_TSample.Table_TSample gh1 in ListObj)
                {
                    DRN.SP_Table_TSampleDelete(
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
        public bool ClearEntity(ref string msgRet)
        {
            try
            {
                DRN.SP_Table_TSampleClear(
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

        DataClassesTable_TSampleDataContext DCT = new DataClassesTable_TSampleDataContext(MSS.Library.Clasess.IniFilesSet.ReadFromXmlFiles("ConnectionDefForTableN"));
        public bool InsertUpdateTable_T(Model.Table_TSample.Table_TSample ListObj, ref string msgRet)
        {
            try
            {
                DCT.SP_Table_TInsertUpdate(
                    ListObj.GasStationCode,
                    ListObj.time_Stamp.Value,
                    ListObj.strTimeStampShamsi,
                    ListObj.bInvalid,
                    ListObj.nProjectID,
                    ListObj.fSysUpTime_Hour,
                    ListObj.nSourceID_OfResetPAC,
                    ListObj.bResetPAC_Pend,
                    ListObj.fStationCapacity,
                    ListObj.fTotalQb,
                    ListObj.fTotalQm,
                    ListObj.fInGasT,
                    ListObj.fOutGasT,
                    ListObj.fInGasP,
                    ListObj.fOutGasP,
                    ListObj.fAirT,
                    ListObj.EK1_nVb,
                    ListObj.EK1_nVbD,
                    ListObj.EK1_nVm,
                    ListObj.EK1_nVmD,
                    ListObj.EK2_fP_Psi,
                    ListObj.EK1_fT,
                    ListObj.EK1_fC,
                    ListObj.EK1_fQm,
                    ListObj.EK1_fQb,
                    ListObj.EK1_fTbX,
                    ListObj.EK1_fPbX,
                    ListObj.EK1_nBatRemain,
                    ListObj.EK2_nVb,
                    ListObj.EK2_nVbD,
                    ListObj.EK2_nVm,
                    ListObj.EK2_nVmD,
                    ListObj.EK2_fP_Psi,
                    ListObj.EK2_fT,
                    ListObj.EK2_fC,
                    ListObj.EK2_fQm,
                    ListObj.EK2_fQb,
                    ListObj.EK2_fTbX,
                    ListObj.EK2_fPbX,
                    ListObj.EK2_nBatRemain,
                    ListObj.EK3_nVb,
                    ListObj.EK3_nVbD,
                    ListObj.EK3_nVm,
                    ListObj.EK3_nVmD,
                    ListObj.EK3_fP_Psi,
                    ListObj.EK3_fT,
                    ListObj.EK3_fC,
                    ListObj.EK3_fQm,
                    ListObj.EK3_fQb,
                    ListObj.EK3_fTbX,
                    ListObj.EK3_fPbX,
                    ListObj.EK3_nBatRemain,
                    ListObj.fInT_Ht1,
                    ListObj.fOutT_Ht1,
                    ListObj.bWaterLLA_Ht1,
                    ListObj.fInT_Ht2,
                    ListObj.fOutT_Ht2,
                    ListObj.fWaterT_Ht2,
                    ListObj.bWaterLLA_Ht2,
                    ListObj.fWaterT_Ht1,
                    ref msgRet
                    );
                if (msgRet == "")
                    return true;
                else
                    return false;
            }
            catch (Exception ex)
            {
                msgRet = ex.Message;
            }

            return false;
        }



        public List<Model.Table_TSample.Table_TSample> GetList(ref string msgRet)
        {
            try
            {
                return (from d in DRN.Table_TSamples select d).ToList();
            }
            catch (Exception ex)
            {
                msgRet = ex.Message;
            }
            return null;
        }

        public List<Model.Table_TSample.Table_TSample> GetListByID(int Id, ref string msgRet)
        {
            throw new NotImplementedException();
        }

        public List<Model.Table_TSample.Table_TSample> GetListByFilter(List<MSS.Library.Clasess.FilterClass.QueryFilter.ExpressionBuilder.Filter> filter, ref string msgRet)
        {
            throw new NotImplementedException();
        }

        public int CountAll(List<Model.Table_TSample.Table_TSample> ListObj)
        {
            throw new NotImplementedException();
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
