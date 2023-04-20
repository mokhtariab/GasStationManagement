using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;
using System.Collections.ObjectModel;
using GasStationManagement.Model.GasStation;

namespace GasStationManagement.ViewModel.GasStationClass
{
    public class GasStationClass : IGasStation, IDataErrorInfo, INotifyPropertyChanged
    {
        #region Constructor
       
        public GasStationClass()
        {
            
        }
        #endregion

        #region Properties

        DataClassesGasStationsDataContext DRN = new DataClassesGasStationsDataContext(MSS.Library.Clasess.IniFilesSet.ReadFromXmlFiles("ConnectionDef"));
        public bool InsertEntity(List<GasStation> ListObj, ref string msgRet)
        {
            try
            {
                foreach (GasStation gh1 in ListObj)
                {
                    DRN.SP_GasStationsInsert(gh1.ID,gh1.GasStationCode,gh1.GasStationName,gh1.GasStationBuildingDate,
                        gh1.Capacity,gh1.GasStationType_Id,gh1.WorkingPressure_Id,gh1.UseType_Id,gh1.ScheduleRegInfo,
                        gh1.ScheduleSpecPeriod,gh1.Line_Id,gh1.GasStation_Id,gh1.RanFew,gh1.Heater_Few,gh1.CounterInsLoc_Id,
                        gh1.CorrectionFactor,gh1.StationLinkType_Id,gh1.MonitoringSysState_Id,gh1.MonitoringSysExeDate,
                        gh1.Suppliers_Id,gh1.Description,gh1.IsActive,ref msgRet);
                }
                DRN.SubmitChanges();

                CreateTableEntity(ListObj, ref msgRet);

                return true;
            }
            catch (Exception ex)
            {
                msgRet = ex.Message;
            }
            
            return false;
        }

        private void CreateTableEntity(List<GasStation> ListObj, ref string msgRet)
        {
            DataClassesGasStationsDataContext DCT = new DataClassesGasStationsDataContext(MSS.Library.Clasess.IniFilesSet.ReadFromXmlFiles("ConnectionDefForTableN"));
            foreach (GasStation gh1 in ListObj)
            { DCT.SP_GasStationCreateTable(gh1.GasStationCode, ref msgRet); }
            DCT.SubmitChanges();
        }

        public bool UpdateEntity(List<GasStation> ListObj, ref string msgRet)
        {
            try
            {
                foreach (GasStation gh1 in ListObj)
                {
                    DRN.SP_GasStationsUpdate(gh1.ID, gh1.GasStationCode, gh1.GasStationName, gh1.GasStationBuildingDate,
                        gh1.Capacity, gh1.GasStationType_Id, gh1.WorkingPressure_Id, gh1.UseType_Id, gh1.ScheduleRegInfo,
                        gh1.ScheduleSpecPeriod, gh1.Line_Id, gh1.GasStation_Id, gh1.RanFew, gh1.Heater_Few, gh1.CounterInsLoc_Id,
                        gh1.CorrectionFactor, gh1.StationLinkType_Id, gh1.MonitoringSysState_Id, gh1.MonitoringSysExeDate,
                        gh1.Suppliers_Id, gh1.Description, gh1.IsActive, ref msgRet);
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

        public bool DeleteEntity(List<GasStation> ListObj, ref string msgRet)
        {
            try
            {
                foreach (GasStation gh1 in ListObj)
                {
                    DRN.SP_GasStationsDelete(gh1.ID,ref msgRet);
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

        public List<VW_GasStation> GetList(ref string msgRet)
        {
            try
            {
                return (from d in DRN.VW_GasStations select d).ToList();
            }
            catch (Exception ex)
            {
                msgRet = ex.Message;
            }
            return null;
        }

        public List<VW_GasStation> GetListByID(int Id, ref string msgRet)
        {
            try
            {
                return (from d in DRN.VW_GasStations where d.ID == Id select d).ToList();
            }
            catch (Exception ex)
            {
                msgRet = ex.Message;
            }
            return null;
        }

        public List<VW_GasStation> GetListByFilter(List<MSS.Library.Clasess.FilterClass.QueryFilter.ExpressionBuilder.Filter> filter, ref string msgRet)
        {
            try
            {
                var deleg = MSS.Library.Clasess.FilterClass.QueryFilter.ExpressionBuilder.GetExpression<VW_GasStation>(filter).Compile();
                var filteredCollection = (from d in DRN.VW_GasStations select d).Where(deleg);
                return filteredCollection.ToList();
            }
            catch (Exception ex)
            {
                msgRet = ex.Message;
            }
            return null;
        }

        public int CountAll(List<VW_GasStation> ListObj)
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
