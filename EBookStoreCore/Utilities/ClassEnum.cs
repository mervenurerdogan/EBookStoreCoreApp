﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EBookStoreCore.Utilities
{
    public class ClassEnum
    {
        public enum Status
        {
            New = 1,
            Old = 2
        }

        public enum Condition
        {
            VeryBad = 1,
            Bad = 2,
            Normal = 3,
            Good = 4,
            VeryGood = 5
        }

        public enum Payment
        {
            EFT = 1,
            CreditCard = 2,
            Transfer = 3
        }

        public enum Roles
        {
            User = 1,
            Saller = 2,
            Admin = 3
        }

        public enum ResultStatus
        {
            Success=0,
            Error=1,//ResultStatus.Error
            Warning=2, 
            Info = 3


        }


    }
}
