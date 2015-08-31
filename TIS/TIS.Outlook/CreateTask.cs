using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Linq;
using Outlook = Microsoft.Office.Interop.Outlook;
using Office = Microsoft.Office.Core;
using System.Windows.Forms;
using PROF_IT.Exceptionhandling;
using System.Reflection;
using TIS.Client.Task;
using TIS.DL.Internal.TaskPeople;
using TIS.DL.Internal.Employee;
using TIS.DL.Internal.Task;
using TIS.DL.Internal.Supplier;
using TIS.DL.Internal.Customer;
using TIS.DL.Internal.Unknown;
using System.Threading;

namespace TIS.Outlook
{
    public partial class CreateTask
    {

        #region Private Fields
        private Office.CommandBar tisToolBar;
        private Office.CommandBarButton tisCreateTaskToolBarButton;
        #endregion        

        #region Events
        private void CreateTask_Startup(object sender, System.EventArgs e)
        {
            try
            {
                if (tisToolBar == null)
                {
                    tisToolBar = Application.ActiveExplorer().CommandBars.Add("TIS", Office.MsoBarPosition.msoBarTop, false, true);
                    // Add Button to Toolbar
                    tisCreateTaskToolBarButton = (Office.CommandBarButton)tisToolBar.Controls.Add(Office.MsoControlType.msoControlButton, missing, missing,1, true);
                    tisCreateTaskToolBarButton.Caption = "Create Task";

                    tisCreateTaskToolBarButton.Click += new Office._CommandBarButtonEvents_ClickEventHandler(tisCreateTaskToolBarButton_Click);
                    tisToolBar.Visible = true;
                }

            }
            catch (System.Exception exception1)
            {
                System.Exception thisException = exception1;
                Management.ShowException(thisException);
            }
        }
        private void CreateTask_Shutdown(object sender, System.EventArgs e)
        {
        }
        private void tisCreateTaskToolBarButton_Click(Office.CommandBarButton Ctrl, ref bool CancelDefault)
        {
            try
            {
                Cursor.Current = Cursors.WaitCursor;
                Microsoft.Office.Interop.Outlook.Selection sel;

                sel = Application.ActiveExplorer().Selection;

                if (sel != null & sel.Count > 0 & sel[1] is Microsoft.Office.Interop.Outlook.MailItem)
                    Create((Microsoft.Office.Interop.Outlook.MailItem)sel[1]);
            }
            catch (System.Exception exception1)
            {
                Cursor.Current = Cursors.Default;
                System.Exception thisException = exception1;
                Management.ShowException(thisException);
            }
        }
        #endregion

