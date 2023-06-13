.586P														; 
.MODEL FLAT, STDCALL;
 includelib kernel32.lib; компановщику: компоновать с kernel32

 includelib "C:\instit\kusr2\kpo\lb5\SE_asm01\Debug\SEAsm01_a.lib"

 ExitProcess PROTO : DWORD; прототип функции для завершения процесса Windows
 getmin PROTO : DWORD, : DWORD
 getmax PROTO : DWORD, : DWORD
 printconsole PROTO : DWORD ; вызов поцедуры вывода в консоль
 SetConsoleTitleA PROTO : DWORD ;

 
 GetStdHandle PROTO :DWORD
 WriteConsoleA PROTO :DWORD,:DWORD,:DWORD,:DWORD,:DWORD
 

 .STACK 4096
 
 .CONST


	

.DATA
 Loc DWORD 0
 ;min WORD   10000

 result1 byte "Min = "
 result byte 60 dup(0)

 minVal DB 0;
 min DWORD   10000
 sn byte ?

	consolehandle dd 0h

.CODE
 Mas DWORD	11, 100, 2
  mmas DWORD	11, 100, 2

	main PROC
	invoke getmax, offset Mas, ( $ - Mas)/4
	invoke getmin, offset mmas, ( $ - mmas)/4
		

	 add eax, 30h
	 mov minVal, al
	
	;mov minVal, eax
	;mov min,al
	 mov sn, al

	 ;mov min, ax
	 


	;push min ; исходное число
	;push offset result ; где результат
	;call int_to_char ; вызов процедуры преобразовани


	;invoke printconsole, offset result1 ; результат
	;invoke printconsole, offset result ; результат
	
	 		







push - 1; код возврата процесса Windows(параметр ExitProcess)
call ExitProcess; так завешается любой процесс Windows
main ENDP; конец процедуры



	

end main; конец модуля main