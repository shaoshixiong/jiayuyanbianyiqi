using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 汇编编译器
{
    class Class2
    {
        static void Mains(string[] args)
        {
            Dictionary<string, string> dic = new Dictionary<string, string>();

            dic.Add("F4", "HLT ");
            dic.Add("C3", "RET ");

            dic.Add("FA", "CLI ");
            dic.Add("C3", "RET ");

            dic.Add("FB", "STI ");
            dic.Add("C3", "RET ");

            dic.Add("FB", "STI ");
            dic.Add("F4", "HLT ");
            dic.Add("C3", "RET ");

            dic.Add("8B 54 24 04   ", "MOV EDX,[ESP+4]");
            dic.Add("B8 00000000   ", "MOV EAX,0");
            dic.Add("EC", "IN AL,DX");
            dic.Add("C3", "RET ");

            dic.Add("8B 54 24 04   ", "MOV EDX,[ESP+4]");
            dic.Add("B8 00000000   ", "MOV EAX,0");
            dic.Add("66 ED", "IN AX,DX");
            dic.Add("C3", "RET ");

            dic.Add("8B 54 24 04   ", "MOV EDX,[ESP+4]");
            dic.Add("ED", "IN EAX,DX ");
            dic.Add("C3", "RET ");

            dic.Add("8B 54 24 04   ", "MOV EDX,[ESP+4]");
            dic.Add("8A 44 24 08   ", "MOV AL,[ESP+8] ");
            dic.Add("EE", "OUT DX,AL");
            dic.Add("C3", "RET");

            dic.Add("8B 54 24 04   ", "MOV EDX,[ESP+4]");
            dic.Add("8B 44 24 08   ", "MOV EAX,[ESP+8] ");
            dic.Add("66 EF", "OUT DX,AX");
            dic.Add("C3", "RET ");

            dic.Add("8B 54 24 04   ", "MOV EDX,[ESP+4]");
            dic.Add("8B 44 24 08   ", "MOV EAX,[ESP+8] ");
            dic.Add("EF", "OUT DX,EAX ");
            dic.Add("C3", "RET ");

            dic.Add("9C", "PUSHFD");
            dic.Add("58", "POP EAX");
            dic.Add("C3", "RET ");


            dic.Add("50", "PUSH	EAX  ");
            dic.Add("9D", "POPFD");
            dic.Add("C3", "RET ");

            dic.Add("66 8B 44 24 04", "MOV AX,[ESP+4] ");
            dic.Add("66 89 44 24 06", "MOV [ESP+6],AX  ");
            dic.Add("0F 01 54 24 06", "LGDT	[ESP+6] ");
            dic.Add("C3", "RET ");

            dic.Add("66 8B 44 24 04", "MOV AX,[ESP+4] ");
            dic.Add("66 89 44 24 06", "MOV [ESP+6],AX  ");
            dic.Add("0F 01 5C 24 06", "LIDT	[ESP+6] ");
            dic.Add("C3", "RET ");

            dic.Add("0F 20 C0      ", "MOV EAX,CR0 ");
            dic.Add("C3", "RET ");

            dic.Add("8B 44 24 04   ", "MOV EAX,[ESP+4] ");
            dic.Add("0F 22 C0      ", "MOV CR0,EAX ");
            dic.Add("C3", "RET ");

            dic.Add("0F 00 5C 24 04", "LTR [ESP+4]");
            dic.Add("C3", "RET");

            dic.Add("06", "PUSH	ES");
            dic.Add("1E", "PUSH	DS");
            dic.Add("60", "PUSHAD");
            dic.Add("89 E0", "MOV EAX,ESP");
            dic.Add("50", "PUSH	EAX");
            dic.Add("66 8C D0", "MOV AX,SS");
            dic.Add("8E D8", "MOV DS,AX");
            dic.Add("8E C0", "MOV ES,AX");
            dic.Add("E8 [00000000]", "CALL	_inthandler20");
            dic.Add("58", "POP EAX");
            dic.Add("61", "POPAD");
            dic.Add("1F", "POP DS");
            dic.Add("07", "POP ES");
            dic.Add("CF", "IRETD");

            dic.Add("06", "PUSH	ES");
            dic.Add("1E", "PUSH	DS");
            dic.Add("60", "PUSHAD");
            dic.Add("89 E0", "MOV EAX,ESP");
            dic.Add("50", "PUSH	EAX");
            dic.Add("66 8C D0      ", "MOV AX,SS");
            dic.Add("8E D8", "MOV DS,AX");
            dic.Add("8E C0", "MOV ES,AX");
            dic.Add("E8 [00000000] ", "CALL	_inthandler21");
            dic.Add("58", "POP EAX");
            dic.Add("61", "POPAD");
            dic.Add("1F", "POP DS");
            dic.Add("07", "POP ES");
            dic.Add("CF", "IRETD");

            dic.Add("06", "PUSH	ES");
            dic.Add("1E", "PUSH	DS");
            dic.Add("60", "PUSHAD");
            dic.Add("89 E0", "MOV EAX,ESP");
            dic.Add("50", "PUSH	EAX");
            dic.Add("66 8C D0", "MOV AX,SS");
            dic.Add("8E D8", "MOV DS,AX");
            dic.Add("8E C0", "MOV ES,AX");
            dic.Add("E8 [00000000] ", "CALL	_inthandler2c");
            dic.Add("58", "POP EAX");
            dic.Add("61", "POPAD");
            dic.Add("1F", "POP DS");
            dic.Add("07", "POP ES");
            dic.Add("CF", "IRETD");

            dic.Add("FB", "STI");
            dic.Add("06", "PUSH	ES");
            dic.Add("1E", "PUSH	DS");
            dic.Add("60", "PUSHAD");
            dic.Add("89 E0", "MOV EAX,ESP");
            dic.Add("50", "PUSH	EAX  ");
            dic.Add("66 8C D0      ", "MOV AX,SS");
            dic.Add("8E D8", "MOV DS,AX");
            dic.Add("8E C0", "MOV ES,AX");
            dic.Add("E8 [00000000] ", "CALL	_inthandler0c");
            dic.Add("83 F8 00      ", "CMP EAX,0");
            dic.Add("0F 85 00000091", "JNE _asm_end_app");
            dic.Add("58", "POP EAX");
            dic.Add("61", "POPAD");
            dic.Add("1F", "POP DS");
            dic.Add("07", "POP ES");
            dic.Add("83 C4 04      ", "ADD ESP,4");
            dic.Add("CF", "IRETD");

            dic.Add("FB", "STI ");
            dic.Add("06", "PUSH	ES");
            dic.Add("1E", "PUSH	DS");
            dic.Add("60", "PUSHAD");
            dic.Add("89 E0", "MOV EAX,ESP");
            dic.Add("50", "PUSH	EAX  ");
            dic.Add("66 8C D0      ", "MOV AX,SS");
            dic.Add("8E D8", "MOV DS,AX");
            dic.Add("8E C0", "MOV ES,AX");
            dic.Add("E8 [00000000] ", "CALL	_inthandler0d");
            dic.Add("83 F8 00      ", "CMP EAX,0");
            dic.Add("75 71", "JNE _asm_end_app");
            dic.Add("58", "POP EAX");
            dic.Add("61", "POPAD");
            dic.Add("1F", "POP DS");
            dic.Add("07", "POP ES");
            dic.Add("83 C4 04      ", "ADD ESP,4");
            dic.Add("CF", "IRETD");

            dic.Add("57", "PUSH	EDI");
            dic.Add("56", "PUSH	ESI");
            dic.Add("53", "PUSH	EBX");
            dic.Add("BE AA55AA55   ", "MOV ESI,0xaa55aa55");
            dic.Add("BF 55AA55AA   ", "MOV EDI,0x55aa55aa");
            dic.Add("8B 44 24 10   ", "MOV EAX,[ESP+12+4]");

            dic.Add("89 C3", "MOV EBX,EAX");
            dic.Add("81 C3 00000FFC", "ADD EBX,0xffc");
            dic.Add("8B 13", "MOV EDX,[EBX]");
            dic.Add("89 33", "MOV [EBX],ESI");
            dic.Add("83 33 FF      ", "XOR DWORD [EBX],0xffffffff");
            dic.Add("3B 3B", "CMP EDI,[EBX]"); ;
            dic.Add("75 18", "JNE mts_fin");
            dic.Add("83 33 FF      ", "XOR DWORD [EBX],0xffffffff");
            dic.Add("3B 33", "CMP ESI,[EBX]"); ;
            dic.Add("75 11", "JNE mts_fin");
            dic.Add("89 13", "MOV [EBX],EDX");
            dic.Add("05 00001000   ", "ADD EAX,0x1000");
            dic.Add("3B 44 24 14   ", "CMP EAX,[ESP+12+8]");
            dic.Add("76 D9", "JBE mts_loop");
            dic.Add("5B", "POP EBX");
            dic.Add("5E", "POP ESI");
            dic.Add("5F", "POP EDI");
            dic.Add("C3", "RET");

            dic.Add("89 13", "MOV [EBX],EDX");
            dic.Add("5B", "POP EBX");
            dic.Add("5E", "POP ESI");
            dic.Add("5F", "POP EDI");
            dic.Add("C3", "RET ");

            dic.Add("FF 6C 24 04   ", "JMP FAR	[ESP+4]");
            dic.Add("C3", "RET ");

            dic.Add("FF 5C 24 04   ", "CALL	FAR	[ESP+4]");
            dic.Add("C3", "RET");

            dic.Add("FB", "STI");
            dic.Add("1E", "PUSH	DS");
            dic.Add("06", "PUSH	ES");
            dic.Add("60", "PUSHAD");
            dic.Add("60", "PUSHAD");
            dic.Add("66 8C D0", "MOV AX,SS");
            dic.Add("8E D8", "MOV DS,AX");
            dic.Add("8E C0", "MOV ES,AX");
            dic.Add("E8 [00000000] ", "CALL	_hrb_api");
            dic.Add("83 F8 00      ", "CMP EAX,0");
            dic.Add("75 07", "JNE _asm_end_app");
            dic.Add("83 C4 20", "ADD ESP,32 ");
            dic.Add("61", "POPAD");
            dic.Add("07", "POP ES");
            dic.Add("1F", "POP DS");
            dic.Add("CF", "IRETD");

            dic.Add("8B 20", "MOV ESP,[EAX]");
            dic.Add("C7 40 04 00000000", "MOV DWORD [EAX+4],0");
            dic.Add("61", "POPAD");
            dic.Add("C3", "RET");

            dic.Add("60", "PUSHAD");
            dic.Add("8B 44 24 24   ", "MOV EAX,[ESP+36]");
            dic.Add("8B 4C 24 28   ", "MOV ECX,[ESP+40]");
            dic.Add("8B 54 24 2C   ", "MOV EDX,[ESP+44]");
            dic.Add("8B 5C 24 30   ", "MOV EBX,[ESP+48]");
            dic.Add("8B 6C 24 34   ", "MOV EBP,[ESP+52]");
            dic.Add("89 65 00      ", "MOV [EBP  ],ESP");
            dic.Add("8C 55 04      ", "MOV [EBP+4],SS");
            dic.Add("8E C3", "MOV ES,BX");
            dic.Add("8E DB", "MOV DS,BX");
            dic.Add("8E E3", "MOV FS,BX");
            dic.Add("8E EB", "MOV GS,BX");

            dic.Add("83 C9 03      ", "OR ECX,3");
            dic.Add("83 CB 03      ", "OR EBX,3");
            dic.Add("53", "PUSH	EBX");
            dic.Add("52", "PUSH	EDX");
            dic.Add("51", "PUSH	ECX");
            dic.Add("50", "PUSH	EAX");
            dic.Add("CB", "RETF");

        }
        static string getbit()
        {
            Dictionary<string, string> dic = new Dictionary<string, string>();

            dic.Add("F4", "HLT ");
            dic.Add("C3", "RET ");
            
            dic.Add("FA", "CLI ");
            dic.Add("C3", "RET ");
            
            dic.Add("FB", "STI ");
            dic.Add("C3", "RET ");
            
            dic.Add("FB", "STI ");
            dic.Add("F4", "HLT ");
            dic.Add("C3", "RET ");
            
            dic.Add("8B 54 24 04   ", "MOV EDX,[ESP+4]");
            dic.Add("B8 00000000   ", "MOV EAX,0");
            dic.Add("EC", "IN AL,DX");
            dic.Add("C3", "RET ");
            
            dic.Add("8B 54 24 04   ", "MOV EDX,[ESP+4]");
            dic.Add("B8 00000000   ", "MOV EAX,0");
            dic.Add("66 ED", "IN AX,DX");
            dic.Add("C3", "RET ");
            
            dic.Add("8B 54 24 04   ", "MOV EDX,[ESP+4]");
            dic.Add("ED", "IN EAX,DX ");
            dic.Add("C3", "RET ");
            
            dic.Add("8B 54 24 04   ", "MOV EDX,[ESP+4]");
            dic.Add("8A 44 24 08   ", "MOV AL,[ESP+8] ");
            dic.Add("EE", "OUT DX,AL");
            dic.Add("C3", "RET ");
            
            dic.Add("8B 54 24 04   ", "MOV EDX,[ESP+4]");
            dic.Add("8B 44 24 08   ", "MOV EAX,[ESP+8] ");
            dic.Add("66 EF", "OUT DX,AX");
            dic.Add("C3", "RET ");
            
            dic.Add("8B 54 24 04   ", "MOV EDX,[ESP+4]");
            dic.Add("8B 44 24 08   ", "MOV EAX,[ESP+8] ");
            dic.Add("EF", "OUT DX,EAX ");
            dic.Add("C3", "RET ");
            
            dic.Add("9C", "PUSHFD");
            dic.Add("58", "POP EAX");
            dic.Add("C3", "RET ");
            
         
            dic.Add("50", "PUSH	EAX  ");
            dic.Add("9D", "POPFD");
            dic.Add("C3", "RET ");
            
            dic.Add("66 8B 44 24 04", "MOV AX,[ESP+4] ");
            dic.Add("66 89 44 24 06", "MOV [ESP+6],AX  ");
            dic.Add("0F 01 54 24 06", "LGDT	[ESP+6] ");
            dic.Add("C3", "RET ");
         
            dic.Add("66 8B 44 24 04", "MOV AX,[ESP+4] ");
            dic.Add("66 89 44 24 06", "MOV [ESP+6],AX  ");
            dic.Add("0F 01 5C 24 06", "LIDT	[ESP+6] ");
            dic.Add("C3", "RET ");
            
            dic.Add("0F 20 C0      ", "MOV EAX,CR0 ");
            dic.Add("C3", "RET ");
            
            dic.Add("8B 44 24 04   ", "MOV EAX,[ESP+4] ");
            dic.Add("0F 22 C0      ", "MOV CR0,EAX ");
            dic.Add("C3", "RET ");
            
            dic.Add("0F 00 5C 24 04", "LTR [ESP+4]");
            dic.Add("C3", "RET");
            
            dic.Add("06", "PUSH	ES");
            dic.Add("1E", "PUSH	DS");
            dic.Add("60", "PUSHAD");
            dic.Add("89 E0", "MOV EAX,ESP");
            dic.Add("50", "PUSH	EAX");
            dic.Add("66 8C D0", "MOV AX,SS");
            dic.Add("8E D8", "MOV DS,AX");
            dic.Add("8E C0", "MOV ES,AX");
            dic.Add("E8 [00000000]", "CALL	_inthandler20");
            dic.Add("58", "POP EAX");
            dic.Add("61", "POPAD");
            dic.Add("1F", "POP DS");
            dic.Add("07", "POP ES");
            dic.Add("CF", "IRETD");
            
            dic.Add("06", "PUSH	ES");
            dic.Add("1E", "PUSH	DS");
            dic.Add("60", "PUSHAD");
            dic.Add("89 E0", "MOV EAX,ESP");
            dic.Add("50", "PUSH	EAX");
            dic.Add("66 8C D0      ", "MOV AX,SS");
            dic.Add("8E D8", "MOV DS,AX");
            dic.Add("8E C0", "MOV ES,AX");
            dic.Add("E8 [00000000] ", "CALL	_inthandler21");
            dic.Add("58", "POP EAX");
            dic.Add("61", "POPAD");
            dic.Add("1F", "POP DS");
            dic.Add("07", "POP ES");
            dic.Add("CF", "IRETD");
            
            dic.Add("06", "PUSH	ES");
            dic.Add("1E", "PUSH	DS");
            dic.Add("60", "PUSHAD");
            dic.Add("89 E0", "MOV EAX,ESP");
            dic.Add("50", "PUSH	EAX");
            dic.Add("66 8C D0", "MOV AX,SS");
            dic.Add("8E D8", "MOV DS,AX");
            dic.Add("8E C0", "MOV ES,AX");
            dic.Add("E8 [00000000] ", "CALL	_inthandler2c");
            dic.Add("58", "POP EAX");
            dic.Add("61", "POPAD");
            dic.Add("1F", "POP DS");
            dic.Add("07", "POP ES");
            dic.Add("CF", "IRETD");
            
            dic.Add("FB", "STI");
            dic.Add("06", "PUSH	ES");
            dic.Add("1E", "PUSH	DS");
            dic.Add("60", "PUSHAD");
            dic.Add("89 E0", "MOV EAX,ESP");
            dic.Add("50", "PUSH	EAX  ");
            dic.Add("66 8C D0      ", "MOV AX,SS");
            dic.Add("8E D8", "MOV DS,AX");
            dic.Add("8E C0", "MOV ES,AX");
            dic.Add("E8 [00000000] ", "CALL	_inthandler0c");
            dic.Add("83 F8 00      ", "CMP EAX,0");
            dic.Add("0F 85 00000091", "JNE _asm_end_app");
            dic.Add("58", "POP EAX");
            dic.Add("61", "POPAD");
            dic.Add("1F", "POP DS");
            dic.Add("07", "POP ES");
            dic.Add("83 C4 04      ", "ADD ESP,4");
            dic.Add("CF", "IRETD");
            
            dic.Add("FB", "STI ");
            dic.Add("06", "PUSH	ES");
            dic.Add("1E", "PUSH	DS");
            dic.Add("60", "PUSHAD");
            dic.Add("89 E0", "MOV EAX,ESP");
            dic.Add("50", "PUSH	EAX  ");
            dic.Add("66 8C D0      ", "MOV AX,SS");
            dic.Add("8E D8", "MOV DS,AX");
            dic.Add("8E C0", "MOV ES,AX");
            dic.Add("E8 [00000000] ", "CALL	_inthandler0d");
            dic.Add("83 F8 00      ", "CMP EAX,0");
            dic.Add("75 71", "JNE _asm_end_app");
            dic.Add("58", "POP EAX");
            dic.Add("61", "POPAD");
            dic.Add("1F", "POP DS");
            dic.Add("07", "POP ES");
            dic.Add("83 C4 04      ", "ADD ESP,4");
            dic.Add("CF", "IRETD");
            
            dic.Add("57", "PUSH	EDI");
            dic.Add("56", "PUSH	ESI");
            dic.Add("53", "PUSH	EBX");
            dic.Add("BE AA55AA55   ", "MOV ESI,0xaa55aa55");
            dic.Add("BF 55AA55AA   ", "MOV EDI,0x55aa55aa");
            dic.Add("8B 44 24 10   ", "MOV EAX,[ESP+12+4]");
            
            dic.Add("89 C3", "MOV EBX,EAX");
            dic.Add("81 C3 00000FFC", "ADD EBX,0xffc");
            dic.Add("8B 13", "MOV EDX,[EBX]");
            dic.Add("89 33", "MOV [EBX],ESI");
            dic.Add("83 33 FF      ", "XOR DWORD [EBX],0xffffffff");
            dic.Add("3B 3B", "CMP EDI,[EBX]"); ;
            dic.Add("75 18", "JNE mts_fin");
            dic.Add("83 33 FF      ", "XOR DWORD [EBX],0xffffffff");
            dic.Add("3B 33", "CMP ESI,[EBX]"); ;
            dic.Add("75 11", "JNE mts_fin");
            dic.Add("89 13", "MOV [EBX],EDX");
            dic.Add("05 00001000   ", "ADD EAX,0x1000");
            dic.Add("3B 44 24 14   ", "CMP EAX,[ESP+12+8]");
            dic.Add("76 D9", "JBE mts_loop");
            dic.Add("5B", "POP EBX");
            dic.Add("5E", "POP ESI");
            dic.Add("5F", "POP EDI");
            dic.Add("C3", "RET");
            
            dic.Add("89 13", "MOV [EBX],EDX");
            dic.Add("5B", "POP EBX");
            dic.Add("5E", "POP ESI");
            dic.Add("5F", "POP EDI");
            dic.Add("C3", "RET ");
            
            dic.Add("FF 6C 24 04   ", "JMP FAR	[ESP+4]");
            dic.Add("C3", "RET ");
            
            dic.Add("FF 5C 24 04   ", "CALL	FAR	[ESP+4]");
            dic.Add("C3", "RET");
            
            dic.Add("FB", "STI");
            dic.Add("1E", "PUSH	DS");
            dic.Add("06", "PUSH	ES");
            dic.Add("60", "PUSHAD");
            dic.Add("60", "PUSHAD");
            dic.Add("66 8C D0", "MOV AX,SS");
            dic.Add("8E D8", "MOV DS,AX");
            dic.Add("8E C0", "MOV ES,AX");
            dic.Add("E8 [00000000] ", "CALL	_hrb_api");
            dic.Add("83 F8 00      ", "CMP EAX,0");
            dic.Add("75 07", "JNE _asm_end_app");
            dic.Add("83 C4 20", "ADD ESP,32 ");
            dic.Add("61", "POPAD");
            dic.Add("07", "POP ES");
            dic.Add("1F", "POP DS");
            dic.Add("CF", "IRETD");
            
            dic.Add("8B 20", "MOV ESP,[EAX]");
            dic.Add("C7 40 04 00000000", "MOV DWORD [EAX+4],0");
            dic.Add("61", "POPAD");
            dic.Add("C3", "RET");
            
            dic.Add("60", "PUSHAD");
            dic.Add("8B 44 24 24   ", "MOV EAX,[ESP+36]");
            dic.Add("8B 4C 24 28   ", "MOV ECX,[ESP+40]");
            dic.Add("8B 54 24 2C   ", "MOV EDX,[ESP+44]");
            dic.Add("8B 5C 24 30   ", "MOV EBX,[ESP+48]");
            dic.Add("8B 6C 24 34   ", "MOV EBP,[ESP+52]");
            dic.Add("89 65 00      ", "MOV [EBP  ],ESP");
            dic.Add("8C 55 04      ", "MOV [EBP+4],SS");
            dic.Add("8E C3", "MOV ES,BX");
            dic.Add("8E DB", "MOV DS,BX");
            dic.Add("8E E3", "MOV FS,BX");
            dic.Add("8E EB", "MOV GS,BX");
            
            dic.Add("83 C9 03      ", "OR ECX,3");
            dic.Add("83 CB 03      ", "OR EBX,3");
            dic.Add("53", "PUSH	EBX");
            dic.Add("52", "PUSH	EDX");
            dic.Add("51", "PUSH	ECX");
            dic.Add("50", "PUSH	EAX");
            dic.Add("CB", "RETF");

            return null;
        }
    }
}
