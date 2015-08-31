using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TIS.DL.Internal.Schedule;
using TIS.DATA.Internal;
using System.Reflection;
using System.Data.SqlClient;

namespace TIS.BL.Internal
{
    public class Schedule : PROF_IT.DLM.BL.SqlServer.BaseObject
    {

        #region Constructor
        public Schedule()
            : base()
        {
            
        }
        public Schedule(SqlTransaction transaction)
            : base(transaction)
        {
            
        }
        #endregion

        #region Methods

        public ScheduleObjectCollection GetAll()
        {
            ScheduleObjectCollection schedules;
            try
            {
                schedules = new ScheduleDataService().GetAll();
            }
            catch (System.Exception exception1)
            {
                System.Exception innerException = exception1;
                throw new System.Exception(MethodBase.GetCurrentMethod().Name, innerException);
            }
            return schedules;
        }

        public void Save(ScheduleObject schedule)
        {
            try
            {
                CheckTransaction();
                new ScheduleDataService(Transaction).Save(schedule);
                if (IsOwner) Transaction.Commit();
            }
            catch (Exception exception1)
            {
                if (IsOwner) Transaction.Rollback();
                Exception innerException = exception1;
                throw new Exception(MethodBase.GetCurrentMethod().Name, innerException);
            }
            finally
            {
                if (IsOwner) Connection.Close();
            }
        }

        public void Remove(ScheduleObject schedule)
        {
            try
            {
                CheckTransaction();
                new ScheduleDataService(Transaction).Remove(schedule);
                if (IsOwner) Transaction.Commit();
            }
            catch (Exception exception1)
            {
                if (IsOwner) Transaction.Rollback();
                Exception innerException = exception1;
                throw new Exception(MethodBase.GetCurrentMethod().Name, innerException);
            }
            finally
            {
                if (IsOwner) Connection.Close();
            }
        }

        #endregion
    }
}
