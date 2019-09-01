using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 汇编编译器
{
    class 预处理汇编文件
    {
        static void Mainsss(string[] args)
        {


            //Process CmdProcess = new Process();  
            //CmdProcess.StartInfo.FileName = "cmd.exe";    
            //3.配置开发方式输入输出错误

            //CmdProcess.StartInfo.CreateNoWindow = true;         // 不创建新窗口    
            //CmdProcess.StartInfo.UseShellExecute = false;       //不启用shell启动进程  
            //CmdProcess.StartInfo.RedirectStandardInput = true;  // 重定向输入    
            //CmdProcess.StartInfo.RedirectStandardOutput = true; // 重定向标准输出    
            //CmdProcess.StartInfo.RedirectStandardError = true;  // 重定向错误输出  
            //4.执行cmd且获取返回值
            //方法一

            //CmdProcess.StartInfo.Arguments = "/c " + "=====cmd命令======";//“/C”表示执行完命令后马上退出  
            //CmdProcess.Start();//执行  

            //CmdProcess.StandardOutput.ReadToEnd();//获取返回值  

            //CmdProcess.WaitForExit();//等待程序执行完退出进程  

            //CmdProcess.Close();//结束  
            //方法二

            //CmdProcess.StandardInput.WriteLine(str + "&exit"); //向cmd窗口发送输入信息  
            //CmdProcess.StandardInput.AutoFlush = true;  //提交  

            //CmdProcess.Start();//执行  

            //CmdProcess.StandardOutput.ReadToEnd();//输出  

            //CmdProcess.WaitForExit();//等待程序执行完退出进程  

            //CmdProcess.Close();//结束  
            String path = AppDomain.CurrentDomain.BaseDirectory + "\\..\\..\\daima\\";

//            string[] suoyou_lst = Directory.GetFiles(path, "*.nas");
//            foreach (string lst in suoyou_lst)
//            {

//                Process pro = new Process();
//                string filename = lst.Substring(lst.LastIndexOf("\\") + 1, lst.LastIndexOf(".") - lst.LastIndexOf("\\") - 1);
//                File.Delete(path + filename + ".bin");
//                File.Delete(path + filename + ".lst");
//                string cmdBat = string.Format(@"{0}.bin : {0}.nas Makefile
//	nask.exe {0}.nas {0}.bin {0}.lst", filename);
//                File.WriteAllText(path+"Makefile", cmdBat, Encoding.UTF8);
//                FileInfo fileinfo = new FileInfo(@"G:\Y2\asp.net\MvcTest20130404\Test\汇编编译器\daima\make.bat");
//                pro.StartInfo.WorkingDirectory = fileinfo.Directory.FullName;

//                pro.StartInfo.FileName = @"G:\Y2\asp.net\MvcTest20130404\Test\汇编编译器\daima\make.bat";
//                pro.StartInfo.CreateNoWindow = false;
//                pro.Start();
//                pro.WaitForExit();

               
//            }





            //获取目录下所有lst文件
            string[] files = Directory.GetFiles(path, "*.lst");
            List<string[]> list = new List<string[]>();
            int flag = 0;
            foreach (string file in files)
            {
                string[] lsstr = File.ReadAllLines(file,Encoding.Default);
                flag = flag + lsstr.Length;
                list.Add(lsstr);
            }
            //多个string[]合并成一个string[]
            string[] ls = new string[flag];
            int iFlag = 0;
            foreach (string[] lsstr in list)
            {
                foreach (string str in lsstr)
                {
                    ls[iFlag] = str;
                    iFlag++;
                }
            }

            for (int i = 0; i < ls.Length; i++)
            {
                ls[i] = ls[i].Replace(" = ", "");//去除=
                if (ls[i].Length > 15)
                {
                    ls[i] = ls[i].Substring(15, ls[i].Length - 15);//去掉前地址部分
                }
                if (ls[i].Contains(";"))
                {
                    ls[i] = ls[i].Substring(0, ls[i].IndexOf(";")).Replace(" ", "");//去掉注释
                }
                else
                {
                    ls[i] = ls[i].Replace(" ", "");//去掉空格
                }
                if (ls[i].Contains("\t"))
                {
                    ls[i] = "dic.Add(\"" + ls[i].Substring(ls[i].IndexOf("\t"), ls[i].Length - ls[i].IndexOf("\t")) + "\",\"" + ls[i].Substring(0, ls[i].IndexOf("\t")) + "\");";//加dic.Add并将指令放前，机器码放后
                }
            }
            //去重复指令
            Dictionary<string, string> dic = new Dictionary<string, string>();
            foreach (string s in ls)
            {
                if (!dic.ContainsKey(s))
                {
                    dic.Add(s, "aaa");
                }
            }
            //处理后结果
            string rs = "";
            foreach (string key in dic.Keys)
            {
                if (key.Contains("Add"))
                    rs = rs + key + "\n";
            }
            rs = rs.Replace("\t", "");//去制表符tab
            File.WriteAllText(AppDomain.CurrentDomain.BaseDirectory + "\\..\\..\\ku\\" + DateTime.Now.ToString("yyyyMMddhhmmss") + ".txt", rs, Encoding.ASCII);
            Console.WriteLine(rs);
        }
    }
}
