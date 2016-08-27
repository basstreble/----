using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
namespace auto_distribution
{

    public partial class Tool : Form
    {
        //工人使用工具的习惯
        static List<Stuff_using_tool> stuffUsingTool = new List<Stuff_using_tool>();
        //待使用的工具
        static List<int> toolWaiting = new List<int>();
        //目前正在工作的工人和工具的组合
        static List<Stuff_using_tool> stuffAndToolOnWork = new List<Stuff_using_tool>();
        public Tool()
        {
            InitializeComponent();
            //假设工人使用工具习惯如下
            for (int i = 0; i < 200; i++)
            {
                var temp = new Stuff_using_tool();
                temp.stuff = i;
                temp.using_tool = i;
                stuffUsingTool.Add(temp);
            }
            for (int i = 200; i < 400; i++)
            {
                var temp = new Stuff_using_tool();
                temp.stuff = i;
                temp.using_tool = i - 200;
                stuffUsingTool.Add(temp);
            }
            for (int i = 400; i < 600; i++)
            {
                var temp = new Stuff_using_tool();
                temp.stuff = i;
                temp.using_tool = i - 400;
                stuffUsingTool.Add(temp);
            }
            for (int i = 600; i < 700; i++)
            {
                var temp = new Stuff_using_tool();
                temp.stuff = i;
                temp.using_tool = i - 600;
                stuffUsingTool.Add(temp);
            }
            for (int i = 0; i < 200; i++)
            {
                toolWaiting.Add(i);
            }
        }

        //输入员工号获取工具
        private void gettool_Click(object sender, EventArgs e)
        {
            var stuffGet = PublicMethods.transferToInt(StuffNo.Text);
            if (stuffGet != -1)
            {
                var toolGet = stuffUsingTool.First(p => p.stuff == PublicMethods.transferToInt(StuffNo.Text));
                if (stuffAndToolOnWork.Where(p => p.stuff == toolGet.stuff).Any())
                {
                    MessageBox.Show("您已经处于工作状态！");
                    return;
                }
                if (!toolWaiting.Any())
                {
                    var rd = PublicMethods.getRandomNumber(0, 199);
                    var stuffAndTool = stuffAndToolOnWork[rd];
                    stuffAndToolOnWork.RemoveAt(rd);
                    toolWaiting.Remove(stuffAndTool.using_tool);
                    MessageBox.Show(stuffAndTool.stuff + "号工人因满员而强制下班！");

                }
                if (toolWaiting.Contains(toolGet.using_tool))
                {
                    MessageBox.Show(toolGet.using_tool + "号工具给你使用");
                    toolWaiting.Remove(toolGet.using_tool);
                    var temp = new Stuff_using_tool();
                    temp.stuff = stuffGet;
                    temp.using_tool = toolGet.using_tool;
                    stuffAndToolOnWork.Add(temp);
                }
                else
                {
                    //工人熟悉工具在使用，就分配一个默认使用它的人数最少的工具，并且将此工人的默认使用工具改成此工具             
                    var toolUseList = stuffUsingTool.GroupBy(p => p.using_tool).OrderBy(p => p.Count()).Select(p => new { tool = p.Key, useNumber = p.Count() }).ToList();
                    for (int i = 0; i < 200; i++)
                    {
                        //如果此工具空闲，则交付工人使用
                        if (toolWaiting.Contains(toolUseList[i].tool))
                        {
                            var temp = new Stuff_using_tool();
                            temp.stuff = stuffGet;
                            temp.using_tool = toolUseList[i].tool;
                            stuffAndToolOnWork.Add(temp);//添加工作中的工人工具编号
                            toolWaiting.Remove(toolUseList[i].tool);//移除该空闲工具
                            stuffUsingTool.Remove(toolGet);//移除旧的工人熟练使用的工具号
                            //添加新的工人熟练使用的工具号
                            stuffUsingTool.Insert(stuffGet, new Stuff_using_tool { stuff = stuffGet, using_tool = toolUseList[i].tool });
                            MessageBox.Show(toolUseList[i].tool + "号工具给你临时使用，请熟悉此工具");
                            break;
                        }
                    }

                }
            }
            else
                MessageBox.Show("员工号不正确！");
        }
        //
        private void returntool_Click(object sender, EventArgs e)
        {
            var toolGet = PublicMethods.transferToInt(ToolNo.Text);
            if (toolGet > -1)
            {
                var stuffNo = stuffAndToolOnWork.FirstOrDefault(p => p.using_tool == toolGet);
                if (stuffNo != null)
                {
                    toolWaiting.Add(toolGet);
                    stuffAndToolOnWork.Remove(stuffAndToolOnWork.First(p => p.using_tool == toolGet));
                    MessageBox.Show(stuffNo.stuff + "号工人下班，" + toolGet + "号工具已归还");
                }
                else
                    MessageBox.Show("请勿重复下班！");
            }
            else
                MessageBox.Show("工具号不正确！");

        }


    }
}
