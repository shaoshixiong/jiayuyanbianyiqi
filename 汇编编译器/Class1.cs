using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 汇编编译器
{
    class Class1
    {
        static void Mainsssss(string[] args)
        {
            Dictionary<string, string> dic = new Dictionary<string, string>();


            dic.Add("B8 9000", "MOV AX,0x9000 ");
            dic.Add("8E C0  ", "MOV ES,AX");
            dic.Add("BF 0000", "MOV DI,0 ");
            dic.Add("B8 4F00", "MOV AX,0x4f00 ");
            dic.Add("CD 10  ", "INT 0x10 ");
            dic.Add("3D 004F", "CMP AX,0x004f ");
            dic.Add("75 52  ", "JNE scrn320   ");

            dic.Add("26 8B 45 04", "MOV AX,[ES:DI+4]");
            dic.Add("3D 0200", "CMP AX,0x0200 ");
            dic.Add("72 49  ", "JB scrn320");

            dic.Add("B9 0100", "MOV CX,VBEMODE ");
            dic.Add("B8 4F01", "MOV AX,0x4f01 ");
            
           
            dic.Add("75 3C  ", "JNE scrn320   ");

            dic.Add("26 80 7D 19 08", "CMP BYTE [ES:DI+0x19],8");
            dic.Add("75 35  ", "JNE scrn320   ");
            dic.Add("26 80 7D 1B 04", "CMP BYTE [ES:DI+0x1b],4");
            dic.Add("75 2E  ", "JNE scrn320   ");
            dic.Add("26 8B 05   ", "MOV AX,[ES:DI+0x00] ");
            dic.Add("25 0080", "AND AX,0x0080 ");
            dic.Add("74 26  ", "JZ scrn320");

            dic.Add("BB 4100", "MOV BX,VBEMODE+0x4000  ");
            dic.Add("B8 4F02", "MOV AX,0x4f02 ");
            dic.Add("CD 10  ", "INT 0x10 ");
            dic.Add("C6 06 0FF2 08 ", "MOV BYTE [VMODE],8");
            dic.Add("26 8B 45 12", "MOV AX,[ES:DI+0x12] ");
            dic.Add("A3 0FF4", "MOV [SCRNX],AX ");
            dic.Add("26 8B 45 14", "MOV AX,[ES:DI+0x14] ");
            dic.Add("A3 0FF6", "MOV [SCRNY],AX ");
            dic.Add("66 26 8B 45 28", "MOV EAX,[ES:DI+0x28]");
            dic.Add("66 A3 0FF8 ", "MOV [VRAM],EAX ");
            dic.Add("EB 20  ", "JMP keystatus ");

            dic.Add("B0 13  ", "MOV AL,0x13");
            dic.Add("B4 00  ", "MOV AH,0x00");
            dic.Add("CD 10  ", "INT 0x10");
            dic.Add("C6 06 0FF2 08 ", "MOV BYTE [VMODE],8");
            dic.Add("C7 06 0FF4 0140  ", "MOV WORD [SCRNX],320 ");
            dic.Add("C7 06 0FF6 00C8  ", "MOV WORD [SCRNY],200 ");
            dic.Add("66 C7 06 0FF8 000A0000   ", "MOV DWORD [VRAM],0x000a0000 ");

            dic.Add("B4 02  ", "MOV AH,0x02");
            dic.Add("CD 16  ", "INT 0x16");
            dic.Add("A2 0FF1", "MOV [LEDS],AL ");

            dic.Add("B0 FF  ", "MOV AL,0xff   ");
            dic.Add("E6 21  ", "OUT 0x21,AL   ");

            dic.Add("90", "NOP");
            dic.Add("E6 A1  ", " OUT 0xa1,AL  ");

            dic.Add("FA", "CLI");

            dic.Add("E8 00B5", "CALL	waitkbdout    ");
            dic.Add("B0 D1  ", "MOV AL,0xd1  ");
            dic.Add("E6 64  ", "OUT 0x64,AL  ");
            dic.Add("E8 00AE", "CALL	waitkbdout    ");
            dic.Add("B0 DF  ", "MOV AL,0xdf");
            dic.Add("E6 60  ", "OUT 0x60,AL");
            dic.Add("E8 00A7", "CALL	waitkbdout");

            dic.Add("0F 01 16 C38A ", "LGDT	[GDTR0]");
            dic.Add("0F 20 C0   ", "MOV EAX,CR0  ");
            dic.Add("66 25 7FFFFFFF", "AND EAX,0x7fffffff");
            dic.Add("66 83 C8 01", "OR EAX,0x00000001");
            dic.Add("0F 22 C0   ", "MOV CR0,EAX  ");
            dic.Add("EB 00  ", "JMP pipelineflush ");

            dic.Add("B8 0008", "MOV AX,1*8");
            dic.Add("8E D8  ", "MOV DS,AX ");
            dic.Add("8E C0  ", "MOV ES,AX ");
            dic.Add("8E E0  ", "MOV FS,AX ");
            dic.Add("8E E8  ", "MOV GS,AX ");
            dic.Add("8E D0  ", "MOV SS,AX ");

            dic.Add("66 BE 0000C390", "MOV ESI,bootpack");
            dic.Add("66 BF 00280000", "MOV EDI,BOTPAK");
            dic.Add("66 B9 00020000", "MOV ECX,512*1024/4 ");
            dic.Add("E8 0077", "CALL memcpy");

            dic.Add("66 BE 00007C00", "MOV ESI,0x7c00");
            dic.Add("66 BF 00100000", "MOV EDI,DSKCAC");
            dic.Add("66 B9 00000080", "MOV ECX,512/4");
            dic.Add("E8 0062", "CALL memcpy   ");

            dic.Add("66 BE 00008200", "MOV ESI,DSKCAC0+512");
            dic.Add("66 BF 00100200", "MOV EDI,DSKCAC+512");
            dic.Add("66 B9 00000000", "MOV ECX,0");
            dic.Add("8A 0E 0FF0 ", "MOV CL,BYTE [CYLS] ");
            dic.Add("66 69 C9 00001200", "IMUL	ECX,512*18*2/4");
            dic.Add("66 81 E9 00000080", "SUB ECX,512/4");
            dic.Add("E8 003B", "CALL memcpy");

            dic.Add("66 BB 00280000", "MOV EBX,BOTPAK    ");
            dic.Add("67 66 8B 4B 10", "MOV ECX,[EBX+16]  ");
            dic.Add("66 83 C1 03", "ADD ECX,3 	; ECX += 3; ");
            dic.Add("66 C1 E9 02", "SHR ECX,2 	; ECX /= 4; ");
            dic.Add("74 10  ", "JZ skip");
            dic.Add("67 66 8B 73 14", "MOV ESI,[EBX+20]");
            dic.Add("66 01 DE   ", "ADD ESI,EBX");
            dic.Add("67 66 8B 7B 0C", "MOV EDI,[EBX+12]");
            dic.Add("E8 0016", "CALL	memcpy");

            dic.Add("67 66 8B 63 0C", "MOV ESP,[EBX+12]");
            dic.Add("66 EA 0000001B 0010 ", "JMP DWORD 2*8:0x0000001b ");

            dic.Add("E4 64  ", "IN  AL,0x64 ");
            dic.Add("24 02  ", "AND  AL,0x02 ");
            dic.Add("E4 60  ", "IN  AL,0x60");
            dic.Add("75 F8  ", "JNZ waitkbdout");
            dic.Add("C3", "RET   ");

            dic.Add("67 66 8B 06", "MOV EAX,[ESI]");
            dic.Add("66 83 C6 04", "ADD ESI,4 ");
            dic.Add("67 66 89 07", "MOV [EDI],EAX");
            dic.Add("66 83 C7 04", "ADD EDI,4 ");
            dic.Add("66 83 E9 01", "SUB ECX,1 ");
            dic.Add("75 EA  ", "JNZ memcpy");
            dic.Add("C3", "RET   ");

            dic.Add("00 00 00 00 00", "ALIGNB	16    ");

            dic.Add("00 00 00 00 00 00 00 00  ", "RESB	8");
            dic.Add("FFFF 0000 9200 00CF ", "DW 0xffff,0x0000,0x9200,0x00cf");
            dic.Add("FFFF 0000 9A28 0047 ", "DW 0xffff,0x0000,0x9a28,0x0047");

            dic.Add("0000   ", "DW 0");

            dic.Add("0017   ", "DW 8*3-1 ");
            dic.Add("0000C370   ", "DD GDT0  ");


            string rs = "";
            foreach (string key in dic.Keys)
            {
                string vl = "";
                dic.TryGetValue(key, out vl);
                rs = rs + "dic.Add(\"" + vl + "\",\"" + key + "\");\n";
            }
            Console.WriteLine(rs);
           
        }
        public static string getBit()
        {

            Dictionary<string, string> dic = new Dictionary<string, string>();


            dic.Add("B8 9000", "MOV AX,0x9000 ");
            dic.Add("8E C0  ", "MOV ES,AX");
            dic.Add("BF 0000", "MOV DI,0 ");
            dic.Add("B8 4F00", "MOV AX,0x4f00 ");
            dic.Add("CD 10  ", "INT 0x10 ");
            dic.Add("3D 004F", "CMP AX,0x004f ");
            dic.Add("75 52  ", "JNE scrn320   ");

            dic.Add("26 8B 45 04", "MOV AX,[ES:DI+4]");
            dic.Add("3D 0200", "CMP AX,0x0200 ");
            dic.Add("72 49  ", "JB scrn320");

            dic.Add("B9 0100", "MOV CX,VBEMODE ");
            dic.Add("B8 4F01", "MOV AX,0x4f01 ");
            dic.Add("CD 10  ", "INT 0x10 ");
            dic.Add("3D 004F", "CMP AX,0x004f ");
            dic.Add("75 3C  ", "JNE scrn320   ");

            dic.Add("26 80 7D 19 08", "CMP BYTE [ES:DI+0x19],8");
            dic.Add("75 35  ", "JNE scrn320   ");
            dic.Add("26 80 7D 1B 04", "CMP BYTE [ES:DI+0x1b],4");
            dic.Add("75 2E  ", "JNE scrn320   ");
            dic.Add("26 8B 05   ", "MOV AX,[ES:DI+0x00] ");
            dic.Add("25 0080", "AND AX,0x0080 ");
            dic.Add("74 26  ", "JZ scrn320");

            dic.Add("BB 4100", "MOV BX,VBEMODE+0x4000  ");
            dic.Add("B8 4F02", "MOV AX,0x4f02 ");
            dic.Add("CD 10  ", "INT 0x10 ");
            dic.Add("C6 06 0FF2 08 ", "MOV BYTE [VMODE],8");
            dic.Add("26 8B 45 12", "MOV AX,[ES:DI+0x12] ");
            dic.Add("A3 0FF4", "MOV [SCRNX],AX ");
            dic.Add("26 8B 45 14", "MOV AX,[ES:DI+0x14] ");
            dic.Add("A3 0FF6", "MOV [SCRNY],AX ");
            dic.Add("66 26 8B 45 28", "MOV EAX,[ES:DI+0x28]");
            dic.Add("66 A3 0FF8 ", "MOV [VRAM],EAX ");
            dic.Add("EB 20  ", "JMP keystatus ");

            dic.Add("B0 13  ", "MOV AL,0x13");
            dic.Add("B4 00  ", "MOV AH,0x00");
            dic.Add("CD 10  ", "INT 0x10");
            dic.Add("C6 06 0FF2 08 ", "MOV BYTE [VMODE],8");
            dic.Add("C7 06 0FF4 0140  ", "MOV WORD [SCRNX],320 ");
            dic.Add("C7 06 0FF6 00C8  ", "MOV WORD [SCRNY],200 ");
            dic.Add("66 C7 06 0FF8 000A0000   ", "MOV DWORD [VRAM],0x000a0000 ");

            dic.Add("B4 02  ", "MOV AH,0x02");
            dic.Add("CD 16  ", "INT 0x16");
            dic.Add("A2 0FF1", "MOV [LEDS],AL ");

            dic.Add("B0 FF  ", "MOV AL,0xff   ");
            dic.Add("E6 21  ", "OUT 0x21,AL   ");

            dic.Add("90", "NOP");
            dic.Add("E6 A1  ", " OUT 0xa1,AL  ");

            dic.Add("FA", "CLI");

            dic.Add("E8 00B5", "CALL	waitkbdout    ");
            dic.Add("B0 D1  ", "MOV AL,0xd1  ");
            dic.Add("E6 64  ", "OUT 0x64,AL  ");
            dic.Add("E8 00AE", "CALL	waitkbdout    ");
            dic.Add("B0 DF  ", "MOV AL,0xdf");
            dic.Add("E6 60  ", "OUT 0x60,AL");
            dic.Add("E8 00A7", "CALL	waitkbdout");

            dic.Add("0F 01 16 C38A ", "LGDT	[GDTR0]");
            dic.Add("0F 20 C0   ", "MOV EAX,CR0  ");
            dic.Add("66 25 7FFFFFFF", "AND EAX,0x7fffffff");
            dic.Add("66 83 C8 01", "OR EAX,0x00000001");
            dic.Add("0F 22 C0   ", "MOV CR0,EAX  ");
            dic.Add("EB 00  ", "JMP pipelineflush ");

            dic.Add("B8 0008", "MOV AX,1*8");
            dic.Add("8E D8  ", "MOV DS,AX ");
            dic.Add("8E C0  ", "MOV ES,AX ");
            dic.Add("8E E0  ", "MOV FS,AX ");
            dic.Add("8E E8  ", "MOV GS,AX ");
            dic.Add("8E D0  ", "MOV SS,AX ");

            dic.Add("66 BE 0000C390", "MOV ESI,bootpack");
            dic.Add("66 BF 00280000", "MOV EDI,BOTPAK");
            dic.Add("66 B9 00020000", "MOV ECX,512*1024/4 ");
            dic.Add("E8 0077", "CALL memcpy");

            dic.Add("66 BE 00007C00", "MOV ESI,0x7c00");
            dic.Add("66 BF 00100000", "MOV EDI,DSKCAC");
            dic.Add("66 B9 00000080", "MOV ECX,512/4");
            dic.Add("E8 0062", "CALL memcpy   ");

            dic.Add("66 BE 00008200", "MOV ESI,DSKCAC0+512");
            dic.Add("66 BF 00100200", "MOV EDI,DSKCAC+512");
            dic.Add("66 B9 00000000", "MOV ECX,0");
            dic.Add("8A 0E 0FF0 ", "MOV CL,BYTE [CYLS] ");
            dic.Add("66 69 C9 00001200", "IMUL	ECX,512*18*2/4");
            dic.Add("66 81 E9 00000080", "SUB ECX,512/4");
            dic.Add("E8 003B", "CALL memcpy");

            dic.Add("66 BB 00280000", "MOV EBX,BOTPAK    ");
            dic.Add("67 66 8B 4B 10", "MOV ECX,[EBX+16]  ");
            dic.Add("66 83 C1 03", "ADD ECX,3 	; ECX += 3; ");
            dic.Add("66 C1 E9 02", "SHR ECX,2 	; ECX /= 4; ");
            dic.Add("74 10  ", "JZ skip");
            dic.Add("67 66 8B 73 14", "MOV ESI,[EBX+20]");
            dic.Add("66 01 DE   ", "ADD ESI,EBX");
            dic.Add("67 66 8B 7B 0C", "MOV EDI,[EBX+12]");
            dic.Add("E8 0016", "CALL	memcpy");

            dic.Add("67 66 8B 63 0C", "MOV ESP,[EBX+12]");
            dic.Add("66 EA 0000001B 0010 ", "JMP DWORD 2*8:0x0000001b ");

            dic.Add("E4 64  ", "IN  AL,0x64 ");
            dic.Add("24 02  ", "AND  AL,0x02 ");
            dic.Add("E4 60  ", "IN  AL,0x60");
            dic.Add("75 F8  ", "JNZ waitkbdout");
            dic.Add("C3", "RET   ");

            dic.Add("67 66 8B 06", "MOV EAX,[ESI]");
            dic.Add("66 83 C6 04", "ADD ESI,4 ");
            dic.Add("67 66 89 07", "MOV [EDI],EAX");
            dic.Add("66 83 C7 04", "ADD EDI,4 ");
            dic.Add("66 83 E9 01", "SUB ECX,1 ");
            dic.Add("75 EA  ", "JNZ memcpy");
            dic.Add("C3", "RET   ");

            dic.Add("00 00 00 00 00", "ALIGNB	16    ");

            dic.Add("00 00 00 00 00 00 00 00  ", "RESB	8");
            dic.Add("FFFF 0000 9200 00CF ", "DW 0xffff,0x0000,0x9200,0x00cf");
            dic.Add("FFFF 0000 9A28 0047 ", "DW 0xffff,0x0000,0x9a28,0x0047");

            dic.Add("0000   ", "DW 0");

            dic.Add("0017   ", "DW 8*3-1 ");
            dic.Add("0000C370   ", "DD GDT0  ");


            string rs = "";
            foreach (string key in dic.Keys)
            {
                string vl = "";
                dic.TryGetValue(key, out vl);
                rs = rs + "dic.Add(\"" + vl + "\",\"" + key + "\");\n";
            }
            Console.WriteLine(rs);
            return null;
        }
    }
}
