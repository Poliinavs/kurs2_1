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
									pstr:dword,				;����� ������ ����������
									intfield:dword			;����� ��� ��������������
		mov edi,pstr										
		mov esi,0											;���������� �������� � ����������
		mov eax,intfield									
		cdq													;���� ����� ���������������� � eax �� edx
		mov ebx,10											;��������� ������� ���������(10)->ebx
		idiv ebx											;eax=eax/ebx,������� � edx(������� ����� �� ������)
		test eax,80000000									;��������� �������� ���
		jz	plus											;���� ������������� ����� - �� plus
		neg eax												;����� ������ ���� eax	
		neg edx												;edx=-edx
		mov cl,'-'											;������ ������ ����������:'-'
		mov [edi],cl										;������ ������ ����������:'-'
		inc edi												
	plus:													;���� ���������� �� ������� 10
		push dx												;�������->����
		inc esi												
		test eax,eax										;eax==?
		jz fin												;���� �� , �� �� fin
		cdq													;���� ����� ���������������� � eax �� edx
		idiv ebx											;eax=eax/ebx,������� � edx(������� ����� �� ������)
		jmp plus											;����������� ������� �� plus
	fin:													;� ecx ���-�� �� ������� �������� = ���-�� ������� ����������
		mov ecx,esi											
	write:													;���� ������ ����������
		pop bx												;������� �� ����� ->bx
		add bl,'0'											;������������ ������ � bl
		mov [edi],bl										;bl ->���������
		inc edi												
	loop write												
		ret													
	int_to_char ENDP										
end main
