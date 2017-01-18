using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForLan.Repository.Abstract
{
    interface IDictionaryRepository
    {
        void Add(string polishWord, string foreignWord);

    }
}
