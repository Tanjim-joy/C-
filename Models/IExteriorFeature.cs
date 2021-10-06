using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Imran_1264705.Models
{
    public interface IExteriorFeature
    {
        void AddFeature(string[] feature);
        string GetFeature();
    }
}
