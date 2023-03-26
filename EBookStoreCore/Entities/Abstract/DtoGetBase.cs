using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static EBookStoreCore.Utilities.ClassEnum;

namespace EBookStoreCore.Entities.Abstract
{
    public abstract class DtoGetBase
    {

        public virtual ResultStatus ResultStatus { get; set; }
    }
}
