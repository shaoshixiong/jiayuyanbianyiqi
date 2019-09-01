using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 汇编编译器
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine(Convert.ToByte("011001101011100011111111", 2));

            //string test = "0110 0110 1011 1000 1111 1111";
            //binaryFileSav(@"G:\Y2\asp.net\MvcTest20130404\Test\汇编编译器\bin\Debug\aaa.ex", test);
            //string source = "MOV     AX,255";
            //string yuchuli = source.Replace(" ", "");
            //foreach (char c in yuchuli)
            //{
            //    if (c == 'M')
            //    {
            //        if (yuchuli.Substring(0, 3) == "MOV")
            //        {
            //            string type=getType("AX,255");
            //            source = bitnar(type);
            //            Console.WriteLine(source);
            //            Console.ReadLine();
            //        }
            //    }
            //}


            string[] content = File.ReadAllLines(args[0]);
            //string[] content = File.ReadAllLines(@"G:\Y2\asp.net\MvcTest20130404\Test\汇编编译器\bin\Debug\ipl09.nas");
            //去掉注释
            for (int i = 0; i < content.Length; i++)
            {
                if (content[i].Contains(";"))
                {
                    content[i] = content[i].Substring(0, content[i].IndexOf(";")).Replace(" ", "").Replace("\t", "").Replace("\n", "");
                }
                else
                {
                    content[i] = content[i].Replace(" ", "").Replace("\t","").Replace("\n","");
                }
            }
            string 机器码 = "";
            for (int i = 0; i < content.Length; i++)
            {
                if (content[i] != "")
                {
                    string rs = Class3.getbit(content[i]);
                    if (rs == "false")
                    {

                        Console.WriteLine("第" + i + "行，附近有误！" + "'" + content[i] + "'");
                        
                    }
                    else
                    {
                        机器码 =机器码+ rs;
                    }
                }
            }
            binaryFileSav(args[0]+".bin", 机器码);
        }
       // Convert.ToString(0xa,2)
         public static byte[] HexToByte(string hexString)
        {
            try
            {
               
                hexString = hexString.Replace(" ", "");
                byte[] returnBytes = new byte[hexString.Length /2];
                for (int i = 0; i < returnBytes.Length; i++)
                {
                    returnBytes[i] = Convert.ToByte(hexString.Substring(i * 2, 2), 16);
                }
                return returnBytes;
            }
            catch (Exception ex)
            {
                return null;
            }
            return null;
        }

        //public static byte[] HexToByte(string hexString)
        //{
        //    try
        //    {
        //        hexString = hexString.Replace(" ", "");
        //        byte[] returnBytes = new byte[hexString.Length / 8];
        //        for (int i = 0; i < returnBytes.Length; i++)
        //        {
        //            returnBytes[i] = Convert.ToByte(hexString.Substring(i * 8, 8), 2);
        //        }
        //        return returnBytes;
        //    }
        //    catch (Exception ex)
        //    {
        //        return null;
        //    }
        //    return null;
        //}
        public static int binaryFileSav(string path, string content)
        {
            try
            {
                Stream flstr = new FileStream(path, FileMode.Create);
                BinaryWriter sw = new BinaryWriter(flstr);
                byte[] buffer = HexToByte(content);
                if (buffer == null)
                {
                    return 0;
                }
                sw.Write(buffer);
                sw.Close();
                flstr.Close();
                return 1;
            }
            catch (Exception e)
            {
                return 0;
            }
            return 0;
        }
     
        public static string getType(string leixing)
        {
            string type = "";
            string[] jg = leixing.Split(',');
            /////1
            if (jg[0] == "AX" || jg[0] == "BX" || jg[0] == "CX" || jg[0] == "DX")
            {
                type = type + "Reg";
            }
            else if (jg[0] == "SP")
            {
                type = type + "";
            }
            else
            {
                type = type + "Imm";
            }
            /////2
            if (jg[1] == "AX" || jg[1] == "BX" || jg[1] == "CX" || jg[1] == "DX")
            {
                type = type + ",Reg";
            }

            else
            {
                type = type + ",Imm";
            }
            return type;
        }

        //        oo : Function

        //00 : If mmm = 110, then a displacement follows the operation; otherwise, no displacement is used

        //01 : An 8-bit signed displacement follows the opcode

        //10 : A 16-bit signed displacement follows the opcode

        //11 : mmm specifies a register, instead of an addressing mode

        //mmm : Function

        //000 : DS:[BX+SI]

        //001 : DS:[BX+DI]

        //010 : SS:[BP+SI]

        //011 : SS:[BP+DI]

        //100 : DS:[SI]

        //101 : DS:[DI]

        //110 : SS:[BP]

        //111 : DS:[BX]

        //rrr : W=0 : W=1 : reg32

        //000 : AL : AX : EAX

        //001 : CL : CX : ECX

        //010 : DL : DX : EDX

        //011 : BL : BX : EBX

        //100 : AH : SP : ESP

        //101 : CH : BP : EBP

        //110 : DH : SI : ESI

        //111 : BH : DI : EDI

        //sss : Segment Register

        //000 : ES

        //001 : CS

        //010 : SS

        //011 : DS

        //100 : FS (Only 386+)

        //101 : GS (Only 386+)

        //rrr : Index Register

        //000 : EAX

        //001 : ECX

        //010 : EDX

        //011 : EBX

        //100 : No Index

        //101 : EBP

        //110 : ESI

        //111 : EDI

        public static string bitnar(string type)
        {
            Dictionary<string, string> dic = new Dictionary<string, string>();

            dic.Add("MemOfs,Acc", "1010001w");
            dic.Add("Acc,MemOfs", "1010000w");
            dic.Add("Reg,Imm", "1011wrrr");
            dic.Add("Mem,Imm", "1100011woo000mmm");
            dic.Add("Reg,Reg", "1000101woorrrmmm");
            dic.Add("Reg,Mem", "1000101woorrrmmm");
            dic.Add("Mem,Reg", "1000100woorrrmmm");
            dic.Add("Reg16,Seg", "10001100oosssmmm");
            dic.Add("Seg,Reg16", "10001110oosssmmm");
            dic.Add("Mem16,Seg", "10001100oosssmmm");
            dic.Add("Seg,Mem16", "10001110oosssmmm");
            dic.Add("Reg32,CRn", "000011110010000011sssrrr");
            dic.Add("CRn,Reg32", "000011110010001011sssrrr");
            dic.Add("Reg32,DRn", "000011110010000111sssrrr");
            dic.Add("DRn,Reg32", "000011110010001111sssrrr");
            dic.Add("Reg32,TRn", "000011110010010011sssrrr");
            dic.Add("TRn,Reg32", "000011110010011011sssrrr");
            string rs;
            dic.TryGetValue(type, out rs);
            return rs;
        }
    }
}
