#define asm1 ".586P														; \
\n.MODEL FLAT, STDCALL;\
\n includelib kernel32.lib; ������������: ����������� � kernel32\
\n\
\n ExitProcess PROTO : DWORD; �������� ������� ��� ���������� �������� Windows\
\n MessageBoxA PROTO : DWORD, : DWORD, : DWORD, : DWORD; �������� API - ������� MessageBoxA\
\n \
\n .STACK 4096; ��������� �����\
\n \
\n .CONST; ������� ��������\
\n \
\n.DATA; ������� ������\
\n MB_OK  EQU 0; EQU ���������� ���������\
\n STR1   DB \"TEST ASM\", 0; \n"

#define asm2 "HW     DD ?													; ������� ����� ������ 4 �����, ������������������\
\n\
\n.CODE; ������� ����\
\n\
\nmain PROC; ����� ����� main\
\nSTART : ; �����\
\nINVOKE MessageBoxA, HW, OFFSET STR2, OFFSET STR1, MB_OK\
\n\
\npush - 1; ��� �������� �������� Windows(�������� ExitProcess)\
\ncall ExitProcess; ��� ���������� ����� ������� Windows\
\nmain ENDP; ����� ���������\
\n\
\nend main; ����� ������ main"

	