

.586P														; 
.MODEL FLAT, STDCALL;
includelib kernel32.lib; ������������: ����������� � kernel32
getmin PROTO : DWORD, : DWORD
getmax PROTO : DWORD, : DWORD

 printconsole PROTO : DWORD ; ����� �������� ������ � �������
 SetConsoleTitleA PROTO : DWORD ;

 
 GetStdHandle PROTO :DWORD
 WriteConsoleA PROTO :DWORD,:DWORD,:DWORD,:DWORD,:DWORD
.STACK 4096

.CONST


	

.DATA
	 result1 byte "Min = "
	 result byte 60 dup(0)


		consolehandle dd 0h

	min DWORD   10000
	max DWORD   0
.CODE
	; ----------------FindMin--------------------------
	getmin proc uses eax ebx ecx edi esi, pMas :dword,  amount :dword

	newMin: 
				mov min, eax
				jnz cont

				mov edi, pMas
				mov ecx, amount
		CYCLE:
				mov eax, [edi]
				cmp eax,min
				jl newMin

				cont:
				add edi, type pMas

	
		loop CYCLE                                ;--ecx && ecx!=0
		
	push min ; �������� �����
	push offset result ; ��� ���������
	call int_to_char ; ����� ��������� �������������


	invoke printconsole, offset result1 ; ���������
	invoke printconsole, offset result ; ���������	
		ret 
	getmin ENDP

		; ----------------FindMax--------------------------
	getmax proc uses eax ebx ecx edi esi, mMas :dword,  amount :dword
		mov eax,max
	newMax: 
				mov max, eax
				jnz cont

				mov edi, mMas
				mov ecx, amount
		CYCLE:
				mov eax, [edi]
				cmp eax,max
				jg newMax

				cont:
				add edi, type mMas
		

	
		loop CYCLE                                ;--ecx && ecx!=0
		
	push max ; �������� �����
	push offset result ; ��� ���������
	call int_to_char ; ����� ��������� �������������


	invoke printconsole, offset result1 ; ���������
	invoke printconsole, offset result ; ���������	
		ret 
	getmax ENDP


	; ----------------printconsole--------------------------
printconsole proc uses eax ebx ecx edi esi,
	pstr :dword

		push -11;     ����������� �����
	call GetStdHandle ; �������� handle ->eax
	mov consolehandle, eax
	
	push 0
	push 0
	push sizeof pstr +2;���������� ��������� ����
	push  pstr
	push consolehandle
	call WriteConsoleA

	ret
printconsole ENDP

; ----------------�������������� ����� � ������--------------------------

int_to_char PROC uses eax ebx ecx edi esi,
	pstr : dword, ; ����� ������ ����������
	intfield : sdword ; ����� ��� ��������������
	
	
	mov edi, pstr ; �������� �� pstr � edi
	mov esi, 0 ; ���������� �������� � ���������� 
	mov eax, intfield ; ����� -> � eax
	cdq ; ���� ����� ���������������� � eax �� edx
	mov ebx, 10 ; ��������� ������� ��������� (10) -> ebx
	idiv ebx ; eax = eax/ebx, ������� � edx (������� ����� �� ������)
	test eax, 80000000h ; ��������� �������� ���
	jz plus ; ���� ������������� ����� - �� plus
	neg eax ; ����� ������ ���� eax
	neg edx ; edx = -edx
	mov cl, '-' ; ������ ������ ���������� '-'
	mov[edi], cl ; ������ ������ ���������� '-'
	inc edi ; ++edi

plus : ; ���� ���������� �� �������� 10
	push dx ; ������� -> ����
	inc esi ; ++esi
	test eax, eax ; eax == ?
	jz fin ; ���� ��, �� �� fin
	cdq ; ���� ���������������� � eax �� edx 
	idiv ebx ; eax = eax/ebx, ������� � edx
	jmp plus ; ����������� ������� �� plus

fin : ; � ecx ���-�� �� 0-��� �������� = ���-�� �������� ����������
	mov ecx, esi
	write : ; ���� ������ ����������
	pop bx ; ������� �� ����� -> bx
	add bl, '0' ; ������������ ������ � bl
	mov[edi], bl ; bl -> � ���������
	inc edi ; edi++
	loop write ; ���� (--ecx)>0 ������� �� write

	ret
int_to_char ENDP

END
		