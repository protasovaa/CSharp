using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RocketModel
{
    // интерфейс страховой
    interface IIncurance
    {
        // список случаев, за которые выплачивается компенсация
        List<int> HealDiseaseIndexes { get; }
    }
}
