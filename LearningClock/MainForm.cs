using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;

namespace LearningClock
{
    public partial class LearningClock : DevExpress.XtraEditors.XtraForm
    {
        ExcelHelper excelHelper = new ExcelHelper();
        //时钟模式定时器
        private System.Timers.Timer globalTimer;
        private List<ElapsedEventHandler> globalTimerMethods;
        //任务列表
        private List<LearningTask> learningTaskList = null;
        //当前任务
        public EventHandler<LearningTask> evCurLearningTaskChanged;
        private LearningTask curLearningTask = null;
        public LearningTask CurLearningTask
        {
            get => this.curLearningTask;
            set
            {
                if (this.curLearningTask != value)
                {
                    this.curLearningTask = value;
                    evCurLearningTaskChanged?.Invoke(this, value);
                }
            }
        }

        public LearningClock()
        {
            InitializeComponent();
            init();
        }

        #region 初始化
        /// <summary>
        /// 初始化函数
        /// </summary>
        public void init()
        {
            //new一些东西，设置初始参数
            learningTaskList = new List<LearningTask>();
            initGlobalTimer(1000);
            this.gridControl_taskList.DataSource = this.learningTaskList;
            this.evCurLearningTaskChanged += OnCurrentLearningTaskChanged;

            //从TaskList文件初始化
            excelHelper.PathLearningTaskListFile = @"C:\Users\Administrator\Desktop\taskList.xlsx";
            int ret = excelHelper.ReadTaskList(ref learningTaskList);
            if(ret == 0)
            {
                excelHelper.WriteTaskList(ref learningTaskList);
            }
            else if(ret == 1)
            {
                this.gridControl_taskList.RefreshDataSource();
            }

            initCurTaskEvents();
            initShow();
        }

        /// <summary>
        /// 初始界面显示
        /// </summary>
        private void initShow()
        {
            if (CurLearningTask is null || learningTaskList is null)
            {
                this.labelControl_currentTask.Text = "无学习任务";
                this.labelControl_currentMode.Text = "模式：时钟";
                this.labelControl_setTime.Text = "计时：0h";
                this.panelControl_setTime.Visible = false;
                this.panelControl_taskList.Visible = false;
            }
            else
            {
                this.labelControl_currentTask.Text = this.CurLearningTask?.TaskDescription;
                this.labelControl_currentMode.Text = this.CurLearningTask?.TaskMode.ToString();
                this.labelControl_setTime.Text = "计时：0h";
                this.panelControl_setTime.Visible = false;
                this.panelControl_taskList.Visible = false;
            }
        }

        /// <summary>
        /// 给当前任务进行事件绑定
        /// </summary>
        private void initCurTaskEvents()
        {
            if (this.CurLearningTask is null)
            {
                return;
            }
            
            if(this.CurLearningTask.dlgTaskModeChanged !=null)
            {
                this.CurLearningTask.dlgTaskModeChanged += OnCurrentModeChanged;

            }
            if (this.CurLearningTask.dlgTaskStatusChanged != null)
            {
                this.CurLearningTask.dlgTaskStatusChanged += OnCurrentLearningTaskStatusChanged;

            }
            if (this.CurLearningTask.dlgTaskStatusChanged != null)
            {
                this.CurLearningTask.dlgCountDownInitValChanged += OnCountDownInitValChanged;
            }
        }       

        #endregion

        /// <summary>
        /// 全局时钟
        /// </summary>
        private void initGlobalTimer(int intervalMill)        
        {
            globalTimer = new System.Timers.Timer();
            globalTimerMethods = new List<ElapsedEventHandler>();
            globalTimer.Enabled = true;
            globalTimer.Interval = intervalMill;
            globalTimer.AutoReset = true;
            globalTimer.Elapsed += OnShowCurTime;
            globalTimerMethods.Add(OnShowCurTime);
        }

        #region 三种显示
        /// <summary>
        /// 显示当前时间
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OnShowCurTime(object sender, ElapsedEventArgs e)
        {
            this.dGauge1.Text = DateTime.Now.ToString("T");
        }

