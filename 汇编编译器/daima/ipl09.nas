; haribote-ipl
; TAB=4

CYLS	EQU		20				; 读多远

		ORG		0x7c00			; 指明程序的装载地址

; 以下的记述用于标准FAT12格式的软盘

		JMP		entry
		DB		0x90
		DB		"HARIBOTE"		; 启动区的名称可以是任意的字符串（8字节）
		DW		512				; 每个扇区（sector）的大小（必须为512字节）
		DB		1				; 簇（cluster）的大小（必须为1个扇区）
		DW		1				; FAT的起始位置（一般从第一个扇区开始）
		DB		2				; FAT的个数（必须为2）
		DW		224				; 根目录的大小（一般设成224项）
		DW		2880			; 该磁盘的大小（必须是2880扇区）
		DB		0xf0			; 磁盘的种类（必须是0xf0）
		DW		9				; FAT的长度（必须是9扇区）
		DW		18				; 1个磁道（track）有几个扇区（必须是18）
		DW		2				; 磁头数（必须是2）
		DD		0				; 不适用分区，必须是0
		DD		2880			; 重写一次磁盘大小
		DB		0,0,0x29		; 意义不明，固定
		DD		0xffffffff		; （可能是）标卷号码
		DB		"HARIBOTEOS "	; 磁盘的名称（11字节）
		DB		"FAT12   "		; 磁盘格式名称（8字节）
		RESB	18				; 先空出18字节

; 程序主体

entry:
		MOV		AX,0			; 初始化寄存器
		MOV		SS,AX
		MOV		SP,0x7c00
		MOV		DS,AX

; ディスクを読む

		MOV		AX,0x0820
		MOV		ES,AX
		MOV		CH,0			; 柱面0
		MOV		DH,0			; 磁头0
		MOV		CL,2			; 扇区2
		MOV		BX,18*2*CYLS-1	; 要读取的扇区总数
		CALL	readfast		; 快速装载

; 我读完并运行了UU_OS.sys！

		MOV		BYTE [0x0ff0],CYLS	; 注意IPL读取了多远
		JMP		0xc200

error:
		MOV		AX,0
		MOV		ES,AX
		MOV		SI,msg
putloop:
		MOV		AL,[SI]
		ADD		SI,1			; 给SI加1
		CMP		AL,0
		JE		fin
		MOV		AH,0x0e			; 显示一个文字
		MOV		BX,15			; 指定字符颜色
		INT		0x10			; 调用显卡BIOS
		JMP		putloop
fin:
		HLT						; 让CPU停止,等待指令
		JMP		fin				; 无限循环
msg:
		DB		0x0a, 0x0a		; 换行2次
		DB		"load error"
		DB		0x0a			; 换行
		DB		0

readfast:	; 使用AL尽可能多地阅读
;	ES：读地址，CH：柱面，DH：头，CL：扇区，BX：读取扇区号

		MOV		AX,ES			; <从ES计算AL的最大值>
		SHL		AX,3			; 将AX除以32并将结果放入AH（SHL是左移指令）
		AND		AH,0x7f			; AH是AH的余数除以128（512 * 128 = 64K）
		MOV		AL,128			; AL = 128-AH;有多少扇区可以达到最接近的64KB边界
		SUB		AL,AH

		MOV		AH,BL			; <计算从BX到AH的AL的最大值>
		CMP		BH,0			; if (BH != 0) { AH = 18; }
		JE		.skip1
		MOV		AH,18
.skip1:
		CMP		AL,AH			; if (AL > AH) { AL = AH; }
		JBE		.skip2
		MOV		AL,AH
.skip2:

		MOV		AH,19			; <计算从CL到AH的AL的最大值>
		SUB		AH,CL			; AH = 19 - CL;
		CMP		AL,AH			; if (AL > AH) { AL = AH; }
		JBE		.skip3
		MOV		AL,AH
.skip3:

		PUSH	BX
		MOV		SI,0			; 记录失败次数的寄存器
retry:
		MOV		AH,0x02			; AH=0x02 : 读入磁盘
		MOV		BX,0
		MOV		DL,0x00			; A驱动器
		PUSH	ES
		PUSH	DX
		PUSH	CX
		PUSH	AX
		INT		0x13			; 调用磁盘BIOS
		JNC		next			; 如果没有错误，请转到下一步
		ADD		SI,1			; 往SI加1
		CMP		SI,5			; 比较SI与5
		JAE		error			; SI >= 5 时，跳转到error
		MOV		AH,0x00
		MOV		DL,0x00			; A驱动器
		INT		0x13			; 重置驱动器
		POP		AX
		POP		CX
		POP		DX
		POP		ES
		JMP		retry
next:
		POP		AX
		POP		CX
		POP		DX
		POP		BX				; ESの内容をBXで受け取る
		SHR		BX,5			; BX从16字节到512字节
		MOV		AH,0
		ADD		BX,AX			; BX += AL;
		SHL		BX,5			; BX从512字节单位到16字节单位
		MOV		ES,BX			; 它变为ES + = AL * 0x20;
		POP		BX
		SUB		BX,AX
		JZ		.ret
		ADD		CL,AL			; 将AL添加到CL
		CMP		CL,18			; 比较CL于18
		JBE		readfast		; CL <= 18 跳转至readfast
		MOV		CL,1
		ADD		DH,1
		CMP		DH,2
		JB		readfast		; DH < 2 跳转至readfast
		MOV		DH,0
		ADD		CH,1
		JMP		readfast
.ret:
		RET

		RESB	0x7dfe-$		; 填写0x00,直到0x001fe

		DB		0x55, 0xaa
