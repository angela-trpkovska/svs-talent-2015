using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App1.Common
{
    /// <summary>
    /// enumeration for transaction status
    /// </summary>
    /// 
    public enum TransactionStatus
    {
        InProcess, Completed, CompletedWithWarning, Failed
    }
}
