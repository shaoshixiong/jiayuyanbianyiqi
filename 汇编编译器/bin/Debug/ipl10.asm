; haribote-ipl
; tab=4

		org		0x7c00			;指明程序装载地址

;以下这段是标准的FAT12格式软盘专用的代码

		jmp		entry
		db		0x90
		db		"SSXOS   "			;启动区的名称可以是任意的字符串（8字节）
		dw		512				;每个扇区（sector）的大小（必须为512字节）
		db		1				;簇（cluster）的大小（必须为1个扇区）
		dw		1				;FAT的起始位置（一般从第一个扇区开始）
		db		2				;FAT的个数（必须为2）
		dw		224				;根目录的大小（一般设成224项）
		dw		2880			;该磁盘的大小(必须是2880扇区)
		db		0xf0			;磁盘的种类（必须是0xf0）
		dw		9				;FAT的长度（必须是9扇区）
		dw		18				;1个磁道（track）有几个扇区（必须是18）
		dw		2				;磁头数（必须是2）
		dd		0				;不使用分区，必须是0xf0）
		dd		2880			;重写一次磁盘大小
		db		0,0,0x29		;意义不明，固定
		dd		0x00397033		;（可能是）卷标号码
		db		"SSX-OS     "		;磁盘的名称（11字节）
		db		"fat12   "		;磁盘格式名称（8字节）
		resb	18				;先空出18字节

;程序主体

entry:
		mov		ax,0			;初始化寄存器
		mov		ss,ax
		mov		sp,0x7c00
		mov		ds,ax

		call	loading			; booting ssxos

;读磁盘	

		mov		ax,0x0820
		mov		es,ax
		mov		ch,0			; 柱面0
		mov		dh,0			; 磁头0
		mov		cl,2			; 扇区2
		mov		bx,18*2-1		; 読み込みたい合計セクタ数
		call	readfast		; 高速読み込み
			push	ax
			push	bx
			call	loadingdot		; 画面にdotを一個増やす
			pop		bx
			pop		ax

		mov		bx,4312+0x8200+2
fatloop:
		add		bx,-2
		cmp		word [bx],0
		jz		fatloop
		mov		ax,bx
		add		ax,-0x8200-5+54+53
		mov		bl,54
		div		bl				; al = ax / bl

		cmp		al,0
		jnz		fatskip1
		mov		al,1
fatskip1:
		cmp		al,33
		jbe		fatskip2
		mov		al,33
fatskip2:
		mov		[0x0ff0],al		; iplがどこまで読んだのかをメモ
		add		al,-1
		jz		fatskip3
		mov		ah,0
		imul	bx,ax,18*2

		mov		ax,0x0c80
		mov		es,ax
		mov		ch,1			; シリンダ1
		mov		dh,0			; ヘッド0
		mov		cl,1			; セクタ1
		call	readfast		; 高速読み込み
fatskip3:
; 読み終わったのでosakkie.sysを実行だ！

		jmp		0xc200

loading:
		mov		si,msg_loading
		call	putloop
		ret
loadingdot:
		mov		si,msg_loadingdot
		call	putloop
		ret
putloop:
		mov		al,[si]
		add		si,1			; siに1を足す
		cmp		al,0
		je		return
		mov		ah,0x0e			; 一文字表示ファンクション
		mov		bx,15			; カラーコード
		int		0x10			; ビデオbios呼び出し
		jmp		putloop
error:
		mov		si,msg_err
		call	putloop
fin:
		hlt						; 何かあるまでcpuを停止させる
		jmp		fin				; 無限ループ

msg_err:
		db		0x0a, 0x0a		; 改行を2つ
		db		"load error... orz"
		db		0x0a			; 改行
		db		0
msg_loading:
		db		"booting osakkie "
		db		0
msg_loadingdot:
		db		"."
		db		0

readfast:	; alを使って出来るだけまとめて読み出す
;	es:読み込み番地, ch:シリンダ, dh:ヘッド, cl:セクタ, bx:最大読み込みセクタ数

		mov		ax,es			; < esからalの最大値を計算 >
		shl		ax,3			; axを32で割って、その結果をahに入れたことになる
		and		ah,0x7f			; ahはahを128で割った余り（512*128=64k）
		mov		al,128			; al = 128 - ah; 一番近い64kb境界まで最大何セクタ入るか
		sub		al,ah

		mov		ah,bl			; < bxからalの最大値をahに計算 >
		cmp		bh,0			; if (bh != 0) { ah = 18; }
		je		.skip1
		mov		ah,18
.skip1:
		cmp		al,ah			; if (al > ah) { al = ah; }
		jbe		.skip2
		mov		al,ah
.skip2:

		mov		ah,19			; < clからalの最大値をahに計算 >
		sub		ah,cl			; ah = 19 - cl;
		cmp		al,ah			; if (al > ah) { al = ah; }
		jbe		.skip3
		mov		al,ah
.skip3:

		push	bx
		mov		si,0			; 记录失败次数的寄存器
retry:
		mov		ah,0x02			; ah=0x02 :;读盘
		mov		bx,0
		mov		dl,0x00			; A驱动器
		push	es
		push	dx
		push	cx
		push	ax
		int		0x13			; 调用磁盘BIOS
		jnc		next			; 没出错的话跳转到next
		add		si,1			; 往si加1
		cmp		si,5			; 比较si与5
		jae		error			; si>=5时，跳转到error
		mov		ah,0x00
		mov		dl,0x00			; A驱动器
		int		0x13			; 重置驱动器
		pop		ax
		pop		cx
		pop		dx
		pop		es
		jmp		retry
next:
		pop		ax
		pop		cx
		pop		dx
		pop		bx				; esの内容をbxで受け取る
		shr		bx,5			; bxを16バイト単位から512バイト単位へ
		mov		ah,0
		add		bx,ax			; bx += al;
		shl		bx,5			; bxを512バイト単位から16バイト単位へ
		mov		es,bx			; これで es += al * 0x20; になる
		pop		bx
		sub		bx,ax
		jz		return
		add		cl,al			; 往cl里加al
		cmp		cl,18			; 比较cl与18
		jbe		readfast		; 如果cl<=18 跳转至readloop
		mov		cl,1
		add		dh,1
		cmp		dh,2
		jb		readfast		; dh < 2 だったらreadloopへ
			push	ax
			push	bx
			call	loadingdot		; 画面にdotを一個増やす
			pop		bx
			pop		ax
		mov		dh,0
		add		ch,1
		jmp		readfast

return:
		ret

		resb	0x7dfe-$		; 填写0x00，直到0x001fe

		db		0x55, 0xaa
