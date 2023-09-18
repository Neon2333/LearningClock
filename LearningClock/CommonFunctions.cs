using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningClock
{
    public class CommonFunctions
    {
        /// <summary>
        /// 移除所有的事件绑定
        /// </summary>
        /// <param name="clearEvent"></param>
        public static void clear_event<T>(ref T clearEvent) where T : Delegate
        {
            Delegate[] dels = (clearEvent as Delegate).GetInvocationList(); //event是特殊的delegate，所以类型还是delegate
            foreach (Delegate d in dels)
            {
                Delegate.RemoveAll(clearEvent, d);
                //得到方法名
                //object delObj = d.GetType().GetProperty("Method").GetValue(d, null);
                //string funcName = (string)delObj.GetType().GetProperty("Name").GetValue(delObj, null);
            }
        }
    }
}
