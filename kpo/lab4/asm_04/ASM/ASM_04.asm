.586P														; 
.MODEL FLAT, STDCALL;
 includelib kernel32.lib; компановщику: компоновать с kernel32

 ExitProcess PROTO : DWORD; прототип функции для завершения процесса Windows
 MessageBoxA PROTO : DWORD, : DWORD, : DWORD, : DWORD; прототип API - функции MessageBoxA
 
 .STACK 4096; выделение стека
 
 .CONST; сегмент констант
 
.DATA; сегмент данных
 MB_OK  EQU 0; EQU определяет константу
 STR1   DB "TEST ASM", 0; 
STR2   DB "text: sal num: 12", 0

HW     DD ?													; двойное слово длиной 4 байта, неинициализировано

.CODE; сегмент кода

main PROC; точка входа main
START : ; метка
INVOKE MessageBoxA, HW, OFFSET STR2, OFFSET STR1, MB_OK

push - 1; код возврата процесса Windows(параметр ExitProcess)
call ExitProcess; так завешается любой процесс Windows
main ENDP; конец процедуры

end main; конец модуля main