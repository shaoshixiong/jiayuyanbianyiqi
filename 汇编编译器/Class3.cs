using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 汇编编译器
{
    class Class3
    {
        static void Mains(string[] args)
        {
            Dictionary<string, string> dic = new Dictionary<string, string>();
            dic.Add("JMP entry", "EB 4E");
            dic.Add("DB 0x90", "90");
            dic.Add("DB \"HARIBOTE\"", "48 41 52 49 42 4F 54 45  ");
            dic.Add("DW 512", "0200 ");
            dic.Add("DB 1", "01");
            dic.Add("DW 1", "0001 ");
            dic.Add("DB 2", "02");
            dic.Add("DW 224", "00E0 ");
            dic.Add("DW 2880", "0B40 ");
            dic.Add("DB 0xf0", "F0");
            dic.Add("DW 9", "0009 ");
            dic.Add("DW 18", "0012 ");
            dic.Add("DW 2", "0002 ");
            dic.Add("DD 0", "00000000");
            dic.Add("DD 2880", "00000B40");
            dic.Add("DB 0,0,0x29", "00 00 29");
            dic.Add("DD 0xffffffff", "FFFFFFFF");
            dic.Add("DB \"HARIBOTEOS \"", "48 41 52 49 42 4F 54 45 4F 53    ");
            dic.Add("  ", "20 ");
            dic.Add("DB \"FAT12   \"", "46 41 54 31 32 20 20 20  ");
            dic.Add("RESB	18", "00 00 00 00 00 00 00 00 00 00    ");
            dic.Add("MOV AX,0", "B8 0000 ");
            dic.Add("MOV SS,AX", "8E D0");
            dic.Add("MOV SP,0x7c00 ", "BC 7C00 ");
            dic.Add("MOV DS,AX", "8E D8");
            dic.Add("MOV AX,0x0820 ", "B8 0820 ");
            dic.Add("MOV ES,AX", "8E C0");
            dic.Add("MOV CH,0", "B5 00");
            dic.Add("MOV CL,2", "B1 02");
            dic.Add("MOV BX,18*2*CYLS-1", "BB 02CF ");
            dic.Add("CALL	readfast", "E8 0033 ");
            dic.Add("MOV BYTE [0x0ff0],CYLS", "C6 06 0FF0 14    ");
            dic.Add("JMP 0xc200", "E9 458D ");
            dic.Add("MOV SI,msg", "BE 7C90 ");
            dic.Add("MOV AL,[SI]", "8A 04");
            dic.Add("ADD SI,1", "83 C6 01");
            dic.Add("CMP AL,0", "3C 00");
            dic.Add("JE fin", "74 09");
            dic.Add("MOV AH,0x0e", "B4 0E");
            dic.Add("MOV BX,15", "BB 000F ");
            dic.Add("INT 0x10", "CD 10");
            dic.Add("JMP putloop", "EB EE");
            dic.Add("HLT", "F4");
            dic.Add("JMP fin", "EB FD");
            dic.Add("DB 0x0a, 0x0a", "0A 0A");
            dic.Add("DB \"load error\"", "6C 6F 61 64 20 65 72 72 6F 72    ");
            dic.Add("DB 0x0a", "0A");
            dic.Add("DB 0 ", "00");
            dic.Add("MOV AX,ES", "8C C0");
            dic.Add("SHL AX,3", "C1 E0 03");
            dic.Add("AND AH,0x7f", "80 E4 7F");
            dic.Add("MOV AL,128", "B0 80");
            dic.Add("SUB AL,AH", "28 E0");
            dic.Add("MOV AH,BL", "88 DC");
            dic.Add("CMP BH,0", "80 FF 00");
            dic.Add("JE .skip1", "74 02");
            dic.Add("MOV AH,18", "B4 12");
            dic.Add("CMP AL,AH", "38 E0");
            dic.Add("JBE .skip2", "76 02");
            dic.Add("MOV AL,AH", "88 E0");
            dic.Add("MOV AH,19", "B4 13");
            dic.Add("SUB AH,CL", "28 CC");
            dic.Add("PUSH	BX", "53");
            dic.Add("MOV SI,0", "BE 0000 ");
            dic.Add("MOV AH,0x02", "B4 02");
            dic.Add("MOV BX,0", "BB 0000 ");
            dic.Add("MOV DL,0x00", "B2 00");
            dic.Add("PUSH	ES", "06");
            dic.Add("PUSH	DX", "52");
            dic.Add("PUSH	CX", "51");
            dic.Add("PUSH	AX", "50");
            dic.Add("INT 0x13", "CD 13");
            dic.Add("JNC next", "73 14");
            dic.Add("CMP SI,5", "83 FE 05");
            dic.Add("JAE error", "73 95");
            dic.Add("MOV AH,0x00", "B4 00");
            dic.Add("POP AX", "58");
            dic.Add("POP CX", "59");
            dic.Add("POP DX", "5A");
            dic.Add("POP ES", "07");
            dic.Add("JMP retry", "EB DD");
            dic.Add("POP BX", "5B");
            dic.Add("SHR BX,5", "C1 EB 05");
            dic.Add("ADD BX,AX", "01 C3");
            dic.Add("SHL BX,5", "C1 E3 05");
            dic.Add("MOV ES,BX", "8E C3");
            dic.Add("SUB BX,AX", "29 C3");
            dic.Add("JZ .ret", "74 18");
            dic.Add("ADD CL,AL", "00 C1");
            dic.Add("CMP CL,18", "80 F9 12");
            dic.Add("JBE readfast", "76 98");
            dic.Add("MOV CL,1", "B1 01");
            dic.Add("ADD DH,1", "80 C6 01");
            dic.Add("CMP DH,2", "80 FE 02");
            dic.Add("JB readfast", "72 8E");
            dic.Add("MOV DH,0", "B6 00");
            dic.Add("ADD CH,1", "80 C5 01");
            dic.Add("JMP readfast", "EB 87");
            dic.Add("RET", "C3");
            dic.Add("DB 0x55, 0xaa", "55 AA");

            dic.Add("MOV AH,0", "B4 00");


        }
        public static string getbit(string key)
        {
            Dictionary<string, string> dic = new Dictionary<string, string>();
            dic.Add("jmp entry", "eb 4e");
            dic.Add("db 0x90", "90");
            dic.Add("db \"haribote\"", "48 41 52 49 42 4F 54 45  ");
            dic.Add("dw 512", "0200 ");
            dic.Add("db 1", "01");
            dic.Add("dw 1", "0001 ");
            dic.Add("db 2", "02");
            dic.Add("dw 224", "00e0 ");
            dic.Add("dw 2880", "0b40 ");
            dic.Add("db 0xf0", "f0");
            dic.Add("dw 9", "0009 ");
            dic.Add("dw 18", "0012 ");
            dic.Add("dw 2", "0002 ");
            dic.Add("dd 0", "00000000");
            dic.Add("dd 2880", "00000b40");
            dic.Add("db 0,0,0x29", "00 00 29");
            dic.Add("dd 0xffffffff", "ffffffff");
            dic.Add("db \"hariboteos \"", "48 41 52 49 42 4F 54 45 4F 53    ");
            dic.Add("  ", "20 ");
            dic.Add("db \"fat12   \"", "46 41 54 31 32 20 20 20  ");
            dic.Add("resb	18", "00 00 00 00 00 00 00 00 00 00    ");
            dic.Add("mov ax,0", "b8 0000 ");
            dic.Add("mov ss,ax", "8e d0");
            dic.Add("mov sp,0x7c00 ", "bc 7c00 ");
            dic.Add("mov ds,ax", "8e d8");
            dic.Add("mov ax,0x0820 ", "b8 0820 ");
            dic.Add("mov es,ax", "8e c0");
            dic.Add("mov ch,0", "b5 00");
            dic.Add("mov cl,2", "b1 02");
            dic.Add("mov bx,18*2*cyls-1", "bb 02cf ");
            dic.Add("call	readfast", "e8 0033 ");
            dic.Add("mov byte [0x0ff0],cyls", "c6 06 0FF0 14    ");
            dic.Add("jmp 0xc200", "e9 458d ");
            dic.Add("mov si,msg", "be 7c90 ");
            dic.Add("mov al,[si]", "8a 04");
            dic.Add("add si,1", "83 c6 01");
            dic.Add("cmp al,0", "3c 00");
            dic.Add("je fin", "74 09");
            dic.Add("mov ah,0x0e", "b4 0e");
            dic.Add("mov bx,15", "bb 000f ");
            dic.Add("int 0x10", "cd 10");
            dic.Add("jmp putloop", "eb ee");
            dic.Add("hlt", "f4");
            dic.Add("jmp fin", "eb fd");
            dic.Add("db 0x0a, 0x0a", "0a 0a");
            dic.Add("db \"load error\"", "6c 6f 61 64 20 65 72 72 6F 72    ");
            dic.Add("db 0x0a", "0a");
            dic.Add("db 0 ", "00");
            dic.Add("mov ax,es", "8c c0");
            dic.Add("shl ax,3", "c1 e0 03");
            dic.Add("and ah,0x7f", "80 e4 7f");
            dic.Add("mov al,128", "b0 80");
            dic.Add("sub al,ah", "28 e0");
            dic.Add("mov ah,bl", "88 dc");
            dic.Add("cmp bh,0", "80 ff 00");
            dic.Add("je .skip1", "74 02");
            dic.Add("mov ah,18", "b4 12");
            dic.Add("cmp al,ah", "38 e0");
            dic.Add("jbe .skip2", "76 02");
            dic.Add("mov al,ah", "88 e0");
            dic.Add("mov ah,19", "b4 13");
            dic.Add("sub ah,cl", "28 cc");
            dic.Add("push	bx", "53");
            dic.Add("mov si,0", "be 0000 ");
            dic.Add("mov ah,0x02", "b4 02");
            dic.Add("mov bx,0", "bb 0000 ");
            dic.Add("mov dl,0x00", "b2 00");
            dic.Add("push	es", "06");
            dic.Add("push	dx", "52");
            dic.Add("push	cx", "51");
            dic.Add("push	ax", "50");
            dic.Add("int 0x13", "cd 13");
            dic.Add("jnc next", "73 14");
            dic.Add("cmp si,5", "83 fe 05");
            dic.Add("jae error", "73 95");
            dic.Add("mov ah,0x00", "b4 00");
            dic.Add("pop ax", "58");
            dic.Add("pop cx", "59");
            dic.Add("pop dx", "5a");
            dic.Add("pop es", "07");
            dic.Add("jmp retry", "eb dd");
            dic.Add("pop bx", "5b");
            dic.Add("shr bx,5", "c1 eb 05");
            dic.Add("add bx,ax", "01 c3");
            dic.Add("shl bx,5", "c1 e3 05");
            dic.Add("mov es,bx", "8e c3");
            dic.Add("sub bx,ax", "29 c3");
            dic.Add("jz .ret", "74 18");
            dic.Add("add cl,al", "00 c1");
            dic.Add("cmp cl,18", "80 f9 12");
            dic.Add("jbe readfast", "76 98");
            dic.Add("mov cl,1", "b1 01");
            dic.Add("add dh,1", "80 c6 01");
            dic.Add("cmp dh,2", "80 fe 02");
            dic.Add("jb readfast", "72 8e");
            dic.Add("mov dh,0", "b6 00");
            dic.Add("add ch,1", "80 c5 01");
            dic.Add("jmp readfast", "eb 87");
            dic.Add("ret", "c3");
            dic.Add("db 0x55, 0xaa", "55 aa");

            dic.Add("mov ah,0", "b4 00");

            dic.Add("equ0x100", "vbemode");
            dic.Add("equ0x00280000", "botpak");
            dic.Add("equ0x00100000", "dskcac");
            dic.Add("equ0x00008000", "dskcac0");
            dic.Add("equ0x0ff0", "cyls");
            dic.Add("equ0x0ff1", "leds");
            dic.Add("equ0x0ff2", "vmode");
            dic.Add("equ0x0ff4", "scrnx");
            dic.Add("equ0x0ff6", "scrny");
            dic.Add("equ0x0ff8", "vram");
            dic.Add("org0xc200", "");
            dic.Add("movax,0x9000", "b89000");
            dic.Add("moves,ax", "8ec0");
            dic.Add("movdi,0", "bf0000");
            dic.Add("movax,0x4f00", "b84f00");
            dic.Add("int0x10", "cd10");
            dic.Add("cmpax,0x004f", "3d004f");
            dic.Add("jnescrn320", "7552");
            dic.Add("movax,[es:di+4]", "268b4504");
            dic.Add("cmpax,0x0200", "3d0200");
            dic.Add("jbscrn320", "7249");
            dic.Add("movcx,vbemode", "b90100");
            dic.Add("movax,0x4f01", "b84f01");

            dic.Add("cmpbyte[es:di+0x19],8", "26807d1908");

            dic.Add("cmpbyte[es:di+0x1b],4", "26807d1B04");

            dic.Add("movax,[es:di+0x00]", "268b05");
            dic.Add("andax,0x0080", "250080");
            dic.Add("jzscrn320", "7426");
            dic.Add("movbx,vbemode+0x4000", "bb4100");
            dic.Add("movax,0x4f02", "b84f02");
            dic.Add("movbyte[vmode],8", "c6060ff208");
            dic.Add("movax,[es:di+0x12]", "268b4512");
            dic.Add("mov[scrnx],ax", "a30ff4");
            dic.Add("movax,[es:di+0x14]", "268b4514");
            dic.Add("mov[scrny],ax", "a30ff6");
            dic.Add("moveax,[es:di+0x28]", "66268b4528");
            dic.Add("mov[vram],eax", "66a30ff8");
            dic.Add("jmpkeystatus", "eb20");
            dic.Add("moval,0x13", "b013");
            dic.Add("movah,0x00", "b400");
            dic.Add("movword[scrnx],320", "c7060ff40140");
            dic.Add("movword[scrny],200", "c7060ff600C8");
            dic.Add("movdword[vram],0x000a0000", "66c7060FF8000A0000");
            dic.Add("movah,0x02", "b402");
            dic.Add("int0x16", "cd16");
            dic.Add("mov[leds],al", "a20ff1");
            dic.Add("moval,0xff", "b0ff");
            dic.Add("out0x21,al", "e621");
            dic.Add("nop", "90");
            dic.Add("out0xa1,al", "e6a1");
            dic.Add("cli", "fa");
            dic.Add("callwaitkbdout", "e800b5");
            dic.Add("moval,0xd1", "b0d1");
            dic.Add("out0x64,al", "e664");

            dic.Add("moval,0xdf", "b0df");
            dic.Add("out0x60,al", "e660");

            dic.Add("lgdt[gdtr0]", "0f0116c38a");
            dic.Add("moveax,cr0", "0f20c0");
            dic.Add("andeax,0x7fffffff", "66257ffffffF");
            dic.Add("oreax,0x00000001", "6683c801");
            dic.Add("movcr0,eax", "0f22c0");
            dic.Add("jmppipelineflush", "eb00");
            dic.Add("movax,1*8", "b80008");
            dic.Add("movds,ax", "8ed8");
            dic.Add("movfs,ax", "8ee0");
            dic.Add("movgs,ax", "8ee8");
            dic.Add("movss,ax", "8ed0");
            dic.Add("movesi,bootpack", "66be0000c390");
            dic.Add("movedi,botpak", "66bf00280000");
            dic.Add("movecx,512*1024/4", "66b900020000");
            dic.Add("callmemcpy", "e80077");
            dic.Add("movesi,0x7c00", "66be00007c00");
            dic.Add("movedi,dskcac", "66bf00100000");
            dic.Add("movecx,512/4", "66b900000080");

            dic.Add("movesi,dskcac0+512", "66be00008200");
            dic.Add("movedi,dskcac+512", "66bf00100200");
            dic.Add("movecx,0", "66b900000000");
            dic.Add("movcl,byte[cyls]", "8a0e0ff0");
            dic.Add("imulecx,512*18*2/4", "6669c900001200");
            dic.Add("subecx,512/4", "6681e900000080");

            dic.Add("movebx,botpak", "66bb00280000");
            dic.Add("movecx,[ebx+16]", "67668b4b10");
            dic.Add("addecx,3", "6683c103");
            dic.Add("shrecx,2", "66c1e902");
            dic.Add("jzskip", "7410");
            dic.Add("movesi,[ebx+20]", "67668b7314");
            dic.Add("addesi,ebx", "6601de");
            dic.Add("movedi,[ebx+12]", "67668b7b0c");

            dic.Add("movesp,[ebx+12]", "67668b630c");
            dic.Add("jmpdword2*8:0x0000001b", "66ea0000001B0010");
            dic.Add("inal,0x64", "e464");
            dic.Add("andal,0x02", "2402");
            dic.Add("inal,0x60", "e460");
            dic.Add("jnzwaitkbdout", "75f8");
          
            dic.Add("moveax,[esi]", "67668b06");
            dic.Add("addesi,4", "6683c604");
            dic.Add("mov[edi],eax", "67668907");
            dic.Add("addedi,4", "6683c704");
            dic.Add("subecx,1", "6683e901");
            dic.Add("jnzmemcpy", "75ea");
            dic.Add("alignb16", "0000000000");
            dic.Add("resb8", "0000000000000000");
            dic.Add("dw0xffff,0x0000,0x9200,0x00cf", "FFFF0000920000CF");
            dic.Add("dw0xffff,0x0000,0x9a28,0x0047", "FFFF00009A280047");
            dic.Add("dw0", "0000");
            dic.Add("dw8*3-1", "0017");
            dic.Add("ddgdt0", "0000c370");

            dic.Add("equ20", "cyls");
            dic.Add("org0x7c00", "");
            dic.Add("jmpentry", "eb4e");
            dic.Add("db0x90", "90");
            dic.Add("db\"haribote\"", "48415249424f5445");
            dic.Add("dw512", "0200");
            dic.Add("db1", "01");
            dic.Add("dw1", "0001");
            dic.Add("db2", "02");
            dic.Add("dw224", "00e0");
            dic.Add("dw2880", "0b40");
            dic.Add("db0xf0", "f0");
            dic.Add("dw9", "0009");
            dic.Add("dw18", "0012");
            dic.Add("dw2", "0002");
            dic.Add("dd0", "00000000");
            dic.Add("dd2880", "00000b40");
            dic.Add("db0,0,0x29", "000029");
            dic.Add("dd0xffffffff", "ffffffff");
            dic.Add("db\"hariboteos\"", "48415249424f54454F53");
            dic.Add("db\"fat12\"", "4641543132202020");
            dic.Add("resb18", "00000000000000000000");
            dic.Add("movax,0", "b80000");
            dic.Add("movsp,0x7c00", "bc7c00");
            dic.Add("movax,0x0820", "b80820");
            dic.Add("movch,0", "b500");
            dic.Add("movdh,0", "b600");
            dic.Add("movcl,2", "b102");
            dic.Add("movbx,18*2*cyls-1", "bb02cf");
            dic.Add("callreadfast", "e80033");
            dic.Add("movbyte[0x0ff0],cyls", "c6060ff014");
            dic.Add("jmp0xc200", "e9458d");

            dic.Add("movsi,msg", "be7c90");
            dic.Add("moval,[si]", "8a04");
            dic.Add("addsi,1", "83c601");
            dic.Add("cmpal,0", "3c00");
            dic.Add("jefin", "7409");
            dic.Add("movah,0x0e", "b40e");
            dic.Add("movbx,15", "bb000f");

            dic.Add("jmpputloop", "ebee");
           
            dic.Add("jmpfin", "ebfd");
            dic.Add("db0x0a,0x0a", "0a0a");
            dic.Add("db\"loaderror\"", "6c6f6164206572726F72");
            dic.Add("db0x0a", "0a");
            dic.Add("db0", "00");

            dic.Add("movax,es", "8cc0");
            dic.Add("shlax,3", "c1e003");
            dic.Add("andah,0x7f", "80e47f");
            dic.Add("moval,128", "b080");
            dic.Add("subal,ah", "28e0");
            dic.Add("movah,bl", "88dc");
            dic.Add("cmpbh,0", "80ff00");
            dic.Add("je.skip1", "7402");
            dic.Add("movah,18", "b412");
            dic.Add("cmpal,ah", "38e0");
            dic.Add("jbe.skip2", "7602");
            dic.Add("moval,ah", "88e0");
            dic.Add("movah,19", "b413");
            dic.Add("subah,cl", "28cc");
            dic.Add("jbe.skip3", "7602");
            dic.Add("pushbx", "53");
            dic.Add("movsi,0", "be0000");

            dic.Add("movbx,0", "bb0000");
            dic.Add("movdl,0x00", "b200");
            dic.Add("pushes", "06");
            dic.Add("pushdx", "52");
            dic.Add("pushcx", "51");
            dic.Add("pushax", "50");
            dic.Add("int0x13", "cd13");
            dic.Add("jncnext", "7314");
            dic.Add("cmpsi,5", "83fe05");
            dic.Add("jaeerror", "7395");
            dic.Add("popax", "58");
            dic.Add("popcx", "59");
            dic.Add("popdx", "5a");
            dic.Add("popes", "07");
            dic.Add("jmpretry", "ebdd");
            dic.Add("popbx", "5b");
            dic.Add("shrbx,5", "c1eb05");
            dic.Add("movah,0", "b400");
            dic.Add("addbx,ax", "01c3");
            dic.Add("shlbx,5", "c1e305");
            dic.Add("moves,bx", "8ec3");

            dic.Add("subbx,ax", "29c3");
            dic.Add("jz.ret", "7418");
            dic.Add("addcl,al", "00c1");
            dic.Add("cmpcl,18", "80f912");
            dic.Add("jbereadfast", "7698");
            dic.Add("movcl,1", "b101");
            dic.Add("adddh,1", "80c601");
            dic.Add("cmpdh,2", "80fe02");
            dic.Add("jbreadfast", "728e");

            dic.Add("addch,1", "80c501");
            dic.Add("jmpreadfast", "eb87");
            dic.Add("resb0x7dfe-$", "00000000000000000000");
            dic.Add("db0x55,0xaa", "55aa");



            dic.Add("global_io_hlt,_io_cli,_io_sti,_io_stihlt", "");
            dic.Add("global_io_in8,_io_in16,_io_in32", "");
            dic.Add("global_io_out8,_io_out16,_io_out32", "");
            dic.Add("global_io_load_eflags,_io_store_eflags", "");
            dic.Add("global_load_gdtr,_load_idtr", "");
            dic.Add("global_load_cr0,_store_cr0", "");
            dic.Add("global_load_tr", "");
            dic.Add("global_asm_inthandler20,_asm_inthandler21", "");
            dic.Add("global_asm_inthandler2c,_asm_inthandler0c", "");
            dic.Add("global_asm_inthandler0d,_asm_end_app", "");
            dic.Add("global_memtest_sub", "");
            dic.Add("global_farjmp,_farcall", "");
            dic.Add("global_asm_hrb_api,_start_app", "");
            dic.Add("extern_inthandler20,_inthandler21", "");
            dic.Add("extern_inthandler2c,_inthandler0d", "");
            dic.Add("extern_inthandler0c", "");
            dic.Add("extern_hrb_api", "");






            dic.Add("sti", "fb");


            dic.Add("movedx,[esp+4]", "8b542404");
            dic.Add("moveax,0", "b800000000");
            dic.Add("inal,dx", "ec");

            dic.Add("inax,dx", "66ed");

            dic.Add("ineax,dx", "ed");

            dic.Add("moval,[esp+8]", "8a442408");
            dic.Add("outdx,al", "ee");

            dic.Add("moveax,[esp+8]", "8b442408");
            dic.Add("outdx,ax", "66ef");

            dic.Add("outdx,eax", "ef");

            dic.Add("pushfd", "9c");
            dic.Add("popeax", "58");

            dic.Add("moveax,[esp+4]", "8b442404");
            dic.Add("pusheax", "50");
            dic.Add("popfd", "9d");

            dic.Add("movax,[esp+4]", "668b442404");
            dic.Add("mov[esp+6],ax", "6689442406");
            dic.Add("lgdt[esp+6]", "0f01542406");
            dic.Add("", "_load_idtr:");
            dic.Add("lidt[esp+6]", "0f015c2406");


            dic.Add("ltr[esp+4]", "0f005c2404");
            dic.Add("pushds", "1e");
            dic.Add("pushad", "60");
            dic.Add("moveax,esp", "89e0");
            dic.Add("movax,ss", "668cd0");
            dic.Add("call_inthandler20", "e8[00000000]");
            dic.Add("popad", "61");
            dic.Add("popds", "1f");
            dic.Add("iretd", "cf");
            dic.Add("call_inthandler21", "e8[00000000]");
            dic.Add("call_inthandler2c", "e8[00000000]");
            dic.Add("call_inthandler0c", "e8[00000000]");
            dic.Add("cmpeax,0", "83f800");
            dic.Add("jne_asm_end_app", "0f8500000091");
            dic.Add("addesp,4", "83c404");
            dic.Add("call_inthandler0d", "e8[00000000]");



            dic.Add("pushedi", "57");
            dic.Add("pushesi", "56");
            dic.Add("pushebx", "53");
            dic.Add("movesi,0xaa55aa55", "beaa55aa55");
            dic.Add("movedi,0x55aa55aa", "bf55aa55aa");
            dic.Add("moveax,[esp+12+4]", "8b442410");
            dic.Add("movebx,eax", "89c3");
            dic.Add("addebx,0xffc", "81c300000ffc");
            dic.Add("movedx,[ebx]", "8b13");
            dic.Add("mov[ebx],esi", "8933");
            dic.Add("xordword[ebx],0xffffffff", "8333FF");
            dic.Add("cmpedi,[ebx]", "3b3b");
            dic.Add("jnemts_fin", "7518");
            dic.Add("cmpesi,[ebx]", "3b33");

            dic.Add("mov[ebx],edx", "8913");
            dic.Add("addeax,0x1000", "0500001000");
            dic.Add("cmpeax,[esp+12+8]", "3b442414");
            dic.Add("jbemts_loop", "76d9");
            dic.Add("popebx", "5b");
            dic.Add("popesi", "5e");
            dic.Add("popedi", "5f");

            dic.Add("jmpfar[esp+4]", "ff6c2404");

            dic.Add("callfar[esp+4]", "ff5c2404");


            dic.Add("call_hrb_api", "e8[00000000]");


            dic.Add("addesp,32", "83c420");
            dic.Add("movesp,[eax]", "8b20");
            dic.Add("movdword[eax+4],0", "c7400400000000");


            dic.Add("moveax,[esp+36]", "8b442424");
            dic.Add("movecx,[esp+40]", "8b4c2428");
            dic.Add("movedx,[esp+44]", "8b54242c");
            dic.Add("movebx,[esp+48]", "8b5c2430");
            dic.Add("movebp,[esp+52]", "8b6c2434");
            dic.Add("mov[ebp],esp", "896500");
            dic.Add("mov[ebp+4],ss", "8c5504");

            dic.Add("movds,bx", "8edb");
            dic.Add("movfs,bx", "8ee3");
            dic.Add("movgs,bx", "8eeb");
            dic.Add("orecx,3", "83c903");
            dic.Add("orebx,3", "83cb03");

            dic.Add("pushedx", "52");
            dic.Add("pushecx", "51");

            dic.Add("retf", "cb");
            string rs = "";
            if (!dic.TryGetValue(key.ToLower(), out rs))
            {
                rs = "false";
            }
            return rs;
        }
    }
}
