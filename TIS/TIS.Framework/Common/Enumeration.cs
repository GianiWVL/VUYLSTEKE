using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TIS.Framework.Common
{
    public class Enumeration
    {
        public class Document
        {
            public enum DocumentType
            {
                Link,
                Application,
                Document
            }
        }
        public Enumeration()
        {
        }

        public class EnumViews
        {
            public EnumViews()
            {
            }   

            public enum Application
            {
                User
            }

            public enum Document
            {
                Cleaning,
                Peages,
                License,
                Tunnels,
                Ferries,
                Insurence,
                DeutscheMaut,
                OnBoardComputer
            }

            public enum Main
            {
                Task,
                Customer,
                Costing,
                Employee,
                Vehicle,
                Fuel,
                Material,
                MaterialCategory,
                Popup,
                Document,
                Supplier,
                BoardComputer,
                Planning
            }
        }

        public class Reports
        {
            public enum TurnOver
            {
                TurnOverByCustomer,
                TurnOverByDay,
                TurnOverByMonth,
                TurnOverByYear
            }
        }

        public class Task
        {
            public enum Status
            {
                Open,
                Progress,
                Resolved
            }

            public enum Priority
            {
                Low,
                Medium,
                High
            }

            public enum Effort
            {
                Low,
                Medium,
                High
            }
        }

        public class Frequency
        {
            public enum TimeFrequency
            {
                Daily,
                Weekly,
                TwoWeekly,
                Monthly
            }
        }

        public class Fuel
        {
            public enum FuelType
            {
                Unknown,
                Diesel,
                Diesel_Rood,
                Benzine95
            }

            public enum Location
            {
                Vuylsteke_Tournai,
                Vuylsteke_Polen,
                Vuylsteke_Genk,
                Vuylsteke_Roemenië,
                Vuylsteke_Heestert
            }
        }

        public class Material
        {
            public enum Type
            {
                Boordcomputer,
                IT
            }
        }

    }
}