        /// <summary>
        /// 显示计时
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OnShowCountDown(object sender, ElapsedEventArgs e)
        {
            if(this.CurLearningTask is null)
            {
                return;
            }

            this.CurLearningTask.TotalLearningTime++;
            this.dGauge1.Text = (--this.CurLearningTask.RemainingTime).ToString();
        }

        /// <summary>
        /// 显示累计
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OnShowTotalLearningTime(object sender, ElapsedEventArgs e)
        {
            if(this.CurLearningTask is null)
            {
                return;
            }

            this.dGauge1.Text = (this.CurLearningTask.TotalLearningTime++).ToString();
            this.CurLearningTask.RemainingTime--;
        }

        #endregion

        #region 当前任务列表
        //切换当前任务
        private void OnCurrentLearningTaskChanged(object sender, LearningTask e)
        {
            if (this.CurLearningTask is null)
            {
                initShow();
                this.panelControl_taskList.Visible = true;
                return;
            }

            
            //给更换的当前任务初始化事件
            initCurTaskEvents();            

            //修改当前任务label
            this.labelControl_currentTask.Text = (this.CurLearningTask is null) ? "当前无任务" : this.CurLearningTask.TaskDescription;
            //修改当前模式label
            //修改计时label
            if (this.CurLearningTask is null)
            {
                this.labelControl_currentMode.Text = "模式：时钟";
                this.labelControl_setTime.Text = "计时：0";
            }
            else
            {
                if (this.CurLearningTask.TaskMode == 0)
                {
                    this.labelControl_currentMode.Text = "模式：时钟";
                    this.labelControl_setTime.Text = "计时：0";
                }
                else if(this.CurLearningTask.TaskMode == 1)
                {
                    this.labelControl_currentMode.Text = "模式：计时";
                    this.labelControl_setTime.Text = $"计时：{(this.CurLearningTask.CountDownInitVal / 3600).ToString()}h";

                }
                else
                {
                    this.labelControl_currentMode.Text = "模式：累计";
                    this.labelControl_setTime.Text = $"计时：{(this.CurLearningTask.CountDownInitVal / 3600).ToString()}h";

                }

            }
        }

        private void OnCurrentLearningTaskStatusChanged()
        {
            if((LearningTask.EtTaskStatus)CurLearningTask?.TaskStatus == LearningTask.EtTaskStatus.Learning)
            {
                this.labelControl_currentTask.Text = this.CurLearningTask?.TaskDescription;
                this.labelControl_currentTask.BackColor = Color.FromArgb(148, 165, 141);
            }
            else if((LearningTask.EtTaskStatus)CurLearningTask?.TaskStatus == LearningTask.EtTaskStatus.Pause)
            {
                this.labelControl_currentTask.Text = "Pause!";
                this.labelControl_currentTask.BackColor = Color.FromArgb(251, 210, 106);

            }
            else
            {
                //在ItemCustomize添加删除线
            }
        }

