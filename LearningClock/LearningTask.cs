using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningClock
{
    public class LearningTask : EventArgs
    {
        //id
        private int iTaskId;
        public int TaskId { get => iTaskId; set => iTaskId = value; }

        //任务创建时间
        private DateTime dtCreateTime;
        public DateTime CreateTime { get => dtCreateTime; set => dtCreateTime = value; }
       
        //任务状态
        public Action dlgTaskStatusChanged;
        public enum EtTaskStatus { Learning = 0, Pause, Finished};
        private int eTaskStatus = (int)EtTaskStatus.Pause;
        public int TaskStatus
        {
            get => this.eTaskStatus;
            set
            {
                if (this.eTaskStatus != value)
                {
                    this.eTaskStatus = value;
                    dlgTaskStatusChanged?.Invoke();
                }

            }
        }

        //任务模式：时钟、倒计时、累计时间
        public Action dlgTaskModeChanged;
        public enum EtTaskMode { modeClock = 0, modeCountDown, modeTotalTime };
        private int iTaskMode = (int)EtTaskMode.modeClock;
        public int TaskMode
        {
            get => this.iTaskMode;
            set
            {
                if (this.iTaskMode != value)
                {
                    this.iTaskMode = value;
                    dlgTaskModeChanged?.Invoke();
                }
            }
        }

        //任务描述
        public Action dlgTaskDescriptionChanged;
        private string sTaskDescription;
        public string TaskDescription
        {
            get => this.sTaskDescription;
            set
            {
                if (this.sTaskDescription != value)
                {
                    this.sTaskDescription = value;
                    dlgTaskDescriptionChanged?.Invoke();
                }
            }
        }

        //设置倒计时时间(s)
        public Action dlgCountDownInitValChanged;
        private int iCountDownInitVal = 0;
        public int CountDownInitVal
        {
            get => this.iCountDownInitVal;
            set
            {
                if(iCountDownInitVal != value)
                {
                    this.iCountDownInitVal = value;
                    dlgCountDownInitValChanged?.Invoke();
                }
            }
        }

        //当前剩余倒计时(s)
        public Action dlgRemainingTimeChanged;
        private int iRemainingTime = 0;
        public int RemainingTime
        {
            get => this.iRemainingTime;
            set
            {
                if (iRemainingTime != value)
                {
                    this.iRemainingTime = value;
                    dlgRemainingTimeChanged?.Invoke();
                }
            }
        }

        //累计学习时间(s)
        public Action dlgTotalLearningTimeChanged;
        private Int64 iTotalLearningTime = 0;
        public Int64 TotalLearningTime
        {
            get => this.iTotalLearningTime;
            set
            {
                if (iTotalLearningTime != value)
                {
                    this.iTotalLearningTime = value;
                    dlgTotalLearningTimeChanged?.Invoke();
                }
            }
        }

    }
}
