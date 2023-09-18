using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Data;
using NPOI;
using NPOI.SS.UserModel;
using NPOI.XSSF.UserModel;
using NPOI.HSSF.UserModel;
using System.Diagnostics;

namespace LearningClock
{
    public class ExcelHelper
    {
        //文件路径
        private string pathLearningTaskListFile;
        public string PathLearningTaskListFile { get => pathLearningTaskListFile; set => pathLearningTaskListFile = value; }

        public ExcelHelper()
        {
        }

        //读取任务列表Excel文件
        public int ReadTaskList(ref List<LearningTask> learningTasks)
        {
            try
            {
                if (learningTasks is null || String.IsNullOrEmpty(pathLearningTaskListFile))
                {
                    return -1;
                }

                if (!File.Exists(pathLearningTaskListFile))
                {
                    return 0;
                }

                FileStream fs = new FileStream(pathLearningTaskListFile, FileMode.Open);
                XSSFWorkbook workbook = new XSSFWorkbook(fs);

                ISheet isheet = null;
                isheet = workbook.GetSheetAt(0);

                for(int i = 1; i < isheet.LastRowNum + 1 ; i++)
                {
                    IRow row = isheet.GetRow(i);
                    ICell cell = null;
                    LearningTask learningTask = new LearningTask();
                    cell = row.GetCell(0);
                    learningTask.TaskId = Convert.ToInt32(GetCellValue(cell));
                    cell = row.GetCell(1);
                    learningTask.CreateTime = Convert.ToDateTime(GetCellValue(cell));
                    cell = row.GetCell(2);
                    learningTask.TaskMode = Convert.ToInt32(GetCellValue(cell));
                    cell = row.GetCell(3);
                    learningTask.TaskStatus = Convert.ToInt32(GetCellValue(cell));
                    cell = row.GetCell(4);
                    learningTask.TaskDescription = GetCellValue(cell).ToString();
                    cell = row.GetCell(5);
                    learningTask.CountDownInitVal = Convert.ToInt32(GetCellValue(cell));
                    cell = row.GetCell(6);
                    learningTask.RemainingTime = Convert.ToInt32(GetCellValue(cell));
                    cell = row.GetCell(7);
                    learningTask.TotalLearningTime = Convert.ToInt32(GetCellValue(cell));

                    learningTasks.Add(learningTask);
                }

                fs.Close();
                workbook.Close();
                return 1;
            }
            catch(Exception ex)
            {
                return -1;
            }

        }

        //将任务列表写入Excel文件
        public int WriteTaskList(ref List<LearningTask> learningTasks)
        {
            try
            {
                if (learningTasks is null || String.IsNullOrEmpty(pathLearningTaskListFile))
                {
                    return -1;
                }

                if (File.Exists(PathLearningTaskListFile))
                {
                    File.Delete(pathLearningTaskListFile);   
                }

                FileStream fs = new FileStream(pathLearningTaskListFile, FileMode.Create);
                XSSFWorkbook workbook = new XSSFWorkbook();   //创建表对象wb
                ISheet isheet = null;
                isheet = workbook.CreateSheet("TaskListPage1");  //在wb中创建sheet1
                IRow row = null;
                ICell cell = null;
                //加表头
                row = isheet.CreateRow(0);
                cell = row.CreateCell(0);
                cell.SetCellValue("TaskId");
                cell = row.CreateCell(1);
                cell.SetCellValue("CreateTime");
                cell = row.CreateCell(2);
                cell.SetCellValue("CurTaskMode");
                cell = row.CreateCell(3);
                cell.SetCellValue("CurTaskStatus");
                cell = row.CreateCell(4);
                cell.SetCellValue("TaskDescription");
                cell = row.CreateCell(5);
                cell.SetCellValue("CountDownInitVal");
                cell = row.CreateCell(6);
                cell.SetCellValue("RemainingTime");
                cell = row.CreateCell(7);
                cell.SetCellValue("TotalLearningTime");

                int countTasks = learningTasks.Count;

                for (int i = 0; i < countTasks; i++)
                {
                    row = isheet.CreateRow(i + 1);
                    cell = row.CreateCell(0);
                    cell.SetCellValue(learningTasks[i].TaskId);
                    cell = row.CreateCell(1);
                    cell.SetCellValue(learningTasks[i].CreateTime.ToString());
                    cell = row.CreateCell(2);
                    cell.SetCellValue(learningTasks[i].TaskMode);
                    cell = row.CreateCell(3);
                    cell.SetCellValue(learningTasks[i].TaskStatus);
                    cell = row.CreateCell(4);
                    cell.SetCellValue(learningTasks[i].TaskDescription);
                    cell = row.CreateCell(5);
                    cell.SetCellValue(learningTasks[i].CountDownInitVal);
                    cell = row.CreateCell(6);
                    cell.SetCellValue(learningTasks[i].RemainingTime);
                    cell = row.CreateCell(7);
                    cell.SetCellValue(learningTasks[i].TotalLearningTime);
                }
                workbook.Write(fs);
                fs.Close();
                workbook.Close();
                return 1;
            }
            catch(Exception ex)
            {
                return -1;
            }
        }

        //获取单元格数值
        public static object GetCellValue(ICell cell)
        {
            object value = null;
            try
            {
                if (cell.CellType != CellType.Blank)
                {
                    switch (cell.CellType)
                    {
                        case CellType.Numeric:
                            //判断单元格内数据是否是DateTime
                            if (DateUtil.IsCellDateFormatted(cell))
                            {
                                value = cell.DateCellValue;	//若是日期格式，则用DateCellValue获取DateTime
                            }
                            else
                            {
                                // Numeric type
                                value = cell.NumericCellValue;
                            }
                            break;
                        case CellType.Boolean:
                            // Boolean type
                            value = cell.BooleanCellValue;
                            break;
                        case CellType.Formula:
                            value = cell.CellFormula;
                            break;
                        default:
                            // String type
                            value = cell.StringCellValue;
                            break;
                    }
                }
            }
            catch (Exception)
            {
                value = "";
            }

            return value;
        }

    }
}
