﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 汇编编译器
{
    class Lib
    {
        public void getBit()
        {
            Dictionary<string, string> dic = new Dictionary<string, string>();
            dic.Add("EQU0x100", "VBEMODE");
            dic.Add("EQU0x00280000", "BOTPAK");
            dic.Add("EQU0x00100000", "DSKCAC");
            dic.Add("EQU0x00008000", "DSKCAC0");
            dic.Add("EQU0x0ff0", "CYLS");
            dic.Add("EQU0x0ff1", "LEDS");
            dic.Add("EQU0x0ff2", "VMODE");
            dic.Add("EQU0x0ff4", "SCRNX");
            dic.Add("EQU0x0ff6", "SCRNY");
            dic.Add("EQU0x0ff8", "VRAM");
            dic.Add("ORG0xc200", "");
            dic.Add("MOVAX,0x9000", "B89000");
            dic.Add("MOVES,AX", "8EC0");
            dic.Add("MOVDI,0", "BF0000");
            dic.Add("MOVAX,0x4f00", "B84F00");
            dic.Add("INT0x10", "CD10");
            dic.Add("CMPAX,0x004f", "3D004F");
            dic.Add("JNEscrn320", "7552");
            dic.Add("MOVAX,[ES:DI+4]", "268B4504");
            dic.Add("CMPAX,0x0200", "3D0200");
            dic.Add("JBscrn320", "7249");
            dic.Add("MOVCX,VBEMODE", "B90100");
            dic.Add("MOVAX,0x4f01", "B84F01");
            dic.Add("JNEscrn320", "753C");
            dic.Add("CMPBYTE[ES:DI+0x19],8", "26807D1908");
            dic.Add("JNEscrn320", "7535");
            dic.Add("CMPBYTE[ES:DI+0x1b],4", "26807D1B04");
            dic.Add("JNEscrn320", "752E");
            dic.Add("MOVAX,[ES:DI+0x00]", "268B05");
            dic.Add("ANDAX,0x0080", "250080");
            dic.Add("JZscrn320", "7426");
            dic.Add("MOVBX,VBEMODE+0x4000", "BB4100");
            dic.Add("MOVAX,0x4f02", "B84F02");
            dic.Add("MOVBYTE[VMODE],8", "C6060FF208");
            dic.Add("MOVAX,[ES:DI+0x12]", "268B4512");
            dic.Add("MOV[SCRNX],AX", "A30FF4");
            dic.Add("MOVAX,[ES:DI+0x14]", "268B4514");
            dic.Add("MOV[SCRNY],AX", "A30FF6");
            dic.Add("MOVEAX,[ES:DI+0x28]", "66268B4528");
            dic.Add("MOV[VRAM],EAX", "66A30FF8");
            dic.Add("JMPkeystatus", "EB20");
            dic.Add("MOVAL,0x13", "B013");
            dic.Add("MOVAH,0x00", "B400");
            dic.Add("MOVWORD[SCRNX],320", "C7060FF40140");
            dic.Add("MOVWORD[SCRNY],200", "C7060FF600C8");
            dic.Add("MOVDWORD[VRAM],0x000a0000", "66C7060FF8000A0000");
            dic.Add("MOVAH,0x02", "B402");
            dic.Add("INT0x16", "CD16");
            dic.Add("MOV[LEDS],AL", "A20FF1");
            dic.Add("MOVAL,0xff", "B0FF");
            dic.Add("OUT0x21,AL", "E621");
            dic.Add("NOP", "90");
            dic.Add("OUT0xa1,AL", "E6A1");
            dic.Add("CLI", "FA");
            dic.Add("CALLwaitkbdout", "E800B5");
            dic.Add("MOVAL,0xd1", "B0D1");
            dic.Add("OUT0x64,AL", "E664");
            dic.Add("CALLwaitkbdout", "E800AE");
            dic.Add("MOVAL,0xdf", "B0DF");
            dic.Add("OUT0x60,AL", "E660");
            dic.Add("CALLwaitkbdout", "E800A7");
            dic.Add("LGDT[GDTR0]", "0F0116C38A");
            dic.Add("MOVEAX,CR0", "0F20C0");
            dic.Add("ANDEAX,0x7fffffff", "66257FFFFFFF");
            dic.Add("OREAX,0x00000001", "6683C801");
            dic.Add("MOVCR0,EAX", "0F22C0");
            dic.Add("JMPpipelineflush", "EB00");
            dic.Add("MOVAX,1*8", "B80008");
            dic.Add("MOVDS,AX", "8ED8");
            dic.Add("MOVFS,AX", "8EE0");
            dic.Add("MOVGS,AX", "8EE8");
            dic.Add("MOVSS,AX", "8ED0");
            dic.Add("MOVESI,bootpack", "66BE0000C390");
            dic.Add("MOVEDI,BOTPAK", "66BF00280000");
            dic.Add("MOVECX,512*1024/4", "66B900020000");
            dic.Add("CALLmemcpy", "E80077");
            dic.Add("MOVESI,0x7c00", "66BE00007C00");
            dic.Add("MOVEDI,DSKCAC", "66BF00100000");
            dic.Add("MOVECX,512/4", "66B900000080");
            dic.Add("CALLmemcpy", "E80062");
            dic.Add("MOVESI,DSKCAC0+512", "66BE00008200");
            dic.Add("MOVEDI,DSKCAC+512", "66BF00100200");
            dic.Add("MOVECX,0", "66B900000000");
            dic.Add("MOVCL,BYTE[CYLS]", "8A0E0FF0");
            dic.Add("IMULECX,512*18*2/4", "6669C900001200");
            dic.Add("SUBECX,512/4", "6681E900000080");
            dic.Add("CALLmemcpy", "E8003B");
            dic.Add("MOVEBX,BOTPAK", "66BB00280000");
            dic.Add("MOVECX,[EBX+16]", "67668B4B10");
            dic.Add("ADDECX,3", "6683C103");
            dic.Add("SHRECX,2", "66C1E902");
            dic.Add("JZskip", "7410");
            dic.Add("MOVESI,[EBX+20]", "67668B7314");
            dic.Add("ADDESI,EBX", "6601DE");
            dic.Add("MOVEDI,[EBX+12]", "67668B7B0C");
            dic.Add("CALLmemcpy", "E80016");
            dic.Add("MOVESP,[EBX+12]", "67668B630C");
            dic.Add("JMPDWORD2*8:0x0000001b", "66EA0000001B0010");
            dic.Add("INAL,0x64", "E464");
            dic.Add("ANDAL,0x02", "2402");
            dic.Add("INAL,0x60", "E460");
            dic.Add("JNZwaitkbdout", "75F8");
            dic.Add("RET", "C3");
            dic.Add("MOVEAX,[ESI]", "67668B06");
            dic.Add("ADDESI,4", "6683C604");
            dic.Add("MOV[EDI],EAX", "67668907");
            dic.Add("ADDEDI,4", "6683C704");
            dic.Add("SUBECX,1", "6683E901");
            dic.Add("JNZmemcpy", "75EA");
            dic.Add("ALIGNB16", "0000000000");
            dic.Add("RESB8", "0000000000000000");
            dic.Add("DW0xffff,0x0000,0x9200,0x00cf", "FFFF0000920000CF");
            dic.Add("DW0xffff,0x0000,0x9a28,0x0047", "FFFF00009A280047");
            dic.Add("DW0", "0000");
            dic.Add("DW8*3-1", "0017");
            dic.Add("DDGDT0", "0000C370");
            dic.Add("ALIGNB16", "");
            dic.Add("EQU20", "CYLS");
            dic.Add("ORG0x7c00", "");
            dic.Add("JMPentry", "EB4E");
            dic.Add("DB0x90", "90");
            dic.Add("DB\"HARIBOTE\"", "48415249424F5445");
            dic.Add("DW512", "0200");
            dic.Add("DB1", "01");
            dic.Add("DW1", "0001");
            dic.Add("DB2", "02");
            dic.Add("DW224", "00E0");
            dic.Add("DW2880", "0B40");
            dic.Add("DB0xf0", "F0");
            dic.Add("DW9", "0009");
            dic.Add("DW18", "0012");
            dic.Add("DW2", "0002");
            dic.Add("DD0", "00000000");
            dic.Add("DD2880", "00000B40");
            dic.Add("DB0,0,0x29", "000029");
            dic.Add("DD0xffffffff", "FFFFFFFF");
            dic.Add("DB\"HARIBOTEOS\"", "48415249424F54454F53");
            dic.Add("DB\"FAT12\"", "4641543132202020");
            dic.Add("RESB18", "00000000000000000000");
            dic.Add("MOVAX,0", "B80000");
            dic.Add("MOVSP,0x7c00", "BC7C00");
            dic.Add("MOVAX,0x0820", "B80820");
            dic.Add("MOVCH,0", "B500");
            dic.Add("MOVDH,0", "B600");
            dic.Add("MOVCL,2", "B102");
            dic.Add("MOVBX,18*2*CYLS-1", "BB02CF");
            dic.Add("CALLreadfast", "E80033");
            dic.Add("MOVBYTE[0x0ff0],CYLS", "C6060FF014");
            dic.Add("JMP0xc200", "E9458D");
            dic.Add("MOVAX,0", "B80000");
            dic.Add("MOVSI,msg", "BE7C90");
            dic.Add("MOVAL,[SI]", "8A04");
            dic.Add("ADDSI,1", "83C601");
            dic.Add("CMPAL,0", "3C00");
            dic.Add("JEfin", "7409");
            dic.Add("MOVAH,0x0e", "B40E");
            dic.Add("MOVBX,15", "BB000F");
            dic.Add("INT0x10", "CD10");
            dic.Add("JMPputloop", "EBEE");
            dic.Add("HLT", "F4");
            dic.Add("JMPfin", "EBFD");
            dic.Add("DB0x0a,0x0a", "0A0A");
            dic.Add("DB\"loaderror\"", "6C6F6164206572726F72");
            dic.Add("DB0x0a", "0A");
            dic.Add("DB0", "00");
            dic.Add("", "readfast:");
            dic.Add("MOVAX,ES", "8CC0");
            dic.Add("SHLAX,3", "C1E003");
            dic.Add("ANDAH,0x7f", "80E47F");
            dic.Add("MOVAL,128", "B080");
            dic.Add("SUBAL,AH", "28E0");
            dic.Add("MOVAH,BL", "88DC");
            dic.Add("CMPBH,0", "80FF00");
            dic.Add("JE.skip1", "7402");
            dic.Add("MOVAH,18", "B412");
            dic.Add("CMPAL,AH", "38E0");
            dic.Add("JBE.skip2", "7602");
            dic.Add("MOVAL,AH", "88E0");
            dic.Add("MOVAH,19", "B413");
            dic.Add("SUBAH,CL", "28CC");
            dic.Add("JBE.skip3", "7602");
            dic.Add("PUSHBX", "53");
            dic.Add("MOVSI,0", "BE0000");
            dic.Add("MOVAH,0x02", "B402");
            dic.Add("MOVBX,0", "BB0000");
            dic.Add("MOVDL,0x00", "B200");
            dic.Add("PUSHES", "06");
            dic.Add("PUSHDX", "52");
            dic.Add("PUSHCX", "51");
            dic.Add("PUSHAX", "50");
            dic.Add("INT0x13", "CD13");
            dic.Add("JNCnext", "7314");
            dic.Add("CMPSI,5", "83FE05");
            dic.Add("JAEerror", "7395");
            dic.Add("POPAX", "58");
            dic.Add("POPCX", "59");
            dic.Add("POPDX", "5A");
            dic.Add("POPES", "07");
            dic.Add("JMPretry", "EBDD");
            dic.Add("POPBX", "5B");
            dic.Add("SHRBX,5", "C1EB05");
            dic.Add("MOVAH,0", "B400");
            dic.Add("ADDBX,AX", "01C3");
            dic.Add("SHLBX,5", "C1E305");
            dic.Add("MOVES,BX", "8EC3");
            dic.Add("POPBX", "5B");
            dic.Add("SUBBX,AX", "29C3");
            dic.Add("JZ.ret", "7418");
            dic.Add("ADDCL,AL", "00C1");
            dic.Add("CMPCL,18", "80F912");
            dic.Add("JBEreadfast", "7698");
            dic.Add("MOVCL,1", "B101");
            dic.Add("ADDDH,1", "80C601");
            dic.Add("CMPDH,2", "80FE02");
            dic.Add("JBreadfast", "728E");
            dic.Add("MOVDH,0", "B600");
            dic.Add("ADDCH,1", "80C501");
            dic.Add("JMPreadfast", "EB87");
            dic.Add("RESB0x7dfe-$", "00000000000000000000");
            dic.Add("DB0x55,0xaa", "55AA");
            dic.Add("", "[FORMAT\"WCOFF\"]");
            dic.Add("", "[INSTRSET\"i486p\"]");
            dic.Add("", "[BITS32]");
            dic.Add("", "[FILE\"naskfunc.nas\"]");
            dic.Add("GLOBAL_io_hlt,_io_cli,_io_sti,_io_stihlt", "");
            dic.Add("GLOBAL_io_in8,_io_in16,_io_in32", "");
            dic.Add("GLOBAL_io_out8,_io_out16,_io_out32", "");
            dic.Add("GLOBAL_io_load_eflags,_io_store_eflags", "");
            dic.Add("GLOBAL_load_gdtr,_load_idtr", "");
            dic.Add("GLOBAL_load_cr0,_store_cr0", "");
            dic.Add("GLOBAL_load_tr", "");
            dic.Add("GLOBAL_asm_inthandler20,_asm_inthandler21", "");
            dic.Add("GLOBAL_asm_inthandler2c,_asm_inthandler0c", "");
            dic.Add("GLOBAL_asm_inthandler0d,_asm_end_app", "");
            dic.Add("GLOBAL_memtest_sub", "");
            dic.Add("GLOBAL_farjmp,_farcall", "");
            dic.Add("GLOBAL_asm_hrb_api,_start_app", "");
            dic.Add("EXTERN_inthandler20,_inthandler21", "");
            dic.Add("EXTERN_inthandler2c,_inthandler0d", "");
            dic.Add("EXTERN_inthandler0c", "");
            dic.Add("EXTERN_hrb_api", "");
            dic.Add("", "[SECTION.text]");
            dic.Add("", "_io_hlt:");
            dic.Add("HLT", "F4");
            dic.Add("", "_io_cli:");
            dic.Add("CLI", "FA");
            dic.Add("", "_io_sti:");
            dic.Add("STI", "FB");
            dic.Add("", "_io_stihlt:");
            dic.Add("", "_io_in8:");
            dic.Add("MOVEDX,[ESP+4]", "8B542404");
            dic.Add("MOVEAX,0", "B800000000");
            dic.Add("INAL,DX", "EC");
            dic.Add("", "_io_in16:");
            dic.Add("INAX,DX", "66ED");
            dic.Add("", "_io_in32:");
            dic.Add("INEAX,DX", "ED");
            dic.Add("", "_io_out8:");
            dic.Add("MOVAL,[ESP+8]", "8A442408");
            dic.Add("OUTDX,AL", "EE");
            dic.Add("", "_io_out16:");
            dic.Add("MOVEAX,[ESP+8]", "8B442408");
            dic.Add("OUTDX,AX", "66EF");
            dic.Add("", "_io_out32:");
            dic.Add("OUTDX,EAX", "EF");
            dic.Add("", "_io_load_eflags:");
            dic.Add("PUSHFD", "9C");
            dic.Add("POPEAX", "58");
            dic.Add("", "_io_store_eflags:");
            dic.Add("MOVEAX,[ESP+4]", "8B442404");
            dic.Add("PUSHEAX", "50");
            dic.Add("POPFD", "9D");
            dic.Add("", "_load_gdtr:");
            dic.Add("MOVAX,[ESP+4]", "668B442404");
            dic.Add("MOV[ESP+6],AX", "6689442406");
            dic.Add("LGDT[ESP+6]", "0F01542406");
            dic.Add("", "_load_idtr:");
            dic.Add("LIDT[ESP+6]", "0F015C2406");
            dic.Add("", "_load_cr0:");
            dic.Add("", "_store_cr0:");
            dic.Add("", "_load_tr:");
            dic.Add("LTR[ESP+4]", "0F005C2404");
            dic.Add("PUSHDS", "1E");
            dic.Add("PUSHAD", "60");
            dic.Add("MOVEAX,ESP", "89E0");
            dic.Add("MOVAX,SS", "668CD0");
            dic.Add("CALL_inthandler20", "E8[00000000]");
            dic.Add("POPAD", "61");
            dic.Add("POPDS", "1F");
            dic.Add("IRETD", "CF");
            dic.Add("CALL_inthandler21", "E8[00000000]");
            dic.Add("CALL_inthandler2c", "E8[00000000]");
            dic.Add("CALL_inthandler0c", "E8[00000000]");
            dic.Add("CMPEAX,0", "83F800");
            dic.Add("JNE_asm_end_app", "0F8500000091");
            dic.Add("ADDESP,4", "83C404");
            dic.Add("CALL_inthandler0d", "E8[00000000]");
            dic.Add("CMPEAX,0", "83F800");
            dic.Add("JNE_asm_end_app", "7571");
            dic.Add("", "_memtest_sub:");
            dic.Add("PUSHEDI", "57");
            dic.Add("PUSHESI", "56");
            dic.Add("PUSHEBX", "53");
            dic.Add("MOVESI,0xaa55aa55", "BEAA55AA55");
            dic.Add("MOVEDI,0x55aa55aa", "BF55AA55AA");
            dic.Add("MOVEAX,[ESP+12+4]", "8B442410");
            dic.Add("MOVEBX,EAX", "89C3");
            dic.Add("ADDEBX,0xffc", "81C300000FFC");
            dic.Add("MOVEDX,[EBX]", "8B13");
            dic.Add("MOV[EBX],ESI", "8933");
            dic.Add("XORDWORD[EBX],0xffffffff", "8333FF");
            dic.Add("CMPEDI,[EBX]", "3B3B");
            dic.Add("JNEmts_fin", "7518");
            dic.Add("CMPESI,[EBX]", "3B33");
            dic.Add("JNEmts_fin", "7511");
            dic.Add("MOV[EBX],EDX", "8913");
            dic.Add("ADDEAX,0x1000", "0500001000");
            dic.Add("CMPEAX,[ESP+12+8]", "3B442414");
            dic.Add("JBEmts_loop", "76D9");
            dic.Add("POPEBX", "5B");
            dic.Add("POPESI", "5E");
            dic.Add("POPEDI", "5F");
            dic.Add("", "_farjmp:");
            dic.Add("JMPFAR[ESP+4]", "FF6C2404");
            dic.Add("", "_farcall:");
            dic.Add("CALLFAR[ESP+4]", "FF5C2404");
            dic.Add("PUSHAD", "60");
            dic.Add("MOVDS,AX", "8ED8");
            dic.Add("CALL_hrb_api", "E8[00000000]");
            dic.Add("CMPEAX,0", "83F800");
            dic.Add("JNE_asm_end_app", "7507");
            dic.Add("ADDESP,32", "83C420");
            dic.Add("MOVESP,[EAX]", "8B20");
            dic.Add("MOVDWORD[EAX+4],0", "C7400400000000");
            dic.Add("RET", "C3");
            dic.Add("", "_start_app:");
            dic.Add("MOVEAX,[ESP+36]", "8B442424");
            dic.Add("MOVECX,[ESP+40]", "8B4C2428");
            dic.Add("MOVEDX,[ESP+44]", "8B54242C");
            dic.Add("MOVEBX,[ESP+48]", "8B5C2430");
            dic.Add("MOVEBP,[ESP+52]", "8B6C2434");
            dic.Add("MOV[EBP],ESP", "896500");
            dic.Add("MOV[EBP+4],SS", "8C5504");
            dic.Add("MOVES,BX", "8EC3");
            dic.Add("MOVDS,BX", "8EDB");
            dic.Add("MOVFS,BX", "8EE3");
            dic.Add("MOVGS,BX", "8EEB");
            dic.Add("ORECX,3", "83C903");
            dic.Add("OREBX,3", "83CB03");
            dic.Add("PUSHEBX", "53");
            dic.Add("PUSHEDX", "52");
            dic.Add("PUSHECX", "51");
            dic.Add("PUSHEAX", "50");
            dic.Add("RETF", "CB");

        }
    }
}
