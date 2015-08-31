using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using PROF_IT.DLM.DATA.SqlServer;
using System.Data;
using PROF_IT.DLM.DATA;
using TIS.DL.Internal.MaterialRevision;
using TIS.DL.Internal.Maintenance;
using System.Reflection;
using System.Data.SqlClient;
using TIS.DL.Internal.Employee;
using TIS.DL.Internal.MaintenanceVehicle;

namespace TIS.DATA.Internal
{
    public class MaterialRevisionDataService : DataServiceBase
    {
        public MaterialRevisionDataService()
            : base()
        { }
        public MaterialRevisionDataService(IDbTransaction txn)
            : base(txn)
        { }

        public string BaseQuery(bool selectTop, int top)
        {
            QueryBuilder builder;
            try
            {
                builder = new QueryBuilder();
                if (selectTop == true)
                    builder.SelectTop(top);
                else
                    builder.Select();
                builder.AppendColumn(MaterialRevisionObject.MATREV_ID);
                builder.AppendColumn(MaterialRevisionObject.MAINT_ID);
                builder.AppendColumn(MaterialRevisionObject.REVISION);
                builder.AppendColumn(MaterialRevisionObject.ANSWER);
                builder.AppendColumn(MaterialRevisionObject.CATEGORY);
                builder.AppendColumn(MaintenanceObject.EMP_ID_EXECUTOR);
                builder.AppendColumn(MaintenanceObject.MAINT_ID);
                builder.AppendColumn(MaintenanceObject.MAINTVEH_ID);
                builder.AppendColumn(MaintenanceObject.MAT_ID);
                builder.AppendColumn(MaintenanceObject.REMARK);
                builder.AppendColumn(MaintenanceObject.START_MAINTENANCE);
                builder.AppendColumn(EmployeeObject.ARCHIVE);
                builder.AppendColumn(EmployeeObject.EMAIL);
                builder.AppendColumn(EmployeeObject.EMP_ID);
                builder.AppendColumn(EmployeeObject.LAN_ID);
                builder.AppendColumn(EmployeeObject.NAME);
                builder.AppendColumn(EmployeeObject.SURNAME);
                builder.AppendColumn(EmployeeObject.TRANSC_ID);
                builder.AppendColumn(EmployeeObject.TRANSC_LANGUAGE);
                builder.AppendColumn(EmployeeObject.TRANSI_ID);
                builder.AppendColumn(EmployeeObject.REPEAT_MAIL);
                builder.AppendFromTable(MaterialRevisionObject.TABLE);
                builder.AppendLeftJoin(MaintenanceObject.TABLE, MaintenanceObject.MAINT_ID, MaterialRevisionObject.MAINT_ID);
                builder.AppendLeftJoin(EmployeeObject.TABLE, EmployeeObject.EMP_ID, MaintenanceObject.EMP_ID_EXECUTOR);
                builder.AppendLeftJoin(MaintenanceVehicleObject.TABLE, MaintenanceVehicleObject.MAINTVEH_ID, MaintenanceObject.MAINTVEH_ID);
                return builder.Query;
            }
            catch (System.Exception exception1)
            {
                Exception innerException = exception1;
                throw new Exception(MethodBase.GetCurrentMethod().Name, innerException);
            }
        }


        public MaterialRevisionObjectCollection GetByMaintenance(MaintenanceObject maintenance)
        {
            MaterialRevisionObjectCollection materialRevisions = new MaterialRevisionObjectCollection();
            QueryBuilder builder;
            try
            {
                builder = new QueryBuilder();
                builder.Append(this.BaseQuery(false, 0));
                builder.AppendWhereString(MaterialRevisionObject.MAINT_ID, maintenance.MaintID.ToString(), QueryBuilder.ComparisonOperators.Equal, QueryBuilder.ParameterLocation.FIRST);
                builder.Append("AND " + MaterialRevisionObject.MAINT_ID + " is not null ");
                materialRevisions = MaterialRevisionConvertor.DataTableToCollection(this.ExecuteDataSet(builder.Query, false).Tables[0]);
            }
            catch (System.Exception exception1)
            {
                throw new Exception(MethodBase.GetCurrentMethod().Name, exception1);
            }
            return materialRevisions;
        }

        public void Save(MaterialRevisionObject materialRevision)
        {
            SqlCommand cmd = null;
            try
            {
                ExecuteNonQuery(out cmd, false, "MaterialRevision_SAVE",
                    CreateParameter("@matrevID", SqlDbType.UniqueIdentifier, materialRevision.MatRevID, ParameterDirection.InputOutput),
                    CreateParameter("@maintID", SqlDbType.UniqueIdentifier, materialRevision.Maintenance == null ? Guid.Empty : materialRevision.Maintenance.MaintID),
                    CreateParameter("@Revision", SqlDbType.VarChar, materialRevision.Revision),
                    CreateParameter("@Answer", SqlDbType.VarChar, materialRevision.Answer),
                    CreateParameter("@Category", SqlDbType.VarChar, materialRevision.Category)
                    );
                materialRevision.MatRevID = (Guid)cmd.Parameters["@matrevID"].Value;
            }
            catch (Exception exception1)
            {
                Exception innerException = exception1;
                throw new Exception(MethodBase.GetCurrentMethod().Name, innerException);
            }
            finally
            {
                if (cmd != null)
                {
                    cmd.Dispose();
                }
                cmd = null;
            }
        }

        public bool Remove(MaterialRevisionObject materialRevision)
        {
            SqlCommand cmd = null;
            try
            {
                ExecuteNonQuery(out cmd, false, "MaterialRevision_DELETE",
                    CreateParameter("@matrevID", SqlDbType.UniqueIdentifier, materialRevision.MatRevID, ParameterDirection.Input)
                    );
                return true;
            }
            catch (Exception exception1)
            {
                Exception innerException = exception1;
                throw new Exception(MethodBase.GetCurrentMethod().Name, innerException);
            }
            finally
            {
                if (cmd != null)
                {
                    cmd.Dispose();
                }
                cmd = null;
            }
        }
    }
}