        #region Private Methods
        private void Create(Microsoft.Office.Interop.Outlook.MailItem mailItem)
        {
            String messageClass;
            DevExpress.XtraRichEdit.RichEditControl rtfControl = new DevExpress.XtraRichEdit.RichEditControl();
            TIS.DL.Internal.Task.TaskObject taskObj;
            Microsoft.Office.Interop.Outlook.Inspector inspector;
            try
            {
                messageClass = mailItem.MessageClass;


                if (messageClass == "IPM.Note")
                {
                    taskObj = new TIS.DL.Internal.Task.TaskObject();
                    ProcessEmailAddresses(taskObj, mailItem);
                    //Get Reporter
                    Microsoft.Office.Interop.Outlook.NameSpace outNamespace;
                    outNamespace = Application.GetNamespace("MAPI");
                    Microsoft.Office.Interop.Outlook.Recipient reporter = outNamespace.CurrentUser;
                    ProcessEmailAddressReporter(taskObj, reporter.Address);

                    taskObj.CreationDate = PROF_IT.Common.Convert.DateFunctions.DateToStrDate(System.DateTime.Now);
                    //RTF BODY
                    inspector = mailItem.GetInspector;
                    inspector.Activate();
                    Microsoft.Office.Interop.Word.Document document = (Microsoft.Office.Interop.Word.Document)inspector.WordEditor;
                    document.Select();
                    document.Application.Selection.Copy();
                    rtfControl.Paste();
                    taskObj.Description = rtfControl.RtfText;

                    //Subject
                    taskObj.Tag = mailItem.Subject;
                    switch (mailItem.Importance)
                    {
                        case Microsoft.Office.Interop.Outlook.OlImportance.olImportanceHigh:
                            taskObj.Priority = TIS.Framework.Common.Enumeration.Task.Priority.High;
                            break;
                        case Microsoft.Office.Interop.Outlook.OlImportance.olImportanceLow:
                            taskObj.Priority = TIS.Framework.Common.Enumeration.Task.Priority.Low;
                            break;
                        case Microsoft.Office.Interop.Outlook.OlImportance.olImportanceNormal:
                            taskObj.Priority = TIS.Framework.Common.Enumeration.Task.Priority.Medium;
                            break;
                    }
                    taskObj.Effort = TIS.Framework.Common.Enumeration.Task.Effort.Low;
                    taskObj.Status = TIS.Framework.Common.Enumeration.Task.Status.Open;

                    Task task = new Task(PROF_IT.Common.Enumerations.TypeForm.PropertyForm, taskObj);
                    task.ShowDialog();

                    //Close document, inspector
                    if (inspector != null) inspector.Close(Microsoft.Office.Interop.Outlook.OlInspectorClose.olDiscard);
                    document = null;
                    inspector = null;
                    mailItem = null;
                }
                else
                {
                    MessageBox.Show("Kan geen task creëren omdat het geselecteerde item geen e-mail is!");
                }
            }
            catch (System.Exception exception1)
            {
                System.Exception innerException = exception1;
                throw new System.Exception(MethodBase.GetCurrentMethod().Name, innerException);
            }
            finally
            {

                rtfControl.Dispose();
            }

        }
        private void ProcessEmailAddresses(TaskObject task, Microsoft.Office.Interop.Outlook.MailItem mail)
        {
            try
            {
                //Add Sender to task
                if (mail.SenderEmailAddress != null & mail.SenderEmailAddress != "")
                    CreateEmailAddress(task, mail.SenderEmailAddress);
                //Add recipients (Employees and Suppliers) to task
                foreach (Microsoft.Office.Interop.Outlook.Recipient recipient in mail.Recipients) 
                {
                    if (recipient.Address != "" & recipient.Address != null)
                    {
                        CreateEmailAddress(task, recipient.Address);
                    } 
                }
            }
            catch (System.Exception exception1)
            {
                System.Exception innerException = exception1;
                throw new System.Exception(MethodBase.GetCurrentMethod().Name, innerException);
            }
        }
        private void CreateEmailAddress(TaskObject task, string emailAddress)
        {
            TIS.BL.Internal.Employee blEmp = new TIS.BL.Internal.Employee();
            TIS.BL.Internal.Supplier blSup = new TIS.BL.Internal.Supplier();
            TIS.BL.Internal.Unknown blUnk = new TIS.BL.Internal.Unknown();
            TIS.DL.Internal.Employee.EmployeeObject employee;
            TIS.DL.Internal.Supplier.SupplierObject supplier;
            TIS.DL.Internal.Unknown.UnknownObject unknown;
            TIS.DL.Internal.TaskPeople.TaskPeopleObject taskPeople;

            try
            {
                if (PROF_IT.Common.Functions.Functions.IsEmailAddress(emailAddress))
                {
                    employee = blEmp.GetEmployeeByEmail(emailAddress);
                    if (employee != null)
                    {
                        taskPeople = ProcessEmployee(employee);
                        taskPeople.Task = task;
                        task.AssigneesEmployee.Add(taskPeople);
                    }

                    supplier = blSup.GetSupplierByEmail(emailAddress);
                    if (supplier != null)
                    {
                        taskPeople = ProcessSupplier(supplier);
                        taskPeople.Task = task;
                        task.AssigneesSupplier.Add(taskPeople);
                    }

                    if (supplier == null & employee == null)
                    {
                        unknown = blUnk.GetUnknownByEmail(emailAddress);
                        if (unknown != null)
                        {
                            taskPeople = ProcessUnknown(unknown);
                            taskPeople.Task = task;
                            task.AssigneesUnknown.Add(taskPeople);
                        }
                        else
                        {
                            //Create Unknown record
                            unknown = new UnknownObject();
                            unknown.Email = emailAddress;
                            unknown.State = PROF_IT.Common.Enumerations.ObjectState.Created;
                            blUnk.Save(unknown);
                            taskPeople = ProcessUnknown(unknown);
                            taskPeople.Task = task;
                            task.AssigneesUnknown.Add(taskPeople);
                        }
                    }
                }
            }
            catch (System.Exception exception1)
            {
                System.Exception innerException = exception1;
                throw new System.Exception(MethodBase.GetCurrentMethod().Name, innerException);
            }
           
        }
        private void ProcessEmailAddressReporter(TaskObject task, string emailAddress)
        {
            TIS.BL.Internal.Employee blEmp = new TIS.BL.Internal.Employee();
            TIS.DL.Internal.Employee.EmployeeObject employee;
            TIS.DL.Internal.TaskPeople.TaskPeopleObject taskPeople;

            try
            {
                //Voorlopig enkel werkbaar voor Thomas
                employee = blEmp.GetEmployeeByEmail("thomas@vuylsteketransport.be");
                if (employee == null)
                {
                    throw new System.Exception("E-mail adres van outlook account is niet gekend binnen TIS, gelieve de applicatiebeheerder te contacteren");
                }
                else
                {
                    taskPeople = ProcessEmployee(employee);
                    taskPeople.Task = task;
                    task.Reporters.Add(taskPeople);
                }
            }
            catch (System.Exception exception1)
            {
                System.Exception innerException = exception1;
                throw new System.Exception(MethodBase.GetCurrentMethod().Name, innerException);
            }
        }
        private TaskPeopleObject ProcessEmployee(EmployeeObject employee)
        {
            try
            {
                TaskPeopleObject taskPeople = new TaskPeopleObject();
                taskPeople.Assignee = true;
                taskPeople.Reporter = false;
                taskPeople.Employee = employee;
                taskPeople.State = PROF_IT.Common.Enumerations.ObjectState.Created;
                return taskPeople;
            }
            catch (System.Exception exception1)
            {
                System.Exception innerException = exception1;
                throw new System.Exception(MethodBase.GetCurrentMethod().Name, innerException);
            }
        }
        private TaskPeopleObject ProcessSupplier(SupplierObject supplier)
        {
            try
            {
                TaskPeopleObject taskPeople = new TaskPeopleObject();
                taskPeople.Assignee = true;
                taskPeople.Reporter = false;
                taskPeople.Supplier = supplier;
                taskPeople.State = PROF_IT.Common.Enumerations.ObjectState.Created;
                return taskPeople;
            }
            catch (System.Exception exception1)
            {
                System.Exception innerException = exception1;
                throw new System.Exception(MethodBase.GetCurrentMethod().Name, innerException);
            }
        }
        private TaskPeopleObject ProcessUnknown(UnknownObject unknown)
        {
            try
            {
                TaskPeopleObject taskPeople = new TaskPeopleObject();
                taskPeople.Assignee = true;
                taskPeople.Reporter = false;
                taskPeople.Unknown = unknown;
                taskPeople.State = PROF_IT.Common.Enumerations.ObjectState.Created;
                return taskPeople;
            }
            catch (System.Exception exception1)
            {
                System.Exception innerException = exception1;
                throw new System.Exception(MethodBase.GetCurrentMethod().Name, innerException);
            }
        }

        #endregion


        #region VSTO generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InternalStartup()
        {
            this.Startup += new System.EventHandler(CreateTask_Startup);
            this.Shutdown += new System.EventHandler(CreateTask_Shutdown);
        }
        
        #endregion
    }
}