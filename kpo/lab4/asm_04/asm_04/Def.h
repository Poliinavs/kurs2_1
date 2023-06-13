#define asm1 ".586P														; \
\n.MODEL FLAT, STDCALL;\
\n includelib kernel32.lib; компановщику: компоновать с kernel32\
\n\
\n ExitProcess PROTO : DWORD; прототип функции для завершения процесса Windows\
\n MessageBoxA PROTO : DWORD, : DWORD, : DWORD, : DWORD; прототип API - функции MessageBoxA\
\n \
\n .STACK 4096; выделение стека\
\n \
\n .CONST; сегмент констант\
\n \
\n.DATA; сегмент данных\
\n MB_OK  EQU 0; EQU определяет константу\
\n STR1   DB \"TEST ASM\", 0; \n"

#define asm2 "HW     DD ?													; двойное слово длиной 4 байта, неинициализировано\
\n\
\n.CODE; сегмент кода\
\n\
\nmain PROC; точка входа main\
\nSTART : ; метка\
\nINVOKE MessageBoxA, HW, OFFSET STR2, OFFSET STR1, MB_OK\
\n\
\npush - 1; код возврата процесса Windows(параметр ExitProcess)\
\ncall ExitProcess; так завешается любой процесс Windows\
\nmain ENDP; конец процедуры\
\n\
\nend main; конец модуля main"

	