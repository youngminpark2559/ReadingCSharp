using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//c Add a interface IPointy which defines one unimplemented method GetNumberOfPoints().

namespace CustomInterface
{
    // This interface defines the behavior of "having points."
    public interface IPointy
    {
        // Implicitly public and abstract.
        byte GetNumberOfPoints();
    }
}