        /// <summary>
        /// 绑定Space暂停
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmPause_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                labelControl_currentTask_Click(sender, e);
            }
        }

        //切换Learning/Pause
        private void labelControl_currentTask_Click(object sender, EventArgs e)
        {
            if (this.CurLearningTask is null || this.CurLearningTask.TaskStatus == 2)
            {
                return;
            }

            if (this.CurLearningTask.TaskStatus == 0)
            {
                this.CurLearningTask.TaskStatus = 1;
            }
            else
            {
                this.CurLearningTask.TaskStatus = 0;
            }
        }

        //打开任务列表
        private void labelControl_currentTask_DoubleClick(object sender, EventArgs e)
        {
            this.panelControl_taskList.Visible = !this.panelControl_taskList.Visible;
        }

        //遍历每个条目并设置
        private void tileView_taskList_ItemCustomize(object sender, DevExpress.XtraGrid.Views.Tile.TileViewItemCustomizeEventArgs e)
        {
            if (e.Item == null || e.Item.Elements.Count == 0)
                return;

            if ((LearningTask.EtTaskStatus)tileView_taskList.GetRowCellValue(e.RowHandle, "TaskStatus") == LearningTask.EtTaskStatus.Finished)
            {
                e.Item.AppearanceItem.Normal.Font = new Font("微软雅黑", 8, FontStyle.Strikeout);
                e.Item.AppearanceItem.Focused.Font = new Font("微软雅黑", 8, FontStyle.Strikeout);
            }
        }

        //添加任务
        private void simpleButton_addTask_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(this.textEdit_inputTaskDescription.Text))
            {
                return;
            }

            //创建任务
            LearningTask learningTask = new LearningTask();
            learningTask.TaskId = learningTaskList.Count;
            learningTask.CreateTime = DateTime.Now;
            learningTask.TaskMode = (int)LearningTask.EtTaskMode.modeClock;
            learningTask.TaskStatus = (int)LearningTask.EtTaskStatus.Learning;
            learningTask.TaskDescription = this.textEdit_inputTaskDescription.Text;
            learningTask.CountDownInitVal = 3600 * Convert.ToInt32(this.labelControl_setTime.Text.Substring(3, 1));
            learningTask.RemainingTime = learningTask.CountDownInitVal;
            learningTask.TotalLearningTime = 0;
            learningTaskList.Add(learningTask);
            this.gridControl_taskList.RefreshDataSource();  //将DataSource的变化刷新到显示上
            this.textEdit_inputTaskDescription.Text = "";
            this.textEdit_inputTaskDescription.Focus();
            //新任务绑定事件
            learningTask.dlgTaskModeChanged += OnCurrentModeChanged;
            learningTask.dlgTaskStatusChanged += OnCurrentLearningTaskStatusChanged;
            learningTask.dlgCountDownInitValChanged += OnCountDownInitValChanged;
            //更新文件
            excelHelper.WriteTaskList(ref this.learningTaskList);
        }

        //删除选中任务
        private void simpleButton_delTask_Click(object sender, EventArgs e)
        {
            if (learningTaskList.Count == 0)
            {
                return;
            }

            int rowHandle = this.tileView_taskList.FocusedRowHandle;
            int delTaskId = Convert.ToInt32(this.tileView_taskList.GetRowCellValue(rowHandle, "TaskId"));
            if(CurLearningTask?.TaskId == delTaskId)
            {
                CurLearningTask = null;
            }
            learningTaskList.RemoveAll(item => item.TaskId == delTaskId);

            //将经过增删的现有task重新从0编排id
            for (int i = 0; i < learningTaskList.Count; i++)
            {
                learningTaskList[i].TaskId = i;
            }
            this.gridControl_taskList.RefreshDataSource();

            excelHelper.WriteTaskList(ref this.learningTaskList);
        }

        //修改选中任务Description
        private void simpleButton_modifyTask_Click(object sender, EventArgs e)
        {
            if (learningTaskList.Count == 0 || string.IsNullOrEmpty(this.textEdit_inputTaskDescription.Text))
            {
                return;
            }

            this.tileView_taskList.SetFocusedRowCellValue("TaskDescription", this.textEdit_inputTaskDescription.Text);
            this.textEdit_inputTaskDescription.Text = "";

            excelHelper.WriteTaskList(ref this.learningTaskList);
        }

        //清空任务列表
        private void simpleButton_clearTask_Click(object sender, EventArgs e)
        {
            learningTaskList.Clear();
            this.gridControl_taskList.RefreshDataSource();
            excelHelper.WriteTaskList(ref this.learningTaskList);
        }

        //双击选中，更改当前任务
        private void tileView_taskList_DoubleClick(object sender, EventArgs e)
        {
            if (learningTaskList.Count == 0)
            {
                return;
            }
            int rowHandle = this.tileView_taskList.FocusedRowHandle;
            int curSelTaskId = Convert.ToInt32(this.tileView_taskList.GetRowCellValue(rowHandle, "TaskId"));
            CurLearningTask = learningTaskList.FindLast(item => item.TaskId == curSelTaskId);
        }


        #endregion

        #region 当前模式
        //修改当前任务的模式
        //curTask的模式发生改变
        private void OnCurrentModeChanged()
        {
            if (CurLearningTask is null)
            {
                return;
            }

            //CommonFunctions.clear_event<ElapsedEventHandler>(globalTimer.Elapsed);
            foreach(var evt in globalTimerMethods)
            {
                globalTimer.Elapsed -= evt;
            }
            globalTimerMethods.Clear();

            if ((LearningTask.EtTaskMode)this.CurLearningTask.TaskMode == LearningTask.EtTaskMode.modeClock)
            {
                this.labelControl_currentMode.Text = "模式：时钟";
                this.labelControl_currentTask.Text = "";
                this.labelControl_setTime.Text = "计时：0";
                this.panelControl_setTime.Visible = false;
                globalTimer.Elapsed += OnShowCurTime;
                globalTimerMethods.Add(OnShowCurTime);
            }
            else if ((LearningTask.EtTaskMode)this.CurLearningTask?.TaskMode == LearningTask.EtTaskMode.modeCountDown)
            {
                this.labelControl_currentMode.Text = "模式：计时";
                this.labelControl_currentTask.Text = this.CurLearningTask?.TaskDescription;
                this.labelControl_setTime.Text = $"计时：{this.CurLearningTask?.CountDownInitVal/3600}h";

                globalTimer.Elapsed += OnShowCountDown;
                globalTimerMethods.Add(OnShowCountDown);
            }
            else if ((LearningTask.EtTaskMode)this.CurLearningTask?.TaskMode == LearningTask.EtTaskMode.modeTotalTime)
            {
                this.labelControl_currentMode.Text = "模式：累计";
                this.labelControl_currentTask.Text = this.CurLearningTask?.TaskDescription;
                this.labelControl_setTime.Text = $"计时：{this.CurLearningTask?.CountDownInitVal / 3600}h";

                globalTimer.Elapsed += OnShowTotalLearningTime;
                globalTimerMethods.Add(OnShowTotalLearningTime);
            }
        }

        private void labelControl_currentMode_Click(object sender, EventArgs e)
        {
            if(this.CurLearningTask is null)
            {
                return;
            }

            if(this.CurLearningTask.TaskMode == 0)
            {
                this.CurLearningTask.TaskMode = 1;
            }
            else if(this.CurLearningTask.TaskMode == 1)
            {
                this.CurLearningTask.TaskMode = 2;
            }
            else
            {
                this.CurLearningTask.TaskMode = 0;
            }
        }


        #endregion

        #region 计时设置
        //设定倒计时改变
        private void OnCountDownInitValChanged()
        {
            if(this.CurLearningTask is null)
            {
                return;
            }

            this.labelControl_setTime.Text = $"计时：{this.CurLearningTask?.CountDownInitVal / 3600}h";
            this.CurLearningTask.TaskStatus = 0;
            this.CurLearningTask.TaskMode = 1;
        }

        private void labelControl_setTime_Click(object sender, EventArgs e)
        {
            if (CurLearningTask is null)
            {
                return;
            }
            if (CurLearningTask?.TaskStatus == 0 || CurLearningTask?.TaskStatus == 2)
            {
                return;
            }
            if (CurLearningTask?.TaskMode == 0)
            {
                return;
            }

            this.panelControl_setTime.Visible = !this.panelControl_setTime.Visible;
        }

        private int countDownSec = 0;
        private void labelControl_setTime_DoubleClick(object sender, EventArgs e)
        {
            if (countDownSec != this.CurLearningTask?.CountDownInitVal)
            {
                this.CurLearningTask.CountDownInitVal = countDownSec;
            }
        }

        private void toggleSwitchs_Toggled(object sender, EventArgs e)
        {
            countDownSec = 0;

            if (this.toggleSwitch_15m.IsOn)
            {
                countDownSec += 900;
            }
            if (this.toggleSwitch_30m.IsOn)
            {
                countDownSec += 1800;
            }
            if (this.toggleSwitch_1h.IsOn)
            {
                countDownSec += 3600;
            }
            if (this.toggleSwitch_2h.IsOn)
            {
                countDownSec += 7200;
            }
            if (this.toggleSwitch_3h.IsOn)
            {
                countDownSec += 10800;
            }
            if (this.toggleSwitch_4h.IsOn)
            {
                countDownSec += 14400;
            }
        }


        #endregion

        
    }
}