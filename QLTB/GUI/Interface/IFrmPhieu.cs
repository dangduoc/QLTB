using QLTB.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLTB.GUI
{
    public interface IFrmPhieu
    {
        void AddToGrid(List<BaseThietBiGridDisplayModel> list);
    }
}
