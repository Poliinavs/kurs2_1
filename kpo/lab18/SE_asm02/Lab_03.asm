.586P														; ������� ������ (��������� Pentium)
.MODEL FLAT, STDCALL										; ������ ������, ���������� � �������
includelib kernel32.lib										; ������������: ����������� � kernel32
includelib user32.lib
ExitProcess PROTO : DWORD									; �������� ������� ��� ���������� �������� Windows
MessageBoxA PROTO : DWORD, : DWORD, : DWORD, : DWORD		; �������� API-������� MessageBoxA

.STACK 4096													; ��������� �����

.CONST														; ������� ��������

.DATA														; ������� ������
MB_OK	EQU	0												; EQU ���������� ���������
STR1	DB	"SE_Asm02",	0									; ������, ������ ������� ������ + ������� ���
STR2	DB	"��������� �������� = ", 0						; ������, ������ ������� ������ + ������� ���
HW		DD	?												; ������� ����� ������ 4 �����, ������������������

NUMBER1	DD	3h ; 3 � HEX
NUMBER2	DD	3h
NUMBER3 DD	1h

.CODE														; ������� ����

main PROC													; ����� ����� main
START	:													; �����
	   
	   mov eax, 0h

	   add eax, NUMBER1
	   add eax, NUMBER2
	   add eax,	NUMBER3
	   add eax, 30h
	   

	   mov STR2 + 21, al

	   INVOKE MessageBoxA, HW, OFFSET STR2, OFFSET STR1, MB_OK

	push - 1												; ��� �������� �������� Windows(�������� ExitProcess)
	call ExitProcess										; ��� ����������� ����� ������� Windows
main ENDP													; ����� ���������
			
end main													; ����� ������ main