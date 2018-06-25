using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoveBrickMan
{
    class ControlProperty
    {
        public static void Form1CP (Dialog f1)
        {
            f1.label1.Text = "所属类别:";
            f1.label2.Text = "金    额:";
            f1.label3.Text = "备    注:";
            f1.BtConfirm.Text = "确定";
            f1.BtReset.Text = "重置";
            f1.BtCancel.Text = "关闭";
            f1.BtAdd.Text = "新增";
        }
    }
}
