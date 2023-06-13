

.586P														; 
.MODEL FLAT, STDCALL;
includelib kernel32.lib; компановщику: компоновать с kernel32
getmin PROTO : DWORD, : DWORD
getmax PROTO : DWORD, : DWORD

 printconsole PROTO : DWORD ; вызов поцедуры вывода в консоль
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
		
	push min ; исходное число
	push offset result ; где результат
	call int_to_char ; вызов процедуры преобразовани


	invoke printconsole, offset result1 ; результат
	invoke printconsole, offset result ; результат	
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
		
	push max ; исходное число
	push offset result ; где результат
	call int_to_char ; вызов процедуры преобразовани


	invoke printconsole, offset result1 ; результат
	invoke printconsole, offset result ; результат	
		ret 
	getmax ENDP


	; ----------------printconsole--------------------------
printconsole proc uses eax ebx ecx edi esi,
	pstr :dword

		push -11;     стандартный вывод
	call GetStdHandle ; получить handle ->eax
	mov consolehandle, eax
	
	push 0
	push 0
	push sizeof pstr +2;количество выводимых байт
	push  pstr
	push consolehandle
	call WriteConsoleA

	ret
printconsole ENDP

; ----------------преобразование числа в строку--------------------------

int_to_char PROC uses eax ebx ecx edi esi,
	pstr : dword, ; адрес строки результата
	intfield : sdword ; число для преобразования
	
	
	mov edi, pstr ; копирует из pstr в edi
	mov esi, 0 ; количество символов в результате 
	mov eax, intfield ; число -> в eax
	cdq ; знак числа распространяется с eax на edx
	mov ebx, 10 ; основание системы счисления (10) -> ebx
	idiv ebx ; eax = eax/ebx, остаток в edx (деление целых со знаком)
	test eax, 80000000h ; тестируем знаковый бит
	jz plus ; если положительное число - на plus
	neg eax ; иначе мнеяем знак eax
	neg edx ; edx = -edx
	mov cl, '-' ; первый символ результата '-'
	mov[edi], cl ; первый символ результата '-'
	inc edi ; ++edi

plus : ; цикл разложения по степеням 10
	push dx ; остаток -> стек
	inc esi ; ++esi
	test eax, eax ; eax == ?
	jz fin ; если да, то на fin
	cdq ; знак распространяется с eax на edx 
	idiv ebx ; eax = eax/ebx, остаток в edx
	jmp plus ; безусловный переход на plus

fin : ; в ecx кол-во не 0-вых остатков = кол-ву символов результата
	mov ecx, esi
	write : ; цикл записи результата
	pop bx ; остаток из стека -> bx
	add bl, '0' ; сформировали символ в bl
	mov[edi], bl ; bl -> в результат
	inc edi ; edi++
	loop write ; если (--ecx)>0 переход на write

	ret
int_to_char ENDP

END
		