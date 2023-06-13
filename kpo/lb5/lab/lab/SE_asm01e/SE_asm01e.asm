.586
.model flat,stdcall

includelib kernel32.lib
includelib libucrt.lib
includelib SE_ams01d.lib

EXTRN getmin:proc
EXTRN getmax:proc


ExitProcess			PROTO:DWORD
SetConsoleTitleA	PROTO:DWORD
GetStdHandle		PROTO:DWORD
WriteConsoleA		PROTO:DWORD,:DWORD,:DWORD,:DWORD,:DWORD

.stack 4096
.const
consoletitle		db 'SMW Consol',0
.data
consolehandle		dd 0h
array				dword 1,2,3,4,2,9,7,13,9,10
sum					byte  40 dup(0)
.code
	main PROC

		push lengthof array
		push offset array
		call getmin

		mov ebx,eax

		push lengthof array
		push offset array
		call getmax

		add ebx,eax
		push ebx
		push offset sum
		call int_to_char

		push offset consoletitle
		call SetConsoleTitleA

		push -11
		call GetStdHandle
		mov consolehandle,eax

		invoke WriteConsoleA,consolehandle,offset sum,sizeof sum,0,0;
	
		push 0
		call ExitProcess
	main ENDP

	;<-------------------------------int_to_char------------------------------->
	int_to_char PROC uses eax ebx ecx edi esi,
									pstr:dword,				;адрес строки результата
									intfield:dword			;число для преобразования
		mov edi,pstr										
		mov esi,0											;количество символов в результате
		mov eax,intfield									
		cdq													;знак числа распространяется с eax на edx
		mov ebx,10											;основание системы счисления(10)->ebx
		idiv ebx											;eax=eax/ebx,остаток в edx(деление целых со знаком)
		test eax,80000000									;тестируем знаковый бит
		jz	plus											;если положительное число - на plus
		neg eax												;иначе меняем знак eax	
		neg edx												;edx=-edx
		mov cl,'-'											;первый символ результата:'-'
		mov [edi],cl										;первый символ результата:'-'
		inc edi												
	plus:													;цикл разложения по степени 10
		push dx												;остаток->стек
		inc esi												
		test eax,eax										;eax==?
		jz fin												;если да , то на fin
		cdq													;знак числа распространяется с eax на edx
		idiv ebx											;eax=eax/ebx,остаток в edx(деление целых со знаком)
		jmp plus											;безусловный переход на plus
	fin:													;в ecx кол-во не нулевых остатков = кол-ву сімволов результата
		mov ecx,esi											
	write:													;цикл записи результата
		pop bx												;остаток из стека ->bx
		add bl,'0'											;сформировали символ в bl
		mov [edi],bl										;bl ->результат
		inc edi												
	loop write												
		ret													
	int_to_char ENDP										
end main
