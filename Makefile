TOOLPATH = /

MAKE     = $(TOOLPATH)make.exe -r
COPY     = copy

ipl09.bin : ipl09.nas Makefile
	nask.exe ipl09.nas ipl09.bin ipl09.lst
	

img :
	$(MAKE) ipl09.bin
	
run :
	$(MAKE) img