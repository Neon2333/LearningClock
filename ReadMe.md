DevExpress添加右键菜单：https://blog.csdn.net/xiaoyu812289718/article/details/17612627

[winform click点击事件 左键 OR 右键](https://www.cnblogs.com/wcl2017/p/9145611.html)

1. 时钟模式

2. 学习时：倒计时模式、累计时长模式

3. class task，Dictionary<taskId, task>

   taskId:0~999

   ```c#
   class Task
   {
       public string taskDescription;
       public DateTime 设置倒计时时间;
       public DateTime 当前剩余倒计时;
       public DateTime 累计学习时间;
   }
   ```

## 按钮

当前学习：显示当前task

状态：Learning/Pause

模式：自然时钟、倒计时、累计时长。（默认自然时钟）

倒计时设定：下拉菜单，toggle按钮，滑动自由设定时间

## 逻辑

**当前学习：**

当前无学习任务时等价自然时钟模式。

单击出现下拉菜单。

双击某一栏任务，切换为当前任务，从下拉菜单删除，放置当前学习label显示。

倒计时、累计时长模式下的Learning状态时，无法切换任务；Pause时可修改任务。

添加、删除、修改任务内容、清空列表。

当前任务执行完，将文字~~添加删除线~~。

**状态：**

在倒计时、累计时长模式下，可通过单击/Enter按键，切换Learning/Pause，Pause时计时暂停，Learning时计时恢复。

**模式：**

无学习任务时，自然时钟模式。

单击，切换模式。

倒计时、累计时长模式下的Learning状态时，无法切换到时钟模式，只能在倒计时/累计切换。

Pause时可在三种模式下切换。

**倒计时设定：**

单击后，出现下拉菜单，倒计时清零。

toggle按钮预置几个时间（15m/30m/1h/2h/4h)，底部放上滑轮自由设定时间。再单击，预置时间设定，按钮显示预置时间，LED显示。状态为Pause。手动切换到Learning后开始计时。

**学习任务倒计时结束：**

**弹窗：**任务学完、还没学完。

**任务学完：**

当前学习显示当前无任务

任务被删除线

模式切换到自然时钟

**还没学完：**

进入倒计时设定，下拉菜单弹出。